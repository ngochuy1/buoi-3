using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi_3
{
    internal class Nguoi
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Phone { get; set; }

        // Constructor để khởi tạo đối tượng Nguoi
        public Nguoi(string lastName, string firstName, string phone)
        {
            LastName = lastName;
            FirstName = firstName;
            Phone = phone;
        }

    }
}
