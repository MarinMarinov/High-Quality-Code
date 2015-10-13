using System;
using System.Collections.Generic;

namespace Pattern9.Visitor
{
    /// <summary>
    /// The 'ObjectStructure' class
    /// </summary>
    public class LectorsList
    {
        private List<AbstractLector> lectors = new List<AbstractLector>();

        public List<AbstractLector> Lectors
        {
            get { return this.lectors; }
            set { this.lectors = value; }
        }

        public void Attach(AbstractLector lector)
        {
            this.Lectors.Add(lector);
        }

        public void Detach(AbstractLector lector)
        {
            this.Lectors.Remove(lector);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var lector in this.lectors)
            {
                lector.Accept(visitor);
            }

            Console.WriteLine();
        }
    }
}
