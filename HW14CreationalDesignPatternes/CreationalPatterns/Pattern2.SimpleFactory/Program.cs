using System;

namespace Pattern2.SimpleFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            // the classic way
            Tea tea = new Tea("Carcade", 100);
            Console.WriteLine(tea.HerbContent);
            Console.WriteLine(tea.WatterContent);


            // Using TeaFactory - implementation of Simple Factory pattern
            TeaFactory teaMaker = new TeaFactory();
            Console.WriteLine("The teaMaker is instance of the {0} class which implements Simple Factory pattern", teaMaker.GetType());

            Tea bigBlackTea = teaMaker.GetTea(TeaType.Black, TeaAmount.Big);
            Tea smallMintTea = teaMaker.GetTea(TeaType.Mint, TeaAmount.Small);

            Console.WriteLine("The tea is {0} and the amount is {1}ml. Cheers!", bigBlackTea.HerbContent, bigBlackTea.WatterContent);

            Console.WriteLine("The tea is {0} and the amount is {1}ml. Cheers!", smallMintTea.HerbContent, smallMintTea.WatterContent);

            // We can make TeaFactory to be static class with static method, but this is not good practice:
            // mediumThyneTea = TeaFactory.GetTea(TeaType.Thyme, (int)TeaAmount.Medium);
            //Console.WriteLine("The tea is {0} and the amount is {1}ml. Cheers!", mediumThyneTea.HerbContent, mediumThyneTea.WatterContent);
        }
    }
}
