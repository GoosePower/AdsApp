//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Answer { get; set; }
        public string Variants { get; set; }
        public int AdId { get; set; }
    
        public virtual Ad Ad { get; set; }
    }
}
