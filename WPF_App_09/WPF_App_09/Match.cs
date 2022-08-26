using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_App_09 {
    public class Match {

        // class is super basic doesn't even need any constructors

        // Match class properties
        // Score1 goes with Team1 etc
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }

        // could add an array of the players for each team so that when someone presses
        // the select button it would display the names of the starting players for the team 
        // it would go here

        // how many minutes of the match have elapsed
        public int Completion { get; set; }

    }
}
