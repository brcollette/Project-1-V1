namespace Project__1_V1
{
    partial class frmWeeklypayroll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWeeklypayroll));
            lblHrsworked = new Label();
            txtHrsworked = new TextBox();
            lblRghours = new Label();
            lblOThrs = new Label();
            lblRgpay = new Label();
            lblOTpay = new Label();
            lblTotalpay = new Label();
            lblTaxwitheld = new Label();
            lblCPP = new Label();
            lblEI = new Label();
            lblNetpay = new Label();
            txtRghours = new TextBox();
            txtOThrs = new TextBox();
            txtRgpay = new TextBox();
            txtOTpay = new TextBox();
            txtTotalpay = new TextBox();
            txtTaxwitheld = new TextBox();
            txtCPP = new TextBox();
            txtEI = new TextBox();
            txtNetpay = new TextBox();
            btnCalculate = new Button();
            btnExit = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lblHrsworked
            // 
            lblHrsworked.AutoSize = true;
            lblHrsworked.BackColor = SystemColors.ActiveCaption;
            lblHrsworked.BorderStyle = BorderStyle.Fixed3D;
            lblHrsworked.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHrsworked.Location = new Point(49, 117);
            lblHrsworked.Name = "lblHrsworked";
            lblHrsworked.Size = new Size(263, 17);
            lblHrsworked.TabIndex = 0;
            lblHrsworked.Text = "Enter hours worked per approved time sheet:";
            // 
            // txtHrsworked
            // 
            txtHrsworked.BackColor = SystemColors.ActiveCaption;
            txtHrsworked.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtHrsworked.ForeColor = SystemColors.ActiveCaptionText;
            txtHrsworked.Location = new Point(318, 117);
            txtHrsworked.Name = "txtHrsworked";
            txtHrsworked.Size = new Size(100, 23);
            txtHrsworked.TabIndex = 1;
            txtHrsworked.TextAlign = HorizontalAlignment.Right;
            // 
            // lblRghours
            // 
            lblRghours.AutoSize = true;
            lblRghours.BackColor = SystemColors.ActiveCaption;
            lblRghours.BorderStyle = BorderStyle.Fixed3D;
            lblRghours.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRghours.Location = new Point(224, 149);
            lblRghours.Name = "lblRghours";
            lblRghours.Size = new Size(91, 17);
            lblRghours.TabIndex = 2;
            lblRghours.Text = "Regular Hours:";
            // 
            // lblOThrs
            // 
            lblOThrs.AutoSize = true;
            lblOThrs.BackColor = SystemColors.ActiveCaption;
            lblOThrs.BorderStyle = BorderStyle.Fixed3D;
            lblOThrs.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOThrs.Location = new Point(213, 177);
            lblOThrs.Name = "lblOThrs";
            lblOThrs.Size = new Size(102, 17);
            lblOThrs.TabIndex = 3;
            lblOThrs.Text = "Overtime Hours:";
            // 
            // lblRgpay
            // 
            lblRgpay.AutoSize = true;
            lblRgpay.BackColor = SystemColors.ActiveCaption;
            lblRgpay.BorderStyle = BorderStyle.Fixed3D;
            lblRgpay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRgpay.Location = new Point(238, 211);
            lblRgpay.Name = "lblRgpay";
            lblRgpay.Size = new Size(77, 17);
            lblRgpay.TabIndex = 4;
            lblRgpay.Text = "Regular pay:";
            // 
            // lblOTpay
            // 
            lblOTpay.AutoSize = true;
            lblOTpay.BackColor = SystemColors.ActiveCaption;
            lblOTpay.BorderStyle = BorderStyle.Fixed3D;
            lblOTpay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOTpay.Location = new Point(227, 240);
            lblOTpay.Name = "lblOTpay";
            lblOTpay.Size = new Size(88, 17);
            lblOTpay.TabIndex = 5;
            lblOTpay.Text = "Overtime pay:";
            // 
            // lblTotalpay
            // 
            lblTotalpay.AutoSize = true;
            lblTotalpay.BackColor = SystemColors.ActiveCaption;
            lblTotalpay.BorderStyle = BorderStyle.Fixed3D;
            lblTotalpay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalpay.Location = new Point(254, 269);
            lblTotalpay.Name = "lblTotalpay";
            lblTotalpay.Size = new Size(61, 17);
            lblTotalpay.TabIndex = 6;
            lblTotalpay.Text = "Total Pay:";
            // 
            // lblTaxwitheld
            // 
            lblTaxwitheld.AutoSize = true;
            lblTaxwitheld.BackColor = SystemColors.ActiveCaption;
            lblTaxwitheld.BorderStyle = BorderStyle.Fixed3D;
            lblTaxwitheld.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTaxwitheld.Location = new Point(191, 298);
            lblTaxwitheld.Name = "lblTaxwitheld";
            lblTaxwitheld.Size = new Size(124, 17);
            lblTaxwitheld.TabIndex = 7;
            lblTaxwitheld.Text = "Less: Tax witholdings";
            // 
            // lblCPP
            // 
            lblCPP.AutoSize = true;
            lblCPP.BackColor = SystemColors.ActiveCaption;
            lblCPP.BorderStyle = BorderStyle.Fixed3D;
            lblCPP.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCPP.Location = new Point(256, 327);
            lblCPP.Name = "lblCPP";
            lblCPP.Size = new Size(59, 17);
            lblCPP.TabIndex = 8;
            lblCPP.Text = "Less: CPP";
            // 
            // lblEI
            // 
            lblEI.AutoSize = true;
            lblEI.BackColor = SystemColors.ActiveCaption;
            lblEI.BorderStyle = BorderStyle.Fixed3D;
            lblEI.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEI.Location = new Point(267, 356);
            lblEI.Name = "lblEI";
            lblEI.Size = new Size(48, 17);
            lblEI.TabIndex = 9;
            lblEI.Text = "Less: EI";
            // 
            // lblNetpay
            // 
            lblNetpay.AutoSize = true;
            lblNetpay.BackColor = SystemColors.ActiveCaption;
            lblNetpay.BorderStyle = BorderStyle.Fixed3D;
            lblNetpay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNetpay.Location = new Point(260, 386);
            lblNetpay.Name = "lblNetpay";
            lblNetpay.Size = new Size(55, 17);
            lblNetpay.TabIndex = 10;
            lblNetpay.Text = "Net Pay:";
            // 
            // txtRghours
            // 
            txtRghours.BackColor = SystemColors.ActiveCaption;
            txtRghours.ForeColor = SystemColors.ActiveCaptionText;
            txtRghours.Location = new Point(318, 146);
            txtRghours.Name = "txtRghours";
            txtRghours.ReadOnly = true;
            txtRghours.Size = new Size(100, 23);
            txtRghours.TabIndex = 11;
            txtRghours.TextAlign = HorizontalAlignment.Right;
            // 
            // txtOThrs
            // 
            txtOThrs.BackColor = SystemColors.ActiveCaption;
            txtOThrs.ForeColor = SystemColors.ActiveCaptionText;
            txtOThrs.Location = new Point(318, 174);
            txtOThrs.Name = "txtOThrs";
            txtOThrs.ReadOnly = true;
            txtOThrs.Size = new Size(100, 23);
            txtOThrs.TabIndex = 12;
            txtOThrs.TextAlign = HorizontalAlignment.Right;
            // 
            // txtRgpay
            // 
            txtRgpay.BackColor = SystemColors.ActiveCaption;
            txtRgpay.ForeColor = SystemColors.ActiveCaptionText;
            txtRgpay.Location = new Point(318, 208);
            txtRgpay.Name = "txtRgpay";
            txtRgpay.ReadOnly = true;
            txtRgpay.Size = new Size(100, 23);
            txtRgpay.TabIndex = 13;
            txtRgpay.TextAlign = HorizontalAlignment.Right;
            // 
            // txtOTpay
            // 
            txtOTpay.BackColor = SystemColors.ActiveCaption;
            txtOTpay.ForeColor = SystemColors.ActiveCaptionText;
            txtOTpay.Location = new Point(318, 237);
            txtOTpay.Name = "txtOTpay";
            txtOTpay.ReadOnly = true;
            txtOTpay.Size = new Size(100, 23);
            txtOTpay.TabIndex = 14;
            txtOTpay.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTotalpay
            // 
            txtTotalpay.BackColor = SystemColors.ActiveCaption;
            txtTotalpay.ForeColor = SystemColors.ActiveCaptionText;
            txtTotalpay.Location = new Point(318, 266);
            txtTotalpay.Name = "txtTotalpay";
            txtTotalpay.ReadOnly = true;
            txtTotalpay.Size = new Size(100, 23);
            txtTotalpay.TabIndex = 15;
            txtTotalpay.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTaxwitheld
            // 
            txtTaxwitheld.BackColor = SystemColors.ActiveCaption;
            txtTaxwitheld.ForeColor = SystemColors.ActiveCaptionText;
            txtTaxwitheld.Location = new Point(318, 295);
            txtTaxwitheld.Name = "txtTaxwitheld";
            txtTaxwitheld.ReadOnly = true;
            txtTaxwitheld.Size = new Size(100, 23);
            txtTaxwitheld.TabIndex = 16;
            txtTaxwitheld.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCPP
            // 
            txtCPP.BackColor = SystemColors.ActiveCaption;
            txtCPP.ForeColor = SystemColors.ActiveCaptionText;
            txtCPP.Location = new Point(318, 324);
            txtCPP.Name = "txtCPP";
            txtCPP.ReadOnly = true;
            txtCPP.Size = new Size(100, 23);
            txtCPP.TabIndex = 17;
            txtCPP.TextAlign = HorizontalAlignment.Right;
            // 
            // txtEI
            // 
            txtEI.BackColor = SystemColors.ActiveCaption;
            txtEI.ForeColor = SystemColors.ActiveCaptionText;
            txtEI.Location = new Point(318, 353);
            txtEI.Name = "txtEI";
            txtEI.ReadOnly = true;
            txtEI.Size = new Size(100, 23);
            txtEI.TabIndex = 18;
            txtEI.TextAlign = HorizontalAlignment.Right;
            // 
            // txtNetpay
            // 
            txtNetpay.BackColor = SystemColors.ActiveCaption;
            txtNetpay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNetpay.ForeColor = SystemColors.ActiveCaptionText;
            txtNetpay.Location = new Point(318, 383);
            txtNetpay.Name = "txtNetpay";
            txtNetpay.ReadOnly = true;
            txtNetpay.Size = new Size(100, 23);
            txtNetpay.TabIndex = 19;
            txtNetpay.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = SystemColors.ActiveCaption;
            btnCalculate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(343, 412);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 1;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ActiveCaption;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(818, 513);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ActiveCaption;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.Location = new Point(302, 491);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(127, 45);
            btnClear.TabIndex = 2;
            btnClear.Text = "&Press to clear and start over";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // frmWeeklypayroll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(953, 548);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtNetpay);
            Controls.Add(txtEI);
            Controls.Add(txtCPP);
            Controls.Add(txtTaxwitheld);
            Controls.Add(txtTotalpay);
            Controls.Add(txtOTpay);
            Controls.Add(txtRgpay);
            Controls.Add(txtOThrs);
            Controls.Add(txtRghours);
            Controls.Add(lblNetpay);
            Controls.Add(lblEI);
            Controls.Add(lblCPP);
            Controls.Add(lblTaxwitheld);
            Controls.Add(lblTotalpay);
            Controls.Add(lblOTpay);
            Controls.Add(lblRgpay);
            Controls.Add(lblOThrs);
            Controls.Add(lblRghours);
            Controls.Add(txtHrsworked);
            Controls.Add(lblHrsworked);
            Name = "frmWeeklypayroll";
            Text = "Weekly Payroll Summary";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHrsworked;
        private TextBox txtHrsworked;
        private Label lblRghours;
        private Label lblOThrs;
        private Label lblRgpay;
        private Label lblOTpay;
        private Label lblTotalpay;
        private Label lblTaxwitheld;
        private Label lblCPP;
        private Label lblEI;
        private Label lblNetpay;
        private TextBox txtRghours;
        private TextBox txtOThrs;
        private TextBox txtRgpay;
        private TextBox txtOTpay;
        private TextBox txtTotalpay;
        private TextBox txtTaxwitheld;
        private TextBox txtCPP;
        private TextBox txtEI;
        private TextBox txtNetpay;
        private Button btnCalculate;
        private Button btnExit;
        private Button btnClear;
    }
}
