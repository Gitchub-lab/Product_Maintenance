using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lab3_ProductMaintenance
{
    /// <summary>
    /// 
    /// Author: Cecilia Santiago    
    /// 
    /// Validates the ff:
    /// if Product Code is empty
    /// if Product Code is longer than 10 characters
    /// if Name is empty
    /// if Name is longer than 50 characters
    /// if Version is empty
    /// if Version contains an alpha
    /// if Version is negative
    /// if Version has more than 1 decimal place
    /// if Date is not in a valid format
    /// </summary>
    /// <returns>invalid if above condition is met otherwise data input is valid</returns>
    public static class Validator
    {
        private static decimal tmpversion = 0.0m;           //temporary placeholder for Version
        public static bool IsPresent(TextBox tb, Label lb)
        {
            bool result = true; // Text is not empty
            lb.Visible = false;
            if (tb.Text == "")
            {
                lb.Text = tb.Tag + " must be provided";
                lb.Visible = true;                
                result = false; // Text is empty
            }
            
            return result;
        }

        public static bool IsMore10(TextBox tb, Label lb)
        {
            bool result = true; // Text  is less than 10 characters
            lb.Visible = false;
            if (tb.TextLength > 10)
            {
                //MessageBox.Show(tb.Tag + " cannot be more than 10 characters", "Input Error");
                lb.Text = tb.Tag + " cannot be more than 10 characters";
                lb.Visible = true;
                result = false; // Text is more than 10 characters
            }

            return result;
        }

        public static bool IsMore50(TextBox tb, Label lb)
        {
            bool result = true; // Text  is less than 50 characters
            lb.Visible = false;
            if (tb.TextLength > 50)
            {
                lb.Text = tb.Tag + " cannot be more than 50 characters";
                lb.Visible = true;
                result = false; // Text is more than 50 characters
            }

            return result;
        }

        public static bool IsNotAlpha(TextBox tb, Label lb)
        {
            bool result = true;
            lb.Visible = false;
            try
            {
                tmpversion = Convert.ToDecimal(tb.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");

                lb.Text = tb.Tag + " can only have decimal value";
                lb.Visible = true;
                result = false;                      // This is positive, has to be double
                
            }
            return result;
        }

        public static bool IsPositive(TextBox tb, Label lb)
        {
            bool result = true;
            lb.Visible = false;
            tmpversion = Convert.ToDecimal(tb.Text);            
            if (tmpversion < 1)
            {
                lb.Text = tb.Tag + " has to be greater than 0";
                lb.Visible = true;
                result = false;                      // This is negative, has to be numeric
            }
             
            return result;
        }

        public static bool IsDecimal(TextBox tb, Label lb)
        {
            Regex reg = new Regex(@"\d{1,18}\.\d{1}$");
            bool result = reg.IsMatch(tb.Text.Trim());
            lb.Visible = false;
            if (!result)
            {
                lb.Text = tb.Tag + " has to have 1 decimal place";
                lb.Visible = true;
                result = false;
            }

            return result;
        }

        public static bool IsValidDate(string Text, Label lb)
        {                       
            Regex reg = new Regex(@"\b(?<year>\d{4})-(?<month>\d{2})-(?<day>\d{2})\b");
            bool result = reg.IsMatch(Text.Trim());
            lb.Visible = false;
            if (!result)
            {
                lb.Text = "Date is not valid";
                lb.Visible = true;
                result = false;
            }
                        
            return result;           

        }

        public static bool IsValidDateEmpty(string Text, Label lb)
        {
            bool result = true;
            lb.Visible = false;
            if (Text == "    ")
            {
                lb.Text = "Date cannot be blank";
                lb.Visible = true;
                result = false;
            }

            return result;

        }

    }
}
