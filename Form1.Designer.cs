namespace TEST
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
            SEED_text = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            MAC_text = new MaskedTextBox();
            Box_out = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 99);
            button1.Name = "button1";
            button1.Size = new Size(384, 67);
            button1.TabIndex = 0;
            button1.Text = "GENERATE!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SEED_text
            // 
            SEED_text.AsciiOnly = true;
            SEED_text.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            SEED_text.Location = new Point(178, 13);
            SEED_text.Mask = "aaaaaaaaaaaa";
            SEED_text.Name = "SEED_text";
            SEED_text.Size = new Size(177, 38);
            SEED_text.TabIndex = 1;
            SEED_text.TextAlign = HorizontalAlignment.Center;
            SEED_text.ValidatingType = typeof(int);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(101, 16);
            label1.Name = "label1";
            label1.Size = new Size(71, 31);
            label1.TabIndex = 2;
            label1.Text = "SEED:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(101, 54);
            label2.Name = "label2";
            label2.Size = new Size(178, 31);
            label2.TabIndex = 3;
            label2.Text = "Last MAC Octet:";
            // 
            // MAC_text
            // 
            MAC_text.AsciiOnly = true;
            MAC_text.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            MAC_text.Location = new Point(285, 51);
            MAC_text.Mask = "aa";
            MAC_text.Name = "MAC_text";
            MAC_text.Size = new Size(57, 38);
            MAC_text.TabIndex = 4;
            MAC_text.TextAlign = HorizontalAlignment.Center;
            // 
            // Box_out
            // 
            Box_out.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Box_out.Location = new Point(81, 210);
            Box_out.Name = "Box_out";
            Box_out.ReadOnly = true;
            Box_out.Size = new Size(261, 38);
            Box_out.TabIndex = 5;
            Box_out.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(178, 176);
            label3.Name = "label3";
            label3.Size = new Size(64, 31);
            label3.TabIndex = 6;
            label3.Text = "PASS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 305);
            Controls.Add(label3);
            Controls.Add(Box_out);
            Controls.Add(MAC_text);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SEED_text);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "ATEN Password unlock";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private MaskedTextBox SEED_text;
        private Label label1;
        private Label label2;
        private MaskedTextBox MAC_text;
        private TextBox Box_out;
        private Label label3;
    }
}