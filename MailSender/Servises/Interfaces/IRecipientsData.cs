using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender.Entityes;

namespace MailSender.Servises.Interfaces
{
    public interface IRecipientsData
    {
        IEnumerable<Recipient> GetItems();

        Recipient GetItemById(int id);

        void Edit(Recipient item);
    }
}
