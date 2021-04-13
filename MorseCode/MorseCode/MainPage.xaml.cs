using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MorseCode
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }
        private string code = "";
        private string theWord = "";

        private void DashClick(object sender, EventArgs e)
        {
            code += "-";
            morseLabel.Text = code;
        }
        private void DotClick (object sender, EventArgs e)
        {
            code += ".";
            morseLabel.Text = code;
        }
        private void SpaceClick(object sender, EventArgs e)
        {
            char newLetter = Morse.MorseCoder(code);
            code = morseLabel.Text = "";
            theWord += newLetter;
            word.Text = theWord;

        }
      
    }
}
