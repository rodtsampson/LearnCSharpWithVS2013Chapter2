//This is part of a 2-file example
//1. ControlsClass
//2. Program_BasicForms
using System;
using System.Windows.Forms;

namespace BasicForms
{
    partial class Program
    {
        static Form myFrm = new Form();
        static Button butt = new Button();
        static Label lbl = new Label();
        static TextBox box1 = new TextBox();
        static TextBox box2 = new TextBox();
        static RadioButton rbutt = new RadioButton();

        static void butt_Click(object sender, EventArgs e)
        {
            lbl.Text = "Answer: " + (double.Parse(box1.Text) + double.Parse(box2.Text)).ToString();
        }
    }
}
