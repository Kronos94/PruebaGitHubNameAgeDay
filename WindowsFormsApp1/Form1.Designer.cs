namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.tBOne = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MonDay = new System.Windows.Forms.RadioButton();
            this.TuDay = new System.Windows.Forms.RadioButton();
            this.WedDay = new System.Windows.Forms.RadioButton();
            this.ThuDay = new System.Windows.Forms.RadioButton();
            this.FriDay = new System.Windows.Forms.RadioButton();
            this.SatDay = new System.Windows.Forms.RadioButton();
            this.SunDay = new System.Windows.Forms.RadioButton();
            this.ageBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(187, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tBOne
            // 
            this.tBOne.Location = new System.Drawing.Point(254, 27);
            this.tBOne.Name = "tBOne";
            this.tBOne.Size = new System.Drawing.Size(579, 20);
            this.tBOne.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "¿Cual es tu nombre?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "¿Que edad tienes?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "¿Que dia es hoy?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // MonDay
            // 
            this.MonDay.AutoSize = true;
            this.MonDay.Checked = true;
            this.MonDay.Location = new System.Drawing.Point(254, 123);
            this.MonDay.Name = "MonDay";
            this.MonDay.Size = new System.Drawing.Size(54, 17);
            this.MonDay.TabIndex = 9;
            this.MonDay.TabStop = true;
            this.MonDay.Text = "Lunes";
            this.MonDay.UseVisualStyleBackColor = true;
            this.MonDay.CheckedChanged += new System.EventHandler(this.Day_CheckedChanged);
            // 
            // TuDay
            // 
            this.TuDay.AutoSize = true;
            this.TuDay.Location = new System.Drawing.Point(369, 123);
            this.TuDay.Name = "TuDay";
            this.TuDay.Size = new System.Drawing.Size(57, 17);
            this.TuDay.TabIndex = 10;
            this.TuDay.TabStop = true;
            this.TuDay.Text = "Martes";
            this.TuDay.UseVisualStyleBackColor = true;
            this.TuDay.CheckedChanged += new System.EventHandler(this.Day_CheckedChanged);
            // 
            // WedDay
            // 
            this.WedDay.AutoSize = true;
            this.WedDay.Location = new System.Drawing.Point(482, 123);
            this.WedDay.Name = "WedDay";
            this.WedDay.Size = new System.Drawing.Size(70, 17);
            this.WedDay.TabIndex = 11;
            this.WedDay.TabStop = true;
            this.WedDay.Text = "Miercoles";
            this.WedDay.UseVisualStyleBackColor = true;
            this.WedDay.CheckedChanged += new System.EventHandler(this.Day_CheckedChanged);
            // 
            // ThuDay
            // 
            this.ThuDay.AutoSize = true;
            this.ThuDay.Location = new System.Drawing.Point(603, 123);
            this.ThuDay.Name = "ThuDay";
            this.ThuDay.Size = new System.Drawing.Size(59, 17);
            this.ThuDay.TabIndex = 12;
            this.ThuDay.TabStop = true;
            this.ThuDay.Text = "Jueves";
            this.ThuDay.UseVisualStyleBackColor = true;
            this.ThuDay.CheckedChanged += new System.EventHandler(this.Day_CheckedChanged);
            // 
            // FriDay
            // 
            this.FriDay.AutoSize = true;
            this.FriDay.Location = new System.Drawing.Point(254, 168);
            this.FriDay.Name = "FriDay";
            this.FriDay.Size = new System.Drawing.Size(60, 17);
            this.FriDay.TabIndex = 13;
            this.FriDay.TabStop = true;
            this.FriDay.Text = "Viernes";
            this.FriDay.UseVisualStyleBackColor = true;
            this.FriDay.CheckedChanged += new System.EventHandler(this.Day_CheckedChanged);
            // 
            // SatDay
            // 
            this.SatDay.AutoSize = true;
            this.SatDay.Location = new System.Drawing.Point(369, 168);
            this.SatDay.Name = "SatDay";
            this.SatDay.Size = new System.Drawing.Size(62, 17);
            this.SatDay.TabIndex = 14;
            this.SatDay.TabStop = true;
            this.SatDay.Text = "Sabado";
            this.SatDay.UseVisualStyleBackColor = true;
            this.SatDay.CheckedChanged += new System.EventHandler(this.Day_CheckedChanged);
            // 
            // SunDay
            // 
            this.SunDay.AutoSize = true;
            this.SunDay.Location = new System.Drawing.Point(482, 168);
            this.SunDay.Name = "SunDay";
            this.SunDay.Size = new System.Drawing.Size(67, 17);
            this.SunDay.TabIndex = 15;
            this.SunDay.TabStop = true;
            this.SunDay.Text = "Domingo";
            this.SunDay.UseVisualStyleBackColor = true;
            this.SunDay.CheckedChanged += new System.EventHandler(this.Day_CheckedChanged);
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(254, 71);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(120, 20);
            this.ageBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 352);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.SunDay);
            this.Controls.Add(this.SatDay);
            this.Controls.Add(this.FriDay);
            this.Controls.Add(this.ThuDay);
            this.Controls.Add(this.WedDay);
            this.Controls.Add(this.TuDay);
            this.Controls.Add(this.MonDay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBOne);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tBOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton MonDay;
        private System.Windows.Forms.RadioButton TuDay;
        private System.Windows.Forms.RadioButton WedDay;
        private System.Windows.Forms.RadioButton ThuDay;
        private System.Windows.Forms.RadioButton FriDay;
        private System.Windows.Forms.RadioButton SatDay;
        private System.Windows.Forms.RadioButton SunDay;
        private System.Windows.Forms.NumericUpDown ageBox;
    }
}

