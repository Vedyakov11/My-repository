using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender.Data2.linq2sql;
using MailSender.Entityes;
using MailSender.Servises.Interfaces;

namespace MailSender.Servises
{
    public class RecipientsDataLinq2Sql : IRecipientsData
    {
        private readonly MailSenderDBDataContext _context;

        public RecipientsDataLinq2Sql(MailSenderDBDataContext Context)
        {
            _context = Context;
        }

        public IEnumerable<Recipient> GetItems()
        {
            var db_recipients = _context.Recipients;
            return db_recipients.Select(r => new Recipient
            {
                Id = r.Id,
                Name = r.Name,
                EmailAddress = r.Email
            });
        }

        public Recipient GetItemById(int id)
        {
            var db_recipient = _context.Recipients.FirstOrDefault(r => r.Id == id);
            if (db_recipient is null)
                return null;
            return new Recipient
            {
                Id = db_recipient.Id,
                Name = db_recipient.Name,
                EmailAddress = db_recipient.Email
            };
        }

        public void Edit(Recipient recipient)
        {
            var db_recipient = _context.Recipients.FirstOrDefault(r => r.Id == recipient.Id);
            if (db_recipient is null) return;

            db_recipient.Name = recipient.Name;
            db_recipient.Email = recipient.EmailAddress;

            _context.SubmitChanges();
        }

    }
}
