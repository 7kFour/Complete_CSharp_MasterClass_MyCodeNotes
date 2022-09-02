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
                                    </Student>
                                    <Student>
                                        <Name>Cao Cao</Name>
                                        <Age>19</Age>
                                        <University>Stanford</University>
                                    </Student>
                                    <Student>
                                        <Name>Fitz</Name>
                                        <Age>31</Age>
                                        <University>Yale</University>
                                    </Student>
                                    <Student>
                                        <Name>Amelia</Name>
                                        <Age>20</Age>
                                        <University>Yale</University>
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
                               Uni = s.Element("University")
                           };


        }
    }
}
