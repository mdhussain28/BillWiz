namespace BillWiz.UI
{
    partial class itemdelete
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
            button1 = new Button();
            label4 = new Label();
            label1 = new Label();
            items_by_category = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.CornflowerBlue;
            button1.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            button1.FlatAppearance.MouseOverBackColor = Color.LightSkyBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(25, 146);
            button1.Name = "button1";
            button1.Size = new Size(524, 43);
            button1.TabIndex = 46;
            button1.Text = "Delete Item";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(28, 47);
            label4.Name = "label4";
            label4.Size = new Size(121, 22);
            label4.TabIndex = 38;
            label4.Text = "Item Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 6);
            label1.Name = "label1";
            label1.Size = new Size(174, 25);
            label1.TabIndex = 35;
            label1.Text = "Add New Item";
            // 
            // items_by_category
            // 
            items_by_category.Cursor = Cursors.Hand;
            items_by_category.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            items_by_category.FormattingEnabled = true;
            items_by_category.Location = new Point(28, 92);
            items_by_category.Name = "items_by_category";
            items_by_category.Size = new Size(521, 30);
            items_by_category.TabIndex = 47;
            // 
            // itemdelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 231);
            Controls.Add(items_by_category);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "itemdelete";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "itemdelete";
            Load += itemdelete_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label4;
        private Label label1;
        private ComboBox items_by_category;
    }
}