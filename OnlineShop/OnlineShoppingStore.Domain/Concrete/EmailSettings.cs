using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Concrete
{
    public class EmailSettings
    {
        public string MailToAddress = "andrarlaa2@gmail.com";
        public string MailFromAddress = "andrarlaa2@gmail.com";
        public bool UseSsl = true;
        public string Username = "andrarlaa2@gmail.com";
        public string Password = "andraandra"; // Create your own google app password, In the video I have shown you how to create app password.
        public string ServerName = "smtp.gmail.com";
        public int ServerPort = 587;
    }
}
