using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCaseManager.Models.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string UserType { get; set; } // 'Admin', 'Client', 'Lawyer', etc.
        public DateTime DateCreated { get; set; } = DateTime.Now;

        public ICollection<Case> Cases { get; set; }
    }

}
