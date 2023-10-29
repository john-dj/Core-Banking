using Core_Banking.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Banking.Repositories
{
    public interface IAccountsRepo
    {
        Task<ApplicationUser> GetUserByEmailAsync(string email);

        Task<IdentityResult> CreateUserAsync(SignUpModel userModel);

        Task<SignInResult> PasswordSignInAsync(SignInModel signInModel);

        Task SignOutAsync();

        //Task<IdentityResult> ChangePasswordAsync(ChangePasswordModel model);

        Task<IdentityResult> ConfirmEmailAsync(string uid, string token);

        Task GenerateEmailConfirmationTokenAsync(ApplicationUser user);

        Task GenerateForgotPasswordTokenAsync(ApplicationUser user);

        //Task<IdentityResult> ResetPasswordAsync(ResetPasswordModel model);
    }
}
