﻿namespace MegaDesk2_Jeni_Angie
{
    partial class ViewAllQuotes
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
            this.quoteGrid = new System.Windows.Forms.DataGridView();
            this.btnViewQuotes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quoteGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // quoteGrid
            // 
            this.quoteGrid.AllowUserToAddRows = false;
            this.quoteGrid.AllowUserToOrderColumns = true;
            this.quoteGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quoteGrid.Location = new System.Drawing.Point(26, 13);
            this.quoteGrid.Margin = new System.Windows.Forms.Padding(4);
            this.quoteGrid.Name = "quoteGrid";
            this.quoteGrid.Size = new System.Drawing.Size(761, 357);
            this.quoteGrid.TabIndex = 3;
            // 
            // btnViewQuotes
            // 
            this.btnViewQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewQuotes.Location = new System.Drawing.Point(341, 390);
            this.btnViewQuotes.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewQuotes.Name = "btnViewQuotes";
            this.btnViewQuotes.Size = new System.Drawing.Size(152, 47);
            this.btnViewQuotes.TabIndex = 2;
            this.btnViewQuotes.Text = "Close";
            this.btnViewQuotes.UseVisualStyleBackColor = true;
            this.btnViewQuotes.Click += new System.EventHandler(this.btnCloseViewQuotes_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quoteGrid);
            this.Controls.Add(this.btnViewQuotes);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewAllQuotes_FormClosed);
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quoteGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView quoteGrid;
        private System.Windows.Forms.Button btnViewQuotes;
    }
}