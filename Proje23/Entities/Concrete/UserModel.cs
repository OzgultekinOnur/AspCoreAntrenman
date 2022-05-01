using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class UserModel : BaseEntity
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Profession { get; set; }
        public int ExamCreated { get; set; } 
        public double Ranks { get; set; } 
        public int TookTheExam { get; set; } 
        public int QuestionAnswered { get; set; } 
        public string Experience { get; set; } 
        public string EnglishLevel { get; set; } 
        public string Gender { get; set; } 
        public string Password { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public string ActivationCode { get; set; }
        public List<Exam> Exams { get; set; }
    }
}