namespace Pattern6.Adapter
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICompound water = new RichCompound("water");
            water.Display();

            ICompound benzene = new RichCompound("benzene");
            benzene.Display();

            ICompound ethanol = new RichCompound("ethanol");
            ethanol.Display();

            ICompound etilen = new RichCompound("etilen");
            etilen.Display(); // will display default values of the variables, because there isn't etilen item in the databank
        }
    }
}
