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

namespace PR23106_tazhbaev_var2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string predlozhenie = textAll.Text;
                int colich = 0;
                    
                char[] Text = predlozhenie.ToCharArray();
                char[] glasnie = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

                for (int i = 0; i < predlozhenie.Length; i++)
                    for (int j = 0; j < glasnie.Length; j++)
                        if (predlozhenie[i] == glasnie[j])
                            colich++;

                glWords.Content = Convert.ToString(colich);



                string[] slova = textAll.Text.Split(' ');


            }
            catch (Exception ex)
            {
                    errorText.Content = $"Ошибка: {ex.Message}";
            }
        }
    }
}
