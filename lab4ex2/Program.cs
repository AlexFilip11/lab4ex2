using System;

namespace lab4ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cititi de la tastatura continutul unei matrici de intregi cu 3 dimensiuni avand lungimile n, m, k.Lungimile celor trei dimensiuni ale matricii, n, m si k, vor fi citite de la tastaura.
            // Scrieti o functie care va calcula suma elementelor unei astfel de matrici, apelati-o si afisati-i rezultatul.
            // Scrieti o functie care va determina elementul cu valoare maxima, apelati-o si afisati-i rezultatul.
            Console.WriteLine("Introduceti prima dimensiune a vectorului ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti a doua dimensiune a vectorului ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti a treia dimensiune a vectorului ");
            int k = int.Parse(Console.ReadLine());
            int[,,] matrice = ReadMatrix(n, m, k);
            Console.WriteLine("Suma elementelor matricei este "+ AddMatixElements(matrice));
            Console.WriteLine("Valoarea maxima din matrice este " + MaxValueMatrix(matrice));
            
        }
        static int[,,] ReadMatrix(int n, int m, int k)
        {
            Console.WriteLine("Introduceti Matricea: ");
            int[,,] result = new int[n, m, k];
            for (int h = 0; h < n; h++)
                for (int i = 0; i < m; i++)
                    for (int j = 0; j < k; j++)
                    {
                        result[h, i, j] = int.Parse(Console.ReadLine());
                    }
            return result;
        }
        static int AddMatixElements(int[,,] matrix)
        {
            int suma = 0;
            for (int h = 0; h < matrix.GetLength(0); h++)
                for (int i = 0; i < matrix.GetLength(1); i++)
                    for (int j = 0; j < matrix.GetLength(2); j++)
                    {
                        suma += matrix[h, i, j];
                    }
            return suma;
        }
        static int MaxValueMatrix(int[,,]matrix)
        {
            int max = matrix[0, 0, 0];
            for (int h = 0; h < matrix.GetLength(0); h++)
                for (int i = 0; i < matrix.GetLength(1); i++)
                    for (int j = 0; j < matrix.GetLength(2); j++)
                    {
                        if (max <= matrix[h, i, j])
                            max = matrix[h, i, j];
                    }
            return max;
        }
    }
}

