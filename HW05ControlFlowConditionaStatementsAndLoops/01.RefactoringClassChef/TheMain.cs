namespace _01.RefactoringClassChef
{
    using System;
    
    class TheMain
    {
        static void Main(string[] args)
        {
            Potato firstPotato = new Potato();
            Carrot firstCarrot = new Carrot();
            Console.WriteLine(firstPotato.ToString());
            Console.WriteLine(firstCarrot.ToString());

            //Bowl bowl = new Bowl();
            //bowl.Ingredients.Add(firstPotato);
            //bowl.Ingredients.Add(firstCarrot);

            //foreach (var item in bowl.Ingredients)
            //{
            //    Console.WriteLine(item.GetType().Name);
            //}
            //Console.WriteLine(bowl.ToString());

            Chef chef = new Chef();
            var meal = chef.Cook();
            Console.WriteLine(meal);
        }
    }
}
