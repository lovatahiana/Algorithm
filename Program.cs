namespace Problem1
{
    internal class Problem
    {
        public static void Main()
        {
            
            Equation myEquation = new Equation(1, 10, 169);
            myEquation.DisplayEquation();
            myEquation.CalculateRoots();
            if (myEquation.Discriminant == 0)
            {
                Console.WriteLine($"The root = {myEquation.FirstRoot} .");
            }
            else if (myEquation.Discriminant > 0)
            {
                Console.WriteLine($"First Root = {myEquation.FirstRoot} , Second Root = {myEquation.SecondRoot}");
            }
        }
    }
}
