namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var addNumbers = Add(20, 25);
            var addDecimal = Add(2.55m, 5.46m);
            var addWithConditonal = Add(23, 24, true);

            Console.WriteLine($"Add whole numbers is {addNumbers}");
            Console.WriteLine($"Add Decimal numbers is {addDecimal}");
            Console.WriteLine($"Add with Conditional is {addWithConditonal}");

        }

        static int Add(int num1, int num2) {
            return num1 + num2;
        }

        static decimal Add(decimal num1, decimal num2) {
            return num1 + num2;
        }

        static string Add(int num1, int num2, bool dollars) {

            int sum = num1 + num2;

            if (dollars && sum > 1) {
                return $"{sum} dollars";
            } else if (dollars && sum == 1){
                return $"{sum} dollar";
            } else if(dollars && sum < 1) {
                return $"{sum} dollars";
            } else {
                return sum.ToString();
            }

        }
    }
}
