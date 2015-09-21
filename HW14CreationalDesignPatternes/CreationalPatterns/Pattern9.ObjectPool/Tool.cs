using System;

namespace Pattern9.ObjectPool
{
    /// <summary>
    /// The PooledObject class is the type that is expensive or slow to instantiate,
    /// or that has limited availability, so is to be held in the object pool.
    /// </summary>
    public class Tool : IDisposable
    {
        private readonly DateTime timeofOrder = DateTime.Now;

        public DateTime TimeOfOrder
        {
            get
            {
                return this.timeofOrder;
            }
        }

        public string WorkerName { get; set; }

        public string ToolType { get; set; }

        public void Dispose()
        {
            this.WorkerName = null;
        }
    }
}
