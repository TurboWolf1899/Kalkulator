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
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            //zbrajanje
            double zbroj= Convert.ToDouble(textBox1.Text)+Convert.ToDouble(textBox2.Text);
            textBlock1.Text = zbroj.ToString();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            //oduzimanje
            double razlika = Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text);
            textBlock1.Text = razlika.ToString();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            //mnonženje
            double umnozak = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text);
            textBlock1.Text = umnozak.ToString();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            //dijeljenje
            double kolicnik = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text);
            textBlock1.Text = kolicnik.ToString();
        }

        private void Radio1_Checked(object sender, RoutedEventArgs e)
        {
            //DEC
            Convert.ToString(textBlock1.Text);
            Console.WriteLine(textBlock1.Text);
        }

        private void Radio2_Checked(object sender, RoutedEventArgs e)
        {
            //BIN
            Convert.ToString(textBlock1.Text);
            Console.WriteLine(textBlock1.Text, 2);
        }

        private void Radio3_Checked(object sender, RoutedEventArgs e)
        {
            //OCT
            Convert.ToString(textBlock1.Text);
            Console.WriteLine(textBlock1.Text, 8);
        }

        private void Radio4_Checked(object sender, RoutedEventArgs e)
        {
            //HEX
            Convert.ToString(textBlock1.Text);
            Console.WriteLine(textBlock1.Text, 16);
        }
    }
}
