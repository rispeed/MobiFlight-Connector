﻿namespace MobiFlight.UI.Panels.Modifier
{
    partial class BlinkModifierPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxBlinkValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelSequences = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // textBoxBlinkValue
            // 
            this.textBoxBlinkValue.Location = new System.Drawing.Point(10, 26);
            this.textBoxBlinkValue.Name = "textBoxBlinkValue";
            this.textBoxBlinkValue.Size = new System.Drawing.Size(41, 20);
            this.textBoxBlinkValue.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Blink value";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Blink sequence (in ms)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 24);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelSequences
            // 
            this.panelSequences.AutoSize = true;
            this.panelSequences.Location = new System.Drawing.Point(128, 23);
            this.panelSequences.MinimumSize = new System.Drawing.Size(200, 0);
            this.panelSequences.Name = "panelSequences";
            this.panelSequences.Size = new System.Drawing.Size(200, 30);
            this.panelSequences.TabIndex = 8;
            // 
            // BlinkModifierPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panelSequences);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBlinkValue);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(400, 0);
            this.Name = "BlinkModifierPanel";
            this.Size = new System.Drawing.Size(400, 56);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBlinkValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelSequences;
    }
}
