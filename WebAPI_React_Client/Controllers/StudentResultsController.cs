using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_React_Client.Models;
using System.Web.Http.Cors;

namespace WebAPI_React_Client.Controllers
{
    public class StudentResultsController : ApiController
    {

        [EnableCors("*", "*", "*")]
        public List<StudentResults> GetAll()
        {
            // Note - this is just for illustrative purposes.  Normally we'd go to a database to fetch these results.
            // This is to demonstrate a RESTful API in dotnet and its results.
            List<StudentResults> studentResultsList = new List<StudentResults>();

            StudentResults studentResultsClark = new StudentResults();
            studentResultsClark.Date = DateTime.Now;
            studentResultsClark.FirstName = "Super";
            studentResultsClark.LastName = "Man";
            studentResultsClark.Id = 1243454;
            studentResultsClark.SummaryNotes = "Your student is a pleasure to have in class";
            studentResultsClark.ClassResults = new List<ClassResults>();
            studentResultsClark.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultsClark.Id, "Flying", 4.0f));
            studentResultsClark.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultsClark.Id, "Laser beam vision", 3.1f));
            studentResultsClark.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultsClark.Id, "Kryptonite Resistance", 0.1f));
            studentResultsList.Add(studentResultsClark);

            StudentResults studentResultsLois = new StudentResults();
            studentResultsLois.Date = DateTime.Now;
            studentResultsLois.FirstName = "Lois";
            studentResultsLois.LastName = "Lane";
            studentResultsLois.Id = 9834543;
            studentResultsLois.SummaryNotes = "Lois is smart and resourceful.";
            studentResultsLois.ClassResults = new List<ClassResults>();
            studentResultsLois.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultsLois.Id, "Flying", 0.0f));
            studentResultsLois.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultsLois.Id, "Journalism", 4.0f));
            studentResultsLois.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultsLois.Id, "Establishing personal boundaries", 2.4f));
            studentResultsList.Add(studentResultsLois);

            StudentResults studentResultsGreenLantern = new StudentResults();
            studentResultsGreenLantern.Date = DateTime.Now;
            studentResultsGreenLantern.FirstName = "Green";
            studentResultsGreenLantern.LastName = "Lantern";
            studentResultsGreenLantern.Id = 0025214;
            studentResultsGreenLantern.SummaryNotes = "Green Lantern was a pleasure to have in class.  He might be a little too cocky for his own good but in the end he does the right thing.";
            studentResultsGreenLantern.ClassResults = new List<ClassResults>();
            studentResultsGreenLantern.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultsGreenLantern.Id, "Flying", 3.2f));
            studentResultsGreenLantern.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultsGreenLantern.Id, "Alter-Ego", 3.9f));
            studentResultsGreenLantern.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultsGreenLantern.Id, "Green Power Ring", 4.0f));
            studentResultsList.Add(studentResultsGreenLantern);

            StudentResults studentResultsWonderWoman = new StudentResults();
            studentResultsWonderWoman.Date = DateTime.Now;
            studentResultsWonderWoman.FirstName = "Wonder";
            studentResultsWonderWoman.LastName = "Woman";
            studentResultsWonderWoman.Id = 0215487;
            studentResultsWonderWoman.SummaryNotes = "Wonder Woman brings true fighting spirit and the feeling of hope and unity to the classroom.";
            studentResultsWonderWoman.ClassResults = new List<ClassResults>();
            studentResultsWonderWoman.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultsWonderWoman.Id, "Flying", 3.6f));
            studentResultsWonderWoman.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultsWonderWoman.Id, "Bracers of Themiscyra", 4.0f));
            studentResultsWonderWoman.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultsWonderWoman.Id, "Lasso of Hestia", 4.0f));
            studentResultsWonderWoman.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultsWonderWoman.Id, "Sword of the Amazons", 4.0f));
            studentResultsList.Add(studentResultsWonderWoman);

            StudentResults studentResultBatman = new StudentResults();
            studentResultBatman.Date = DateTime.Now;
            studentResultBatman.FirstName = "Bat";
            studentResultBatman.LastName = "Man";
            studentResultBatman.Id = 9854758;
            studentResultBatman.SummaryNotes = "Batman is the worlds best detective and a formidible opponent in combat.  I would encourage Batman to let his guard down and allow himself to be vulnerable and build positive, lasting relationships.";
            studentResultBatman.ClassResults = new List<ClassResults>();
            studentResultBatman.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultBatman.Id, "Batarang", 3.6f));
            studentResultBatman.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultBatman.Id, "Detective Skills - Advanced", 4.0f));
            studentResultBatman.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultBatman.Id, "Martial Arts", 3.7f));
            studentResultBatman.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultBatman.Id, "Building Loving Relationships", 1.7f));
            studentResultsList.Add(studentResultBatman);

            StudentResults studentResultTheFlash = new StudentResults();
            studentResultTheFlash.Date = DateTime.Now;
            studentResultTheFlash.FirstName = "The";
            studentResultTheFlash.LastName = "Flash";
            studentResultTheFlash.Id = 9854758;
            studentResultTheFlash.SummaryNotes = "Gets his work done quicky! (who would have thought?).  Could maybe take some time and slow down and appreciate life more.";
            studentResultTheFlash.ClassResults = new List<ClassResults>();
            studentResultTheFlash.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultTheFlash.Id, "Super-speed", 3.9f));
            studentResultTheFlash.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultTheFlash.Id, "Time shifting", 3.1f));
            studentResultTheFlash.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultTheFlash.Id, "Phasing", 3.5f));
            studentResultTheFlash.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultTheFlash.Id, "Art Appreciation", 1.2f));
            studentResultsList.Add(studentResultTheFlash);

            StudentResults studentResultGreenArrow = new StudentResults();
            studentResultGreenArrow.Date = DateTime.Now;
            studentResultGreenArrow.FirstName = "Green";
            studentResultGreenArrow.LastName = "Arrow";
            studentResultGreenArrow.Id = 9854758;
            studentResultGreenArrow.SummaryNotes = "Green Arrow is a wonderful student.  Bow skills are fantastic.  Martial arts prowess top notch.  Look forward to him finding a real super power.";
            studentResultGreenArrow.ClassResults = new List<ClassResults>();
            studentResultGreenArrow.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultGreenArrow.Id, "Archery", 4.0f));
            studentResultGreenArrow.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultGreenArrow.Id, "Martial Arts", 3.4f));
            studentResultGreenArrow.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultGreenArrow.Id, "Stealth", 3.8f));
            studentResultGreenArrow.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultGreenArrow.Id, "Invulnerability", 0.2f));
            studentResultsList.Add(studentResultGreenArrow);

            return studentResultsList;
        }
    }
}
