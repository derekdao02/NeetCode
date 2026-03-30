internal class Program
{
    private static void Main(string[] args)
    {
        Solution solution = new Solution();

        int[][] images = new int[][]{
            new int[] {1,1,1},
            new int[] {1,1,0},
            new int[] {1,0,1}
        };

        var sr = 1;
        var sc = 1;
        var color = 2;
        var result = solution.FloodFill(images, sr, sc, color);

        PrintGrid(result);
    }

    public static void PrintGrid(int[][] grid)
    {
        // grid.Length total row
        // grid[i].Length is total item in row
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                Console.Write(grid[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
