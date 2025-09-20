string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

for (int i = 0; i < myStrings.Length; i++)
{

    int periodLocation;
    string partString;

    do
    {

        periodLocation = myStrings[i].IndexOf('.');

        if (periodLocation == -1)
        {
            Console.WriteLine(myStrings[i]);
            break;
        }

        partString = myStrings[i].TrimStart().Substring(0, periodLocation + 1);
        Console.WriteLine(partString);

        myStrings[i] = myStrings[i].TrimStart().Remove(0, periodLocation + 1);



    } while (periodLocation != -1);

}
