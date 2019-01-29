//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CourseRegister.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Enrollment
    {
        public int id { get; set; }

        [Display(Name = "Student Id")]
        public string studentId { get; set; }

        [Display(Name = "Course Id")]
        public int courseId { get; set; }

        [Range(0, 100)]
        [Display(Name = "Score")]
        public int score { get; set; }


        public virtual Course Course { get; set; }

        public virtual Student Student { get; set; }
    }
}