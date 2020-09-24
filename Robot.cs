using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    public class Robot : IIdentifiable
    {
        public string Id { get; set; }
        public string Model { get; set; }
        
        //public Robot(string id, decimal Model)
        //{
        //    this.Id = id;
        //    this.Model = Model;
        //}
    }
}
