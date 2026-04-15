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

        emailMessage.From.Add(new MailboxAddress("Admin Tool", Environment.GetEnvironmentVariable("SMTP_USER")));
        emailMessage.To.Add(new MailboxAddress("", email));
        emailMessage.Subject = subject;
        emailMessage.Body = new TextPart("html") { Text = message };

        using var client = new SmtpClient();
        
        await client.ConnectAsync(
            Environment.GetEnvironmentVariable("SMTP_SERVER"), 
            int.Parse(Environment.GetEnvironmentVariable("SMTP_PORT") ?? "587"), 
            MailKit.Security.SecureSocketOptions.StartTls
        );

        await client.AuthenticateAsync(
            Environment.GetEnvironmentVariable("SMTP_USER"), 
            Environment.GetEnvironmentVariable("SMTP_PASS")
        );

        await client.SendAsync(emailMessage);
        await client.DisconnectAsync(true);
    }
}