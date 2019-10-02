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

namespace BienFuntion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void showIntValue()
        {
            int intVar;
            intVar = 42;
            value.Text = intVar.ToString();
        }

        private void showLongValue()
        {
            long longVar;
            longVar = 42L;
            value.Text = longVar.ToString();
        }

        private void showFloatValue()
        {
            float floatVar;
            floatVar = 0.42F; // thêm F sau 42 để phân biệt với kiểu double
            value.Text = floatVar.ToString();
        }

        private void showDoubleValue()
        {
            double doubleVar;
            doubleVar = 0.42;
            value.Text = doubleVar.ToString();
        }

        private void showDecimalValue()
        {
            decimal decimalVar;
            decimalVar = 0.42M; // thêm M sau 42 để phân biệt với kiểu
            // double, float
            value.Text = decimalVar.ToString();
        }

        private void showStringValue()
        {
            string stringVar;
            stringVar = "forty two";
            value.Text = stringVar; // không cần dùng ToString
        }

        private void showCharValue()
        {
            char charVar;
            charVar = 'x';
            value.Text = charVar.ToString();
        }

        private void showBoolValue()
        {
            bool boolVar;
            boolVar = false;
            value.Text = boolVar.ToString();
        }
        private void quit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void type_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem selectedType = (type.SelectedItem as ListBoxItem);
            switch (selectedType.Content.ToString())
            {
                case "int":
                    showIntValue();
                    break;
                case "long":
                    showLongValue();
                    break;
                case "float":
                    showFloatValue();
                    break;
                case "double":
                    showDoubleValue();
                    break;
                case "decimal":
                    showDecimalValue();
                    break;
                case "string":
                    showStringValue();
                    break;
                case "char":
                    showCharValue();
                    break;
                case "bool":
                    showBoolValue();
                    break;
            }
        }
    }
}
