using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();
            var dateModifier = new DateModifierr();
            dateModifier.DaysDifference(firstDate, secondDate);
        }
    }
}
