namespace discoball
{
    partial class solo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(solo));
            this.bola = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bola
            // 
            this.bola.BackColor = System.Drawing.Color.Transparent;
            this.bola.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bola.BackgroundImage")));
            this.bola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bola.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bola.FlatAppearance.BorderSize = 0;
            this.bola.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bola.ForeColor = System.Drawing.Color.Transparent;
            this.bola.Image = ((System.Drawing.Image)(resources.GetObject("bola.Image")));
            this.bola.Location = new System.Drawing.Point(383, 209);
            this.bola.Name = "bola";
            this.bola.Size = new System.Drawing.Size(34, 33);
            this.bola.TabIndex = 3;
            this.bola.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Location = new System.Drawing.Point(-1, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 126);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // solo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(845, 475);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bola);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "solo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1 Jugador";
            this.Load += new System.EventHandler(this.solo_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.solo_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.solo_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bola;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}