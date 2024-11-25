using System.Security.Policy;
using System.Diagnostics;
using System.Security.Cryptography.Pkcs;

namespace Coins
{
    public partial class Form1 : Form
    {
        Bitmap loaded, res;
        public float totalValue = 0;
        public float totalCoins = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                loaded = new Bitmap(openFileDialog1.FileName);
                pictureBoxCoin.Image = loaded;
            }
        }

        private void count_btn_Click(object sender, EventArgs e)
        {
            if (loaded == null) { return; }
            DIP.Binary(ref loaded);
            pictureBoxCoin.Image = loaded;

            List<Coin> detectedCoins = Algorithms.ListCoins(loaded);

            totalCoins = detectedCoins.Count;
            totalValue = detectedCoins.Sum(coin => coin.Value);

            coinsLabel.Text = $"{totalCoins}";
            valueLabel.Text = $"{(float)Math.Ceiling(totalValue * 100) / 100}";

            listBoxCoins.Items.Clear();
            foreach (var coin in detectedCoins)
            {
                listBoxCoins.Items.Add($"Coin: Value = {coin.Value}, Pixel Count = {coin.PixelCount}");
            }
        }

    }
}
