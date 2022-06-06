
namespace WinForms_StorageManager
{
    partial class MenuForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label_totalProducts = new System.Windows.Forms.Label();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.label_user = new System.Windows.Forms.Label();
            this.label_totalSales = new System.Windows.Forms.Label();
            this.panel_Login = new System.Windows.Forms.Panel();
            this.label_passwordError = new System.Windows.Forms.Label();
            this.label_loginNameError = new System.Windows.Forms.Label();
            this.Button_login = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_loginName = new System.Windows.Forms.TextBox();
            this.label_loginPassword = new System.Windows.Forms.Label();
            this.label_loginName = new System.Windows.Forms.Label();
            this.label_authenticate = new System.Windows.Forms.Label();
            this.label_info = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "Document";
            this.openFileDialog1.Filter = "Text documents (.txt)|*.txt|All files|*.*";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.statisticsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(684, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.AutoSize = false;
            this.loginToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(100, 27);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.LoginToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.AutoSize = false;
            this.productsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(100, 27);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.ProductsToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.AutoSize = false;
            this.salesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(100, 27);
            this.salesToolStripMenuItem.Text = "Sales";
            this.salesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.SalesToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.AutoSize = false;
            this.statisticsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(79, 27);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            this.statisticsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.StatisticsToolStripMenuItem_Click);
            // 
            // label_totalProducts
            // 
            this.label_totalProducts.AutoSize = true;
            this.label_totalProducts.BackColor = System.Drawing.SystemColors.Control;
            this.label_totalProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_totalProducts.ForeColor = System.Drawing.Color.ForestGreen;
            this.label_totalProducts.Location = new System.Drawing.Point(107, 28);
            this.label_totalProducts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_totalProducts.Name = "label_totalProducts";
            this.label_totalProducts.Size = new System.Drawing.Size(129, 17);
            this.label_totalProducts.TabIndex = 4;
            this.label_totalProducts.Text = "label_totalProducts";
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.BackColor = System.Drawing.SystemColors.Control;
            this.label_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_user.ForeColor = System.Drawing.Color.ForestGreen;
            this.label_user.Location = new System.Drawing.Point(7, 28);
            this.label_user.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(74, 17);
            this.label_user.TabIndex = 6;
            this.label_user.Text = "label_user";
            // 
            // label_totalSales
            // 
            this.label_totalSales.AutoSize = true;
            this.label_totalSales.BackColor = System.Drawing.SystemColors.Control;
            this.label_totalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_totalSales.ForeColor = System.Drawing.Color.ForestGreen;
            this.label_totalSales.Location = new System.Drawing.Point(206, 28);
            this.label_totalSales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_totalSales.Name = "label_totalSales";
            this.label_totalSales.Size = new System.Drawing.Size(108, 17);
            this.label_totalSales.TabIndex = 7;
            this.label_totalSales.Text = "label_totalSales";
            // 
            // panel_Login
            // 
            this.panel_Login.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Login.Controls.Add(this.label_passwordError);
            this.panel_Login.Controls.Add(this.label_loginNameError);
            this.panel_Login.Controls.Add(this.Button_login);
            this.panel_Login.Controls.Add(this.textBox_password);
            this.panel_Login.Controls.Add(this.textBox_loginName);
            this.panel_Login.Controls.Add(this.label_loginPassword);
            this.panel_Login.Controls.Add(this.label_loginName);
            this.panel_Login.Controls.Add(this.label_authenticate);
            this.panel_Login.Location = new System.Drawing.Point(109, 69);
            this.panel_Login.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Login.Name = "panel_Login";
            this.panel_Login.Size = new System.Drawing.Size(455, 249);
            this.panel_Login.TabIndex = 9;
            // 
            // label_passwordError
            // 
            this.label_passwordError.AutoSize = true;
            this.label_passwordError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_passwordError.ForeColor = System.Drawing.Color.Red;
            this.label_passwordError.Location = new System.Drawing.Point(128, 154);
            this.label_passwordError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_passwordError.Name = "label_passwordError";
            this.label_passwordError.Size = new System.Drawing.Size(138, 17);
            this.label_passwordError.TabIndex = 18;
            this.label_passwordError.Text = "label_passwordError";
            // 
            // label_loginNameError
            // 
            this.label_loginNameError.AutoSize = true;
            this.label_loginNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_loginNameError.ForeColor = System.Drawing.Color.Red;
            this.label_loginNameError.Location = new System.Drawing.Point(128, 93);
            this.label_loginNameError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_loginNameError.Name = "label_loginNameError";
            this.label_loginNameError.Size = new System.Drawing.Size(145, 17);
            this.label_loginNameError.TabIndex = 17;
            this.label_loginNameError.Text = "label_loginNameError";
            // 
            // Button_login
            // 
            this.Button_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_login.BackColor = System.Drawing.Color.Chartreuse;
            this.Button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_login.Location = new System.Drawing.Point(171, 182);
            this.Button_login.Margin = new System.Windows.Forms.Padding(2);
            this.Button_login.Name = "Button_login";
            this.Button_login.Size = new System.Drawing.Size(105, 53);
            this.Button_login.TabIndex = 16;
            this.Button_login.Text = "Login";
            this.Button_login.UseVisualStyleBackColor = false;
            this.Button_login.Click += new System.EventHandler(this.Button_login_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_password.Location = new System.Drawing.Point(128, 125);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_password.MaxLength = 30;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(183, 26);
            this.textBox_password.TabIndex = 15;
            // 
            // textBox_loginName
            // 
            this.textBox_loginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_loginName.Location = new System.Drawing.Point(128, 63);
            this.textBox_loginName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_loginName.MaxLength = 30;
            this.textBox_loginName.Name = "textBox_loginName";
            this.textBox_loginName.Size = new System.Drawing.Size(183, 26);
            this.textBox_loginName.TabIndex = 14;
            // 
            // label_loginPassword
            // 
            this.label_loginPassword.AutoSize = true;
            this.label_loginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_loginPassword.Location = new System.Drawing.Point(26, 128);
            this.label_loginPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_loginPassword.Name = "label_loginPassword";
            this.label_loginPassword.Size = new System.Drawing.Size(82, 20);
            this.label_loginPassword.TabIndex = 13;
            this.label_loginPassword.Text = "Password:";
            // 
            // label_loginName
            // 
            this.label_loginName.AutoSize = true;
            this.label_loginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_loginName.Location = new System.Drawing.Point(23, 66);
            this.label_loginName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_loginName.Name = "label_loginName";
            this.label_loginName.Size = new System.Drawing.Size(91, 20);
            this.label_loginName.TabIndex = 12;
            this.label_loginName.Text = "User name:";
            // 
            // label_authenticate
            // 
            this.label_authenticate.AutoSize = true;
            this.label_authenticate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_authenticate.Location = new System.Drawing.Point(23, 18);
            this.label_authenticate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_authenticate.Name = "label_authenticate";
            this.label_authenticate.Size = new System.Drawing.Size(213, 20);
            this.label_authenticate.TabIndex = 11;
            this.label_authenticate.Text = "Please authenticate yourself!";
            // 
            // label_info
            // 
            this.label_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_info.ForeColor = System.Drawing.Color.Red;
            this.label_info.Location = new System.Drawing.Point(107, 142);
            this.label_info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(459, 24);
            this.label_info.TabIndex = 10;
            this.label_info.Text = "First select Login then enter username and password.";
            this.label_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::WinForms_StorageManager.Properties.Resources.login_button;
            this.pictureBox1.Location = new System.Drawing.Point(11, 286);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(662, 286);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 591);
            this.Controls.Add(this.panel_Login);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_totalSales);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.label_totalProducts);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label_info);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Storage program";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MenuForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_Login.ResumeLayout(false);
            this.panel_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label_totalProducts;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_totalSales;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.Panel panel_Login;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Label label_authenticate;
        private System.Windows.Forms.Button Button_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_loginName;
        private System.Windows.Forms.Label label_loginPassword;
        private System.Windows.Forms.Label label_loginName;
        private System.Windows.Forms.Label label_passwordError;
        private System.Windows.Forms.Label label_loginNameError;
    }
}

