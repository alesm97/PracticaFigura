using System;

namespace PracticaFigura
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
            this.rectangleText = new System.Windows.Forms.Label();
            this.triangleText = new System.Windows.Forms.Label();
            this.circleText = new System.Windows.Forms.Label();
            this.rectangleBase = new System.Windows.Forms.NumericUpDown();
            this.rectBaseText = new System.Windows.Forms.Label();
            this.rectHeghtText = new System.Windows.Forms.Label();
            this.triangleBaseText = new System.Windows.Forms.Label();
            this.triangleHeightText = new System.Windows.Forms.Label();
            this.circleRadiusText = new System.Windows.Forms.Label();
            this.rectangleHeight = new System.Windows.Forms.NumericUpDown();
            this.triangleHeight = new System.Windows.Forms.NumericUpDown();
            this.triangleBase = new System.Windows.Forms.NumericUpDown();
            this.circleRadius = new System.Windows.Forms.NumericUpDown();
            this.RectangleButton = new System.Windows.Forms.Button();
            this.triangleButton = new System.Windows.Forms.Button();
            this.circleButton = new System.Windows.Forms.Button();
            this.rectangleAreaText = new System.Windows.Forms.Label();
            this.resultText = new System.Windows.Forms.Label();
            this.rectanglePerimetreText = new System.Windows.Forms.Label();
            this.triangleAreaText = new System.Windows.Forms.Label();
            this.perimetreTriangleText = new System.Windows.Forms.Label();
            this.circlePerimetreText = new System.Windows.Forms.Label();
            this.circleAreaText = new System.Windows.Forms.Label();
            this.cm1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rectangleBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectangleHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangleHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangleBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // rectangleText
            // 
            this.rectangleText.AutoSize = true;
            this.rectangleText.Location = new System.Drawing.Point(18, 28);
            this.rectangleText.Name = "rectangleText";
            this.rectangleText.Size = new System.Drawing.Size(63, 15);
            this.rectangleText.TabIndex = 0;
            this.rectangleText.Text = "Rectangle";
            // 
            // triangleText
            // 
            this.triangleText.AutoSize = true;
            this.triangleText.Location = new System.Drawing.Point(18, 146);
            this.triangleText.Name = "triangleText";
            this.triangleText.Size = new System.Drawing.Size(52, 15);
            this.triangleText.TabIndex = 1;
            this.triangleText.Text = "Triangle";
            // 
            // circleText
            // 
            this.circleText.AutoSize = true;
            this.circleText.Location = new System.Drawing.Point(18, 267);
            this.circleText.Name = "circleText";
            this.circleText.Size = new System.Drawing.Size(38, 15);
            this.circleText.TabIndex = 2;
            this.circleText.Text = "Circle";
            // 
            // rectangleBase
            // 
            this.rectangleBase.DecimalPlaces = 2;
            this.rectangleBase.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.rectangleBase.Location = new System.Drawing.Point(139, 65);
            this.rectangleBase.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.rectangleBase.Name = "rectangleBase";
            this.rectangleBase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rectangleBase.Size = new System.Drawing.Size(120, 20);
            this.rectangleBase.TabIndex = 7;
            this.rectangleBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.rectangleBase.ValueChanged += new System.EventHandler(this.rectangleValueChanged);
            // 
            // rectBaseText
            // 
            this.rectBaseText.AutoSize = true;
            this.rectBaseText.Location = new System.Drawing.Point(52, 70);
            this.rectBaseText.Name = "rectBaseText";
            this.rectBaseText.Size = new System.Drawing.Size(35, 15);
            this.rectBaseText.TabIndex = 12;
            this.rectBaseText.Text = "Base";
            // 
            // rectHeghtText
            // 
            this.rectHeghtText.AutoSize = true;
            this.rectHeghtText.Location = new System.Drawing.Point(52, 101);
            this.rectHeghtText.Name = "rectHeghtText";
            this.rectHeghtText.Size = new System.Drawing.Size(43, 15);
            this.rectHeghtText.TabIndex = 13;
            this.rectHeghtText.Text = "Height";
            // 
            // triangleBaseText
            // 
            this.triangleBaseText.AutoSize = true;
            this.triangleBaseText.Location = new System.Drawing.Point(52, 180);
            this.triangleBaseText.Name = "triangleBaseText";
            this.triangleBaseText.Size = new System.Drawing.Size(35, 15);
            this.triangleBaseText.TabIndex = 14;
            this.triangleBaseText.Text = "Base";
            // 
            // triangleHeightText
            // 
            this.triangleHeightText.AutoSize = true;
            this.triangleHeightText.Location = new System.Drawing.Point(52, 221);
            this.triangleHeightText.Name = "triangleHeightText";
            this.triangleHeightText.Size = new System.Drawing.Size(43, 15);
            this.triangleHeightText.TabIndex = 15;
            this.triangleHeightText.Text = "Height";
            // 
            // circleRadiusText
            // 
            this.circleRadiusText.AutoSize = true;
            this.circleRadiusText.Location = new System.Drawing.Point(52, 305);
            this.circleRadiusText.Name = "circleRadiusText";
            this.circleRadiusText.Size = new System.Drawing.Size(46, 15);
            this.circleRadiusText.TabIndex = 16;
            this.circleRadiusText.Text = "Radius";
            // 
            // rectangleHeight
            // 
            this.rectangleHeight.DecimalPlaces = 2;
            this.rectangleHeight.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.rectangleHeight.Location = new System.Drawing.Point(139, 96);
            this.rectangleHeight.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.rectangleHeight.Name = "rectangleHeight";
            this.rectangleHeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rectangleHeight.Size = new System.Drawing.Size(120, 20);
            this.rectangleHeight.TabIndex = 17;
            this.rectangleHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.rectangleHeight.ValueChanged += new System.EventHandler(this.rectangleValueChanged);
            // 
            // triangleHeight
            // 
            this.triangleHeight.DecimalPlaces = 2;
            this.triangleHeight.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.triangleHeight.Location = new System.Drawing.Point(139, 221);
            this.triangleHeight.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.triangleHeight.Name = "triangleHeight";
            this.triangleHeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.triangleHeight.Size = new System.Drawing.Size(120, 20);
            this.triangleHeight.TabIndex = 18;
            this.triangleHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.triangleHeight.ValueChanged += new System.EventHandler(this.triangleValueChanged);
            // 
            // triangleBase
            // 
            this.triangleBase.DecimalPlaces = 2;
            this.triangleBase.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.triangleBase.Location = new System.Drawing.Point(139, 180);
            this.triangleBase.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.triangleBase.Name = "triangleBase";
            this.triangleBase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.triangleBase.Size = new System.Drawing.Size(120, 20);
            this.triangleBase.TabIndex = 19;
            this.triangleBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.triangleBase.ValueChanged += new System.EventHandler(this.triangleValueChanged);
            // 
            // circleRadius
            // 
            this.circleRadius.DecimalPlaces = 2;
            this.circleRadius.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.circleRadius.Location = new System.Drawing.Point(139, 305);
            this.circleRadius.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.circleRadius.Name = "circleRadius";
            this.circleRadius.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.circleRadius.Size = new System.Drawing.Size(120, 20);
            this.circleRadius.TabIndex = 20;
            this.circleRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.circleRadius.ValueChanged += new System.EventHandler(this.circleRadius_ValueChanged);
            // 
            // RectangleButton
            // 
            this.RectangleButton.Enabled = false;
            this.RectangleButton.Location = new System.Drawing.Point(336, 82);
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(166, 23);
            this.RectangleButton.TabIndex = 21;
            this.RectangleButton.Text = "Rectangle operations";
            this.RectangleButton.UseVisualStyleBackColor = true;
            this.RectangleButton.Click += new System.EventHandler(this.RectangleButton_Click);
            // 
            // triangleButton
            // 
            this.triangleButton.Enabled = false;
            this.triangleButton.Location = new System.Drawing.Point(336, 199);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Size = new System.Drawing.Size(166, 23);
            this.triangleButton.TabIndex = 22;
            this.triangleButton.Text = "Triangle operations";
            this.triangleButton.UseVisualStyleBackColor = true;
            this.triangleButton.Click += new System.EventHandler(this.triangleButton_Click);
            // 
            // circleButton
            // 
            this.circleButton.Enabled = false;
            this.circleButton.Location = new System.Drawing.Point(336, 305);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(166, 23);
            this.circleButton.TabIndex = 23;
            this.circleButton.Text = "Circle operations";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            // 
            // rectangleAreaText
            // 
            this.rectangleAreaText.AutoSize = true;
            this.rectangleAreaText.Location = new System.Drawing.Point(546, 70);
            this.rectangleAreaText.Name = "rectangleAreaText";
            this.rectangleAreaText.Size = new System.Drawing.Size(38, 15);
            this.rectangleAreaText.TabIndex = 24;
            this.rectangleAreaText.Text = "Area: ";
            this.rectangleAreaText.Click += new System.EventHandler(this.label1_Click);
            // 
            // resultText
            // 
            this.resultText.AutoSize = true;
            this.resultText.Location = new System.Drawing.Point(632, 28);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(48, 15);
            this.resultText.TabIndex = 25;
            this.resultText.Text = "Results";
            // 
            // rectanglePerimetreText
            // 
            this.rectanglePerimetreText.AutoSize = true;
            this.rectanglePerimetreText.Location = new System.Drawing.Point(546, 101);
            this.rectanglePerimetreText.Name = "rectanglePerimetreText";
            this.rectanglePerimetreText.Size = new System.Drawing.Size(67, 15);
            this.rectanglePerimetreText.TabIndex = 26;
            this.rectanglePerimetreText.Text = "Perimetre: ";
            // 
            // triangleAreaText
            // 
            this.triangleAreaText.AutoSize = true;
            this.triangleAreaText.Location = new System.Drawing.Point(546, 180);
            this.triangleAreaText.Name = "triangleAreaText";
            this.triangleAreaText.Size = new System.Drawing.Size(38, 15);
            this.triangleAreaText.TabIndex = 27;
            this.triangleAreaText.Text = "Area: ";
            // 
            // perimetreTriangleText
            // 
            this.perimetreTriangleText.AutoSize = true;
            this.perimetreTriangleText.Location = new System.Drawing.Point(546, 221);
            this.perimetreTriangleText.Name = "perimetreTriangleText";
            this.perimetreTriangleText.Size = new System.Drawing.Size(67, 15);
            this.perimetreTriangleText.TabIndex = 28;
            this.perimetreTriangleText.Text = "Perimetre: ";
            // 
            // circlePerimetreText
            // 
            this.circlePerimetreText.AutoSize = true;
            this.circlePerimetreText.Location = new System.Drawing.Point(546, 332);
            this.circlePerimetreText.Name = "circlePerimetreText";
            this.circlePerimetreText.Size = new System.Drawing.Size(67, 15);
            this.circlePerimetreText.TabIndex = 29;
            this.circlePerimetreText.Text = "Perimetre: ";
            // 
            // circleAreaText
            // 
            this.circleAreaText.AutoSize = true;
            this.circleAreaText.Location = new System.Drawing.Point(546, 296);
            this.circleAreaText.Name = "circleAreaText";
            this.circleAreaText.Size = new System.Drawing.Size(38, 15);
            this.circleAreaText.TabIndex = 30;
            this.circleAreaText.Text = "Area: ";
            // 
            // cm1
            // 
            this.cm1.AutoSize = true;
            this.cm1.Location = new System.Drawing.Point(266, 65);
            this.cm1.Name = "cm1";
            this.cm1.Size = new System.Drawing.Size(18, 15);
            this.cm1.TabIndex = 31;
            this.cm1.Text = "m";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "m";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "m";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "m";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "m";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 371);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cm1);
            this.Controls.Add(this.circleAreaText);
            this.Controls.Add(this.circlePerimetreText);
            this.Controls.Add(this.perimetreTriangleText);
            this.Controls.Add(this.triangleAreaText);
            this.Controls.Add(this.rectanglePerimetreText);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.rectangleAreaText);
            this.Controls.Add(this.circleButton);
            this.Controls.Add(this.triangleButton);
            this.Controls.Add(this.RectangleButton);
            this.Controls.Add(this.circleRadius);
            this.Controls.Add(this.triangleBase);
            this.Controls.Add(this.triangleHeight);
            this.Controls.Add(this.rectangleHeight);
            this.Controls.Add(this.circleRadiusText);
            this.Controls.Add(this.triangleHeightText);
            this.Controls.Add(this.triangleBaseText);
            this.Controls.Add(this.rectHeghtText);
            this.Controls.Add(this.rectBaseText);
            this.Controls.Add(this.rectangleBase);
            this.Controls.Add(this.circleText);
            this.Controls.Add(this.triangleText);
            this.Controls.Add(this.rectangleText);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.rectangleBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectangleHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangleHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangleBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleRadius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void triangleBase_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label rectangleText;
        private System.Windows.Forms.Label triangleText;
        private System.Windows.Forms.Label circleText;
        private System.Windows.Forms.NumericUpDown rectangleBase;
        private System.Windows.Forms.Label rectBaseText;
        private System.Windows.Forms.Label rectHeghtText;
        private System.Windows.Forms.Label triangleBaseText;
        private System.Windows.Forms.Label triangleHeightText;
        private System.Windows.Forms.Label circleRadiusText;
        private System.Windows.Forms.NumericUpDown rectangleHeight;
        private System.Windows.Forms.NumericUpDown triangleHeight;
        private System.Windows.Forms.NumericUpDown triangleBase;
        private System.Windows.Forms.NumericUpDown circleRadius;
        private System.Windows.Forms.Button RectangleButton;
        private System.Windows.Forms.Button triangleButton;
        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.Label rectangleAreaText;
        private System.Windows.Forms.Label resultText;
        private System.Windows.Forms.Label rectanglePerimetreText;
        private System.Windows.Forms.Label triangleAreaText;
        private System.Windows.Forms.Label perimetreTriangleText;
        private System.Windows.Forms.Label circlePerimetreText;
        private System.Windows.Forms.Label circleAreaText;
        private System.Windows.Forms.Label cm1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

