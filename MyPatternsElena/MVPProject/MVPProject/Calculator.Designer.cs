namespace MVPProject
{
    partial class Calculator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtDivis = new System.Windows.Forms.RadioButton();
            this.rbtMult = new System.Windows.Forms.RadioButton();
            this.rbtDiv = new System.Windows.Forms.RadioButton();
            this.rbtAdd = new System.Windows.Forms.RadioButton();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tnEnter = new System.Windows.Forms.Button();
            this.txtRezult = new System.Windows.Forms.TextBox();
            this.Rezult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtDivis);
            this.groupBox1.Controls.Add(this.rbtMult);
            this.groupBox1.Controls.Add(this.rbtDiv);
            this.groupBox1.Controls.Add(this.rbtAdd);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a mathematical operation";
            // 
            // rbtDivis
            // 
            this.rbtDivis.AutoSize = true;
            this.rbtDivis.Location = new System.Drawing.Point(149, 43);
            this.rbtDivis.Name = "rbtDivis";
            this.rbtDivis.Size = new System.Drawing.Size(74, 17);
            this.rbtDivis.TabIndex = 3;
            this.rbtDivis.TabStop = true;
            this.rbtDivis.Text = "(/) division";
            this.rbtDivis.UseVisualStyleBackColor = true;
            // 
            // rbtMult
            // 
            this.rbtMult.AutoSize = true;
            this.rbtMult.Location = new System.Drawing.Point(149, 19);
            this.rbtMult.Name = "rbtMult";
            this.rbtMult.Size = new System.Drawing.Size(98, 17);
            this.rbtMult.TabIndex = 2;
            this.rbtMult.TabStop = true;
            this.rbtMult.Text = "(*) multiplication";
            this.rbtMult.UseVisualStyleBackColor = true;
            // 
            // rbtDiv
            // 
            this.rbtDiv.AutoSize = true;
            this.rbtDiv.Location = new System.Drawing.Point(7, 44);
            this.rbtDiv.Name = "rbtDiv";
            this.rbtDiv.Size = new System.Drawing.Size(89, 17);
            this.rbtDiv.TabIndex = 1;
            this.rbtDiv.TabStop = true;
            this.rbtDiv.Text = "(-) subtraction";
            this.rbtDiv.UseVisualStyleBackColor = true;
            // 
            // rbtAdd
            // 
            this.rbtAdd.AutoSize = true;
            this.rbtAdd.Location = new System.Drawing.Point(7, 20);
            this.rbtAdd.Name = "rbtAdd";
            this.rbtAdd.Size = new System.Drawing.Size(77, 17);
            this.rbtAdd.TabIndex = 0;
            this.rbtAdd.TabStop = true;
            this.rbtAdd.Text = "(+) addition";
            this.rbtAdd.UseVisualStyleBackColor = true;
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(13, 98);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(100, 20);
            this.txtNumber1.TabIndex = 1;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(162, 98);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(100, 20);
            this.txtNumber2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number 2";
            // 
            // tnEnter
            // 
            this.tnEnter.Location = new System.Drawing.Point(101, 162);
            this.tnEnter.Name = "tnEnter";
            this.tnEnter.Size = new System.Drawing.Size(75, 23);
            this.tnEnter.TabIndex = 6;
            this.tnEnter.Text = "Enter";
            this.tnEnter.UseVisualStyleBackColor = true;
            this.tnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtRezult
            // 
            this.txtRezult.Location = new System.Drawing.Point(87, 136);
            this.txtRezult.Name = "txtRezult";
            this.txtRezult.Size = new System.Drawing.Size(100, 20);
            this.txtRezult.TabIndex = 7;
            // 
            // Rezult
            // 
            this.Rezult.AutoSize = true;
            this.Rezult.Location = new System.Drawing.Point(84, 121);
            this.Rezult.Name = "Rezult";
            this.Rezult.Size = new System.Drawing.Size(37, 13);
            this.Rezult.TabIndex = 8;
            this.Rezult.Text = "Rezult";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 189);
            this.Controls.Add(this.Rezult);
            this.Controls.Add(this.txtRezult);
            this.Controls.Add(this.tnEnter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtDivis;
        private System.Windows.Forms.RadioButton rbtMult;
        private System.Windows.Forms.RadioButton rbtDiv;
        private System.Windows.Forms.RadioButton rbtAdd;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tnEnter;
        private System.Windows.Forms.TextBox txtRezult;
        private System.Windows.Forms.Label Rezult;
    }
}

