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
    
    public partial class course_lessons
    {
        public int course_lessons_id { get; set; }
        public string course_lessons_title { get; set; }
        public int course_lessons_course_id { get; set; }
        public Nullable<int> course_lessons_order_number { get; set; }
    
        public virtual course course { get; set; }
    }
}