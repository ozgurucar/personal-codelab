class Q3354
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Hello World!");
        CountValidSelections(new int[] { 1, 2, 3 });
    }

    public static int CountValidSelections(int[] nums)
    {

        Direction direction;
        for (int i = 0; i < nums.Length; i++)
        { 
            if(nums[i] == 0)
            {
                int[] copyNums = (int[])nums.Clone();
                // For Left Direction Test
                int curr = i;
                direction = Direction.Left;
                while (true)
                {
                    
                    if (getNext(direction, curr) < 0 || getNext(direction, curr) >= copyNums.Length)
                    {
                        bool flag = true;
                        foreach (int num in copyNums)
                        {
                            if (num != 0) flag = false;
                        }
                        if (flag) return i;
                        break;
                    }
                    curr = getNext(direction, curr);
                    if (copyNums[curr] > 0)
                    {
                        copyNums[curr]--;
                        direction = reverseDirection(direction);
                    }
                }


                // For Right Direction Test
            copyNums = (int[])nums.Clone();
            direction = Direction.Right;
             while (true)
                {
                    
                    if (getNext(direction, curr) < 0 || getNext(direction, curr) >= copyNums.Length)
                    {
                        bool flag = true;
                        foreach (int num in copyNums)
                        {
                            if (num != 0) flag = false;
                        }
                        if (flag) return i;
                        break;
                    }
                    curr = getNext(direction, curr);
                    if (copyNums[curr] > 0)
                    {
                        copyNums[curr]--;
                        direction = reverseDirection(direction);
                    }
                }
            }


           
        }
        return 0;
    }


    public enum Direction
    {
        Left,
        Right
    }

    public static int getNext(Direction direction, int curr)
    {
        if (direction == Direction.Left)
        {
            return curr - 1;
        }
        else
        {
            return curr + 1;
        }
    }
    
    public static Direction reverseDirection(Direction direction)
    {
        if (direction == Direction.Left)
        {
            return Direction.Right;
        }
        else
        {
            return Direction.Left;
        }
    }
}