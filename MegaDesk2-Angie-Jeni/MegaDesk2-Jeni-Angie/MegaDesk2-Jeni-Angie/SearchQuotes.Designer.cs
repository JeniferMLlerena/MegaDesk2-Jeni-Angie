namespace MegaDesk2_Jeni_Angie
{
    partial class SearchQuotes
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
            this.gridSearchQuotes = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbSearchQuoteSurfaceMaterial = new System.Windows.Forms.ComboBox();
            this.lblSurfaceMaterial = new System.Windows.Forms.Label();
            this.btnCloseQuote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSearchQuotes
            // 
            this.gridSearchQuotes.AllowUserToAddRows = false;
            this.gridSearchQuotes.AllowUserToOrderColumns = true;
            this.gridSearchQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSearchQuotes.Location = new System.Drawing.Point(47, 50);
            this.gridSearchQuotes.Margin = new System.Windows.Forms.Padding(4);
            this.gridSearchQuotes.Name = "gridSearchQuotes";
            this.gridSearchQuotes.Size = new System.Drawing.Size(740, 400);
            this.gridSearchQuotes.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(533, 6);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 32);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbSearchQuoteSurfaceMaterial
            // 
            this.cmbSearchQuoteSurfaceMaterial.FormattingEnabled = true;
            this.cmbSearchQuoteSurfaceMaterial.Location = new System.Drawing.Point(242, 9);
            this.cmbSearchQuoteSurfaceMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSearchQuoteSurfaceMaterial.Name = "cmbSearchQuoteSurfaceMaterial";
            this.cmbSearchQuoteSurfaceMaterial.Size = new System.Drawing.Size(225, 24);
            this.cmbSearchQuoteSurfaceMaterial.TabIndex = 7;
            // 
            // lblSurfaceMaterial
            // 
            this.lblSurfaceMaterial.AutoSize = true;
            this.lblSurfaceMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurfaceMaterial.Location = new System.Drawing.Point(42, 9);
            this.lblSurfaceMaterial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurfaceMaterial.Name = "lblSurfaceMaterial";
            this.lblSurfaceMaterial.Size = new System.Drawing.Size(187, 29);
            this.lblSurfaceMaterial.TabIndex = 6;
            this.lblSurfaceMaterial.Text = "Surface Material";
            // 
            // btnCloseQuote
            // 
            this.btnCloseQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseQuote.Location = new System.Drawing.Point(337, 458);
            this.btnCloseQuote.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseQuote.Name = "btnCloseQuote";
            this.btnCloseQuote.Size = new System.Drawing.Size(152, 47);
            this.btnCloseQuote.TabIndex = 5;
            this.btnCloseQuote.Text = "Close";
            this.btnCloseQuote.UseVisualStyleBackColor = true;
            this.btnCloseQuote.Click += new System.EventHandler(this.BtnCloseQuote_Click_1);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.gridSearchQuotes);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbSearchQuoteSurfaceMaterial);
            this.Controls.Add(this.lblSurfaceMaterial);
            this.Controls.Add(this.btnCloseQuote);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchQuotes_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchQuotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridSearchQuotes;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbSearchQuoteSurfaceMaterial;
        private System.Windows.Forms.Label lblSurfaceMaterial;
        private System.Windows.Forms.Button btnCloseQuote;
    }
}