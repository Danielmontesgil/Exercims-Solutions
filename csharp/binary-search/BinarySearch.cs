using System;

public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        switch (input.Length)
        {
            case 0:
            case 1 when input[0] != value:
                return -1;
        }

        var inputHalf = input.Length / 2;

        if (input[inputHalf] == value)
        {
            return inputHalf;
        }

        if (input[inputHalf] > value)
        {
            return Find(input[..inputHalf], value);
        }

        if (input[inputHalf] >= value)
        {
            return -1;
        }

        var find = Find(input[inputHalf..], value);
        return find == -1 ? -1 : find + inputHalf;

    }
    
    public static int Find1(int[] input, int value)
    {
        int minNum = 0;
        int maxNum = input.Length - 1;
        while (minNum <= maxNum) {
            int mid = (minNum + maxNum) / 2;           
            if (value == input[mid]) {
                return mid;
            } else if (value < input[mid]) {
                maxNum = mid - 1;
            }else {
                minNum = mid + 1;
            }
        }
        return -1;
    }
}