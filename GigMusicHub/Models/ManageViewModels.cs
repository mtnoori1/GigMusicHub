using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

namespace GigMusicHub.Models
{
    public class IndexViewModel
    {
        public bool HasPassword { get; set; }
        public IList<UserLoginInfo> Logins { get; set; }
        public string PhoneNumber { get; set; }
        public string TwoFactor { get; set; }
        public string BrowserRemembered { get; set; }
    }
    public class ManageLoginsViewModel
    {
        public IList<UserLoginInfo> currentLogins { get; set; }
        public IList<AuthenticationDescription> otherLogins { get; set; }
    }
     public class FactorViewModel
    {
        public string Purpose { get; set; }
    }
    public class  SetPasswordViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} character long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name ="Confirm new Password")]
        [Compare("NewPassword",ErrorMessage ="The New Password and Confirmation Password do not match.")]
        public string ConfirmPassword { get; set; }
    }
    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Current Password")]

        public string OldPassword { get;set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} character long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new Password")]
        [Compare("NewPassword", ErrorMessage = "The New Password and Confirmation Password do not match.")]
        public string ConfirmPassword { get; set; }
    }
    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name ="Phone Number")]
        public string Number { get; set; }

    }
    public class VerifyPhoneNumberViewModel
    {
        [Required]
        [Display(Name ="Code")]
        public string Code { get; set; }
        [Required]
        [Phone]
        [Display(Name ="Phone Number")]
        public string PhoneNumber { get; set; }
    }
    public class ConfigureTwoFactorViewModel
    {
        public string SelectProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem>Providers { get; set; }
    
    }
}
