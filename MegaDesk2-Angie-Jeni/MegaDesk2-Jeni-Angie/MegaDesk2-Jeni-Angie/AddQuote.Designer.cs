namespace MegaDesk2_Jeni_Angie
{
    partial class AddQuote
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
            this.numUpDownDrawers = new System.Windows.Forms.NumericUpDown();
            this.btnGetQuote = new System.Windows.Forms.Button();
            this.cmbRush = new System.Windows.Forms.ComboBox();
            this.cmbDesktopMaterial = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblError = new System.Windows.Forms.Label();
            this.depthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.widthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lblDepth = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDrawers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // numUpDownDrawers
            // 
            this.numUpDownDrawers.Location = new System.Drawing.Point(247, 138);
            this.numUpDownDrawers.Margin = new System.Windows.Forms.Padding(4);
            this.numUpDownDrawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numUpDownDrawers.Name = "numUpDownDrawers";
            this.numUpDownDrawers.Size = new System.Drawing.Size(52, 22);
            this.numUpDownDrawers.TabIndex = 26;
            // 
            // btnGetQuote
            // 
            this.btnGetQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetQuote.Location = new System.Drawing.Point(190, 367);
            this.btnGetQuote.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetQuote.Name = "btnGetQuote";
            this.btnGetQuote.Size = new System.Drawing.Size(152, 47);
            this.btnGetQuote.TabIndex = 25;
            this.btnGetQuote.Text = "Get Quote";
            this.btnGetQuote.UseVisualStyleBackColor = true;
            this.btnGetQuote.Click += new System.EventHandler(this.btnGetQuote_Click);
            // 
            // cmbRush
            // 
            this.cmbRush.FormattingEnabled = true;
            this.cmbRush.Items.AddRange(new object[] {
            "Regular Delivery(14 Days)",
            "3 Days",
            "5 Days",
            "7 Days"});
            this.cmbRush.Location = new System.Drawing.Point(541, 193);
            this.cmbRush.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRush.Name = "cmbRush";
            this.cmbRush.Size = new System.Drawing.Size(195, 24);
            this.cmbRush.TabIndex = 23;
            // 
            // cmbDesktopMaterial
            // 
            this.cmbDesktopMaterial.FormattingEnabled = true;
            this.cmbDesktopMaterial.Location = new System.Drawing.Point(541, 138);
            this.cmbDesktopMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDesktopMaterial.Name = "cmbDesktopMaterial";
            this.cmbDesktopMaterial.Size = new System.Drawing.Size(195, 24);
            this.cmbDesktopMaterial.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(423, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Rush Order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(385, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Surface Material";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Number of Drawers";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(190, 90);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(263, 22);
            this.txtCustomerName.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Customer Name";
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.Location = new System.Drawing.Point(78, 299);
            this.LblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(0, 17);
            this.LblError.TabIndex = 17;
            // 
            // depthNumericUpDown
            // 
            this.depthNumericUpDown.Location = new System.Drawing.Point(134, 260);
            this.depthNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.depthNumericUpDown.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depthNumericUpDown.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthNumericUpDown.Name = "depthNumericUpDown";
            this.depthNumericUpDown.Size = new System.Drawing.Size(160, 22);
            this.depthNumericUpDown.TabIndex = 16;
            this.depthNumericUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // widthNumericUpDown
            // 
            this.widthNumericUpDown.Location = new System.Drawing.Point(134, 197);
            this.widthNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.widthNumericUpDown.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.widthNumericUpDown.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthNumericUpDown.Name = "widthNumericUpDown";
            this.widthNumericUpDown.Size = new System.Drawing.Size(160, 22);
            this.widthNumericUpDown.TabIndex = 15;
            this.widthNumericUpDown.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // lblDepth
            // 
            this.lblDepth.AutoSize = true;
            this.lblDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepth.Location = new System.Drawing.Point(65, 260);
            this.lblDepth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new System.Drawing.Size(54, 20);
            this.lblDepth.TabIndex = 14;
            this.lblDepth.Text = "Depth";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(65, 197);
            this.lblWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(52, 20);
            this.lblWidth.TabIndex = 13;
            this.lblWidth.Text = "Width";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(427, 367);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(152, 47);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 39);
            this.label5.TabIndex = 27;
            this.label5.Text = "New Quote";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(66, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 18);
            this.label9.TabIndex = 46;
            this.label9.Text = "(min of 12\'\' and max of 48\'\')";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(66, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 18);
            this.label8.TabIndex = 45;
            this.label8.Text = "(min of 24\'\' and max of 96\'\')";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(424, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(276, 18);
            this.label11.TabIndex = 48;
            this.label11.Text = "(given normal production time of 14days)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(66, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 18);
            this.label10.TabIndex = 47;
            this.label10.Text = "(min of 0 and max of 7)";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numUpDownDrawers);
            this.Controls.Add(this.btnGetQuote);
            this.Controls.Add(this.cmbRush);
            this.Controls.Add(this.cmbDesktopMaterial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.depthNumericUpDown);
            this.Controls.Add(this.widthNumericUpDown);
            this.Controls.Add(this.lblDepth);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.btnCancel);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosing);
            this.Load += new System.EventHandler(this.AddQuote_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDrawers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numUpDownDrawers;
        private System.Windows.Forms.Button btnGetQuote;
        private System.Windows.Forms.ComboBox cmbRush;
        private System.Windows.Forms.ComboBox cmbDesktopMaterial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblError;
        private System.Windows.Forms.NumericUpDown depthNumericUpDown;
        private System.Windows.Forms.NumericUpDown widthNumericUpDown;
        private System.Windows.Forms.Label lblDepth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}