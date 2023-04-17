namespace lab7
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gameTime = new System.Windows.Forms.Timer(this.components);
            this.czasGry = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.EndBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTime
            // 
            this.gameTime.Interval = 60000;
            this.gameTime.Tick += new System.EventHandler(this.gameTime_Tick);
            // 
            // czasGry
            // 
            this.czasGry.AutoSize = true;
            this.czasGry.Location = new System.Drawing.Point(560, 590);
            this.czasGry.Name = "czasGry";
            this.czasGry.Size = new System.Drawing.Size(53, 13);
            this.czasGry.TabIndex = 0;
            this.czasGry.Text = "Czas gry: ";
            // 
            // StartBtn
            // 
            this.StartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartBtn.Location = new System.Drawing.Point(515, 12);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(100, 60);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "START";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // EndBtn
            // 
            this.EndBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EndBtn.Location = new System.Drawing.Point(515, 78);
            this.EndBtn.Name = "EndBtn";
            this.EndBtn.Size = new System.Drawing.Size(100, 60);
            this.EndBtn.TabIndex = 2;
            this.EndBtn.Text = "KONIEC";
            this.EndBtn.UseVisualStyleBackColor = true;
            this.EndBtn.Click += new System.EventHandler(this.EndBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(497, 591);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(627, 612);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EndBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.czasGry);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTime;
        private System.Windows.Forms.Label czasGry;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button EndBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

