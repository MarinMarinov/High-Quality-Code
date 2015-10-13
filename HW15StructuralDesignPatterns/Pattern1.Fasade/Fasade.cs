using System;

namespace Pattern1.Fasade
{
    public class Fasade
    {
        private SubsystemOne one;
        private SubsystemTwo two;
        private SubsystemThree three;
        private SubsystemFour four;

        private Fasade()
        {
            one = new SubsystemOne();
            two = new SubsystemTwo();
            three = new SubsystemThree();
            four = new SubsystemFour();
        }

        public static Fasade CreateInstance()
        {
            return new Fasade();
        }

        public void GeneralUserFunctionA()
        {
            Console.WriteLine("GeneralUserFunctionA method calls ----");
            one.MethodOne();
            two.MethodTwo();
            four.MethodFour();
        }

        public void GeneralUserFunctionB()
        {
            Console.WriteLine("GeneralUserFunctionB method calls ----");
            one.MethodOne();
            two.MethodTwo();
            three.MethodThree();
            four.MethodFour();
            two.MethodTwo();
            one.MethodOne();
        }
    }
}
