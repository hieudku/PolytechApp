using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolytechLibrary
{
    public class Polytech
    {
        // fields
        string name = "";
        string address = "";
        string city = "";
        string region = "";
        int postcode;
        int phoneNumber;
        string twitterAddress = "";

        // properties
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string Region { get => region; set => region = value; }
        public int Postcode { get => postcode; set => postcode = value; }
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string TwitterAddress
        {
            get
            {
                return twitterAddress;
            }
            set
            {
                if (!value.StartsWith('@'))
                {
                    throw new Exception("Twitter handle starts with '@");
                }
                twitterAddress = value;
            }
        }

        // constructors
        

        // override a ToString() method
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine(Address);
            sb.AppendLine(City);
            sb.AppendLine(Region);
            sb.AppendLine(PhoneNumber.ToString());
            sb.AppendLine(TwitterAddress);
            sb.AppendLine(Postcode.ToString());
            return sb.ToString();
        }
    }
}
