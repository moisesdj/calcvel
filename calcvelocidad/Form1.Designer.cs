namespace calcvelocidad
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.campot = new System.Windows.Forms.TextBox();
            this.campov = new System.Windows.Forms.TextBox();
            this.campop = new System.Windows.Forms.TextBox();
            this.campot2 = new System.Windows.Forms.TextBox();
            this.campov2 = new System.Windows.Forms.TextBox();
            this.campop2 = new System.Windows.Forms.TextBox();
            this.enter = new System.Windows.Forms.Button();
            this.resultadot = new System.Windows.Forms.TextBox();
            this.resultadov = new System.Windows.Forms.TextBox();
            this.resultadop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // campot
            // 
            this.campot.Location = new System.Drawing.Point(-1, 22);
            this.campot.Name = "campot";
            this.campot.Size = new System.Drawing.Size(65, 20);
            this.campot.TabIndex = 0;
            this.campot.TextChanged += new System.EventHandler(this.campot_TextChanged);
            // 
            // campov
            // 
            this.campov.Location = new System.Drawing.Point(102, 22);
            this.campov.Name = "campov";
            this.campov.Size = new System.Drawing.Size(65, 20);
            this.campov.TabIndex = 1;
            // 
            // campop
            // 
            this.campop.Location = new System.Drawing.Point(213, 22);
            this.campop.Name = "campop";
            this.campop.Size = new System.Drawing.Size(59, 20);
            this.campop.TabIndex = 2;
            // 
            // campot2
            // 
            this.campot2.Location = new System.Drawing.Point(-1, 65);
            this.campot2.Name = "campot2";
            this.campot2.Size = new System.Drawing.Size(65, 20);
            this.campot2.TabIndex = 3;
            this.campot2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // campov2
            // 
            this.campov2.Location = new System.Drawing.Point(102, 65);
            this.campov2.Name = "campov2";
            this.campov2.Size = new System.Drawing.Size(65, 20);
            this.campov2.TabIndex = 4;
            // 
            // campop2
            // 
            this.campop2.Location = new System.Drawing.Point(213, 65);
            this.campop2.Name = "campop2";
            this.campop2.Size = new System.Drawing.Size(59, 20);
            this.campop2.TabIndex = 5;
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(92, 95);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(75, 23);
            this.enter.TabIndex = 6;
            this.enter.Text = "ACEPTAR";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // resultadot
            // 
            this.resultadot.Location = new System.Drawing.Point(-1, 157);
            this.resultadot.Name = "resultadot";
            this.resultadot.ReadOnly = true;
            this.resultadot.Size = new System.Drawing.Size(65, 20);
            this.resultadot.TabIndex = 7;
            // 
            // resultadov
            // 
            this.resultadov.Location = new System.Drawing.Point(92, 157);
            this.resultadov.Name = "resultadov";
            this.resultadov.ReadOnly = true;
            this.resultadov.Size = new System.Drawing.Size(65, 20);
            this.resultadov.TabIndex = 8;
            // 
            // resultadop
            // 
            this.resultadop.Location = new System.Drawing.Point(213, 157);
            this.resultadop.Name = "resultadop";
            this.resultadop.ReadOnly = true;
            this.resultadop.Size = new System.Drawing.Size(59, 20);
            this.resultadop.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "RT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "RV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "RP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "t";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "v";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "p";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "t";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(130, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "v";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(240, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "p";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "VER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 550);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultadop);
            this.Controls.Add(this.resultadov);
            this.Controls.Add(this.resultadot);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.campop2);
            this.Controls.Add(this.campov2);
            this.Controls.Add(this.campot2);
            this.Controls.Add(this.campop);
            this.Controls.Add(this.campov);
            this.Controls.Add(this.campot);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox campot;
        private System.Windows.Forms.TextBox campov;
        private System.Windows.Forms.TextBox campop;
        private System.Windows.Forms.TextBox campot2;
        private System.Windows.Forms.TextBox campov2;
        private System.Windows.Forms.TextBox campop2;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.TextBox resultadot;
        private System.Windows.Forms.TextBox resultadov;
        private System.Windows.Forms.TextBox resultadop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}

