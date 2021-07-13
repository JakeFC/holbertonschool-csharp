using System;

class Character
{
    public static bool IsLower(char c)
    {
        if (c > 96 && c < 123)
            return true;
        return false;
    }
}