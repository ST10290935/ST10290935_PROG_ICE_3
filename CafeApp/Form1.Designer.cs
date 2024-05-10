namespace CafeApp
{
    partial class Form1
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
            comboBoxItems = new ComboBox();
            numericUpDownQuantity = new NumericUpDown();
            buttonAdd = new Button();
            buttonShowReceipt = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            SuspendLayout();
            // 
            // comboBoxItems
            // 
            comboBoxItems.FormattingEnabled = true;
            comboBoxItems.Location = new Point(57, 21);
            comboBoxItems.Name = "comboBoxItems";
            comboBoxItems.Size = new Size(182, 33);
            comboBoxItems.TabIndex = 0;
            comboBoxItems.SelectedIndexChanged += comboBoxItems_SelectedIndexChanged;
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(57, 84);
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(180, 31);
            numericUpDownQuantity.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(57, 156);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(112, 34);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonShowReceipt
            // 
            buttonShowReceipt.Location = new Point(57, 234);
            buttonShowReceipt.Name = "buttonShowReceipt";
            buttonShowReceipt.Size = new Size(112, 34);
            buttonShowReceipt.TabIndex = 3;
            buttonShowReceipt.Text = "Show Receipt";
            buttonShowReceipt.UseVisualStyleBackColor = true;
            buttonShowReceipt.Click += buttonShowReceipt_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(214, 234);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(buttonShowReceipt);
            Controls.Add(buttonAdd);
            Controls.Add(numericUpDownQuantity);
            Controls.Add(comboBoxItems);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxItems;
        private NumericUpDown numericUpDownQuantity;
        private Button buttonAdd;
        private Button buttonShowReceipt;
        private Button btnExit;
    }
}
