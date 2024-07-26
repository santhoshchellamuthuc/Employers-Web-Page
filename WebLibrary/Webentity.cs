using System;
using System.ComponentModel.DataAnnotations;

namespace WebLibrary
{
    public class Webentity
    {
        [Key]
        public string name { get; set; }
        public DateTime brithdate { get; set; }
        public long experience { get; set; }
        public long exceptedsalary {get;set;}
    }
}
