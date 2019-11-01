using System;
using System.Windows.Forms;

namespace StringMethodProject
{
    class TwoDPoint
    {
        //instance variables
        private int x, y;
        public TwoDPoint(int xCoord, int yCoord)
        {
            //set instance variables
            this.x = xCoord; this.y = yCoord;
        }
        //object.Equals(object)
        //ex... p1.Equals(p2)
        public override bool Equals(object obj)
        {
            //ensure that obj is not null
            //and that the object types are identical
            if(obj==null || this.GetType() != obj.GetType())
            {
                return false;
            }
            else
            {
                //converts to a TwoDPoint
                TwoDPoint point = (TwoDPoint)obj;
                return this.x == point.x && this.y == point.y;
            }
        }
        public override int GetHashCode()
        {
            return x ^ y;
        }
    }
    class PointComparer
    {
        //create form and controls
        static Form frm = new Form();
        static TextBox box1 = new TextBox();
        static TextBox box2 = new TextBox();
        static Label lbl = new Label();
        static Button btn = new Button();
        //assign controls to forms
        //and position controls
        //in Main() using Init()
        public static void Init()
        {
            frm.Controls.Add(box1);
            frm.Controls.Add(box2);
            frm.Controls.Add(lbl);
            frm.Controls.Add(btn);
            int topPos = 50;
            foreach(Control c in frm.Controls)
            {
                c.Left = 50;
                c.Top = topPos;
                //push down new controls
                topPos += 25;
            }
            //assign button click event handler
            btn.Click += btn_Click;
            btn.Text = "Compare";
        }
        //handle button click
        private static void btn_Click(object sender, EventArgs e)
        {
            //clean/format point
            //ex... (4,5) becomes "4","5"
            string[] first = box1.Text.Split(new char[] { '(', ',', ')' }, StringSplitOptions.RemoveEmptyEntries);
            string[] second = box2.Text.Split(new char[] { '(', ',', ')' }, StringSplitOptions.RemoveEmptyEntries);
            //construct x and y coords of both points
            int p1x = int.Parse(first[0]);
            int p1y = int.Parse(first[1]);
            int p2x = int.Parse(second[0]);
            int p2y = int.Parse(second[1]);
            //set points with content from text boxes
            TwoDPoint p1 = new TwoDPoint(p1x, p1y);
            TwoDPoint p2 = new TwoDPoint(p2x, p2y);
            //compare and convert result to string
            //to display in label 
            lbl.Text = p1.Equals(p2).ToString();
        }
        //static void Main()
        //{
        //    Init();
        //    Application.Run(frm);
        //}
    }
}
