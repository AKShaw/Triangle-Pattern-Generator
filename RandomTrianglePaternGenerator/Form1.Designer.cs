namespace RandomTrianglePaternGenerator
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
            this.trianglePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mainColorDialog = new System.Windows.Forms.ColorDialog();
            this.mainColorBtn = new System.Windows.Forms.Button();
            this.mainColorPicBox = new System.Windows.Forms.PictureBox();
            this.secondColorBtn = new System.Windows.Forms.Button();
            this.thirdColorBtn = new System.Windows.Forms.Button();
            this.fourthColorBtn = new System.Windows.Forms.Button();
            this.fifthColorBtn = new System.Windows.Forms.Button();
            this.secondColorPicBox = new System.Windows.Forms.PictureBox();
            this.thirdColorPicBox = new System.Windows.Forms.PictureBox();
            this.fourthColorPicBox = new System.Windows.Forms.PictureBox();
            this.fifthColorPicBox = new System.Windows.Forms.PictureBox();
            this.secondColorDialog = new System.Windows.Forms.ColorDialog();
            this.thirdColorDialog = new System.Windows.Forms.ColorDialog();
            this.fourthColorDialog = new System.Windows.Forms.ColorDialog();
            this.fifthColorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.mainColorPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondColorPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdColorPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthColorPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fifthColorPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // trianglePanel
            // 
            this.trianglePanel.BackColor = System.Drawing.Color.Black;
            this.trianglePanel.Location = new System.Drawing.Point(0, 0);
            this.trianglePanel.Name = "trianglePanel";
            this.trianglePanel.Size = new System.Drawing.Size(1300, 700);
            this.trianglePanel.TabIndex = 0;
            this.trianglePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 719);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Color Selector:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 703);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Main Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 703);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Second Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 703);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Third Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 703);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fourth Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(595, 703);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fifth Color";
            // 
            // mainColorDialog
            // 
            this.mainColorDialog.AnyColor = true;
            this.mainColorDialog.FullOpen = true;
            // 
            // mainColorBtn
            // 
            this.mainColorBtn.Location = new System.Drawing.Point(124, 719);
            this.mainColorBtn.Name = "mainColorBtn";
            this.mainColorBtn.Size = new System.Drawing.Size(102, 23);
            this.mainColorBtn.TabIndex = 13;
            this.mainColorBtn.Text = "Select main color";
            this.mainColorBtn.UseVisualStyleBackColor = true;
            this.mainColorBtn.Click += new System.EventHandler(this.mainColorBtn_Click);
            // 
            // mainColorPicBox
            // 
            this.mainColorPicBox.Location = new System.Drawing.Point(124, 748);
            this.mainColorPicBox.Name = "mainColorPicBox";
            this.mainColorPicBox.Size = new System.Drawing.Size(102, 16);
            this.mainColorPicBox.TabIndex = 14;
            this.mainColorPicBox.TabStop = false;
            // 
            // secondColorBtn
            // 
            this.secondColorBtn.Location = new System.Drawing.Point(232, 719);
            this.secondColorBtn.Name = "secondColorBtn";
            this.secondColorBtn.Size = new System.Drawing.Size(117, 23);
            this.secondColorBtn.TabIndex = 15;
            this.secondColorBtn.Text = "Select second color";
            this.secondColorBtn.UseVisualStyleBackColor = true;
            this.secondColorBtn.Click += new System.EventHandler(this.secondColorBtn_Click);
            // 
            // thirdColorBtn
            // 
            this.thirdColorBtn.Location = new System.Drawing.Point(355, 719);
            this.thirdColorBtn.Name = "thirdColorBtn";
            this.thirdColorBtn.Size = new System.Drawing.Size(102, 23);
            this.thirdColorBtn.TabIndex = 16;
            this.thirdColorBtn.Text = "Select third color";
            this.thirdColorBtn.UseVisualStyleBackColor = true;
            this.thirdColorBtn.Click += new System.EventHandler(this.thirdColorBtn_Click);
            // 
            // fourthColorBtn
            // 
            this.fourthColorBtn.Location = new System.Drawing.Point(463, 719);
            this.fourthColorBtn.Name = "fourthColorBtn";
            this.fourthColorBtn.Size = new System.Drawing.Size(102, 23);
            this.fourthColorBtn.TabIndex = 17;
            this.fourthColorBtn.Text = "Select fourth color";
            this.fourthColorBtn.UseVisualStyleBackColor = true;
            this.fourthColorBtn.Click += new System.EventHandler(this.fourthColorBtn_Click);
            // 
            // fifthColorBtn
            // 
            this.fifthColorBtn.Location = new System.Drawing.Point(571, 719);
            this.fifthColorBtn.Name = "fifthColorBtn";
            this.fifthColorBtn.Size = new System.Drawing.Size(102, 23);
            this.fifthColorBtn.TabIndex = 18;
            this.fifthColorBtn.Text = "Select fifth color";
            this.fifthColorBtn.UseVisualStyleBackColor = true;
            this.fifthColorBtn.Click += new System.EventHandler(this.fifthColorBtn_Click);
            // 
            // secondColorPicBox
            // 
            this.secondColorPicBox.Location = new System.Drawing.Point(232, 748);
            this.secondColorPicBox.Name = "secondColorPicBox";
            this.secondColorPicBox.Size = new System.Drawing.Size(117, 16);
            this.secondColorPicBox.TabIndex = 19;
            this.secondColorPicBox.TabStop = false;
            // 
            // thirdColorPicBox
            // 
            this.thirdColorPicBox.Location = new System.Drawing.Point(355, 748);
            this.thirdColorPicBox.Name = "thirdColorPicBox";
            this.thirdColorPicBox.Size = new System.Drawing.Size(102, 16);
            this.thirdColorPicBox.TabIndex = 20;
            this.thirdColorPicBox.TabStop = false;
            // 
            // fourthColorPicBox
            // 
            this.fourthColorPicBox.Location = new System.Drawing.Point(463, 748);
            this.fourthColorPicBox.Name = "fourthColorPicBox";
            this.fourthColorPicBox.Size = new System.Drawing.Size(102, 16);
            this.fourthColorPicBox.TabIndex = 21;
            this.fourthColorPicBox.TabStop = false;
            // 
            // fifthColorPicBox
            // 
            this.fifthColorPicBox.Location = new System.Drawing.Point(571, 748);
            this.fifthColorPicBox.Name = "fifthColorPicBox";
            this.fifthColorPicBox.Size = new System.Drawing.Size(102, 16);
            this.fifthColorPicBox.TabIndex = 22;
            this.fifthColorPicBox.TabStop = false;
            // 
            // secondColorDialog
            // 
            this.secondColorDialog.AnyColor = true;
            this.secondColorDialog.FullOpen = true;
            // 
            // thirdColorDialog
            // 
            this.thirdColorDialog.AnyColor = true;
            this.thirdColorDialog.FullOpen = true;
            // 
            // fourthColorDialog
            // 
            this.fourthColorDialog.AnyColor = true;
            this.fourthColorDialog.FullOpen = true;
            // 
            // fifthColorDialog
            // 
            this.fifthColorDialog.AnyColor = true;
            this.fifthColorDialog.FullOpen = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 768);
            this.Controls.Add(this.fifthColorPicBox);
            this.Controls.Add(this.fourthColorPicBox);
            this.Controls.Add(this.thirdColorPicBox);
            this.Controls.Add(this.secondColorPicBox);
            this.Controls.Add(this.fifthColorBtn);
            this.Controls.Add(this.fourthColorBtn);
            this.Controls.Add(this.thirdColorBtn);
            this.Controls.Add(this.secondColorBtn);
            this.Controls.Add(this.mainColorPicBox);
            this.Controls.Add(this.mainColorBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trianglePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Right Angle Triangle Patern Generator";
            ((System.ComponentModel.ISupportInitialize)(this.mainColorPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondColorPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdColorPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthColorPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fifthColorPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel trianglePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColorDialog mainColorDialog;
        private System.Windows.Forms.Button mainColorBtn;
        private System.Windows.Forms.PictureBox mainColorPicBox;
        private System.Windows.Forms.Button secondColorBtn;
        private System.Windows.Forms.Button thirdColorBtn;
        private System.Windows.Forms.Button fourthColorBtn;
        private System.Windows.Forms.Button fifthColorBtn;
        private System.Windows.Forms.PictureBox secondColorPicBox;
        private System.Windows.Forms.PictureBox thirdColorPicBox;
        private System.Windows.Forms.PictureBox fourthColorPicBox;
        private System.Windows.Forms.PictureBox fifthColorPicBox;
        private System.Windows.Forms.ColorDialog secondColorDialog;
        private System.Windows.Forms.ColorDialog thirdColorDialog;
        private System.Windows.Forms.ColorDialog fourthColorDialog;
        private System.Windows.Forms.ColorDialog fifthColorDialog;
    }
}

