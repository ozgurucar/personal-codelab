//question 0013
class RomanToInteger
{
    static void Main(string[] args)
    {


    }
    public static int RomanToInt(string s)
    {

        int total = 0;

        var dictCouples = new Dictionary<string, int>();
        var dictLetters = new Dictionary<char, int>();

        dictLetters.Add('I', 1);
        dictLetters.Add('V', 5);
        dictLetters.Add('X', 10);
        dictLetters.Add('L', 50);
        dictLetters.Add('C', 100);
        dictLetters.Add('D', 500);
        dictLetters.Add('M', 1000);


        dictCouples.Add("CM", 100);
        dictCouples.Add("CD", 100);
        dictCouples.Add("XL", 10);
        dictCouples.Add("XC", 10);
        dictCouples.Add("IV", 1);
        dictCouples.Add("IX", 1);


        foreach (char c in s)
        {
            dictLetters.TryGetValue(c, out int value);
            total += value;
        }

        var parts = Enumerable
            .Range(0, s.Length - 1)
            .Select(i => s.Substring(i, 2))
            .ToList();


        foreach (var part in parts)
        {
            dictCouples.TryGetValue(part, out int value);
            total -= value * 2;
        }
        return total;
    }

}


