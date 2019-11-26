using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public enum ActivityType {Water,Air,Land} //Radio buttons

    public class Activity : IComparable
    {
        public string Name { get; set; }
        public string Description { get; set; } 
        public DateTime ActivityDate { get; set; }
        public ActivityType TypeOfActivity { get; set; }
        public decimal Cost { get; set; }

        public Activity()
        {

        }

        public int CompareTo(object obj)
        {
            Activity that = (Activity)obj;
            return this.ActivityDate.CompareTo(that.ActivityDate); //Sort by Date
        }

        public override string ToString()
        {
            return $"{Name}-{ActivityDate.ToShortDateString()}"; // To list boxes
        }
    }
}
