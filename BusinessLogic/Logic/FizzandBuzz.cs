using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Logic
{
    public class FizzandBuzz : IFizzandBuzz
    {
        public string GetFizzandBuzz(int i)
        {
            string result = i % 3 == 0 && i%5==0 ? "Fizz" : i.ToString();
            return result;
        }
    }
}
