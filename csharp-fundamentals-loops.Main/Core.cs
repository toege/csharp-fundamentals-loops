using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp_fundamentals_loops.Main
{
    public class Core
    {
        public int[] numsZeroToThree= new int[4];
        public int[] numsFiveToTen = new int[6];
        public int[] countdown = new int[4];

        public int[] favouriteNumbers = { 1, 2, 4, 5, 7, 8, 10 };

        public string[] myHobbies = { "Fishing", "Language learning", "Skydiving", "Procrastinating" };

        public void stepOne()
        {
            // TODO: 1. Write a for loop that adds the numbers 0 to 3 to the numsZeroToThree array                        
            throw new NotImplementedException();            
        }

        public void stepTwo()
        {
            // TODO: 2. Write a for loop that adds the numbers 5 to 10 to the numsFiveToTen array
            throw new NotImplementedException();
        }

        public void stepThree()
        {
            // TODO: 3. Write a for loop that adds the numbers 3 to 0 (in that order) to the countdown array
            throw new NotImplementedException();

        }

        public bool stepFour(int num)
        {
            // TODO: 6. Write a for loop that checks if num is in the favouriteNumbers array            
            throw new NotImplementedException();
        }

        public bool stepFive(string hobby)
        {
            // TODO 5. Write a for loop that checks if the hobby String is in the myHobbies array
            throw new NotImplementedException();
        }
    }

}
