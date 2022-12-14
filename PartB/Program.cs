namespace PartB
{

    class Program
    {
        static void Main(string[] args)
        {
            IShape rect = new Rect() { Height = 2, Width = 5};
            IShape square = new Square { SideLength = 10 };

            //Console.WriteLine($"rect area = {rect.CalcSquare()}");
            //Console.WriteLine($"square area = {square.CalcSquare()}");

            IAnimal cat = new Cat() { Leg = 4 };
            IAnimal fish = new Fish() { };
            Console.WriteLine(cat.IMove());
            Console.WriteLine(fish.IMove());
            /*
            var intList = new List<int>() { 13, 34, 65, 34, 23, 55 };

            intList.Add(14);

            Console.WriteLine(intList);

            for (int i =0; i < intList.Count; i++)
            {
                Console.WriteLine(intList[i]);
            }
           
            Rect rect = new Rect { Height = 2, Width = 5 };
            int rectArea = AreaCalc.CalcSquare(rect);
            Console.WriteLine($"rect area = {rectArea}");

            Rect square = new Square { Height = 2, Width = 10 };
            AreaCalc.CalcSquare(square);
            */
            Console.ReadLine();
        }

    }
}