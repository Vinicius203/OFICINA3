using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDB.domain.Entities
{
    public class Director
    {
        public int ID { get; set; }
        public string first_name { get; set; }
        public string last_name{ get; set; }
        public DateTime birthdate { get; set; }

    }
}
