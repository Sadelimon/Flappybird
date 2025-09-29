namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BoruUst = new System.Windows.Forms.PictureBox();
            this.Zemin = new System.Windows.Forms.PictureBox();
            this.Kus = new System.Windows.Forms.PictureBox();
            this.BoruAlt = new System.Windows.Forms.PictureBox();
            this.ScoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zemin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt)).BeginInit();
            this.SuspendLayout();
            // 
            // BoruUst
            // 
            this.BoruUst.Image = global::WindowsFormsApp1.Properties.Resources.pipe_green1;
            this.BoruUst.Location = new System.Drawing.Point(369, -164);
            this.BoruUst.Name = "BoruUst";
            this.BoruUst.Size = new System.Drawing.Size(80, 322);
            this.BoruUst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruUst.TabIndex = 0;
            this.BoruUst.TabStop = false;
            // 
            // Zemin
            // 
            this.Zemin.Image = global::WindowsFormsApp1.Properties.Resources._base;
            this.Zemin.Location = new System.Drawing.Point(-7, 431);
            this.Zemin.Name = "Zemin";
            this.Zemin.Size = new System.Drawing.Size(626, 132);
            this.Zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Zemin.TabIndex = 0;
            this.Zemin.TabStop = false;
            // 
            // Kus
            // 
            this.Kus.BackColor = System.Drawing.Color.Transparent;
            this.Kus.Image = global::WindowsFormsApp1.Properties.Resources.bluebird_upflap;
            this.Kus.Location = new System.Drawing.Point(32, 220);
            this.Kus.Name = "Kus";
            this.Kus.Size = new System.Drawing.Size(49, 36);
            this.Kus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Kus.TabIndex = 0;
            this.Kus.TabStop = false;
            // 
            // BoruAlt
            // 
            this.BoruAlt.Image = global::WindowsFormsApp1.Properties.Resources.pipe_green;
            this.BoruAlt.Location = new System.Drawing.Point(369, 317);
            this.BoruAlt.Name = "BoruAlt";
            this.BoruAlt.Size = new System.Drawing.Size(80, 321);
            this.BoruAlt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoruAlt.TabIndex = 0;
            this.BoruAlt.TabStop = false;
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.BackColor = System.Drawing.Color.Transparent;
            this.ScoreText.Font = new System.Drawing.Font("Lato", 40.07547F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreText.ForeColor = System.Drawing.SystemColors.Control;
            this.ScoreText.Location = new System.Drawing.Point(265, 21);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(64, 71);
            this.ScoreText.TabIndex = 1;
            this.ScoreText.Text = "0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(613, 559);
            this.Controls.Add(this.BoruUst);
            this.Controls.Add(this.Zemin);
            this.Controls.Add(this.Kus);
            this.Controls.Add(this.BoruAlt);
            this.Controls.Add(this.ScoreText);
            this.Name = "Form1";
            this.Text = "FlappyBird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.BoruUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zemin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoruAlt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BoruAlt;
        private System.Windows.Forms.PictureBox Kus;
        private System.Windows.Forms.PictureBox Zemin;
        private System.Windows.Forms.PictureBox BoruUst;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}

