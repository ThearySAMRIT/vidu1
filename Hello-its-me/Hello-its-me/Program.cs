using System;

namespace Hello_its_me
{
    class Program
    {
        static void Main(string[] args)
        {
            uint m, n,s=1,d=0;
            Console.WriteLine("imput n");
            n = uint.Parse(Console.ReadLine());
            Console.WriteLine("imput m");
            m = uint.Parse(Console.ReadLine());
            for (uint i = n; i <= m; i++)
            {
                int sum=0, factorial;
                uint cure;
                cure = i;
                while (cure != 0)
                {
                    factorial = 1;
                    for(int j=1;j<=cure%10;j++)
                    {
                        factorial *= j;
                    }
                    cure = cure / 10;
                    sum += factorial;
                }

                if (sum == i)
                {
                    Console.WriteLine("strong number is = {0}", sum);
                }
            }
            Console.ReadLine();
        }
    }
}
