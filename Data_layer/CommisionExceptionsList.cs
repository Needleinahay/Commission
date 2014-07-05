using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_layer
{
    public class WrongAmountOfVacancies : Exception
    {
        public WrongAmountOfVacancies() {}
        public WrongAmountOfVacancies(string toBeMessage)
            : base(toBeMessage) {}
    }
}
