﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyekPCS
{
    public partial class customtextbox : UserControl
    {
        //Fields
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color borderFocusColor = Color.HotPink;
        private bool isFocused = false;
        
        //Constructor
        public customtextbox()
        {
            InitializeComponent();
        }
        //Properties
        public Color BorderColor 
        { 
            get => borderColor; 
            set => borderColor = value; 
        }
        public int BorderSize 
        { 
            get => borderSize; 
            set => borderSize = value; 
        }
        public bool UnderlinedStyle 
        { 
            get => underlinedStyle;
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }
        public Color BorderFocusColor 
        { 
            get => borderFocusColor;
            set
            {
                borderFocusColor = value;
                this.Invalidate();
            }
        }
        public bool IsFocused 
        { 
            get => isFocused;
            set
            {
                isFocused = value;
                this.Invalidate();
            }
        }

        //Properties
        public bool PasswordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }
        }

        [Category("RJ Code Advance")]
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }

        [Category("RJ Code Advance")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }

        [Category("RJ Code Advance")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }

        [Category("RJ Code Advance")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        [Category("RJ Code Advance")]
        public string Text
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        //Overridden methods

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            //Draw border
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (isFocused) penBorder.Color = borderFocusColor;//Set Border color in focus. Otherwise, normal border color

                if (underlinedStyle) //Line Style
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                else //Normal Style
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }
        //Private methods
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

    }
}
