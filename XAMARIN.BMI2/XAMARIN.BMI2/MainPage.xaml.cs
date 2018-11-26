using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XAMARIN.BMI2
{
    public partial class MainPage : ContentPage
    { 

        public MainPage()
        {
            InitializeComponent();
            ButtonBMI.Clicked += ButtonClickEvent;
            ButtonBMI2.Clicked += ButtonClickEvent2;
        }

        public void ButtonClickEvent2(object sender, EventArgs e)
        {
            float height = float.Parse(EntryHeight.Text);
            int weight = int.Parse(EntryWeight.Text);
            Navigation.PushModalAsync(new NavigationPage(new BmiResult(height,weight)));
        }

        public void ButtonClickEvent(object sender, EventArgs e)
        {
            float height = float.Parse(EntryHeight.Text);
            int weight = int.Parse(EntryWeight.Text);

            if (height <= 3) {
                LabelResult.Text = "BMI=" + weight / (height * height);
                float BMI = +weight / (height * height);
            }
            else
            {
                height = height / 100;
                LabelResult.Text = "BMI=" + weight / (height * height);
                float BMI = +weight / (height * height);
            }

            

        }
    }
}
