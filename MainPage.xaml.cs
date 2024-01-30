using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Kalkulator
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            // Zbrajanje
            double zbroj = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text);
            textBlock1.Text = zbroj.ToString();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            // Oduzimanje
            double razlika = Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text);
            textBlock1.Text = razlika.ToString();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            // Množenje
            double umnozak = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text);
            textBlock1.Text = umnozak.ToString();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            // Dijeljenje
            double kolicnik = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text);
            textBlock1.Text = kolicnik.ToString();
        }

        private void Radio1_Checked(object sender, RoutedEventArgs e)
        {
            // DEC
            textBlock1.Text = Convert.ToDouble(textBlock1.Text).ToString();
        }

        private void Radio2_Checked(object sender, RoutedEventArgs e)
        {
            // BIN
            int decimalnaVrijednost = Convert.ToInt32(textBlock1.Text);
            textBlock1.Text = Convert.ToString(decimalnaVrijednost, 2);
        }

        private void Radio3_Checked(object sender, RoutedEventArgs e)
        {
            // OCT
            int decimalnaVrijednost = Convert.ToInt32(textBlock1.Text);
            textBlock1.Text = Convert.ToString(decimalnaVrijednost, 8);
        }

        private void Radio4_Checked(object sender, RoutedEventArgs e)
        {
            // HEX
            int decimalnaVrijednost = Convert.ToInt32(textBlock1.Text);
            textBlock1.Text = Convert.ToString(decimalnaVrijednost, 16);
        }
    }
}