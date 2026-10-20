using System.Xml.Linq;

namespace Task_3
{
    class Student
    {
        public int StudentId;
        public string StudentName;
        public int Age;

        public Student(int studentId, string studentname, int age)
        {
            StudentId = studentId;
            StudentName = studentname;
            Age = age;
        }
        
       public void PrintDetailsStudent()
        {
            Console.WriteLine($"{StudentId}             {StudentName}         {Age}");
        }

        //Student Class End
    }
    class Instrutor
    {
        public int InstructorId;
        public string InstructorName;
        public string Specialization;

        public Instrutor(int instructorid, string instructorname, string specialization)
        {
            InstructorId = instructorid;
            InstructorName = instructorname;
            Specialization = specialization;
        }
        public void PrintDetailsInstrutor()
        {
            Console.WriteLine($"{InstructorId}                {InstructorName}         {Specialization}");
        }

        
    }
    class Course
    {
        public int CourseId;
        public string Title;
        public Instrutor Instrutor;

        public Course(int courseId, string title, Instrutor instrutor)
        {
            CourseId = courseId;
            Title = title;
            Instrutor = instrutor;
        }
        public void PrintDetailsCourse()
        {
            Console.WriteLine($"{CourseId}                {Title}         {Instrutor.InstructorName}");
        }
    }

    class StudentManager
    {
        List<Student> Students;
        List<Course> Courses;
        List<Instrutor> Instrutor;
        public bool AddStudent(Student student)
        {
            return true;
        }
        public bool AddCourse(Course course)
        {
            return true;
        }
        public bool AddInstructor(Instrutor instructor)
        {
            return true;
        }
        //public  Student FindStudent (int studentId)
        //{
        //    Console.WriteLine("m");
        //}
    }

    
    //• 
    //• 
    //• 
    //• 
    //• Course FindCourse(int courseId)
    //• Instructor FindInstructor(int instructorId)
    //• bool EnrollStudentInCourse(int studentId, int courseId)

    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            string findstudent;
            string findcourse;
            
            List <Student> students = new List<Student>();
            List <Instrutor> instrutors = new List<Instrutor>();
            List <Course> course = new List<Course>();


            do
            {
                Console.WriteLine("1 - Add  Student");
                Console.WriteLine("2 - Add  Instrutor");
                Console.WriteLine("3 - Add  Course");
                Console.WriteLine("4 - Enroll Student in Course");
                Console.WriteLine("5 - Show All Students");
                Console.WriteLine("6 - Show All Courses");
                Console.WriteLine("7 - Show All Instructors");
                Console.WriteLine("8 - Find the student by id or name");
                Console.WriteLine("9 - Fine the course by id or name");
                Console.WriteLine("10 - Exit");
                Console.WriteLine("11 - Check if the student enrolled in specific course");
                Console.WriteLine("12 - Return the instructor name by course name");
                Console.Write("Please choose : ");
                a = Convert.ToInt32(Console.ReadLine());

                switch (a)
            {
                case 1:
                    Console.WriteLine("====================");
                    Console.WriteLine("1 - Add  Student");

                    Console.Write("Add  Student ID : ");
                    int studentId=Convert.ToInt32(Console.ReadLine());
                    Console.Write("Add  Student Name : ");
                    string studentname = Console.ReadLine();
                    Console.Write("Add  Student Age : ");
                    int age=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("====================");
                        Student student1 = new Student(studentId, studentname, age);
                        students.Add(student1);



                        break;
                case 2:
                        Console.WriteLine("====================");
                        Console.WriteLine("2 - Add  Instrutor");

                        Console.Write("Add  Instructor ID : ");
                        int instructorid = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Add  Instructor Name : ");
                        string instructorname = Console.ReadLine();
                        Console.Write("Add  Specialization : ");
                        string specialization = Console.ReadLine();
                        Console.WriteLine("====================");
                        Instrutor instruct1 = new Instrutor(instructorid, instructorname, specialization);
                        instrutors.Add(instruct1);



                        break;
                case 3:
                        Console.WriteLine("====================");
                        Console.WriteLine("3 - Add  Course");

                        Console.Write("Add  Course ID : ");
                        int courseId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Add  Course Title : ");
                        string title = Console.ReadLine();
                        Console.Write("Add  instrutor : ");


                        int InstID = Convert.ToInt32(Console.ReadLine());
                        if (InstID > 0)
                        {
                        for (int i = 0; i < instrutors.Count; i++)
                            {
                                if (InstID == instrutors[i].InstructorId)
                                {
                                    Course course1 = new Course(courseId, title, instrutors[i]);
                                    course.Add(course1);
                                }
                            }


                        }

                            
                        Console.WriteLine("====================");
                        

                        break;
                case 4:
                    Console.WriteLine("4 - Enroll Student in Course");
                    break;
                case 5:
                    Console.WriteLine("5 - Show All Students");
                        Console.WriteLine("====================");
                        Console.WriteLine("StudentId     Name          Age");
                        for (int i = 0; i < students.Count; i++)  
                        students[i].PrintDetailsStudent();
                        Console.WriteLine("====================");
                        break;

                case 6:
                    Console.WriteLine("6 - Show All Courses");
                        Console.WriteLine("====================");
                        Console.WriteLine("CourseId     Title          InstructorName");
                        for (int i = 0; i < course.Count; i++)
                            course[i].PrintDetailsCourse();
                        Console.WriteLine("====================");

                        break;
                case 7:
                        Console.WriteLine("7 - Show All Instructors");
                        Console.WriteLine("====================");
                        Console.WriteLine("InstructorId     Name          Specialization");
                        for (int i = 0; i < instrutors.Count; i++)
                        instrutors[i].PrintDetailsInstrutor();
                        Console.WriteLine("====================");


                        break;

                case 8:
                    Console.WriteLine("====================");
                    Console.Write("8 - Find the student by id or name : ");
                        findstudent = Console.ReadLine();
                        for (int i = 0; i < students.Count; i++)
                            if (students[i].StudentName.Contains(findstudent) || students[i].StudentId.ToString().Contains(findstudent))
                                students[i].PrintDetailsStudent();
                        Console.WriteLine("====================");
                        break;

                case 9:
                    Console.WriteLine("9 - Fine the course by id or name");
                        findcourse = Console.ReadLine();
                        for (int i = 0; i < course.Count; i++)
                            if (course[i].Title.Contains(findcourse) || course[i].CourseId.ToString().Contains(findcourse))
                                course[i].PrintDetailsCourse();
                        Console.WriteLine("====================");
                        break;
                case 10:
                    Console.WriteLine("10 - Exit");
                    break;
                case 11:
                    Console.WriteLine("11 - Check if the student enrolled in specific course");
                    break;
                case 12:
                    Console.WriteLine("12 - Return the instructor name by course name");
                    break;

                }
            }
            while (a!=10);
            




        }
    }
}
