﻿namespace Calculator
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Backspace = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
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
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(586, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.scientificToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.standardToolStripMenuItem.Text = "Standard";
            this.standardToolStripMenuItem.Click += new System.EventHandler(this.standardToolStripMenuItem_Click);
            // 
            // scientificToolStripMenuItem
            // 
            this.scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            this.scientificToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.scientificToolStripMenuItem.Text = "Scientific";
            this.scientificToolStripMenuItem.Click += new System.EventHandler(this.scientificToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Backspace
            // 
            this.Backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Backspace.Location = new System.Drawing.Point(12, 86);
            this.Backspace.Name = "Backspace";
            this.Backspace.Size = new System.Drawing.Size(67, 63);
            this.Backspace.TabIndex = 1;
            this.Backspace.Text = "⌂";
            this.Backspace.UseVisualStyleBackColor = true;
            this.Backspace.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(12, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(286, 41);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(85, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 63);
            this.button2.TabIndex = 3;
            this.button2.Text = "CE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(158, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 63);
            this.button3.TabIndex = 4;
            this.button3.Text = "C";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(231, 86);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 63);
            this.button4.TabIndex = 5;
            this.button4.Text = "%";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(231, 155);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 63);
            this.button5.TabIndex = 9;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.operators_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(158, 155);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 63);
            this.button6.TabIndex = 8;
            this.button6.Text = "9";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.Location = new System.Drawing.Point(85, 155);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(67, 63);
            this.button7.TabIndex = 7;
            this.button7.Text = "8";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.Location = new System.Drawing.Point(12, 155);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(67, 63);
            this.button8.TabIndex = 6;
            this.button8.Text = "7";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button9.Location = new System.Drawing.Point(231, 224);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(67, 63);
            this.button9.TabIndex = 13;
            this.button9.Text = "-";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.operators_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button10.Location = new System.Drawing.Point(158, 224);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(67, 63);
            this.button10.TabIndex = 12;
            this.button10.Text = "6";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button11.Location = new System.Drawing.Point(85, 224);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(67, 63);
            this.button11.TabIndex = 11;
            this.button11.Text = "5";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button12.Location = new System.Drawing.Point(12, 224);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(67, 63);
            this.button12.TabIndex = 10;
            this.button12.Text = "4";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button13.Location = new System.Drawing.Point(231, 293);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(67, 63);
            this.button13.TabIndex = 17;
            this.button13.Text = "*";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.operators_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button14.Location = new System.Drawing.Point(158, 293);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(67, 63);
            this.button14.TabIndex = 16;
            this.button14.Text = "3";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button15.Location = new System.Drawing.Point(85, 293);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(67, 63);
            this.button15.TabIndex = 15;
            this.button15.Text = "2";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button_Click);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button16.Location = new System.Drawing.Point(12, 293);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(67, 63);
            this.button16.TabIndex = 14;
            this.button16.Text = "1";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button_Click);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button17.Location = new System.Drawing.Point(231, 362);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(67, 63);
            this.button17.TabIndex = 21;
            this.button17.Text = "/";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.operators_Click);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button18.Location = new System.Drawing.Point(158, 362);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(67, 63);
            this.button18.TabIndex = 20;
            this.button18.Text = "=";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button19.Location = new System.Drawing.Point(85, 362);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(67, 63);
            this.button19.TabIndex = 19;
            this.button19.Text = ".";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button_Click);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button20.Location = new System.Drawing.Point(12, 362);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(67, 63);
            this.button20.TabIndex = 18;
            this.button20.Text = "0";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button_Click);
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button21.Location = new System.Drawing.Point(502, 362);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(67, 63);
            this.button21.TabIndex = 42;
            this.button21.Text = "Mod";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.operators_Click);
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button22.Location = new System.Drawing.Point(429, 362);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(67, 63);
            this.button22.TabIndex = 41;
            this.button22.Text = "Oct";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button25
            // 
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button25.Location = new System.Drawing.Point(502, 293);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(67, 63);
            this.button25.TabIndex = 38;
            this.button25.Text = "In x";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button26
            // 
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button26.Location = new System.Drawing.Point(429, 293);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(67, 63);
            this.button26.TabIndex = 37;
            this.button26.Text = "Hex";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button27
            // 
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button27.Location = new System.Drawing.Point(356, 293);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(67, 63);
            this.button27.TabIndex = 36;
            this.button27.Text = "Tan";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button29
            // 
            this.button29.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button29.Location = new System.Drawing.Point(502, 224);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(67, 63);
            this.button29.TabIndex = 34;
            this.button29.Text = "1/x";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button30
            // 
            this.button30.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button30.Location = new System.Drawing.Point(429, 224);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(67, 63);
            this.button30.TabIndex = 33;
            this.button30.Text = "Bin";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // button31
            // 
            this.button31.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button31.Location = new System.Drawing.Point(356, 224);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(67, 63);
            this.button31.TabIndex = 32;
            this.button31.Text = "Cos";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button33
            // 
            this.button33.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button33.Location = new System.Drawing.Point(502, 155);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(67, 63);
            this.button33.TabIndex = 30;
            this.button33.Text = "x³";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // button34
            // 
            this.button34.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button34.Location = new System.Drawing.Point(429, 155);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(67, 63);
            this.button34.TabIndex = 29;
            this.button34.Text = "Dec";
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Click += new System.EventHandler(this.button34_Click);
            // 
            // button35
            // 
            this.button35.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button35.Location = new System.Drawing.Point(356, 155);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(67, 63);
            this.button35.TabIndex = 28;
            this.button35.Text = "Sin";
            this.button35.UseVisualStyleBackColor = true;
            this.button35.Click += new System.EventHandler(this.button35_Click);
            // 
            // button37
            // 
            this.button37.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button37.Location = new System.Drawing.Point(502, 86);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(67, 63);
            this.button37.TabIndex = 26;
            this.button37.Text = "x²";
            this.button37.UseVisualStyleBackColor = true;
            this.button37.Click += new System.EventHandler(this.button37_Click);
            // 
            // button38
            // 
            this.button38.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button38.Location = new System.Drawing.Point(429, 86);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(67, 63);
            this.button38.TabIndex = 25;
            this.button38.Text = "Sqrt";
            this.button38.UseVisualStyleBackColor = true;
            this.button38.Click += new System.EventHandler(this.button38_Click);
            // 
            // button39
            // 
            this.button39.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button39.Location = new System.Drawing.Point(356, 86);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(67, 63);
            this.button39.TabIndex = 24;
            this.button39.Text = "Log";
            this.button39.UseVisualStyleBackColor = true;
            this.button39.Click += new System.EventHandler(this.button39_Click);
            // 
            // button40
            // 
            this.button40.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button40.Location = new System.Drawing.Point(356, 362);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(67, 63);
            this.button40.TabIndex = 22;
            this.button40.Text = "π";
            this.button40.UseVisualStyleBackColor = true;
            this.button40.Click += new System.EventHandler(this.button40_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 43;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.button37);
            this.Controls.Add(this.button38);
            this.Controls.Add(this.button39);
            this.Controls.Add(this.button40);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Backspace);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scientificToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button Backspace;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

