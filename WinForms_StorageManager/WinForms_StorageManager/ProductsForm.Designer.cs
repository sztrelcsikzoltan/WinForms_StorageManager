
namespace WinForms_StorageManager
{
    partial class ProductsForm
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
            this.label_addPrice = new System.Windows.Forms.Label();
            this.label_addPriceError = new System.Windows.Forms.Label();
            this.textBox_addPrice = new System.Windows.Forms.TextBox();
            this.label_addProductNameError = new System.Windows.Forms.Label();
            this.label_addProductIdError = new System.Windows.Forms.Label();
            this.textBox_addProductName = new System.Windows.Forms.TextBox();
            this.textBox_addProductId = new System.Windows.Forms.TextBox();
            this.Button_add = new System.Windows.Forms.Button();
            this.label_addProductName = new System.Windows.Forms.Label();
            this.label_addProductId = new System.Windows.Forms.Label();
            this.label_addNewProduct = new System.Windows.Forms.Label();
            this.panel_deleteProduct = new System.Windows.Forms.Panel();
            this.label_deleteProductIdError = new System.Windows.Forms.Label();
            this.textBox_deleteProductId = new System.Windows.Forms.TextBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.label_deleteProductId = new System.Windows.Forms.Label();
            this.label_deleteProduct = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_values)).BeginInit();
            this.panel_addProduct.SuspendLayout();
            this.panel_deleteProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_values
            // 
            this.dgv_values.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_values.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_values.Location = new System.Drawing.Point(18, 45);
            this.dgv_values.Name = "dgv_values";
            this.dgv_values.RowHeadersWidth = 51;
            this.dgv_values.Size = new System.Drawing.Size(330, 488);
            this.dgv_values.TabIndex = 11;
            this.dgv_values.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_values_CellClick);
            // 
            // label_message
            // 
            this.label_message.AutoSize = true;
            this.label_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_message.Location = new System.Drawing.Point(17, 546);
            this.label_message.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(65, 17);
            this.label_message.TabIndex = 13;
            this.label_message.Text = "Message";
            // 
            // button_deleteRow
            // 
            this.button_deleteRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_deleteRow.Location = new System.Drawing.Point(181, 7);
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
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Product list";
            // 
            // panel_addProduct
            // 
            this.panel_addProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_addProduct.Controls.Add(this.label_addPrice);
            this.panel_addProduct.Controls.Add(this.label_addPriceError);
            this.panel_addProduct.Controls.Add(this.textBox_addPrice);
            this.panel_addProduct.Controls.Add(this.label_addProductNameError);
            this.panel_addProduct.Controls.Add(this.label_addProductIdError);
            this.panel_addProduct.Controls.Add(this.textBox_addProductName);
            this.panel_addProduct.Controls.Add(this.textBox_addProductId);
            this.panel_addProduct.Controls.Add(this.Button_add);
            this.panel_addProduct.Controls.Add(this.label_addProductName);
            this.panel_addProduct.Controls.Add(this.label_addProductId);
            this.panel_addProduct.Controls.Add(this.label_addNewProduct);
            this.panel_addProduct.Location = new System.Drawing.Point(353, 45);
            this.panel_addProduct.Margin = new System.Windows.Forms.Padding(2);
            this.panel_addProduct.Name = "panel_addProduct";
            this.panel_addProduct.Size = new System.Drawing.Size(314, 294);
            this.panel_addProduct.TabIndex = 20;
            // 
            // label_addPrice
            // 
            this.label_addPrice.AutoSize = true;
            this.label_addPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_addPrice.Location = new System.Drawing.Point(8, 175);
            this.label_addPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_addPrice.Name = "label_addPrice";
            this.label_addPrice.Size = new System.Drawing.Size(42, 18);
            this.label_addPrice.TabIndex = 24;
            this.label_addPrice.Text = "Price";
            // 
            // label_addPriceError
            // 
            this.label_addPriceError.AutoSize = true;
            this.label_addPriceError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_addPriceError.ForeColor = System.Drawing.Color.Red;
            this.label_addPriceError.Location = new System.Drawing.Point(114, 206);
            this.label_addPriceError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_addPriceError.Name = "label_addPriceError";
            this.label_addPriceError.Size = new System.Drawing.Size(117, 15);
            this.label_addPriceError.TabIndex = 23;
            this.label_addPriceError.Text = "label_addPriceError";
            // 
            // textBox_addPrice
            // 
            this.textBox_addPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_addPrice.Location = new System.Drawing.Point(112, 171);
            this.textBox_addPrice.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_addPrice.MaxLength = 9;
            this.textBox_addPrice.Name = "textBox_addPrice";
            this.textBox_addPrice.Size = new System.Drawing.Size(183, 26);
            this.textBox_addPrice.TabIndex = 22;
            // 
            // label_addProductNameError
            // 
            this.label_addProductNameError.AutoSize = true;
            this.label_addProductNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_addProductNameError.ForeColor = System.Drawing.Color.Red;
            this.label_addProductNameError.Location = new System.Drawing.Point(112, 140);
            this.label_addProductNameError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_addProductNameError.Name = "label_addProductNameError";
            this.label_addProductNameError.Size = new System.Drawing.Size(165, 15);
            this.label_addProductNameError.TabIndex = 21;
            this.label_addProductNameError.Text = "label_addProductNameError";
            // 
            // label_addProductIdError
            // 
            this.label_addProductIdError.AutoSize = true;
            this.label_addProductIdError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_addProductIdError.ForeColor = System.Drawing.Color.Red;
            this.label_addProductIdError.Location = new System.Drawing.Point(112, 78);
            this.label_addProductIdError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_addProductIdError.Name = "label_addProductIdError";
            this.label_addProductIdError.Size = new System.Drawing.Size(141, 15);
            this.label_addProductIdError.TabIndex = 20;
            this.label_addProductIdError.Text = "label_addProductIdError";
            // 
            // textBox_addProductName
            // 
            this.textBox_addProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_addProductName.Location = new System.Drawing.Point(112, 109);
            this.textBox_addProductName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_addProductName.MaxLength = 30;
            this.textBox_addProductName.Name = "textBox_addProductName";
            this.textBox_addProductName.Size = new System.Drawing.Size(183, 26);
            this.textBox_addProductName.TabIndex = 19;
            // 
            // textBox_addProductId
            // 
            this.textBox_addProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_addProductId.Location = new System.Drawing.Point(112, 47);
            this.textBox_addProductId.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_addProductId.MaxLength = 9;
            this.textBox_addProductId.Name = "textBox_addProductId";
            this.textBox_addProductId.Size = new System.Drawing.Size(183, 26);
            this.textBox_addProductId.TabIndex = 18;
            // 
            // Button_add
            // 
            this.Button_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_add.BackColor = System.Drawing.Color.Chartreuse;
            this.Button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_add.Location = new System.Drawing.Point(179, 234);
            this.Button_add.Margin = new System.Windows.Forms.Padding(2);
            this.Button_add.Name = "Button_add";
            this.Button_add.Size = new System.Drawing.Size(113, 44);
            this.Button_add.TabIndex = 17;
            this.Button_add.Text = "Add";
            this.Button_add.UseVisualStyleBackColor = false;
            this.Button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // label_addProductName
            // 
            this.label_addProductName.AutoSize = true;
            this.label_addProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_addProductName.Location = new System.Drawing.Point(8, 113);
            this.label_addProductName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_addProductName.Name = "label_addProductName";
            this.label_addProductName.Size = new System.Drawing.Size(101, 18);
            this.label_addProductName.TabIndex = 2;
            this.label_addProductName.Text = "Product name";
            // 
            // label_addProductId
            // 
            this.label_addProductId.AutoSize = true;
            this.label_addProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_addProductId.Location = new System.Drawing.Point(8, 51);
            this.label_addProductId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_addProductId.Name = "label_addProductId";
            this.label_addProductId.Size = new System.Drawing.Size(75, 18);
            this.label_addProductId.TabIndex = 1;
            this.label_addProductId.Text = "Product id";
            // 
            // label_addNewProduct
            // 
            this.label_addNewProduct.AutoSize = true;
            this.label_addNewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_addNewProduct.Location = new System.Drawing.Point(162, 10);
            this.label_addNewProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_addNewProduct.Name = "label_addNewProduct";
            this.label_addNewProduct.Size = new System.Drawing.Size(133, 18);
            this.label_addNewProduct.TabIndex = 0;
            this.label_addNewProduct.Text = "Add new product";
            // 
            // panel_deleteProduct
            // 
            this.panel_deleteProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_deleteProduct.Controls.Add(this.label_deleteProductIdError);
            this.panel_deleteProduct.Controls.Add(this.textBox_deleteProductId);
            this.panel_deleteProduct.Controls.Add(this.button_delete);
            this.panel_deleteProduct.Controls.Add(this.label_deleteProductId);
            this.panel_deleteProduct.Controls.Add(this.label_deleteProduct);
            this.panel_deleteProduct.Location = new System.Drawing.Point(353, 356);
            this.panel_deleteProduct.Margin = new System.Windows.Forms.Padding(2);
            this.panel_deleteProduct.Name = "panel_deleteProduct";
            this.panel_deleteProduct.Size = new System.Drawing.Size(314, 177);
            this.panel_deleteProduct.TabIndex = 21;
            // 
            // label_deleteProductIdError
            // 
            this.label_deleteProductIdError.AutoSize = true;
            this.label_deleteProductIdError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_deleteProductIdError.ForeColor = System.Drawing.Color.Red;
            this.label_deleteProductIdError.Location = new System.Drawing.Point(113, 94);
            this.label_deleteProductIdError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_deleteProductIdError.Name = "label_deleteProductIdError";
            this.label_deleteProductIdError.Size = new System.Drawing.Size(154, 15);
            this.label_deleteProductIdError.TabIndex = 22;
            this.label_deleteProductIdError.Text = "label_deleteProductIdError";
            // 
            // textBox_deleteProductId
            // 
            this.textBox_deleteProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_deleteProductId.Location = new System.Drawing.Point(111, 60);
            this.textBox_deleteProductId.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_deleteProductId.MaxLength = 9;
            this.textBox_deleteProductId.Name = "textBox_deleteProductId";
            this.textBox_deleteProductId.Size = new System.Drawing.Size(183, 26);
            this.textBox_deleteProductId.TabIndex = 18;
            // 
            // button_delete
            // 
            this.button_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_delete.BackColor = System.Drawing.Color.Chartreuse;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_delete.Location = new System.Drawing.Point(178, 119);
            this.button_delete.Margin = new System.Windows.Forms.Padding(2);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(113, 46);
            this.button_delete.TabIndex = 17;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.Button_delete_Click);
            // 
            // label_deleteProductId
            // 
            this.label_deleteProductId.AutoSize = true;
            this.label_deleteProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_deleteProductId.Location = new System.Drawing.Point(8, 64);
            this.label_deleteProductId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_deleteProductId.Name = "label_deleteProductId";
            this.label_deleteProductId.Size = new System.Drawing.Size(75, 18);
            this.label_deleteProductId.TabIndex = 1;
            this.label_deleteProductId.Text = "Product id";
            // 
            // label_deleteProduct
            // 
            this.label_deleteProduct.AutoSize = true;
            this.label_deleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_deleteProduct.Location = new System.Drawing.Point(177, 17);
            this.label_deleteProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_deleteProduct.Name = "label_deleteProduct";
            this.label_deleteProduct.Size = new System.Drawing.Size(118, 18);
            this.label_deleteProduct.TabIndex = 0;
            this.label_deleteProduct.Text = "Delete product";
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 591);
            this.Controls.Add(this.panel_deleteProduct);
            this.Controls.Add(this.panel_addProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_deleteRow);
            this.Controls.Add(this.label_message);
            this.Controls.Add(this.dgv_values);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_values)).EndInit();
            this.panel_addProduct.ResumeLayout(false);
            this.panel_addProduct.PerformLayout();
            this.panel_deleteProduct.ResumeLayout(false);
            this.panel_deleteProduct.PerformLayout();
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
        private System.Windows.Forms.Label label_addProductId;
        private System.Windows.Forms.Label label_addNewProduct;
        private System.Windows.Forms.Button Button_add;
        private System.Windows.Forms.TextBox textBox_addProductName;
        private System.Windows.Forms.TextBox textBox_addProductId;
        private System.Windows.Forms.Panel panel_deleteProduct;
        private System.Windows.Forms.TextBox textBox_deleteProductId;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label_deleteProductId;
        private System.Windows.Forms.Label label_deleteProduct;
        private System.Windows.Forms.Label label_addProductNameError;
        private System.Windows.Forms.Label label_addProductIdError;
        private System.Windows.Forms.Label label_deleteProductIdError;
        private System.Windows.Forms.Label label_addPrice;
        private System.Windows.Forms.Label label_addPriceError;
        private System.Windows.Forms.TextBox textBox_addPrice;
    }
}

