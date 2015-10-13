using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern6.Adapter
{
    internal class RichCompound : ICompound
    {
        private readonly string chemical;
        private readonly float boilingPoint;
        private readonly float meltingPoint;
        private readonly double molecularWeight;
        private readonly string molecularFormula;

        public RichCompound(string chemical)
        {
            this.chemical = chemical;

            ChemicalDatabank dataBank = new ChemicalDatabank();

            this.boilingPoint = dataBank.GetCriticalPoint(this.chemical, "B");
            this.meltingPoint = dataBank.GetCriticalPoint(this.chemical, "M");
            this.molecularWeight = dataBank.GetMolecularWeight(this.chemical);
            this.molecularFormula = dataBank.GetMolecularStructure(this.chemical);
        }

        public void Display()
        {
            Console.WriteLine("Compound: {0} ------ ", this.chemical);
            Console.WriteLine(" Formula: {0}", this.molecularFormula);
            Console.WriteLine(" Weight : {0}", this.molecularWeight);
            Console.WriteLine(" Melting Point: {0}", this.meltingPoint);
            Console.WriteLine(" Boiling Point: {0}", this.boilingPoint);
            Console.WriteLine();
        }
    }
}
