using System;
using Microsoft.Maui.Controls;

namespace Odev1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnAddClicked(object sender, EventArgs e)
        {
            if (double.TryParse(FirstNumberEntry.Text, out double firstNumber) &&
                double.TryParse(SecondNumberEntry.Text, out double secondNumber))
            {
                double result = firstNumber + secondNumber;
                ResultLabel.Text = "Sonuç: " + result.ToString();
            }
            else
            {
                ResultLabel.Text = "Lütfen geçerli sayılar girin.";
            }
        }

        private void OnSubtractClicked(object sender, EventArgs e)
        {
            if (double.TryParse(FirstNumberEntry.Text, out double firstNumber) &&
                double.TryParse(SecondNumberEntry.Text, out double secondNumber))
            {
                double result = firstNumber - secondNumber;
                ResultLabel.Text = "Sonuç: " + result.ToString();
            }
            else
            {
                ResultLabel.Text = "Lütfen geçerli sayılar girin.";
            }
        }

        private void OnMultiplyClicked(object sender, EventArgs e)
        {
            if (double.TryParse(FirstNumberEntry.Text, out double firstNumber) &&
                double.TryParse(SecondNumberEntry.Text, out double secondNumber))
            {
                double result = firstNumber * secondNumber;
                ResultLabel.Text = "Sonuç: " + result.ToString();
            }
            else
            {
                ResultLabel.Text = "Lütfen geçerli sayılar girin.";
            }
        }

        private void OnDivideClicked(object sender, EventArgs e)
        {
            if (double.TryParse(FirstNumberEntry.Text, out double firstNumber) &&
                double.TryParse(SecondNumberEntry.Text, out double secondNumber))
            {
                if (secondNumber != 0)
                {
                    double result = firstNumber / secondNumber;
                    ResultLabel.Text = "Sonuç: " + result.ToString();
                }
                else
                {
                    ResultLabel.Text = "Bir sayı sıfıra bölünemez.";
                }
            }
            else
            {
                ResultLabel.Text = "Lütfen geçerli sayılar girin.";
            }
        }
    }
}
