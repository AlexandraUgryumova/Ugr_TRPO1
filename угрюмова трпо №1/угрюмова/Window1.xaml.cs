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
using System.Windows.Shapes;

namespace угрюмова
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        static bool IsNumberContains(string input)
        {
            foreach (char c in input)
                if (!Char.IsLetter(c))
                    return false;
            return true;
        }
        private void ButtonGoToWindow2_Click(object sender, RoutedEventArgs e)
        {
            string name = name_txt.Text;
            string female = female_txt.Text;
            string fatherName = fatherName_txt.Text;    
            string email = email_txt.Text;
            string phone = phone_txt.Text;
            if(name != "" || female != "" || fatherName != "" || email != "" || phone != "")
            {
                if (IsNumberContains(name) && IsNumberContains(female) && IsNumberContains(fatherName))
                {
                    Window2 window2 = new Window2();
                    window2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("в имени/фамилии/отчестве есть небуквенные символы");
                }
            }
            else
            {
                MessageBox.Show("есть пустые поля");
            }
        }
    }
}
