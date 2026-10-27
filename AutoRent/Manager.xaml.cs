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

namespace AutoRent
{
    /// <summary>
    /// Логика взаимодействия для Manager.xaml
    /// </summary>
    public partial class Manager : Window
    {
        public Manager()
        {
            InitializeComponent();
            OrdersLoad();
            MotoLoad();
            StatusLoad();
            Type_paymentLoad();
            ClientsLoad();
            WorkersLoad();
            GenderLoad();
            OtchetLoad();
        }
        MySqlConnection Connect = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["mototex"].ConnectionString);

        DataTable MotoDT = new DataTable();
        DataTable ClientsDT = new DataTable();
        DataTable OrdersDT = new DataTable();
        DataTable OtchetDT = new DataTable();

        List<string[]> Data = new List<string[]>();

        void OtchetLoad()
        {
            
            try
            {

                MySqlCommand Cmd;
                Connect.Open();
                Cmd = new MySqlCommand("Select * From sales ", Connect);
                OtchetDT.Load(Cmd.ExecuteReader());
                OtchetTable.DataContext = OtchetDT;
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
                    CBArticle.Items.Add(Data[i][0]);
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
                    CBPayment_type.Items.Add(Data[i][0]);

                }
                Data.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка соединения с базой данных. \n\n\n\n\nПодробнее:\n" + ex.ToString());
            }
            finally { Connect.Close();
            }
        }

        void StatusLoad()
        {
            
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
                }
                Data.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка соединения с базой данных. \n\n\n\n\nПодробнее:\n" + ex.ToString());
            }
            finally { Connect.Close(); }
        }


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


                }
                Data.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка соединения с базой данных. \n\n\n\n\nПодробнее:\n" + ex.ToString());
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
                    CBWorkersOrders.Items.Add(Data[i][0]);
                }
                    Data.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка соединения с базой данных. \n\n\n\n\nПодробнее:\n" + ex.ToString());
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

                    CBClientsOrders.Items.Add(Data[i][0]);
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AutoRent.Avtr Back = new AutoRent.Avtr();
            Back.Show();
            Close();
        }

        private void AddOrders_Click(object sender, RoutedEventArgs e)
        {
            if (CBWorkersOrders.Text == "")
            {

                MessageBox.Show("Выберите работника!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (CBClientsOrders.Text == "")
            {

                MessageBox.Show("Выберите клиента!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (CBArticle.Text == "")
            {

                MessageBox.Show("Выберите артикул!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBQuantity.Text == "")
            {

                MessageBox.Show("Введите количество!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBPriceOrders.Text == "")
            {

                MessageBox.Show("Введите цену!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (CBPayment_type.Text == "")
            {

                MessageBox.Show("Выберите тип оплаты!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBFinal_cost.Text == "")
            {

                MessageBox.Show("Введите итоговую цену!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (Date.Text == "")
            {

                MessageBox.Show("Выберите дату!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Add(new MySqlCommand("INSERT INTO `sales`(`Workers`,`Clients`,`Moto`,`Quantity`,`Cost`,`Payment_type`,`Final_price`,`Date`) VALUES ('" + CBWorkersOrders.Text + "','" + CBClientsOrders.Text + "','" + CBArticle.Text + "','" + TBQuantity.Text + "','" + TBPriceOrders.Text + "','" + CBPayment_type.Text + "','" + TBFinal_cost.Text + "','" + Date.SelectedDate.Value.ToString("yyyy/MM/dd") + "')", Connect));
            OrdersDT.Clear();
            OrdersLoad();
        }

        private void UpdateOrders_Click(object sender, RoutedEventArgs e)
        {
            if (CBWorkersOrders.Text == "")
            {

                MessageBox.Show("Выберите работника!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (CBClientsOrders.Text == "")
            {

                MessageBox.Show("Выберите клиента!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (CBArticle.Text == "")
            {

                MessageBox.Show("Выберите артикул!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBQuantity.Text == "")
            {

                MessageBox.Show("Введите количество!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBPriceOrders.Text == "")
            {

                MessageBox.Show("Введите цену!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (CBPayment_type.Text == "")
            {

                MessageBox.Show("Выберите тип оплаты!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (TBFinal_cost.Text == "")
            {

                MessageBox.Show("Введите итоговую цену!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (Date.Text == "")
            {

                MessageBox.Show("Выберите дату!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            string text = String.Empty;
            foreach (DataRowView Row in OrdersTable.SelectedItems)
            {
                text = Row.Row.ItemArray[0].ToString();
            }
            Update(new MySqlCommand("UPDATE `sales` SET `Workers`='" + CBWorkersOrders.Text + "',`Clients`='" + CBClientsOrders.Text + "',`Moto`='" + CBArticle.Text + "',`Quantity`='" + TBQuantity.Text + "',`Cost`= "+  (TBPriceOrders.Text) + ",`Payment_type`='" + CBPayment_type.Text + "',`Final_price`= " +  (TBFinal_cost.Text) + ",`Date`='" + Date.SelectedDate.Value.ToString("yyyy/MM/dd") + "' WHERE `id_Sales`='" + text + "'", Connect));
            OrdersDT.Clear();
            OrdersLoad();
        }
        private void TBPriceOrders_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789,.".IndexOf(e.Text) < 0;
        }
        private void OrdersTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string text = String.Empty;
            foreach (DataRowView Row in OrdersTable.SelectedItems)
            {

                for (int i = 0; i < OrdersTable.Columns.Count; i++)
                {
                    text = Row.Row.ItemArray[0].ToString();
                }
                Id.Text = Row.Row.ItemArray[0].ToString();
                CBWorkersOrders.Text = Row.Row.ItemArray[1].ToString();
                CBClientsOrders.Text = Row.Row.ItemArray[2].ToString();
                
                CBArticle.Text = Row.Row.ItemArray[3].ToString();
                TBQuantity.Text = Row.Row.ItemArray[4].ToString();
                TBPriceOrders.Text = Row.Row.ItemArray[5].ToString();
                CBPayment_type.Text = Row.Row.ItemArray[6].ToString();
                TBFinal_cost.Text = Row.Row.ItemArray[7].ToString();
                Date.Text = Row.Row.ItemArray[8].ToString();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DocX doc = DocX.Load("Чек.docx");
            var b1 = doc.Bookmarks["articul"];
            var b2 = doc.Bookmarks["kolich"];
            var b3 = doc.Bookmarks["tip"];
            var b4 = doc.Bookmarks["cost"];
            var b5 = doc.Bookmarks["final"];
            var b6 = doc.Bookmarks["login"];
            var b7 = doc.Bookmarks["number"];
            var b8 = doc.Bookmarks["time"];
            var b9 = doc.Bookmarks["NOM"];

            {
                
                b1.SetText(CBArticle.Text);
                b2.SetText(TBQuantity.Text);
                b3.SetText(CBPayment_type.Text);
                b4.SetText(TBPriceOrders.Text);
                b5.SetText(TBFinal_cost.Text);
                b6.SetText(CBWorkersOrders.Text);
                b7.SetText(CBClientsOrders.Text);
                b8.SetText(Date.SelectedDate.Value.ToString("yyyy/MM/dd"));
                b9.SetText(Id.Text);
            }
            Connect.Close();
            doc.SaveAs("Чек продажи");
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

        private void Otchet_Click(object sender, RoutedEventArgs e)
        {


            WordTable word = new WordTable();
                List<Sales> listorder = new List<Sales>();
                try
                {
                    Connect.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM sales;", Connect);
                MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                    while (dr.Read())
                        listorder.Add(new Sales()
                        {
                            worker = dr[1].ToString(),
                            client = dr[2].ToString(),
                            article = dr[3].ToString(),
                            quantity = (dr[4].ToString()),
                            price = Convert.ToDouble(dr[5].ToString()),
                            final_price = Convert.ToDouble(dr[7].ToString()),
                            date = Convert.ToDateTime(dr[8].ToString())
                        });
                    }
                    Connect.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); Connect.Close(); }
                listorder = listorder.Where(sr => sr.date >= Date2.SelectedDate.Value & sr.date <= Date1.SelectedDate.Value).ToList();

            word.ReportCreation(listorder, Date2.SelectedDate.Value.ToString("dd.MM.yyyy"), Date1.SelectedDate.Value.ToString("dd.MM.yyyy"));
            }

        private void Poisk_TextChanged(object sender, TextChangedEventArgs e)
        {
            for (int i = 0; i < MotoDT.Rows.Count; i++)
            {
                int Count = 0;
                List<object> sa = MotoDT.Rows[i].ItemArray.ToList();
                foreach (var item in sa)
                {
                    if (item.ToString().ToLower().Contains(Poisk.Text.ToLower()))
                        Count++;
                }
                if (Count == 0)
                {
                    MotoDT.Rows.RemoveAt(i);
                    i--;

                }
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
        }
        
        private void TBFinal_cost_TextChanged(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789,.".IndexOf(e.Text) < 0;
            
        }

        double i; 
       

        private void TBQuantity_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                i = Convert.ToDouble(TBPriceOrders.Text.Replace(".", ",")) * Convert.ToInt32(TBQuantity.Text);
                TBFinal_cost.Text = i.ToString("0.00",System.Globalization.CultureInfo.GetCultureInfo("en-US"));
            }
            catch (Exception)
            {


            }
        }
    }

    }



