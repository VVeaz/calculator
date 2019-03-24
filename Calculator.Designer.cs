namespace Calculator
{
    partial class Calculator
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
            this.number1 = new System.Windows.Forms.RichTextBox();
            this.number2 = new System.Windows.Forms.RichTextBox();
            this.result = new System.Windows.Forms.RichTextBox();
            this.label_num1 = new System.Windows.Forms.Label();
            this.label_num2 = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.adding = new System.Windows.Forms.Button();
            this.subtracting = new System.Windows.Forms.Button();
            this.multiplying = new System.Windows.Forms.Button();
            this.dividing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // number1
            // 
            this.number1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.number1.BackColor = System.Drawing.SystemColors.Control;
            this.number1.Location = new System.Drawing.Point(38, 66);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(316, 316);
            this.number1.TabIndex = 0;
            this.number1.Text = "";
            // 
            // number2
            // 
            this.number2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.number2.BackColor = System.Drawing.SystemColors.Control;
            this.number2.Location = new System.Drawing.Point(403, 66);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(316, 316);
            this.number2.TabIndex = 1;
            this.number2.Text = "";
            // 
            // result
            // 
            this.result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result.BackColor = System.Drawing.SystemColors.Info;
            this.result.Location = new System.Drawing.Point(935, 66);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(316, 316);
            this.result.TabIndex = 2;
            this.result.Text = "";
            // 
            // label_num1
            // 
            this.label_num1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_num1.AutoSize = true;
            this.label_num1.Location = new System.Drawing.Point(34, 43);
            this.label_num1.Name = "label_num1";
            this.label_num1.Size = new System.Drawing.Size(78, 20);
            this.label_num1.TabIndex = 3;
            this.label_num1.Text = "Number 1";
            // 
            // label_num2
            // 
            this.label_num2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_num2.AutoSize = true;
            this.label_num2.Location = new System.Drawing.Point(399, 43);
            this.label_num2.Name = "label_num2";
            this.label_num2.Size = new System.Drawing.Size(78, 20);
            this.label_num2.TabIndex = 4;
            this.label_num2.Text = "Number 2";
            // 
            // label_result
            // 
            this.label_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(931, 43);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(55, 20);
            this.label_result.TabIndex = 5;
            this.label_result.Text = "Result";
            // 
            // adding
            // 
            this.adding.BackColor = System.Drawing.SystemColors.Control;
            this.adding.Location = new System.Drawing.Point(735, 90);
            this.adding.Name = "adding";
            this.adding.Size = new System.Drawing.Size(177, 40);
            this.adding.TabIndex = 6;
            this.adding.Text = "Number1 + Number2";
            this.adding.UseVisualStyleBackColor = false;
            this.adding.Click += new System.EventHandler(this.adding_Click);
            // 
            // subtracting
            // 
            this.subtracting.BackColor = System.Drawing.SystemColors.Control;
            this.subtracting.Location = new System.Drawing.Point(735, 163);
            this.subtracting.Name = "subtracting";
            this.subtracting.Size = new System.Drawing.Size(177, 40);
            this.subtracting.TabIndex = 7;
            this.subtracting.Text = "Number1 - Number2";
            this.subtracting.UseVisualStyleBackColor = false;
            this.subtracting.Click += new System.EventHandler(this.subtracting_Click);
            // 
            // multiplying
            // 
            this.multiplying.BackColor = System.Drawing.SystemColors.Control;
            this.multiplying.Location = new System.Drawing.Point(735, 236);
            this.multiplying.Name = "multiplying";
            this.multiplying.Size = new System.Drawing.Size(177, 40);
            this.multiplying.TabIndex = 8;
            this.multiplying.Text = "Number1 * Number2";
            this.multiplying.UseVisualStyleBackColor = false;
            this.multiplying.Click += new System.EventHandler(this.multiplying_Click);
            // 
            // dividing
            // 
            this.dividing.BackColor = System.Drawing.SystemColors.Control;
            this.dividing.Location = new System.Drawing.Point(735, 308);
            this.dividing.Name = "dividing";
            this.dividing.Size = new System.Drawing.Size(177, 40);
            this.dividing.TabIndex = 9;
            this.dividing.Text = "Number1 / Number2";
            this.dividing.UseVisualStyleBackColor = false;
            this.dividing.Click += new System.EventHandler(this.dividing_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1327, 409);
            this.Controls.Add(this.dividing);
            this.Controls.Add(this.multiplying);
            this.Controls.Add(this.subtracting);
            this.Controls.Add(this.adding);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.label_num2);
            this.Controls.Add(this.label_num1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox number1;
        private System.Windows.Forms.RichTextBox number2;
        private System.Windows.Forms.RichTextBox result;
        private System.Windows.Forms.Label label_num1;
        private System.Windows.Forms.Label label_num2;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Button adding;
        private System.Windows.Forms.Button subtracting;
        private System.Windows.Forms.Button multiplying;
        private System.Windows.Forms.Button dividing;
    }
}

