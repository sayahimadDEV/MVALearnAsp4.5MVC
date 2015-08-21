using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVALearnAsp4._5MVC.Models
{
    public class Speaker
    {

        public Int32 SpeakerID { get; set; }

        [Required(ErrorMessage ="The {0} is required")]
        [Display(Name ="Speaker name")]
        public String Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public String EmailAddress { get; set; }
        //commentaire
        //public virtual List<Session> ListSession { get; set; }
    }
}