namespace WalkMatrix
{
    public class EntryPoint
    {
        public static void Main()
        {
            int matrixLength = ConsoleInputProvider.GetInput();
            int[,] matrix = MatrixGenerator.Generate(matrixLength);
            ConsoleOutputProvider.PrintMatrix(matrix);
        }
    }
}
