namespace BasicCalculator
{
    partial class FrmBasicCalculator
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
            lblTitle = new Label();
            txtFirst = new TextBox();
            cboOperator = new ComboBox();
            txtSecond = new TextBox();
            pnlTotal = new Panel();
            lblTotal = new Label();
            lblTotalCaption = new Label();
            btnCompute = new Button();
            pnlTotal.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(55, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(195, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Basic Calculator";
            // 
            // txtFirst
            // 
            txtFirst.Font = new Font("Segoe UI", 20F);
            txtFirst.Location = new Point(52, 79);
            txtFirst.Multiline = true;
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(255, 49);
            txtFirst.TabIndex = 1;
            // 
            // cboOperator
            // 
            cboOperator.Font = new Font("Segoe UI", 15F);
            cboOperator.FormattingEnabled = true;
            cboOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cboOperator.Location = new Point(126, 147);
            cboOperator.Name = "cboOperator";
            cboOperator.Size = new Size(81, 36);
            cboOperator.TabIndex = 2;
            // 
            // txtSecond
            // 
            txtSecond.Font = new Font("Segoe UI", 20F);
            txtSecond.Location = new Point(55, 200);
            txtSecond.Multiline = true;
            txtSecond.Name = "txtSecond";
            txtSecond.Size = new Size(252, 46);
            txtSecond.TabIndex = 3;
            // 
            // pnlTotal
            // 
            pnlTotal.BackColor = SystemColors.ActiveCaptionText;
            pnlTotal.Controls.Add(lblTotal);
            pnlTotal.Controls.Add(lblTotalCaption);
            pnlTotal.Location = new Point(27, 264);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Size = new Size(312, 113);
            pnlTotal.TabIndex = 4;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Consolas", 20F);
            lblTotal.ForeColor = Color.LimeGreen;
            lblTotal.Location = new Point(16, 56);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(104, 32);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "000000";
            // 
            // lblTotalCaption
            // 
            lblTotalCaption.AutoSize = true;
            lblTotalCaption.Font = new Font("Consolas", 13F);
            lblTotalCaption.ForeColor = Color.Lime;
            lblTotalCaption.Location = new Point(16, 19);
            lblTotalCaption.Name = "lblTotalCaption";
            lblTotalCaption.Size = new Size(70, 22);
            lblTotalCaption.TabIndex = 5;
            lblTotalCaption.Text = "Total:";
            // 
            // btnCompute
            // 
            btnCompute.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompute.Location = new Point(110, 383);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(119, 55);
            btnCompute.TabIndex = 5;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = true;
            btnCompute.Click += btnCompute_Click;
            // 
            // FrmBasicCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(360, 450);
            Controls.Add(btnCompute);
            Controls.Add(pnlTotal);
            Controls.Add(txtSecond);
            Controls.Add(cboOperator);
            Controls.Add(txtFirst);
            Controls.Add(lblTitle);
            Name = "FrmBasicCalculator";
            Text = "FrmBasicCalculator";
            pnlTotal.ResumeLayout(false);
            pnlTotal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtFirst;
        private ComboBox cboOperator;
        private TextBox txtSecond;
        private Panel pnlTotal;
        private Label lblTotalCaption;
        private Label lblTotal;
        private Button btnCompute;
    }
}
