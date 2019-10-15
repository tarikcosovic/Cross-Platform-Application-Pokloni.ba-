using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.OS;
using MobileApp.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(EntryRenderer), typeof(WhiteEntry))]
namespace MobileApp.Droid.CustomRenderers
{
    public class WhiteEntry : EntryRenderer
    {

        public WhiteEntry(Context context):base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if(e.NewElement!=null)
            {
                if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
                    Control.BackgroundTintList = ColorStateList.ValueOf(Android.Graphics.Color.White);
                else
                    Control.Background.SetColorFilter(Android.Graphics.Color.White, PorterDuff.Mode.SrcAtop);
            }
        }
    }
}