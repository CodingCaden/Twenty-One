namespace Twenty_One
{
    partial class Form1
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
            this.btn_rolldice = new System.Windows.Forms.Button();
            this.dice1box = new System.Windows.Forms.PictureBox();
            this.dice2box = new System.Windows.Forms.PictureBox();
            this.dice1 = new System.Windows.Forms.PictureBox();
            this.dice2 = new System.Windows.Forms.PictureBox();
            this.dice3 = new System.Windows.Forms.PictureBox();
            this.dice4 = new System.Windows.Forms.PictureBox();
            this.dice5 = new System.Windows.Forms.PictureBox();
            this.dice6 = new System.Windows.Forms.PictureBox();
            this.playbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dice1box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice6)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_rolldice
            // 
            this.btn_rolldice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rolldice.Location = new System.Drawing.Point(289, 207);
            this.btn_rolldice.Name = "btn_rolldice";
            this.btn_rolldice.Size = new System.Drawing.Size(200, 50);
            this.btn_rolldice.TabIndex = 6;
            this.btn_rolldice.Text = "ROLL DICE";
            this.btn_rolldice.UseVisualStyleBackColor = true;
            this.btn_rolldice.Click += new System.EventHandler(this.btn_rolldice_Click);
            // 
            // dice1box
            // 
            this.dice1box.Location = new System.Drawing.Point(326, 57);
            this.dice1box.Name = "dice1box";
            this.dice1box.Size = new System.Drawing.Size(136, 144);
            this.dice1box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice1box.TabIndex = 8;
            this.dice1box.TabStop = false;
            // 
            // dice2box
            // 
            this.dice2box.Location = new System.Drawing.Point(326, 263);
            this.dice2box.Name = "dice2box";
            this.dice2box.Size = new System.Drawing.Size(136, 144);
            this.dice2box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice2box.TabIndex = 9;
            this.dice2box.TabStop = false;
            // 
            // dice1
            // 
            this.dice1.Image = global::Twenty_One.Properties.Resources.Dice1;
            this.dice1.Location = new System.Drawing.Point(12, 12);
            this.dice1.Name = "dice1";
            this.dice1.Size = new System.Drawing.Size(87, 79);
            this.dice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice1.TabIndex = 10;
            this.dice1.TabStop = false;
            this.dice1.Visible = false;
            // 
            // dice2
            // 
            this.dice2.Image = global::Twenty_One.Properties.Resources.Dice2;
            this.dice2.Location = new System.Drawing.Point(117, 12);
            this.dice2.Name = "dice2";
            this.dice2.Size = new System.Drawing.Size(87, 79);
            this.dice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice2.TabIndex = 11;
            this.dice2.TabStop = false;
            this.dice2.Visible = false;
            // 
            // dice3
            // 
            this.dice3.Image = global::Twenty_One.Properties.Resources.Dice3;
            this.dice3.Location = new System.Drawing.Point(224, 12);
            this.dice3.Name = "dice3";
            this.dice3.Size = new System.Drawing.Size(87, 79);
            this.dice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice3.TabIndex = 12;
            this.dice3.TabStop = false;
            this.dice3.Visible = false;
            // 
            // dice4
            // 
            this.dice4.Image = global::Twenty_One.Properties.Resources.Dice4;
            this.dice4.Location = new System.Drawing.Point(478, 12);
            this.dice4.Name = "dice4";
            this.dice4.Size = new System.Drawing.Size(87, 79);
            this.dice4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice4.TabIndex = 13;
            this.dice4.TabStop = false;
            this.dice4.Visible = false;
            // 
            // dice5
            // 
            this.dice5.Image = global::Twenty_One.Properties.Resources.Dice5;
            this.dice5.Location = new System.Drawing.Point(590, 12);
            this.dice5.Name = "dice5";
            this.dice5.Size = new System.Drawing.Size(87, 79);
            this.dice5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice5.TabIndex = 14;
            this.dice5.TabStop = false;
            this.dice5.Visible = false;
            // 
            // dice6
            // 
            this.dice6.Image = global::Twenty_One.Properties.Resources.Dice6;
            this.dice6.Location = new System.Drawing.Point(701, 12);
            this.dice6.Name = "dice6";
            this.dice6.Size = new System.Drawing.Size(87, 79);
            this.dice6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice6.TabIndex = 15;
            this.dice6.TabStop = false;
            this.dice6.Visible = false;
            // 
            // playbtn
            // 
            this.playbtn.Location = new System.Drawing.Point(340, 207);
            this.playbtn.Name = "playbtn";
            this.playbtn.Size = new System.Drawing.Size(109, 50);
            this.playbtn.TabIndex = 16;
            this.playbtn.Text = "Play Again?";
            this.playbtn.UseVisualStyleBackColor = true;
            this.playbtn.Visible = false;
            this.playbtn.Click += new System.EventHandler(this.playbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playbtn);
            this.Controls.Add(this.dice6);
            this.Controls.Add(this.dice5);
            this.Controls.Add(this.dice4);
            this.Controls.Add(this.dice3);
            this.Controls.Add(this.dice2);
            this.Controls.Add(this.dice1);
            this.Controls.Add(this.dice2box);
            this.Controls.Add(this.dice1box);
            this.Controls.Add(this.btn_rolldice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dice1box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_rolldice;
        private System.Windows.Forms.PictureBox dice1box;
        private System.Windows.Forms.PictureBox dice2box;
        private System.Windows.Forms.PictureBox dice1;
        private System.Windows.Forms.PictureBox dice2;
        private System.Windows.Forms.PictureBox dice3;
        private System.Windows.Forms.PictureBox dice4;
        private System.Windows.Forms.PictureBox dice5;
        private System.Windows.Forms.PictureBox dice6;
        private System.Windows.Forms.Button playbtn;
    }
}

