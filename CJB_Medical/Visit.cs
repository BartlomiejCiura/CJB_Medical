//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CJB_Medical
{
    using System;
    using System.Collections.Generic;
    
    public partial class Visit
    {
        public int Id { get; set; }
        public string Diagnosis { get; set; }
        public string Description { get; set; }
        public string Recommendations { get; set; }
        public System.DateTime From { get; set; }
        public System.DateTime To { get; set; }
        public int Doctor_Id { get; set; }
    
        public virtual User User { get; set; }
        public virtual Attachment Attachment { get; set; }

        public override string ToString()
        {
            return From.ToShortTimeString();
        }
    }
}
