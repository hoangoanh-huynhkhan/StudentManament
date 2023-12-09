using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm__alert : Form
    {
        private enum ActionType
        {
            Wait,
            Start,
            Close
        }

        private ActionType action;
        private int x, y;

        public frm__alert(string msg, AlertType type)
        {
            InitializeComponent();
            ShowAlert(msg, type);
        }

        public enum AlertType
        {
            Success,
            Warning,
            Error,
            Info
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (action)
            {
                case ActionType.Wait:
                    timer1.Interval = 5000;
                    action = ActionType.Close;
                    break;
                case ActionType.Start:
                    timer1.Interval = 1;
                    Opacity += 0.1;
                    if (x < Location.X)
                    {
                        Left--;
                    }
                    else
                    {
                        if (Opacity == 1.0)
                        {
                            action = ActionType.Wait;
                        }
                    }
                    break;
                case ActionType.Close:
                    timer1.Interval = 1;
                    Opacity -= 0.1;

                    Left -= 3;
                    if (Opacity == 0.0)
                    {
                        Dispose();
                    }
                    break;
            }
        }

        private void btnClose__click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = ActionType.Close;
        }

        public void ShowAlert(string msg, AlertType type)
        {
            Opacity = 0.0;
            StartPosition = FormStartPosition.Manual;
            string formName;

            for (int i = 1; i < 20; i++)
            {
                formName = "alert" + i.ToString();
                frm__alert existingForm = (frm__alert)Application.OpenForms[formName];

                if (existingForm == null)
                {
                    Name = formName;
                    x = Screen.PrimaryScreen.WorkingArea.Width - Width + 15;
                    y = Screen.PrimaryScreen.WorkingArea.Height - Height * i - 5 * i;
                    Location = new Point(x, y);
                    break;
                }
            }
            x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {
                case AlertType.Success:
                    pic__action.Image = global::GUI.Properties.Resources.success;
                    BackColor = Color.SeaGreen;
                    break;
                case AlertType.Error:
                    pic__action.Image = global::GUI.Properties.Resources.error;
                    BackColor = Color.DarkRed;
                    break;
                case AlertType.Info:
                    pic__action.Image = global::GUI.Properties.Resources.info;
                    BackColor = Color.RoyalBlue;
                    break;
                case AlertType.Warning:
                    pic__action.Image = global::GUI.Properties.Resources.warning;
                    BackColor = Color.DarkOrange;
                    break;
            }
            lblMsg.Text = msg;
            Show();
            action = ActionType.Start;
            timer1.Interval = 1;
            timer1.Start();
        }
    }
}
