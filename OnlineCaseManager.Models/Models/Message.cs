using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCaseManager.Models.Models
{
    public class Message
    {
        public int MessageID { get; set; }
        public int CaseID { get; set; }
        public int SenderID { get; set; }
        public int ReceiverID { get; set; }
        public string MessageText { get; set; }
        public DateTime SentAt { get; set; } = DateTime.Now;

        public Case Case { get; set; }
        public User Sender { get; set; }
        public User Receiver { get; set; }
    }

}
