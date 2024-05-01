using System.Windows.Forms;

namespace Program8
{
    partial class Input
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
            this.Item_Details = new System.Windows.Forms.GroupBox();
            this.Quantity_textBox = new System.Windows.Forms.TextBox();
            this.Price_textBox = new System.Windows.Forms.TextBox();
            this.Name_textbox = new System.Windows.Forms.TextBox();
            this.ID_textbox = new System.Windows.Forms.TextBox();
            this.Item_ID = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Item_Name = new System.Windows.Forms.Label();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Item_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // Item_Details
            // 
            this.Item_Details.Controls.Add(this.Quantity_textBox);
            this.Item_Details.Controls.Add(this.Price_textBox);
            this.Item_Details.Controls.Add(this.Name_textbox);
            this.Item_Details.Controls.Add(this.ID_textbox);
            this.Item_Details.Controls.Add(this.Item_ID);
            this.Item_Details.Controls.Add(this.Quantity);
            this.Item_Details.Controls.Add(this.Price);
            this.Item_Details.Controls.Add(this.Item_Name);
            this.Item_Details.Location = new System.Drawing.Point(55, 33);
            this.Item_Details.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Item_Details.Name = "Item_Details";
            this.Item_Details.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Item_Details.Size = new System.Drawing.Size(348, 161);
            this.Item_Details.TabIndex = 0;
            this.Item_Details.TabStop = false;
            this.Item_Details.Text = "Item Details";
            // 
            // Quantity_textBox
            // 
            this.Quantity_textBox.Location = new System.Drawing.Point(137, 119);
            this.Quantity_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Quantity_textBox.Name = "Quantity_textBox";
            this.Quantity_textBox.Size = new System.Drawing.Size(125, 22);
            this.Quantity_textBox.TabIndex = 8;
            // 
            // Price_textBox
            // 
            this.Price_textBox.Location = new System.Drawing.Point(137, 87);
            this.Price_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Price_textBox.Name = "Price_textBox";
            this.Price_textBox.Size = new System.Drawing.Size(125, 22);
            this.Price_textBox.TabIndex = 7;
            // 
            // Name_textbox
            // 
            this.Name_textbox.Location = new System.Drawing.Point(137, 57);
            this.Name_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name_textbox.Name = "Name_textbox";
            this.Name_textbox.Size = new System.Drawing.Size(125, 22);
            this.Name_textbox.TabIndex = 6;
            // 
            // ID_textbox
            // 
            this.ID_textbox.Location = new System.Drawing.Point(137, 24);
            this.ID_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ID_textbox.Name = "ID_textbox";
            this.ID_textbox.Size = new System.Drawing.Size(125, 22);
            this.ID_textbox.TabIndex = 5;
            // 
            // Item_ID
            // 
            this.Item_ID.AutoSize = true;
            this.Item_ID.Location = new System.Drawing.Point(20, 30);
            this.Item_ID.Name = "Item_ID";
            this.Item_ID.Size = new System.Drawing.Size(48, 16);
            this.Item_ID.TabIndex = 4;
            this.Item_ID.Text = "Item ID";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(20, 125);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(55, 16);
            this.Quantity.TabIndex = 3;
            this.Quantity.Text = "Quantity";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(20, 90);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(38, 16);
            this.Price.TabIndex = 2;
            this.Price.Text = "Price";
            // 
            // Item_Name
            // 
            this.Item_Name.AutoSize = true;
            this.Item_Name.Location = new System.Drawing.Point(20, 59);
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.Size = new System.Drawing.Size(72, 16);
            this.Item_Name.TabIndex = 1;
            this.Item_Name.Text = "Item Name";
           
            // 
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(128, 198);
            this.OK_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(94, 23);
            this.OK_Button.TabIndex = 1;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(299, 198);
            this.Cancel_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(94, 23);
            this.Cancel_Button.TabIndex = 2;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 265);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.Item_Details);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Input";
            this.Text = "ChildMDI1";
            this.Item_Details.ResumeLayout(false);
            this.Item_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox Item_Details;
        private Label Quantity;
        private Label Price;
        private Label Item_Name;
        private Button OK_Button;
        private Button Cancel_Button;
        private Label Item_ID;
        public TextBox Quantity_textBox;
        public TextBox Price_textBox;
        public TextBox Name_textbox;
        public TextBox ID_textbox;
    }
}