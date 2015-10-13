using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern9.Visitor
{
    /// <summary>
    /// The 'Element' class
    /// </summary>
    public abstract class AbstractLector
    {
        protected AbstractLector()
        {
        }

        protected AbstractLector(string name, decimal income, int vacationDays)
        {
            this.Name = name;
            this.Income = income;
            this.VacationDays = vacationDays;
            this.WorkFromHomeDays = 0;
        }

        public string Name { get; set; }

        public decimal Income { get; set; }

        public int VacationDays { get; set; }

        public int WorkFromHomeDays { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
