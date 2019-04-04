using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.Lib.Entityes
{
    public class EmailList
    {
        public string Name { get; set; }
        public ICollection<Email> Emails { get; set; } = new List<Email>();
    }
}
