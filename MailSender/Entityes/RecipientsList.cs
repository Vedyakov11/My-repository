using System.Collections.Generic;

namespace MailSender.Entityes
{
    public class RecipientsList
    {
        public string Name { get; set; }

        public ICollection<Recipient> Recipients { get; set; } = new List<Recipient>();
    }
}
