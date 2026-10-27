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
using MySql.Data.MySqlClient;
using System.Data;
using Xceed.Words.NET;
using System.Text.RegularExpressions;
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;

namespace AutoRent
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            OrdersLoad();
            MotoLoad();
            ClientsLoad();
            WorkersLoad();
        }
        MySqlConnection Connect = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["mototex"].ConnectionString);

        DataTable MotoDT = new DataTable();
        DataTable ClientsDT = new DataTable();
        DataTable OrdersDT = new DataTable();
        DataTable WorkersDT = new DataTable();

        List<string[]> Data = new List<string[]>();

        void OrdersLoad()
        {
            try
            {
                MySqlCommand Cmd = new MySqlCommand("Select * From sales", Connect);
                Connect.Open();
                MySqlDataReader Reader = Cmd.ExecuteReader();
                while (Reader.Read())
                {
                    Data.Add(new string[1]);
                    Data[Data.Count - 1][0] = Reader.GetString(0);
                }
                for (int i = 0; i < Data.Count; i++)
                {


                }
                Data.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка соединения с базой данных. \n\n\n\n\nПодробнее:\n" + ex.ToString());
            }
            finally { Connect.Close(); }
            try
            {

                MySqlCommand Cmd;
                Connect.Open();
                Cmd = new MySqlCommand("Select * From sales ", Connect);
                OrdersDT.Load(Cmd.ExecuteReader());
                OrdersTable.DataContext = OrdersDT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка соединения с базой данных.\n\n\nПодробнее:\n" + ex.ToString());
            }
            finally { Connect.Close(); }
        }



        void MotoLoad()
        {
            try
            {
                MySqlCommand Cmd = new MySqlCommand("Select * From motor_vehicles", Connect);
                Connect.Open();
                MySqlDataReader Reader = Cmd.ExecuteReader();
                while (Reader.Read())
                {
                    Data.Add(new string[1]);
                    Data[Data.Count - 1][0] = Reader.GetString(0);
                }
                for (int i = 0; i < Data.Count; i++)
                {

                }
                Data.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка соединения с базой данных. \n\n\n\n\nПодробнее:\n" + ex.ToString());
            }
            finally { Connect.Close(); }
            try
            {

                MySqlCommand Cmd;
                Connect.Open();
                Cmd = new MySqlCommand("Select * From motor_vehicles", Connect);
                MotoDT.Load(Cmd.ExecuteReader());
                MotoTable.DataContext = MotoDT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка соединения с базой данных.\n\n\nПодробнее:\n" + ex.ToString());
            }
            finally { Connect.Close(); }
        }

        void WorkersLoad()
        {
            try
            {
                MySqlCommand Cmd = new MySqlCommand("Select * From workers", Connect);
                Connect.Open();
                MySqlDataReader Reader = Cmd.ExecuteReader();
                while (Reader.Read())
                {
                    Data.Add(new string[1]);
                    Data[Data.Count - 1][0] = Reader.GetString(0);
                }
                for (int i = 0; i < Data.Count; i++)
                {

                }
                Data.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка соединения с базой данных. \n\n\n\n\nПодробнее:\n" + ex.ToString());
            }
            finally { Connect.Close(); }
            try
            {

                MySqlCommand Cmd;
                Connect.Open();
                Cmd = new MySqlCommand("Select * From workers ", Connect);
                WorkersDT.Load(Cmd.ExecuteReader());
                WorkersTable.DataContext = WorkersDT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка соединения с базой данных.\n\n\nПодробнее:\n" + ex.ToString());
            }
            finally { Connect.Close(); }
        }
        void ClientsLoad()
        {
            try
            {
                MySqlCommand Cmd = new MySqlCommand("Select * From clients", Connect);
                Connect.Open();
                MySqlDataReader Reader = Cmd.ExecuteReader();
                while (Reader.Read())
                {
                    Data.Add(new string[1]);
                    Data[Data.Count - 1][0] = Reader.GetString(0);
                }
                for (int i = 0; i < Data.Count; i++)
                {


                }
                Data.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка соединения с базой данных. \n\n\n\n\nПодробнее:\n" + ex.ToString());
            }
            finally { Connect.Close(); }
            try
            {

                MySqlCommand Cmd;
                Connect.Open();
                Cmd = new MySqlCommand("Select * From clients ", Connect);
                ClientsDT.Load(Cmd.ExecuteReader());
                ClientsTable.DataContext = ClientsDT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка соединения с базой данных.\n\n\nПодробнее:\n" + ex.ToString());
            }
            finally { Connect.Close(); }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AutoRent.Avtr Back = new AutoRent.Avtr();
            Back.Show();
            Close();
        }
        List<string> x;
        List<int> y;
        void Stat()
        {
            x = new List<string>();
            y = new List<int>();
            try
            {
                MySqlCommand Cmd = new MySqlCommand("SELECT `Date`,`Final_price` FROM mototex.sales where `Date` between '"+Date1.SelectedDate.Value.ToString("yyyy/MM/dd")+ "' and '" + Date2.SelectedDate.Value.ToString("yyyy/MM/dd") + "'", Connect);
                Connect.Open();
                MySqlDataReader Reader = Cmd.ExecuteReader();
                while (Reader.Read())
                {
                    x.Add(Reader.GetString(0).Replace("0:00:00", ""));
                    y.Add(Reader.GetInt32(1));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            finally
            {
                Connect.Close();
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(Date1.SelectedDate != null || Date2.SelectedDate != null)
            {
                Stata.ChartAreas.Clear();
                Stata.Series.Clear();
                Stat();
                Stata.ChartAreas.Add(new ChartArea("one"));
                Stata.Series.Add(new Series("two"));
                Stata.Series["two"].ChartArea = "one";
                Stata.Series["two"].ChartType = SeriesChartType.Column;
                Stata.Series["two"].Points.DataBindXY(x, y);
            }
        }
    }
}
