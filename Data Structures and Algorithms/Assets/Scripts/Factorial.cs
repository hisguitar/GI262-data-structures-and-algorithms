public class Factorial
{
    int factorial(int n)
    {
        // Exit condition
        if (n == 1)
        {
            return 1;
        }
        /*
        Recursive condition
        5! = 5*4*3*2*1
        4! = 4*3*2*1
        3! = 3*2*1
        2! = 2*1
        1! = 1
        n! = n * (n-1)!
        */
        else
        {
            return n * factorial(n-1)!;
        }
    }
}