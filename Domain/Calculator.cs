using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Calculator
    {
        public int Sum(int left, int right)
        => left + right;
        

        public int Diff(int left, int right)
        => left - right;


        public int Div(int left, int right)
            => left / right;

        public int Multiply(int left, int right)
            => left * right;
    }
}
