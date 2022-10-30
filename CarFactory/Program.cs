
using CarFactory.Factories;

var sportsCarFactory = new SportsCarFactory();
var vanCarFactory = new VanFactory();

var opelSportsCar = sportsCarFactory.CreateOpel();
var fiatSportsCar = sportsCarFactory.CreateFiat();
var opelVan = vanCarFactory.CreateOpel();
var fiatVan = vanCarFactory.CreateFiat();

