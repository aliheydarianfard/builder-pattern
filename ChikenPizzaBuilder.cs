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
    public class ChikenPizzaBuilder : IPizzaBuilder
    {
        private ChikenRecipe _pitzza = new ChikenRecipe();

        
        public ChikenPizzaBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._pitzza = new ChikenRecipe();
        }
        public void BuildBread()
        {
            this._pitzza.Add("big bread");
        }

        public void BuildChesse()
        {
            this._pitzza.Add("blue cheasse");
        }

        public void BuildSauce()
        {
            this._pitzza.Add("notmal Sauce");
        }

        public void BuildMeat()
        {
            this._pitzza.Add("chiken meat");
        }

        public ChikenRecipe GetRecipe()
        {
            ChikenRecipe result = this._pitzza;

            this.Reset();

            return result;
        }


    }
}
