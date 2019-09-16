using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokloni.ba.WinUI
{
    public static class ValidationHelper
    {
        public static bool NotNull(MaterialSingleLineTextField[] model, ErrorProvider errorProvider)
        {
            foreach (var item in model)
            {
                if (string.IsNullOrWhiteSpace(item.Text))
                {
                    errorProvider.SetError(item, "Obavezno polje");
                    return false;
                }
                else
                {
                    errorProvider.SetError(item, null);
                }
            }
            return true;
        }

        public static bool LengthCheck(MaterialSingleLineTextField[] model, ErrorProvider errorProvider, int min = 3, int max = 100)
        {
            foreach (var item in model)
            {
                if (item.Text.Length <= min)
                {
                    errorProvider.SetError(item, "Text treba da sadrži najmanje " + min + " karaktera");
                    return false;
                }
                else if (item.Text.Length >= max)
                {
                    errorProvider.SetError(item, "Text treba da sadrži najviše " + max + " karaktera");
                    return false;
                }
                else
                {
                    errorProvider.SetError(item, null);
                }
            }
            return true;
        }
        public static bool PasswordCheck(string first, string second,Control control, ErrorProvider errorProvider)
        {
            if (first.Equals(second))
                return true;
            else
            {
                errorProvider.SetError(control, "Lozinke nisu jednake");
                return false;
            }
        }
        public static bool EmailCheck(string email, Control control, ErrorProvider errorProvider)
        {
            bool isEmail = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (isEmail)
                return true;
            else
            {
                errorProvider.SetError(control, "Email adresa nije validna");
                return false;
            }
        }

        public static bool ValidateTextBoxes(MaterialSingleLineTextField[] temp, ErrorProvider errorProvider)
        {
            if (NotNull(temp, errorProvider) && LengthCheck(temp, errorProvider))
                return true;

            return false;
        }
    }
}
