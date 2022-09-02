using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_to_ObjectsAndQuery_Operators {
    internal class Student {
        // students id at their university
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        // Foreign Key 
        // id for which university a student belongs to
        public int UniversityId { get; set; }

        public void ShowInfo() {
            Console.WriteLine($"Student {Name} with the Id {Id}, Gender {Gender} from University with Id {UniversityId}");
        }
    }
}
