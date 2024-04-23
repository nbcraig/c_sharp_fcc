// Exercise - Use the string's IndexOf() and Substring() helper methods
/*
string message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

// Exercise - Use the string's IndexOf() and Substring() helper methods

string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

openingPosition += 1;

string finalMessage = message.Substring(openingPosition, (closingPosition - openingPosition));

Console.WriteLine(openingPosition);
Console.WriteLine(closingPosition);
Console.WriteLine(finalMessage);

// Exercise - Use the string's IndexOfAny() and LastIndexOf() helper methods

string message = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
    int openingPosition = message.IndexOf('(');
    if (openingPosition == -1) break;

    openingPosition += 1;
    int closingPosition = message.IndexOf(')');
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    // Note the overload of the Substring to return only the remaining 
    // unprocessed message:
    message = message.Substring(closingPosition + 1);
}

// Work with different types of symbol sets

string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    // Now  find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // Finally, use the techniques you've already learned to display the sub-string:

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}

// Exercise - Use the Remove() and Replace() methods

// Remove
string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);

// Replace
string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);
*/
// Exercise - Complete a challenge to extract, replace, and remove data from an input string

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
int quantityStart = input.IndexOf("<span>");
int quantityEnd = input.IndexOf("</span>");
quantityStart += 6;
quantity = input.Substring(quantityStart, (quantityEnd - quantityStart));

int outputStart = input.IndexOf("<div>");
int outputEnd = input.IndexOf("</div>");
outputStart += 5;
output = input.Substring(outputStart, (outputEnd - outputStart));
output.Replace("&trade;", "&reg;");


Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");