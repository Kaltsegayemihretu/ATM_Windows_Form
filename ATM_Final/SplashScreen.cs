using System;
using System.Drawing;
using System.Windows.Forms;

namespace ATM_Final
{
    public partial class SplashScreen : Form
    {
        private Timer timer;

        public SplashScreen()
        {
            InitializeComponent();
            // Make the form borderless
            this.FormBorderStyle = FormBorderStyle.None;
            // Set the desired window size
            int desiredWidth = 1250; // Your desired width
            int desiredHeight = 600; // Your desired height

            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            int posX = (screenWidth - desiredWidth) / 2;
            int posY = (screenHeight - desiredHeight) / 2;

            this.StartPosition = FormStartPosition.Manual;
            this.Size = new Size(desiredWidth, desiredHeight);
            this.Location = new Point(posX, posY);

            // Create and configure the timer
            timer = new Timer();
            timer.Interval = 11000; // Set the time in milliseconds (e.g., 5000 for 5 seconds)
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            // Calculate the position to center the video in the form
            int videoWidth = axWindowsMediaPlayer1.Width;
            int videoHeight = axWindowsMediaPlayer1.Height;

            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            int posX = (formWidth - videoWidth) / 2;
            int posY = (formHeight - videoHeight) / 2;

            axWindowsMediaPlayer1.Location = new Point(posX, posY);

            // Play the video
            axWindowsMediaPlayer1.URL = @"C:\Users\kal Tsegaye\Desktop\Folders\Atm Gui\ATM_Windows_Form\ATM_Final\assets\SplashScreen.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            // Video's original size
            axWindowsMediaPlayer1.stretchToFit = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            timer.Stop();

            // Close the current form
            this.Hide();

            // Open the next form
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
