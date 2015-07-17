using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IfStatementsRefactoring
{
    public class Potato
    {
        public Potato()
        {
            this.IsPeeled = false;
            this.IsChoped = false;
            this.IsCooked = false;
            this.IsRotten = false;
        }

        public bool IsPeeled { get; set; }

        public bool IsChoped { get; set; }

        public bool IsCooked { get; set; }

        public bool IsRotten { get; set; }

        public void Peel()
        {
            this.IsPeeled = true;
        }

        public void Chop()
        {
            this.IsChoped = true;
        }

        public void Cook()
        {
            this.IsCooked = true;
        }
    }
}
