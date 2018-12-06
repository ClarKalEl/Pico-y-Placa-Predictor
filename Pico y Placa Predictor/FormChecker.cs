using System;
using System.Drawing;
using System.Windows.Forms;


namespace Pico_y_Placa_Predictor
{
    public partial class FormChecker : Form
    {
        #region Global Class Fields and Properties Declaration - Initialization
        Boolean isLicensePlateOk = true; //Field and Property that Helps to detect issues with License Plate.
        public Boolean IsLicensePlateOk { get { return isLicensePlateOk; } set { isLicensePlateOk = value; } }
        Boolean oldMan = false; // Well, this Field and Property is a little joke actually, just for fun :)
        public Boolean OldMan { get { return oldMan; } set { oldMan = value; } }

        String[] daysByDigits = { "Friday", "Monday", "Monday", "Tuesday", "Tuesday", "Wednesday", "Wednesday", "Thursday", "Thursday", "Friday" };
        public String[] DaysByDigits { get { return daysByDigits; } } //Restricted Days Array, every array index correspond to the last License Plate Number, so I corelate the License Plate Last Digit with the order I save the days inside the Array, this way we just have to enter the Driver License Plate Last Digit (keyNumber) as index, and we're gonna have the Restricted Day for the Driver.

        String morningScheduleBeginTime = "07:00", morningScheduleEndTime = "09:30"; //Fields and Properties of the Different Restricted Schedules for Quito - Ecuador City.
        String afternoonScheduleBeginTime = "16:00", afternoonScheduleEndTime = "19:30";
        public String MorningScheduleBeginTime { get { return morningScheduleBeginTime; } }
        public String MorningScheduleEndTime { get { return morningScheduleEndTime; } }
        public String AfternoonScheduleBeginTime { get { return afternoonScheduleBeginTime; } }
        public String AfternoonScheduleEndTime { get { return afternoonScheduleEndTime; } }
        String closeToRestrictionTimeRemaining = ""; // Fields and Properties for helping to know if the Driver with the DateTime entered is close to a restriction schedule.
        public String CloseToRestrictionTimeRemaining { get { return closeToRestrictionTimeRemaining; } set { closeToRestrictionTimeRemaining = value; } }
        Boolean[] closeToRestriction = new Boolean[2]; //The index 0 is for indicating if there is(T) or not(F) a Restriction Schedule close and the index 1 is for knowing if that Restriction is on morning(T), otherwise(F) the next Restriction is on afternoon.
        public Boolean[] CloseToRestriction { get { return closeToRestriction; } set { closeToRestriction = value; } }

        Color holoGreenDark = Color.FromArgb(255, 102, 153, 0); //Colors for Showing the Last Verdict.
        Color redError = Color.FromArgb(255, 155, 0, 0);
        #endregion
        public FormChecker()
        {
            InitializeComponent();
        }

        #region Check Button and Delivery of all Possible Errors.
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            IsLicensePlateOk = true; //Resetting the Properties
            OldMan = false;
            CloseToRestriction[0] = false; CloseToRestriction[1] = true;
            CloseToRestrictionTimeRemaining = "";
            try
            {
                errorProvider.Clear();
                switch (licensePlateVerifier(mTBLicensePlate.Text))
                {   // Distribution of Error Messagges.
                    case 1: //Not UPPERCASE LIcense Plate letters.
                        errorProvider.SetError(mTBLicensePlate, "The first 3 characters must be only UPPERCASE letters, verify and try again please.");
                        break;

                    case 2: //License Plate Field incomplete.
                        errorProvider.SetError(mTBLicensePlate, "License Plate is incomplete, verify and try again please.");
                        break;

                    case 0:
                        switch (dateTimeVerifierVerdictEngine(mTBDate.Text, mTBTime.Text, mTBLicensePlate.Text))
                        {
                            case 1: //Incomplete Date Field.
                                errorProvider.SetError(mTBDate, "The Date is incomplete, remember to use the right format dd/MM/YYYY, verify and try again please.");
                                break;

                            case 2: //Day out of boundaries.
                                errorProvider.SetError(mTBDate, "The Day is out of boundaries, must be a positive number but cannot be higher than 31, verify and try again please.");
                                break;

                            case 3: //Month out of boundaries.
                                errorProvider.SetError(mTBDate, "The Month is out of boundaries, must be a positive number but cannot be higher than 12, verify and try again please.");
                                break;

                            case 4: //Year out of boundaries.
                                errorProvider.SetError(mTBDate, "The Year is out of boundaries, must be a positive number but cannot be less than 2017 or higher than 2118, verify and try again please.");
                                break;

                            case 5: //Hours out of boundaries.
                                errorProvider.SetError(mTBTime, "The Hours are out of boundaries, must be a positive number but cannot be higher than 23, verify and try again please.");
                                break;

                            case 6: //Minutes out of boundaries.
                                errorProvider.SetError(mTBTime, "The Minutes are out of boundaries, must be a positive number but cannot be higher than 59, verify and try again please.");
                                break;

                            case 7: //Date out of boundaries.
                                errorProvider.SetError(mTBDate, "The Date cannot be part of the past, it must be only a present or future Date, althought not more than 100 years, verify and try again please.");
                                break;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                errorProvider.SetError(buttonCheck, "An Exception has Ocurred, these are the Details:\n" + ex.Source + "\n" + ex.Message);
            }
        }
        #endregion

        #region License Plate Verifier Method
        //Method that Verifies the Licence Plate has a right structure, otherwise gives an error to the User that they must fix. It return an int error code where 0->No Error, 1->The three first character are not only UPPERCASE letters, which it must be, 2->The License Plate is incomplete.
        private int licensePlateVerifier(string licensePlateNumber)
        {
            int errorResult = 0;
            if (licensePlateNumber.Length == 10)
            {   //It starts assigning the first three characters to a char array, then it runs to compare and verify it is between the A char and the Z char in the Asscii table, if not, sets the property IsLicensePlateOk to false and breaks the loop, it tests the boolean property and if it is false it sends the error code.
                char[] c = mTBLicensePlate.Text.Substring(0, 3).ToCharArray();
                for (int i = 0; i <= 2; i++)
                {
                    if (!((int)(c[i]) >= 65 && (int)(c[i]) <= 90))
                    {
                        IsLicensePlateOk = false;
                        break;
                    }
                }
                if (!IsLicensePlateOk) // Tests if there was an error in the three first characters, in that case sets the error code and finish the function, if not, it goes to verify the last 4 digits.
                {
                    errorResult = 1; //Sets the Error Code 1, indicates 1 or more of the 3 first characters are not only UPPERCASE chars.
                }
            }
            else
            {
                errorResult = 2; //Sets the Error Code 2, indicates the License Plate Number Field is incomplete.
            }
            return errorResult;
        }
        #endregion

        #region Date-Time Verifier and Final Verdict Engine
        private int dateTimeVerifierVerdictEngine(string givenDate, string givenTime, string licensePlateNumber)
        {   
            int errorResult = 0; //Variable to Set the Error Code Number.
            int keyNumber = Convert.ToInt32(licensePlateNumber.Substring(licensePlateNumber.Length - 1, 1)); //The Key Last Digit of the License Plate Number to be evaluated.
            DateTime rightNow = DateTime.Now;
            DateTime parsedEnteredDateTime; 
            String driverRestictedDay; //Day that is the one with Restricted Schedules for the Driver.
            String parsedDateDOW; //Day of the Week involved in the parsedEnteredDateTime.
            String[] rightWords = new String[2]; //String Array to save the right words to use in the Final Verdict (Hour/Hours, Minute/Minutes).
            TimeSpan timeUntilRestrictionRemaining; //TimeSpan variable to save The Time To next Restriction Beginning Schedule or the Remaining Restriction Time if Driver is Restricted.
            if (givenDate.Length == 10)
            {   //givenDate Breakdown / Apportionment. This Apportionment is for a better, and so much ease of issues detecting with the givenDate.
                int day = Convert.ToInt32(givenDate.Substring(0, 2)); //Converting to Int the String portion corresponding to every Date aspect for easy handling.
                int month = Convert.ToInt32(givenDate.Substring(3, 2));
                int year = Convert.ToInt32(givenDate.Substring(6, 4));
                int hours = Convert.ToInt32(givenTime.Substring(0, 2));
                int minutes = Convert.ToInt32(givenTime.Substring(3, 2));
                //DateTime Testing for Issues Detecting and Finally make a Verdict
                if (day > 0 && day <= 31)
                {
                    if (month > 0 && month <= 12)
                    {
                        if (year >= rightNow.Year && year <= (rightNow.Year + 100))
                        {
                            if (hours >= 0 && hours <= 23)
                            {
                                if (minutes >= 0 && minutes <= 59)
                                {
                                    parsedEnteredDateTime = dateTimeParser(givenDate + " " + givenTime); //Converting Strings to DateTime values, calling to the Converter/Parser. parsedEnteredDateTime is the Date combined with the Time entered by the User, to obtain a DateTime Object.
                                    driverRestictedDay = DaysByDigits[keyNumber]; //Knowing what is the Driver's Restriction Day.
                                    parsedDateDOW = parsedEnteredDateTime.DayOfWeek.ToString();
                                    if (parsedEnteredDateTime > rightNow) //Verifying the entered DateTime has not passed yet, otherwise and error is reported.
                                    {
                                        if (year >= (rightNow.Year + 70)) //Verifying the DateTime is not more than 70 years from the current DateTime, because it wouldn't make so much sense, if it is, the app is still working, but a little joke is launched :).
                                        {
                                            OldMan = true;
                                        }
                                        else
                                        {
                                            OldMan = false;
                                        }

                                        if (driverRestictedDay.Equals(parsedDateDOW, StringComparison.OrdinalIgnoreCase)) // Comparing Day Of Week independently of uppercase or lowercase, if true, it is the Restriction Day for the driver, so we continue with the Time Testing, but if not, it means it's not the Driver's Restriction Day and he/she is Authorized to Drive.
                                        {
                                            DateTime morningBeginTime = dateTimeParser(givenDate + " " + MorningScheduleBeginTime); //Structuring morning Restricted DateTime boundaries.
                                            DateTime morningEndTime = dateTimeParser(givenDate + " " + MorningScheduleEndTime);
                                            if (parsedEnteredDateTime >= morningBeginTime && parsedEnteredDateTime <= morningEndTime) //Testing if the Entered DateTime is in a morning Restriction Schedule Time, if not, I test with afternoon Schedule boundaries, otherwise the Driver is Authorized to Drive.
                                            {
                                                timeUntilRestrictionRemaining = morningEndTime - parsedEnteredDateTime;
                                                CloseToRestriction[0] = true; //The index 1 is not relevant here.
                                                closeToRestrictionRemainingTimeSetter(timeUntilRestrictionRemaining);
                                                youAreRestricted();
                                            }
                                            else
                                            {
                                                DateTime afternoonBeginTime = dateTimeParser(givenDate + " " + AfternoonScheduleBeginTime); //Structuring afternoon Restricted DateTime boundaries.
                                                DateTime afternoonEndTime = dateTimeParser(givenDate + " " + AfternoonScheduleEndTime);
                                                if (parsedEnteredDateTime >= afternoonBeginTime && parsedEnteredDateTime <= afternoonEndTime) //Testing with the afternoon Restricted Schedule Time.
                                                {
                                                    timeUntilRestrictionRemaining = afternoonEndTime - parsedEnteredDateTime;
                                                    CloseToRestriction[0] = false; //The index 1 is not relevant here.
                                                    closeToRestrictionRemainingTimeSetter(timeUntilRestrictionRemaining);
                                                    youAreRestricted();
                                                }
                                                else
                                                {
                                                    if (parsedEnteredDateTime > morningEndTime) //Now the Driver is Authorized to Drive, but here I'm testing if is there a next Restricted Schedule Time on this day?, if true, I calculate the time until the next Restricted Schedule Beginning.
                                                    {
                                                        if (parsedEnteredDateTime < afternoonBeginTime)
                                                        {
                                                            timeUntilRestrictionRemaining = afternoonBeginTime - parsedEnteredDateTime;
                                                            CloseToRestriction[0] = true; CloseToRestriction[1] = false; //Index 0-> If True, There is a Restriction close, otherwise there is not and the entered time is greater than 19:30. Index 1-> If the Index 0 is True, this index if True says that Morning Restriction is close, I mean the entered time is before the morning Restriction schedule, otherwise it says that Afternoon Restriction is close (the entered time is after the morning restriction schedule but before the afternoon restriction schedule).
                                                            closeToRestrictionRemainingTimeSetter(timeUntilRestrictionRemaining);
                                                        }
                                                        else
                                                        {
                                                            youAreAuthorized();
                                                        }
                                                    }
                                                    else if (parsedEnteredDateTime < morningBeginTime)
                                                    {
                                                        timeUntilRestrictionRemaining = morningBeginTime - parsedEnteredDateTime;
                                                        CloseToRestriction[0] = true; CloseToRestriction[1] = true;
                                                        closeToRestrictionRemainingTimeSetter(timeUntilRestrictionRemaining);
                                                    }
                                                    youAreAuthorized();
                                                }
                                            }
                                        }
                                        else
                                        {
                                            youAreAuthorized();
                                        }
                                    }
                                    else
                                    {
                                        errorResult = 7;
                                    }
                                }
                                else
                                {
                                    errorResult = 6;
                                }
                            }
                            else
                            {
                                errorResult = 5;
                            }
                        }
                        else
                        {
                            errorResult = 4;
                        }
                    }
                    else
                    {
                        errorResult = 3;
                    }
                }
                else
                {
                    errorResult = 2;
                }
            }
            else
            {
                errorResult = 1;
            }
            return errorResult;
        }

        //Converter/Parser to DateTime Objects.
        private DateTime dateTimeParser(string stringDate)
        {
            return DateTime.Parse(stringDate);
        }

        private void closeToRestrictionRemainingTimeSetter(TimeSpan timeUntilRestrictionRemainingHelper)
        {//The timeUntilRestrictionRemainingHelper is a TimeSpan variable which contains the Time until the Next Restriction Schedule Beginning or Time Remaining until the Current Restriction End.
         //Loop, to decide the right words to save in rightWordsSetter and this way the message is a more human natural talking and not so mechanich, it has the next Structure:
         //rightWordsSetter[0]-> Word Hours/Hour for the Time until the Next Restriction Schedule Beginning or Time Remaining until the Current Restriction End.
         //rightWordsSetter[0]-> Word Minutes/Minute for the Time until the Next Restriction Schedule Beginning or Time Remaining until the Current Restriction End.
            int hours = timeUntilRestrictionRemainingHelper.Hours, minutes = timeUntilRestrictionRemainingHelper.Minutes;
            String[] rightWordsSetter = new String[2];
            for (int i = 0; i < 2; i++) // Variable i is for running on timeUntilRestrictionRemainingHelper indexes.
            {
                if (i < 1) // Asking if i is 0 for Hour Parameter or 1 for Minute Parameter.
                {
                    if (hours > 1) 
                    {
                        rightWordsSetter[i] = "Hours";
                    }
                    else
                    {
                        rightWordsSetter[i] = "Hour";
                    }
                }
                else
                {
                    if (minutes > 1) 
                    {
                        rightWordsSetter[i] = "Minutes";
                    }
                    else
                    {
                        rightWordsSetter[i] = "Minute";
                    }
                }
            }
            //Formatting the right Close To Restriction or Remaining Time:
            if (hours == 0 && minutes >= 1)
            {
                CloseToRestrictionTimeRemaining = String.Format("{0:%m} {1}", timeUntilRestrictionRemainingHelper, rightWordsSetter[1]);
            } else if (hours >= 1 && minutes == 0)
            {
                CloseToRestrictionTimeRemaining = String.Format("{0:%h} {1}", timeUntilRestrictionRemainingHelper, rightWordsSetter[0]);
            } else if (hours >= 1 && minutes >= 1)
            {
                CloseToRestrictionTimeRemaining = String.Format("{0:%h} {1} and {2:%m} {3}", timeUntilRestrictionRemainingHelper, rightWordsSetter[0], timeUntilRestrictionRemainingHelper, rightWordsSetter[1]);
            }
        }
        #endregion

        #region Clear the Verdict
        private void mTBLicensePlate_TabIndexChanged(object sender, EventArgs e)
        {
            if (labelVerdict.Visible)
            {
                resultVisibilityReset();
            }
        }

        private void mTBDate_TextChanged(object sender, EventArgs e)
        {
            if (labelVerdict.Visible)
            {
                resultVisibilityReset();
            }
        }

        private void mTBTime_TextChanged(object sender, EventArgs e)
        {
            if (labelVerdict.Visible)
            {
                resultVisibilityReset();
            }
        }
        // Verdict Labels Reset to the default state
        private void resultVisibilityReset()
        {
            labelVerdict.Visible = false;
            labelCommentaries.Text = "•••";
        }
        #endregion

        #region Verdict Methods
        //Method that tells the Driver, he/she is Authorized to Drive on the Date-Time Entered.
        private void youAreAuthorized()
        {
            labelVerdict.Visible = true;
            labelVerdict.Text = "You are Authorized to Drive, Good Trip! : )";
            labelVerdict.ForeColor = holoGreenDark;
            if (OldMan)
            {
                labelCommentaries.Text = "Althought you're gonna be so old on that time... haha, anyway... Good Luck!, and be careful with your hips, cowboy... : )";
            }
            else
            {
                if (CloseToRestriction[0])
                {
                    if (CloseToRestriction[1])
                    {
                        labelCommentaries.Text = "But you are close to a Restriction Schedule, You have " + CloseToRestrictionTimeRemaining + " for your next Restricted Schedule, duration of restriction on Morning is 2 Hours and 30 Minutes, from 7:00 to 9:30, so it runs out faster, but have on mind that you have a Second Restriction on this Day that lasts 3 Hours and 30 Minutes, from 16:00 to 19:30, so be alert and don't be around the streets when Restriction Time arrives. Beware of traffic signs, drunk people and other factors when driving. Have a great day! and a secure trip : )";
                    }
                    else
                    {
                        labelCommentaries.Text = "But you are close to a Restriction Schedule, You have " + CloseToRestrictionTimeRemaining + " for your next Restricted Schedule, duration of restriction on Afternoon is 3 Hours and 30 Minutes, from 16:00 to 19:30, it's not so bad, time runs out faster than you think, just be alert and don't be around the streets when Restriction Time arrives. Beware of traffic signs, drunk people and other factors when driving. Have a great day! and a secure trip : )";
                    }
                }
                else
                {
                    labelCommentaries.Text = "Don't forget to beware of traffic signs, drunk people and other factors when driving, extra security is always good. Have a great day! and a secure trip : )";
                }
            }
        }

        //Method that tells the Driver he/she is NOT Authorized to Drive on the Date-Time Entered.
        private void youAreRestricted()
        {
            labelVerdict.Visible = true;
            labelVerdict.Text = "You are NOT Authorized to Drive on that Time";
            labelVerdict.ForeColor = redError;
            if (OldMan)
            {
                labelCommentaries.Text = "Wait for a little, time runs much more faster these days... Remember to Be patient and careful with the penalty fees, one is never too cautious... Don't forget to take your supplements as well, to be a man of almost a century has it's merit... haha... Good Luck! : )";
            }
            else
            {
                if (CloseToRestriction[0])
                {
                    labelCommentaries.Text = "Just wait for a while, Your Remaining Restriction Time is " + CloseToRestrictionTimeRemaining + ", until 9:30... but Time runs out faster on Morning... Remember to Be patient and careful with the penalty fees, one is never too cautious... Have on mind that you have a Second Restriction on this Day that lasts 3 Hours and 30 Minutes, from 16:00 to 19:30, so be alert and don't be around the streets when Restriction Time arrives. When your Restricted Time ends, if you plan to drive... Beware of traffic signs, drunk people and other factors when driving. Have a great day! and a secure trip : )";
                }
                else
                {
                    labelCommentaries.Text = "Just wait for a while, Your Remaining Restriction Time is " + CloseToRestrictionTimeRemaining + ", until 19:30... but Time runs out fast these days... Remember to Be patient and careful with the penalty fees, one is never too cautious... When your Restricted Time ends, if you plan to drive... Beware of traffic signs, drunk people and other factors when driving. Have a great day! and a secure trip : )";
                }
            }
        }
        #endregion

        #region Public Testing Methods
        public int licensePlateVerifierTest(string plate)
        {
            return licensePlateVerifier(plate);
        }

        public int dateTimeVerifierVerdictEngineTest(string givenDate, string givenTime, string licensePlateNumber)
        {
            return dateTimeVerifierVerdictEngine(givenDate,givenTime,licensePlateNumber);
        }
        #endregion

    }
}