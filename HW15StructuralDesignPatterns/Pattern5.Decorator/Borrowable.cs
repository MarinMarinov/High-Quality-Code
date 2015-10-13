using System;
using System.Collections.Generic;

namespace Pattern5.Decorator
{
    /// <summary>
    /// The 'ConcreteDecorator' class
    /// </summary>
    internal class Borrowable : Decorator
    {
        private readonly ICollection<string> tenants;

        public Borrowable(AbstractItem abstractItem)
            : base(abstractItem)
        {
            this.tenants = new List<string>();
        }

        public void BorrowItem(string tenantName)
        {
            this.tenants.Add(tenantName);
            this.AbstractItem.CopiesCount--;
        }

        public void ReturnItem(string tenantName)
        {
            this.tenants.Remove(tenantName);
            this.AbstractItem.CopiesCount++;
        }

        public override void Display()
        {
            base.Display();

            Console.WriteLine("List of the tenants: ");
            int counter = 0;
            foreach (string tenant in tenants)
            {
                counter++;
                Console.WriteLine("{0}. {1} ", counter, tenant);
            }
        }
    }
}
