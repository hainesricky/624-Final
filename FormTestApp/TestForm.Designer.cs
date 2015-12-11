﻿namespace FormTestApp
{
    partial class TestForm
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
            this.testButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.scribblePanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.testLabel = new System.Windows.Forms.Label();
            this.TemplateToggle = new System.Windows.Forms.Button();
            this.AddTemplate = new System.Windows.Forms.Button();
            this.ClearTemplates = new System.Windows.Forms.Button();
            this.TemplateDump = new System.Windows.Forms.Button();
            this.ChangeShape = new System.Windows.Forms.Button();
            this.CurrentTemplateLabel = new System.Windows.Forms.Label();
            this.ToggleRecognize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testButton
            // 
            this.testButton.BackColor = System.Drawing.Color.Lime;
            this.testButton.Location = new System.Drawing.Point(12, 12);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 0;
            this.testButton.Text = "Test...";
            this.testButton.UseVisualStyleBackColor = false;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.BackColor = System.Drawing.Color.Gray;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(1641, 344);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(160, 100);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // scribblePanel
            // 
            this.scribblePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scribblePanel.BackColor = System.Drawing.Color.Gainsboro;
            this.scribblePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scribblePanel.Location = new System.Drawing.Point(195, 43);
            this.scribblePanel.Name = "scribblePanel";
            this.scribblePanel.Size = new System.Drawing.Size(1440, 756);
            this.scribblePanel.TabIndex = 3;
            this.scribblePanel.Resize += new System.EventHandler(this.scribblePanel_Resize);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(12, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 124);
            this.button1.TabIndex = 0;
            this.button1.Text = "IsTemplate?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(88, 17);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(162, 13);
            this.testLabel.TabIndex = 6;
            this.testLabel.Text = "Press Test button to start testing.";
            // 
            // TemplateToggle
            // 
            this.TemplateToggle.Location = new System.Drawing.Point(13, 474);
            this.TemplateToggle.Name = "TemplateToggle";
            this.TemplateToggle.Size = new System.Drawing.Size(176, 125);
            this.TemplateToggle.TabIndex = 7;
            this.TemplateToggle.Text = "Show/Hide Templates";
            this.TemplateToggle.UseVisualStyleBackColor = true;
            this.TemplateToggle.Click += new System.EventHandler(this.TemplateToggle_Click);
            // 
            // AddTemplate
            // 
            this.AddTemplate.BackColor = System.Drawing.Color.Coral;
            this.AddTemplate.Location = new System.Drawing.Point(12, 94);
            this.AddTemplate.Name = "AddTemplate";
            this.AddTemplate.Size = new System.Drawing.Size(177, 85);
            this.AddTemplate.TabIndex = 8;
            this.AddTemplate.Text = "Add As New Template";
            this.AddTemplate.UseVisualStyleBackColor = false;
            this.AddTemplate.Click += new System.EventHandler(this.button2_Click);
            // 
            // ClearTemplates
            // 
            this.ClearTemplates.BackColor = System.Drawing.Color.Red;
            this.ClearTemplates.Location = new System.Drawing.Point(12, 224);
            this.ClearTemplates.Name = "ClearTemplates";
            this.ClearTemplates.Size = new System.Drawing.Size(177, 87);
            this.ClearTemplates.TabIndex = 9;
            this.ClearTemplates.Text = "Clear Templates";
            this.ClearTemplates.UseVisualStyleBackColor = false;
            this.ClearTemplates.Click += new System.EventHandler(this.ClearTemplates_Click);
            // 
            // TemplateDump
            // 
            this.TemplateDump.BackColor = System.Drawing.Color.GreenYellow;
            this.TemplateDump.Location = new System.Drawing.Point(12, 711);
            this.TemplateDump.Name = "TemplateDump";
            this.TemplateDump.Size = new System.Drawing.Size(176, 76);
            this.TemplateDump.TabIndex = 10;
            this.TemplateDump.Text = "Dump templates to file";
            this.TemplateDump.UseVisualStyleBackColor = false;
            this.TemplateDump.Click += new System.EventHandler(this.TemplateDump_Click);
            // 
            // ChangeShape
            // 
            this.ChangeShape.Location = new System.Drawing.Point(13, 605);
            this.ChangeShape.Name = "ChangeShape";
            this.ChangeShape.Size = new System.Drawing.Size(176, 60);
            this.ChangeShape.TabIndex = 11;
            this.ChangeShape.Text = "Change Active Shape Template";
            this.ChangeShape.UseVisualStyleBackColor = true;
            this.ChangeShape.Click += new System.EventHandler(this.ChangeShape_Click);
            // 
            // CurrentTemplateLabel
            // 
            this.CurrentTemplateLabel.AutoSize = true;
            this.CurrentTemplateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTemplateLabel.Location = new System.Drawing.Point(16, 668);
            this.CurrentTemplateLabel.Name = "CurrentTemplateLabel";
            this.CurrentTemplateLabel.Size = new System.Drawing.Size(172, 25);
            this.CurrentTemplateLabel.TabIndex = 12;
            this.CurrentTemplateLabel.Text = "CurrentTemplate";
            // 
            // ToggleRecognize
            // 
            this.ToggleRecognize.Location = new System.Drawing.Point(1641, 69);
            this.ToggleRecognize.Name = "ToggleRecognize";
            this.ToggleRecognize.Size = new System.Drawing.Size(160, 74);
            this.ToggleRecognize.TabIndex = 13;
            this.ToggleRecognize.Text = "Toggle Autorecognizer";
            this.ToggleRecognize.UseVisualStyleBackColor = true;
            this.ToggleRecognize.Click += new System.EventHandler(this.ToggleRecognize_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1813, 811);
            this.Controls.Add(this.ToggleRecognize);
            this.Controls.Add(this.CurrentTemplateLabel);
            this.Controls.Add(this.ChangeShape);
            this.Controls.Add(this.TemplateDump);
            this.Controls.Add(this.ClearTemplates);
            this.Controls.Add(this.AddTemplate);
            this.Controls.Add(this.TemplateToggle);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.scribblePanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.testButton);
            this.Name = "TestForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Panel scribblePanel;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button TemplateToggle;
        private System.Windows.Forms.Button AddTemplate;
        private System.Windows.Forms.Button ClearTemplates;
        private System.Windows.Forms.Button TemplateDump;
        private System.Windows.Forms.Button ChangeShape;
        private System.Windows.Forms.Label CurrentTemplateLabel;
        private System.Windows.Forms.Button ToggleRecognize;
    }
}
