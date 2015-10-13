using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern8.Memento
{
    public class Memento
    {
        public Memento(string name, string phone, string address)
        {
            this.Name = name;
            this.Phone = phone;
            this.Address = address;
        }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }
    }
}
