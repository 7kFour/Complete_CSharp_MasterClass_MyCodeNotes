using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_to_ObjectsAndQuery_Operators {
    internal class University {
        public int Id { get; set; }
        public string Name { get; set; }

        public void ShowInfo() {
            Console.WriteLine($"University {Name} with Id {Id}");
        }
    }
}
