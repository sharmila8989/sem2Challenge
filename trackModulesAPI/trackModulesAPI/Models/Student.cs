//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace trackModulesAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public string Id { get; set; }
        public string studentFname { get; set; }
        public string studentLastname { get; set; }
        public string MacAddress { get; set; }
    
        public virtual WirelessModule WirelessModule { get; set; }
    }
}
