using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.Lib.Entityes
{
    public class RecipientsList
    {
        public string Name { get; set; }
        public ICollection<Recipient> Recipients { get; set; } = new List<Recipient>();
    }
}
