using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;   // dragging form
using GUI_Template_fix.Secondary_Forms_Centre;
using GUI_Template_fix.Secondary_Forms_Right;

namespace GUI_Template_fix
{
    public partial class MainForm : Form
    {
        private Button currentButton;           // currently active button
        private Color currentColor;             // theme color of a currently active Color
        private string currentTextLabel;        // text currently displayed on the label
        private Form currentCentreForm;         // currently active centre child form
        private Form currentRightForm;          // currently active right panel child form

        public MainForm()
        {
            InitializeComponent();

            // prevents icon flittering
            this.DoubleBuffered = true;

            // getting rid of the control box
            this.ControlBox = false;
            this.Text = String.Empty;

            // setting minimal size of the form
            this.MinimumSize = new Size(1055, 615);

            // set currentColor to FontColors.color1
            currentColor = FontColors.color2;

            // current text on label 
            currentTextLabel = "Main Menu";
        }


        #region Colors

        private struct ThemeColors
        {
            public static Color color1 = Color.FromArgb(245, 157, 34);
            public static Color color2 = Color.FromArgb(237, 118, 58);
            public static Color color3 = Color.FromArgb(236, 92, 65);
            public static Color color4 = Color.FromArgb(226, 50, 70);
            public static Color color5 = Color.FromArgb(201, 31, 80);
            public static Color color6 = Color.FromArgb(168, 22, 85);
            public static Color color7 = Color.FromArgb(127, 21, 85);
            public static Color color8 = Color.FromArgb(84, 23, 82);
        }
        private struct FontColors
        {
            public static Color color1 = Color.FromArgb(255, 255, 255);
            public static Color color2 = Color.FromArgb(220, 244, 255);
        }
        private struct BackgroundColors
        {
            public static Color color1 = Color.FromArgb(6, 2, 29);
            public static Color color2 = Color.FromArgb(8, 6, 35);
            public static Color color3 = Color.FromArgb(20, 14, 80);
        }

        #endregion


        #region Activate/Desactivate Button

        /// <summary>
        /// Activate visual effects of clicked button
        /// And desactivates visual effects connected with the previous one
        /// </summary>
        /// <param name="senderButton"> Sender button </param>
        /// <param name="senderColor"> Chosen theme color </param>
        private void ActivateDesactivateButton(Button senderButton, Color senderColor)
        {
            if (senderButton != currentButton)
            {
                DesactivateButton();                        // desactivate previously activated button

                // activate new button
                panelButton.Visible = true;                 // activate side panel
                panelButton.BackColor = senderColor;        // set side button panel color to theme color
                panelUnderTop.BackColor = senderColor;      // set under top panel color to theme color
                currentButton = senderButton;               // save "senderButton" variable to "currentButton"
                senderButton.ForeColor = senderColor;       // set fore button color to theme
                panelButton.Location = new Point(0, currentButton.Location.Y);  // set panel location
                currentColor = senderColor;                 // save theme color
                labelTop.Text = currentTextLabel;           // change top table text
            }
            else
            {
                // if clicked button is currently active
                // do nothing
            }

        }

        private void DesactivateButton()
        {
            if (currentButton != null)
            {
                panelButton.Visible = false;                            // desactivate side panel
                panelUnderTop.BackColor = BackgroundColors.color2;      // change under top panel color to default
                currentButton.ForeColor = FontColors.color1;            // change button font color to default
                currentColor = FontColors.color2;                       // save theme color
                labelTop.Text = currentTextLabel;                       // change top table text
                currentButton = null;
            }
        }


        #endregion


        #region Side menu buttons

        private void button1_Click(object sender, EventArgs e)
        {
            currentTextLabel = "Button 1";
            OpenCloseForms((Button)sender, new formCentre1(), new formRight1());
            ActivateDesactivateButton((Button)sender, ThemeColors.color1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentTextLabel = "Button 2";
            OpenCloseForms((Button)sender, new formCentre2(), new formRight2());
            ActivateDesactivateButton((Button)sender, ThemeColors.color2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentTextLabel = "Button 3";
            OpenCloseForms((Button)sender, new formCentre3(), new formRight3());
            ActivateDesactivateButton((Button)sender, ThemeColors.color3);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentTextLabel = "Button 4";
            OpenCloseForms((Button)sender, new formCentre4(), new formRight4());
            ActivateDesactivateButton((Button)sender, ThemeColors.color4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentTextLabel = "Button 5";
            OpenCloseForms((Button)sender, new formCentre5(), new formRight5());
            ActivateDesactivateButton((Button)sender, ThemeColors.color5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentTextLabel = "Button 6";
            OpenCloseForms((Button)sender, new formCentre6(), new formRight6());
            ActivateDesactivateButton((Button)sender, ThemeColors.color6);           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            currentTextLabel = "Button 7";
            OpenCloseForms((Button)sender, new formCentre7(), new formRight7());
            ActivateDesactivateButton((Button)sender, ThemeColors.color7);
            
        }

        private void labelTopRight_Click(object sender, EventArgs e)
        {
            currentTextLabel = "Main Menu";
            DesactivateButton();
            CloseForms();
        }

        #endregion


        #region Top Left Corner buttons

        // Close window button
        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButtonExit_MouseLeave(object sender, EventArgs e)
        {
            iconButtonExit.IconColor = FontColors.color1;
            iconButtonExit.ForeColor = FontColors.color1;
        }

        private void iconButtonExit_MouseEnter(object sender, EventArgs e)
        {
            iconButtonExit.IconColor = currentColor;
            iconButtonExit.ForeColor = currentColor;
        }


        // Minimize window button
        private void iconButtonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void iconButtonMinimize_MouseEnter(object sender, EventArgs e)
        {
            iconButtonMinimize.IconColor = currentColor;
            iconButtonMinimize.ForeColor = currentColor;
        }

        private void iconButtonMinimize_MouseLeave(object sender, EventArgs e)
        {
            iconButtonMinimize.IconColor = FontColors.color1;
            iconButtonMinimize.ForeColor = FontColors.color1;
        }


        #endregion


        #region Mouse Drag

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void labelTopRight_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panelLeft_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        #endregion


        #region Open/close Child Form

        /// <summary>
        /// Function doing all the work concerning opening and closing forms upon clicing on buttons
        /// </summary>
        /// <param name="senderButton"> object containing information about clicked button</param>
        /// <param name="centreForm"> centre form that shall be opened upon clicking button </param>
        /// <param name="rightForm"> right form that shall be opened upon clicking button </param>
        private void OpenCloseForms(Button senderButton, Form centreForm, Form rightForm)
        {
            if(senderButton != currentButton)  // if new forms have to been activated
            {
                if(currentButton!=null)
                {
                    CloseForms();   // if a button has been activated previously
                }

                // open new forms
                OpenCentreForm(centreForm);
                OpenRightForm(rightForm);
            }
            
        }

        /// <summary>
        /// Open new form inside of the centre panel
        /// </summary>
        /// <param name="childForm"> Template of new form </param>
        private void OpenCentreForm(Form centreForm)
        {
            // if currently opened centre form is the same as the one passed to the function
            if (centreForm != currentCentreForm)
            {
                // close previously opened form
                CloseCentreForm();

                // create a new form
                currentCentreForm = centreForm;                         // saving a reference to the child form inside of the main form
                centreForm.TopLevel = false;                            // enables child form to be docked to panel "panelDesktop"
                centreForm.FormBorderStyle = FormBorderStyle.None;      // delete edge of the form
                centreForm.Dock = DockStyle.Fill;                       // fill panel
                panelCentre.Controls.Add(centreForm);                   // dock child form to "panelDesktop"

                // pin to the pannel and show the form
                panelCentre.Tag = centreForm;
                centreForm.BringToFront();
                centreForm.Show();
            }
        }

        /// <summary>
        /// Open new form inside of the right panel
        /// </summary>
        /// <param name="rightForm"> Template of new form </param>
        private void OpenRightForm(Form rightForm)
        {
            // if currently opened centre form is the same as the one passed to the function
            if (rightForm != currentRightForm)
            {
                // close previously opened form
                CloseRightForm();

                // create a new form
                currentRightForm = rightForm;                         // saving a reference to the child form inside of the main form
                rightForm.TopLevel = false;                            // enables child form to be docked to panel "panelDesktop"
                rightForm.FormBorderStyle = FormBorderStyle.None;      // delete edge of the form
                rightForm.Dock = DockStyle.Fill;                       // fill panel
                panelRight.Controls.Add(rightForm);                   // dock child form to "panelDesktop"

                // pin to the pannel and show the form
                panelRight.Tag = rightForm;
                rightForm.BringToFront();
                rightForm.Show();
            }
        }

        /// <summary>
        /// Close form on Centre panel
        /// </summary>
        private void CloseCentreForm()
        {
            // if there is a form currently opened on the panel
            if (currentCentreForm != null)
            {
                currentCentreForm.Close();
                currentCentreForm = null;
            }
        }

        /// <summary>
        /// Close form on Right panel
        /// </summary>
        private void CloseRightForm()
        {
            // if there is a form currently opened on the panel
            if (currentRightForm != null)
            {
                currentRightForm.Close();
                currentRightForm = null;
            }
        }

        /// <summary>
        /// Close forms on Right and Centre panels
        /// </summary>
        private void CloseForms()
        {
            CloseCentreForm();
            CloseRightForm();
        }

        #endregion
    }
}
