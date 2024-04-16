// Exercise - Explore data type casting and conversion
using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");

/*
// Convert a string to a int using the Convert class

string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);

// Compare casting and converting a decimal into an int

int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);


// Exercise - Examine the TryParse() method

string value = "bad";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}

if (result > 0)
    Console.WriteLine($"Measurement (w/ offset): {50 + result}");


// Exercise - Complete a challenge to combine string array values as strings and as integers

string[] values = { "12.3", "45", "ABC", "11", "DEF" };

string message = "";
decimal total = 0m;

foreach (var value in values)
{
    decimal result;
    if (decimal.TryParse(value, out result))
    {
        total += result;
    }
    else
    {
        message += result;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");
*/

// Exercise - Complete a challenge to output math operations as specific number types

int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
int result1 = Convert.ToInt32(value1 / value2);
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");