namespace Pattern2.SimpleFactory
{
    public class Tea
    {
        public Tea(string herb, int watter)
        {
            this.HerbContent = herb;
            this.WatterContent = watter;
        }
        
        public string HerbContent { get; private set; }

        public int WatterContent { get; private set; }
    }
}
