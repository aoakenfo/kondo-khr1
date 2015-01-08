using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace Khr1Test
{
    public class TextboxTraceListener : TraceListener
    {
        private RichTextBox textBox;
        public TextboxTraceListener(RichTextBox textBox)
        {
            this.textBox = textBox;
        }

        public override void Write(string message)
        {
            textBox.Text += message;
        }

        public override void WriteLine(string message)
        {
            textBox.Text += message + Environment.NewLine;

            this.textBox.SelectionStart = this.textBox.Text.Length;
            this.textBox.ScrollToCaret();
        }
    }
}
