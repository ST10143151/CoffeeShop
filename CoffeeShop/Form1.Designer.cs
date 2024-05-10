namespace CoffeeShop
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
            btnCalc = new Button();
            txtEdtName = new TextBox();
            txtEdtOrderID = new TextBox();
            txtEdtCntCoffee = new TextBox();
            lblName = new Label();
            lblOrderID = new Label();
            lblCntCoffee = new Label();
            lblCupCake = new Label();
            txtEdtCntCupCake = new TextBox();
            txtEdtTotal = new TextBox();
            label1 = new Label();
            btnClear = new Button();
            btnArray = new Button();
            SuspendLayout();
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(398, 263);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(75, 23);
            btnCalc.TabIndex = 0;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // txtEdtName
            // 
            txtEdtName.Location = new Point(163, 59);
            txtEdtName.Name = "txtEdtName";
            txtEdtName.Size = new Size(100, 23);
            txtEdtName.TabIndex = 1;
            // 
            // txtEdtOrderID
            // 
            txtEdtOrderID.Location = new Point(163, 104);
            txtEdtOrderID.Name = "txtEdtOrderID";
            txtEdtOrderID.Size = new Size(100, 23);
            txtEdtOrderID.TabIndex = 2;
            // 
            // txtEdtCntCoffee
            // 
            txtEdtCntCoffee.Location = new Point(163, 153);
            txtEdtCntCoffee.Name = "txtEdtCntCoffee";
            txtEdtCntCoffee.Size = new Size(100, 23);
            txtEdtCntCoffee.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Nirmala UI", 9F);
            lblName.Location = new Point(49, 62);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 4;
            lblName.Text = "Name";
            // 
            // lblOrderID
            // 
            lblOrderID.AutoSize = true;
            lblOrderID.Font = new Font("Nirmala UI", 9F);
            lblOrderID.Location = new Point(50, 112);
            lblOrderID.Name = "lblOrderID";
            lblOrderID.Size = new Size(48, 15);
            lblOrderID.TabIndex = 5;
            lblOrderID.Text = "OrderID";
            // 
            // lblCntCoffee
            // 
            lblCntCoffee.AutoSize = true;
            lblCntCoffee.Font = new Font("Nirmala UI", 9F);
            lblCntCoffee.Location = new Point(49, 161);
            lblCntCoffee.Name = "lblCntCoffee";
            lblCntCoffee.Size = new Size(103, 15);
            lblCntCoffee.TabIndex = 6;
            lblCntCoffee.Text = "Number of Coffee";
            // 
            // lblCupCake
            // 
            lblCupCake.AutoSize = true;
            lblCupCake.Font = new Font("Nirmala UI", 9F);
            lblCupCake.Location = new Point(36, 210);
            lblCupCake.Name = "lblCupCake";
            lblCupCake.Size = new Size(116, 15);
            lblCupCake.TabIndex = 7;
            lblCupCake.Text = "Number of CupCake";
            // 
            // txtEdtCntCupCake
            // 
            txtEdtCntCupCake.Location = new Point(163, 207);
            txtEdtCntCupCake.Name = "txtEdtCntCupCake";
            txtEdtCntCupCake.Size = new Size(100, 23);
            txtEdtCntCupCake.TabIndex = 8;
            // 
            // txtEdtTotal
            // 
            txtEdtTotal.Location = new Point(163, 252);
            txtEdtTotal.Name = "txtEdtTotal";
            txtEdtTotal.Size = new Size(100, 23);
            txtEdtTotal.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 260);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 10;
            label1.Text = "Total";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(398, 234);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnArray
            // 
            btnArray.Location = new Point(411, 194);
            btnArray.Name = "btnArray";
            btnArray.Size = new Size(75, 23);
            btnArray.TabIndex = 12;
            btnArray.Text = "ArrayDisplay";
            btnArray.UseVisualStyleBackColor = true;
            btnArray.Click += btnArray_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnArray);
            Controls.Add(btnClear);
            Controls.Add(label1);
            Controls.Add(txtEdtTotal);
            Controls.Add(txtEdtCntCupCake);
            Controls.Add(lblCupCake);
            Controls.Add(lblCntCoffee);
            Controls.Add(lblOrderID);
            Controls.Add(lblName);
            Controls.Add(txtEdtCntCoffee);
            Controls.Add(txtEdtOrderID);
            Controls.Add(txtEdtName);
            Controls.Add(btnCalc);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalc;
        private TextBox txtEdtName;
        private TextBox txtEdtOrderID;
        private TextBox txtEdtCntCoffee;
        private Label lblName;
        private Label lblOrderID;
        private Label lblCntCoffee;
        private Label lblCupCake;
        private TextBox txtEdtCntCupCake;
        private TextBox txtEdtTotal;
        private Label label1;
        private Button btnClear;
        private Button btnArray;
    }
}
