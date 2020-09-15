namespace BradySalePriceCalculator
{
    partial class salePriceCalculator
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
            this.lblOriginalPricePromptLabel = new System.Windows.Forms.Label();
            this.lblDiscPercentagePrompt = new System.Windows.Forms.Label();
            this.lblOutputDescription = new System.Windows.Forms.Label();
            this.txtOriginalPrice = new System.Windows.Forms.TextBox();
            this.txtDiscountPercentage = new System.Windows.Forms.TextBox();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOriginalPricePromptLabel
            // 
            this.lblOriginalPricePromptLabel.AutoSize = true;
            this.lblOriginalPricePromptLabel.Location = new System.Drawing.Point(39, 27);
            this.lblOriginalPricePromptLabel.Name = "lblOriginalPricePromptLabel";
            this.lblOriginalPricePromptLabel.Size = new System.Drawing.Size(195, 17);
            this.lblOriginalPricePromptLabel.TabIndex = 0;
            this.lblOriginalPricePromptLabel.Text = "Enter the item\'s original price:";
            // 
            // lblDiscPercentagePrompt
            // 
            this.lblDiscPercentagePrompt.AutoSize = true;
            this.lblDiscPercentagePrompt.Location = new System.Drawing.Point(31, 80);
            this.lblDiscPercentagePrompt.Name = "lblDiscPercentagePrompt";
            this.lblDiscPercentagePrompt.Size = new System.Drawing.Size(203, 17);
            this.lblDiscPercentagePrompt.TabIndex = 1;
            this.lblDiscPercentagePrompt.Text = "Enter the discount percentage:";
            // 
            // lblOutputDescription
            // 
            this.lblOutputDescription.AutoSize = true;
            this.lblOutputDescription.Location = new System.Drawing.Point(159, 131);
            this.lblOutputDescription.Name = "lblOutputDescription";
            this.lblOutputDescription.Size = new System.Drawing.Size(75, 17);
            this.lblOutputDescription.TabIndex = 2;
            this.lblOutputDescription.Text = "Sale price:";
            // 
            // txtOriginalPrice
            // 
            this.txtOriginalPrice.Location = new System.Drawing.Point(249, 27);
            this.txtOriginalPrice.Name = "txtOriginalPrice";
            this.txtOriginalPrice.Size = new System.Drawing.Size(100, 22);
            this.txtOriginalPrice.TabIndex = 3;
            // 
            // txtDiscountPercentage
            // 
            this.txtDiscountPercentage.Location = new System.Drawing.Point(249, 80);
            this.txtDiscountPercentage.Name = "txtDiscountPercentage";
            this.txtDiscountPercentage.Size = new System.Drawing.Size(100, 22);
            this.txtDiscountPercentage.TabIndex = 4;
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(249, 129);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(100, 22);
            this.txtSalePrice.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(88, 194);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(97, 70);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "&Calculate Sale Price";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(209, 194);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 70);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // salePriceCalculator
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(423, 297);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtSalePrice);
            this.Controls.Add(this.txtDiscountPercentage);
            this.Controls.Add(this.txtOriginalPrice);
            this.Controls.Add(this.lblOutputDescription);
            this.Controls.Add(this.lblDiscPercentagePrompt);
            this.Controls.Add(this.lblOriginalPricePromptLabel);
            this.Name = "salePriceCalculator";
            this.Text = "salePriceCalculator";
            this.Load += new System.EventHandler(this.SalePriceCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOriginalPricePromptLabel;
        private System.Windows.Forms.Label lblDiscPercentagePrompt;
        private System.Windows.Forms.Label lblOutputDescription;
        private System.Windows.Forms.TextBox txtOriginalPrice;
        private System.Windows.Forms.TextBox txtDiscountPercentage;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

