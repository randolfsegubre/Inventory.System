using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Inventory.System.Data.Entity
{
    public class Users
    {
        [Key]
        public int User_Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public UserDetails Details { get; set; }
    }

    public class UserDetails
    {
        [Key]
        public int UserDetails_Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
    }
}
