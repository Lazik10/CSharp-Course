namespace WinFormsCarMarketplace
{
    partial class MainForm
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
            this.labelRegistry = new System.Windows.Forms.Label();
            this.labelMoneyInRegistry = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.listBoxCars = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelRegistry
            // 
            this.labelRegistry.AutoSize = true;
            this.labelRegistry.Location = new System.Drawing.Point(16, 356);
            this.labelRegistry.Name = "labelRegistry";
            this.labelRegistry.Size = new System.Drawing.Size(52, 15);
            this.labelRegistry.TabIndex = 1;
            this.labelRegistry.Text = "Registry:";
            // 
            // labelMoneyInRegistry
            // 
            this.labelMoneyInRegistry.AutoSize = true;
            this.labelMoneyInRegistry.Location = new System.Drawing.Point(101, 354);
            this.labelMoneyInRegistry.Name = "labelMoneyInRegistry";
            this.labelMoneyInRegistry.Size = new System.Drawing.Size(0, 15);
            this.labelMoneyInRegistry.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(201, 386);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(365, 386);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 4;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(517, 386);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // listBoxCars
            // 
            this.listBoxCars.FormattingEnabled = true;
            this.listBoxCars.ItemHeight = 15;
            this.listBoxCars.Location = new System.Drawing.Point(12, 12);
            this.listBoxCars.Name = "listBoxCars";
            this.listBoxCars.Size = new System.Drawing.Size(766, 364);
            this.listBoxCars.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 421);
            this.Controls.Add(this.listBoxCars);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelMoneyInRegistry);
            this.Controls.Add(this.labelRegistry);
            this.Name = "MainForm";
            this.Text = "Marketplace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelRegistry;
        private Label labelMoneyInRegistry;
        private Button buttonAdd;
        private Button buttonRemove;
        private Button buttonSave;
        private ListBox listBoxCars;
    }
}