// See https://aka.ms/new-console-template for more information
using DependencyInversion;

Console.WriteLine("Hello, World!");
MailSender mailSender = new MailSender();
WhatsAppsSender whatsAppsSender = new WhatsAppsSender();
TelegramSender telegramSender = new TelegramSender();


ReportSender reportSender = new ReportSender(mailSender);
ReportSender rpt2 = new ReportSender(telegramSender);
ReportSender rpt3 = new ReportSender(whatsAppsSender);
//reportSender.MailSender = mailSender;
reportSender.Send();
