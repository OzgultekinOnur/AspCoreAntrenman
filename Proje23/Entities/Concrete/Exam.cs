using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Exam : BaseEntity
    {
        public string Text { get; set; }
        public string Text2 { get; set; }
        public string Question1 { get; set; }
        public string Question2 { get; set; }
        public string Question3 { get; set; }
        public string Question4 { get; set; }

        //--------
        public string Question1Answers1 { get; set; }

        public string Question1Answers2 { get; set; }
        public string Question1Answers3 { get; set; }
        public string Question1Answers4 { get; set; }

        //--
        public string Question2Answers1 { get; set; }

        public string Question2Answers2 { get; set; }
        public string Question2Answers3 { get; set; }
        public string Question2Answers4 { get; set; }

        //--
        public string Question3Answers1 { get; set; }

        public string Question3Answers2 { get; set; }
        public string Question3Answers3 { get; set; }
        public string Question3Answers4 { get; set; }

        //--
        public string Question4Answers1 { get; set; }

        public string Question4Answers2 { get; set; }
        public string Question4Answers3 { get; set; }
        public string Question4Answers4 { get; set; }

        //________________________________________
        public string Q1Correct1 { get; set; }

        public string Q2Correct2 { get; set; }
        public string Q3Correct3 { get; set; }
        public string Q4Correct4 { get; set; }
        public string Date { get; set; }
        public int UserModelId { get; set; }
        public UserModel UserModel { get; set; }
    }
}