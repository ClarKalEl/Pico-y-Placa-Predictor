using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pico_y_Placa_Predictor
{
    public partial class Predictor : Form
    {
        #region Global Class Fields and Properties Declaration/Initialization and Contained Forms Instanciation.
        private String currentSection = "Start";
        public String CurrentSection { get { return currentSection; } set { currentSection = value; } }
        FormWelcome WelcomeScreen = new FormWelcome();
        FormChecker CheckerScreen = new FormChecker();
        FormFarewell FarewellScreen = new FormFarewell();
        AboutBoxPicoYPlaca AboutForm = new AboutBoxPicoYPlaca();
        #endregion

        public Predictor()
        {
            splash();
            InitializeComponent();
            welcome();
            buttonActivation("buttonBack",false);
        }

        #region Splash
        private void splash()
        {
            FormSplash SplashScreen = new FormSplash();
            SplashScreen.ShowDialog();
        }
        #endregion

        #region Navigation Buttons Methods
        private void buttonNext_Click(object sender, EventArgs e)
        {
            goNext();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            goBack();
        }

        // Method that manages the Next Button behavior
        private void goNext()
        {
            buttonActivation("buttonBack", true);
            switch (CurrentSection) // Checking the Current Showing Form and decide where to go based on the CurrentSection class property.
            {
                case "Welcome":
                    checker();
                    break;
                case "Checker":
                    farewell();
                    buttonNext.Text = "Finish";
                    break;
                case "Farewell":
                    Application.Exit();
                    break;
            }
        }

        // Method that manages the Back Button behavior
        private void goBack()
        {
            switch (CurrentSection) //Checks the Current Showing Form and decide where to go.
            {
                case "Checker":
                    welcome();
                    buttonActivation("buttonBack", false);
                    break;
                case "Farewell":
                    buttonNext.Text = "Next";
                    checker();
                    break;
            }
        }
        
        // Method to Enable or Disable the Buttons, it changes not only the Enabled property but the color as well for a more intuitive look.
        private void buttonActivation(string buttonName, Boolean requiredState) 
        {   // Active / Enabled Colors:
            Color buttonActiveBackColor = Color.FromArgb(69, 39, 160); //Colors for Showing the Last Verdict.
            Color buttonActiveBorderColor = Color.FromArgb(121, 83, 210);
            Color buttonActiveMouseDownBackColor = Color.FromArgb(0, 0, 112);
            Color buttonActiveMouseOverBackColor = Color.FromArgb(121, 83, 210);
            Color buttonActiveTextForeColor = Color.White;
            // Inactive / Disabled Colors:
            Color buttonInactiveBackColor = Color.FromKnownColor(KnownColor.InactiveCaption); //Colors for Showing the Last Verdict.
            Color buttonInactiveBorderColor = Color.FromKnownColor(KnownColor.InactiveBorder);
            Color buttonInactiveMouseDownBackColor = Color.FromKnownColor(KnownColor.InactiveCaption);
            Color buttonInactiveMouseOverBackColor = Color.FromKnownColor(KnownColor.InactiveCaption);
            Color buttonInactiveTextForeColor = Color.FromKnownColor(KnownColor.InactiveCaptionText);
            // Comparing buttonName and Assigning Colors by requiredState.
            switch (buttonName)
            {
                case "buttonBack":
                    if (requiredState)
                    {
                        buttonBack.Enabled = true;
                        buttonBack.BackColor = buttonActiveBackColor;
                        buttonBack.FlatAppearance.BorderColor = buttonActiveBorderColor;
                        buttonBack.FlatAppearance.MouseDownBackColor = buttonActiveMouseDownBackColor;
                        buttonBack.FlatAppearance.MouseOverBackColor = buttonActiveMouseOverBackColor;
                        buttonBack.ForeColor = buttonActiveTextForeColor;
                    }
                    else
                    {
                        buttonBack.Enabled = false;
                        buttonBack.BackColor = buttonInactiveBackColor;
                        buttonBack.FlatAppearance.BorderColor = buttonInactiveBorderColor;
                        buttonBack.FlatAppearance.MouseDownBackColor = buttonInactiveMouseDownBackColor;
                        buttonBack.FlatAppearance.MouseOverBackColor = buttonInactiveMouseOverBackColor;
                        buttonBack.ForeColor = buttonInactiveTextForeColor;
                    }
                    break;
            }
        }
        #endregion

        #region Forms in panelContent Showing Management
        private void welcome()
        {
            formSetter("Welcome");
        }
        private void checker()
        {
            formSetter("Checker");
        }
        private void farewell()
        {
            formSetter("Farewell");
        }

        // Method that removes from the main panel container the current showing form.
        private void formRemover(String sectionName)
        {
            if (panelContent.Controls.Count > 0)
            {
                panelContent.Controls.RemoveAt(0);
            }

        }

        // Method that shows up the form that should appear, get it into the main container and shows it up.
        public void formSetter(String sectionName)
        {
            if(panelContent.Controls.Count>=1) formRemover(CurrentSection);
            switch (sectionName)
            {
                case "Welcome":
                    if (CurrentSection != "Welcome")
                    {
                        WelcomeScreen.TopLevel = false;
                        WelcomeScreen.AutoScroll = true;
                        panelContent.Controls.Add(WelcomeScreen);
                        CurrentSection = "Welcome";
                        WelcomeScreen.Show();
                        WelcomeScreen.Size = panelContent.Size;
                    }
                    break;
                case "Checker":
                    if (CurrentSection != "Checker")
                    {
                        CheckerScreen.TopLevel = false;
                        CheckerScreen.AutoScroll = true;
                        panelContent.Controls.Add(CheckerScreen);
                        CurrentSection = "Checker";
                        CheckerScreen.Show();
                    }
                    break;
                case "Farewell":
                    if (CurrentSection != "Farewell")
                    {   
                        FarewellScreen.TopLevel = false;
                        FarewellScreen.AutoScroll = true;
                        panelContent.Controls.Add(FarewellScreen);
                        CurrentSection = "Farewell";
                        FarewellScreen.Show();
                    }
                    break;
            }
        }
        #endregion

        #region ToolStripMenu Method
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm.ShowDialog();
        }
        #endregion

    }
}