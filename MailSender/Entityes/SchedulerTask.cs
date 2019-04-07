using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.Entityes
{
    public class SchedulerTask
    {
        public DateTime Time { get; set; }
        public Sender Sender { get; set; }
        public RecipientsList Recipients { get; set; }
        public EmailList Emails { get; set; }
    }
}
