using Q4_SchoolGradingSystem.App;

namespace Q4_SchoolGradingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolApp app = new SchoolApp();
            app.SeedData();
            app.PrintAllStudents();
        }
    }
}