using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mocking
{
    public class Business
    {
        private readonly Repository repo;

        public Business(Repository repo)
        {
            this.repo = repo;
        }

        public int Addition(int a, int b)
        {
            return this.repo.Sum(a, b);
        }

        public int Subtraction(int a, int b)
        {
            return this.repo.Sub(a, b);
        }
    }
}
