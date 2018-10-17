using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Address : CivicAddress
    {
        public Address() { }
        public Address(string country, string city, string street, string bulding, string postalCode, string entrance, int departmentNum, string floorLevel)
            : base(street, "", bulding, city, country, floorLevel, postalCode, "")
        {
            DepartmentNum = departmentNum;
        }

        public int DepartmentNum { get; set; }
    }
}
