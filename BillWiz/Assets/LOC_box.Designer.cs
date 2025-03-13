namespace BillWiz.UI
{
    partial class LOC_box
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOC_box));
            no_btn = new Button();
            yes_btn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // no_btn
            // 
            no_btn.Location = new Point(202, 72);
            no_btn.Margin = new Padding(4, 3, 4, 3);
            no_btn.Name = "no_btn";
            no_btn.Size = new Size(129, 32);
            no_btn.TabIndex = 5;
            no_btn.Text = "No";
            no_btn.UseVisualStyleBackColor = true;
            no_btn.Click += no_btn_Click;
            // 
            // yes_btn
            // 
            yes_btn.Location = new Point(24, 72);
            yes_btn.Margin = new Padding(4, 3, 4, 3);
            yes_btn.Name = "yes_btn";
            yes_btn.Size = new Size(129, 32);
            yes_btn.TabIndex = 4;
            yes_btn.Text = "Yes";
            yes_btn.UseVisualStyleBackColor = true;
            yes_btn.Click += yes_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(207, 22);
            label1.TabIndex = 3;
            label1.Text = "Are you Sure To Quit?";
            // 
            // LOC_box
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 130);
            Controls.Add(no_btn);
            Controls.Add(yes_btn);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LOC_box";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOC_box";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button no_btn;
        private Button yes_btn;
        private Label label1;
    }
}