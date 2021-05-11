
namespace DinosaurGame
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dino = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.bad = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bad)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dino
            // 
            this.dino.Image = global::DinosaurGame.Properties.Resources.e00cff2d5f78554;
            this.dino.Location = new System.Drawing.Point(24, 310);
            this.dino.Name = "dino";
            this.dino.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.dino.Size = new System.Drawing.Size(85, 88);
            this.dino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dino.TabIndex = 0;
            this.dino.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::DinosaurGame.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-13, 388);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(818, 188);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // bad
            // 
            this.bad.Image = global::DinosaurGame.Properties.Resources.pipe;
            this.bad.Location = new System.Drawing.Point(558, 332);
            this.bad.Name = "bad";
            this.bad.Size = new System.Drawing.Size(67, 66);
            this.bad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bad.TabIndex = 2;
            this.bad.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Location = new System.Drawing.Point(64, 25);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(45, 15);
            this.scoreText.TabIndex = 3;
            this.scoreText.Text = "Score : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.dino);
            this.Controls.Add(this.bad);
            this.Name = "Form1";
            this.Text = "Dinosaur Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.dino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox dino;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox bad;
        private System.Windows.Forms.Label scoreText;
    }
}

