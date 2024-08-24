using _05_Builder;

//Lets say I want the to build houses in multiple configurations

var builder1 = new HouseBuilder();
var house1 = builder1.AddCeiling().AddWall().SetSize(20).Build();

var builder2 = new HouseBuilder();
var house2 = builder2.AddCeiling().Build();

var builder3 = new HouseBuilder();
var house3 = builder3.AddCeiling().AddWall().Build();

Console.WriteLine($"Floor size: {house1.FloorSize}, Has ceiling: {house1.HasCeiling}, has wall: {house1.HasWall}");
Console.WriteLine($"Floor size: {house2.FloorSize}, Has ceiling: {house2.HasCeiling}, has wall:  {house2.HasWall}");
Console.WriteLine($"Floor size: {house3.FloorSize}, Has ceiling:  {house3.HasCeiling}, has wall:  {house3.HasWall}");
