using PizzaBuilder;
using System;
using System.Collections.Generic;


/// <summary>
///  buider pattern is creational pattern 
///  you can create complex object step by step
///  Single Responsibility Principle and Open Close Principle  this example each type of pizza like(pepperoni,chiken,atc..) have own recipe (bussince logic)
/// </summary>


// pepperoni pizza
var director = new PizzaDirector();
var builder = new PepperoniBuilder();
director.Builder = builder;

Console.WriteLine("basic pepperoni pitzza:");
director.BuildBasicPitzza();
Console.WriteLine(builder.GetRecipe().GetPepperoni());

Console.WriteLine("healthy pepperoni pitzza:");
director.BuildHealthyPitzza();
Console.WriteLine(builder.GetRecipe().GetPepperoni());


// chiken pizza
var Specialdirector = new PizzaDirector();
var chikenBuilder = new ChikenPizzaBuilder();
Specialdirector.Builder = chikenBuilder;

Console.WriteLine("Standard basic chiken pitzza:");
Specialdirector.BuildBasicPitzza();
Console.WriteLine(chikenBuilder.GetRecipe().GetChikenPizza());


Console.WriteLine("extra chesse chiken pitzza:");
Specialdirector.BuildExtraChessePitzza();
Console.WriteLine(chikenBuilder.GetRecipe().GetChikenPizza());
