using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MorseCoder
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        string code = "";
        string message = "";
        void Dot_Clicked(object sender, System.EventArgs e)
        {
            code += ".";
            output_code.Text = code;
        }
        void Dash_Clicked(object sender, System.EventArgs e)
        {
            code += "-";
            output_code.Text = code;
        }
        void Space_Clicked(object sender, System.EventArgs e)
        {
            message += Morse.MorseCoder(code);
            output.Text = message;
            code = "";
            output_code.Text = code;
        }
    }
}
