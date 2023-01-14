using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder
{
    // this is resualt of concrete implementations of Pizza
    public class PepperoniRecipe
    {
        private List<object> _parts = new List<object>();
        

        public void Add(string part)
        {
            this._parts.Add(part);
        }

        public string GetPepperoni()
        {
            string str = string.Empty;

            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2); // removing last ",c"

            return "Pitzza parts: " + str + "\n";
        }
      
    }
}
