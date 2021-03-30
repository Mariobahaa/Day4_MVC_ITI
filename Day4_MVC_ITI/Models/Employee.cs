using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day4_MVC_ITI.Models
{
    [Table("Employees")]
    public class Employee
    {
        
        [Key]
        [Required(ErrorMessage ="Id is a Required Field")]
        [Range(0, 100000)]
        public int empID  {get; set;}


        [MaxLength(50)]
        [Required(ErrorMessage = "Name is a Required Field")]


        public string Name {get; set;}

        [MaxLength(50)]
        [Required(ErrorMessage = "Username is a Required Field")]

        public string Username {get; set;}

        [MaxLength(50)]
        [Required(ErrorMessage ="you must enter a password")]
        [MinLength(8, ErrorMessage = "password have to be at least 8 chars")]
        [DataType(DataType.Password)]


        public string Password {get; set;}

        [MaxLength(1,ErrorMessage = "must be M or F")]
        [Required(ErrorMessage ="Enter your gender please")]
       
        public char Gender {get; set;}
        [Range(0,100000, ErrorMessage ="Must be a positive number")]
        [DataType("money")]
        [Required]
        public decimal Salary {get; set;}

        [DataType("date")]
        [Required(ErrorMessage ="Join Date should be provided")]

        public DateTime joinDate {get; set;}

        [MaxLength(100)]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z")]
        [Required(ErrorMessage ="Email is Required")]
        public string email {get; set;}

        [StringLength(10)]
        [Required(ErrorMessage = "Please enter your phone")]

        public string phoneNum {get; set;}

    }
}