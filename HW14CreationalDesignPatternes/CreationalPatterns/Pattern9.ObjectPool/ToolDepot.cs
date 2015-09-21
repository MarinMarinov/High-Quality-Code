using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern9.ObjectPool
{
    /// <summary>
    /// The Pool class is the most important class in the object pool design pattern. It controls access to the
    /// pooled objects, maintaining a list of available objects and a collection of objects that have already been
    /// requested from the pool and are still in use. The pool also ensures that objects that have been released
    /// are returned to a suitable state, ready for the next time they are requested.
    /// </summary>
    /// <typeparam name="T">The pool objects type.</typeparam>
    public class ToolDepot<T> where T: IDisposable, new()
    {
        public readonly List<T> availableTools = new List<T>();
        public readonly List<T> usedTools = new List<T>();

        public ToolDepot()
        {
        }

        public T GetTool()
        {
            lock (this.availableTools)
            {
                if (this.availableTools.Count != 0)
                {
                    T tool = this.availableTools[0];
                    this.usedTools.Add(tool);
                    this.availableTools.Remove(tool);
                    //this.availableTools.RemoveAt(0); // Check for the proper use of Remove
                    
                    return tool;
                }
                else
                {
                    T tool = new T();
                    this.usedTools.Add(tool);

                    return tool;
                }
            }
        }

        public void ReleaseTool(T tool)
        {
            tool.Dispose();

            lock (this.availableTools) // may be this.usedTools is more proper?
            {
                this.availableTools.Add(tool);
                this.usedTools.Remove(tool);
            }
        }

    }
}
