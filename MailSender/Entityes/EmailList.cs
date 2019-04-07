using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.Entityes
{
    public class EmailList
    {
        public string Name { get; set; }
        public ICollection<Email> Emails { get; set; } = new List<Email>();
    }
}
