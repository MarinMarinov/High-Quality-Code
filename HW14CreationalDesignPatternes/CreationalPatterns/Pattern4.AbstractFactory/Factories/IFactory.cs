namespace Pattern4.AbstractFactory.Factories
{
    using Pattern4.AbstractFactory.Banitsas;

    public interface IFactory
    {
        CheeseBanitsa MakeCheeseBanitsa();

        MeatBanitsa MakeMeatBanitsa();
    }
}
