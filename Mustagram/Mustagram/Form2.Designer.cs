﻿namespace Mustagram
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameBox = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.passwordbox = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mustagram.Properties.Resources.KakaoTalk_20200424_143113477;
            this.pictureBox1.Location = new System.Drawing.Point(138, 67);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.nameBox.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.nameBox.BorderColor = System.Drawing.Color.LightGray;
            this.nameBox.CornerRadius = 15;
            this.nameBox.FillColor = System.Drawing.Color.LightGray;
            this.nameBox.Location = new System.Drawing.Point(26, 294);
            this.nameBox.Name = "nameBox";
            this.nameBox.SelectionColor = System.Drawing.Color.White;
            this.nameBox.Size = new System.Drawing.Size(432, 53);
            this.nameBox.Click += new System.EventHandler(this.Idbox_Click);
            this.nameBox.Enter += new System.EventHandler(this.Idbox_Enter);
            this.nameBox.Leave += new System.EventHandler(this.Idbox_Leave);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.rectangleShape1,
            this.passwordbox,
            this.nameBox});
            this.shapeContainer1.Size = new System.Drawing.Size(491, 691);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // passwordbox
            // 
            this.passwordbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.passwordbox.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.passwordbox.BorderColor = System.Drawing.Color.LightGray;
            this.passwordbox.CornerRadius = 15;
            this.passwordbox.FillColor = System.Drawing.Color.LightGray;
            this.passwordbox.Location = new System.Drawing.Point(26, 370);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.SelectionColor = System.Drawing.Color.White;
            this.passwordbox.Size = new System.Drawing.Size(432, 53);
            this.passwordbox.Enter += new System.EventHandler(this.passwordbox_Enter);
            this.passwordbox.Leave += new System.EventHandler(this.passwordbox_Leave);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.BorderColor = System.Drawing.Color.LightGray;
            this.rectangleShape1.CornerRadius = 15;
            this.rectangleShape1.FillColor = System.Drawing.Color.LightGray;
            this.rectangleShape1.Location = new System.Drawing.Point(24, 447);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.SelectionColor = System.Drawing.Color.White;
            this.rectangleShape1.Size = new System.Drawing.Size(432, 53);
            this.rectangleShape1.Click += new System.EventHandler(this.Idbox_Click);
            this.rectangleShape1.Enter += new System.EventHandler(this.Idbox_Enter);
            this.rectangleShape1.Leave += new System.EventHandler(this.Idbox_Leave);
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 0;
            this.lineShape1.X2 = 491;
            this.lineShape1.Y1 = 641;
            this.lineShape1.Y2 = 641;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Underline);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(179)))), ((int)(((byte)(244)))));
            this.label7.Location = new System.Drawing.Point(278, 665);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "로그인";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(135, 665);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "이미 계정이 있으신가요?";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.txtId.ForeColor = System.Drawing.Color.Gray;
            this.txtId.HideSelection = false;
            this.txtId.Location = new System.Drawing.Point(48, 311);
            this.txtId.Name = "txtId";
            this.txtId.ShortcutsEnabled = false;
            this.txtId.Size = new System.Drawing.Size(387, 21);
            this.txtId.TabIndex = 23;
            this.txtId.Text = "이름";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(48, 387);
            this.textBox1.Name = "textBox1";
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(387, 21);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "아이디";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.textBox2.ForeColor = System.Drawing.Color.Gray;
            this.textBox2.HideSelection = false;
            this.textBox2.Location = new System.Drawing.Point(48, 461);
            this.textBox2.Name = "textBox2";
            this.textBox2.ShortcutsEnabled = false;
            this.textBox2.Size = new System.Drawing.Size(387, 21);
            this.textBox2.TabIndex = 25;
            this.textBox2.Text = "비밀번호";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(491, 691);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape nameBox;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape passwordbox;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}