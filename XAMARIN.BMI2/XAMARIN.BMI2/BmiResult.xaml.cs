using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XAMARIN.BMI2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BmiResult : ContentPage
    {
        private float height;
        private int weight;

        public BmiResult()
        {
            InitializeComponent();
            buttonBack.Clicked += buttonBackClicked;
        }

        public BmiResult(float height,int weight)
        {
            InitializeComponent();
            this.height = height;
            this.weight = weight;
            

            if (height <= 3)
            {
                labelBMI.Text = "BMI=" + weight / (height * height);
                float BMI = +weight / (height * height);
            }
            else
            {
                height = height / 100;
                labelBMI.Text = "BMI=" + weight / (height * height);
                float BMI = +weight / (height * height);
            }

        }

        private void buttonBackClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}