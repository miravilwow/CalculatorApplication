namespace CalculatorApplication
{
    partial class FrmCalculator
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
            txtInboxInput1 = new TextBox();
            txtInboxInput2 = new TextBox();
            cbOperator = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnEqual = new Button();
            lblDisplayTotal = new Label();
            SuspendLayout();
            // 
            // txtInboxInput1
            // 
            txtInboxInput1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInboxInput1.Location = new Point(229, 48);
            txtInboxInput1.Name = "txtInboxInput1";
            txtInboxInput1.Size = new Size(169, 29);
            txtInboxInput1.TabIndex = 0;
            // 
            // txtInboxInput2
            // 
            txtInboxInput2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInboxInput2.Location = new Point(229, 143);
            txtInboxInput2.Name = "txtInboxInput2";
            txtInboxInput2.Size = new Size(169, 29);
            txtInboxInput2.TabIndex = 1;
            // 
            // cbOperator
            // 
            cbOperator.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbOperator.FormattingEnabled = true;
            cbOperator.Location = new Point(262, 95);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(99, 27);
            cbOperator.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(35, 56);
            label1.Name = "label1";
            label1.Size = new Size(142, 21);
            label1.TabIndex = 3;
            label1.Text = "Enter First Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(35, 146);
            label2.Name = "label2";
            label2.Size = new Size(163, 21);
            label2.TabIndex = 4;
            label2.Text = "Enter Second Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(136, 213);
            label3.Name = "label3";
            label3.Size = new Size(62, 21);
            label3.TabIndex = 5;
            label3.Text = "Answer";
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEqual.Location = new Point(262, 269);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(99, 27);
            btnEqual.TabIndex = 6;
            btnEqual.Text = "button1";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Location = new Point(229, 219);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(92, 15);
            lblDisplayTotal.TabIndex = 7;
            lblDisplayTotal.Text = "_________________";
            // 
            // FrmCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(536, 326);
            Controls.Add(lblDisplayTotal);
            Controls.Add(btnEqual);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbOperator);
            Controls.Add(txtInboxInput2);
            Controls.Add(txtInboxInput1);
            Name = "FrmCalculator";
            Text = "FrmCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInboxInput1;
        private TextBox txtInboxInput2;
        private ComboBox cbOperator;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnEqual;
        private Label lblDisplayTotal;
    }
}