using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMyMvc.Model
{
    public class FizzBuzz
    {
        public string GetFizzBuzzValue(int i)
        {
            string result = i % 3 == 0 ? "Fizz" : i % 5 == 0 ? "Buzz" : i % 3 == 0 && i % 5 == 0 ? "FizzBuzz" : i.ToString();
            return result;
        }
        public List<string> GetFizzBuzzNum(int value)
        {

            var numbers = new List<string>();

            for (var i = 1; i <= value; i++)
            {
                numbers.Add(GetFizzBuzzValue(i));
            }
            return numbers;
        }


    }
}
