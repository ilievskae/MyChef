namespace MyChef
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listRecepies = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbTimeForPreparing = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbTotalPersons = new System.Windows.Forms.Label();
            this.textBoxContent = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clbTaste = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbTaste = new System.Windows.Forms.Label();
            this.listTastes = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "cbcvb";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Листа на веќе постоечки рецепти:";
            // 
            // listRecepies
            // 
            this.listRecepies.FormattingEnabled = true;
            this.listRecepies.Location = new System.Drawing.Point(16, 43);
            this.listRecepies.Name = "listRecepies";
            this.listRecepies.Size = new System.Drawing.Size(296, 225);
            this.listRecepies.TabIndex = 3;
            this.listRecepies.SelectedIndexChanged += new System.EventHandler(this.listRecepies_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(16, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Додади рецепт";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Enabled = false;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(115, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "Избриши рецепт";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbName.Location = new System.Drawing.Point(355, 43);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(83, 23);
            this.lbName.TabIndex = 7;
            this.lbName.Text = "cgbcvbcbcv";
            this.lbName.Visible = false;
            // 
            // lbTimeForPreparing
            // 
            this.lbTimeForPreparing.AutoSize = true;
            this.lbTimeForPreparing.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeForPreparing.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbTimeForPreparing.Location = new System.Drawing.Point(523, 285);
            this.lbTimeForPreparing.Name = "lbTimeForPreparing";
            this.lbTimeForPreparing.Size = new System.Drawing.Size(28, 23);
            this.lbTimeForPreparing.TabIndex = 9;
            this.lbTimeForPreparing.Text = "30";
            this.lbTimeForPreparing.Visible = false;
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbCategory.Location = new System.Drawing.Point(456, 318);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(42, 23);
            this.lbCategory.TabIndex = 10;
            this.lbCategory.Text = "lesno";
            this.lbCategory.Visible = false;
            // 
            // lbTotalPersons
            // 
            this.lbTotalPersons.AutoSize = true;
            this.lbTotalPersons.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPersons.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbTotalPersons.Location = new System.Drawing.Point(380, 383);
            this.lbTotalPersons.Name = "lbTotalPersons";
            this.lbTotalPersons.Size = new System.Drawing.Size(19, 23);
            this.lbTotalPersons.TabIndex = 11;
            this.lbTotalPersons.Text = "4";
            this.lbTotalPersons.Visible = false;
            // 
            // textBoxContent
            // 
            this.textBoxContent.Location = new System.Drawing.Point(359, 68);
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.Size = new System.Drawing.Size(284, 200);
            this.textBoxContent.TabIndex = 12;
            this.textBoxContent.Text = "";
            this.textBoxContent.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(355, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Време на подготовка:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(557, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "минути";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(355, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Категорија:";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(357, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "За";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(405, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "лице/лица";
            this.label8.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clbTaste);
            this.groupBox1.Location = new System.Drawing.Point(16, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 91);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Според вкус";
            // 
            // clbTaste
            // 
            this.clbTaste.FormattingEnabled = true;
            this.clbTaste.Items.AddRange(new object[] {
            "Предјадења",
            "Главни јадења",
            "Десерти",
            "Коктели"});
            this.clbTaste.Location = new System.Drawing.Point(6, 20);
            this.clbTaste.Name = "clbTaste";
            this.clbTaste.Size = new System.Drawing.Size(100, 64);
            this.clbTaste.TabIndex = 0;
            this.clbTaste.SelectedValueChanged += new System.EventHandler(this.clbTaste_SelectedValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(355, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Селектиран рецепт:";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(355, 349);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 23);
            this.label10.TabIndex = 20;
            this.label10.Text = "Според вкус:";
            this.label10.Visible = false;
            // 
            // lbTaste
            // 
            this.lbTaste.AutoSize = true;
            this.lbTaste.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaste.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbTaste.Location = new System.Drawing.Point(456, 349);
            this.lbTaste.Name = "lbTaste";
            this.lbTaste.Size = new System.Drawing.Size(42, 23);
            this.lbTaste.TabIndex = 21;
            this.lbTaste.Text = "lesno";
            this.lbTaste.Visible = false;
            // 
            // listTastes
            // 
            this.listTastes.FormattingEnabled = true;
            this.listTastes.Location = new System.Drawing.Point(134, 294);
            this.listTastes.Name = "listTastes";
            this.listTastes.Size = new System.Drawing.Size(189, 82);
            this.listTastes.TabIndex = 22;
            this.listTastes.SelectedIndexChanged += new System.EventHandler(this.listTastes_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 447);
            this.Controls.Add(this.listTastes);
            this.Controls.Add(this.lbTaste);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxContent);
            this.Controls.Add(this.lbTotalPersons);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbTimeForPreparing);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listRecepies);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Мој готвач";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listRecepies;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbTimeForPreparing;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbTotalPersons;
        private System.Windows.Forms.RichTextBox textBoxContent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox clbTaste;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbTaste;
        private System.Windows.Forms.ListBox listTastes;
    }
}

