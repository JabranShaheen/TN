using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TN.Implementation.GeneratorAbstractions
{
    interface IRandomNumberGenerator
    {
        int GenerateRandomNumber(int From, int To);
    }
}
