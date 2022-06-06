
namespace WinForms_StorageManager
{
    partial class StatisticsForm
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
            this.button_showRevenue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_printFile = new System.Windows.Forms.Button();
            this.button_viewFile = new System.Windows.Forms.Button();
            this.dgv_file = new System.Windows.Forms.DataGridView();
            this.label_file = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_values)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_file)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_values
            // 
            this.dgv_values.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_values.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_values.Location = new System.Drawing.Point(18, 45);
            this.dgv_values.Name = "dgv_values";
            this.dgv_values.RowHeadersWidth = 51;
            this.dgv_values.Size = new System.Drawing.Size(320, 400);
            this.dgv_values.TabIndex = 11;
            this.dgv_values.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgw_values_CellClick);
            // 
            // label_message
            // 
            this.label_message.AutoSize = true;
            this.label_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_message.Location = new System.Drawing.Point(17, 528);
            this.label_message.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_message.MaximumSize = new System.Drawing.Size(650, 0);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(65, 17);
            this.label_message.TabIndex = 13;
            this.label_message.Text = "Message";
            // 
            // button_showRevenue
            // 
            this.button_showRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_showRevenue.Location = new System.Drawing.Point(217, 7);
            this.button_showRevenue.Margin = new System.Windows.Forms.Padding(2);
            this.button_showRevenue.Name = "button_showRevenue";
            this.button_showRevenue.Size = new System.Drawing.Size(121, 31);
            this.button_showRevenue.TabIndex = 15;
            this.button_showRevenue.Text = "Show revenue";
            this.button_showRevenue.UseVisualStyleBackColor = true;
            this.button_showRevenue.Click += new System.EventHandler(this.Button_showRevenue_Click);
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
            // Button_printFile
            // 
            this.Button_printFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_printFile.BackColor = System.Drawing.Color.Chartreuse;
            this.Button_printFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_printFile.Location = new System.Drawing.Point(130, 463);
            this.Button_printFile.Margin = new System.Windows.Forms.Padding(2);
            this.Button_printFile.Name = "Button_printFile";
            this.Button_printFile.Size = new System.Drawing.Size(113, 44);
            this.Button_printFile.TabIndex = 17;
            this.Button_printFile.Text = "Print file";
            this.Button_printFile.UseVisualStyleBackColor = false;
            this.Button_printFile.Click += new System.EventHandler(this.Button_printFile_Click);
            // 
            // button_viewFile
            // 
            this.button_viewFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_viewFile.BackColor = System.Drawing.Color.Chartreuse;
            this.button_viewFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_viewFile.Location = new System.Drawing.Point(452, 463);
            this.button_viewFile.Margin = new System.Windows.Forms.Padding(2);
            this.button_viewFile.Name = "button_viewFile";
            this.button_viewFile.Size = new System.Drawing.Size(113, 44);
            this.button_viewFile.TabIndex = 21;
            this.button_viewFile.Text = "View file";
            this.button_viewFile.UseVisualStyleBackColor = false;
            this.button_viewFile.Click += new System.EventHandler(this.Button_viewFile_Click);
            // 
            // dgv_file
            // 
            this.dgv_file.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_file.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_file.Location = new System.Drawing.Point(352, 45);
            this.dgv_file.Name = "dgv_file";
            this.dgv_file.RowHeadersWidth = 51;
            this.dgv_file.Size = new System.Drawing.Size(318, 400);
            this.dgv_file.TabIndex = 22;
            // 
            // label_file
            // 
            this.label_file.AutoSize = true;
            this.label_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_file.Location = new System.Drawing.Point(464, 475);
            this.label_file.Name = "label_file";
            this.label_file.Size = new System.Drawing.Size(81, 20);
            this.label_file.TabIndex = 23;
            this.label_file.Text = "label_file";
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 591);
            this.Controls.Add(this.label_file);
            this.Controls.Add(this.dgv_file);
            this.Controls.Add(this.button_viewFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_showRevenue);
            this.Controls.Add(this.label_message);
            this.Controls.Add(this.dgv_values);
            this.Controls.Add(this.Button_printFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StatisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_values)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_file)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_values;
        private System.Windows.Forms.Label label_message;
        private System.Windows.Forms.Button button_showRevenue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_printFile;
        private System.Windows.Forms.Button button_viewFile;
        private System.Windows.Forms.DataGridView dgv_file;
        private System.Windows.Forms.Label label_file;
    }
}

