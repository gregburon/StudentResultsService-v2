using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_React_Client.Models
{
    public class StudentResults
    {
        public DateTime Date { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Id { get; set; }
        public string SummaryNotes { get; set; }

        public List<ClassResults> ClassResults { get; set; }
    }

    public class ClassResults
    {
        public DateTime Date { get; set; }
        public int Id { get; set; }
        public string ClassName { get; set; }
        public float GPA { get; set; }

        public static ClassResults BuildClassResults(DateTime date, int id, string className, float GPA)
        {
            ClassResults results = new ClassResults();
            results.Date = date;
            results.Id = id;
            results.ClassName = className;
            results.GPA = GPA;
            return results;
        }
    }
}