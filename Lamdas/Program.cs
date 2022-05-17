/*
var myNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };

var numbersOver5 = myNumbers.Where(n => n > 5);
*/

var table = new List<int>{ 1, 2, 3, 4, 5, 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };

var newTable = table.Where(n => n < 5);
string combinedString = String.Join(",", newTable);

Console.Write(combinedString);
Console.Read();