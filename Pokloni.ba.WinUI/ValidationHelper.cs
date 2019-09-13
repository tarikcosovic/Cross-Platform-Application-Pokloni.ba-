using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokloni.ba.WinUI
{
    public static class ValidationHelper
    {
        public static bool NotNull(TextBox[] model, ErrorProvider errorProvider)
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

        public static bool LengthCheck(TextBox[] model, ErrorProvider errorProvider, int min = 3, int max = 100)
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

        public static bool ValidateTextBoxes(TextBox[] temp, ErrorProvider errorProvider)
        {
            if (NotNull(temp, errorProvider) && LengthCheck(temp, errorProvider))
                return true;

            return false;
        }
    }
}
