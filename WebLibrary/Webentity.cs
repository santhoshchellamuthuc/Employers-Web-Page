using System;
using System.ComponentModel.DataAnnotations;

namespace WebLibrary
{
    public class Webentity
    {
        [Key]
        [Required(ErrorMessage = "Empolyee Name required")][Display(Name="Empolyee Name:")]
        public string name { get; set; }
        [Required(ErrorMessage ="Employee DOB requirea")][Display(Name="DOB:")]
        public DateTime brithdate { get; set; }
        [Required(ErrorMessage ="Year of experience required")]
        public long experience { get; set; }
        [Required][Display(Name = "Expected CTC:")]
        public long exceptedsalary {get;set;}
    }
}
