using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVALearnAsp4._5MVC.Models
{
    public class Session
    {
        public Int32 SessionID { get; set; }

        public String Title { get; set; }

        [Required(ErrorMessage ="The abstract is required")]
        [DataType(DataType.MultilineText)]
        public String Abstract { get; set; }

        public Int32 SpeakerID { get; set; }

        public virtual Speaker Speaker { get; set; }

        public virtual List<Comment> Comments { get; set; }

    }
}