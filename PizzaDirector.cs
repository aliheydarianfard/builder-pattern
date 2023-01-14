using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder
{
    // define the kind of order step by step
    internal class PizzaDirector
    {
        private IPizzaBuilder _builder;

        public IPizzaBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildBasicPitzza()
        {
            this._builder.BuildBread();
            this._builder.BuildChesse();
            this._builder.BuildMeat();
            this._builder.BuildSauce();
        }
        public void BuildExtraChessePitzza()
        {
            this._builder.BuildBread();
            this._builder.BuildChesse();
            this._builder.BuildMeat();
            this._builder.BuildSauce();
        }
        public void BuildHealthyPitzza()
        {
            this._builder.BuildBread();
            this._builder.BuildChesse();
            this._builder.BuildMeat();
        }


    }
}
