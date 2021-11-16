using System;
using System.Collections.Generic;
using System.Text;

namespace CharecterPatterns
{
    class LetterPatters
    {
        public void StarPatternA()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 1 || j == 1 || i == 3 || j == 5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(" ");
            }
        }
        public void StarPatternB()
        {
            for (int i=1;i<=5;i++)
            {
                for (int j=1;j<=5;j++)
                {
                    if (i == 1 || j == 1 || i==5 ||i==3|| j==5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void StarPatternC()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 1 || j == 1 || i == 5 )
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void StarPatternD()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 1 || j == 1 || i == 5  || j==5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void StarPatternE()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 1 || j == 1 || i == 3 || i == 5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void StarPatternF()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 1 || j == 1 || i == 3 )
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void StarPatternG()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 1 || j == 1 ||i==5 || j== 5 && i >= 3 || i==3 && j>=3)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void StarPatternH()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (j==1 ||j==5 || i==3)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void StarPatternI()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 1 || i == 5 || j == 3)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void StarPatternJ()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 1 || j == 3 ||i==5 && j<=3 ||j==1 && i>=3 )
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void StarPatternK()
        {
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (j == 1 || j+i == 6 || i-j ==3)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void StarPatternL()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (j == 1 || i==5 )
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void StarPatternM()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (j == 1 || j == 5 || i == 2 && j >= 2 && j <= 2 || i == 3 && j == 3 ||i==2 && j==4)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void StarPatternN()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (j == 1 || j==5 ||i-j==0|| i==2 && j>=2 && j<=2 ||i==3 && j==3)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void StarPatternO()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    if(i==1 && j>=2 && j<=4 || i==5 && j>=2 &&j<=4 || j==1 && i>=2 && i<=4 || j==5 && i>=2 && i<=4 )
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void StarPatternP()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 1 || j == 1 || i==3 || j == 5 && i <= 3)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void StarPatternQ()
        {
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    if (i == 1  && j >= 2 && j <= 5 || i==6 && j>=2 && j<=5 ||j==1 &&i>=2 && i<=5 ||j==6 && i >= 2 && i <= 5 ||i==5 && i-j==0 || i == 6 && i - j == 0 || i==7 && i-j ==0)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void StarPatternR()
        {
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    if (j==1 || i==1 && j<=4||i==3 && j<=4 || j==4 && i>=1 && i<=2 || j==i-1 )
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void StarPatternS()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i==1 || i==5 ||j==1 &&i<=2 || i==3 ||j==5 && i>=4 )
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void StarPatternT()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 1 || j== 3)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void StarPatternU()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (j == 1 || j == 5 ||i==5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void StarPatternV()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (i-j ==0 || i+j ==10 )
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void StarPatternW()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if ( j==1 || j==5 ||i - j == 0 && j>=4 &&j<=4 ||i+j==6  && j>=2 && j<=3)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void StarPatternX()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (i - j == 0 || i + j == 6)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void StarPatternY()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (i - j == 0  && j<=3 || i+j==6)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void StarPatternZ()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i==1||i==5 || i+j ==6) 
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
