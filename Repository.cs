using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mocking
{
    public class Repository
    {
        /// <summary>
        /// This solution comes from here: Mock in Unit testing C#: https://www.youtube.com/watch?v=xJG5Sm_HbOc
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Sum(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// This method is not implmented yet. 
        /// This is to show that you can still unit test the method without needing
        /// finished code
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public virtual int Sub(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
