namespace FireFlow_Oven
{
    partial class Connection
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
            this.ConnectionsListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Refresh_Connection = new System.Windows.Forms.Button();
            this.Button_Connect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectionsListBox
            // 
            this.ConnectionsListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.ConnectionsListBox, 2);
            this.ConnectionsListBox.FormattingEnabled = true;
            this.ConnectionsListBox.Location = new System.Drawing.Point(5, 23);
            this.ConnectionsListBox.Margin = new System.Windows.Forms.Padding(0);
            this.ConnectionsListBox.Name = "ConnectionsListBox";
            this.ConnectionsListBox.Size = new System.Drawing.Size(250, 134);
            this.ConnectionsListBox.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel1.Controls.Add(this.ConnectionsListBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Button_Refresh_Connection, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Button_Connect, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 198);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Connection: Below are COM Ports Seen";
            // 
            // Button_Refresh_Connection
            // 
            this.Button_Refresh_Connection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Refresh_Connection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Refresh_Connection.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Button_Refresh_Connection.FlatAppearance.BorderSize = 0;
            this.Button_Refresh_Connection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Refresh_Connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Button_Refresh_Connection.ForeColor = System.Drawing.Color.White;
            this.Button_Refresh_Connection.Location = new System.Drawing.Point(7, 166);
            this.Button_Refresh_Connection.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Refresh_Connection.Name = "Button_Refresh_Connection";
            this.Button_Refresh_Connection.Size = new System.Drawing.Size(120, 23);
            this.Button_Refresh_Connection.TabIndex = 19;
            this.Button_Refresh_Connection.Text = "Refresh";
            this.Button_Refresh_Connection.UseVisualStyleBackColor = false;
            this.Button_Refresh_Connection.Click += new System.EventHandler(this.Button_Refresh_Connection_Click);
            // 
            // Button_Connect
            // 
            this.Button_Connect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Connect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Button_Connect.FlatAppearance.BorderSize = 0;
            this.Button_Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Button_Connect.ForeColor = System.Drawing.Color.White;
            this.Button_Connect.Location = new System.Drawing.Point(137, 166);
            this.Button_Connect.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Connect.Name = "Button_Connect";
            this.Button_Connect.Size = new System.Drawing.Size(120, 23);
            this.Button_Connect.TabIndex = 20;
            this.Button_Connect.Text = "Connect";
            this.Button_Connect.UseVisualStyleBackColor = false;
            this.Button_Connect.Click += new System.EventHandler(this.Button_Connect_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 180);
            this.panel1.TabIndex = 5;
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(284, 220);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Connection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connections";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ConnectionsListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Refresh_Connection;
        private System.Windows.Forms.Button Button_Connect;
    }
}