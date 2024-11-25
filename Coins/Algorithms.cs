using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace Coins
{
    public class DIP
    {
        public static void GreyScale(ref Bitmap a)
        {
            Color pixel;
            int avg;
            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    pixel = a.GetPixel(x, y);
                    avg = (pixel.R + pixel.G + pixel.B) / 3;
                    Color gray = Color.FromArgb(avg, avg, avg);
                    a.SetPixel(x, y, gray);
                }
            }
        }
        public static void Binary(ref Bitmap a)
        {
            Color pixel;
            int avg;
            int threshold = 200;
            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    pixel = a.GetPixel(x, y);
                    avg = (pixel.R + pixel.G + pixel.B) / 3;
                    if (avg < threshold)
                    {
                        a.SetPixel(x, y, Color.Black);
                    }
                    else
                    {
                        a.SetPixel(x, y, Color.White);
                    }
                }
            }
        }
    }
    public class Coin
    {
        public int PixelCount { get; set; }
        public float Value { get; set; }
    }
    public class Algorithms
    {
        public const float PESO_FIVE = 5;
        public const float PESO_ONE = 1;
        public const float CENT_TWENTY_FIVE = 0.25f;
        public const float CENT_TEN = 0.10f;
        public const float CENT_FIVE = 0.05f;
        public static bool isBlack(Color a)
        {
            return a.R == 0;
        }
        public static List<Coin> ListCoins(Bitmap a)
        {
            List<Coin> coinsList = new List<Coin>();
            Color pixel;
            bool[,] visited = new bool[a.Width, a.Height];

            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    if (visited[x, y])
                    {
                        continue;
                    }
                    else
                    {
                        visited[x, y] = true;
                        pixel = a.GetPixel(x, y);

                        if (isBlack(pixel))
                        {
                            int pixelCount = BreadFirstSearch(ref a, ref visited, x, y);
                            if (pixelCount < 1000)
                            {
                                continue;
                            }
                            else
                            {
                                Coin coin = new Coin
                                {
                                    PixelCount = pixelCount,
                                    Value = GetCoin(pixelCount)
                                };
                                coinsList.Add(coin);
                            }
                        }
                    }
                }
            }
            return coinsList;
        }


        public static void CountCoins(Bitmap a, ref float res, ref float count)
        {
            Color pixel;
            bool[,] visited = new bool[a.Width, a.Height];

            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    if (visited[x, y])
                    {
                        continue;
                    }
                    else
                    {
                        visited[x, y] = true;

                        pixel = a.GetPixel(x, y);
                        int pixelCount;

                        if (isBlack(pixel))
                        {
                            pixelCount = BreadFirstSearch(ref a, ref visited, x, y);
                            if (pixelCount < 1000)
                            {
                                continue;
                            }
                            else
                            {
                                count++;
                                res += GetCoin(pixelCount);
                            }
                        }
                    }
                }
            }
        }
        public static int BreadFirstSearch(ref Bitmap a, ref bool[,] visited, int x, int y)
        {
            Queue<int[]> queue = new Queue<int[]>();
            queue.Enqueue([x, y]);
            int pixelCount = 0;
            int[] top;
            while (queue.Count > 0)
            {
                top = queue.Dequeue();
                pixelCount++;
                int currX = top[0], currY = top[1];

                if (currY - 1 >= 0 && a.GetPixel(currX, currY - 1).R == 0 && !visited[currX, currY - 1])
                {
                    queue.Enqueue([currX, currY - 1]);
                    visited[currX, currY - 1] = true;
                }
                if (currY + 1 < a.Height && a.GetPixel(currX, currY + 1).R == 0 && !visited[currX, currY + 1])
                {
                    queue.Enqueue([currX, currY + 1]);
                    visited[currX, currY + 1] = true;
                }
                if (currX - 1 >= 0 && a.GetPixel(currX - 1, currY).R == 0 && !visited[currX - 1, currY])
                {
                    queue.Enqueue([currX - 1, currY]);
                    visited[currX - 1, currY] = true;
                }
                if (currX + 1 < a.Width && a.GetPixel(currX + 1, currY).R == 0 && !visited[currX + 1, currY])
                {
                    queue.Enqueue([currX + 1, currY]);
                    visited[currX + 1, currY] = true;
                }

            }
            return pixelCount;
        }
        public static float GetCoin(int pixelCount)
        {
            if (pixelCount > 7000)
                return PESO_FIVE;
            if (pixelCount > 5000)
                return PESO_ONE;
            if (pixelCount > 4000)
                return CENT_TWENTY_FIVE;
            if (pixelCount > 3000)
                return CENT_TEN;
            if (pixelCount > 1000)
                return CENT_FIVE;
            return 0;
        }
    }

}

