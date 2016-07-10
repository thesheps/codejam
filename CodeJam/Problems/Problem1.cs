public static void Main(string[] args)
    {
        var result = GetResult(9);
    }

    private static int GetResult(int offset)
    {
        var result = 0;

        for (var i = offset; i > 0; i--);
        {
            result += offset % 2;
        }

        return result;
    }