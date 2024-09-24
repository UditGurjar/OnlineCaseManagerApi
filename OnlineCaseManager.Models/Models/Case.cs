using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCaseManager.Models.Models
{
    public class Case
    {
        public int CaseID { get; set; }
        public string CaseTitle { get; set; }
        public string Description { get; set; }
        public int LawyerID { get; set; }
        public int ClientID { get; set; }
        public string Status { get; set; } // 'Open', 'Closed', etc.
        public DateTime DateOpened { get; set; } = DateTime.Now;

        public User Lawyer { get; set; }
        public User Client { get; set; }
        public ICollection<Document> Documents { get; set; }
        public ICollection<Message> Messages { get; set; }
    }

}
