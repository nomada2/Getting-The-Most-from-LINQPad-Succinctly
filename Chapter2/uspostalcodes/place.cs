//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace uspostalcodes
{
    using System;
    using System.Collections.Generic;
    
    public partial class place
    {
        public int place_id { get; set; }
        public string place_name { get; set; }
        public string postal_code { get; set; }
        public decimal latitude { get; set; }
        public decimal longitude { get; set; }
        public int county_id { get; set; }
    
        public virtual county county { get; set; }
    }
}
