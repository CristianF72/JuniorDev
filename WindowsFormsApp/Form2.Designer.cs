﻿namespace WindowsFormsApp
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 24);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 19);
            this.button1.TabIndex = 0;
            this.button1.Text = "IList";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.IListButon);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 24);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 19);
            this.button2.TabIndex = 1;
            this.button2.Text = "IEnumerable";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.IEnumerableButton);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "vs";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(26, 60);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 19);
            this.button3.TabIndex = 3;
            this.button3.Text = "Yield return";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.YieldReturnButton);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(233, 60);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 19);
            this.button4.TabIndex = 4;
            this.button4.Text = "Yield returns: multiple iterations";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.YieldReturnMultipleIterationsButton);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(26, 102);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 19);
            this.button5.TabIndex = 5;
            this.button5.Text = "Generics 1 (int)";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Generics1IntButton);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(233, 102);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(153, 19);
            this.button6.TabIndex = 6;
            this.button6.Text = "Generics 2 (string)";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Generics2StringButon);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(26, 146);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(141, 19);
            this.button7.TabIndex = 7;
            this.button7.Text = "Generic Delegate 1 (int)";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.GenericDelegate1IntButton);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(233, 146);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(153, 19);
            this.button8.TabIndex = 8;
            this.button8.Text = "Generic Delegate 2 (string)";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.GenericDelegate2StringButton);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(26, 189);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(141, 19);
            this.button9.TabIndex = 9;
            this.button9.Text = "LinQ";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.LinQButton);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(233, 189);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(153, 19);
            this.button10.TabIndex = 10;
            this.button10.Text = "LinQ Single Example";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.LinQSingleExampleButton);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(26, 232);
            this.button11.Margin = new System.Windows.Forms.Padding(2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(141, 19);
            this.button11.TabIndex = 11;
            this.button11.Text = "LinQ First Example";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.LinQFirstExampleButton);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(233, 234);
            this.button12.Margin = new System.Windows.Forms.Padding(2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(153, 19);
            this.button12.TabIndex = 12;
            this.button12.Text = "Extension Method";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.ExtensionMethodButton);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(103, 275);
            this.button13.Margin = new System.Windows.Forms.Padding(2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(188, 23);
            this.button13.TabIndex = 13;
            this.button13.Text = "Boxing / Unboxing";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.BoxingUnboxingButton);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(103, 317);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(188, 23);
            this.button14.TabIndex = 14;
            this.button14.Text = "Explicit Interface Implementation";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.ExplicitInterfaceImplementationButton);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(103, 366);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(188, 23);
            this.button15.TabIndex = 15;
            this.button15.Text = "Async Await Example";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.AsyncAwaitExampleButton);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(103, 410);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(188, 23);
            this.button16.TabIndex = 16;
            this.button16.Text = "Threads splitting task example";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.ThreadsSplittingTaskButton);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(103, 453);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(188, 23);
            this.button17.TabIndex = 17;
            this.button17.Text = "Tuple vs ValueTuple";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.TupleVsTupleValueButton);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(103, 498);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(188, 23);
            this.button18.TabIndex = 18;
            this.button18.Text = "Expression-bodied members";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.ExpressionBodiedMembersButton);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(103, 542);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(188, 23);
            this.button19.TabIndex = 19;
            this.button19.Text = "Deadlock";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.DeadlockExampleButton);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 589);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
    }
}