using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces {

    // implementing the interface
    internal class Ticket : IEquatable<Ticket> {

        // property to store the duration of the ticket in hours
        protected int DurationInHours { get; set; }

        // constructor
        public Ticket(int dur) {
            DurationInHours = dur;
        }

        // implementing interface to fix CS0535 error - does not implement interface member...
        // https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0535
        // basically checking to see if the Ticket being passed (other) is the same
        // as the Ticket that is calling this method 
        public bool Equals(Ticket other) {

            // this Ticket has a duration and we know what we are passing is also a Ticket so it has
            // a duration in hours as well 
            // if they have the same duration we will assume they are the same ticket
            // so if this Ticket has the same duration as the Ticket passed - return true
            // else return false because we are using the == operator
            return this.DurationInHours == other.DurationInHours;
        }

    }
}
