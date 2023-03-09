using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMSCodeFirstApproach.Core.Entities
{
    public class User
    {
        [Key]
        public int UserID { get; set; } 
        public string Name { get; set; }    
        public string phone { get; set; }   
        public string UName { get; set; }   
        public string Password { get; set; }    
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }   
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set;}
        public bool Status { get; set; }    
        public User() { }
        public User(int userID, string name, string phone, string uName, string password, int createdBy, DateTime createdDate, int modifiedBy, DateTime modifiedDate, bool status)
        {
            UserID = userID;
            Name = name;
            this.phone = phone;
            UName = uName;
            Password = password;
            CreatedBy = createdBy;
            CreatedDate = createdDate;
            ModifiedBy = modifiedBy;
            ModifiedDate = modifiedDate;
            Status = status;    
        }
    }
}
