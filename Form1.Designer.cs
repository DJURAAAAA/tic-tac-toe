namespace TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            easyEnemyBTN = new Button();
            mediunEnemyBTN = new Button();
            hardEnemyBTN = new Button();
            impossibleEnemyBTN = new Button();
            showEnemyPIC = new PictureBox();
            acceptBTN = new Button();
            declineBTN = new Button();
            showBotStatsLBL = new Label();
            ((System.ComponentModel.ISupportInitialize)showEnemyPIC).BeginInit();
            SuspendLayout();
            // 
            // easyEnemyBTN
            // 
            easyEnemyBTN.BackColor = Color.Lime;
            easyEnemyBTN.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            easyEnemyBTN.Location = new Point(695, 30);
            easyEnemyBTN.Name = "easyEnemyBTN";
            easyEnemyBTN.Size = new Size(221, 147);
            easyEnemyBTN.TabIndex = 0;
            easyEnemyBTN.Text = "EASY";
            easyEnemyBTN.UseVisualStyleBackColor = false;
            easyEnemyBTN.Click += easyEnemyBTN_Click;
            // 
            // mediunEnemyBTN
            // 
            mediunEnemyBTN.BackColor = Color.Yellow;
            mediunEnemyBTN.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mediunEnemyBTN.Location = new Point(695, 202);
            mediunEnemyBTN.Name = "mediunEnemyBTN";
            mediunEnemyBTN.Size = new Size(221, 147);
            mediunEnemyBTN.TabIndex = 1;
            mediunEnemyBTN.Text = "MEDIUM";
            mediunEnemyBTN.UseVisualStyleBackColor = false;
            mediunEnemyBTN.Click += mediunEnemyBTN_Click;
            // 
            // hardEnemyBTN
            // 
            hardEnemyBTN.BackColor = Color.Red;
            hardEnemyBTN.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hardEnemyBTN.Location = new Point(695, 372);
            hardEnemyBTN.Name = "hardEnemyBTN";
            hardEnemyBTN.Size = new Size(221, 147);
            hardEnemyBTN.TabIndex = 2;
            hardEnemyBTN.Text = "HARD";
            hardEnemyBTN.UseVisualStyleBackColor = false;
            hardEnemyBTN.Click += hardEnemyBTN_Click;
            // 
            // impossibleEnemyBTN
            // 
            impossibleEnemyBTN.BackColor = Color.Fuchsia;
            impossibleEnemyBTN.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            impossibleEnemyBTN.Location = new Point(695, 539);
            impossibleEnemyBTN.Name = "impossibleEnemyBTN";
            impossibleEnemyBTN.Size = new Size(221, 147);
            impossibleEnemyBTN.TabIndex = 3;
            impossibleEnemyBTN.Text = "IMPOSSIBLE";
            impossibleEnemyBTN.UseVisualStyleBackColor = false;
            impossibleEnemyBTN.Click += impossibleEnemyBTN_Click;
            // 
            // showEnemyPIC
            // 
            showEnemyPIC.BackgroundImageLayout = ImageLayout.Stretch;
            showEnemyPIC.Location = new Point(89, 42);
            showEnemyPIC.Name = "showEnemyPIC";
            showEnemyPIC.Size = new Size(506, 450);
            showEnemyPIC.TabIndex = 4;
            showEnemyPIC.TabStop = false;
            // 
            // acceptBTN
            // 
            acceptBTN.BackColor = Color.Lime;
            acceptBTN.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            acceptBTN.Location = new Point(64, 539);
            acceptBTN.Name = "acceptBTN";
            acceptBTN.Size = new Size(202, 91);
            acceptBTN.TabIndex = 5;
            acceptBTN.Text = "ACCEPT";
            acceptBTN.UseVisualStyleBackColor = false;
            acceptBTN.Click += acceptBTN_Click;
            // 
            // declineBTN
            // 
            declineBTN.BackColor = Color.Red;
            declineBTN.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            declineBTN.Location = new Point(423, 539);
            declineBTN.Name = "declineBTN";
            declineBTN.Size = new Size(202, 91);
            declineBTN.TabIndex = 6;
            declineBTN.Text = "DECLINE";
            declineBTN.UseVisualStyleBackColor = false;
            // 
            // showBotStatsLBL
            // 
            showBotStatsLBL.AutoSize = true;
            showBotStatsLBL.BackColor = Color.Transparent;
            showBotStatsLBL.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showBotStatsLBL.Location = new Point(223, 505);
            showBotStatsLBL.Name = "showBotStatsLBL";
            showBotStatsLBL.Size = new Size(230, 31);
            showBotStatsLBL.TabIndex = 7;
            showBotStatsLBL.Text = "....................................";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(942, 698);
            Controls.Add(showBotStatsLBL);
            Controls.Add(declineBTN);
            Controls.Add(acceptBTN);
            Controls.Add(showEnemyPIC);
            Controls.Add(impossibleEnemyBTN);
            Controls.Add(hardEnemyBTN);
            Controls.Add(mediunEnemyBTN);
            Controls.Add(easyEnemyBTN);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "TicTacToe";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)showEnemyPIC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button easyEnemyBTN;
        private Button mediunEnemyBTN;
        private Button hardEnemyBTN;
        private Button impossibleEnemyBTN;
        private PictureBox showEnemyPIC;
        private Button acceptBTN;
        private Button declineBTN;
        private Label showBotStatsLBL;
    }
}
