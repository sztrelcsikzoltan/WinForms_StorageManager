
namespace WinForms_StorageManager
{
    partial class SalesForm
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
            this.dgv_values = new System.Windows.Forms.DataGridView();
            this.label_message = new System.Windows.Forms.Label();
            this.button_deleteRow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_addProduct = new System.Windows.Forms.Panel();
            this.label_addDateError = new System.Windows.Forms.Label();
            this.numericUpDown_addAmount = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker_addDate = new System.Windows.Forms.DateTimePicker();
            this.comboBox_ProductName = new System.Windows.Forms.ComboBox();
            this.label_addAmountError = new System.Windows.Forms.Label();
            this.label_addDate = new System.Windows.Forms.Label();
            this.label_addAmount = new System.Windows.Forms.Label();
            this.label_addProductNameError = new System.Windows.Forms.Label();
            this.Button_addSale = new System.Windows.Forms.Button();
            this.label_addProductName = new System.Windows.Forms.Label();
            this.label_addNewSale = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_values)).BeginInit();
            this.panel_addProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_addAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_values
            // 
            this.dgv_values.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_values.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_values.Location = new System.Drawing.Point(18, 45);
            this.dgv_values.Name = "dgv_values";
            this.dgv_values.RowHeadersWidth = 51;
            this.dgv_values.Size = new System.Drawing.Size(340, 488);
            this.dgv_values.TabIndex = 11;
            this.dgv_values.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_values_CellClick);
            // 
            // label_message
            // 
            this.label_message.AutoSize = true;
            this.label_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_message.Location = new System.Drawing.Point(17, 541);
            this.label_message.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_message.MaximumSize = new System.Drawing.Size(650, 0);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(65, 17);
            this.label_message.TabIndex = 13;
            this.label_message.Text = "Message";
            // 
            // button_deleteRow
            // 
            this.button_deleteRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_deleteRow.Location = new System.Drawing.Point(202, 7);
            this.button_deleteRow.Margin = new System.Windows.Forms.Padding(2);
            this.button_deleteRow.Name = "button_deleteRow";
            this.button_deleteRow.Size = new System.Drawing.Size(138, 31);
            this.button_deleteRow.TabIndex = 14;
            this.button_deleteRow.Text = "Delete row(s)";
            this.button_deleteRow.UseVisualStyleBackColor = true;
            this.button_deleteRow.Click += new System.EventHandler(this.Button_deleteRow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Sales list";
            // 
            // panel_addProduct
            // 
            this.panel_addProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_addProduct.Controls.Add(this.label_addDateError);
            this.panel_addProduct.Controls.Add(this.numericUpDown_addAmount);
            this.panel_addProduct.Controls.Add(this.dateTimePicker_addDate);
            this.panel_addProduct.Controls.Add(this.comboBox_ProductName);
            this.panel_addProduct.Controls.Add(this.label_addAmountError);
            this.panel_addProduct.Controls.Add(this.label_addDate);
            this.panel_addProduct.Controls.Add(this.label_addAmount);
            this.panel_addProduct.Controls.Add(this.label_addProductNameError);
            this.panel_addProduct.Controls.Add(this.Button_addSale);
            this.panel_addProduct.Controls.Add(this.label_addProductName);
            this.panel_addProduct.Controls.Add(this.label_addNewSale);
            this.panel_addProduct.Location = new System.Drawing.Point(363, 45);
            this.panel_addProduct.Margin = new System.Windows.Forms.Padding(2);
            this.panel_addProduct.Name = "panel_addProduct";
            this.panel_addProduct.Size = new System.Drawing.Size(310, 325);
            this.panel_addProduct.TabIndex = 20;
            // 
            // label_addDateError
            // 
            this.label_addDateError.AutoSize = true;
            this.label_addDateError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_addDateError.ForeColor = System.Drawing.Color.Red;
            this.label_addDateError.Location = new System.Drawing.Point(97, 150);
            this.label_addDateError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_addDateError.Name = "label_addDateError";
            this.label_addDateError.Size = new System.Drawing.Size(115, 15);
            this.label_addDateError.TabIndex = 31;
            this.label_addDateError.Text = "label_addDateError";
            // 
            // numericUpDown_addAmount
            // 
            this.numericUpDown_addAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_addAmount.Location = new System.Drawing.Point(92, 182);
            this.numericUpDown_addAmount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_addAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_addAmount.Name = "numericUpDown_addAmount";
            this.numericUpDown_addAmount.Size = new System.Drawing.Size(113, 24);
            this.numericUpDown_addAmount.TabIndex = 30;
            this.numericUpDown_addAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimePicker_addDate
            // 
            this.dateTimePicker_addDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker_addDate.Location = new System.Drawing.Point(92, 118);
            this.dateTimePicker_addDate.Name = "dateTimePicker_addDate";
            this.dateTimePicker_addDate.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker_addDate.TabIndex = 29;
            // 
            // comboBox_ProductName
            // 
            this.comboBox_ProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_ProductName.FormattingEnabled = true;
            this.comboBox_ProductName.Location = new System.Drawing.Point(92, 53);
            this.comboBox_ProductName.Name = "comboBox_ProductName";
            this.comboBox_ProductName.Size = new System.Drawing.Size(200, 26);
            this.comboBox_ProductName.TabIndex = 28;
            // 
            // label_addAmountError
            // 
            this.label_addAmountError.AutoSize = true;
            this.label_addAmountError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_addAmountError.ForeColor = System.Drawing.Color.Red;
            this.label_addAmountError.Location = new System.Drawing.Point(97, 215);
            this.label_addAmountError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_addAmountError.Name = "label_addAmountError";
            this.label_addAmountError.Size = new System.Drawing.Size(131, 15);
            this.label_addAmountError.TabIndex = 26;
            this.label_addAmountError.Text = "label_addAmountError";
            // 
            // label_addDate
            // 
            this.label_addDate.AutoSize = true;
            this.label_addDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_addDate.Location = new System.Drawing.Point(17, 121);
            this.label_addDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_addDate.Name = "label_addDate";
            this.label_addDate.Size = new System.Drawing.Size(39, 18);
            this.label_addDate.TabIndex = 25;
            this.label_addDate.Text = "Date";
            // 
            // label_addAmount
            // 
            this.label_addAmount.AutoSize = true;
            this.label_addAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_addAmount.Location = new System.Drawing.Point(17, 185);
            this.label_addAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_addAmount.Name = "label_addAmount";
            this.label_addAmount.Size = new System.Drawing.Size(59, 18);
            this.label_addAmount.TabIndex = 24;
            this.label_addAmount.Text = "Amount";
            // 
            // label_addProductNameError
            // 
            this.label_addProductNameError.AutoSize = true;
            this.label_addProductNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_addProductNameError.ForeColor = System.Drawing.Color.Red;
            this.label_addProductNameError.Location = new System.Drawing.Point(95, 84);
            this.label_addProductNameError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_addProductNameError.Name = "label_addProductNameError";
            this.label_addProductNameError.Size = new System.Drawing.Size(165, 15);
            this.label_addProductNameError.TabIndex = 21;
            this.label_addProductNameError.Text = "label_addProductNameError";
            // 
            // Button_addSale
            // 
            this.Button_addSale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_addSale.BackColor = System.Drawing.Color.Chartreuse;
            this.Button_addSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_addSale.Location = new System.Drawing.Point(92, 256);
            this.Button_addSale.Margin = new System.Windows.Forms.Padding(2);
            this.Button_addSale.Name = "Button_addSale";
            this.Button_addSale.Size = new System.Drawing.Size(113, 44);
            this.Button_addSale.TabIndex = 17;
            this.Button_addSale.Text = "Add sale";
            this.Button_addSale.UseVisualStyleBackColor = false;
            this.Button_addSale.Click += new System.EventHandler(this.Button_addSale_Click);
            // 
            // label_addProductName
            // 
            this.label_addProductName.AutoSize = true;
            this.label_addProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_addProductName.Location = new System.Drawing.Point(17, 56);
            this.label_addProductName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_addProductName.Name = "label_addProductName";
            this.label_addProductName.Size = new System.Drawing.Size(60, 18);
            this.label_addProductName.TabIndex = 2;
            this.label_addProductName.Text = "Product";
            // 
            // label_addNewSale
            // 
            this.label_addNewSale.AutoSize = true;
            this.label_addNewSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_addNewSale.Location = new System.Drawing.Point(16, 10);
            this.label_addNewSale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_addNewSale.Name = "label_addNewSale";
            this.label_addNewSale.Size = new System.Drawing.Size(107, 18);
            this.label_addNewSale.TabIndex = 0;
            this.label_addNewSale.Text = "Add new sale";
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 591);
            this.Controls.Add(this.panel_addProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_deleteRow);
            this.Controls.Add(this.label_message);
            this.Controls.Add(this.dgv_values);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_values)).EndInit();
            this.panel_addProduct.ResumeLayout(false);
            this.panel_addProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_addAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_values;
        private System.Windows.Forms.Label label_message;
        private System.Windows.Forms.Button button_deleteRow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_addProduct;
        private System.Windows.Forms.Label label_addProductName;
        private System.Windows.Forms.Label label_addNewSale;
        private System.Windows.Forms.Button Button_addSale;
        private System.Windows.Forms.Label label_addProductNameError;
        private System.Windows.Forms.Label label_addAmount;
        private System.Windows.Forms.Label label_addAmountError;
        private System.Windows.Forms.Label label_addDate;
        private System.Windows.Forms.ComboBox comboBox_ProductName;
        private System.Windows.Forms.NumericUpDown numericUpDown_addAmount;
        private System.Windows.Forms.DateTimePicker dateTimePicker_addDate;
        private System.Windows.Forms.Label label_addDateError;
    }
}

