namespace WinFormsMenu
{
    partial class AddMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.listBoxProduct = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(84, 39);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(233, 27);
            this.textBoxName.TabIndex = 1;
            // 
            // listBoxProduct
            // 
            this.listBoxProduct.FormattingEnabled = true;
            this.listBoxProduct.ItemHeight = 20;
            this.listBoxProduct.Location = new System.Drawing.Point(12, 205);
            this.listBoxProduct.Name = "listBoxProduct";
            this.listBoxProduct.Size = new System.Drawing.Size(305, 144);
            this.listBoxProduct.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(166, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Catégorie du produit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Récap. menu";
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.ItemHeight = 20;
            this.listBoxMenu.Location = new System.Drawing.Point(484, 74);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.Size = new System.Drawing.Size(288, 284);
            this.listBoxMenu.TabIndex = 6;
            // 
            // AddMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBoxProduct);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Name = "AddMenu";
            this.Text = "AddMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxName;
        private ListBox listBoxProduct;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private ListBox listBoxMenu;
    }
}