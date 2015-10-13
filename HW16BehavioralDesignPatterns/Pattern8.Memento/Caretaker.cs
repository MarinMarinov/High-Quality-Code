using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern8.Memento
{
    /// <summary>
    /// The 'Caretaker' class
    /// </summary>
    public class Caretaker
    {
        // May save more than one memento
        // (e.g. Stack for undo/redo functionality)
        public Memento Memento { get; set; }
    }
}
