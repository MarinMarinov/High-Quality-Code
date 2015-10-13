using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern8.Memento
{
    /// <summary>
    /// The 'Originator' class
    /// </summary>
    public class AddressTemplate
    {
        private string name;
        private string phone;
        private string address;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public Memento SaveMemento()
        {
            return new Memento(this.Name, this.Phone, this.Address);
        }

        public void RestoreMemento(Memento memento)
        {
            this.Name = memento.Name;
            this.Phone = memento.Phone;
            this.Address = memento.Address;
        }
     
        public void Show()
        {
            Console.WriteLine(this.Name);
            Console.WriteLine(this.Phone);
            Console.WriteLine(this.Address);
        }
    }
}
