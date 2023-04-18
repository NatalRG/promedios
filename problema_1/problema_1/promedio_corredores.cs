using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            String  valJ, ValC, valR, ValP, ValRa, ValD;
            string[] corredores = { "Juan", "Carlos", "Roberto", "Pedro", "Raul", "David" };
            double[] tiempo_Juan = new double[6], tiempo_Carlos = new double[6], tiempo_Pedro = new double[6], tiempo_Roberto = new double[6], tiempo_Raul = new double[6], tiempo_David = new double[6], PROMEDIOS = new double[6], PROMEDIOS2 = new double[6];
            double pmd_J = 0, pmd_C = 0, pmd_P = 0, pmd_R = 0, pmd_Ra = 0, pmd_D = 0, valJ_num, valC_num, valR_num, valP_num, valRa_num, valD_num;
            int posicion = 0, posicion2 = 0;

                Console.Write("Ingrese los tiempos de Juan" + "\n");
                for (int i = 0; i < tiempo_Juan.Length; i++)
                {
                    Console.Write("Ingrese el tiempo numero " + i + " : " + "\n");
                    valJ = Console.ReadLine();
                    valJ_num = double.Parse(valJ);
                    if (valJ_num >= 10.1 && valJ_num <= 10.4)
                    {
                        tiempo_Juan[i] = valJ_num;
                        pmd_J = pmd_J + valJ_num;
                    }
                    else
                    {
                        Console.Write("Valor erroneo" + "\n");
                        i = i - 1;
                    }
                }

                Console.Write("Ingrese los tiempos de Carlos" + "\n");
                for (int j = 0; j < tiempo_Carlos.Length; j++)
                {
                    Console.Write("Ingrese el tiempo numero " + j + " : " + "\n");
                    ValC = Console.ReadLine();
                    valC_num = double.Parse(ValC);
                    if (valC_num >= 10.1 && valC_num <= 10.4)
                    {
                        tiempo_Carlos[j] = valC_num;
                        pmd_C = pmd_C + valC_num;
                    }
                    else
                    {
                        Console.Write("Valor erroneo" + "\n");
                        j = j - 1;
                    }
                }

               Console.Write("Ingrese los tiempos de Roberto" + "\n");
                for (int a = 0; a < tiempo_Carlos.Length; a++)
                {
                    Console.Write("Ingrese el tiempo numero " + a + " : " + "\n");
                    valR = Console.ReadLine();
                    valR_num = double.Parse(valR);
                    if (valR_num >= 10.1 && valR_num <= 10.4)
                    {
                        tiempo_Roberto[a] = valR_num;
                        pmd_R = pmd_R + valR_num;
                    }
                    else
                    {
                        Console.Write("Valor erroneo" + "\n");
                        a = a - 1;
                    }
                }
          
               Console.Write("Ingrese los tiempos de Pedro" + "\n");
                for (int s = 0; s < tiempo_Carlos.Length; s++)
                {
                    Console.Write("Ingrese el tiempo numero " + s + " : " + "\n");
                    ValP = Console.ReadLine();
                    valP_num = double.Parse(ValP);
                    if (valP_num >= 10.1 && valP_num <= 10.4)
                    {
                        tiempo_Pedro[s] = valP_num;
                        pmd_P = pmd_P + valP_num;
                    }
                    else
                    {
                        Console.Write("Valor erroneo" + "\n");
                        s = s - 1;
                    }
                }
  
                Console.Write("Ingrese los tiempos de Raul" + "\n");
                for (int n = 0; n < tiempo_Carlos.Length; n++)
                {
                    Console.Write("Ingrese el tiempo numero " + n + " : " + "\n");
                    ValRa = Console.ReadLine();
                    valRa_num = double.Parse(ValRa);
                    if (valRa_num >= 10.1 && valRa_num <= 10.4)
                    {
                        tiempo_Raul[n] = valRa_num;
                        pmd_Ra = pmd_Ra + valRa_num;
                    }
                    else
                    {
                        Console.Write("Valor erroneo" + "\n");
                        n = n - 1;
                    }
                }

                Console.Write("Ingrese los tiempos de David" + "\n");
                for (int y = 0; y < tiempo_Carlos.Length; y++)
                {
                    Console.Write("Ingrese el tiempo numero " + y + " : " + "\n");
                    ValD = Console.ReadLine();
                    valD_num = double.Parse(ValD);
                    if (valD_num >= 10.1 && valD_num <= 10.4)
                    {
                        tiempo_David[y] = valD_num;
                        pmd_D = pmd_D + valD_num;
                    }
                    else
                    {
                        Console.Write("Valor erroneo" + "\n");
                        y = y - 1;
                    }
                } 

            PROMEDIOS[0] = pmd_J / 6;
            PROMEDIOS[1] = pmd_C / 6;
            PROMEDIOS[2] = pmd_R / 6;
            PROMEDIOS[3] = pmd_P / 6;
            PROMEDIOS[4] = pmd_Ra / 6;
            PROMEDIOS[5] = pmd_D / 6;

            double menor = PROMEDIOS[0];

            for (int h = 0; h < 6; h++)
            {
                if (PROMEDIOS[h] < menor)
                {
                    menor = PROMEDIOS[h];
                }


            }
            for (int r = 0; r < 6; r++)
            {
                if (PROMEDIOS[r] == menor)
                {
                    posicion = r;
                }
            }

            String nombre = corredores[posicion];

            Console.Write("\n\nEl mejor tiempo es de : " + corredores[posicion] + " y su promedio fue de: " + PROMEDIOS[posicion]);

            PROMEDIOS = PROMEDIOS.Where(val => val != menor).ToArray();
            corredores = corredores.Where(val => val != nombre).ToArray();

            double menor2 = PROMEDIOS[0];

            for (int h = 0; h < PROMEDIOS.Length; h++)
            {
                if (PROMEDIOS[h] < menor2)
                {
                    menor2 = PROMEDIOS[h];
                }


            }
            for (int r = 0; r < PROMEDIOS.Length; r++)
            {
                if (PROMEDIOS[r] == menor2)
                {
                    posicion2 = r;
                }
            }

            Console.Write("\n\nEl segundo mejor tiempo es de : " + corredores[posicion2] + " y su promedio fue de: " + PROMEDIOS[posicion2]);
            Console.ReadKey();
        }
    }
}







