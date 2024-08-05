// See https://aka.ms/new-console-template for more information
using PropertyDemo;

Console.WriteLine("Hello, World!");

var petList = new List<IPet>();

var p = new Cat();
p.Name = "Ezreal";
p.Id = 1;

var p1 = new Dog
{ 
    Name = "Whiteys",
    Id = 2 
};


var p2 = new Cat()
{
    Name = "Flora",
    Id = 3
};

petList.Add(p);
petList.Add(p1);
petList.Add(p2);


// Lambda Functions | shorthand anonymous functions

var printFunc = (IPet p) => Console.WriteLine(p); // Lambda Function

void PrintPetFunction (IPet p)
{
    Console.WriteLine(p);
}

petList.ForEach(PrintPetFunction);

Console.ReadLine();

