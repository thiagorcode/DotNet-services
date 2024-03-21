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

class StudentName
{
  public string? FirstName { get; set; }
  public string? LastName { get; set; }
  public int ID { get; set; }
}
var students = new Dictionary<int, StudentName>()
        {
            { 111, new StudentName { FirstName="Sachin", LastName="Karnik", ID=211 } },
            { 112, new StudentName { FirstName="Dina", LastName="Salimzianova", ID=317 } },
            { 113, new StudentName { FirstName="Andy", LastName="Ruth", ID=198 } }
        };

foreach (var index in Enumerable.Range(111, 3))
{
  Console.WriteLine($"Student {index} is {students[index].FirstName} {students[index].LastName}");
}
Console.WriteLine();

var students2 = new Dictionary<int, StudentName>()
{
  [111] = new StudentName { FirstName = "Sachin", LastName = "Karnik", ID = 211 },
  [112] = new StudentName { FirstName = "Dina", LastName = "Salimzianova", ID = 317 },
  [113] = new StudentName { FirstName = "Andy", LastName = "Ruth", ID = 198 }
};

foreach (var index in Enumerable.Range(111, 3))
{
  Console.WriteLine($"Student {index} is {students2[index].FirstName} {students2[index].LastName}");
}