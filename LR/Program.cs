namespace LR_pbinfo2623
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v;
            int n = int.Parse(Console.ReadLine());
            v = new int[n];
            string[] v2 = new string[n];
            int[] L = new int[n];
            int[] R = new int[n];
            v2 = Console.ReadLine().Split(' ');
            int a = 0;
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(v2[i]);
                //Console.Write(v[i]+" "); 
                if (v[i] >= a)
                {
                    a = v[i];
                    L[i] = a;
                }
                else
                {
                    L[i] = a;
                }
            }
            int b = v[n - 1];
            for (int i = n - 1; i >= 0; i--)
            {
                if (b > v[i])
                {
                    b = v[i];
                    R[i] = b;
                }
                else
                {
                    R[i] = b;
                }
            }
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                if (R[i] == L[i])
                {
                    s++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(L[i]+" ");
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write(R[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine(s);
        }
    }
}