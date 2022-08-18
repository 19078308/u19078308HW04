using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19078308HW04.Models
{
    public class Individuals : Members
    {
        private bool _Volunteer;
        public Individuals(string fullname, int numbers, string date, double amount, bool volunteer) : base(fullname, numbers, date, amount)
        {
            _Volunteer = volunteer;
        }
        public bool Volunteer
        {
            get { return _Volunteer; }
            set { _Volunteer = value; }
        }
    }
    

}