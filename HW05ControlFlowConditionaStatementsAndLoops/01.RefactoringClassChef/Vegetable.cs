namespace _01.RefactoringClassChef
{
    public abstract class Vegetable
    {
        public Vegetable()
        {
            this.IsPeeled = false;
            this.IsChoped = false;
            this.IsCooked = false;
        }

        public bool IsPeeled { get; set; }

        public bool IsChoped { get; set; }

        public bool IsCooked { get; set; }

        public void Peel()
        {
            this.IsPeeled = true;
        }

        public void Chop()
        {
            this.IsChoped = true;
        }

        public void Cook()
        {
            this.IsCooked = true;
        }

        public override string ToString()
        {
            string name = this.GetType().Name;
            string peeling = this.IsPeeled ? "peeled" : "not peeled";
            string choping = this.IsChoped ? "choped" : "not choped";

            return string.Format("{0} is {1} and is {2}", name, peeling, choping);
        }
    }
}
