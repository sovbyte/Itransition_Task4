using MailKit.Net.Smtp;
using MimeKit;

namespace Itransition_Task4.Services;

public interface IEmailService
{
    Task SendEmailAsync(string email, string subject, string message);
}

public class EmailService : IEmailService
{
    public async Task SendEmailAsync(string email, string subject, string message)
    {
        var emailMessage = new MimeMessage();

        var smtpUser = Environment.GetEnvironmentVariable("SMTP_USER") ?? "";
        var smtpPass = Environment.GetEnvironmentVariable("SMTP_PASS") ?? "";
        var smtpServer = Environment.GetEnvironmentVariable("SMTP_SERVER") ?? "";
        var smtpPort = Environment.GetEnvironmentVariable("SMTP_PORT") ?? "587";

        emailMessage.From.Add(new MailboxAddress("Admin Tool", smtpUser));
        emailMessage.To.Add(new MailboxAddress("", email));
        emailMessage.Subject = subject;
        emailMessage.Body = new TextPart("html") { Text = message };

        using var client = new SmtpClient();
        
        if (string.IsNullOrEmpty(smtpUser) || string.IsNullOrEmpty(smtpPass))
        {
            throw new Exception("SMTP credentials are missing in .env file!");
        }

        await client.ConnectAsync(smtpServer, int.Parse(smtpPort), MailKit.Security.SecureSocketOptions.StartTls);
        await client.AuthenticateAsync(smtpUser, smtpPass);
        await client.SendAsync(emailMessage);
        await client.DisconnectAsync(true);
    }
}