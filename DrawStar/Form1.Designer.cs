﻿namespace DrawStar
{
    partial class drawStar
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
            this.drawButton = new System.Windows.Forms.Button();
            this.whatLabel = new System.Windows.Forms.Label();
            this.xInput = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.yInput = new System.Windows.Forms.TextBox();
            this.sizeInput = new System.Windows.Forms.TextBox();
            this.redRadio = new System.Windows.Forms.RadioButton();
            this.blueRadio = new System.Windows.Forms.RadioButton();
            this.greenRadio = new System.Windows.Forms.RadioButton();
            this.otherLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(12, 12);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(75, 23);
            this.drawButton.TabIndex = 0;
            this.drawButton.Text = "Draw Star";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // whatLabel
            // 
            this.whatLabel.Location = new System.Drawing.Point(93, 12);
            this.whatLabel.Name = "whatLabel";
            this.whatLabel.Size = new System.Drawing.Size(160, 28);
            this.whatLabel.TabIndex = 1;
            this.whatLabel.Text = "Input your values and press draw Star to draw the star";
            // 
            // xInput
            // 
            this.xInput.Location = new System.Drawing.Point(43, 41);
            this.xInput.Name = "xInput";
            this.xInput.Size = new System.Drawing.Size(25, 20);
            this.xInput.TabIndex = 2;
            this.xInput.Text = "0";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(20, 44);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(17, 13);
            this.xLabel.TabIndex = 3;
            this.xLabel.Text = "X:";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(20, 73);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(17, 13);
            this.yLabel.TabIndex = 4;
            this.yLabel.Text = "Y:";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(12, 99);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(30, 13);
            this.sizeLabel.TabIndex = 5;
            this.sizeLabel.Text = "Size:";
            // 
            // yInput
            // 
            this.yInput.Location = new System.Drawing.Point(43, 70);
            this.yInput.Name = "yInput";
            this.yInput.Size = new System.Drawing.Size(25, 20);
            this.yInput.TabIndex = 6;
            this.yInput.Text = "0";
            // 
            // sizeInput
            // 
            this.sizeInput.Location = new System.Drawing.Point(43, 96);
            this.sizeInput.Name = "sizeInput";
            this.sizeInput.Size = new System.Drawing.Size(25, 20);
            this.sizeInput.TabIndex = 7;
            this.sizeInput.Text = "0";
            // 
            // redRadio
            // 
            this.redRadio.AutoSize = true;
            this.redRadio.Location = new System.Drawing.Point(15, 122);
            this.redRadio.Name = "redRadio";
            this.redRadio.Size = new System.Drawing.Size(67, 17);
            this.redRadio.TabIndex = 8;
            this.redRadio.TabStop = true;
            this.redRadio.Text = "Red Pen";
            this.redRadio.UseVisualStyleBackColor = true;
            // 
            // blueRadio
            // 
            this.blueRadio.AutoSize = true;
            this.blueRadio.Location = new System.Drawing.Point(15, 145);
            this.blueRadio.Name = "blueRadio";
            this.blueRadio.Size = new System.Drawing.Size(68, 17);
            this.blueRadio.TabIndex = 9;
            this.blueRadio.TabStop = true;
            this.blueRadio.Text = "Blue Pen";
            this.blueRadio.UseVisualStyleBackColor = true;
            // 
            // greenRadio
            // 
            this.greenRadio.AutoSize = true;
            this.greenRadio.Location = new System.Drawing.Point(15, 168);
            this.greenRadio.Name = "greenRadio";
            this.greenRadio.Size = new System.Drawing.Size(76, 17);
            this.greenRadio.TabIndex = 10;
            this.greenRadio.TabStop = true;
            this.greenRadio.Text = "Green Pen";
            this.greenRadio.UseVisualStyleBackColor = true;
            // 
            // otherLabel
            // 
            this.otherLabel.Location = new System.Drawing.Point(15, 192);
            this.otherLabel.Name = "otherLabel";
            this.otherLabel.Size = new System.Drawing.Size(76, 37);
            this.otherLabel.TabIndex = 11;
            this.otherLabel.Text = "Select None for Black Pen";
            // 
            // drawStar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.otherLabel);
            this.Controls.Add(this.greenRadio);
            this.Controls.Add(this.blueRadio);
            this.Controls.Add(this.redRadio);
            this.Controls.Add(this.sizeInput);
            this.Controls.Add(this.yInput);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.xInput);
            this.Controls.Add(this.whatLabel);
            this.Controls.Add(this.drawButton);
            this.Name = "drawStar";
            this.Text = "Draw Star";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Label whatLabel;
        private System.Windows.Forms.TextBox xInput;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.TextBox yInput;
        private System.Windows.Forms.TextBox sizeInput;
        private System.Windows.Forms.RadioButton redRadio;
        private System.Windows.Forms.RadioButton blueRadio;
        private System.Windows.Forms.RadioButton greenRadio;
        private System.Windows.Forms.Label otherLabel;
    }
}

