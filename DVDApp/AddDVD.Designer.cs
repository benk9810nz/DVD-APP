namespace DVDApp
{
    partial class AddDVD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDVD));
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_genre = new System.Windows.Forms.TextBox();
            this.nUD_rating = new System.Windows.Forms.NumericUpDown();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_Genre = new System.Windows.Forms.Label();
            this.lb_rating = new System.Windows.Forms.Label();
            this.cb_mature = new System.Windows.Forms.ComboBox();
            this.lb_mature = new System.Windows.Forms.Label();
            this.bt_Save = new System.Windows.Forms.Button();
            this.bt_Discard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_rating)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(33, 48);
            this.tb_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(498, 40);
            this.tb_name.TabIndex = 0;
            this.tb_name.Text = "Name";
            this.tb_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // tb_genre
            // 
            this.tb_genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_genre.Location = new System.Drawing.Point(33, 135);
            this.tb_genre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_genre.Name = "tb_genre";
            this.tb_genre.Size = new System.Drawing.Size(498, 40);
            this.tb_genre.TabIndex = 1;
            this.tb_genre.Text = "Genre";
            this.tb_genre.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // nUD_rating
            // 
            this.nUD_rating.Location = new System.Drawing.Point(116, 206);
            this.nUD_rating.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nUD_rating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUD_rating.Name = "nUD_rating";
            this.nUD_rating.Size = new System.Drawing.Size(92, 26);
            this.nUD_rating.TabIndex = 4;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(36, 23);
            this.lb_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(88, 20);
            this.lb_name.TabIndex = 5;
            this.lb_name.Text = "Film Name:";
            // 
            // lb_Genre
            // 
            this.lb_Genre.AutoSize = true;
            this.lb_Genre.Location = new System.Drawing.Point(36, 111);
            this.lb_Genre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Genre.Name = "lb_Genre";
            this.lb_Genre.Size = new System.Drawing.Size(87, 20);
            this.lb_Genre.TabIndex = 6;
            this.lb_Genre.Text = "Film Genre";
            // 
            // lb_rating
            // 
            this.lb_rating.AutoSize = true;
            this.lb_rating.Location = new System.Drawing.Point(34, 209);
            this.lb_rating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_rating.Name = "lb_rating";
            this.lb_rating.Size = new System.Drawing.Size(60, 20);
            this.lb_rating.TabIndex = 7;
            this.lb_rating.Text = "Rating:";
            // 
            // cb_mature
            // 
            this.cb_mature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_mature.FormattingEnabled = true;
            this.cb_mature.Items.AddRange(new object[] {
            "G",
            "PG",
            "M",
            "R13",
            "R15",
            "R16",
            "R18"});
            this.cb_mature.Location = new System.Drawing.Point(240, 272);
            this.cb_mature.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_mature.Name = "cb_mature";
            this.cb_mature.Size = new System.Drawing.Size(180, 28);
            this.cb_mature.TabIndex = 8;
            this.cb_mature.ValueMemberChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // lb_mature
            // 
            this.lb_mature.AutoSize = true;
            this.lb_mature.Location = new System.Drawing.Point(28, 277);
            this.lb_mature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_mature.Name = "lb_mature";
            this.lb_mature.Size = new System.Drawing.Size(162, 20);
            this.lb_mature.TabIndex = 9;
            this.lb_mature.Text = "Maturity Classification";
            // 
            // bt_Save
            // 
            this.bt_Save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Save.Location = new System.Drawing.Point(33, 386);
            this.bt_Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(158, 77);
            this.bt_Save.TabIndex = 10;
            this.bt_Save.Text = "Save";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // bt_Discard
            // 
            this.bt_Discard.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Discard.Location = new System.Drawing.Point(375, 386);
            this.bt_Discard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_Discard.Name = "bt_Discard";
            this.bt_Discard.Size = new System.Drawing.Size(158, 77);
            this.bt_Discard.TabIndex = 11;
            this.bt_Discard.Text = "Discard";
            this.bt_Discard.UseVisualStyleBackColor = true;
            // 
            // AddDVD
            // 
            this.AcceptButton = this.bt_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_Discard;
            this.ClientSize = new System.Drawing.Size(591, 485);
            this.Controls.Add(this.bt_Discard);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.lb_mature);
            this.Controls.Add(this.cb_mature);
            this.Controls.Add(this.lb_rating);
            this.Controls.Add(this.lb_Genre);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.nUD_rating);
            this.Controls.Add(this.tb_genre);
            this.Controls.Add(this.tb_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "AddDVD";
            this.Text = "Add/Edit DVD";
            this.Load += new System.EventHandler(this.AddDVD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUD_rating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_genre;
        private System.Windows.Forms.NumericUpDown nUD_rating;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_Genre;
        private System.Windows.Forms.Label lb_rating;
        private System.Windows.Forms.ComboBox cb_mature;
        private System.Windows.Forms.Label lb_mature;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.Button bt_Discard;
    }
}