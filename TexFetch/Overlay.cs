using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TexFetch {




    class OverlayForm : Form {
        public OverlayForm() {
            SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }
    }

    class Overlay {
        private Form form;
        private Panel box;
        private Label info;
        private Timer timer;

        private Point mousePos;
        private bool selecting = false;
        private Screen.Selection selection;

        public Bitmap Init() {

            form = new OverlayForm();

            MouseMessageFilter mouseFilter = new MouseMessageFilter(this);
            mouseFilter.TargetForm = form;

            Application.AddMessageFilter(mouseFilter);

            form.FormBorderStyle = FormBorderStyle.None;
            form.TransparencyKey = Color.Turquoise;
            form.BackColor = Color.Turquoise;

            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(Screen.left, Screen.top);
            form.Size = new Size(Screen.width, Screen.height);

            box = new Panel();
            box.Visible = false;
            box.BorderStyle = BorderStyle.FixedSingle;

            info = new Label();
            box.Controls.Add(info);
            form.Controls.Add(box);

            timer = new Timer();
            timer.Interval = 12;
            timer.Tick += timerTick;
            timer.Start();

            form.KeyDown += overlayKeyDown;
            info.Paint += infoDraw;
            form.ShowDialog();
            //Application.Run(form);


            timer.Stop();
            Application.RemoveMessageFilter(mouseFilter);


            return mouseFilter.ScreenShot;
        }

        private void timerTick(object sender, EventArgs e) {
            if(mousePos.X != Control.MousePosition.X || mousePos.Y != Control.MousePosition.Y) {
                mousePos.X = Control.MousePosition.X;
                mousePos.Y = Control.MousePosition.Y;
                if (selecting) {
                    selection.p2 = new Point(Control.MousePosition.X, Control.MousePosition.Y);
                    selection.Update();
                    box.Visible = false;
                    box.Left = Screen.left * -1 + selection.x;
                    box.Top = Screen.top * -1 + selection.y;
                    box.Width = selection.w + 1;
                    box.Height = selection.h + 1;
                    box.Visible = true;
                    if (selection.p2.X < selection.p1.X) info.Top = selection.h - 17;
                    else info.Top = 1;
                }
                info.Invalidate();
            }
        }

        private void infoDraw(object sender, PaintEventArgs e) {
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            e.Graphics.DrawString(selection.w + " x " + selection.h, info.Font, SystemBrushes.GrayText, new Point(0, 0));
        }



        class MouseMessageFilter : IMessageFilter {

            private Overlay instance = null;

            public MouseMessageFilter(Overlay instance)
            {
                this.instance = instance;
            }

            public Form TargetForm { get; set; }

            public Bitmap ScreenShot { get; set; }

            public bool PreFilterMessage(ref Message m) {
                if (m.Msg == 513 || m.Msg == 162)
                { // left click
                    if (!instance.selecting)
                    {
                        instance.selecting = true;
                        instance.box.Visible = true;
                        instance.selection.p1 = new Point(Control.MousePosition.X, Control.MousePosition.Y);
                    }
                    else
                    {
                        instance.selection.p2 = new Point(Control.MousePosition.X, Control.MousePosition.Y);
                        instance.selection.Update();
                        instance.form.Visible = false;


                        int sf = Utils.GetScaleFactor();


                        this.ScreenShot = TexFetch.Snip(
                           sf * instance.selection.x,
                           sf * instance.selection.y,
                           sf * instance.selection.w,
                           sf * instance.selection.h
                           );


                        //Application.Exit();
                    }
                }
                else if (m.Msg == 517 || m.Msg == 165)
                {
                    this.instance.form.Close();
                    //Application.Exit();
                }
                // right click

                return false;
            }

            

        }

        private void overlayKeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape)
            {
                this.form.Close();
            }
        }
    }
}
