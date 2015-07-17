namespace _01.RefactoringClassChef
{
    public class Chef
    {
        public Bowl Cook()
        {
            Potato potato = GetPotato();
            this.Peel(potato);
            this.Chop(potato);

            Carrot carrot = GetCarrot();
            this.Peel(carrot);
            this.Chop(carrot);

            Bowl bowl = GetBowl();
            bowl.Add(potato);
            bowl.Add(carrot);

            return bowl;
        }

        private Potato GetPotato()
        {
            return new Potato();
        }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }
        
        private Bowl GetBowl()
        {
            return new Bowl(); 
        }

        private void Chop(Vegetable vegetable)
        {
            vegetable.Chop();
        }

        private void Peel(Vegetable vegetable)
        {
            vegetable.Peel();
        }
    }
}
