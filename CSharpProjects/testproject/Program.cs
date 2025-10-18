// using System.Globalization;

// CultureInfo.CurrentCulture = new CultureInfo("en-US");

// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");


// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types:");

// Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");


// Console.WriteLine("");
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

// string[] values = { "12.3", "45", "ABC", "11", "DEF" };

// string str = "";
// float total = 0;

// foreach (string value in values)
// {
//     float output = 0;

//     if (float.TryParse(value, out output))
//     {
//         total += output;
//     }
//     else
//     {
//         str += value;
//     }
// }

// Console.WriteLine($"Message: {str}");
// Console.WriteLine($"Total: {total}");


// int value1 = 11;
// decimal value2 = 6.2m;
// float value3 = 4.3f;

// // Your code here to set result1
// // Hint: You need to round the result to nearest integer (don't just truncate)
// int result1 = Convert.ToInt32(value1 / value2);
// Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// // Your code here to set result2
// decimal result2 = value2 / Convert.ToDecimal(value3);
// Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// // Your code here to set result3
// float result3 = value3 / value1;
// Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");


// double num1 = 1.23516184198165;

// float num2 = (float)num1;

// double num3 = Convert.ToDouble(num2);

// decimal num4 = 3.516186816823512655512652m;

// double num5 = (double)num4;

// decimal num6 = (decimal)num5;

// int num7 = Convert.ToSInt(num5);


// Console.WriteLine(num7);

// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);
// Console.WriteLine(message.Substring(openingPosition + 1, closingPosition - openingPosition - 1));

// string message = "Hello, world!";
// char[] charsToFind = { 'a', 'e', 'i', 'h', 'H' };

// int index = message.IndexOfAny(charsToFind);

// Console.WriteLine($"Found '{message[index]}' in '{message}' at index: {index}.");


// string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// // The IndexOfAny() helper method requires a char array of characters. 
// // You want to look for:

// char[] openSymbols = { '[', '{', '(' };

// // You'll use a slightly different technique for iterating through 
// // the characters in the string. This time, use the closing 
// // position of the previous iteration as the starting index for the 
// //next open symbol. So, you need to initialize the closingPosition 
// // variable to zero:

// int closingPosition = 0;

// while (true)
// {
//     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

//     if (openingPosition == -1) break;

//     string currentSymbol = message.Substring(openingPosition, 1);

//     // Now  find the matching closing symbol
//     char matchingSymbol = ' ';

//     switch (currentSymbol)
//     {
//         case "[":
//             matchingSymbol = ']';
//             break;
//         case "{":
//             matchingSymbol = '}';
//             break;
//         case "(":
//             matchingSymbol = ')';
//             break;
//     }

//     // To find the closingPosition, use an overload of the IndexOf method to specify 
//     // that the search for the matchingSymbol should start at the openingPosition in the string. 

//     openingPosition += 1;
//     closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//     // Finally, use the techniques you've already learned to display the sub-string:

//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));
// }


// string data = "12345John Smith          5000  3  ";
// string updatedData = data.Remove(5, 5);
// Console.WriteLine(updatedData);

// string message = "This--is--ex-amp-le--da-ta";
// message = message.Replace("--", " ");
// message = message.Replace("-", "");
// Console.WriteLine(message);


// EXTRACT DATA PROBLEM 

// const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

// string quantity = "";
// string output = "";

// const string quantityOpening = "<span>";
// const string quantityClosing = "</span>";
// // Your work here

// int qOpen = input.IndexOf(quantityOpening);
// qOpen += quantityOpening.Length;
// int qClose = input.IndexOf(quantityClosing);
// quantity = input.Substring(qOpen, qClose - qOpen);

// const string divOpening = "<div>";
// const string divClosing = "</div>";

// output = input.Remove(input.IndexOf(divOpening),divOpening.Length);
// output = output.Remove(output.IndexOf(divClosing), divClosing.Length);
// Console.WriteLine(quantity);
// Console.WriteLine(output);

// for (int i = 0; i < 100; i++)
// {
//     Console.WriteLine(i);
// }

// printSomething();
// Console.WriteLine("it's finished");
// PrintIteration();

// void printSomething()
// {
//     Console.WriteLine("something is printed");
// }

// void PrintIteration()
// {
//     for (int i = 0; i < 100; i++)
// {
//     Console.WriteLine(i);
// }
// }

// try
// {
//     Object x = null;
//     int y = 0;
//     Console.WriteLine(2 / y);
//     Console.WriteLine(5 / (int)x);

// }
// catch (DivideByZeroException)
// {
//     Console.WriteLine("You can't divide a integral value to zero");
// }

// catch (NullReferenceException)
// {
//     System.Console.WriteLine("You can't point a null variable");
// }
// System.Console.WriteLine("Test");

// double float1 = 3000.0;
// double float2 = 0.0;
// int number1 = 3000;
// int number2 = 0;

// Console.WriteLine(float1 / float2);
// Test();
// Console.WriteLine(number1 / number2);
// Console.WriteLine("Exit program");

// void Test()
// {

// }

// double float1 = 3000.0;
// double float2 = 0.0;
// int number1 = 3000;
// int number2 = 0;

// try
// {
//     Console.WriteLine(float1 / float2);
//     Console.WriteLine(number1 / number2);
// }
// catch
// {
//     Console.WriteLine("An exception has been caught");
// }
// Console.WriteLine("Exit program");


// try
// {
//     Process1();
// }
// catch
// {
//     Console.WriteLine("An exception has occurred");
// }

// Console.WriteLine("Exit program");

// static void Process1()
// {
//     try
//     {
//         WriteMessage();
//     }
//     catch
//     {
//         Console.WriteLine("An exception occured in Process 1");
//     }
// }

// static void WriteMessage()
// {
//     double float1 = 3000.0;
//     double float2 = 0.0;
//     int number1 = 3000;
//     int number2 = 0;

//     Console.WriteLine(float1 / float2);
//     Console.WriteLine(number1 / number2);
// }

// try
// {
//     Process1();
// }
// catch
// {
//     Console.WriteLine("An exception has occurred");
// }

// Console.WriteLine("Exit program");

// static void Process1()
// {
//     try
//     {
//         WriteMessage();
//     }
//     catch (Exception ex)
//     {
//         Console.WriteLine($"Exception caught in Process1: {ex.Message}");
//     }
// }

// static void WriteMessage()
// {
//     double float1 = 3000.0;
//     double float2 = 0.0;
//     int number1 = 3000;
//     int number2 = 0;

//     Console.WriteLine(float1 / float2);
//     Console.WriteLine(number1 / number2);
// }

// double testNum = 3000.0;
// byte smallNum;
// checked
// {
//     smallNum = (byte)testNum;
// }

// System.Console.WriteLine(smallNum);

// string test = "bu bir denemedir.";

// var bler = test.Where(ehe => ehe == 'b');

// foreach (var x in bler) {
//     System.Console.WriteLine(x);
// 

int x = 5;

Console.WriteLine(x);

void ChangeValue(int _)
{
    x = _;

}

ChangeValue(10);

Console.WriteLine(x);