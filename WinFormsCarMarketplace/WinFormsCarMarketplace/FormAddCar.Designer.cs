namespace WinFormsCarMarketplace
{
    partial class FormAddCar
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelMainHeader = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelManufactureYear = new System.Windows.Forms.Label();
            this.labelSPZ = new System.Windows.Forms.Label();
            this.labelValue = new System.Windows.Forms.Label();
            this.labelCurrency = new System.Windows.Forms.Label();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.textBoxSPZ = new System.Windows.Forms.TextBox();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(104, 210);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelMainHeader
            // 
            this.labelMainHeader.AutoSize = true;
            this.labelMainHeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMainHeader.Location = new System.Drawing.Point(46, 9);
            this.labelMainHeader.Name = "labelMainHeader";
            this.labelMainHeader.Size = new System.Drawing.Size(177, 25);
            this.labelMainHeader.TabIndex = 1;
            this.labelMainHeader.Text = "Fill Car Parameters";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(12, 56);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(38, 15);
            this.labelBrand.TabIndex = 2;
            this.labelBrand.Text = "Brand";
            // 
            // labelManufactureYear
            // 
            this.labelManufactureYear.AutoSize = true;
            this.labelManufactureYear.Location = new System.Drawing.Point(12, 94);
            this.labelManufactureYear.Name = "labelManufactureYear";
            this.labelManufactureYear.Size = new System.Drawing.Size(100, 15);
            this.labelManufactureYear.TabIndex = 3;
            this.labelManufactureYear.Text = "Manufacture Year";
            // 
            // labelSPZ
            // 
            this.labelSPZ.AutoSize = true;
            this.labelSPZ.Location = new System.Drawing.Point(12, 134);
            this.labelSPZ.Name = "labelSPZ";
            this.labelSPZ.Size = new System.Drawing.Size(27, 15);
            this.labelSPZ.TabIndex = 4;
            this.labelSPZ.Text = "SPZ";
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(12, 170);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(35, 15);
            this.labelValue.TabIndex = 5;
            this.labelValue.Text = "Value";
            // 
            // labelCurrency
            // 
            this.labelCurrency.AutoSize = true;
            this.labelCurrency.Location = new System.Drawing.Point(229, 176);
            this.labelCurrency.Name = "labelCurrency";
            this.labelCurrency.Size = new System.Drawing.Size(31, 15);
            this.labelCurrency.TabIndex = 6;
            this.labelCurrency.Text = "Euro";
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(88, 53);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(135, 23);
            this.textBoxBrand.TabIndex = 7;
            // 
            // textBoxSPZ
            // 
            this.textBoxSPZ.Location = new System.Drawing.Point(88, 131);
            this.textBoxSPZ.Name = "textBoxSPZ";
            this.textBoxSPZ.Size = new System.Drawing.Size(135, 23);
            this.textBoxSPZ.TabIndex = 8;
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Location = new System.Drawing.Point(123, 92);
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(100, 23);
            this.numericUpDownYear.TabIndex = 9;
            // 
            // numericUpDownValue
            // 
            this.numericUpDownValue.Location = new System.Drawing.Point(88, 168);
            this.numericUpDownValue.Name = "numericUpDownValue";
            this.numericUpDownValue.Size = new System.Drawing.Size(135, 23);
            this.numericUpDownValue.TabIndex = 10;
            // 
            // FormAddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 245);
            this.Controls.Add(this.numericUpDownValue);
            this.Controls.Add(this.numericUpDownYear);
            this.Controls.Add(this.textBoxSPZ);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.labelCurrency);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.labelSPZ);
            this.Controls.Add(this.labelManufactureYear);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.labelMainHeader);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormAddCar";
            this.Text = "FormAddCar";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAdd;
        private Label labelMainHeader;
        private Label labelBrand;
        private Label labelManufactureYear;
        private Label labelSPZ;
        private Label labelValue;
        private Label labelCurrency;
        private TextBox textBoxBrand;
        private TextBox textBoxSPZ;
        private NumericUpDown numericUpDownYear;
        private NumericUpDown numericUpDownValue;
    }
}