using System;

namespace Assignment1_S19
{
    class Program
    {
        public static void Main()
        {
            int a = 5, b = 100;
            printPrimeNumbers(a, b);
            

            int n1 = 5;
            double r1 = getSeriesResult(n1);
            Console.WriteLine("\n The sum of the series is: " + r1);


            long n2 = 15;
            long r2 = decimalToBinary(n2);
            Console.WriteLine("\n Binary conversion of the decimal number " + n2 + " is: " + r2);
            
            

            long n3 = 1101;
            long r3 = binaryToDecimal(n3);
            Console.WriteLine("\n Decimal conversion of the binary number " + n3 + " is: " + r3); 
          
            int n4 = 5;
            printTriangle(n4);

            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr); 

            // This assignment helped me in learning basic C# programming concepts
            // Some questions were very challenging and helped as a refresher to programming concepts I learnt earlier.
            // I enjoyed working on this assignment and it helped in improving logical concepts. 
            Console.ReadKey();
        }

        public static void printPrimeNumbers(int x, int y)
        {
            try
            {
                if (x <= y) {
                    for (; x <= y; x++) {
                        Boolean isPrime = true;
                        for (int i = 2; i < x; i++) {
                            if (x % i == 0) {
                                isPrime = false;
                                break;
                            }
                        }
                        if (isPrime) {
                            Console.Write(x + " ");
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
        }

        public static double getSeriesResult(int n)
        {
            try
            {

                double seriesResult = 0;
                for (double i = 1; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        seriesResult += -(getFactorial(i) / (i + 1));
                    }
                    else
                    {
                        seriesResult += (getFactorial(i) / (i + 1));
                    }
                }

                return seriesResult;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }

            return 0;
        }

        public static int getFactorial(double a)
        {
            int fact = 1;
            for (int x = 1; x <= a; x++)
            {
                fact = fact * x;
            }

            return fact;
        }

        public static long decimalToBinary(long n)
        {
            try
            {

                long q, r2, d;
                d = n;
                string mystrng = "";
                while (n > 0)
                {
                    r2 = n % 2;
                    mystrng += Convert.ToString(r2);
                    n /= 2;
                }
                string strF = "";
                int Length = mystrng.Length - 1;
                while (Length >= 0)
                {
                    strF = strF + mystrng[Length];
                    Length--;
                }
                q = Convert.ToInt64(strF);
                return q;

            }
            
            catch
            {
                Console.WriteLine("Exception occured while computing decimalToBinary()");
            }

            return 0;
        }

        public static long binaryToDecimal(long n)
        {
            try
            {
                long value;
                long nowValue;
                long power2 = 1;
                long decimalV= 0;
                while(n>0)
                {
                    value = n % 10;
                    
                    decimalV += value * power2;
                    nowValue = n / 10;
                    n = nowValue;
                    power2 = power2 * 2;

                }

                return decimalV;
               
            }
            catch
            {
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
            }

            return 0;
        }

        public static void printTriangle(int n)
        {
            try
            {
                int i,j;
                for(i=0;i<n;i++)
                {
                    for (j = 1; j <= n - i; j++)
                        Console.Write(" ");
                    for (j = 1; j <= 2 * i - 1; j++)
                        Console.Write("*");
                    Console.Write("\n");
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static void computeFrequency(int[] a)
        {
            try
            {
                int[] f = new int[a.Length];
                int ctr;
                for (int i = 0; i < a.Length; i++)
                {

                    f[i] = -1;
                }
                for (int i = 0; i < a.Length; i++)
                {
                    ctr = 1;
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            ctr += 1;
                            f[j] = 0;
                        }
                    }

                    if (f[i] != 0)
                    {
                        f[i] = ctr;
                    }
                }
                Console.Write("\n Number"+"\t"+"Frequency \n");
                for (int i = 0; i < a.Length; i++)
                {
                    if (f[i] != 0)
                    {
                        Console.Write(a[i]+"\t"+ f[i]+"\n");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }

    }


}

