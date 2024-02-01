using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace Trip_Planner
{
    class tourist
    {
        public tourist(string tName, string tEmail , string tPhone, int tGender , int tAge)
        {
            Name = tName;
            Email = tEmail;
            Phone = tPhone;
            Gender = tGender;
            Age = tAge;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int  Gender { get; set; }
        public int Age { get; set; }

    }

}


