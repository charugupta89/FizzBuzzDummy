using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Logic
{
    public class BuzzLogic : IBuzzLogic
    {
        public string GetBuzz(int i)
        {
            string result = i % 5 == 0 ? "Buzz" : i.ToString();
            return result;
        }
    }
}
