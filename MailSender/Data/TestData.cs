﻿using MailSender.Entityes;
using MailSender.Servise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.Data
{
    static class TestData
    {
        public static List<Server> Servers { get; } = new List<Server>
        {
            new Server { Name = "Яндекс", Address = "smtp.yandex.ru", UserName = "UserName", Password = Encryptor.Encrypt("Password 1", 3) },
            new Server { Name = "Mail.ru", Address = "smtp.mail.ru", UserName = "UserName", Password = Encryptor.Encrypt("Password 2", 3) },
            new Server { Name = "gmail.com", Address = "smtp.gmail.com", UserName = "UserName", Password = Encryptor.Encrypt("Password 3", 3) }
        };

        public static List<Sender> Senders { get; } = new List<Sender>
        {
            new Sender{ Name = "Иванов", EmailAddress ="ivanov@yandex.ru" },
            new Sender{ Name = "Петров", EmailAddress ="ivanov@yandex.ru" },
            new Sender{ Name = "Сидоров", EmailAddress ="ivanov@yandex.ru" }
        };

    }
}
