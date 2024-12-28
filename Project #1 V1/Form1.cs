/*
 * ICT 710
 * Assignment #1 - Simple GUI application for payroll
 * Specifically this application will allow a user to input the standard hours worked into a terminal
 * The terminal will then split out the regular hours and overtime hours
 * It will further display the total regular pay and overtime pay using the constants noted below
 * Further, CRA payroll witholdings, Canadian Pension Plan (CPP) and Employment Insurance (EI) witholdings will be calculated
 * Finally the net cash pay to the employee will be presented 
 * The terminal will also have a clear button in the event a incorrect figure is entered and a exit button to terminate the program
 * Contstants: 
 *      Regular rate per hour is $20 and the overtime rate is time and a half at $30 per hour
 *      CRA witholdings are calculated at 20% (technically this is not correct as witholdings are based on income bracket but that kind of calculation 
 *      is beyond the scope of this project
 *      CPP is calculated at 5.95% of regular pay (technically there is a CPP cap  but implementing that into the code below
 *      is beyonf the scope of this project
 *      EI is calcualted at the 2024 rate of 1.64% of net pay for the employee portion 
 * 
 * By: Brandon Collette
 * Calgary, Alberta
 * October 2024
 */

namespace Project__1_V1
{
    public partial class frmWeeklypayroll : Form
    {
        public frmWeeklypayroll()
        {
            InitializeComponent();
        }

        // The below is the event handler for the calculate button and virtually all the core of the program is contained within this handler
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /* 
            * We now need to declare many variables 
            * All of the below need to be declared because the code below will perform certain calculations based on these variables 
            * i.e. CPP cannot be calculated without reference to the total amount paid etc
            * If we did not declare all these variables the program "would not have what is needs" to calculate the output
            * this is a variable declaration for hours worked to be in the decimal format
            * this is being declared as a decimal to allow for the input of a non-whole number
            * What we are saying is "we formally identify the variable Hoursworked to be of type decimal
            */
            decimal Hoursworked; // this needs to be in the decimal format to allow for a decimal (i.e. non-whole number)
            decimal regularPay = 0m; // Clears regularPay to 0. The m after 0 is required for the C# program to be able to identify the character as a actual decimal number
            decimal overtimePay = 0m; // See above comment
            decimal regularHoursCap = 37.5m; // we will see below this cap figure needs to be defined so that it can be used in certain calculations below
            decimal totalPay; // this needs to be in the decimal format to allow for a decimal (i.e. non-whole number)
            decimal witholdings; // this needs to be in the decimal format to allow for a decimal (i.e. non-whole number)
            decimal CPP; // this needs to be in the decimal format to allow for a decimal (i.e. non-whole number)
            decimal EI; // this needs to be in the decimal format to allow for a decimal (i.e. non-whole number)
            decimal netpay; // this needs to be in the decimal format to allow for a decimal (i.e. non-whole number)

            /* 
             * We now need to declare constants. I will declare 2 - The rate of pay per hour and the rate of overtime pay
             * 1) The fixed rate of pay 
             * 2) The OT pay at the time and half rate of the regular pay
             * NOTE: I am not declaring a constant of regular hours worked because my variable declaration above for regular hours also sets the amount at 37.5
             */
            const decimal ratePerHour = 20m; // This establishes regular pay at $20 per hour
            const decimal otratePerHour = ratePerHour * 1.5m; // This establishes OT pay at 1.5x the regular pay

            // Now that the variables and constants have been declared the core code will follow:   

            /* 
             * The below tells the program to "fetch" what is input into the text box txtHrsworked and convtert the number to a decimal
             * It further then assigns the variable from this text box to be type Hoursworked 
             * This is necessary so that C# can use this value we now call Hoursworked to perform other logical operations with it 
            */

            Hoursworked = Convert.ToDecimal(txtHrsworked.Text);

            /*
             * The below IF statement accomplishes the following: IF the hours entered are below the standard of 37.5 it
             * will simply take that figure and present it in the text box we named txtRghours 
             * however IF the number entered is larger than 37.5 there is a else statement that will populate the regular 
             * hours with the max amount of 37.5 and then take the total hours less this 37.5 amount and place this value 
             * in the text box we named txtOThrs
             * All of this is done just so that the regular hours and total hours will be displayed in their applicable text boxes
            */

            if (Hoursworked <= 37.5m)
            {
                txtRghours.Text = Hoursworked.ToString();
            }
            else
            {
                txtRghours.Text = "37.5";
                txtOThrs.Text = (Hoursworked - 37.5m).ToString();
            }
            /*
             * We now need a second IF statement to deal with the two "buckets" of hours that have been calculated in the above IF statement
             * This second one should accomplish the following
             * 1) Reference the calculated regular hours worked and multiply by the constant declared for regular pay IF the hours are at or below
             *    the regular hours cap we established above (37.5)  
             * 2) Reference the calculated overtime hours worked and multiply by the constant declared for overtime pay, just for the portion of 
             *    hours above the regular hours cap and multiply by the overstime constant declared above
             */

            if (decimal.TryParse(txtHrsworked.Text, out Hoursworked))
            /*
             * The above line of code presents a complication. If I do not use the above statement a critical error will be produded 
             * that I tried to resolve but could not. The error that will occur without this line is that the program will state
             * "overtimePay is declared but not used" and will not be able to use the "else" portion of my IF statement below
             * I tried to see why it was doing this and I could see no difference between "overtimePay" and "regularPay" BUT 
             * "regularPay" works just fine. Once I could not resolve this particular issue I asked a AI chatbot why it was doing this 
             * and it gave me the above suggestion which resolved the problem. I still do not see what the issue is and therefore the above
             * line of code is the only portion that I do not really understand
             * One of the things the AI suggested to me was that "overtimePay" was only contained within the "else" portion of the statement
             * and is therefore not visible outside the "else" statement. I tried to move it up but then the entire IF statement would not work
             */
            {

                if (Hoursworked <= regularHoursCap)
                {
                    regularPay = Hoursworked * ratePerHour; // Calculates the standard pay if no overtime hours have been worked
                }

                else
                {
                    regularPay = regularHoursCap * ratePerHour; // Calculates the pay amount up to the standard 37.5 hours using the regular rate
                    decimal overtimehours = Hoursworked - regularHoursCap; // Calculates the number of overtime hours worked
                    overtimePay = overtimehours * otratePerHour; // Calculates the pay amount just for the portion above 37.5 hours using the OT rate
                }

                totalPay = regularPay + overtimePay; // This calculates total pay based on regular hours below the cap
                witholdings = -totalPay * 0.2m; // This calculates the 20% CRA payroll witholdings based on the total pay
                CPP = -totalPay * 0.0595m; // This calculates the 5.95% CPP witholdings based on the total pay
                EI = -totalPay * 0.0164m; // This calcualtes the 1.64% EI witholdings based on the total pay
                netpay = totalPay + witholdings + CPP + EI; // This takes the total pay, subtracts the witholdings, CPP and EI for net cash to employee

                /*
                 * Now that the calculations are performed using the code above, the final step is to "flush" the results
                 * to their respective text box. Each of the below statements gives a "command" to each of the non-hours based text boxes
                 * to become populated with the results of our calculations above
                */

                txtRgpay.Text = regularPay.ToString("C");
                txtOTpay.Text = overtimePay.ToString("C");
                txtTotalpay.Text = totalPay.ToString("C");
                txtTaxwitheld.Text = witholdings.ToString("C");
                txtCPP.Text = CPP.ToString("C");
                txtEI.Text = EI.ToString("C");
                txtNetpay.Text = netpay.ToString("C");

            }

            /* The below event handler will clear all inputed and calculated information (if applicable) in case the user enters a incorrect number
             * It works as follows: 
             *  - identifies the button that we inserted into our form and named "btnClear" 
             *  - the underscore _Click is the code within C# that indicates "what to do" when the button is clicked on
             *  - it goes on to list one by one all the text boxes we added to our form
             *  - the .Clear() is the way C# is programmed to remove the contents of whatever is in those boxes
            */

        }

        // The below is the event handler for the exit button and will serve to terminate the program when the user clicks the exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // the below event handler functions to clear anything input or calcualted in any of the text boxes at anytime in the program
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHrsworked.Clear();
            txtRghours.Clear(); 
            txtOThrs.Clear();
            txtRgpay.Clear();
            txtOTpay.Clear();
            txtTotalpay.Clear();    
            txtTaxwitheld.Clear();
            txtCPP.Clear();
            txtEI.Clear();
            txtNetpay.Clear();
        }
    }
}