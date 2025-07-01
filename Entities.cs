using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivingSystemUserDesigned
{
    public class Document
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Authors { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; } // For JOIN //DOCUMENT TYPE
        public string Description { get; set; } // Formerly Abstract
        public string FilePath { get; set; }
        public DateTime DateArchived { get; set; }
        public int YearPublished { get; set; } 
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } // For JOIN
    }

    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class DocumentType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
    }

    public class ActivityLog
    {
        public DateTime Timestamp { get; set; }
        public string Username { get; set; }
        public string Action { get; set; }
        public string DocumentTitle { get; set; }
        public string DocumentType { get; set; }
        public string Details { get; set; }
    }
}
