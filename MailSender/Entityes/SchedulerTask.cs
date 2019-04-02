using System;

namespace MailSender.Entityes
{
    public class SchedulerTask
    {
        public DateTime Time { get; set; }
        public Sender Sender { get; set; }
        public RecipientsList Recipients { get; set; }
        public EmailList EmailList { get; set; }
    }
}
