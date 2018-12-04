using System;
using System.Windows.Forms;

namespace Pico_y_Placa_Predictor
{
    public partial class Predictor : Form
    {
        #region Global Class Fields and Properties Declaration/Initialization and Contained Forms Instanciation.
        private String actualSection = "Start";
        public String ActualSection { get { return actualSection; } set { actualSection = value; } }
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
        }

        private void splash()
        {
            FormSplash SplashScreen = new FormSplash();
            SplashScreen.ShowDialog();
        }

        #region Navigation Buttons Methods
        private void buttonNext_Click(object sender, EventArgs e)
        {
            goNext();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            goBack();
        }

        //Method that manages the Next Button behavior
        private void goNext()
        {
            buttonBack.Enabled = true;
            switch (ActualSection) //Checks the Current Showing Form and decide where to go based on the ActualSection.
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

        //Method that manages the Back Button behavior
        private void goBack()
        {
            buttonNext.Enabled = true;
            switch (ActualSection) //Checks the Current Showing Form and decide where to go.
            {
                case "Checker":
                    welcome();
                    buttonBack.Enabled = false;
                    break;
                case "Farewell":
                    buttonNext.Text = "Next";
                    checker();
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

        //Method that removes from the main container the current showing form.
        private void formRemover(String sectionName)
        {
            if (panelContent.Controls.Count > 0)
            {
                panelContent.Controls.RemoveAt(0);
            }

        }

        //Method that shows up the form that should appear, get it into the main container and shows it up.
        public void formSetter(String sectionName)
        {
            if(panelContent.Controls.Count>=1) formRemover(ActualSection);
            switch (sectionName)
            {
                case "Welcome":
                    if (ActualSection != "Welcome")
                    {
                        WelcomeScreen.TopLevel = false;
                        WelcomeScreen.AutoScroll = true;
                        panelContent.Controls.Add(WelcomeScreen);
                        ActualSection = "Welcome";
                        WelcomeScreen.Show();
                        WelcomeScreen.Size = panelContent.Size;
                    }
                    break;
                case "Checker":
                    if (ActualSection != "Checker")
                    {
                        CheckerScreen.TopLevel = false;
                        CheckerScreen.AutoScroll = true;
                        panelContent.Controls.Add(CheckerScreen);
                        ActualSection = "Checker";
                        CheckerScreen.Show();
                    }
                    break;
                case "Farewell":
                    if (ActualSection != "Farewell")
                    {   
                        FarewellScreen.TopLevel = false;
                        FarewellScreen.AutoScroll = true;
                        panelContent.Controls.Add(FarewellScreen);
                        ActualSection = "Farewell";
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