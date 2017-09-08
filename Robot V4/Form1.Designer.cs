namespace Robot_V4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.number1 = new System.Windows.Forms.Label();
            this.number2 = new System.Windows.Forms.Label();
            this.number3 = new System.Windows.Forms.Label();
            this.number4 = new System.Windows.Forms.Label();
            this.number5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_leftdir = new System.Windows.Forms.Button();
            this.btn_rightdir = new System.Windows.Forms.Button();
            this.btn_nodir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.btn_moveOne = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Direction:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quick Jump:";
            // 
            // number1
            // 
            this.number1.AutoSize = true;
            this.number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number1.Location = new System.Drawing.Point(43, 151);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(20, 24);
            this.number1.TabIndex = 2;
            this.number1.Text = "0";
            // 
            // number2
            // 
            this.number2.AutoSize = true;
            this.number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number2.Location = new System.Drawing.Point(134, 169);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(20, 24);
            this.number2.TabIndex = 3;
            this.number2.Text = "0";
            // 
            // number3
            // 
            this.number3.AutoSize = true;
            this.number3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number3.Location = new System.Drawing.Point(230, 183);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(29, 31);
            this.number3.TabIndex = 4;
            this.number3.Text = "0";
            // 
            // number4
            // 
            this.number4.AutoSize = true;
            this.number4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number4.Location = new System.Drawing.Point(326, 169);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(20, 24);
            this.number4.TabIndex = 5;
            this.number4.Text = "0";
            // 
            // number5
            // 
            this.number5.AutoSize = true;
            this.number5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number5.Location = new System.Drawing.Point(420, 151);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(20, 24);
            this.number5.TabIndex = 6;
            this.number5.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(139, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btn_leftdir
            // 
            this.btn_leftdir.Location = new System.Drawing.Point(269, 86);
            this.btn_leftdir.Name = "btn_leftdir";
            this.btn_leftdir.Size = new System.Drawing.Size(40, 40);
            this.btn_leftdir.TabIndex = 8;
            this.btn_leftdir.Text = "Left";
            this.btn_leftdir.UseVisualStyleBackColor = true;
            this.btn_leftdir.Click += new System.EventHandler(this.Btn_leftdir_Click);
            // 
            // btn_rightdir
            // 
            this.btn_rightdir.Location = new System.Drawing.Point(376, 86);
            this.btn_rightdir.Name = "btn_rightdir";
            this.btn_rightdir.Size = new System.Drawing.Size(40, 40);
            this.btn_rightdir.TabIndex = 9;
            this.btn_rightdir.Text = "Right";
            this.btn_rightdir.UseVisualStyleBackColor = true;
            this.btn_rightdir.Click += new System.EventHandler(this.Btn_rightdir_Click);
            // 
            // btn_nodir
            // 
            this.btn_nodir.Location = new System.Drawing.Point(315, 79);
            this.btn_nodir.Name = "btn_nodir";
            this.btn_nodir.Size = new System.Drawing.Size(55, 55);
            this.btn_nodir.TabIndex = 10;
            this.btn_nodir.Text = "No direction";
            this.btn_nodir.UseVisualStyleBackColor = true;
            this.btn_nodir.Click += new System.EventHandler(this.Btn_nodir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(352, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(39, 20);
            this.textBox1.TabIndex = 11;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(397, 12);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 12;
            this.goButton.Text = "Jump!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // btn_moveOne
            // 
            this.btn_moveOne.Location = new System.Drawing.Point(68, 76);
            this.btn_moveOne.Name = "btn_moveOne";
            this.btn_moveOne.Size = new System.Drawing.Size(100, 50);
            this.btn_moveOne.TabIndex = 13;
            this.btn_moveOne.Text = "Move";
            this.btn_moveOne.UseVisualStyleBackColor = true;
            this.btn_moveOne.Click += new System.EventHandler(this.Btn_moveOne_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 415);
            this.Controls.Add(this.btn_moveOne);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_nodir);
            this.Controls.Add(this.btn_rightdir);
            this.Controls.Add(this.btn_leftdir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "7";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label number1;
        private System.Windows.Forms.Label number2;
        private System.Windows.Forms.Label number3;
        private System.Windows.Forms.Label number4;
        private System.Windows.Forms.Label number5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_leftdir;
        private System.Windows.Forms.Button btn_rightdir;
        private System.Windows.Forms.Button btn_nodir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button btn_moveOne;
    }
}

