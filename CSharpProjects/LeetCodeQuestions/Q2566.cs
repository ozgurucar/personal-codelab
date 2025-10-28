
    public class Q2566 {

        static void Main(string[] args)
    {
        Console.WriteLine(MinMaxDifference(2323));

    }
    public static int MinMaxDifference(int num) {
        string numStr = num.ToString();
        string minStr = numStr;
        string maxStr = numStr;
        for(int i = 0; i < maxStr.Length; i++) {
            if(maxStr[i] == '9')
                continue;
            maxStr = maxStr.Replace(numStr[i],'9');
            break;
        }

        for(int i = 0; i < minStr.Length; i++) {
            if(minStr[i] == '0') 
                continue;
            minStr = minStr.Replace(numStr[i],'0');
            break;
        }

        return int.Parse(maxStr) - int.Parse(minStr);
    }
}
