using MaterialSkin;
using MaterialSkin.Controls;

namespace Pokloni.ba.WinUI
{
    public class MyMaterialForm : MaterialForm
    {
        private MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        public void InitialiseMyMaterialDesign(MaterialForm form)
        {
            materialSkinManager.AddFormToManage(form);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.DeepPurple500, Primary.DeepPurple700,
                Primary.DeepPurple500, Accent.Purple200,
                TextShade.WHITE
                );
        }
    }
}
