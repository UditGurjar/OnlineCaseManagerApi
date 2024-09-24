using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCaseManager.Models.Models
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public int ClientID { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; } // 'Paid', 'Unpaid'
        public DateTime PaymentDate { get; set; }

        public User Client { get; set; }
    }

}
