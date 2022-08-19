using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19078308HW04.Models
{
    public class Organisations : Members
    {
        private string _Type;
        private bool _Status;

        public Organisations(string fullname, int numbers, string date, double amount, string type, bool status ) : base(fullname, numbers, date, amount)
        {
            _Type = type;
            _Status = status; 
        }

        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }
        public bool Status
        {
           get { return _Status; }
           set { _Status = value; }
        }
        
        public override string Decription()
        {
            return base.Decription() + "They are a(an) " + Type; 
        }

        public override string participation()
        {
            return "They are also our members";
        }


    }
}
