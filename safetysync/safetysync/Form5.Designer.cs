namespace safetysync
{
    partial class Form5
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.btn_saveuser = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.refresh);
            this.panel1.Controls.Add(this.btn_saveuser);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Controls.Add(this.txt_pass);
            this.panel1.Controls.Add(this.Label2);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.Label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 284);
            this.panel1.TabIndex = 36;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(494, 190);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 32);
            this.button2.TabIndex = 42;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.Transparent;
            this.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refresh.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.refresh.Location = new System.Drawing.Point(26, 236);
            this.refresh.Margin = new System.Windows.Forms.Padding(4);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(105, 32);
            this.refresh.TabIndex = 41;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // btn_saveuser
            // 
            this.btn_saveuser.BackColor = System.Drawing.Color.Transparent;
            this.btn_saveuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_saveuser.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveuser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_saveuser.Location = new System.Drawing.Point(375, 190);
            this.btn_saveuser.Margin = new System.Windows.Forms.Padding(4);
            this.btn_saveuser.Name = "btn_saveuser";
            this.btn_saveuser.Size = new System.Drawing.Size(113, 32);
            this.btn_saveuser.TabIndex = 34;
            this.btn_saveuser.Text = "Save";
            this.btn_saveuser.UseVisualStyleBackColor = false;
            this.btn_saveuser.Click += new System.EventHandler(this.btn_saveuser_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_delete.Location = new System.Drawing.Point(595, 190);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(96, 32);
            this.btn_delete.TabIndex = 37;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(348, 62);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(372, 26);
            this.txt_name.TabIndex = 17;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label1.Location = new System.Drawing.Point(287, 66);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(57, 22);
            this.Label1.TabIndex = 19;
            this.Label1.Text = "Name :";
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(348, 140);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(372, 26);
            this.txt_pass.TabIndex = 20;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label2.Location = new System.Drawing.Point(252, 103);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(88, 22);
            this.Label2.TabIndex = 21;
            this.Label2.Text = "Username :";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(348, 103);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(372, 26);
            this.txt_username.TabIndex = 18;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label3.Location = new System.Drawing.Point(256, 140);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(87, 22);
            this.Label3.TabIndex = 22;
            this.Label3.Text = "Password :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(12, 284);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(947, 370);
            this.panel2.TabIndex = 37;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(947, 370);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(971, 666);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.Text = "Form5";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button refresh;
        internal System.Windows.Forms.Button btn_saveuser;
        internal System.Windows.Forms.Button btn_delete;
        internal System.Windows.Forms.TextBox txt_name;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txt_pass;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txt_username;
        internal System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}