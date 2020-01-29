using System.Threading.Tasks;

namespace _5_MethodSignature
{
    public class Program
    {       
        private static async void Main(string[] args)
        {
            var (averageSalary, numberOfEmployee) = await SomeCalculation(0L, 10, 0L == 10L);
        }

        public static async Task<(long averageSalary, long numberOfEmployee)> SomeCalculation(long num1, long num2, bool bVal)
        {
            long averageSalary = num1;
            long numberOfEmployee = num2;
           
            return (averageSalary, numberOfEmployee);
        }
    }
}
