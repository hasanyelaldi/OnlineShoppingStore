using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Concrete
{
    public class EmailSettings
    {
        public string MailToAddress = "hasanyelaldi.hy@gmail.com";
        public string MailFromAddress = "emaydinlatma@gmail.com";
        public bool UseSsl = true;
        public string Username = "emaydinlatma@gmail.com";
        public string Password = "5757571982";
        public string ServerName = "smtp.gmail.com";
        public int ServerPort = 587;
    }
}
