using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailsOfCohort
{
    class Program
    {
        public static void GetCohortDetails(string cohortName, int GenCCount, string mode, string track, string module)
        {
            Console.WriteLine($"It is {cohortName} with {GenCCount} GenCs " +
                              $"undergoing training for {track} thru {mode}. " +
                              $"The current module of training is {module}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Cohort Name");
            string cohortName = Console.ReadLine();

            Console.WriteLine("Enter GenC's count");
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the mode");
            string mode = Console.ReadLine();

            Console.WriteLine("Enter the track");
            string track = Console.ReadLine();

            Console.WriteLine("Enter current module");
            string module = Console.ReadLine();

            GetCohortDetails(GenCCount:count, cohortName:cohortName, track:track, module:module, mode:mode);

            Console.ReadLine();
        }
    }
}
