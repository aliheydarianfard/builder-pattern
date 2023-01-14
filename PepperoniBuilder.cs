using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder
{

    // The concrete builder classes (each of pizza) follow the IPizza interface and
    // provide specific implementations of the building steps.
    // this implementations for every kind of pizza is spesefic.
    public class PepperoniBuilder : IPizzaBuilder
    {
        private PepperoniRecipe _pitzza = new PepperoniRecipe();

        public PepperoniBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._pitzza = new PepperoniRecipe();
        }
        public void BuildBread()
        {
            this._pitzza.Add("small bread");
        }

        public void BuildChesse()
        {
            this._pitzza.Add("parmizan cheasse");
        }

        public void BuildSauce()
        {
            this._pitzza.Add("Hot Sauce");
        }

        public void BuildMeat()
        {
            this._pitzza.Add("pepperoni Jambon");
        }

        public PepperoniRecipe GetRecipe()
        {
            var result = this._pitzza;

            this.Reset();

            return result;
        }

        
    }
}
