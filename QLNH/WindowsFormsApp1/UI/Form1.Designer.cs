namespace WindowsFormsApp1
{
    partial class RestaurantTB
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
            this.textName = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.Savebt = new System.Windows.Forms.Button();
            this.Deletebt = new System.Windows.Forms.Button();
            this.Updatebt = new System.Windows.Forms.Button();
            this.UpdateAllbt = new System.Windows.Forms.Button();
            this.CallSPbt = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Catelogy = new System.Windows.Forms.Label();
            this.CateSelectbt = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextDes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(91, 13);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(407, 26);
            this.textName.TabIndex = 0;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(91, 55);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(407, 26);
            this.textAddress.TabIndex = 2;
            // 
            // Savebt
            // 
            this.Savebt.Location = new System.Drawing.Point(90, 176);
            this.Savebt.Name = "Savebt";
            this.Savebt.Size = new System.Drawing.Size(111, 45);
            this.Savebt.TabIndex = 3;
            this.Savebt.Text = "Save";
            this.Savebt.UseVisualStyleBackColor = true;
            this.Savebt.Click += new System.EventHandler(this.Savebt_Click);
            // 
            // Deletebt
            // 
            this.Deletebt.Location = new System.Drawing.Point(279, 176);
            this.Deletebt.Name = "Deletebt";
            this.Deletebt.Size = new System.Drawing.Size(111, 45);
            this.Deletebt.TabIndex = 4;
            this.Deletebt.Text = "Delete";
            this.Deletebt.UseVisualStyleBackColor = true;
            this.Deletebt.Click += new System.EventHandler(this.Deletebt_Click);
            // 
            // Updatebt
            // 
            this.Updatebt.Location = new System.Drawing.Point(462, 176);
            this.Updatebt.Name = "Updatebt";
            this.Updatebt.Size = new System.Drawing.Size(111, 45);
            this.Updatebt.TabIndex = 5;
            this.Updatebt.Text = "Update";
            this.Updatebt.UseVisualStyleBackColor = true;
            this.Updatebt.Click += new System.EventHandler(this.Updatebt_Click);
            // 
            // UpdateAllbt
            // 
            this.UpdateAllbt.Location = new System.Drawing.Point(368, 236);
            this.UpdateAllbt.Name = "UpdateAllbt";
            this.UpdateAllbt.Size = new System.Drawing.Size(205, 45);
            this.UpdateAllbt.TabIndex = 6;
            this.UpdateAllbt.Text = "Update all rows";
            this.UpdateAllbt.UseVisualStyleBackColor = true;
            // 
            // CallSPbt
            // 
            this.CallSPbt.Location = new System.Drawing.Point(90, 236);
            this.CallSPbt.Name = "CallSPbt";
            this.CallSPbt.Size = new System.Drawing.Size(202, 45);
            this.CallSPbt.TabIndex = 7;
            this.CallSPbt.Text = "Call store product";
            this.CallSPbt.UseVisualStyleBackColor = true;
            this.CallSPbt.Click += new System.EventHandler(this.CallSPbt_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(19, 299);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 28;
            this.dataGrid.Size = new System.Drawing.Size(646, 141);
            this.dataGrid.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Address";
            // 
            // Catelogy
            // 
            this.Catelogy.AutoSize = true;
            this.Catelogy.Location = new System.Drawing.Point(9, 100);
            this.Catelogy.Name = "Catelogy";
            this.Catelogy.Size = new System.Drawing.Size(71, 20);
            this.Catelogy.TabIndex = 11;
            this.Catelogy.Text = "Catelogy";
            // 
            // CateSelectbt
            // 
            this.CateSelectbt.FormattingEnabled = true;
            this.CateSelectbt.Location = new System.Drawing.Point(91, 98);
            this.CateSelectbt.Name = "CateSelectbt";
            this.CateSelectbt.Size = new System.Drawing.Size(406, 28);
            this.CateSelectbt.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Describe";
            // 
            // TextDes
            // 
            this.TextDes.Location = new System.Drawing.Point(90, 139);
            this.TextDes.Name = "TextDes";
            this.TextDes.Size = new System.Drawing.Size(407, 26);
            this.TextDes.TabIndex = 14;
            // 
            // RestaurantTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 452);
            this.Controls.Add(this.TextDes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CateSelectbt);
            this.Controls.Add(this.Catelogy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.CallSPbt);
            this.Controls.Add(this.UpdateAllbt);
            this.Controls.Add(this.Updatebt);
            this.Controls.Add(this.Deletebt);
            this.Controls.Add(this.Savebt);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textName);
            this.Name = "RestaurantTB";
            this.Text = "RestaurantManager";
            this.Load += new System.EventHandler(this.RestaurantTB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Button Savebt;
        private System.Windows.Forms.Button Deletebt;
        private System.Windows.Forms.Button Updatebt;
        private System.Windows.Forms.Button UpdateAllbt;
        private System.Windows.Forms.Button CallSPbt;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Catelogy;
        private System.Windows.Forms.ComboBox CateSelectbt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextDes;
    }
}

