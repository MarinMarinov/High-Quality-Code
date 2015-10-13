namespace Pattern5.Decorator
{
    /// <summary>
    /// The 'Component' abstract class
    /// </summary>
    internal abstract class AbstractItem
    {
        public int CopiesCount { get; set; }

        public abstract void Display();
    }
}
