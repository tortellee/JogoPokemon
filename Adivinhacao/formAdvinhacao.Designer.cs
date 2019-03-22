namespace Adivinhacao
{
    partial class formAdvinhacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAdvinhacao));
            this.button1 = new System.Windows.Forms.Button();
            this.Pica = new System.Windows.Forms.PictureBox();
            this.Snorlax = new System.Windows.Forms.PictureBox();
            this.Meow = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Snorlax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meow)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(95, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Meow";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pica
            // 
            this.Pica.Image = global::Adivinhacao.Properties.Resources.Pica;
            this.Pica.Location = new System.Drawing.Point(24, 19);
            this.Pica.Name = "Pica";
            this.Pica.Size = new System.Drawing.Size(72, 74);
            this.Pica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pica.TabIndex = 3;
            this.Pica.TabStop = false;
            this.Pica.Visible = false;
            // 
            // Snorlax
            // 
            this.Snorlax.Image = global::Adivinhacao.Properties.Resources.Snorlax;
            this.Snorlax.Location = new System.Drawing.Point(24, 19);
            this.Snorlax.Name = "Snorlax";
            this.Snorlax.Size = new System.Drawing.Size(72, 74);
            this.Snorlax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Snorlax.TabIndex = 2;
            this.Snorlax.TabStop = false;
            this.Snorlax.Visible = false;
            // 
            // Meow
            // 
            this.Meow.BackColor = System.Drawing.Color.Transparent;
            this.Meow.Image = global::Adivinhacao.Properties.Resources.Meow;
            this.Meow.Location = new System.Drawing.Point(24, 19);
            this.Meow.Name = "Meow";
            this.Meow.Size = new System.Drawing.Size(71, 74);
            this.Meow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Meow.TabIndex = 1;
            this.Meow.TabStop = false;
            this.Meow.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Escolha, qual pokemon irá aparecer ?";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Pikachu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(174, 147);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Snorlax";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.Meow);
            this.groupBox1.Controls.Add(this.Pica);
            this.groupBox1.Controls.Add(this.Snorlax);
            this.groupBox1.Location = new System.Drawing.Point(58, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 102);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "??????";
            // 
            // formAdvinhacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(237, 181);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "formAdvinhacao";
            this.Text = "Escolha o pokemon";
            this.Load += new System.EventHandler(this.formAdvinhacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Snorlax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meow)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Meow;
        private System.Windows.Forms.PictureBox Snorlax;
        private System.Windows.Forms.PictureBox Pica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}