
namespace WinForms_StorageManager
{
    partial class DatabaseForm
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
            this.button_products = new System.Windows.Forms.Button();
            this.button_sales = new System.Windows.Forms.Button();
            this.button_users = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_values)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_values
            // 
            this.dgv_values.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_values.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_values.Location = new System.Drawing.Point(28, 111);
            this.dgv_values.Name = "dgv_values";
            this.dgv_values.RowHeadersWidth = 51;
            this.dgv_values.Size = new System.Drawing.Size(624, 410);
            this.dgv_values.TabIndex = 11;
            this.dgv_values.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_values_CellClick);
            // 
            // label_message
            // 
            this.label_message.AutoSize = true;
            this.label_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_message.Location = new System.Drawing.Point(27, 539);
            this.label_message.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(65, 17);
            this.label_message.TabIndex = 13;
            this.label_message.Text = "Message";
            // 
            // button_products
            // 
            this.button_products.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_products.Location = new System.Drawing.Point(28, 56);
            this.button_products.Margin = new System.Windows.Forms.Padding(2);
            this.button_products.Name = "button_products";
            this.button_products.Size = new System.Drawing.Size(145, 31);
            this.button_products.TabIndex = 15;
            this.button_products.Text = "Products";
            this.button_products.UseVisualStyleBackColor = true;
            this.button_products.Click += new System.EventHandler(this.Button_products_Click);
            // 
            // button_sales
            // 
            this.button_sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_sales.Location = new System.Drawing.Point(177, 56);
            this.button_sales.Margin = new System.Windows.Forms.Padding(2);
            this.button_sales.Name = "button_sales";
            this.button_sales.Size = new System.Drawing.Size(148, 31);
            this.button_sales.TabIndex = 16;
            this.button_sales.Text = "Sales";
            this.button_sales.UseVisualStyleBackColor = true;
            this.button_sales.Click += new System.EventHandler(this.Button_sales_Click);
            // 
            // button_users
            // 
            this.button_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_users.Location = new System.Drawing.Point(329, 56);
            this.button_users.Margin = new System.Windows.Forms.Padding(2);
            this.button_users.Name = "button_users";
            this.button_users.Size = new System.Drawing.Size(171, 31);
            this.button_users.TabIndex = 17;
            this.button_users.Text = "Users";
            this.button_users.UseVisualStyleBackColor = true;
            this.button_users.Click += new System.EventHandler(this.Button_users_Click);
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 591);
            this.Controls.Add(this.button_users);
            this.Controls.Add(this.button_sales);
            this.Controls.Add(this.button_products);
            this.Controls.Add(this.label_message);
            this.Controls.Add(this.dgv_values);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_values)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_values;
        private System.Windows.Forms.Label label_message;
        private System.Windows.Forms.Button button_products;
        private System.Windows.Forms.Button button_sales;
        private System.Windows.Forms.Button button_users;
    }
}

