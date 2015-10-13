namespace Pattern7.Bridge
{
    internal abstract class ScriptAbstraction
    {
        protected readonly IFormatter formatter;

        internal ScriptAbstraction(IFormatter formatter) // Keeping Dependency Inversion principle
        {
            this.formatter = formatter;
        }

        public abstract void Print();
    }
}