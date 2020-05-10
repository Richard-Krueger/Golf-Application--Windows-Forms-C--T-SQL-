using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using TextBox = System.Windows.Forms.TextBox;

namespace RealGolfApp
{
    public static class Validator
    {

        private static string title = "Entry Error";

        public static string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        //check if textBox has value
        public static bool IsPresent(TextBox textBox)
        {
            if (textBox.Text == "" || textBox.Text is null)
            {
                MessageBox.Show(textBox.Tag + " is a required field.", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }

        //check if input can be converted to integer
        public static bool IsInt32(TextBox textBox)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be an positive integer.", Title);
                textBox.Focus();
                return false;
            }
        }

        //check if input can be converted to decimal
        public static bool IsDecimal(TextBox textBox)
        {
            decimal number = 0;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be a decimal value.", Title);
                textBox.Focus();
                return false;
            }
        }

        //check that desired password has one capital letter, one lowercase letter, one number, and one special character; length is between 8 and 16 characters
        public static bool IsStrongPassword(TextBox textBox)
        {
            MessageBox.Show(textBox.Tag + " must contain one uppercase letter, one lowercase letter, one number, and one special character.", Title);
            textBox.Focus();
            return Regex.IsMatch(textBox.Text, @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*+-]).{8,16}$");
        }

        //check string does contain characters that would allow SQL injection
        public static bool DoesContain(TextBox textBox)
        {
            return Regex.IsMatch(textBox.Text, @"^(?=.*?[';:,\\])$");
        }

        //check string meets required length
        public static bool IsLength(TextBox textBox, int min, int max)
        {
            string str = textBox.Text;

            if (str.Length < min || str.Length > max)
            {
                MessageBox.Show(textBox.Tag + " must be between " + min + " and " + max + " in length.", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }

        //validate that initial passwords match before storing
        public static bool IsMatch(TextBox textBox1, TextBox textBox2)
        {
            if (textBox1.Text != textBox2.Text)
            {
                MessageBox.Show(textBox1.Tag + " and " + textBox2.Tag + " must match.", Title);
                textBox2.Focus();
                return false;
            }
            return true;
        }
    }
}
