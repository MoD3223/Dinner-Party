
namespace Dinner_Party
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
            this.guestNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxFantasy = new System.Windows.Forms.CheckBox();
            this.checkBoxHealthy = new System.Windows.Forms.CheckBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelFinalAmount = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.numberBirthday = new System.Windows.Forms.NumericUpDown();
            this.fancyBirthday = new System.Windows.Forms.CheckBox();
            this.birthdayCost = new System.Windows.Forms.Label();
            this.LabelBirthdayCost = new System.Windows.Forms.Label();
            this.cakeWriting = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tooLongLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guestNumeric)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // guestNumeric
            // 
            this.guestNumeric.Location = new System.Drawing.Point(9, 19);
            this.guestNumeric.Name = "guestNumeric";
            this.guestNumeric.Size = new System.Drawing.Size(68, 20);
            this.guestNumeric.TabIndex = 0;
            this.guestNumeric.ValueChanged += new System.EventHandler(this.guestNumeric_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ilość osób";
            // 
            // checkBoxFantasy
            // 
            this.checkBoxFantasy.AutoSize = true;
            this.checkBoxFantasy.Location = new System.Drawing.Point(9, 45);
            this.checkBoxFantasy.Name = "checkBoxFantasy";
            this.checkBoxFantasy.Size = new System.Drawing.Size(129, 17);
            this.checkBoxFantasy.TabIndex = 2;
            this.checkBoxFantasy.Text = "Dekoracje Fantazyjne";
            this.checkBoxFantasy.UseVisualStyleBackColor = true;
            this.checkBoxFantasy.CheckedChanged += new System.EventHandler(this.checkBoxFantasy_CheckedChanged);
            // 
            // checkBoxHealthy
            // 
            this.checkBoxHealthy.AutoSize = true;
            this.checkBoxHealthy.Location = new System.Drawing.Point(9, 68);
            this.checkBoxHealthy.Name = "checkBoxHealthy";
            this.checkBoxHealthy.Size = new System.Drawing.Size(91, 17);
            this.checkBoxHealthy.TabIndex = 3;
            this.checkBoxHealthy.Text = "Opcja zdrowa";
            this.checkBoxHealthy.UseVisualStyleBackColor = true;
            this.checkBoxHealthy.CheckedChanged += new System.EventHandler(this.checkBoxHealthy_CheckedChanged);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(6, 90);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(38, 13);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "Koszt";
            // 
            // labelFinalAmount
            // 
            this.labelFinalAmount.AutoSize = true;
            this.labelFinalAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFinalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinalAmount.Location = new System.Drawing.Point(50, 90);
            this.labelFinalAmount.Name = "labelFinalAmount";
            this.labelFinalAmount.Size = new System.Drawing.Size(31, 15);
            this.labelFinalAmount.TabIndex = 5;
            this.labelFinalAmount.Text = "0 zł";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(244, 157);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.labelFinalAmount);
            this.tabPage1.Controls.Add(this.guestNumeric);
            this.tabPage1.Controls.Add(this.labelPrice);
            this.tabPage1.Controls.Add(this.checkBoxFantasy);
            this.tabPage1.Controls.Add(this.checkBoxHealthy);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(236, 131);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Impreza okolicznościowa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tooLongLabel);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cakeWriting);
            this.tabPage2.Controls.Add(this.LabelBirthdayCost);
            this.tabPage2.Controls.Add(this.birthdayCost);
            this.tabPage2.Controls.Add(this.fancyBirthday);
            this.tabPage2.Controls.Add(this.numberBirthday);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(236, 131);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Przyjęcie urodzinowe";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ilość osób";
            // 
            // numberBirthday
            // 
            this.numberBirthday.Location = new System.Drawing.Point(9, 19);
            this.numberBirthday.Name = "numberBirthday";
            this.numberBirthday.Size = new System.Drawing.Size(68, 20);
            this.numberBirthday.TabIndex = 3;
            this.numberBirthday.ValueChanged += new System.EventHandler(this.numberBirthday_ValueChanged);
            // 
            // fancyBirthday
            // 
            this.fancyBirthday.AutoSize = true;
            this.fancyBirthday.Location = new System.Drawing.Point(9, 45);
            this.fancyBirthday.Name = "fancyBirthday";
            this.fancyBirthday.Size = new System.Drawing.Size(129, 17);
            this.fancyBirthday.TabIndex = 4;
            this.fancyBirthday.Text = "Dekoracje Fantazyjne";
            this.fancyBirthday.UseVisualStyleBackColor = true;
            this.fancyBirthday.CheckedChanged += new System.EventHandler(this.fancyBirthday_CheckedChanged);
            // 
            // birthdayCost
            // 
            this.birthdayCost.AutoSize = true;
            this.birthdayCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayCost.Location = new System.Drawing.Point(6, 112);
            this.birthdayCost.Name = "birthdayCost";
            this.birthdayCost.Size = new System.Drawing.Size(38, 13);
            this.birthdayCost.TabIndex = 6;
            this.birthdayCost.Text = "Koszt";
            // 
            // LabelBirthdayCost
            // 
            this.LabelBirthdayCost.AutoSize = true;
            this.LabelBirthdayCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelBirthdayCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBirthdayCost.Location = new System.Drawing.Point(50, 112);
            this.LabelBirthdayCost.Name = "LabelBirthdayCost";
            this.LabelBirthdayCost.Size = new System.Drawing.Size(31, 15);
            this.LabelBirthdayCost.TabIndex = 7;
            this.LabelBirthdayCost.Text = "0 zł";
            // 
            // cakeWriting
            // 
            this.cakeWriting.Location = new System.Drawing.Point(6, 81);
            this.cakeWriting.Name = "cakeWriting";
            this.cakeWriting.Size = new System.Drawing.Size(100, 20);
            this.cakeWriting.TabIndex = 8;
            this.cakeWriting.Text = "Sto lat!";
            this.cakeWriting.TextChanged += new System.EventHandler(this.cakeWriting_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Napis na torcie:";
            // 
            // tooLongLabel
            // 
            this.tooLongLabel.AutoSize = true;
            this.tooLongLabel.BackColor = System.Drawing.Color.Red;
            this.tooLongLabel.Location = new System.Drawing.Point(96, 65);
            this.tooLongLabel.Name = "tooLongLabel";
            this.tooLongLabel.Size = new System.Drawing.Size(75, 13);
            this.tooLongLabel.TabIndex = 10;
            this.tooLongLabel.Text = "ZBYT DŁUGI!";
            this.tooLongLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 156);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Planista Przyjęć";
            ((System.ComponentModel.ISupportInitialize)(this.guestNumeric)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown guestNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxFantasy;
        private System.Windows.Forms.CheckBox checkBoxHealthy;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelFinalAmount;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label tooLongLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cakeWriting;
        private System.Windows.Forms.Label LabelBirthdayCost;
        private System.Windows.Forms.Label birthdayCost;
        private System.Windows.Forms.CheckBox fancyBirthday;
        private System.Windows.Forms.NumericUpDown numberBirthday;
        private System.Windows.Forms.Label label2;
    }
}

