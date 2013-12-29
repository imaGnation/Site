using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Site.Models
{
     [MetadataType(typeof(SystemUserMetaData))]
    public partial class SystemUser
    {

         //First Name
        [Required(ErrorMessage = "First Name is Required")]
        [Display(Name = "First Name:")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "First Name must be atleast 3 characters long!")]
        public string FirstName { get; set; }

         //Last Name
        [Required(ErrorMessage = "Last Name is Required")]
        [Display(Name = "Last Name:")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Last Name must be atleast 3 characters long!")]
        public string LastName { get; set; }

         //Email Address
        [Required(ErrorMessage = "Email Address is Required")]
        [Display(Name = "Email Address:")]
        [StringLength(50, ErrorMessage = "Email Address must be atleast 6 characters long!")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "incorrect email address!")]
        public string EmailAddress { get; set; }

         //Contact Number
        [Required(ErrorMessage = "Contact Number is Required")]
        [RegularExpression(@"^(\+27[\\s]?\d{9})$", ErrorMessage = "Example: +27783824048")]
        [Display(Name = "Contact Number:")]
        public string ContactNo { get; set; }


         //Profile Picture
        public string ProfilePicture { get; set; }

         //Password
        [Required(ErrorMessage = "Password is Required")]
        [Display(Name = "Password:")]
        [StringLength(150, MinimumLength = 6, ErrorMessage = "Password must be atleast 6 characters long!")]
        public string Password { get; set; }

         //Compare Password
        [System.Web.Mvc.Compare("Password", ErrorMessage = "Passwords must match")]
        public string ConfirmPassword { get; set; }

         //User Role
        public int UserRoleID { get; set; }
    }

    public class SystemUserMetaData
    {
        [Remote("IsUserNameAvailable", "User", ErrorMessage = "Email is already in use!")]
        public string Email_Address { get; set; }

        [Remote("IsAvailableContact_No", "User", ErrorMessage = "Contact Number is already in use!")]
        public string Contact_No { get; set; }

    }
}