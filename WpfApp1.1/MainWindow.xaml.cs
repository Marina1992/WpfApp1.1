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
using System.Data;

namespace WpfApp1._1
{
    
    public partial class MainWindow : Window
    {
        double num1 = 0;// поле (1 число)
        double num2 = 0;// поле (2 число)
        string op = "";// операция, которую ввел пользователь  
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_num_Click(object sender, RoutedEventArgs e)
        {

            Button button = (Button)sender;
            String num = button.Content.ToString();

            if (txtValue.Text == "0")
                txtValue.Text = num;
            else
                txtValue.Text += num;


            if (op == "") // если операция отсутствовала, то работали с num1

            {

                num1 = Double.Parse(txtValue.Text);
            }

            else
            {
                num2 = Double.Parse(txtValue.Text);


            }
        }


        private void btn_op_Click(object sender, RoutedEventArgs e)
        {

            Button button = (Button)sender;
            op = button.Content.ToString();
            txtValue.Text = "0";
        }

        private void btn_eq_Click(object sender, RoutedEventArgs e)
        {
            double result = 0;
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;

                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;

                case "-":
                    result = num1 - num2;
                    break;

                
            }

            txtValue.Text = result.ToString();
            op = ""; // обнулить операцию
            num1 = result;
            num2 = 0;
        }

                      
             
               

        private void btn_comma_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
                SetComma(num1);
            else
                SetComma(num2);
        }

        private void SetComma(double num)
        {


            if (txtValue.Text.Contains(','))
                return;

            txtValue.Text += ',';
        }
    }

}

