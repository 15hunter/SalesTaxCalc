namespace Smith_SalesTaxCalc_Project
{
    partial class BillyForm
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
            this.BillyText = new System.Windows.Forms.TextBox();
            this.BasePriceText = new System.Windows.Forms.TextBox();
            this.WarrantyText = new System.Windows.Forms.TextBox();
            this.StateText = new System.Windows.Forms.TextBox();
            this.chWarrantyBox = new System.Windows.Forms.ComboBox();
            this.iBasePriceBox = new System.Windows.Forms.TextBox();
            this.chStateBox = new System.Windows.Forms.ComboBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.TotalCostText = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.iTotalCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BillyText
            // 
            this.BillyText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BillyText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillyText.ForeColor = System.Drawing.SystemColors.MenuText;
            this.BillyText.Location = new System.Drawing.Point(37, 26);
            this.BillyText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BillyText.Multiline = true;
            this.BillyText.Name = "BillyText";
            this.BillyText.Size = new System.Drawing.Size(750, 80);
            this.BillyText.TabIndex = 0;
            this.BillyText.Text = "Billy Bob\'s Vehicle Sales Tax Calculator";
            this.BillyText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BillyText.TextChanged += new System.EventHandler(this.BillyText_TextChanged);
            // 
            // BasePriceText
            // 
            this.BasePriceText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BasePriceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BasePriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasePriceText.Location = new System.Drawing.Point(198, 112);
            this.BasePriceText.Multiline = true;
            this.BasePriceText.Name = "BasePriceText";
            this.BasePriceText.Size = new System.Drawing.Size(166, 29);
            this.BasePriceText.TabIndex = 1;
            this.BasePriceText.Text = "Vehicle Base Price:";
            this.BasePriceText.TextChanged += new System.EventHandler(this.BasePriceText_TextChanged);
            // 
            // WarrantyText
            // 
            this.WarrantyText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.WarrantyText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WarrantyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarrantyText.Location = new System.Drawing.Point(198, 182);
            this.WarrantyText.Multiline = true;
            this.WarrantyText.Name = "WarrantyText";
            this.WarrantyText.Size = new System.Drawing.Size(166, 29);
            this.WarrantyText.TabIndex = 2;
            this.WarrantyText.Text = "Extended Warranty:";
            this.WarrantyText.TextChanged += new System.EventHandler(this.WarrantyText_TextChanged);
            // 
            // StateText
            // 
            this.StateText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StateText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateText.Location = new System.Drawing.Point(276, 248);
            this.StateText.Name = "StateText";
            this.StateText.Size = new System.Drawing.Size(88, 22);
            this.StateText.TabIndex = 3;
            this.StateText.Text = "State Sold:";
            this.StateText.TextChanged += new System.EventHandler(this.StateText_TextChanged);
            // 
            // chWarrantyBox
            // 
            this.chWarrantyBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.chWarrantyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chWarrantyBox.FormattingEnabled = true;
            this.chWarrantyBox.Items.AddRange(new object[] {
            "No Warranty",
            "One Year",
            "Two Year",
            "Three Year"});
            this.chWarrantyBox.Location = new System.Drawing.Point(396, 179);
            this.chWarrantyBox.Name = "chWarrantyBox";
            this.chWarrantyBox.Size = new System.Drawing.Size(134, 32);
            this.chWarrantyBox.TabIndex = 4;
            this.chWarrantyBox.SelectedIndexChanged += new System.EventHandler(this.chWarrantyBox_SelectedIndexChanged);
            // 
            // iBasePriceBox
            // 
            this.iBasePriceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iBasePriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBasePriceBox.Location = new System.Drawing.Point(396, 112);
            this.iBasePriceBox.Multiline = true;
            this.iBasePriceBox.Name = "iBasePriceBox";
            this.iBasePriceBox.Size = new System.Drawing.Size(134, 29);
            this.iBasePriceBox.TabIndex = 5;
            this.iBasePriceBox.TextChanged += new System.EventHandler(this.LBasePriceBox_TextChanged);
            // 
            // chStateBox
            // 
            this.chStateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chStateBox.FormattingEnabled = true;
            this.chStateBox.Items.AddRange(new object[] {
            "WA",
            "OR"});
            this.chStateBox.Location = new System.Drawing.Point(396, 245);
            this.chStateBox.Name = "chStateBox";
            this.chStateBox.Size = new System.Drawing.Size(98, 32);
            this.chStateBox.TabIndex = 6;
            this.chStateBox.SelectedIndexChanged += new System.EventHandler(this.chStateBox_SelectedIndexChanged);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(612, 365);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(105, 55);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TotalCostText
            // 
            this.TotalCostText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TotalCostText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalCostText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCostText.Location = new System.Drawing.Point(225, 313);
            this.TotalCostText.Multiline = true;
            this.TotalCostText.Name = "TotalCostText";
            this.TotalCostText.Size = new System.Drawing.Size(216, 25);
            this.TotalCostText.TabIndex = 8;
            this.TotalCostText.TabStop = false;
            this.TotalCostText.Text = "Total Vehicle Cost Is: $";
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(480, 365);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(105, 55);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CalculateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(612, 235);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(105, 55);
            this.CalculateButton.TabIndex = 10;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // iTotalCost
            // 
            this.iTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTotalCost.Location = new System.Drawing.Point(447, 313);
            this.iTotalCost.Multiline = true;
            this.iTotalCost.Name = "iTotalCost";
            this.iTotalCost.Size = new System.Drawing.Size(236, 25);
            this.iTotalCost.TabIndex = 11;
            this.iTotalCost.TextChanged += new System.EventHandler(this.LTotalCost_TextChanged);
            // 
            // BillyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.iTotalCost);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.TotalCostText);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.chStateBox);
            this.Controls.Add(this.iBasePriceBox);
            this.Controls.Add(this.chWarrantyBox);
            this.Controls.Add(this.StateText);
            this.Controls.Add(this.WarrantyText);
            this.Controls.Add(this.BasePriceText);
            this.Controls.Add(this.BillyText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BillyForm";
            this.Text = "Billy Bob\'s Vehicle Sales Tax Calculator";
            this.Load += new System.EventHandler(this.BillyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BillyText;
        private System.Windows.Forms.TextBox BasePriceText;
        private System.Windows.Forms.TextBox WarrantyText;
        private System.Windows.Forms.TextBox StateText;
        private System.Windows.Forms.ComboBox chWarrantyBox;
        private System.Windows.Forms.TextBox iBasePriceBox;
        private System.Windows.Forms.ComboBox chStateBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox TotalCostText;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox iTotalCost;
    }
}

