using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfileStudent.Entity
{
    public class Student
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string POB { get; set; }
        public SEXUAL Sexual { get; set; }
        public string PathAvatar { get; set; }

        public List<LearningHistory> ListLearningHistory { get; set; }

        /// <summary>
        /// Tạo 1 sinh viên giả
        /// </summary>
        /// <returns></returns>
        public static Student CreateFakeStudent()
        {
            Student student = new Student
            {
                ID = "101T10211111",
                FirstName = "Nguyễn",
                LastName = "Dũng",
                DOB = new DateTime(2002, 2, 2),
                POB = "Huế",
                Sexual = SEXUAL.Male,
                PathAvatar = Application.StartupPath + "\\Img\\logo.png",
            };
            List<LearningHistory> histories = new List<LearningHistory>();
            for(int i = 1; i <= 12; i++)
            {
                LearningHistory history = new LearningHistory
                {
                    ID = i.ToString(),
                    Lop = i.ToString(),
                    Truong = "Trường Quốc Học",
                    HocLuc = "Giỏi",
                    Address = "TP Huế"
                };
                histories.Add(history);
            }
            student.ListLearningHistory = histories;
            return student;
        }
    }

    public enum SEXUAL
    {
        Male, Female, Other
    }
}
