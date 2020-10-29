using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FIT5032_Week08A.Models
{
    public class FeedbackModel
    {
        [Display(Name = "Feedback:")]
        [Required(ErrorMessage = "Please provide feedback.")]
        
        [AllowHtml]
        public string FeedbackDetails { get; set; }
    }
}