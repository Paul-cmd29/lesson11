using System;

namespace lesson11
{
    class School
    {
        static void Main(string[] args)
        {

            StudentID student = new StudentID();
            Console.WriteLine(student.Hello("Hello Dear" + " "));


            Console.WriteLine("Classmate: ");
            ClassRoom a = new ClassRoom();
            a.Students();
            a.newstudenst = "Ivan Bravo";
            Console.WriteLine(a.newstudenst);

            Schedule b = new Schedule();
            Console.WriteLine("Standart Schedule:");
            b.StandartSchedule();
            Console.WriteLine("Updated Schedule:");
            b.LessonName = "Math";
            b.DayOfTheWeek = "Monday";
            b.TimeOfLesson = 13.30;

            Console.WriteLine(b.LessonName + " - " + b.DayOfTheWeek + " " + b.TimeOfLesson);

            Teachers c = new Teachers();
            Console.WriteLine("Teachers info:");
            c.TeacherInfo();
            Console.WriteLine("Good Luck!");
        }
    }
    class StudentID
    {
        public string Hello(string message)
        {
            Console.WriteLine("Enter yor name!");
            string name = Console.ReadLine();
            return message + name;
        }    

        
    }

    class ClassRoom
    {
        private string NewStudents;//private field name should start from lowercase letter
        public string newstudenst//property should start from capital letter. Also property name must be the same as related private field name - just started from capital letter
        {
            get { return NewStudents; }
            set { NewStudents = value; }
        }
        public void Students()//name of the void should be more meaningful - i.e. GetStudents or PrintStudentsInfo etc.
        {
            string[] pupils = { "Joanna Smith", "Jadon Shaw", "Jay Wisher", "Anasteisha Ridewald", "Jack Stones" };
            foreach(var a in pupils)
            {
                 Console.WriteLine(a);
            }
          //too big whitespace  

        }
        
    }

    class Schedule
    {
        public void StandartSchedule()
        {
            string[] SSchedule = { "Monday 12:00 - Math", "Thusday 13:30 - Science", "Friday 14:00 - History" };
            Console.WriteLine(SSchedule[0]);
            Console.WriteLine(SSchedule[1]);
            Console.WriteLine(SSchedule[2]);
        }
        private string lesson;
        public string LessonName//property should start from capital letter. Also property name must be the same as related private field name - just started from capital letter
        {
            get { return lesson; }
            set { lesson = value; }
        }

        private string dayofweek;
        public string DayOfTheWeek//property should start from capital letter. Also property name must be the same as related private field name - just started from capital letter
        {
            get { return dayofweek; }
            set { dayofweek = value; }
        }

        private double timeoflesson;
        public double TimeOfLesson//property should start from capital letter. Also property name must be the same as related private field name - just started from capital letter
        {
            get { return timeoflesson; }
            set { timeoflesson = value; }
        }

    }

    class Teachers
    {
        public void TeacherInfo()
        {
            string[] Techs = { "Natalia Johnson - Math", "Stepan Stetham - Science", "Declan Ivanov - History" };
            foreach (var b in Techs)
            {
                Console.WriteLine(b);
            }
        }
    }
}
//checked
