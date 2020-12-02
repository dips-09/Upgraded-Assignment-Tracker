using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Homework8_AssignmentTracker.Models
{
    public partial class Assignment
    {
        public int AssignmentId { get; set; }
        [Required(ErrorMessage = "Select a valid course name")]
        [Display(Name ="What course?")]
        public Courses Course { get; set; }
        [Display(Name = "Priority")]
        [Required(ErrorMessage = "Select a valid priority")]
        public int? AssignmentPriority { get; set; }
        [Display(Name = "When is it due?")]
        [Required(ErrorMessage = "Enter a due date")]
        public DateTime DueDate { get; set; }
        [Display(Name = "Give the assignment a title:")]
        [Required(ErrorMessage = "Title is required")]
        public string AssignmentTitle { get; set; }
        [Display(Name = "Add some notes about what you need to do to complete it:")]
        [Required(ErrorMessage = "Please add some notes")]
        public string AssignmentNotes { get; set; }
        [Display(Name = "You may add some tags! Either select or add a new.")]
        public string AssignmentTags { get; set; }
        public int IsCompleted { get; set; }
    }

    public enum Courses
    {
        CS461 = 1,
        CS465 = 2,
        ANTH370 = 3,
        MUS102 = 4
    }

}
