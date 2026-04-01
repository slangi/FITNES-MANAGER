using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitnes.core
{
    public interface IPriceCalculable
    {
        decimal CalculateFinalPrice();
    }
}
