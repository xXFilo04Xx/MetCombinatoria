using System;

namespace EquaioniLibrary
{
    public class Equazioni
    {
            private static int Fattoriale(int n)
            {
                if (n < 0)
            {
                return 0;
            }
                else if (n <= 1)
            {
                return 1;
            }   
                else
                {
                    int prodotto = 1;
                    for (int i = 2; i <= n; i++)
                    {
                        prodotto *= i;
                    }
                    return prodotto;
                }
            }
    }
}
