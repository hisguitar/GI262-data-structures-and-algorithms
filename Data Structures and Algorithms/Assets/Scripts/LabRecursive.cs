public class LabRecursive
{
    int power(int b = 2, int a = 4)
    {
        if (a == 0)
        {
            return 1;
        }
        else
        {
            return (b * power(b, a - 1));
        }
    }
}