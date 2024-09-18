using System;

class Arrays {
    public static void Main(string[] args) {
        /*
          Collections:
            - Arrays(T[]): Tamanho fixo, indexado, mutável e permite duplicatas
        */

        // Single-dimensional array example
        // int[] numbers = new int[] {5, 2, 7, 3, 1, 9, 4, 6, 8};
        // Console.WriteLine(numbers[4]);
        // numbers[4] = 10;
        // foreach(int n in numbers) {
        //     Console.WriteLine(n);
        // }

        // Multi-dimensional array example
        int[,] matrix = { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };

        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) { // Change 'i' to 'j' here
                Console.Write(" | " + matrix[i, j]);
            }
            Console.WriteLine(" |");
        }
    }
}
