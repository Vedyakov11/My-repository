using System.Collections.Generic;

namespace MailSender.Lib.Entityes
{
    public class EmailList
    {
        public string Name { get; set; }
        public ICollection<Email> Emails { get; set; } = new List<Email>();
    }
}
