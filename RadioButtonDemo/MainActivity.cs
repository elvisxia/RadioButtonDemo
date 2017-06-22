using Android.App;
using Android.Widget;
using Android.OS;

namespace RadioButtonDemo
{
    [Activity(Label = "RadioButtonDemo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        RadioGroup radioGroup;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            radioGroup = FindViewById<RadioGroup>(Resource.Id.mGroup);

            for (int i = 0; i < radioGroup.ChildCount; i++)
            {
                var child=radioGroup.GetChildAt(i);
                if (child is RadioButton)
                {
                    ((RadioButton)child).FocusChange += RadioButton_FocusChange;
                }
            }
        }
        

        private void RadioButton_FocusChange(object sender, Android.Views.View.FocusChangeEventArgs e)
        {
            if (e.HasFocus){
                ((RadioButton)sender).Checked = true;
            }
        }
    }
}

