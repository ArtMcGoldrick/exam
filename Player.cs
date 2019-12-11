/*************************
 * NAME: Art Mc Goldrick *
 * DATE: 11/12/2019      *
 * DESC: Player display  *
 *************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    //This creates the enum outside of class
    public enum Position { Goalkeeper, Defender, Midfielder, Foward };
    class Player : IComparable
    {
        //Properties
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public Position PreferredPosition { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }

        //Constructor
        public Player() { }
        public Player(string firstName, string surname, Position preferredPosition, int age)
        {
            FirstName = firstName;
            Surname = surname;
            PreferredPosition = preferredPosition;
            Age = age;
        }

        //To string to display
        public override string ToString()
        {
            return $"{FirstName} - {Surname}";
        }

        //For sorting by position
        public int CompareTo(object obj)
        {
            Player that = obj as Player;
            return this.PreferredPosition.CompareTo(that.PreferredPosition);
        }
    }
}
