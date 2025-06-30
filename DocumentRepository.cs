using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivingSystemUserDesigned
{
    public class DocumentRepository
    {
        private Database db = new Database();

        // Get all documents with type and department names
        public List<Document> GetAllDocuments()
        {
            var docs = new List<Document>();
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT d.*, dt.type_name, dep.name as department_name 
                    FROM documents d
                    LEFT JOIN document_types dt ON d.type_id = dt.id
                    LEFT JOIN departments dep ON d.department_id = dep.id
                    ORDER BY d.date_archived DESC";
                using (var cmd = new MySqlCommand(sql, conn))
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
                            FilePath = reader["file_path"].ToString(),
                            DateArchived = reader.GetDateTime("date_archived"),
                            DepartmentId = reader.IsDBNull(reader.GetOrdinal("department_id")) ? 0 : reader.GetInt32("department_id"),
                            DepartmentName = reader["department_name"] is DBNull ? "" : reader["department_name"].ToString()
                        });
                    }
                }
            }
            return docs;
        }

        // Insert new document
        public void InsertDocument(Document doc)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string sql = @"
                    INSERT INTO documents 
                    (title, authors, type_id, description, file_path, date_archived, department_id)
                    VALUES (@title, @authors, @type_id, @description,
                            @file_path, @date_archived, @department_id)";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@title", doc.Title);
                    cmd.Parameters.AddWithValue("@authors", doc.Authors);
                    cmd.Parameters.AddWithValue("@type_id", doc.TypeId);
                    cmd.Parameters.AddWithValue("@description", doc.Description ?? "");
                    cmd.Parameters.AddWithValue("@file_path", doc.FilePath);
                    cmd.Parameters.AddWithValue("@date_archived", doc.DateArchived);
                    cmd.Parameters.AddWithValue("@department_id", doc.DepartmentId == 0 ? (object)DBNull.Value : doc.DepartmentId);
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

        // Update document
        public void UpdateDocument(Document doc)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string sql = @"
                    UPDATE documents SET
                        title=@title, authors=@authors,
                        type_id=@type_id, description=@description,
                        file_path=@file_path, date_archived=@date_archived, department_id=@department_id
                    WHERE id=@id";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", doc.Id);
                    cmd.Parameters.AddWithValue("@title", doc.Title);
                    cmd.Parameters.AddWithValue("@authors", doc.Authors);
                    cmd.Parameters.AddWithValue("@type_id", doc.TypeId);
                    cmd.Parameters.AddWithValue("@description", doc.Description ?? "");
                    cmd.Parameters.AddWithValue("@file_path", doc.FilePath);
                    cmd.Parameters.AddWithValue("@date_archived", doc.DateArchived);
                    cmd.Parameters.AddWithValue("@department_id", doc.DepartmentId == 0 ? (object)DBNull.Value : doc.DepartmentId);
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

        // Delete document
        public void DeleteDocument(int id)
        {
            
            Document doc = GetDocumentById(id);

            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("DELETE FROM documents WHERE id=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            if (doc != null)
            {
                DocumentRepository.LogActivity(
                    "The Admin", // 
                    "Deleted",
                    doc.Title,
                    doc.TypeName,
                    "Deleted document"
                );
            }
        }

        // Dashboard stats (total, by type)
        public (int total, Dictionary<string, int> byType) GetDocumentStats()
        {

            int total = 0;
            var byType = new Dictionary<string, int>();
            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM documents", conn))
                {
                    total = Convert.ToInt32(cmd.ExecuteScalar());
                }
                string sql = @"
            SELECT dt.type_name, COUNT(*) as count
            FROM documents d
            JOIN document_types dt ON d.type_id = dt.id
            GROUP BY dt.type_name";
                using (var cmd = new MySqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        byType[reader.GetString("type_name")] = reader.GetInt32("count");
                }
            }
            return (total, byType);

        }

        // Get all document types
        public List<DocumentType> GetAllDocumentTypes()
        {
            var types = new List<DocumentType>();
            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM document_types", conn))
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
            return types;
        }

        // Get all departments
        public List<Department> GetAllDepartments()
        {
            var deps = new List<Department>();
            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT * FROM departments", conn))
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
            return deps;
        }

        public int GetTypeIdByName(string typeName)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT id FROM document_types WHERE type_name=@type", conn))
                {
                    cmd.Parameters.AddWithValue("@type", typeName);
                    var o = cmd.ExecuteScalar();
                    return o != null ? Convert.ToInt32(o) : 0;
                }
            }
        }

        public int GetDepartmentIdByName(string deptName)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand("SELECT id FROM departments WHERE name=@name", conn))
                {
                    cmd.Parameters.AddWithValue("@name", deptName);
                    var o = cmd.ExecuteScalar();
                    return o != null ? Convert.ToInt32(o) : 0;
                }
            }
        }
        public Document GetDocumentById(int id)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string sql = @"
            SELECT d.*, dt.type_name
            FROM documents d
            LEFT JOIN document_types dt ON d.type_id = dt.id
            WHERE d.id = @id";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
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
                                FilePath = reader["file_path"].ToString(),
                                DateArchived = reader.GetDateTime("date_archived"),
                                DepartmentId = reader.IsDBNull(reader.GetOrdinal("department_id")) ? 0 : reader.GetInt32("department_id"),
                                DepartmentName = "" // not used for logging
                            };
                        }
                    }
                }
            }
            return null; // Not found
        }

        public static class ActivityRepository
        {
            public static List<ActivityLog> GetRecentActivities(int count = 20)
            {
                var logs = new List<ActivityLog>();
                using (var conn = new Database().GetConnection())
                {
                    conn.Open();
                    var cmd = new MySqlCommand("SELECT timestamp, username, action, document_title, document_type, details FROM activity_log ORDER BY timestamp DESC LIMIT @count", conn);
                    cmd.Parameters.AddWithValue("@count", count);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            logs.Add(new ActivityLog
                            {
                                Timestamp = reader.IsDBNull(0) ? DateTime.MinValue : reader.GetDateTime(0),
                                Username = reader.IsDBNull(1) ? "" : reader.GetString(1),
                                Action = reader.IsDBNull(2) ? "" : reader.GetString(2),
                                DocumentTitle = reader.IsDBNull(3) ? "" : reader.GetString(3),
                                DocumentType = reader.IsDBNull(4) ? "" : reader.GetString(4),
                                Details = reader.IsDBNull(5) ? "" : reader.GetString(5)
                            });
                        }
                    }
                }
                return logs;
            }
        }

        public static void LogActivity(string username, string action, string docTitle, string docType, string details)
        {
            using (var conn = new Database().GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand("INSERT INTO activity_log (timestamp, username, action, document_title, document_type, details) VALUES (@ts, @user, @act, @title, @type, @details)", conn);
                cmd.Parameters.AddWithValue("@ts", DateTime.Now);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@act", action);
                cmd.Parameters.AddWithValue("@title", docTitle);
                cmd.Parameters.AddWithValue("@type", docType);
                cmd.Parameters.AddWithValue("@details", details);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
