namespace Calculation_of_perimeter__area__rhombus_of_a_square
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SquareParametr();
        }


        static void SquareParametr()
        {
            Console.WriteLine("Squared side : ");
            int squareSide = int.Parse(Console.ReadLine());
            int doubleSide = squareSide * squareSide + squareSide * squareSide;
            double sqaureRoot = Math.Sqrt(doubleSide);
            int smallRadius = squareSide / 2;
            double largeRadius = sqaureRoot / 2;

            Console.WriteLine($"Kvadratin perimetri : {squareSide * 4} ");
            Console.WriteLine($"Kvadratin sahesi : {squareSide*squareSide}");
            Console.WriteLine($"Kvadratin dioqanal : {sqaureRoot}");
            Console.WriteLine($"Kvadratin kicik radiusu : {smallRadius}");
            Console.WriteLine($"Kvadratin boyuk radiusu : {largeRadius}");

            //Console.WriteLine($"Kvadratin rombu : {}")
        }
    }
}