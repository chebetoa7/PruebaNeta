
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaExamen.Model
{
    public class UserModel
    {
        public int id { get; set; }
        public string name { get; set; } = string.Empty;
        public string username { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string phone { get; set; } = string.Empty;
        public Address? address { get; set; } = null;
        public string website { get; set; } = string.Empty;
        public Company? company { get; set; } = null;
    }
    public class Address
    {
        public string street { get; set; } = string.Empty;
        public string suite { get; set; } = string.Empty;
        public string city { get; set; } = string.Empty;
        public string zipcode { get; set; } = string.Empty;
        public Geo? geo { get; set; } = null;
    }

    public class Company
    {
        public string name { get; set; } = string.Empty;
        public string catchPhrase { get; set; } = string.Empty;
        public string bs { get; set; } = string.Empty;
    }

    public class Geo
    {
        public string lat { get; set; } = string.Empty;
        public string lng { get; set; } = string.Empty;
    }
}
