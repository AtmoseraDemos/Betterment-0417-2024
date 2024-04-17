/*
This file contains a class that provides methods that can be used in probabilistic mathematics.
*/


namespace Math{
/*
Create a class 'Probabilities' that contains the following methods:
1. 'Factorial()' that takes an unsigned integer parameter 'n' and returns the factorial of 'n' using recursion.
    Details:
    The factorial of a non-negative integer 'n' is the product of all positive integers less than or equal to 'n'.

    If n = 0 or n = 1, the factorial is 1.
    return n * Factorial(n - 1);

2. 'Permutations()' that takes two unsigned integer parameters 'n' and 'r' and returns the number of permutations of 'n' items taken 'r' at a time.
    Details:
    The number of permutations of 'n' items taken 'r' at a time is given by the formula:
    n! / (n - r)!
    where 'n!' is the factorial of 'n'.
*/

public class Probabilities
{
    private static Dictionary<uint, ulong> memo = new Dictionary<uint, ulong>();

    public static ulong Factorial(uint n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }

        if (memo.ContainsKey(n))
        {
            return memo[n];
        }

        ulong result = n * Factorial(n - 1);
        memo[n] = result;
        return result;
    }

    public static ulong Permutations(uint n, uint r)
    {
        return Factorial(n) / Factorial(n - r);
    }
}

}