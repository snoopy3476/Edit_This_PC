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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.tableLayoutPanel_main = new System.Windows.Forms.TableLayoutPanel();
            this.button_apply = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.groupBox_details = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_details = new System.Windows.Forms.TableLayoutPanel();
            this.c_Music = new System.Windows.Forms.CheckBox();
            this.c_3D_Objects = new System.Windows.Forms.CheckBox();
            this.c_Videos = new System.Windows.Forms.CheckBox();
            this.c_Downloads = new System.Windows.Forms.CheckBox();
            this.c_Pictures = new System.Windows.Forms.CheckBox();
            this.c_Desktop = new System.Windows.Forms.CheckBox();
            this.c_Documents = new System.Windows.Forms.CheckBox();
            this.c_All = new System.Windows.Forms.CheckBox();
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
            this.tableLayoutPanel_main.Controls.Add(this.c_All, 0, 1);
            this.tableLayoutPanel_main.Controls.Add(this.label_title, 0, 0);
            this.tableLayoutPanel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_main.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_main.Name = "tableLayoutPanel_main";
            this.tableLayoutPanel_main.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel_main.RowCount = 4;
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel_main.Size = new System.Drawing.Size(300, 520);
            this.tableLayoutPanel_main.TabIndex = 0;
            // 
            // button_apply
            // 
            this.button_apply.BackColor = System.Drawing.Color.LightBlue;
            this.button_apply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_apply.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_apply.Location = new System.Drawing.Point(13, 463);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(134, 44);
            this.button_apply.TabIndex = 0;
            this.button_apply.Text = "Apply (&A)";
            this.button_apply.UseVisualStyleBackColor = false;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.LightBlue;
            this.button_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_exit.Location = new System.Drawing.Point(153, 463);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(134, 44);
            this.button_exit.TabIndex = 0;
            this.button_exit.Text = "Exit (&X)";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // groupBox_details
            // 
            this.tableLayoutPanel_main.SetColumnSpan(this.groupBox_details, 2);
            this.groupBox_details.Controls.Add(this.tableLayoutPanel_details);
            this.groupBox_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_details.Location = new System.Drawing.Point(13, 103);
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
            this.tableLayoutPanel_details.Controls.Add(this.c_Music, 0, 6);
            this.tableLayoutPanel_details.Controls.Add(this.c_3D_Objects, 0, 0);
            this.tableLayoutPanel_details.Controls.Add(this.c_Videos, 0, 5);
            this.tableLayoutPanel_details.Controls.Add(this.c_Downloads, 0, 1);
            this.tableLayoutPanel_details.Controls.Add(this.c_Pictures, 0, 4);
            this.tableLayoutPanel_details.Controls.Add(this.c_Desktop, 0, 2);
            this.tableLayoutPanel_details.Controls.Add(this.c_Documents, 0, 3);
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
            // c_Music
            // 
            this.c_Music.AutoSize = true;
            this.c_Music.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_Music.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_Music.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.c_Music.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c_Music.Location = new System.Drawing.Point(3, 285);
            this.c_Music.Name = "c_Music";
            this.c_Music.Padding = new System.Windows.Forms.Padding(10);
            this.c_Music.Size = new System.Drawing.Size(262, 48);
            this.c_Music.TabIndex = 21;
            this.c_Music.Tag = "";
            this.c_Music.Text = "Music";
            this.c_Music.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.c_Music.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.c_Music.UseVisualStyleBackColor = true;
            this.c_Music.CheckedChanged += new System.EventHandler(this.c_Details_CheckedChanged);
            // 
            // c_3D_Objects
            // 
            this.c_3D_Objects.AutoSize = true;
            this.c_3D_Objects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_3D_Objects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_3D_Objects.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.c_3D_Objects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c_3D_Objects.Location = new System.Drawing.Point(3, 3);
            this.c_3D_Objects.Name = "c_3D_Objects";
            this.c_3D_Objects.Padding = new System.Windows.Forms.Padding(10);
            this.c_3D_Objects.Size = new System.Drawing.Size(262, 41);
            this.c_3D_Objects.TabIndex = 19;
            this.c_3D_Objects.Tag = "";
            this.c_3D_Objects.Text = "3D Objects";
            this.c_3D_Objects.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.c_3D_Objects.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.c_3D_Objects.UseVisualStyleBackColor = true;
            this.c_3D_Objects.CheckedChanged += new System.EventHandler(this.c_Details_CheckedChanged);
            // 
            // c_Videos
            // 
            this.c_Videos.AutoSize = true;
            this.c_Videos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_Videos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_Videos.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.c_Videos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c_Videos.Location = new System.Drawing.Point(3, 238);
            this.c_Videos.Name = "c_Videos";
            this.c_Videos.Padding = new System.Windows.Forms.Padding(10);
            this.c_Videos.Size = new System.Drawing.Size(262, 41);
            this.c_Videos.TabIndex = 23;
            this.c_Videos.Tag = "";
            this.c_Videos.Text = "Videos";
            this.c_Videos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.c_Videos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.c_Videos.UseVisualStyleBackColor = true;
            this.c_Videos.CheckedChanged += new System.EventHandler(this.c_Details_CheckedChanged);
            // 
            // c_Downloads
            // 
            this.c_Downloads.AutoSize = true;
            this.c_Downloads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_Downloads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_Downloads.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.c_Downloads.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c_Downloads.Location = new System.Drawing.Point(3, 50);
            this.c_Downloads.Name = "c_Downloads";
            this.c_Downloads.Padding = new System.Windows.Forms.Padding(10);
            this.c_Downloads.Size = new System.Drawing.Size(262, 41);
            this.c_Downloads.TabIndex = 20;
            this.c_Downloads.Tag = "";
            this.c_Downloads.Text = "Downloads";
            this.c_Downloads.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.c_Downloads.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.c_Downloads.UseVisualStyleBackColor = true;
            this.c_Downloads.CheckedChanged += new System.EventHandler(this.c_Details_CheckedChanged);
            // 
            // c_Pictures
            // 
            this.c_Pictures.AutoSize = true;
            this.c_Pictures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_Pictures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_Pictures.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.c_Pictures.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c_Pictures.Location = new System.Drawing.Point(3, 191);
            this.c_Pictures.Name = "c_Pictures";
            this.c_Pictures.Padding = new System.Windows.Forms.Padding(10);
            this.c_Pictures.Size = new System.Drawing.Size(262, 41);
            this.c_Pictures.TabIndex = 22;
            this.c_Pictures.Tag = "";
            this.c_Pictures.Text = "Pictures";
            this.c_Pictures.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.c_Pictures.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.c_Pictures.UseVisualStyleBackColor = true;
            this.c_Pictures.CheckedChanged += new System.EventHandler(this.c_Details_CheckedChanged);
            // 
            // c_Desktop
            // 
            this.c_Desktop.AutoSize = true;
            this.c_Desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_Desktop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_Desktop.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.c_Desktop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c_Desktop.Location = new System.Drawing.Point(3, 97);
            this.c_Desktop.Name = "c_Desktop";
            this.c_Desktop.Padding = new System.Windows.Forms.Padding(10);
            this.c_Desktop.Size = new System.Drawing.Size(262, 41);
            this.c_Desktop.TabIndex = 17;
            this.c_Desktop.Tag = "";
            this.c_Desktop.Text = "Desktop";
            this.c_Desktop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.c_Desktop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.c_Desktop.UseVisualStyleBackColor = true;
            this.c_Desktop.CheckedChanged += new System.EventHandler(this.c_Details_CheckedChanged);
            // 
            // c_Documents
            // 
            this.c_Documents.AutoSize = true;
            this.c_Documents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c_Documents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_Documents.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.c_Documents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c_Documents.Location = new System.Drawing.Point(3, 144);
            this.c_Documents.Name = "c_Documents";
            this.c_Documents.Padding = new System.Windows.Forms.Padding(10);
            this.c_Documents.Size = new System.Drawing.Size(262, 41);
            this.c_Documents.TabIndex = 18;
            this.c_Documents.Tag = "";
            this.c_Documents.Text = "Documents";
            this.c_Documents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.c_Documents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.c_Documents.UseVisualStyleBackColor = true;
            this.c_Documents.CheckedChanged += new System.EventHandler(this.c_Details_CheckedChanged);
            // 
            // c_All
            // 
            this.c_All.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.c_All.AutoSize = true;
            this.tableLayoutPanel_main.SetColumnSpan(this.c_All, 2);
            this.c_All.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_All.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.c_All.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c_All.Location = new System.Drawing.Point(13, 53);
            this.c_All.Name = "c_All";
            this.c_All.Padding = new System.Windows.Forms.Padding(10);
            this.c_All.Size = new System.Drawing.Size(274, 43);
            this.c_All.TabIndex = 2;
            this.c_All.Text = "All Items";
            this.c_All.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.c_All.UseVisualStyleBackColor = true;
            this.c_All.CheckedChanged += new System.EventHandler(this.c_All_CheckedChanged);
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
            this.label_title.Size = new System.Drawing.Size(274, 40);
            this.label_title.TabIndex = 3;
            this.label_title.Text = "This PC\r\nEnable / Disable Items";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_main
            // 
            this.AcceptButton = this.button_apply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.CancelButton = this.button_exit;
            this.ClientSize = new System.Drawing.Size(300, 520);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_main";
            this.Opacity = 0.9D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit This PC";
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
        private System.Windows.Forms.CheckBox c_All;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_details;
        private System.Windows.Forms.CheckBox c_Music;
        private System.Windows.Forms.CheckBox c_3D_Objects;
        private System.Windows.Forms.CheckBox c_Videos;
        private System.Windows.Forms.CheckBox c_Downloads;
        private System.Windows.Forms.CheckBox c_Pictures;
        private System.Windows.Forms.CheckBox c_Desktop;
        private System.Windows.Forms.CheckBox c_Documents;
        private System.Windows.Forms.Label label_title;
    }
}

