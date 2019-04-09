using MailSender.Entityes.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.Entityes
{
    public class Recipient : Human, IDataErrorInfo
    {
        public override string Name
        {
            get => base.Name;
            set
            {
                if (value == null) 
                    throw new ArgumentException(nameof(value));
                base.Name = value;
            }
        }

        string IDataErrorInfo.Error => "";

        string IDataErrorInfo.this[string PropertyName]
        {
            get
            {
                switch (PropertyName)
                {
                    case nameof(Name):
                        if (Name == null) return "Имя не может быть пустой ссылкой";
                        if (Name == "") return "Имя не может быть пустой строкой";
                        if (Name.Length < 3) return "Имя не может быть меньше 3 символов";
                        break;
                }

                return "";
            }
        }
    }
}
