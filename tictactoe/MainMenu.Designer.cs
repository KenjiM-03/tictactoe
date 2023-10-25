namespace tictactoe
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.pvp = new System.Windows.Forms.Button();
            this.pvai = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pvp
            // 
            this.pvp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pvp.Location = new System.Drawing.Point(34, 58);
            this.pvp.Name = "pvp";
            this.pvp.Size = new System.Drawing.Size(144, 113);
            this.pvp.TabIndex = 0;
            this.pvp.Text = "Play with a Friend";
            this.pvp.UseVisualStyleBackColor = true;
            this.pvp.Click += new System.EventHandler(this.pvp_Click);
            // 
            // pvai
            // 
            this.pvai.Location = new System.Drawing.Point(433, 58);
            this.pvai.Name = "pvai";
            this.pvai.Size = new System.Drawing.Size(151, 113);
            this.pvai.TabIndex = 1;
            this.pvai.Text = "Practice vs AI";
            this.pvai.UseVisualStyleBackColor = true;
            this.pvai.Click += new System.EventHandler(this.btn_pvai_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pvp);
            this.groupBox1.Controls.Add(this.pvai);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 304);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 189);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose a Mode";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(193, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 273);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 505);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainMenu";
            this.Text = "Nine-Dash-Grid";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button pvp;
        private Button pvai;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
    }
}