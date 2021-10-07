using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Registration.Model
{
    public class Users
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public Language Language { get; set; }
        public Country Country { get; set; }
        public Int64 Pincode { get; set; }
        public string Email { get; set; }
        public Int64 MobileNumber { get; set; }

    }

    public enum Language
    {
        Tamil,
        English,
        Hindi,
        Malayalam,
        Telugu,
    }

    public enum Country
    {
        India,
        England,
        Australia,
        Japan,
        WestIndies,
        Italy,
    }
}
