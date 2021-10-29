
namespace MovieProjectFinal
{
    partial class Form3
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
            this.label4 = new System.Windows.Forms.Label();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.directorTxt = new System.Windows.Forms.TextBox();
            this.yearTxt = new System.Windows.Forms.TextBox();
            this.ratingTxt = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.nmbrText = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Director:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rating:";
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(188, 78);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(155, 20);
            this.titleTxt.TabIndex = 4;
            // 
            // directorTxt
            // 
            this.directorTxt.Location = new System.Drawing.Point(188, 111);
            this.directorTxt.Name = "directorTxt";
            this.directorTxt.Size = new System.Drawing.Size(155, 20);
            this.directorTxt.TabIndex = 5;
            // 
            // yearTxt
            // 
            this.yearTxt.Location = new System.Drawing.Point(188, 137);
            this.yearTxt.Name = "yearTxt";
            this.yearTxt.Size = new System.Drawing.Size(155, 20);
            this.yearTxt.TabIndex = 6;
            // 
            // ratingTxt
            // 
            this.ratingTxt.Location = new System.Drawing.Point(188, 163);
            this.ratingTxt.Name = "ratingTxt";
            this.ratingTxt.Size = new System.Drawing.Size(155, 20);
            this.ratingTxt.TabIndex = 7;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(175, 189);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(178, 32);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "Add to Database";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // nmbrText
            // 
            this.nmbrText.AutoSize = true;
            this.nmbrText.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmbrText.Location = new System.Drawing.Point(33, 48);
            this.nmbrText.Name = "nmbrText";
            this.nmbrText.Size = new System.Drawing.Size(149, 19);
            this.nmbrText.TabIndex = 9;
            this.nmbrText.Text = "Number of Movies:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 10;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nmbrText);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.ratingTxt);
            this.Controls.Add(this.yearTxt);
            this.Controls.Add(this.directorTxt);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Add to Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.TextBox directorTxt;
        private System.Windows.Forms.TextBox yearTxt;
        private System.Windows.Forms.TextBox ratingTxt;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label nmbrText;
        private System.Windows.Forms.TextBox textBox1;
    }
}