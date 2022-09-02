using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_to_ObjectsAndQuery_Operators {
    internal class UniversityManager {
        
        // generic collections for Unis and Students
        public List<University> universities;
        public List<Student> students;

        // constructor
        public UniversityManager() { 
            universities = new List<University>();
            students = new List<Student>();

            // adding unis 
            universities.Add(new University { Id = 1, Name = "Yale" });
            universities.Add(new University { Id = 2, Name = "Stanford" });

            // adding students 
            students.Add(new Student { Id = 1, Name = "Carla", Gender = "female", Age = 17, UniversityId = 1 });
            students.Add(new Student { Id = 2, Name = "Mike", Gender = "male", Age = 21, UniversityId = 1 });
            students.Add(new Student { Id = 3, Name = "Leyla", Gender = "female", Age = 19, UniversityId = 2 });
            students.Add(new Student { Id = 4, Name = "James", Gender = "male", Age = 25, UniversityId = 2 });
            students.Add(new Student { Id = 5, Name = "Sara", Gender = "female", Age = 22, UniversityId = 2 });
            students.Add(new Student { Id = 4, Name = "Karl", Gender = "male", Age = 28, UniversityId = 1 });
        }

        // select male students from students list
        public void MaleStudents() {
            // add to list students with gender male
            IEnumerable<Student> maleStudents = from s in students where s.Gender == "male" select s;

            // write names of male students to console
            //Console.Write("Male students: ");
            //foreach (Student x in maleStudents) {
            //    Console.Write($"{x.Name} ");
            //}

            Console.WriteLine("Male students: ");
            foreach (Student m in maleStudents) {
                Console.Write("    ");
                m.ShowInfo();
            }
        }

        // select female students from students list
        public void FemaleStudents() {
            // add to list students with gender female
            IEnumerable<Student> femaleStudents = from s in students where s.Gender == "female" select s;

            Console.WriteLine("Female students: ");
            foreach (Student f in femaleStudents) {
                Console.Write("    ");
                f.ShowInfo();
            }
        }

        public void SortStudentsByAge() {
            // could also use var - it will get the type automatically 
            // using var is easier but a bit slower than statically typing your variables 
            //var sortedStudents = from s in students orderby s.Age select s;
            IEnumerable<Student> sortedStudents = from s in students orderby s.Age select s;

            Console.WriteLine("Students sorted by age: ");
            foreach (Student a in sortedStudents) {
                Console.Write("    ");
                a.ShowInfo();
            }
        }

        // similar to joining tables in SQL 
        // using foreign key of uni id and then checking each student for their uni id 
        // matching the student uni id to the university id and then checking if it's name is Standford
        // then selecting the students that match the criteria and adding them to stnStudent
        public void AllStudentsFromStanford() {
            IEnumerable<Student> stnStudent = from s in students
                                              join uni in universities on s.UniversityId equals uni.Id
                                              where uni.Name == "Stanford"
                                              select s;

            Console.WriteLine("Students from Stanford University: ");
            foreach (Student stan in stnStudent) {
                Console.Write("    ");
                stan.ShowInfo();
            }
        }

        // take user input for uni id and then print out the students that go to that university
        public void UserStudentSearch(int id) {

            string uniName = String.Empty;

            // store students that have an ID matching the user requested university ID 
            IEnumerable<Student> searchStudent = from s in students
                                                 join uni in universities on s.UniversityId equals uni.Id
                                                 where uni.Id == id
                                                 select s;

            // obviously add more branches if you have more than 2 uni names
            if (id == 1) {
                uniName = "Yale";
            } else {
                uniName = "Stanford";
            }

            Console.WriteLine($"Students from user {uniName} University: ");
            foreach (Student ss in searchStudent) {
                Console.Write("    ");
                ss.ShowInfo();
            }
        }

        // this is showing another way to do a join 
        public void StudentAndUniNameCollection() {

            // basically creating a new list that only has the information of the student name and uni name 
            // think of this sorta as creating a new table with a join in SQL
            var newCollection = from s in students 
                                join uni in universities on s.UniversityId equals uni.Id
                                orderby s.Name
                                select new { StudentName = s.Name, UniName = uni.Name };

            Console.WriteLine("New collection: ");
            foreach (var c in newCollection) {
                Console.Write("    ");
                Console.WriteLine($"Student {c.StudentName} from Uni {c.UniName}");
            }
        }
    }
}
