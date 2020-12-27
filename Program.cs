using CSharp9NewFeatures;
using System;

// First feature : 
// Top level code ! 
// For this type of apps, we don't need the namespace and class declaration. 
// Only one class can have top level declarations
// That class will be the entry point to the program.
Console.WriteLine("Hello World!");


// Second Feature : 
// The type is inferred, we don't need to write it twice 
// old way : Person person = new Person();
// new way : 
Person person = new() { YearOfBirth = 1995, Name = "John Doe" };

// Third Feature : 
person.Name = "Bob Doe"; // This is fine
// person.YearOfBirth = 1998; // PROBLEM -> This property has {get;set;}, therefore, it can only be initialized and read, never set twice. 


// Fourth Feature : new switch expression
int temperature = new Random().Next(-50, 100);
string temperatureDetails = temperature switch
{
    > -30 and < -15 => "Hardly livable",
    < 0 => "Freezing",
    0 => "Freezing point",
    > 0 and < 15 => "Cool but fine", // <--- logical operator and, not &&. You could also say or
    < 30 => "Fine",
    < 45 => "Hot",
    _ => "Not livable"
};

Console.WriteLine(temperature);
Console.WriteLine(temperatureDetails);


// Fifth feature : is not null
Person albert = null;

if (albert is not null)
{
    Console.WriteLine("Albert has value");
}



