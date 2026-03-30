
class Solution
{
    public Solution() { }

    // Input: image = [[1,1,1],[1,1,0],[1,0,1]], sr = 1, sc = 1, color = 2
    // Output: [[2,2,2],[2,2,0],[2,0,1]]
    public int[][] FloodFill(int[][] image, int sr, int sc, int color)
    {
        int starC = image[sr][sc];
        recur(image, sr, sc, color, starC);

        return image;
    }

    private void recur(int[][] image, int sr, int sc, int color, int starC)
    {
        if (sr >= image.Length || sc >= image[0].Length || sr < 0 || sc < 0 || image[sr][sc] == color || image[sr][sc] != starC)
            return;

        image[sr][sc] = color;
        recur(image, sr + 1, sc, color, starC);
        recur(image, sr - 1, sc, color, starC);
        recur(image, sr, sc + 1, color, starC);
        recur(image, sr, sc - 1, color, starC);
    }
}
