
using System.Xml; //To use Xml document.
//Declaring and using some variables using the object type.

object height = 1.88; // Storing a double in a object.
object name = "Amir"; // Storing a string in an object.
Console.WriteLine($"{name} is {height} metres tall.");

//int length1 = name.Length; //This gives a compile error!!
int length2 = ((string)name).Length; //Cast name to a string.
Console.WriteLine($"{name} has {length2} characters.");

/*Making a dynamic statement. Assigning a string literal value, Integer value, and array of integer values.
 *Last, output length of the dynamic variable.*/
dynamic something;

/*Storing an array of int values in a dynamic object.
 * An Array of any type has a length property.*/
something = new[] { 3, 5, 7 };
/* Storing an int in a dynamic object.
 * int does not have a length property.*/
//something = 12;

/* Storing a string in a dynamic object.
 * String has a length property*/
//something = "Ahmen";

//This compiles but might throw an exception at run-time.

Console.WriteLine($"The Length of something is {something.Length}");

//Output the type of the soemthing variable.
Console.WriteLine($"something is a {something.GetType()}");

//Specifying the type of a local variable.
var population = 67_000_000; // 67 million in UK.
var weight = 1.88; // in kilograms.
var price = 4.99M; // in pounds sterling.
var fruit = "Apples"; // String values use double-quotes.
var letter = 'Z'; // char values use single-quotes.
var happy = true; // Booleans can only be true or false.

/*Good use of var because it avoids the repeated type.
 * As shown in the more verbose second statement.*/
var xml1 = new XmlDocument();// works with C# 3 and Later.
XmlDocument xml2 = new XmlDocument(); //Works with ALL C# versions.

/* Bad use of var because we cannot tell the type, so we
 * should use a specifit type declaration as shown in
 * the second statement. */
var file1 = File.CreateText("something1.txt");
StreamWriter file2 = File.CreateText("something2.txt");

