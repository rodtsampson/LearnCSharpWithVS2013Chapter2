using System;
using System.Windows.Forms;

namespace TryCatchConstructs
{
    class Program_TryCatchConstructs
    {
        private static Form frm = new Form();
        private static Button butt = new Button();
        private static Label lbl = new Label();
        private static TextBox box1 = new TextBox();
        private static TextBox box2 = new TextBox();
        //Make function to initialize
        public static void SetComps()
        {
            frm.Controls.Add(butt);
            frm.Controls.Add(box1);
            frm.Controls.Add(box2);
            frm.Controls.Add(lbl);
            int topPos = 50;
            foreach(Control c in frm.Controls)
            {
                c.Left = 50;
                c.Top = topPos;
                topPos += 50;
            }
            butt.Click += Butt_Click;
            lbl.AutoSize = true;
            butt.Text = "Divide";
        }

        static void Butt_Click(object sender, EventArgs e)
        {
            try
            {
                lbl.Text = (double.Parse(box1.Text) + double.Parse(box2.Text)).ToString()+"\n";
            }
            catch(FormatException ex)
            {
                lbl.Text = ex.Message+"\n";
            }
            finally
            {
                lbl.Text += "Your input has been processed.";
            }
        }
        //static void Main()
        //{
        //    SetComps();
        //    Application.Run(frm);
        //}
    }
}
