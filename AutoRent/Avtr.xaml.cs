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
using MySql.Data.MySqlClient;
using System.Data;

namespace AutoRent
{
    /// <summary>
    /// Логика взаимодействия для Avtr.xaml
    /// </summary>
    public partial class Avtr : Window
    {
        public Avtr()
        {
            InitializeComponent();
            CaptchaText.Visibility = Visibility.Hidden;
            CaptchaTB.Visibility = Visibility.Hidden;
            RepeatCaptcha.Visibility = Visibility.Hidden;
            CaptchaBG.Visibility = Visibility.Visible;
        }
        int LogCount = 1;
        string Pass = "", Role = "";
        MySqlConnection Connect = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["mototex"].ConnectionString);

        private void Connection()
        {

            MySqlCommand Cmd = new MySqlCommand("SELECT * FROM mototex.workers where Login='" + TextBoxLogin.Text + "';", Connect);
            try
            {
                Connect.Open();
                MySqlDataReader Data = Cmd.ExecuteReader();
                if (Data.Read())
                {
                    Pass = Data[1].ToString();
                    Role = Data[5].ToString();

                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения к БД!!!");
            }
            finally { Connect.Close(); }
        }
        string status = "";
        private void Button_Click(object sender, RoutedEventArgs e)//Система авторизации
        {
            if (TextBoxLogin.Text != "" && TextBoxPassword.Password != "")
            {
                if (LogCount <= 3)
                {
                    Connection();
                    if (LogCount == 3)
                    {
                        Captcha();
                        CaptchaBG.Visibility = Visibility.Visible;
                        CaptchaText.Visibility = Visibility.Visible;
                        CaptchaTB.Visibility = Visibility.Visible;
                        RepeatCaptcha.Visibility = Visibility.Visible;
                    }
                }
                else
                {
                    if (CaptchaTB.Text == CaptchaText.Content.ToString())
                    {
                        Connection();
                    }
                    else
                    {
                        MessageBox.Show("Капча введена не правильно!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }

                if (TextBoxPassword.Password.Equals(Pass))
                {
                    try
                    {
                        MySqlCommand Cmd = new MySqlCommand("SELECT Status FROM mototex.workers where Login='" + TextBoxLogin.Text + "' and Password = '" + TextBoxPassword.Password + "'", Connect);
                        Connect.Open();
                        MySqlDataReader reader = Cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            status = reader.GetString(0);
                            if (status == "Удален")
                            {
                                
                                MessageBox.Show("Пользователь удален!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                                Connect.Close();
                                return;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        Connect.Close();

                    }

                    switch (Role)
                    {
                        case "Администратор":
                            {
                                
                                MessageBox.Show("Приветсвую, администратор!\nОтличного рабочего дня!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                                TaxiPark.MainWindow Admin = new TaxiPark.MainWindow();
                                Admin.Show();
                                Close();
                                break;
                            }
                        case "Менеджер":
                            {
                                
                                MessageBox.Show("Приветствую, менеджер!\nОтличного рабочего дня!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                                AutoRent.Manager Manager = new AutoRent.Manager();
                                Manager.Show();
                                Close();
                                break;
                            }
                        case "Директор":
                            {
                                MessageBox.Show("Приветствую, директор!\nОтличного рабочего дня!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                                AutoRent.Window1 Driver = new AutoRent.Window1();
                                Driver.Show();
                                Close();
                                break;
                            }
                        
                    }

                }
                else
                {
                   
                    MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            LogCount++;
        }

        private void Captcha() // капча
        {
            string Cap = String.Empty;
            Random Rnd = new Random();
            string Alf = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 6; i++)
            {
                Cap += Alf[Rnd.Next(Alf.Length)];
            }
            CaptchaText.Content = Cap;


        }

        private void CheckBox1_Checked(object sender, RoutedEventArgs e)
        {
           //  if (checkBox1.IsChecked == true)
           // {
            //    TextBoxPassword.PasswordChar = '1';
            // }
           // else
           // {
           //    TextBoxPassword.PasswordChar = '•';
           // }
            if (checkBox1.IsChecked == true)
            {
                ToolTip tooltip = new ToolTip();
                tooltip.BorderBrush = null;//нет границы
                tooltip.HasDropShadow = false;//не отбрасывать тень
                tooltip.Placement = System.Windows.Controls.Primitives.PlacementMode.Relative;//поверх элемента
                tooltip.StaysOpen = true;//оставаться открытым
                tooltip.Content = TextBoxPassword.Password;//собственно текст подсказки = незамаскированный пароль

                TextBoxPassword.ToolTip = tooltip;//установка
            }
            else
            {
                TextBoxPassword.ToolTip = null;//сброс
            }
        }

        private void RepeatCaptcha_Click(object sender, RoutedEventArgs e)
        {
            CaptchaText.Content = "";
            Captcha();
        }
    }
}
