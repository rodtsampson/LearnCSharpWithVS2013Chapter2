//This is part of a 2-file example
//1. ControlsClass
//2. Program_BasicForms
using System;
using System.Windows.Forms;

namespace BasicForms
{
    partial class Program
    {
        static void Main()
        {
            lbl.Top = 50; lbl.Left = 50;
            lbl.Text = "Answer: ";
            box1.Top = 75; box1.Left = 50;
            box2.Top = 100; box2.Left = 50;
            rbutt.Location = new System.Drawing.Point(125, 50);
            rbutt.Size = new System.Drawing.Size(25, 25);
            //rbutt.Top = 125; rbutt.Left = 50;
            rbutt.Text = "+";
            butt.Click += butt_Click;
            butt.Text = "Continue";
            myFrm.Controls.Add(butt);
            myFrm.Controls.Add(lbl);
            myFrm.Controls.Add(box1);
            myFrm.Controls.Add(box2);
            Application.Run(myFrm);
        }
    }
}
