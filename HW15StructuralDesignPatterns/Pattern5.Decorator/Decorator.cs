namespace Pattern5.Decorator
{
    internal  abstract class Decorator : AbstractItem
    {
        protected Decorator(AbstractItem item)
        {
            this.AbstractItem = item;
        }

        protected AbstractItem AbstractItem { get; private set; }

        public override void Display()
        {
            this.AbstractItem.Display();
        }
    }
}
