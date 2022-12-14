using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
