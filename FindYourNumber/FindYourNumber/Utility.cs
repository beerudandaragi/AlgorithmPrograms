using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindYourNumber
{
    class Utility
    {
        public void searchNum(int MaxNumber)
        {

            //Enter the maximum value from 0 to maximum value
            int High = MaxNumber;
        int Low = 0;
        int Middle = (High + Low) / 2;
        Console.WriteLine("press 0 for " + Middle + " and below  \npress 1 for " + (Middle + 1) + " and above");
			int i = int.Parse(Console.ReadLine());
			while (Middle != Low)
			{
				//if the value from low to middle this block will execute
				if (i == 0)
				{
					High = Middle;
					Middle = (Low + High) / 2;
					Console.WriteLine("press 0 for " + Middle + " and below  \npress 1 for " + (Middle + 1) + " and above");
					i = int.Parse(Console.ReadLine());
        Console.WriteLine(i);
				}
				//if the value from Middle to high this block will execute
				if (i == 1)
				{
					Low = Middle + 1;
					Middle = (Low + High) / 2;
					Console.WriteLine("press 0 for " + Middle + " and below \npress 1 for " + (Middle + 1) + " and above");
					i = int.Parse(Console.ReadLine());
    Console.WriteLine(i);
				}
			}
			if (i == 0)
			{    
				//one more comparison is here
				Console.WriteLine("Your Number is " + Low);
			}
			if (i == 1)
			{   
				//one more comparison is here
				Console.WriteLine("Your Number is " + High);
			}
		}
	}
}

    
