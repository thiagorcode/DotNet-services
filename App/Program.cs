// See https://aka.ms/new-console-template for more information
var name = "John";
Console.WriteLine($"name = {name} ");
var path = "C:\\Users\\Documents\\MyFolder";
Console.WriteLine($"path = {path} ");

path = @"C:\\Users\\Documents\\MyFolder\n";
Console.WriteLine($"path = {path} ");

Console.WriteLine("Name: {0} and Path: {1}", name, path);

name = "";
if (name != string.Empty)
{
  Console.WriteLine($"name = {name} ");
}
else
{
  Console.WriteLine("name not found");
}

