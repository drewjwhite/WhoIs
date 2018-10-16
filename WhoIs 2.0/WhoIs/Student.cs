using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoIs
{
    public class Student
    {
        //Data for each current student obtained from report csv.
        public string studentNumber;
        public string surname;
        public string givenNames;
        public string tutor;
        public string courseInfo;

        //Provides the students full name for display.
        public override String ToString()
        {
            return givenNames + " " + surname;
        }
       
    }
}
