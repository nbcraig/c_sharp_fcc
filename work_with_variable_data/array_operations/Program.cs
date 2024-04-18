// Comment and un-comment code sections to run

// Exercise - Discover Sort() and Reverse()

// Create an array of pallets, then sort them

string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}


// Reverse the order of the pallets

string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}


// Exercise - Explore Clear() and Resize()
string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0].ToLower()}");
Array.Clear(pallets, 0, 2);
if (pallets[0] != null)
    Console.WriteLine($"After: {pallets[0].ToLower()}");
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}


// Resize the array to add more elements

string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}


// Resize the array to remove elements

string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Exercise - Discover Split() and Join()

string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result);

// Combine all of the chars into a new comma-separated-value string using Join()

string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}


// Exercise - Complete a challenge to reverse words in a sentence

string pangram = "The quick brown fox jumps over the lazy dog";

string[] pangramWords = pangram.Split(" ");

string[] pangramWordsReversed = new string[pangramWords.Length];

for (int i = 0; i < pangramWords.Length; i++)
{
    char[] wordArray = pangramWords[i].ToCharArray();
    Array.Reverse(wordArray);
    pangramWordsReversed[i] = new string(wordArray);
}

string result = String.Join(" ", pangramWordsReversed);

Console.WriteLine(result);


// Exercise - Complete a challenge to parse a string of orders, sort the orders and tag possible errors

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderStreamArray = orderStream.Split(",");
Array.Sort(orderStreamArray);

foreach (string item in orderStreamArray)
{
    if (item.Length == 4)
        Console.WriteLine(item);
    else
        Console.WriteLine($"{item} - Error");
}