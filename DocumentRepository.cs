using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ArchivingSystemUserDesigned
{
    public class DocumentRepository
    {
        private Database db = new Database();

        // Get all documents with type and department names (using stored procedure)
        public List<Document> GetAllDocuments()
        {
            var docs = new List<Document>();
            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("GetAllDocuments", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            docs.Add(new Document
                            {
                                Id = reader.GetInt32("id"),
                                Title = reader.GetString("title"),
                                Authors = reader.GetString("authors"),
                                TypeId = reader.GetInt32("type_id"),
                                TypeName = reader["type_name"].ToString(),
                                Description = reader["description"]?.ToString() ?? "",
                                YearPublished = reader["year_published"] == DBNull.Value ? 0 : Convert.ToInt32(reader["year_published"]),
                                FilePath = reader["file_path"].ToString(),
                                DateArchived = reader.GetDateTime("date_archived"),
                                DepartmentId = reader.IsDBNull(reader.GetOrdinal("department_id")) ? 0 : reader.GetInt32("department_id"),
                                DepartmentName = reader["department_name"] is DBNull ? "" : reader["department_name"].ToString()
                            });
                        }
                    }
                }
            }
            return docs;
        }

        // Insert new document (using stored procedure)
        public void InsertDocument(Document doc)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("InsertDocument", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_title", doc.Title);
                    cmd.Parameters.AddWithValue("p_authors", doc.Authors);
                    cmd.Parameters.AddWithValue("p_type_id", doc.TypeId);
                    cmd.Parameters.AddWithValue("p_description", doc.Description ?? "");
                    cmd.Parameters.AddWithValue("p_year_published", doc.YearPublished);
                    cmd.Parameters.AddWithValue("p_file_path", doc.FilePath);
                    cmd.Parameters.AddWithValue("p_date_archived", doc.DateArchived);
                    cmd.Parameters.AddWithValue("p_department_id", doc.DepartmentId == 0 ? (object)DBNull.Value : doc.DepartmentId);
                    cmd.ExecuteNonQuery();
                }
            }

            LogActivity(
                "The Admin",
                "Added",
                doc.Title,
                doc.TypeName,
                "Added a new document");
        }

        // Update document (using stored procedure)
        public void UpdateDocument(Document doc)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("UpdateDocument", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_id", doc.Id);
                    cmd.Parameters.AddWithValue("p_title", doc.Title);
                    cmd.Parameters.AddWithValue("p_authors", doc.Authors);
                    cmd.Parameters.AddWithValue("p_type_id", doc.TypeId);
                    cmd.Parameters.AddWithValue("p_description", doc.Description ?? "");
                    cmd.Parameters.AddWithValue("p_year_published", doc.YearPublished);
                    cmd.Parameters.AddWithValue("p_file_path", doc.FilePath);
                    cmd.Parameters.AddWithValue("p_date_archived", doc.DateArchived);
                    cmd.Parameters.AddWithValue("p_department_id", doc.DepartmentId == 0 ? (object)DBNull.Value : doc.DepartmentId);
                    cmd.ExecuteNonQuery();
                }
            }
            LogActivity(
                "The Admin",
                "Edited",
                doc.Title,
                doc.TypeName,
                "Edited document details"
            );
        }

        // Delete document (using stored procedure)
        public void DeleteDocument(int id)
        {
            Document doc = GetDocumentById(id);

            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("DeleteDocument", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            if (doc != null)
            {
                DocumentRepository.LogActivity(
                    "The Admin",
                    "Deleted",
                    doc.Title,
                    doc.TypeName,
                    "Deleted document"
                );
            }
        }

        // Dashboard stats (total, by type) (unchanged: still raw SQL)
        public (int total, Dictionary<string, int> byType) GetDocumentStats()
        {
            int total = 0;
            var byType = new Dictionary<string, int>();

            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("GetDocumentStats", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    using (var reader = cmd.ExecuteReader())
                    {
                        // First result set: total count
                        if (reader.Read())
                            total = Convert.ToInt32(reader["total"]);

                        // Move to next result set: type counts
                        if (reader.NextResult())
                        {
                            while (reader.Read())
                            {
                                byType[reader.GetString("type_name")] = reader.GetInt32("count");
                            }
                        }
                    }
                }
            }
            return (total, byType);
        }

        // Get all document types (using stored procedure)
        public List<DocumentType> GetAllDocumentTypes()
        {
            var types = new List<DocumentType>();
            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("GetAllDocumentTypes", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            types.Add(new DocumentType
                            {
                                Id = reader.GetInt32("id"),
                                TypeName = reader.GetString("type_name")
                            });
                    }
                }
            }
            return types;
        }

        // Get all departments (using stored procedure)
        public List<Department> GetAllDepartments()
        {
            var deps = new List<Department>();
            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("GetAllDepartments", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            deps.Add(new Department
                            {
                                Id = reader.GetInt32("id"),
                                Name = reader.GetString("name")
                            });
                    }
                }
            }
            return deps;
        }

        // Get type id by name (still inline SQL, can be made a procedure if desired)
        public int GetTypeIdByName(string typeName)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("GetTypeIdByName", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_type_name", typeName);
                    var o = cmd.ExecuteScalar();
                    return o != null ? Convert.ToInt32(o) : 0;
                }
            }
        }


        // Get department id by name (still inline SQL, can be made a procedure if desired)
        public int GetDepartmentIdByName(string deptName)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("GetDepartmentIdByName", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_dept_name", deptName);
                    var o = cmd.ExecuteScalar();
                    return o != null ? Convert.ToInt32(o) : 0;
                }
            }
        }


        // Get document by ID (using stored procedure)
        public Document GetDocumentById(int id)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("GetDocumentById", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Document
                            {
                                Id = reader.GetInt32("id"),
                                Title = reader.GetString("title"),
                                Authors = reader.GetString("authors"),
                                TypeId = reader.GetInt32("type_id"),
                                TypeName = reader["type_name"].ToString(),
                                Description = reader["description"]?.ToString() ?? "",
                                YearPublished = reader["year_published"] == DBNull.Value ? 0 : Convert.ToInt32(reader["year_published"]),
                                FilePath = reader["file_path"].ToString(),
                                DateArchived = reader.GetDateTime("date_archived"),
                                DepartmentId = reader.IsDBNull(reader.GetOrdinal("department_id")) ? 0 : reader.GetInt32("department_id"),
                                DepartmentName = reader["department_name"] is DBNull ? "" : reader["department_name"].ToString()
                            };
                        }
                    }
                }
            }
            return null; // Not found
        }

        public static class ActivityRepository
        {
            // Get recent activities (using stored procedure)
            public static List<ActivityLog> GetRecentActivities(int count = 20)
            {
                var logs = new List<ActivityLog>();
                using (var conn = new Database().GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand("GetRecentActivities", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_limit", count);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                logs.Add(new ActivityLog
                                {
                                    Timestamp = reader.IsDBNull(reader.GetOrdinal("timestamp")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("timestamp")),
                                    Username = reader.IsDBNull(reader.GetOrdinal("username")) ? "" : reader.GetString(reader.GetOrdinal("username")),
                                    Action = reader.IsDBNull(reader.GetOrdinal("action")) ? "" : reader.GetString(reader.GetOrdinal("action")),
                                    DocumentTitle = reader.IsDBNull(reader.GetOrdinal("document_title")) ? "" : reader.GetString(reader.GetOrdinal("document_title")),
                                    DocumentType = reader.IsDBNull(reader.GetOrdinal("document_type")) ? "" : reader.GetString(reader.GetOrdinal("document_type")),
                                    Details = reader.IsDBNull(reader.GetOrdinal("details")) ? "" : reader.GetString(reader.GetOrdinal("details"))
                                });
                            }
                        }
                    }
                }
                return logs;
            }
        }

        // Log activity (using stored procedure)
        public static void LogActivity(string username, string action, string docTitle, string docType, string details)
        {
            using (var conn = new Database().GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("LogActivity", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_timestamp", DateTime.Now);
                    cmd.Parameters.AddWithValue("p_username", username);
                    cmd.Parameters.AddWithValue("p_action", action);
                    cmd.Parameters.AddWithValue("p_document_title", docTitle);
                    cmd.Parameters.AddWithValue("p_document_type", docType);
                    cmd.Parameters.AddWithValue("p_details", details);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}