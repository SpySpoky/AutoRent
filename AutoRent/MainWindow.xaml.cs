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
using System.Text.RegularExpressions;

namespace TaxiPark
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Load();
            ModelLoad();
            OrdersLoad();
            ManufacturerLoad();
            ColorLoad();
            CountryLoad();
            MotoLoad();
            StatusLoad();
            Type_paymentLoad();
            ClientsLoad();
            WorkersLoad();
            RoleLoad();
            GenderLoad();


            //ColorsHead.Visibility = Visibility.Hidden;
            //Type.Visibility = Visibility.Hidden;
           // Pol.Visibility = Visibility.Hidden;
           // Country.Visibility = Visibility.Hidden;
            //Status.Visibility = Visibility.Hidden;
            //Model.Visibility = Visibility.Hidden;
            //Role.Visibility = Visibility.Hidden;
            //Payment.Visibility = Visibility.Hidden;
        }
        MySqlConnection Connect = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["mototex"].ConnectionString);

        DataTable TypeDT = new DataTable();
        DataTable MotoDT = new DataTable();
        DataTable ClientsDT = new DataTable();
        DataTable ColorDT = new DataTable();
        DataTable CountryDT = new DataTable();
        DataTable ManufacturerDT = new DataTable();
        DataTable StatusDT = new DataTable();
        DataTable ModelDT = new DataTable();
        DataTable RoleDT = new DataTable();
        DataTable Type_paymentDT = new DataTable();
        DataTable OrdersDT = new DataTable();
        DataTable WorkersDT = new DataTable();
        DataTable GenderDT = new DataTable();

        void GenderLoad()
        {
            try
            {
                MySqlCommand Cmd = new MySqlCommand("Select * From gender", Connect);
                Connect.Open();
                MySqlDataReader Reader = Cmd.ExecuteReader();
                while (Reader.Read())
                {
                    Data.Add(new string[1]);
                    Data[Data.Count - 1][0] = Reader.GetString(0);
                }
                for (int i = 0; i < Data.Count; i++)
                {
                    CBGenderClients.Items.Add(Data[i][0]);
                    CBGender1.Items.Add(Data[i][0]);

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
                Cmd = new MySqlCommand("Select * From gender ", Connect);
                GenderDT.Load(Cmd.ExecuteReader());
                GenderTable.DataContext = GenderDT;
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
        void RoleLoad()
        {
            try
            {
                MySqlCommand Cmd = new MySqlCommand("Select * From role", Connect);
                Connect.Open();
                MySqlDataReader Reader = Cmd.ExecuteReader();
                while (Reader.Read())
                {
                    Data.Add(new string[1]);
                    Data[Data.Count - 1][0] = Reader.GetString(0);
                }
                for (int i = 0; i < Data.Count; i++)
                {
                    CBRole.Items.Add(Data[i][0]);
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
                Cmd = new MySqlCommand("Select * From role ", Connect);
                RoleDT.Load(Cmd.ExecuteReader());
                RoleTable.DataContext = RoleDT;
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
        void Type_paymentLoad()
        {
            try
            {
                MySqlCommand Cmd = new MySqlCommand("Select * From payment_type", Connect);
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
                Cmd = new MySqlCommand("Select * From payment_type ", Connect);
                Type_paymentDT.Load(Cmd.ExecuteReader());
                Type_paymentTable.DataContext = Type_paymentDT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка соединения с базой данных.\n\n\nПодробнее:\n" + ex.ToString());
            }
            finally { Connect.Close(); }
        }
        void Load()
        {
            try
            {
                MySqlCommand Cmd = new MySqlCommand("Select * From type_moto", Connect);
                Connect.Open();
                MySqlDataReader Reader = Cmd.ExecuteReader();
                while (Reader.Read())
                {
                    Data.Add(new string[1]);
                    Data[Data.Count - 1][0] = Reader.GetString(0);
                }
                for (int i = 0; i < Data.Count; i++)
                {
                    CBType.Items.Add(Data[i][0]);

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
                Cmd = new MySqlCommand("SELECT * from type_moto", Connect);
                TypeDT.Load(Cmd.ExecuteReader());
                TypeTable.DataContext = TypeDT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка соединения с базой данных.\n\n\nПодробнее:\n" + ex.ToString());
            }
            finally { Connect.Close(); }
            
        }
        void StatusLoad()
        {
            try
            {

                MySqlCommand Cmd;
                Connect.Open();
                Cmd = new MySqlCommand("SELECT * from status", Connect);
                StatusDT.Load(Cmd.ExecuteReader());
                StatusTable.DataContext = StatusDT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка соединения с базой данных.\n\n\nПодробнее:\n" + ex.ToString());
            }
            finally { Connect.Close(); }
            try
            {
                MySqlCommand Cmd = new MySqlCommand("Select * From status", Connect);
                Connect.Open();
                MySqlDataReader Reader = Cmd.ExecuteReader();
                while (Reader.Read())
                {
                    Data.Add(new string[1]);
                    Data[Data.Count - 1][0] = Reader.GetString(0);
                }
                for (int i = 0; i < Data.Count; i++)
                {
                    CBStatusClients.Items.Add(Data[i][0]);
                    CBStatusMoto.Items.Add(Data[i][0]);
                    CBStatusWorkers.Items.Add(Data[i][0]);  
                }
                Data.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка соединения с базой данных. \n\n\n\n\nПодробнее:\n" + ex.ToString());
            }
            finally { Connect.Close(); }
        }

        List<string[]> Data = new List<string[]>();
        void ModelLoad()
        {
            try
            {
                MySqlCommand Cmd = new MySqlCommand("Select * From model", Connect);
                Connect.Open();
                MySqlDataReader Reader = Cmd.ExecuteReader();
                while (Reader.Read())
                {
                    Data.Add(new string[1]);
                    Data[Data.Count - 1][0] = Reader.GetString(0);
                }
                for (int i = 0; i < Data.Count; i++)
                {
                    CBModel.Items.Add(Data[i][0]);
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
                Cmd = new MySqlCommand("Select * From model", Connect);
                ModelDT.Load(Cmd.ExecuteReader());
                ModelTable.DataContext = ModelDT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка соединения с базой данных.\n\n\nПодробнее:\n" + ex.ToString());
            }
            finally { Connect.Close(); }
        }
        void OrdersLoad()
        {
            try
            {
                MySqlCommand Cmd = new MySqlCommand("SELECT * from sales", Connect);
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
                Cmd = new MySqlCommand("SELECT * from sales", Connect);
                OrdersDT.Load(Cmd.ExecuteReader());
                OrdersTable.DataContext = OrdersDT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка соединения с базой данных.\n\n\nПодробнее:\n" + ex.ToString());
            }
            finally { Connect.Close(); }
        }
        void ManufacturerLoad()
        {
            try
            {
                MySqlCommand Cmd = new MySqlCommand("SELECT * from manufacturer", Connect);
                Connect.Open();
                MySqlDataReader Reader = Cmd.ExecuteReader();
                while (Reader.Read())
                {
                    Data.Add(new string[1]);
                    Data[Data.Count - 1][0] = Reader.GetString(0);
                }
                for (int i = 0; i < Data.Count; i++)
                {
                    CBManufacturerMoto.Items.Add(Data[i][0]);
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
                Cmd = new MySqlCommand("SELECT * from manufacturer", Connect);
                ManufacturerDT.Load(Cmd.ExecuteReader());
                ManufacturerTable.DataContext = ManufacturerDT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка соединения с базой данных.\n\n\nПодробнее:\n" + ex.ToString());
            }
            finally { Connect.Close(); }
        }
        void ColorLoad()
        {
            try
            {
                MySqlCommand Cmd = new MySqlCommand("Select * from color", Connect);
                Connect.Open();
                MySqlDataReader Reader = Cmd.ExecuteReader();
                while (Reader.Read())
                {
                    Data.Add(new string[1]);
                    Data[Data.Count - 1][0] = Reader.GetString(0);
                }
                for (int i = 0; i < Data.Count; i++)
                {
                    CBColor.Items.Add(Data[i][0]);
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
                Cmd = new MySqlCommand("Select * From color ", Connect);
                ColorDT.Load(Cmd.ExecuteReader());
                ColorsTable.DataContext = ColorDT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка соединения с базой данных.\n\n\nПодробнее:\n" + ex.ToString());
            }
            finally { Connect.Close(); }
        }
        void CountryLoad()
        {
            try
            {
                MySqlCommand Cmd = new MySqlCommand("Select * From country", Connect);
                Connect.Open();
                MySqlDataReader Reader = Cmd.ExecuteReader();
                while (Reader.Read())
                {
                    Data.Add(new string[1]);
                    Data[Data.Count - 1][0] = Reader.GetString(0);
                }
                for (int i = 0; i < Data.Count; i++)
                {
                    CBManufacturer.Items.Add(Data[i][0]);
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
                Cmd = new MySqlCommand("Select * From country", Connect);
                CountryDT.Load(Cmd.ExecuteReader());
                CountryTable.DataContext = CountryDT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка соединения с базой данных.\n\n\nПодробнее:\n" + ex.ToString());
            }
            finally { Connect.Close(); }
        }

        void Add(MySqlCommand Cmd)
        {

            try
            {
                Connect.Open();
                Cmd.ExecuteNonQuery();
                Connect.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нельзя изменять использующиеся значения!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                Connect.Close();
                
            }
            
        }
        void Update(MySqlCommand Cmd)
        {

            try
            {
                Connect.Open();
                Cmd.ExecuteNonQuery();
                Connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нельзя изменять использующиеся значения!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                
                Connect.Close();
            }
            
        }
        void Delete(MySqlCommand Cmd)
        {

            try
            {
                Connect.Open();
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка соединения с базой данных. \n\n\n\n\nПодробнее:\n" + ex.ToString());
            }
            finally
            {
                Connect.Close();
                Load();
            }
        }
        private void PriceTB_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789,.".IndexOf(e.Text) < 0;
        }
        private void DeleteTechPass_Click(object sender, RoutedEventArgs e)
        {
            /*
        if (CBClass.Text != "" && CBBrand.Text != "" && TBModel.Text != "" && TBYear.Text != "" && CBDriveUnit.Text != ""
            && TBMileage.Text != "" && CBComputer.Text != "" && CBTransmission.Text != "" &&
            CBClass.Text != " " && CBBrand.Text != " " && TBModel.Text != " " && TBYear.Text != " " && CBDriveUnit.Text != " "
            && TBMileage.Text != " " && CBComputer.Text != " " && CBTransmission.Text != " ")
        {
                }
                else
                {
                    MessageBox.Show("Для изменения данных учетной записи заполните все необходимые поля.");
                }
*/
        }

        private void AddType_Click(object sender, RoutedEventArgs e)
        {
            if (TBType.Text == "")
            {
                MessageBox.Show("Введите данные!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
                Add(new MySqlCommand("INSERT INTO type_moto(Name_type) VALUES ('" + TBType.Text + "')", Connect));
                TypeDT.Clear();
                Load();
        }

        private void UpdateType_Click(object sender, RoutedEventArgs e)
        {
            if (TBType.Text == "")
            {
                MessageBox.Show("Введите данные!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            string text = String.Empty;
            foreach (DataRowView Row in TypeTable.SelectedItems)
            {
                text = Row.Row.ItemArray[0].ToString();
            }
            Update(new MySqlCommand("UPDATE `type_moto` SET `Name_type`='" + TBType.Text + "' WHERE `Name_type`='" + text + "'", Connect));
            TypeDT.Clear();
            Load();
        }

        private void ModelTable_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            string text = String.Empty;
            foreach (DataRowView Row in ModelTable.SelectedItems)
            {

                for (int i = 0; i < ModelTable.Columns.Count; i++)
                {
                    text = Row.Row.ItemArray[0].ToString();
                }

                TBModel.Text = Row.Row.ItemArray[0].ToString();

            }
        }
        private void ColorsTable_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            string text = String.Empty;
            foreach (DataRowView Row in ColorsTable.SelectedItems)
            {

                for (int i = 0; i < ColorsTable.Columns.Count; i++)
                {
                    text = Row.Row.ItemArray[0].ToString();
                }
                TBColors.Text = Row.Row.ItemArray[0].ToString();
            }
        }

        private void CountryTable_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            string text = String.Empty;
            foreach (DataRowView Row in CountryTable.SelectedItems)
            {

                for (int i = 0; i < CountryTable.Columns.Count; i++)
                {
                    text = Row.Row.ItemArray[0].ToString();
                }
                TBCountry.Text = Row.Row.ItemArray[0].ToString();
            }
        }

        private void ManufacturerTable_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            string text = String.Empty;
            foreach (DataRowView Row in ManufacturerTable.SelectedItems)
            {

                for (int i = 0; i < ManufacturerTable.Columns.Count; i++)
                {
                    text = Row.Row.ItemArray[0].ToString();
                }
                TBManufacturer.Text = Row.Row.ItemArray[0].ToString();
                CBManufacturer.Text = Row.Row.ItemArray[1].ToString();
                
            }
        }

        private void StatusTable_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            string text = String.Empty;
            foreach (DataRowView Row in StatusTable.SelectedItems)
            {

                for (int i = 0; i < StatusTable.Columns.Count; i++)
                {
                    text = Row.Row.ItemArray[0].ToString();
                }

                TBStatus.Text = Row.Row.ItemArray[0].ToString();
            }
        }

        private void MotoTable_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            string text = String.Empty;
            foreach (DataRowView Row in MotoTable.SelectedItems)
            {

                for (int i = 0; i < MotoTable.Columns.Count; i++)
                {
                    text = Row.Row.ItemArray[0].ToString();
                }
                TBArticle.Text = Row.Row.ItemArray[0].ToString();
                TBMoto.Text = Row.Row.ItemArray[1].ToString();
                CBType.Text = Row.Row.ItemArray[2].ToString();
                CBModel.Text = Row.Row.ItemArray[3].ToString();
                CBManufacturerMoto.Text = Row.Row.ItemArray[4].ToString();
                CBColor.Text = Row.Row.ItemArray[5].ToString();
                TBQuantity.Text = Row.Row.ItemArray[6].ToString();
                TBCost.Text = Row.Row.ItemArray[7].ToString();
                CBStatusMoto.Text = Row.Row.ItemArray[8].ToString();
                
            }
        }

        private void ClientsTable_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            string text = String.Empty;
            foreach (DataRowView Row in ClientsTable.SelectedItems)
            {

                for (int i = 0; i < ClientsTable.Columns.Count; i++)
                {
                    text = Row.Row.ItemArray[0].ToString();
                }

                TBPhone.Text = Row.Row.ItemArray[0].ToString();
                TBSurname.Text = Row.Row.ItemArray[1].ToString();
                TBNameClients.Text = Row.Row.ItemArray[2].ToString();
                TBMiddlename.Text = Row.Row.ItemArray[3].ToString();
                TBEmail.Text = Row.Row.ItemArray[4].ToString();
                CBGenderClients.Text = Row.Row.ItemArray[5].ToString();
                CBStatusClients.Text = Row.Row.ItemArray[6].ToString();
            }
        }
        private void Type_paymentTable_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            string text = String.Empty;
            foreach (DataRowView Row in Type_paymentTable.SelectedItems)
            {

                for (int i = 0; i < Type_paymentTable.Columns.Count; i++)
                {
                    text = Row.Row.ItemArray[0].ToString();
                }
                TBType_payment.Text = Row.Row.ItemArray[0].ToString();
            }
        }

        private void WorkersTable_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            string text = String.Empty;
            foreach (DataRowView Row in WorkersTable.SelectedItems)
            {

                for (int i = 0; i < WorkersTable.Columns.Count; i++)
                {
                    text = Row.Row.ItemArray[0].ToString();
                }
                TBLogin.Text = Row.Row.ItemArray[0].ToString();
                TBPassword.Text = Row.Row.ItemArray[1].ToString();
                TBSurname1.Text = Row.Row.ItemArray[2].ToString();
                TBName1.Text = Row.Row.ItemArray[3].ToString();
                TBMiddlename1.Text = Row.Row.ItemArray[4].ToString();
                CBRole.Text = Row.Row.ItemArray[5].ToString();
                CBGender1.Text = Row.Row.ItemArray[6].ToString();
                CBStatusWorkers.Text = Row.Row.ItemArray[7].ToString();
            }
        }
        private void GenderTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string text = String.Empty;
            foreach (DataRowView Row in GenderTable.SelectedItems)
            {

                for (int i = 0; i < GenderTable.Columns.Count; i++)
                {
                    text = Row.Row.ItemArray[0].ToString();
                }
                TBGender1.Text = Row.Row.ItemArray[0].ToString();
            }
            }

        private void RoleTable_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            string text = String.Empty;
            foreach (DataRowView Row in RoleTable.SelectedItems)
            {

                for (int i = 0; i < RoleTable.Columns.Count; i++)
                {
                    text = Row.Row.ItemArray[0].ToString();
                }
                TBRole.Text = Row.Row.ItemArray[0].ToString();
            }
        }

       
        private void AddClients_Click(object sender, RoutedEventArgs e)
        {
            if (TBSurname.Text == "")
            {
                
                MessageBox.Show("Введите фамилию!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBNameClients.Text == "")
            {
                
                MessageBox.Show("Введите имя!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBMiddlename.Text == "")
            {
                
                MessageBox.Show("Введите отчество!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
         
            if (TBPhone.Text == "")
            {
                
                MessageBox.Show("Введите телефон!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBEmail.Text == "")
            {
                
                MessageBox.Show("Введите электронную почту!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
         
            if (CBGenderClients.Text == "")
            {
                
                MessageBox.Show("Выберите пол клиента!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (CBStatusClients.Text == "")
            {
                
                MessageBox.Show("Выберите статус клиента!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Regex reg = new Regex("[a-z0-9._%+-]+@[a-z0-9.-]+.[a-z]{2,4}");
            if (!reg.IsMatch(TBEmail.Text.ToLower()))
            {
                
                MessageBox.Show("Неправильный ввод почты!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
              
                for (int i = 0; i < TBEmail.Text.Length; i++)
                {
                    if (TBEmail.Text[i] == '@')
                    {
                        Add(new MySqlCommand("INSERT INTO clients(Phone_number,Surname, Name, Lastname,Email,Gender,Status) VALUES ('" + TBPhone.Text + "','" + TBSurname.Text + "','" + TBNameClients.Text + "','" + TBMiddlename.Text + "','" + TBEmail.Text + "','" + CBGenderClients.Text + "','" + CBStatusClients.Text + "')", Connect));
                        ClientsLoad();
                    }
                    

                }
            }
        }

        private void UpdateClients_Click(object sender, RoutedEventArgs e)
        {
            if (TBSurname.Text == "")
            {
                
                MessageBox.Show("Введите фамилию!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBNameClients.Text == "")
            {
                
                MessageBox.Show("Введите имя!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBMiddlename.Text == "")
            {
                
                MessageBox.Show("Введите отчество!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (TBPhone.Text == "")
            {
                
                MessageBox.Show("Ведите телефон!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBEmail.Text == "")
            {
               
                MessageBox.Show("Введите электронную почту!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (CBGenderClients.Text == "")
            {
                
                MessageBox.Show("Выберите пол клиента!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (CBStatusClients.Text == "")
            {
                
                MessageBox.Show("Выберите статус клиента!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Regex reg = new Regex("[a-z0-9._%+-]+@[a-z0-9.-]+.[a-z]{2,4}");
            if (!reg.IsMatch(TBEmail.Text.ToLower()))
            {
                
                MessageBox.Show("Неправильный ввод почты!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                string text = String.Empty;
                foreach (DataRowView Row in ClientsTable.SelectedItems)
                {
                    text = Row.Row.ItemArray[0].ToString();
                }
                Update(new MySqlCommand("UPDATE clients SET Phone_number='" + TBPhone.Text + "',Surname='" + TBSurname.Text + "',Name='" + TBNameClients.Text + "',Lastname='" + TBMiddlename.Text + "',Email='" + TBEmail.Text + "',Gender='" + CBGenderClients.Text + "',Status='" + CBStatusClients.Text + "' WHERE Phone_number='" + text + "'", Connect));
                
                MessageBox.Show("Клиент обновлен!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                ClientsDT.Clear();
                ClientsLoad();
            }

        }

        private void DeleteClients_Click(object sender, RoutedEventArgs e)
        {
            if (TBSurname.Text == "")
            {
                
                MessageBox.Show("Введите фамилию!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBNameClients.Text == "")
            {
                
                MessageBox.Show("Введите имя!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBMiddlename.Text == "")
            {
                
                MessageBox.Show("Введите отчество!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (TBPhone.Text == "")
            {
                
                MessageBox.Show("Ведите телефон!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBEmail.Text == "")
            {
                
                MessageBox.Show("Введите электронную почту!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (CBGenderClients.Text == "")
            {
                
                MessageBox.Show("Выберите пол клиента!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (CBStatusClients.Text == "")
            {
                
                MessageBox.Show("Выберите статус клиента!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Regex reg = new Regex("[a-z0-9._%+-]+@[a-z0-9.-]+.[a-z]{2,4}");
            if (!reg.IsMatch(TBEmail.Text.ToLower()))
            {
                
                MessageBox.Show("Неправильный ввод почты!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (CBStatusClients.Text == "Удален")
            {
                
                MessageBox.Show("Клиент уже удален!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                Connect.Open();
                MySqlCommand Cmd = new MySqlCommand("UPDATE clients SET Status='Удален' WHERE Phone_number = '" + TBPhone.Text + "'", Connect);
                MySqlDataReader Reader = Cmd.ExecuteReader();
                Connect.Close();
                ClientsDT.Clear();
                ClientsLoad();
            }
            if (CBStatusClients.Text == "Активен")
            {
                
                MessageBox.Show("Вы успешно удалили клиента!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            if (CBStatusClients.Text == "Не активен")
            {
                
                MessageBox.Show("Вы успешно удалили клиента!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
        }

        private void AddMoto_Click(object sender, RoutedEventArgs e)
        {
            if (TBArticle.Text == "")
            {
                
                MessageBox.Show("Введите артикул!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBMoto.Text == "")
            {
                
                MessageBox.Show("Введите название мототехники!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (CBType.Text == "")
            {
                
                MessageBox.Show("Выберите тип мототехники!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (CBModel.Text == "")
            {
                
                MessageBox.Show("Выберите модель!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (CBManufacturerMoto.Text == "")
            {
                
                MessageBox.Show("Выберите производителя!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (CBColor.Text == "")
            {
                
                MessageBox.Show("Выберите цвет!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBQuantity.Text == "")
            {
                
                MessageBox.Show("Введите количество!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBCost.Text == "")
            {
                
                MessageBox.Show("Введите цену!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (CBStatusMoto.Text == "")
            {
                
                MessageBox.Show("Выберите статус!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Add(new MySqlCommand("INSERT INTO `motor_vehicles`(`Article_moto`,`Name_moto`, `Type_moto`, `Model`,`Manufacturer`,`Color`,`Quantity`,`Cost`,`Status`) VALUES ('" + TBArticle.Text + "','" + TBMoto.Text + "','" + CBType.Text + "','" + CBModel.Text + "','" + CBManufacturerMoto.Text + "','" + CBColor.Text + "','" + TBQuantity.Text + "','" + TBCost.Text + "','" + CBStatusMoto.Text + "')", Connect));
            
            MotoLoad();
        }

        private void UpdateMoto_Click(object sender, RoutedEventArgs e)
        {
            if (TBArticle.Text == "")
            {
                
                MessageBox.Show("Введите артикул!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBMoto.Text == "")
            {
                
                MessageBox.Show("Введите название мототехники!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (CBType.Text == "")
            {
                
                MessageBox.Show("Выберите тип мототехники!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (CBModel.Text == "")
            {
                
                MessageBox.Show("Выберите модель!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (CBManufacturerMoto.Text == "")
            {
                
                MessageBox.Show("Выберите производителя!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (CBColor.Text == "")
            {
                
                MessageBox.Show("Выберите цвет!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBQuantity.Text == "")
            {
                
                MessageBox.Show("Введите количество!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBCost.Text == "")
            {
                
                MessageBox.Show("Введите цену!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (CBStatusMoto.Text == "")
            {
                
                MessageBox.Show("Выберите статус!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            string text = String.Empty;
            foreach (DataRowView Row in MotoTable.SelectedItems)
            {
                text = Row.Row.ItemArray[0].ToString();
            }
            Update(new MySqlCommand("UPDATE `motor_vehicles` SET `Article_moto`='" + TBArticle.Text + "',`Name_moto`='" + TBMoto.Text + "',`Type_moto`='" + CBType.Text + "',`Model`='" + CBModel.Text + "',`Manufacturer`='" + CBManufacturerMoto.Text + "',`Color`='" + CBColor.Text + "',`Quantity`='" + TBQuantity.Text + "',`Cost`='" + TBCost.Text + "',`Status`='" + CBStatusMoto.Text + "' WHERE `Article_moto`='" + text + "'", Connect));
            
            MessageBox.Show("Товар обновлен!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            MotoDT.Clear();
            MotoLoad();
        }

        private void DeleteMoto_Click(object sender, RoutedEventArgs e)
        {
            if (TBArticle.Text == "")
            {
                
                MessageBox.Show("Введите артикул!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBMoto.Text == "")
            {
                
                MessageBox.Show("Введите название мототехники!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (CBType.Text == "")
            {
                
                MessageBox.Show("Выберите тип мототехники!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (CBModel.Text == "")
            {
                
                MessageBox.Show("Выберите модель!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (CBManufacturerMoto.Text == "")
            {
                
                MessageBox.Show("Выберите производителя!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (CBColor.Text == "")
            {
                
                MessageBox.Show("Выберите цвет!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBQuantity.Text == "")
            {
                
                MessageBox.Show("Введите количество!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBCost.Text == "")
            {
               
                MessageBox.Show("Введите цену!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (CBStatusMoto.Text == "")
            {
               
                MessageBox.Show("Выберите статус!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (CBStatusMoto.Text == "Удален")
            {
                
                MessageBox.Show("Товар уже удален!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Connect.Open();
            MySqlCommand Cmd = new MySqlCommand("UPDATE motor_vehicles SET Status='Удален' WHERE Article_moto = '" + TBArticle.Text + "'", Connect);
            MySqlDataReader Reader = Cmd.ExecuteReader();
            Connect.Close();
            MotoDT.Clear();
            MotoLoad();
            if (CBStatusMoto.Text == "Активен")
            {
                
                MessageBox.Show("Товар успешно удален!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            if (CBStatusMoto.Text == "Не активен")
            {
                
                MessageBox.Show("Товар успешно удален!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
        }

        private void AddColors_Click(object sender, RoutedEventArgs e)
        {

            if (TBColors.Text == "")
            {
                
                MessageBox.Show("Введите цвет!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
               
            }
            Add(new MySqlCommand("INSERT INTO `color`(`Name_color`) VALUES ('" + TBColors.Text + "')", Connect));
            ColorLoad();
        }

        private void UpdateColors_Click(object sender, RoutedEventArgs e)
        {
            if (TBColors.Text == "")
            {
                
                MessageBox.Show("Введите цвет!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            string text = String.Empty;
            foreach (DataRowView Row in ColorsTable.SelectedItems)
            {
                text = Row.Row.ItemArray[0].ToString();
            }
            Update(new MySqlCommand("UPDATE `color` SET `Name_color`='" + TBColors.Text + "' WHERE `Name_color`='" + text + "'", Connect));
            
            MessageBox.Show("Цвет обновлен!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            ColorDT.Clear();
            ColorLoad();
        }

        private void AddCountry_Click(object sender, RoutedEventArgs e)
        {
            if (TBCountry.Text == "")
            {
               
                MessageBox.Show("Введите страну!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Add(new MySqlCommand("INSERT INTO `country`(`Name_country`) VALUES ('" + TBCountry.Text + "')", Connect));
            CountryLoad();
        }

        private void UpdateCountry_Click(object sender, RoutedEventArgs e)
        {
            if (TBCountry.Text == "")
            {
                
                MessageBox.Show("Введите страну!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            string text = String.Empty;
            foreach (DataRowView Row in CountryTable.SelectedItems)
            {
                text = Row.Row.ItemArray[0].ToString();
            }
            Update(new MySqlCommand("UPDATE `country` SET `Name_country`='" + TBCountry.Text + "' WHERE `Name_country`='" + text + "'", Connect));
            MessageBox.Show("Страна обновлена!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            CountryDT.Clear();
            CountryLoad();
        }

        private void AddManufacturer_Click(object sender, RoutedEventArgs e)
        {
            if (TBManufacturer.Text == "")
            {
                
                MessageBox.Show("Введите производителя!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (CBManufacturer.Text == "")
            {
               
                MessageBox.Show("Введите страну производителя!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Add(new MySqlCommand("INSERT INTO `manufacturer`(`Name`, `Country`) VALUES ('" + TBManufacturer.Text + "','" + CBManufacturer.Text + "')", Connect));
            
            ManufacturerLoad();
        }

        private void UpdateManufacturer_Click(object sender, RoutedEventArgs e)
        {
            if (TBManufacturer.Text == "")
            {
                
                MessageBox.Show("Введите производителя!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (CBManufacturer.Text == "")
            {
                
                MessageBox.Show("Введите страну производителя!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            string text = String.Empty;
            foreach (DataRowView Row in ManufacturerTable.SelectedItems)
            {
                text = Row.Row.ItemArray[0].ToString();
            }
            Update(new MySqlCommand("UPDATE `manufacturer` SET `Name`='" + TBManufacturer.Text + "',`Country`='" + CBManufacturer.Text + "'WHERE `Name`='" + text + "'", Connect));
            
            MessageBox.Show("Производитель обновлен!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            ManufacturerDT.Clear();
            ManufacturerLoad();
        }

        private void AddStatus_Click(object sender, RoutedEventArgs e)
        {
            if (TBStatus.Text == "")
            {
                
                MessageBox.Show("Введите статус!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Add(new MySqlCommand("INSERT INTO `status`(`Name_status`) VALUES ('" + TBStatus.Text + "')", Connect));
            StatusLoad();
        }

        private void UpdateStatus_Click(object sender, RoutedEventArgs e)
        {
            if (TBStatus.Text == "")
            {
                
                MessageBox.Show("Введите статус!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            string text = String.Empty;
            foreach (DataRowView Row in StatusTable.SelectedItems)
            {
                text = Row.Row.ItemArray[0].ToString();
            }
            Update(new MySqlCommand("UPDATE `status` SET `Name_status`='" + TBStatus.Text + "'WHERE `Name_status`='" + text + "'", Connect));
            
            MessageBox.Show("Статус обновлен!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            StatusDT.Clear();
            StatusLoad();
        }

        private void AddModel_Click(object sender, RoutedEventArgs e)
        {
            if (TBModel.Text == "")
            {
               
                MessageBox.Show("Введите модель!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Add(new MySqlCommand("INSERT INTO `model`(`Name_model`) VALUES ('" + TBModel.Text + "')", Connect));
            ModelLoad();
        }

        private void UpdateModel_Click(object sender, RoutedEventArgs e)
        {
            if (TBModel.Text == "")
            {
                
                MessageBox.Show("Введите модель!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            string text = String.Empty;
            foreach (DataRowView Row in ModelTable.SelectedItems)
            {
                text = Row.Row.ItemArray[0].ToString();
            }
            Update(new MySqlCommand("UPDATE `model` SET `Name_model`='" + TBModel.Text + "'WHERE `Name_model`='" + text + "'", Connect));

            MessageBox.Show("Модель обновлена!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            ModelDT.Clear();
            ModelLoad();
        }
        private void AddRole_Click(object sender, RoutedEventArgs e)
        {
            if (TBRole.Text == "")
            {
                
                MessageBox.Show("Введите роль!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Add(new MySqlCommand("INSERT INTO `role`(`Name_role`) VALUES ('" + TBRole.Text + "')", Connect));
            RoleLoad();
        }

        private void UpdateRole_Click(object sender, RoutedEventArgs e)
        {
            if (TBRole.Text == "")
            {
                
                MessageBox.Show("Введите роль!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            string text = String.Empty;
            foreach (DataRowView Row in RoleTable.SelectedItems)
            {
                text = Row.Row.ItemArray[0].ToString();
            }
            Update(new MySqlCommand("UPDATE `role` SET `Name_role`='" + TBRole.Text + "' WHERE `Name_role`='" + text + "'", Connect));
            MessageBox.Show("Роль обновлена!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            RoleDT.Clear();
            RoleLoad();
        }
        private void AddType_payment_Click(object sender, RoutedEventArgs e)
        {
            if (TBType_payment.Text == "")
            {
                
                MessageBox.Show("Введите тип оплаты!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Add(new MySqlCommand("INSERT INTO `payment_type`(`Payment_type`) VALUES ('" + TBType_payment.Text + "')", Connect));
            Type_paymentLoad();
        }

        private void UpdateType_payment_Click(object sender, RoutedEventArgs e)
        {
            if (TBType_payment.Text == "")
            {
                
                MessageBox.Show("Введите тип оплаты!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            string text = String.Empty;
            foreach (DataRowView Row in Type_paymentTable.SelectedItems)
            {
                text = Row.Row.ItemArray[0].ToString();
            }
            Update(new MySqlCommand("UPDATE `payment_type` SET `Payment_type`='" + TBType_payment.Text + "' WHERE `Payment_type`='" + text + "'", Connect));
           
            MessageBox.Show("Тип оплаты обновлен!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            Type_paymentDT.Clear();
            Type_paymentLoad();
        }
        private void AddWorkers_Click(object sender, RoutedEventArgs e)
        {
            if (TBLogin.Text == "")
            {
               
                MessageBox.Show("Введите логин!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBPassword.Text == "")
            {
                
                MessageBox.Show("Введите пароль!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBSurname1.Text == "")
            {
                
                MessageBox.Show("Введите фамилию!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBName1.Text == "")
            {
                
                MessageBox.Show("Введите имя!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBMiddlename1.Text == "")
            {
                
                MessageBox.Show("Введите отчество!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (CBRole.Text == "")
            {
               
                MessageBox.Show("Введите роль!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (CBGender1.Text == "")
            {
                
                MessageBox.Show("Введите пол!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (CBStatusWorkers.Text == "")
            {
                
                MessageBox.Show("Введите статус!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Add(new MySqlCommand("INSERT INTO `workers`(`Login`,`Password`,`Surname`,`Name`,`Lastname`,`Role`,`Gender`,`Status`) VALUES ('" + TBLogin.Text + "','" + TBPassword.Text + "','" + TBSurname1.Text + "','" + TBName1.Text + "','" + TBMiddlename1.Text + "','" + CBRole.Text + "','" + CBGender1.Text + "','" + CBStatusWorkers.Text + "')", Connect));
            
            WorkersLoad();
        }

        private void UpdateWorkers_Click(object sender, RoutedEventArgs e)
        {
            if (TBLogin.Text == "")
            {
                
                MessageBox.Show("Введите логин!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBPassword.Text == "")
            {
                
                MessageBox.Show("Введите пароль!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBSurname1.Text == "")
            {
                
                MessageBox.Show("Введите фамилию!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBName1.Text == "")
            {
                
                MessageBox.Show("Введите имя!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBMiddlename1.Text == "")
            {
                
                MessageBox.Show("Введите отчество!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (CBRole.Text == "")
            {
                
                MessageBox.Show("Введите роль!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (CBGender1.Text == "")
            {
                
                MessageBox.Show("Введите пол!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (CBStatusWorkers.Text == "")
            {
                
                MessageBox.Show("Введите статус!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            string text = String.Empty;
            foreach (DataRowView Row in WorkersTable.SelectedItems)
            {
                text = Row.Row.ItemArray[0].ToString();
            }
            Update(new MySqlCommand("UPDATE `workers` SET `Login`='" + TBLogin.Text + "',`Password`='" + TBPassword.Text + "',`Surname`='" + TBSurname1.Text + "',`Name`='" + TBName1.Text + "',`Lastname`='" + TBMiddlename1.Text + "',`Role`='" + CBRole.Text + "',`Gender`='" + CBGender1.Text + "',`Status`='" + CBStatusWorkers.Text + "' WHERE `Login`='" + text + "'", Connect));
            MessageBox.Show("Работник обновлен!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            WorkersDT.Clear();
            WorkersLoad();

        }

        private void DeleteWorkers_Click(object sender, RoutedEventArgs e)
        {
            if (TBLogin.Text == "")
            {

                MessageBox.Show("Введите логин!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBPassword.Text == "")
            {

                MessageBox.Show("Введите пароль!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBSurname1.Text == "")
            {

                MessageBox.Show("Введите фамилию!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBName1.Text == "")
            {

                MessageBox.Show("Введите имя!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBMiddlename1.Text == "")
            {

                MessageBox.Show("Введите отчество!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (CBRole.Text == "")
            {

                MessageBox.Show("Введите роль!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (CBGender1.Text == "")
            {

                MessageBox.Show("Введите пол!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (CBStatusWorkers.Text == "")
            {

                MessageBox.Show("Введите статус!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (CBStatusWorkers.Text == "Удален")
            {
                
                MessageBox.Show("Работник уже удален!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (CBRole.Text == "Администратор")
            {
                MessageBox.Show("Вы не можете удалить администратора!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Connect.Open();
            MySqlCommand Cmd = new MySqlCommand("UPDATE workers SET Status='Удален' WHERE Login = '" + TBLogin.Text + "'", Connect);
            MySqlDataReader Reader = Cmd.ExecuteReader();
            Connect.Close();
            WorkersDT.Clear();
            WorkersLoad();
            if (CBStatusWorkers.Text == "Активен")
            {
                ;
                MessageBox.Show("Работник успешно удален!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            if (CBStatusWorkers.Text == "Не активен")
            {
                
                MessageBox.Show("Работник успешно удален!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
        }

        private void AddGender_Click(object sender, RoutedEventArgs e)
        {
            if (TBGender1.Text == "")
            {
                
                MessageBox.Show("Введите пол!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Add(new MySqlCommand("INSERT INTO `gender`(`Name_gender`) VALUES ('" + TBGender1.Text + "')", Connect));
            GenderLoad();
        }

        private void UpdateGender_Click(object sender, RoutedEventArgs e)
        {
            if (TBGender1.Text == "")
            {
                
                MessageBox.Show("Введите пол!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            string text = String.Empty;
            foreach (DataRowView Row in GenderTable.SelectedItems)
            {
                text = Row.Row.ItemArray[0].ToString();
            }
            Update(new MySqlCommand("UPDATE `gender` SET `Name_gender`='" + TBGender1.Text + "' WHERE `Name_gender`='" + text + "'", Connect));
            
            MessageBox.Show("Пол обновлен!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            GenderDT.Clear();
            GenderLoad();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AutoRent.Avtr Back = new AutoRent.Avtr();
            Back.Show();
            Close();
            
            MessageBox.Show("Вы вернулись на форму авторизации!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void TypeTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string text = String.Empty;
            foreach (DataRowView Row in TypeTable.SelectedItems)
            {

                for (int i = 0; i < TypeTable.Columns.Count; i++)
                {
                    text = Row.Row.ItemArray[0].ToString();
                }
                TBType.Text = Row.Row.ItemArray[0].ToString();
            }
        }
        bool bl;
        private void TBPhone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!bl)
            {
                bl = true;
                string str = ((TextBox)sender).Text.Replace("+", "").Replace("(", "").Replace(")", "").Replace("-", "");
                ((TextBox)sender).Text = "+";

                for (int i = 0; i < str.Length; i++)
                {
                    if (i == 1)
                        ((TextBox)sender).Text += "(";
                    if (i == 4)
                        ((TextBox)sender).Text += ")";
                    if (i == 7)
                        ((TextBox)sender).Text += "-";
                    if (i == 9)
                        ((TextBox)sender).Text += "-";
                    ((TextBox)sender).Text += str[i];
                }
                bl = false;
            }
                ((TextBox)sender).SelectionStart = ((TextBox)sender).Text.Length;
            ((TextBox)sender).Text = ((TextBox)sender).Text.Replace(" ", "");

        }

        private void TBPhone_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.D0:
                case Key.D1:
                case Key.D2:
                case Key.D3:
                case Key.D4:
                case Key.D5:
                case Key.D6:
                case Key.D7:
                case Key.D8:
                case Key.D9:
                case Key.NumLock:
                case Key.NumPad0:
                case Key.NumPad1:
                case Key.NumPad2:
                case Key.NumPad3:
                case Key.NumPad4:
                case Key.NumPad5:
                case Key.NumPad6:
                case Key.NumPad7:
                case Key.NumPad8:
                case Key.NumPad9:
                case Key.Back:
                case Key.Space:
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            ColorsHead.IsSelected = true;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Pol.IsSelected = true;
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Country.IsSelected = true;
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Status.IsSelected = true;
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            Model.IsSelected = true;
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            Role.IsSelected = true;
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            Payment.IsSelected = true;
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            Type.IsSelected = true;
        }

        private void TBPoisk_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TBPoisk.Text != "")
            {
                for (int i = 0; i < ManufacturerDT.Rows.Count; i++)
                {
                    int Count = 0;
                    List<object> sa = ManufacturerDT.Rows[i].ItemArray.ToList();
                    foreach (var item in sa)
                    {
                        if (item.ToString().ToLower().Contains(TBPoisk.Text.ToLower()))
                            Count++;
                    }
                    if (Count == 0)
                    {
                        ManufacturerDT.Rows.RemoveAt(i);
                        i--;

                    }
                }
            }
            else
            {
                ManufacturerLoad();
            }
        }

        private void PoiskMoto_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PoiskMoto.Text != "")
            {
                for (int i = 0; i < MotoDT.Rows.Count; i++)
                {
                    int Count = 0;
                    List<object> sa = MotoDT.Rows[i].ItemArray.ToList();
                    foreach (var item in sa)
                    {
                        if (item.ToString().ToLower().Contains(PoiskMoto.Text.ToLower()))
                            Count++;
                    }
                    if (Count == 0)
                    {
                        MotoDT.Rows.RemoveAt(i);
                        i--;

                    }
                }
            }
            else
            {
                MotoLoad();
            }
        }

        private void PoiskClients_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PoiskClients.Text != "")
            {
                for (int i = 0; i < ClientsDT.Rows.Count; i++)
                {
                    int Count = 0;
                    List<object> sa = ClientsDT.Rows[i].ItemArray.ToList();
                    foreach (var item in sa)
                    {
                        if (item.ToString().ToLower().Contains(PoiskClients.Text.ToLower()))
                            Count++;
                    }
                    if (Count == 0)
                    {
                        ClientsDT.Rows.RemoveAt(i);
                        i--;

                    }
                }
            }
            else
            {
                ClientsLoad();
            }
        }

        private void PoiskOrders_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PoiskOrders.Text != "")
            {
                for (int i = 0; i < OrdersDT.Rows.Count; i++)
                {
                    int Count = 0;
                    List<object> sa = OrdersDT.Rows[i].ItemArray.ToList();
                    foreach (var item in sa)
                    {
                        if (item.ToString().ToLower().Contains(PoiskOrders.Text.ToLower()))
                            Count++;
                    }
                    if (Count == 0)
                    {
                        OrdersDT.Rows.RemoveAt(i);
                        i--;

                    }
                }
            }
            else
            {
                OrdersLoad();
            }
        }

        private void PoiskWorkers_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PoiskWorkers.Text != "")
            {
                for (int i = 0; i < WorkersDT.Rows.Count; i++)
                {
                    int Count = 0;
                    List<object> sa = WorkersDT.Rows[i].ItemArray.ToList();
                    foreach (var item in sa)
                    {
                        if (item.ToString().ToLower().Contains(PoiskWorkers.Text.ToLower()))
                            Count++;
                    }
                    if (Count == 0)
                    {
                        WorkersDT.Rows.RemoveAt(i);
                        i--;

                    }
                }
            }
            else
            {
                WorkersLoad();
            }
        }

        private void PoiskType_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PoiskType.Text != "")
            {
                for (int i = 0; i < TypeDT.Rows.Count; i++)
                {
                    int Count = 0;
                    List<object> sa = TypeDT.Rows[i].ItemArray.ToList();
                    foreach (var item in sa)
                    {
                        if (item.ToString().ToLower().Contains(PoiskType.Text.ToLower()))
                            Count++;
                    }
                    if (Count == 0)
                    {
                        TypeDT.Rows.RemoveAt(i);
                        i--;

                    }
                }
            }
            else
            {
                Load();
            }
        }

        private void PoiskColors_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PoiskColors.Text != "")
            {
                for (int i = 0; i < ColorDT.Rows.Count; i++)
                {
                    int Count = 0;
                    List<object> sa = ColorDT.Rows[i].ItemArray.ToList();
                    foreach (var item in sa)
                    {
                        if (item.ToString().ToLower().Contains(PoiskColors.Text.ToLower()))
                            Count++;
                    }
                    if (Count == 0)
                    {
                        ColorDT.Rows.RemoveAt(i);
                        i--;

                    }
                }
            }
            else
            {
                ColorLoad();
            }
        }

        private void PoiskGender_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PoiskGender.Text != "")
            {
                for (int i = 0; i < GenderDT.Rows.Count; i++)
                {
                    int Count = 0;
                    List<object> sa = GenderDT.Rows[i].ItemArray.ToList();
                    foreach (var item in sa)
                    {
                        if (item.ToString().ToLower().Contains(PoiskGender.Text.ToLower()))
                            Count++;
                    }
                    if (Count == 0)
                    {
                        GenderDT.Rows.RemoveAt(i);
                        i--;

                    }
                }
            }
            else
            {
                GenderLoad();
            }
        }

        private void PoiskModel_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PoiskModel.Text != "")
            {
                for (int i = 0; i < ModelDT.Rows.Count; i++)
                {
                    int Count = 0;
                    List<object> sa = ModelDT.Rows[i].ItemArray.ToList();
                    foreach (var item in sa)
                    {
                        if (item.ToString().ToLower().Contains(PoiskModel.Text.ToLower()))
                            Count++;
                    }
                    if (Count == 0)
                    {
                        ModelDT.Rows.RemoveAt(i);
                        i--;

                    }
                }
            }
            else
            {
                ModelLoad();
            }
        }

        private void PoiskCountry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PoiskCountry.Text != "")
            {
                for (int i = 0; i < CountryDT.Rows.Count; i++)
                {
                    int Count = 0;
                    List<object> sa = CountryDT.Rows[i].ItemArray.ToList();
                    foreach (var item in sa)
                    {
                        if (item.ToString().ToLower().Contains(PoiskCountry.Text.ToLower()))
                            Count++;
                    }
                    if (Count == 0)
                    {
                        CountryDT.Rows.RemoveAt(i);
                        i--;

                    }
                }
            }
            else
            {
                CountryLoad();
            }
        }

        private void PoiskStatus_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PoiskStatus.Text != "")
            {
                for (int i = 0; i < StatusDT.Rows.Count; i++)
                {
                    int Count = 0;
                    List<object> sa = StatusDT.Rows[i].ItemArray.ToList();
                    foreach (var item in sa)
                    {
                        if (item.ToString().ToLower().Contains(PoiskStatus.Text.ToLower()))
                            Count++;
                    }
                    if (Count == 0)
                    {
                        StatusDT.Rows.RemoveAt(i);
                        i--;

                    }
                }
            }
            else
            {
                StatusLoad();
            }
        }

        private void PoiskRole_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PoiskRole.Text != "")
            {
                for (int i = 0; i < RoleDT.Rows.Count; i++)
                {
                    int Count = 0;
                    List<object> sa = RoleDT.Rows[i].ItemArray.ToList();
                    foreach (var item in sa)
                    {
                        if (item.ToString().ToLower().Contains(PoiskRole.Text.ToLower()))
                            Count++;
                    }
                    if (Count == 0)
                    {
                        RoleDT.Rows.RemoveAt(i);
                        i--;

                    }
                }
            }
            else
            {
                RoleLoad();
            }
        }

        private void PoiskPayment_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PoiskPayment.Text != "")
            {
                for (int i = 0; i < Type_paymentDT.Rows.Count; i++)
                {
                    int Count = 0;
                    List<object> sa = Type_paymentDT.Rows[i].ItemArray.ToList();
                    foreach (var item in sa)
                    {
                        if (item.ToString().ToLower().Contains(PoiskPayment.Text.ToLower()))
                            Count++;
                    }
                    if (Count == 0)
                    {
                        Type_paymentDT.Rows.RemoveAt(i);
                        i--;

                    }
                }
            }
            else
            {
                Type_paymentLoad();
            }
        }
    }
}

