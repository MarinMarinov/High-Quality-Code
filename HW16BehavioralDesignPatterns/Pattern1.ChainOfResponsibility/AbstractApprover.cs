using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern1.ChainOfResponsibility
{
    /// <summary>
    /// The 'Handler' abstract class
    /// </summary>
    internal abstract class AbstractApprover
    {
        protected AbstractApprover successor;

        public void SetSuccessor(AbstractApprover successor)
        {
            this.successor = successor;
        }

        public abstract void ProcessRequest(Order order);

    }
}
