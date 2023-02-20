namespace Proyección_3D
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.TB_Y = new System.Windows.Forms.TrackBar();
            this.TB_X = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TB_SPEED = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_SPEED)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(182, 109);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(858, 448);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(214, 32);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(826, 69);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 10;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(1083, 56);
            this.trackBar2.Maximum = 4;
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(69, 463);
            this.trackBar2.TabIndex = 2;
            this.trackBar2.Value = 4;
            // 
            // TB_Y
            // 
            this.TB_Y.Location = new System.Drawing.Point(70, 109);
            this.TB_Y.Maximum = 50;
            this.TB_Y.Minimum = -50;
            this.TB_Y.Name = "TB_Y";
            this.TB_Y.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TB_Y.Size = new System.Drawing.Size(69, 463);
            this.TB_Y.TabIndex = 3;
            this.TB_Y.Value = 4;
            // 
            // TB_X
            // 
            this.TB_X.Location = new System.Drawing.Point(292, 578);
            this.TB_X.Maximum = 50;
            this.TB_X.Minimum = -50;
            this.TB_X.Name = "TB_X";
            this.TB_X.Size = new System.Drawing.Size(708, 69);
            this.TB_X.TabIndex = 4;
            this.TB_X.Value = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1143, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "ROTATE X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1142, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "ROTATE Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1143, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "ROTATE Z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1143, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "ROTATE XYZ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(591, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "SIZE";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(615, 650);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "X DIRECTION";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Y DIRECTION";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 589);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 58);
            this.button1.TabIndex = 12;
            this.button1.Text = "RESTART IN ORIGIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TB_SPEED
            // 
            this.TB_SPEED.Location = new System.Drawing.Point(1074, 578);
            this.TB_SPEED.Maximum = 8;
            this.TB_SPEED.Name = "TB_SPEED";
            this.TB_SPEED.Size = new System.Drawing.Size(167, 69);
            this.TB_SPEED.TabIndex = 13;
            this.TB_SPEED.Value = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1116, 650);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "SPEED";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 692);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TB_SPEED);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_X);
            this.Controls.Add(this.TB_Y);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_SPEED)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar TB_Y;
        private System.Windows.Forms.TrackBar TB_X;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar TB_SPEED;
        private System.Windows.Forms.Label label8;
    }
}

