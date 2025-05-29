
using System.Diagnostics.SymbolStore;
using System.Globalization;
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

// Default values of int, a bool, a DateTime, and a string.
Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string) ?? "<NULL>"}");
//Declaring a number, assign a vlaue, and resetting it to default value.
int number = 13;
Console.WriteLine($"number set to: {number}");
number = default;
Console.WriteLine($"number reset to its default: {number}");

//No carrage return/ Characters on a single line (Write Method).
Console.Write("A");
Console.Write("B");
Console.Write("C");

//Carrage return (WriteLine Methond).
Console.WriteLine("A");
Console.WriteLine("B");
Console.WriteLine("C");

//Numbered postional arguments.
//if needing formatted Format method of string.

/*Set current culture to US English so that all readers
 * see the same output.*/
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

int numberOfApples = 12;
decimal pricePerApple = 0.35M;

Console.WriteLine(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);

string formatted = string.Format(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple* numberOfApples);

//WriteToFile(formatted); //Writes the string into file.

//Three and five arguments.
//Three parameter values can use named arguments.
Console.WriteLine("{0} {1} lived in {2}.",
    arg0: "Roger", arg1: "Cevung", arg2: "Stockholm");

//Four or more parameter values cannot use named arguments.
Console.WriteLine(
    "{0} {1} lived in {2} and worked in the {3} team at {4}.", "Roger", "Cevent", "Stockholm", "Education", "Optimizely");

//Interloped string
//C# 10 or earlier = Statement needs to be on one line
Console.WriteLine($"{numberOfApples} apples cost {pricePerApple * numberOfApples:C}");

Write("Press any key combination: ");
ConsoleKeyInfo key  = Console.ReadKey();
WriteLine();
WriteLine("Key: {0}, Char: {1}, Modifiers: {2}", arg0: key.Key, arg1: key.KeyChar, arg2: key.Modifiers);