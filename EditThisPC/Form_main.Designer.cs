namespace EditMyPC
{
    partial class Form_main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel_main = new System.Windows.Forms.TableLayoutPanel();
            this.button_apply = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.groupBox_details = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_details = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox_Music = new System.Windows.Forms.CheckBox();
            this.checkBox_3D_Objects = new System.Windows.Forms.CheckBox();
            this.checkBox_Videos = new System.Windows.Forms.CheckBox();
            this.checkBox_Downloads = new System.Windows.Forms.CheckBox();
            this.checkBox_Pictures = new System.Windows.Forms.CheckBox();
            this.checkBox_Desktop = new System.Windows.Forms.CheckBox();
            this.checkBox_Documents = new System.Windows.Forms.CheckBox();
            this.checkBox_All = new System.Windows.Forms.CheckBox();
            this.label_title = new System.Windows.Forms.Label();
            this.tableLayoutPanel_main.SuspendLayout();
            this.groupBox_details.SuspendLayout();
            this.tableLayoutPanel_details.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_main
            // 
            this.tableLayoutPanel_main.ColumnCount = 2;
            this.tableLayoutPanel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_main.Controls.Add(this.button_apply, 0, 3);
            this.tableLayoutPanel_main.Controls.Add(this.button_exit, 1, 3);
            this.tableLayoutPanel_main.Controls.Add(this.groupBox_details, 0, 2);
            this.tableLayoutPanel_main.Controls.Add(this.checkBox_All, 0, 1);
            this.tableLayoutPanel_main.Controls.Add(this.label_title, 0, 0);
            this.tableLayoutPanel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_main.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_main.Name = "tableLayoutPanel_main";
            this.tableLayoutPanel_main.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel_main.RowCount = 4;
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel_main.Size = new System.Drawing.Size(300, 500);
            this.tableLayoutPanel_main.TabIndex = 0;
            // 
            // button_apply
            // 
            this.button_apply.BackColor = System.Drawing.Color.LightBlue;
            this.button_apply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_apply.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_apply.Location = new System.Drawing.Point(13, 443);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(134, 44);
            this.button_apply.TabIndex = 0;
            this.button_apply.Text = "&Apply";
            this.button_apply.UseVisualStyleBackColor = false;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.LightBlue;
            this.button_exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_exit.Location = new System.Drawing.Point(153, 443);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(134, 44);
            this.button_exit.TabIndex = 0;
            this.button_exit.Text = "E&xit";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // groupBox_details
            // 
            this.tableLayoutPanel_main.SetColumnSpan(this.groupBox_details, 2);
            this.groupBox_details.Controls.Add(this.tableLayoutPanel_details);
            this.groupBox_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_details.Location = new System.Drawing.Point(13, 83);
            this.groupBox_details.Name = "groupBox_details";
            this.groupBox_details.Size = new System.Drawing.Size(274, 354);
            this.groupBox_details.TabIndex = 1;
            this.groupBox_details.TabStop = false;
            this.groupBox_details.Text = "Details";
            // 
            // tableLayoutPanel_details
            // 
            this.tableLayoutPanel_details.ColumnCount = 1;
            this.tableLayoutPanel_details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_details.Controls.Add(this.checkBox_Music, 0, 6);
            this.tableLayoutPanel_details.Controls.Add(this.checkBox_3D_Objects, 0, 0);
            this.tableLayoutPanel_details.Controls.Add(this.checkBox_Videos, 0, 5);
            this.tableLayoutPanel_details.Controls.Add(this.checkBox_Downloads, 0, 1);
            this.tableLayoutPanel_details.Controls.Add(this.checkBox_Pictures, 0, 4);
            this.tableLayoutPanel_details.Controls.Add(this.checkBox_Desktop, 0, 2);
            this.tableLayoutPanel_details.Controls.Add(this.checkBox_Documents, 0, 3);
            this.tableLayoutPanel_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_details.Location = new System.Drawing.Point(3, 15);
            this.tableLayoutPanel_details.Name = "tableLayoutPanel_details";
            this.tableLayoutPanel_details.RowCount = 7;
            this.tableLayoutPanel_details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel_details.Size = new System.Drawing.Size(268, 336);
            this.tableLayoutPanel_details.TabIndex = 24;
            // 
            // checkBox_Music
            // 
            this.checkBox_Music.AutoSize = true;
            this.checkBox_Music.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_Music.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_Music.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox_Music.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox_Music.Location = new System.Drawing.Point(3, 285);
            this.checkBox_Music.Name = "checkBox_Music";
            this.checkBox_Music.Padding = new System.Windows.Forms.Padding(10);
            this.checkBox_Music.Size = new System.Drawing.Size(262, 48);
            this.checkBox_Music.TabIndex = 21;
            this.checkBox_Music.Tag = "Music";
            this.checkBox_Music.Text = "Music";
            this.checkBox_Music.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_Music.UseVisualStyleBackColor = true;
            this.checkBox_Music.CheckedChanged += new System.EventHandler(this.checkBox_Details_CheckedChanged);
            // 
            // checkBox_3D_Objects
            // 
            this.checkBox_3D_Objects.AutoSize = true;
            this.checkBox_3D_Objects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_3D_Objects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_3D_Objects.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox_3D_Objects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox_3D_Objects.Location = new System.Drawing.Point(3, 3);
            this.checkBox_3D_Objects.Name = "checkBox_3D_Objects";
            this.checkBox_3D_Objects.Padding = new System.Windows.Forms.Padding(10);
            this.checkBox_3D_Objects.Size = new System.Drawing.Size(262, 41);
            this.checkBox_3D_Objects.TabIndex = 19;
            this.checkBox_3D_Objects.Tag = "3D Objects";
            this.checkBox_3D_Objects.Text = "3D Objects";
            this.checkBox_3D_Objects.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_3D_Objects.UseVisualStyleBackColor = true;
            this.checkBox_3D_Objects.CheckedChanged += new System.EventHandler(this.checkBox_Details_CheckedChanged);
            // 
            // checkBox_Videos
            // 
            this.checkBox_Videos.AutoSize = true;
            this.checkBox_Videos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_Videos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_Videos.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox_Videos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox_Videos.Location = new System.Drawing.Point(3, 238);
            this.checkBox_Videos.Name = "checkBox_Videos";
            this.checkBox_Videos.Padding = new System.Windows.Forms.Padding(10);
            this.checkBox_Videos.Size = new System.Drawing.Size(262, 41);
            this.checkBox_Videos.TabIndex = 23;
            this.checkBox_Videos.Tag = "Videos";
            this.checkBox_Videos.Text = "Videos";
            this.checkBox_Videos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_Videos.UseVisualStyleBackColor = true;
            this.checkBox_Videos.CheckedChanged += new System.EventHandler(this.checkBox_Details_CheckedChanged);
            // 
            // checkBox_Downloads
            // 
            this.checkBox_Downloads.AutoSize = true;
            this.checkBox_Downloads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_Downloads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_Downloads.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox_Downloads.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox_Downloads.Location = new System.Drawing.Point(3, 50);
            this.checkBox_Downloads.Name = "checkBox_Downloads";
            this.checkBox_Downloads.Padding = new System.Windows.Forms.Padding(10);
            this.checkBox_Downloads.Size = new System.Drawing.Size(262, 41);
            this.checkBox_Downloads.TabIndex = 20;
            this.checkBox_Downloads.Tag = "Downloads";
            this.checkBox_Downloads.Text = "Downloads";
            this.checkBox_Downloads.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_Downloads.UseVisualStyleBackColor = true;
            this.checkBox_Downloads.CheckedChanged += new System.EventHandler(this.checkBox_Details_CheckedChanged);
            // 
            // checkBox_Pictures
            // 
            this.checkBox_Pictures.AutoSize = true;
            this.checkBox_Pictures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_Pictures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_Pictures.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox_Pictures.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox_Pictures.Location = new System.Drawing.Point(3, 191);
            this.checkBox_Pictures.Name = "checkBox_Pictures";
            this.checkBox_Pictures.Padding = new System.Windows.Forms.Padding(10);
            this.checkBox_Pictures.Size = new System.Drawing.Size(262, 41);
            this.checkBox_Pictures.TabIndex = 22;
            this.checkBox_Pictures.Tag = "Pictures";
            this.checkBox_Pictures.Text = "Pictures";
            this.checkBox_Pictures.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_Pictures.UseVisualStyleBackColor = true;
            this.checkBox_Pictures.CheckedChanged += new System.EventHandler(this.checkBox_Details_CheckedChanged);
            // 
            // checkBox_Desktop
            // 
            this.checkBox_Desktop.AutoSize = true;
            this.checkBox_Desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_Desktop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_Desktop.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox_Desktop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox_Desktop.Location = new System.Drawing.Point(3, 97);
            this.checkBox_Desktop.Name = "checkBox_Desktop";
            this.checkBox_Desktop.Padding = new System.Windows.Forms.Padding(10);
            this.checkBox_Desktop.Size = new System.Drawing.Size(262, 41);
            this.checkBox_Desktop.TabIndex = 17;
            this.checkBox_Desktop.Tag = "Desktop";
            this.checkBox_Desktop.Text = "Desktop";
            this.checkBox_Desktop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_Desktop.UseVisualStyleBackColor = true;
            this.checkBox_Desktop.CheckedChanged += new System.EventHandler(this.checkBox_Details_CheckedChanged);
            // 
            // checkBox_Documents
            // 
            this.checkBox_Documents.AutoSize = true;
            this.checkBox_Documents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_Documents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_Documents.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox_Documents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox_Documents.Location = new System.Drawing.Point(3, 144);
            this.checkBox_Documents.Name = "checkBox_Documents";
            this.checkBox_Documents.Padding = new System.Windows.Forms.Padding(10);
            this.checkBox_Documents.Size = new System.Drawing.Size(262, 41);
            this.checkBox_Documents.TabIndex = 18;
            this.checkBox_Documents.Tag = "Documents";
            this.checkBox_Documents.Text = "Documents";
            this.checkBox_Documents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_Documents.UseVisualStyleBackColor = true;
            this.checkBox_Documents.CheckedChanged += new System.EventHandler(this.checkBox_Details_CheckedChanged);
            // 
            // checkBox_All
            // 
            this.checkBox_All.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_All.AutoSize = true;
            this.tableLayoutPanel_main.SetColumnSpan(this.checkBox_All, 2);
            this.checkBox_All.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_All.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox_All.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox_All.Location = new System.Drawing.Point(13, 33);
            this.checkBox_All.Name = "checkBox_All";
            this.checkBox_All.Padding = new System.Windows.Forms.Padding(10);
            this.checkBox_All.Size = new System.Drawing.Size(274, 43);
            this.checkBox_All.TabIndex = 2;
            this.checkBox_All.Text = "All Items";
            this.checkBox_All.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_All.UseVisualStyleBackColor = true;
            this.checkBox_All.CheckedChanged += new System.EventHandler(this.checkBox_All_CheckedChanged);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.tableLayoutPanel_main.SetColumnSpan(this.label_title, 2);
            this.label_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_title.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_title.Location = new System.Drawing.Point(13, 10);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(274, 20);
            this.label_title.TabIndex = 3;
            this.label_title.Text = "Enable / Disable Items";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(300, 500);
            this.Controls.Add(this.tableLayoutPanel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_main";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditThisPC";
            this.TopMost = true;
            this.tableLayoutPanel_main.ResumeLayout(false);
            this.tableLayoutPanel_main.PerformLayout();
            this.groupBox_details.ResumeLayout(false);
            this.tableLayoutPanel_details.ResumeLayout(false);
            this.tableLayoutPanel_details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_main;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.GroupBox groupBox_details;
        private System.Windows.Forms.CheckBox checkBox_All;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_details;
        private System.Windows.Forms.CheckBox checkBox_Music;
        private System.Windows.Forms.CheckBox checkBox_3D_Objects;
        private System.Windows.Forms.CheckBox checkBox_Videos;
        private System.Windows.Forms.CheckBox checkBox_Downloads;
        private System.Windows.Forms.CheckBox checkBox_Pictures;
        private System.Windows.Forms.CheckBox checkBox_Desktop;
        private System.Windows.Forms.CheckBox checkBox_Documents;
        private System.Windows.Forms.Label label_title;
    }
}

