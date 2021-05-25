
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
            ((System.ComponentModel.ISupportInitialize)(this.guestNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // guestNumeric
            // 
            this.guestNumeric.Location = new System.Drawing.Point(15, 25);
            this.guestNumeric.Name = "guestNumeric";
            this.guestNumeric.Size = new System.Drawing.Size(68, 20);
            this.guestNumeric.TabIndex = 0;
            this.guestNumeric.ValueChanged += new System.EventHandler(this.guestNumeric_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ilość osób";
            // 
            // checkBoxFantasy
            // 
            this.checkBoxFantasy.AutoSize = true;
            this.checkBoxFantasy.Location = new System.Drawing.Point(15, 51);
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
            this.checkBoxHealthy.Location = new System.Drawing.Point(15, 74);
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
            this.labelPrice.Location = new System.Drawing.Point(12, 94);
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
            this.labelFinalAmount.Location = new System.Drawing.Point(56, 94);
            this.labelFinalAmount.Name = "labelFinalAmount";
            this.labelFinalAmount.Size = new System.Drawing.Size(43, 15);
            this.labelFinalAmount.TabIndex = 5;
            this.labelFinalAmount.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(159, 111);
            this.Controls.Add(this.labelFinalAmount);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.checkBoxHealthy);
            this.Controls.Add(this.checkBoxFantasy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guestNumeric);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Planista Przyjęć";
            ((System.ComponentModel.ISupportInitialize)(this.guestNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown guestNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxFantasy;
        private System.Windows.Forms.CheckBox checkBoxHealthy;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelFinalAmount;
    }
}

