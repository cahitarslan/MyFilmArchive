namespace MyFilmArchive
{
    partial class Form1
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
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnWhite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgwMovieList = new System.Windows.Forms.DataGridView();
            this.tbxMovieId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxCategory = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tbxLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkViewed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnWatch = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMovieList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnBlack);
            this.panel1.Controls.Add(this.btnWhite);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1721, 58);
            this.panel1.TabIndex = 0;
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.Color.Black;
            this.btnBlack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBlack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlack.Location = new System.Drawing.Point(1675, 18);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(34, 25);
            this.btnBlack.TabIndex = 3;
            this.btnBlack.UseVisualStyleBackColor = false;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // btnWhite
            // 
            this.btnWhite.BackColor = System.Drawing.Color.White;
            this.btnWhite.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnWhite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWhite.Location = new System.Drawing.Point(1635, 18);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(34, 25);
            this.btnWhite.TabIndex = 2;
            this.btnWhite.UseVisualStyleBackColor = false;
            this.btnWhite.Click += new System.EventHandler(this.btnWhite_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Movie Archive";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyFilmArchive.Properties.Resources.source;
            this.pictureBox1.Location = new System.Drawing.Point(3, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgwMovieList);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(3, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 669);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Movie List";
            // 
            // dgwMovieList
            // 
            this.dgwMovieList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwMovieList.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgwMovieList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwMovieList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMovieList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbxMovieId,
            this.tbxName,
            this.cbxCategory,
            this.tbxLink,
            this.chkViewed});
            this.dgwMovieList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwMovieList.Location = new System.Drawing.Point(3, 23);
            this.dgwMovieList.MultiSelect = false;
            this.dgwMovieList.Name = "dgwMovieList";
            this.dgwMovieList.Size = new System.Drawing.Size(569, 643);
            this.dgwMovieList.TabIndex = 0;
            this.dgwMovieList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMovieList_CellClick);
            this.dgwMovieList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMovieList_CellValueChanged);
            this.dgwMovieList.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgwMovieList_EditingControlShowing);
            this.dgwMovieList.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgwMovieList_UserDeletingRow);
            // 
            // tbxMovieId
            // 
            this.tbxMovieId.DataPropertyName = "MovieId";
            this.tbxMovieId.HeaderText = "MovieId";
            this.tbxMovieId.MinimumWidth = 26;
            this.tbxMovieId.Name = "tbxMovieId";
            this.tbxMovieId.Visible = false;
            // 
            // tbxName
            // 
            this.tbxName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tbxName.DataPropertyName = "FilmName";
            this.tbxName.FillWeight = 305.6249F;
            this.tbxName.HeaderText = "Name";
            this.tbxName.MinimumWidth = 200;
            this.tbxName.Name = "tbxName";
            // 
            // cbxCategory
            // 
            this.cbxCategory.DataPropertyName = "CategoryId";
            this.cbxCategory.FillWeight = 9.510321F;
            this.cbxCategory.HeaderText = "Category";
            this.cbxCategory.MinimumWidth = 100;
            this.cbxCategory.Name = "cbxCategory";
            // 
            // tbxLink
            // 
            this.tbxLink.DataPropertyName = "Link";
            this.tbxLink.FillWeight = 79.18787F;
            this.tbxLink.HeaderText = "Link";
            this.tbxLink.MinimumWidth = 150;
            this.tbxLink.Name = "tbxLink";
            this.tbxLink.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tbxLink.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // chkViewed
            // 
            this.chkViewed.DataPropertyName = "Viewed";
            this.chkViewed.FillWeight = 5.67713F;
            this.chkViewed.HeaderText = "Viewed";
            this.chkViewed.MinimumWidth = 70;
            this.chkViewed.Name = "chkViewed";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.webBrowser1);
            this.groupBox2.Location = new System.Drawing.Point(581, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1128, 709);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 23);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1122, 683);
            this.webBrowser1.TabIndex = 0;
            // 
            // btnWatch
            // 
            this.btnWatch.BackColor = System.Drawing.Color.Transparent;
            this.btnWatch.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnWatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWatch.ForeColor = System.Drawing.Color.White;
            this.btnWatch.Location = new System.Drawing.Point(12, 739);
            this.btnWatch.Name = "btnWatch";
            this.btnWatch.Size = new System.Drawing.Size(167, 34);
            this.btnWatch.TabIndex = 2;
            this.btnWatch.Text = "Watch";
            this.btnWatch.UseVisualStyleBackColor = false;
            this.btnWatch.Click += new System.EventHandler(this.btnWatch_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(201, 739);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(173, 34);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.Text = "New Tab";
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(400, 739);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(175, 34);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1721, 785);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnWatch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Watching App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMovieList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnWatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwMovieList;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbxMovieId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbxName;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbxCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbxLink;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkViewed;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.Button btnWhite;
        private System.Windows.Forms.Button btnClose;
    }
}

