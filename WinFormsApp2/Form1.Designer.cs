namespace WinFormsApp2
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
            button1 = new Button();
            txtcop = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            clear = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(443, 105);
            button1.Name = "button1";
            button1.Size = new Size(116, 27);
            button1.TabIndex = 0;
            button1.Text = "Решаем";
            button1.UseVisualStyleBackColor = true;
            button1.Click += result_click;
            // 
            // txtcop
            // 
            txtcop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtcop.Location = new Point(2, 16);
            txtcop.Name = "txtcop";
            txtcop.Size = new Size(408, 23);
            txtcop.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.Location = new Point(475, 18);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 2;
            label1.Text = "Кол-во копеек";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(clear);
            groupBox1.Controls.Add(txtcop);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(564, 248);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // clear
            // 
            clear.Location = new Point(443, 58);
            clear.Name = "clear";
            clear.Size = new Size(116, 25);
            clear.TabIndex = 3;
            clear.Text = "clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(564, 248);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "№12";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TextBox txtcop;
        private Label label1;
        private GroupBox groupBox1;
        private Button clear;
    }
}