using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    public class Citizen : IPerson, IIdentifiable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        //public Citizen(string name, int age, string id)
        //{
        //    this.Name = name;
        //    this.Age = age;
        //    this.Id = id;
        //}

    }
}
