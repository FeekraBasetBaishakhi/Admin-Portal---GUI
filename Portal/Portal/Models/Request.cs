//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Portal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Request
    {
        public int id { get; set; }
        [Required]
        public string coursename { get; set; }
        [Required]
        public string department { get; set; }
        [Required]
        public string status { get; set; }
        public int userid { get; set; }
    
        public virtual User User { get; set; }
    }
}
