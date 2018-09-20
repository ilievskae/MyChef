namespace MyChef
{
    partial class AddRecepie
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
            this.label1 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timeForPreparing = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.totalPersons = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.saveRecepie = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.tasteBox = new System.Windows.Forms.ComboBox();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.timeForPreparing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име на рецептот:";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(167, 14);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(297, 20);
            this.Name.TabIndex = 1;
            this.Name.Validating += new System.ComponentModel.CancelEventHandler(this.Name_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Начин на подготовка:";
            // 
            // contextBox
            // 
            this.contextBox.Location = new System.Drawing.Point(167, 55);
            this.contextBox.Name = "contextBox";
            this.contextBox.Size = new System.Drawing.Size(297, 143);
            this.contextBox.TabIndex = 3;
            this.contextBox.Text = "";
            this.contextBox.Validating += new System.ComponentModel.CancelEventHandler(this.contextBox_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Време на подготовка:";
            // 
            // timeForPreparing
            // 
            this.timeForPreparing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeForPreparing.Location = new System.Drawing.Point(167, 215);
            this.timeForPreparing.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.timeForPreparing.Name = "timeForPreparing";
            this.timeForPreparing.Size = new System.Drawing.Size(69, 20);
            this.timeForPreparing.TabIndex = 5;
            this.timeForPreparing.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.timeForPreparing.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(242, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "минути";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Категорија:";
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Items.AddRange(new object[] {
            "Лесно",
            "Средно",
            "Тешко"});
            this.categoryBox.Location = new System.Drawing.Point(167, 254);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(69, 21);
            this.categoryBox.TabIndex = 8;
       
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(17, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "За";
            // 
            // totalPersons
            // 
            this.totalPersons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalPersons.Location = new System.Drawing.Point(51, 330);
            this.totalPersons.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.totalPersons.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.totalPersons.Name = "totalPersons";
            this.totalPersons.Size = new System.Drawing.Size(51, 20);
            this.totalPersons.TabIndex = 10;
            this.totalPersons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalPersons.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.totalPersons.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(112, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "лице/лица";
            // 
            // saveRecepie
            // 
            this.saveRecepie.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.saveRecepie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveRecepie.Location = new System.Drawing.Point(280, 359);
            this.saveRecepie.Name = "saveRecepie";
            this.saveRecepie.Size = new System.Drawing.Size(83, 43);
            this.saveRecepie.TabIndex = 13;
            this.saveRecepie.Text = "Зачувај рецепт";
            this.saveRecepie.UseVisualStyleBackColor = false;
            this.saveRecepie.Click += new System.EventHandler(this.saveRecepie_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancel.Location = new System.Drawing.Point(381, 359);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(83, 43);
            this.cancel.TabIndex = 14;
            this.cancel.Text = "Откажи";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Според вкус:";
            // 
            // tasteBox
            // 
            this.tasteBox.FormattingEnabled = true;
            this.tasteBox.Items.AddRange(new object[] {
            "Предјадењa",
            "Главни јадења",
            "Десерти",
            "Коктели"});
            this.tasteBox.Location = new System.Drawing.Point(167, 295);
            this.tasteBox.Name = "tasteBox";
            this.tasteBox.Size = new System.Drawing.Size(69, 21);
            this.tasteBox.TabIndex = 16;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // AddRecepie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 409);
            this.Controls.Add(this.tasteBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.saveRecepie);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.totalPersons);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timeForPreparing);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.contextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label1);
         
            this.Text = "Додади рецепт";
            this.Load += new System.EventHandler(this.AddRecepie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timeForPreparing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox contextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown timeForPreparing;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown totalPersons;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button saveRecepie;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox tasteBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}