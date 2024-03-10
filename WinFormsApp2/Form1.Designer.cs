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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Dock = DockStyle.Bottom;
            button1.Location = new Point(3, 373);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(800, 38);
            button1.TabIndex = 0;
            button1.Text = "Решаем";
            button1.UseVisualStyleBackColor = true;
            button1.Click += result_click;
            // 
            // txtcop
            // 
            txtcop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtcop.Location = new Point(3, 27);
            txtcop.Margin = new Padding(4, 5, 4, 5);
            txtcop.Name = "txtcop";
            txtcop.Size = new Size(581, 31);
            txtcop.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.Location = new Point(671, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 25);
            label1.TabIndex = 2;
            label1.Text = "Кол-во копеек";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtcop);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(806, 414);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(806, 414);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
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
    }
}