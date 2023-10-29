using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_Banking.Models;

namespace Core_Banking.Service
{
    public interface IEmailService
    {
        Task SendTestEmail(UserEmailOptions userEmailOptions);

        Task SendEmailForEmailConfirmation(UserEmailOptions userEmailOptions);

        Task SendEmailForForgotPassword(UserEmailOptions userEmailOptions);
    }
}
