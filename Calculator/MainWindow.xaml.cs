using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnEen.Click += BtnEen_Click;
            btnTwee.Click += BtnTwee_Click;
            btnDrie.Click += BtnDrie_Click;
            btnVier.Click += BtnVier_Click;
            btnVijf.Click += BtnVijf_Click;
            btnZes.Click += BtnZes_Click;
            btnZeven.Click += BtnZeven_Click;
            btnAcht.Click += BtnAcht_Click;
            btnNegen.Click += BtnNegen_Click;
            btnNul.Click += BtnNul_Click;
            ClearLabel.Click += ClearLabel_Click;
            ClearAll.Click += ClearAll_Click;
            btnPunt.Click += BtnPunt_Click;
            OperatorPlus.Click += OperatorPlus_Click;
            OperatorMin.Click += OperatorMin_Click;
            OperatorKeer.Click += OperatorKeer_Click; ;
            OperatorDelen.Click += OperatorDelen_Click;
            btnResult.Click += BtnResult_Click;
            ConvertNumer.Click += ConvertNumer_Click;
        }

        public void ConvertNumer_Click(object sender, RoutedEventArgs e)
        {
            if (lblvenster.Content.ToString().Contains("-"))
            {
                lblvenster.Content = lblvenster.Content.ToString().Replace("-","");
            } else
            {
                lblvenster.Content = "-";
            }     
        }

        private void BtnResult_Click(object sender, RoutedEventArgs e)
        {
            if (lblVensterDrie.Content.ToString().Contains("+"))
            {
                double num1 = Convert.ToDouble(lblvenster.Content);
                double num2 = Convert.ToDouble(lblvensterTwee.Content);
                double num3 = num2 + num1;
                lblvenster.Content = Convert.ToDouble(num3);
                lblvensterTwee.Content = "";
                lblVensterDrie.Content = "";
            } else if(lblVensterDrie.Content.ToString().Contains("-"))
            {
                double num1 = Convert.ToDouble(lblvenster.Content);
                double num2 = Convert.ToDouble(lblvensterTwee.Content);
                double num3 = num2 - num1;
                lblvenster.Content = Convert.ToDouble(num3);
                lblvensterTwee.Content = "";
                lblVensterDrie.Content = "";
            }
            else if (lblVensterDrie.Content.ToString().Contains("x"))
            {
                double num1 = Convert.ToDouble(lblvenster.Content);
                double num2 = Convert.ToDouble(lblvensterTwee.Content);
                double num3 = num2 * num1;
                lblvenster.Content = Convert.ToDouble(num3);
                lblvensterTwee.Content = "";
                lblVensterDrie.Content = "";
            }
            else if (lblVensterDrie.Content.ToString().Contains(":"))
            {
                double num1 = Convert.ToDouble(lblvenster.Content);
                double num2 = Convert.ToDouble(lblvensterTwee.Content);
                double num3 = num2 / num1;
                lblvenster.Content = Convert.ToDouble(num3);
                lblvensterTwee.Content = "";
                lblVensterDrie.Content = "";
            }

        }

        private void OperatorDelen_Click(object sender, RoutedEventArgs e)
        {
            string num1 = lblvenster.Content.ToString();
            lblvensterTwee.Content = num1;
            lblvenster.Content = "0";
            lblVensterDrie.Content = ":";
        }

        private void OperatorKeer_Click(object sender, RoutedEventArgs e)
        {
            string num1 = lblvenster.Content.ToString();
            lblvensterTwee.Content = num1;
            lblvenster.Content = "0";
            lblVensterDrie.Content = "x";
        }

        private void OperatorPlus_Click(object sender, RoutedEventArgs e)
        {
            string num1 = lblvenster.Content.ToString();
            lblvensterTwee.Content = num1;
            lblvenster.Content = "0";
            lblVensterDrie.Content = "+";
        }
        private void OperatorMin_Click(object sender, RoutedEventArgs e)
        {
            string num1 = lblvenster.Content.ToString();
            lblvensterTwee.Content = num1;
            lblvenster.Content = "0";
            lblVensterDrie.Content = "-";
        }

        private void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            lblvenster.Content = "0";
            lblvensterTwee.Content = "";
            lblVensterDrie.Content = "";
        }

        private void BtnPunt_Click(object sender, RoutedEventArgs e)
        {
            if (lblvenster.Content.ToString().Contains(","))
            {

            } else
            {
                PlaatsVenster(",");
            }
        }

        private void ClearLabel_Click(object sender, RoutedEventArgs e)
        {
            lblvenster.Content = "0";
        }

        private void BtnNul_Click(object sender, RoutedEventArgs e)
        {
            PlaatsVenster("0");
        }

        private void BtnNegen_Click(object sender, RoutedEventArgs e)
        {
            PlaatsVenster("9");
        }

        private void BtnAcht_Click(object sender, RoutedEventArgs e)
        {
            PlaatsVenster("8");
        }

        private void BtnZeven_Click(object sender, RoutedEventArgs e)
        {
            PlaatsVenster("7");
        }

        private void BtnZes_Click(object sender, RoutedEventArgs e)
        {
            PlaatsVenster("6");
        }

        private void BtnVijf_Click(object sender, RoutedEventArgs e)
        {
            PlaatsVenster("5");
        }

        private void BtnVier_Click(object sender, RoutedEventArgs e)
        {
            PlaatsVenster("4");
        }

        private void BtnDrie_Click(object sender, RoutedEventArgs e)
        {
            PlaatsVenster("3");
        }

        private void BtnTwee_Click(object sender, RoutedEventArgs e)
        {
            PlaatsVenster("2");
        }

        private void BtnEen_Click(object sender, RoutedEventArgs e)
        {
            PlaatsVenster("1");
        }
        private void PlaatsVenster(string Waarde)
        {
            if(lblvenster.Content.ToString() == "0" && Waarde != ",")
            {
                lblvenster.Content = Waarde;
            } else
            {
                lblvenster.Content += Waarde;
            }
        }
    }
}
