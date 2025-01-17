namespace TinyLittleFunctions
{


    internal class Program
    {
        public static string CheckPasswordStrength(string password)
        {
            if (string.IsNullOrEmpty(password))
                return "Weak";

            if (password.Length < 6)
                return "Weak";

            bool hasLetter = password.Any(char.IsLetter);
            bool hasDigit = password.Any(char.IsDigit);
            bool hasSpecialChar = password.Any(ch => !char.IsLetterOrDigit(ch));

            if (password.Length >= 6 && hasLetter && hasDigit && hasSpecialChar)
                return "Strong";

            if (password.Length >= 6 && hasLetter && hasDigit)
                return "Medium";

            return "Weak";
        }

        public static string CategorizeAge(int age)
        {
            if (age < 0 || age > 120)
                return "Invalid";

            if (age >= 0 && age <= 12)
                return "Child";

            if (age >= 13 && age <= 17)
                return "Teenager";

            if (age >= 18 && age <= 64)
                return "Adult";

            return "Senior";
        }

        public static string IsPrime(int number)
        {
            if (number <= 1)
                return "Not Prime";

            if (number == 2)
                return "Prime";

            if (number % 2 == 0)
                return "Not Prime";

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                    return "Not Prime";
            }

            return "Prime";
        }

        public static int GetGrade(int score)
        {
            if (score < 0 || score > 100)
                return -1;

            if (score >= 85)
                return 5;

            if (score >= 70)
                return 4;

            if (score >= 55)
                return 3;

            if (score >= 40)
                return 2;

            return 1;
        }

        public static double CalculateDiscount(double totalAmount)
        {
            if (totalAmount < 0)
                return -1;

            if (totalAmount >= 100000)
                return totalAmount * 0.85;

            if (totalAmount >= 50000)
                return totalAmount * 0.90;

            if (totalAmount >= 20000)
                return totalAmount * 0.95;

            return totalAmount;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
