using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVALearnAsp4._5MVC.Models
{
    public class ConferenceContextInitalizer : DropCreateDatabaseAlways<ConferenceContext>
    {
        protected override void Seed(ConferenceContext context)
        {
            context.Sessions.Add(new Session()
            {
              SessionID = 1, Title = "ASP MVC 1",
              Abstract = "Abstract",
              Speaker =new Speaker()
              {
                  SpeakerID =1,
                  Name ="SAYAH Imad",
                  EmailAddress ="sayahimadinfo@OUTLOOK.FR"
              }
            });
            context.Sessions.Add(new Session()
            {
                SessionID =2,
                Title = "ASP MVC 2",
                Abstract = "Abstract",
                Speaker = new Speaker()
                {
                    SpeakerID = 2,
                    Name = "SAYAH Imad",
                    EmailAddress = "sayahimadinfo@OUTLOOK.FR"
                }
            });
            context.SaveChanges();
        }
        
    }
}