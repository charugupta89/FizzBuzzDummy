using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Logic
{
    public class FizzLogic : IFizzLogic
    {
        public string GetFizz(int i)
        {
            string result = i % 3 == 0 ? "Fizz" : i.ToString();
            return result;
        }
    }
}
