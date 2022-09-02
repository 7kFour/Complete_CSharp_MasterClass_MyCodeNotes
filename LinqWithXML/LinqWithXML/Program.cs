using System;
using System.Linq;
using System.Xml.Linq;

namespace LinqWithXML {
    internal class Program {

        // XML - Extensible Markup Language
        // a language used to structure data
        // Many programs and websites use XML - it is similar to JSON with a different syntax

        static void Main(string[] args) {

            // applying student structure like wee used in the University Manager to XML instead of a collection
            // don't forget the @
            string studentsXML =
                                @"<Students>
                                    <Student>
                                        <Name>Chuck</Name>
                                        <Age>23</Age>
                                        <University>Yale</University>
                                        <Year>Senior</Year>
                                    </Student>
                                    <Student>
                                        <Name>Cao Cao</Name>
                                        <Age>19</Age>
                                        <University>Stanford</University>
                                        <Year>Freshman</Year>
                                    </Student>
                                    <Student>
                                        <Name>Fitz</Name>
                                        <Age>31</Age>
                                        <University>Yale</University>
                                        <Year>Junior</Year>
                                    </Student>
                                    <Student>
                                        <Name>Amelia</Name>
                                        <Age>20</Age>
                                        <University>Yale</University>
                                        <Year>Sophmore</Year>
                                    </Student>
                                </Students>";

            // XDocument is a class that represents an XML document
            XDocument studentsXDoc = new XDocument();
            // turning our string into an XML document so that we can use LINQ on it
            studentsXDoc = XDocument.Parse(studentsXML);

            // this is looking for the XName - Student in our table above -
            var students = from s in studentsXDoc.Descendants("Student")
                           select new {
                               Name = s.Element("Name").Value,
                               Age = s.Element("Age").Value,
                               Uni = s.Element("University").Value,
                               Year = s.Element("Year").Value
                           };

            Console.WriteLine("List of students:");
            foreach (var s in students) {
                Console.WriteLine($"    Student: {s.Name}\n        Age: {s.Age}\n        Uni: {s.Uni}\n        Year: {s.Year}\n");
            }

            // sorting students by age - youngest to oldest
            var studentAgeSort = from s in students 
                                 orderby s.Age 
                                 select s;

            Console.WriteLine("\nStudents sorted by age:");
            foreach (var a in studentAgeSort) {
                Console.WriteLine($"    Student: {a.Name}\n        Age: {a.Age}\n        Uni: {a.Uni}\n        Year: {a.Year}\n");
            }


            Console.ReadLine();
        }
    }
}
