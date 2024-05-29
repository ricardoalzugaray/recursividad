using System;

namespace GenerarNumerosPrimos
{
    class Program
    {
        #region Verificar  Primo
        static bool EsPrimo(int num)
        {
            return !EsDivisible(num, num - 1);
        }
        #endregion Verificar Primo
        static bool EsDivisible(int num, int D)
        {
            if (D > 2)
            {
                return num % D == 0 || EsDivisible(num, D - 1);
            }
            else
            {
                return num % 2 == 0;

            }
        }
            static void Main(string[] args)
            {
                int desdeNum, hastaNum;
                bool resultado;

                Console.WriteLine("Ingrese el intervalo");
                desdeNum = Convert.ToInt32(Console.ReadLine());
                hastaNum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n Los números generados desde {0} a {1} son:", desdeNum, hastaNum);

                for (int num = desdeNum; num <= hastaNum; num++)
                {
                    resultado = EsPrimo(num);

                    if (resultado)
                    {
                        Console.WriteLine(num);
                    }
                }
                Console.ReadKey();
            }
        }
    }

