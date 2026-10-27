using Microsoft.Office.Interop.Word;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace AutoRent
{
    class WordTable
    {
        Application App2 = new Application();
        void Find(object FindText, object ReplaceText)
        {
            try
            {
                App2.Selection.Find.Execute(ref FindText,
                true,
                true,
                false,
                false,
                false,
                true,
                false,
                1,
                ref ReplaceText,
                2,
                false,
                false,
                false,
                false);
            }
            catch (Exception rt) { }
        }
        public string ReportCreation(List<Sales> Table, string DATE2, string DATE1)
        {
            Document Doc = new Document();
            try
            {
                SaveFileDialog SFD = new SaveFileDialog();
                SFD.Filter = "DOCX files(*.docx)|*.docx|All files(*.*)|*.*";
                if (SFD.ShowDialog() == true)
                {
                    if (Table == null)
                        return "Нажмите кнопку 'Узнать результаты'";
                    object objMiss = System.Reflection.Missing.Value;
                    Doc = App2.Documents.Open(Directory.GetCurrentDirectory() + @"\Otchet_po_prodazham.docx");
                    
                    Find("DATE1", DATE2);
                    Find("DATE2", DATE1);
                    double PriceProduct = 0;
                    for (int i = 0; i <= Table.Count - 1; i++)
                        PriceProduct += Table[i].final_price;
                    Find("COST", PriceProduct.ToString());
                    

                    Table tab = Doc.Tables[1];
                    tab.Rows.Add(objMiss);
                    tab.Columns.Add();
                    tab.Columns.Add();
                    tab.Columns.Add();
                    tab.Columns.Add();
                    for (int i = 0; i <= Table.Count - 2; i++)
                        tab.Rows.Add();
                    int ROW = -1, COUNT = 0, COUNTCOLUMN = 0, COUNTROW = 0, ROWS = 0, ID = 0;

                    foreach (Row row in tab.Rows)
                    {
                        foreach (Cell item in row.Cells)
                        {
                            if (item.RowIndex == 1)
                            {
                                if (COUNTCOLUMN == 0)
                                    item.Range.Text = "Работник";
                                else if (COUNTCOLUMN == 1)
                                    item.Range.Text = "Номер телефона клиента";
                                else if (COUNTCOLUMN == 2)
                                    item.Range.Text = "Артикул товара";
                                else if (COUNTCOLUMN == 3)
                                    item.Range.Text = "Количество(шт)";
                                else if (COUNTCOLUMN == 4)
                                    item.Range.Text = "Стоимость за единицу товара(руб.коп)";
                                else if (COUNTCOLUMN == 5)
                                    item.Range.Text = "Общая стоимость(руб.коп)";
                                COUNTCOLUMN += 1;
                            }
                            else
                            {
                                if (COUNTROW == 0)
                                    item.Range.Text = Table[ROW].worker;
                                else if (COUNTROW == 1)
                                    item.Range.Text = Table[ROW].client;
                                else if (COUNTROW == 2)
                                    item.Range.Text = Table[ROW].article;
                                else if (COUNTROW == 3)
                                    item.Range.Text = Table[ROW].quantity + " шт";
                                else if (COUNTROW == 4)
                                    item.Range.Text = Table[ROW].price + " руб.коп";
                                else if (COUNTROW == 5)
                                    item.Range.Text = Table[ROW].final_price + " руб.коп";
                                COUNTROW += 1;
                            }
                            ID += 1;
                        }
                        ROW++;
                        if (ROW == Table.Count)
                            break;
                        ROWS++;
                        COUNTROW = 0;
                        COUNT++;
                    }


                    Doc.SaveAs(FileName: SFD.FileName);
                    App2.Documents.Open(Path.Combine(Doc.Path, Doc.Name));
                }

                else { SFD.FileName = "ds"; Doc.Close(); }
                App2.Quit();
                return "Всё успешно";


            }
            catch (Exception err)
            {
                Doc.Close();
                App2.Quit();
                System.Windows.MessageBox.Show("Проблемы" + err.ToString());
            }
            try
            {
                App2.Quit();
            }
            catch (Exception)
            {

            }

            return "Не удалось заполнить";
        }
    }
}

