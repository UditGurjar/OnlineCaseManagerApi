using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCaseManager.Models.Models
{
    public class Document
    {
        public int DocumentID { get; set; }
        public int CaseID { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public int UploadedBy { get; set; }
        public DateTime UploadDate { get; set; } = DateTime.Now;

        public Case Case { get; set; }
        public User Uploader { get; set; }
    }

}
