using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder
{
    // The builder interface specifies methods for creating the
    // different parts of the pizza objects.
    internal interface IPizzaBuilder
    {
        void BuildBread();
        void BuildChesse();
        void BuildSauce();
        void BuildMeat();
    }
}
