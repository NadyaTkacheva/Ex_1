namespace Task_1
{
    class Program
    {
        static void solve1()
        {
            int[] countDiff = new int[10001];
            int[] sumDiff = new int[10001];
            for (int i = 0; i < countDiff.Length; i++)
            {
                countDiff[i] = 0;
                sumDiff[i] = 0;
            }           
            int n = System.Convert.ToInt16(System.Console.ReadLine());
            for (int i = 0; i < n; i++)
            { 
                int begin = System.Convert.ToInt16(System.Console.ReadLine());
                int end = System.Convert.ToInt16(System.Console.ReadLine());
                countDiff[begin]++;
                countDiff[end]--;
                sumDiff[begin] += i;
                sumDiff[end] -= i;
                
            }
            bool[] isSingle = new bool[n];
            for (int i = 0; i < isSingle.Length; i++)
            {
                isSingle[i] = false;
            }
            int minCount = System.Int32.MaxValue;
            int curCount = 0;
            int curSum = 0;
            for (int i = 0; i < 10000; i++)
            {
                curCount += countDiff[i];
                minCount = System.Math.Min(minCount, curCount);
                curSum += sumDiff[i];
                if (curCount == 1)
                {
                    isSingle[curSum] = true;
                }
            }
            if (minCount != 1)
            {
                System.Console.WriteLine("Wrong Answer") ;
                return;                
            }
            for (int i = 0; i < n; i++)
            {
                if (!isSingle[i])
                {
                    System.Console.WriteLine("Wrong Answer");
                    return;
                }
            }
            System.Console.WriteLine("Accepted");
        }
        static void Main()
        {   

            
            int t = System.Convert.ToInt16(System.Console.ReadLine());          
            for (int i = 0; i < t; i++)
            {
                
              solve1();                
            }

            

        }
    }
}
