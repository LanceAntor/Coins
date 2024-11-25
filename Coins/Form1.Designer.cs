namespace Coins
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            openToolStripMenuItem = new ToolStripMenuItem();
            pictureBoxCoin = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            count_btn = new Button();
            coinsLabel = new Label();
            valueLabel = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            listBoxCoins = new ListBox();
            textBox3 = new TextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoin).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { openToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(939, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(59, 24);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // pictureBoxCoin
            // 
            pictureBoxCoin.Location = new Point(40, 40);
            pictureBoxCoin.Name = "pictureBoxCoin";
            pictureBoxCoin.Size = new Size(310, 387);
            pictureBoxCoin.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCoin.TabIndex = 1;
            pictureBoxCoin.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // count_btn
            // 
            count_btn.Location = new Point(137, 465);
            count_btn.Name = "count_btn";
            count_btn.Size = new Size(118, 63);
            count_btn.TabIndex = 2;
            count_btn.Text = "Count";
            count_btn.UseVisualStyleBackColor = true;
            count_btn.Click += count_btn_Click;
            // 
            // coinsLabel
            // 
            coinsLabel.AutoSize = true;
            coinsLabel.Font = new Font("Segoe UI", 12F);
            coinsLabel.Location = new Point(462, 194);
            coinsLabel.Name = "coinsLabel";
            coinsLabel.Size = new Size(0, 28);
            coinsLabel.TabIndex = 3;
            // 
            // valueLabel
            // 
            valueLabel.AutoSize = true;
            valueLabel.Font = new Font("Segoe UI", 12F);
            valueLabel.Location = new Point(452, 316);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new Size(0, 28);
            valueLabel.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(421, 164);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            textBox1.Text = "TOTAL COINS";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(421, 286);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 6;
            textBox2.Text = "TOTAL VALUE";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // listBoxCoins
            // 
            listBoxCoins.FormattingEnabled = true;
            listBoxCoins.Location = new Point(626, 101);
            listBoxCoins.Name = "listBoxCoins";
            listBoxCoins.Size = new Size(301, 424);
            listBoxCoins.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(725, 68);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 8;
            textBox3.Text = "COINS LIST";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 607);
            Controls.Add(textBox3);
            Controls.Add(listBoxCoins);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(valueLabel);
            Controls.Add(coinsLabel);
            Controls.Add(count_btn);
            Controls.Add(pictureBoxCoin);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem openToolStripMenuItem;
        private PictureBox pictureBoxCoin;
        private OpenFileDialog openFileDialog1;
        private Button count_btn;
        private Label coinsLabel;
        private Label valueLabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private ListBox listBoxCoins;
        private TextBox textBox3;
    }
}
