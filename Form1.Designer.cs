namespace TVTS
{
    partial class TVTS
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBox = new System.Windows.Forms.ListBox();
            this.textBox_year = new System.Windows.Forms.TextBox();
            this.textBox_model = new System.Windows.Forms.TextBox();
            this.textBox_make = new System.Windows.Forms.TextBox();
            this.lbl_year = new System.Windows.Forms.Label();
            this.lbl_Model = new System.Windows.Forms.Label();
            this.lbl_make = new System.Windows.Forms.Label();
            this.btn_addCar = new System.Windows.Forms.Button();
            this.btn_sInv = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBox_Owned = new System.Windows.Forms.ListBox();
            this.btn_ownedSearch = new System.Windows.Forms.Button();
            this.tb_ownYear = new System.Windows.Forms.TextBox();
            this.tb_ownModel = new System.Windows.Forms.TextBox();
            this.tb_ownMake = new System.Windows.Forms.TextBox();
            this.lbl_oYear = new System.Windows.Forms.Label();
            this.lbl_oModel = new System.Windows.Forms.Label();
            this.lbl_oMake = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 183);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1674, 638);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBox);
            this.tabPage1.Controls.Add(this.textBox_year);
            this.tabPage1.Controls.Add(this.textBox_model);
            this.tabPage1.Controls.Add(this.textBox_make);
            this.tabPage1.Controls.Add(this.lbl_year);
            this.tabPage1.Controls.Add(this.lbl_Model);
            this.tabPage1.Controls.Add(this.lbl_make);
            this.tabPage1.Controls.Add(this.btn_addCar);
            this.tabPage1.Controls.Add(this.btn_sInv);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage1.Size = new System.Drawing.Size(1666, 600);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "On Lot";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 18;
            this.listBox.Location = new System.Drawing.Point(493, 25);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(1165, 562);
            this.listBox.TabIndex = 14;
            this.listBox.DoubleClick += new System.EventHandler(this.listBox_DoubleClick);
            // 
            // textBox_year
            // 
            this.textBox_year.Location = new System.Drawing.Point(165, 215);
            this.textBox_year.Name = "textBox_year";
            this.textBox_year.Size = new System.Drawing.Size(306, 30);
            this.textBox_year.TabIndex = 13;
            // 
            // textBox_model
            // 
            this.textBox_model.Location = new System.Drawing.Point(165, 133);
            this.textBox_model.Name = "textBox_model";
            this.textBox_model.Size = new System.Drawing.Size(306, 30);
            this.textBox_model.TabIndex = 12;
            // 
            // textBox_make
            // 
            this.textBox_make.Location = new System.Drawing.Point(165, 64);
            this.textBox_make.Name = "textBox_make";
            this.textBox_make.Size = new System.Drawing.Size(306, 30);
            this.textBox_make.TabIndex = 11;
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_year.Location = new System.Drawing.Point(36, 212);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(79, 32);
            this.lbl_year.TabIndex = 10;
            this.lbl_year.Text = "Year";
            // 
            // lbl_Model
            // 
            this.lbl_Model.AutoSize = true;
            this.lbl_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Model.Location = new System.Drawing.Point(36, 130);
            this.lbl_Model.Name = "lbl_Model";
            this.lbl_Model.Size = new System.Drawing.Size(98, 32);
            this.lbl_Model.TabIndex = 9;
            this.lbl_Model.Text = "Model";
            // 
            // lbl_make
            // 
            this.lbl_make.AutoSize = true;
            this.lbl_make.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_make.Location = new System.Drawing.Point(36, 61);
            this.lbl_make.Name = "lbl_make";
            this.lbl_make.Size = new System.Drawing.Size(88, 32);
            this.lbl_make.TabIndex = 8;
            this.lbl_make.Text = "Make";
            // 
            // btn_addCar
            // 
            this.btn_addCar.Location = new System.Drawing.Point(279, 309);
            this.btn_addCar.Name = "btn_addCar";
            this.btn_addCar.Size = new System.Drawing.Size(192, 57);
            this.btn_addCar.TabIndex = 7;
            this.btn_addCar.Text = "Add Car";
            this.btn_addCar.UseVisualStyleBackColor = true;
            this.btn_addCar.Click += new System.EventHandler(this.btn_addCar_Click);
            // 
            // btn_sInv
            // 
            this.btn_sInv.Location = new System.Drawing.Point(17, 309);
            this.btn_sInv.Name = "btn_sInv";
            this.btn_sInv.Size = new System.Drawing.Size(192, 57);
            this.btn_sInv.TabIndex = 6;
            this.btn_sInv.Text = "Search Inventory";
            this.btn_sInv.UseVisualStyleBackColor = true;
            this.btn_sInv.Click += new System.EventHandler(this.btn_sInv_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBox_Owned);
            this.tabPage2.Controls.Add(this.btn_ownedSearch);
            this.tabPage2.Controls.Add(this.tb_ownYear);
            this.tabPage2.Controls.Add(this.tb_ownModel);
            this.tabPage2.Controls.Add(this.tb_ownMake);
            this.tabPage2.Controls.Add(this.lbl_oYear);
            this.tabPage2.Controls.Add(this.lbl_oModel);
            this.tabPage2.Controls.Add(this.lbl_oMake);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage2.Size = new System.Drawing.Size(1666, 600);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Owned";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // listBox_Owned
            // 
            this.listBox_Owned.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Owned.FormattingEnabled = true;
            this.listBox_Owned.ItemHeight = 18;
            this.listBox_Owned.Location = new System.Drawing.Point(502, 8);
            this.listBox_Owned.Name = "listBox_Owned";
            this.listBox_Owned.Size = new System.Drawing.Size(1144, 580);
            this.listBox_Owned.TabIndex = 16;
            // 
            // btn_ownedSearch
            // 
            this.btn_ownedSearch.Location = new System.Drawing.Point(172, 295);
            this.btn_ownedSearch.Name = "btn_ownedSearch";
            this.btn_ownedSearch.Size = new System.Drawing.Size(192, 57);
            this.btn_ownedSearch.TabIndex = 15;
            this.btn_ownedSearch.Text = "Search Inventory";
            this.btn_ownedSearch.UseVisualStyleBackColor = true;
            this.btn_ownedSearch.Click += new System.EventHandler(this.btn_ownedSearch_Click);
            // 
            // tb_ownYear
            // 
            this.tb_ownYear.Location = new System.Drawing.Point(172, 214);
            this.tb_ownYear.Name = "tb_ownYear";
            this.tb_ownYear.Size = new System.Drawing.Size(306, 30);
            this.tb_ownYear.TabIndex = 14;
            // 
            // tb_ownModel
            // 
            this.tb_ownModel.Location = new System.Drawing.Point(172, 148);
            this.tb_ownModel.Name = "tb_ownModel";
            this.tb_ownModel.Size = new System.Drawing.Size(306, 30);
            this.tb_ownModel.TabIndex = 13;
            // 
            // tb_ownMake
            // 
            this.tb_ownMake.Location = new System.Drawing.Point(172, 74);
            this.tb_ownMake.Name = "tb_ownMake";
            this.tb_ownMake.Size = new System.Drawing.Size(306, 30);
            this.tb_ownMake.TabIndex = 12;
            // 
            // lbl_oYear
            // 
            this.lbl_oYear.AutoSize = true;
            this.lbl_oYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_oYear.Location = new System.Drawing.Point(31, 211);
            this.lbl_oYear.Name = "lbl_oYear";
            this.lbl_oYear.Size = new System.Drawing.Size(79, 32);
            this.lbl_oYear.TabIndex = 11;
            this.lbl_oYear.Text = "Year";
            // 
            // lbl_oModel
            // 
            this.lbl_oModel.AutoSize = true;
            this.lbl_oModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_oModel.Location = new System.Drawing.Point(31, 145);
            this.lbl_oModel.Name = "lbl_oModel";
            this.lbl_oModel.Size = new System.Drawing.Size(98, 32);
            this.lbl_oModel.TabIndex = 10;
            this.lbl_oModel.Text = "Model";
            // 
            // lbl_oMake
            // 
            this.lbl_oMake.AutoSize = true;
            this.lbl_oMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_oMake.Location = new System.Drawing.Point(31, 71);
            this.lbl_oMake.Name = "lbl_oMake";
            this.lbl_oMake.Size = new System.Drawing.Size(88, 32);
            this.lbl_oMake.TabIndex = 9;
            this.lbl_oMake.Text = "Make";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TVTS.Properties.Resources.toyota;
            this.pictureBox1.Location = new System.Drawing.Point(712, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(681, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Toyota Vehicle Tracking System";
            // 
            // TVTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1674, 819);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TVTS";
            this.Text = "TVTS";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_make;
        private System.Windows.Forms.Button btn_addCar;
        private System.Windows.Forms.Button btn_sInv;
        private System.Windows.Forms.Label lbl_Model;
        private System.Windows.Forms.TextBox textBox_year;
        private System.Windows.Forms.TextBox textBox_model;
        private System.Windows.Forms.TextBox textBox_make;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ListBox listBox_Owned;
        private System.Windows.Forms.Button btn_ownedSearch;
        private System.Windows.Forms.TextBox tb_ownYear;
        private System.Windows.Forms.TextBox tb_ownModel;
        private System.Windows.Forms.TextBox tb_ownMake;
        private System.Windows.Forms.Label lbl_oYear;
        private System.Windows.Forms.Label lbl_oModel;
        private System.Windows.Forms.Label lbl_oMake;
    }
}

