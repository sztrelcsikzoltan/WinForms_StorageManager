
namespace WinForms_StorageManager
{
    partial class StartForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.label_title = new System.Windows.Forms.Label();
            this.button_menu = new System.Windows.Forms.Button();
            this.button_database = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label_status0 = new System.Windows.Forms.Label();
            this.progressTimer = new System.Windows.Forms.Timer(this.components);
            this.label_status1 = new System.Windows.Forms.Label();
            this.button_errorMessageDetails = new System.Windows.Forms.Button();
            this.button_connectToDatabase = new System.Windows.Forms.Button();
            this.label_noConnection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_title.Location = new System.Drawing.Point(207, 12);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(279, 37);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Storage Manager";
            this.label_title.Visible = false;
            // 
            // button_menu
            // 
            this.button_menu.Enabled = false;
            this.button_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_menu.Location = new System.Drawing.Point(251, 291);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(184, 59);
            this.button_menu.TabIndex = 3;
            this.button_menu.Text = "Menu";
            this.button_menu.UseVisualStyleBackColor = true;
            this.button_menu.Click += new System.EventHandler(this.MenuForm_Click);
            // 
            // button_database
            // 
            this.button_database.Enabled = false;
            this.button_database.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_database.Location = new System.Drawing.Point(251, 444);
            this.button_database.Name = "button_database";
            this.button_database.Size = new System.Drawing.Size(184, 59);
            this.button_database.TabIndex = 4;
            this.button_database.Text = "Database";
            this.button_database.UseVisualStyleBackColor = true;
            this.button_database.Click += new System.EventHandler(this.DatabaseForm_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.progressBar1.Location = new System.Drawing.Point(251, 92);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(184, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // label_status0
            // 
            this.label_status0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_status0.Location = new System.Drawing.Point(252, 65);
            this.label_status0.Name = "label_status0";
            this.label_status0.Size = new System.Drawing.Size(182, 23);
            this.label_status0.TabIndex = 6;
            this.label_status0.Text = "Checking status:";
            this.label_status0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressTimer
            // 
            this.progressTimer.Interval = 20;
            this.progressTimer.Tick += new System.EventHandler(this.ProgressTimer_Tick);
            // 
            // label_status1
            // 
            this.label_status1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label_status1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_status1.ForeColor = System.Drawing.Color.White;
            this.label_status1.Location = new System.Drawing.Point(252, 92);
            this.label_status1.Name = "label_status1";
            this.label_status1.Size = new System.Drawing.Size(182, 23);
            this.label_status1.TabIndex = 7;
            this.label_status1.Text = "All right.";
            this.label_status1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_errorMessageDetails
            // 
            this.button_errorMessageDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_errorMessageDetails.Location = new System.Drawing.Point(251, 89);
            this.button_errorMessageDetails.Name = "button_errorMessageDetails";
            this.button_errorMessageDetails.Size = new System.Drawing.Size(200, 26);
            this.button_errorMessageDetails.TabIndex = 8;
            this.button_errorMessageDetails.Text = "Error message details";
            this.button_errorMessageDetails.UseVisualStyleBackColor = true;
            this.button_errorMessageDetails.Visible = false;
            this.button_errorMessageDetails.Click += new System.EventHandler(this.Button_errorMessageDetails_Click);
            // 
            // button_connectToDatabase
            // 
            this.button_connectToDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_connectToDatabase.Location = new System.Drawing.Point(251, 116);
            this.button_connectToDatabase.Name = "button_connectToDatabase";
            this.button_connectToDatabase.Size = new System.Drawing.Size(200, 28);
            this.button_connectToDatabase.TabIndex = 9;
            this.button_connectToDatabase.Text = "Connect to database";
            this.button_connectToDatabase.UseVisualStyleBackColor = true;
            this.button_connectToDatabase.Visible = false;
            this.button_connectToDatabase.Click += new System.EventHandler(this.Button_connectToDatabase_Click);
            // 
            // label_noConnection
            // 
            this.label_noConnection.BackColor = System.Drawing.Color.Red;
            this.label_noConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_noConnection.ForeColor = System.Drawing.Color.White;
            this.label_noConnection.Location = new System.Drawing.Point(253, 66);
            this.label_noConnection.Name = "label_noConnection";
            this.label_noConnection.Size = new System.Drawing.Size(196, 20);
            this.label_noConnection.TabIndex = 10;
            this.label_noConnection.Text = "No database connection!";
            this.label_noConnection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_noConnection.Visible = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 591);
            this.Controls.Add(this.label_noConnection);
            this.Controls.Add(this.button_connectToDatabase);
            this.Controls.Add(this.button_errorMessageDetails);
            this.Controls.Add(this.label_status1);
            this.Controls.Add(this.label_status0);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button_database);
            this.Controls.Add(this.button_menu);
            this.Controls.Add(this.label_title);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_menu;
        private System.Windows.Forms.Button button_database;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label_status0;
        private System.Windows.Forms.Timer progressTimer;
        private System.Windows.Forms.Label label_status1;
        private System.Windows.Forms.Button button_errorMessageDetails;
        private System.Windows.Forms.Button button_connectToDatabase;
        private System.Windows.Forms.Label label_noConnection;
    }
}