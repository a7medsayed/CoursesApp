//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoursesApp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class trainer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public trainer()
        {
            this.courses = new HashSet<course>();
        }
    
        public int trainer_id { get; set; }
        public string trainer_name { get; set; }
        public string trainer_email { get; set; }
        public string trainer_description { get; set; }
        public System.DateTime trainer_creation_date { get; set; }
        public string trainer_website { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<course> courses { get; set; }
    }
}
