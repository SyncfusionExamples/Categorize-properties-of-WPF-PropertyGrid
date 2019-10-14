using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyGrid_Category
{
    public class Person
    {
        public Person()
        {
            FirstName = "Carl";
            LastName = "Johnson";
            Age = 30;
            Mobile = 91983467382;
            Email = "carljohnson@gta.com";
            ID = "0005A";
            DOB = new DateTime(1987, 10, 16);     
            Designation = "Team Lead";
        }
              
        [Display(GroupName = "Contact Details")]
        public string Email
        {
            get;

            set;
        }

        [CategoryAttribute("Identity")]
        public string FirstName
        {
            get;

            set;
        }

        public string Designation
        {
            get;

            set;
        }


        [Display(GroupName = "Identity")]
        public string LastName
        {
            get;

            set;
        }


        [CategoryAttribute("Identity")]
        public string ID
        {
            get;

            set;
        }


        [Display(GroupName = "Identity")]
        public DateTime DOB
        {
            get;

            set;
        }

        [CategoryAttribute("Contact Details")]
        public long Mobile
        {
            get;

            set;
        }

        public int Age
        {
            get;

            set;
        }
    }
}
