namespace CdevMod16
{
     class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Калькулятор готов к работе");
            var numbers = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
            Console.WriteLine(calculator.Addition(numbers[0], numbers[1]));
        }
    }

}