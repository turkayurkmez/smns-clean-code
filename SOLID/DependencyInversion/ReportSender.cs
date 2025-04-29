using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class ReportSender
    {
        //   public MailSender MailSender { get; set; }
        private ISender sender;
        public ReportSender(ISender sender)
        {
                this.sender = sender;
        }
        public void Send()
        {
           // MailSender mailSender = new MailSender();
            sender.Send();
        }
    }

    public interface ISender
    {
        void Send();
    }
    public class MailSender : ISender
    {
        public void Send() {
            Console.WriteLine("Mail Gönderildi!");
        }
    }

    public class WhatsAppsSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Whatsapp ile gönderildi");
        }
    }

    public class TelegramSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Telegram....");
        }
    }

}
