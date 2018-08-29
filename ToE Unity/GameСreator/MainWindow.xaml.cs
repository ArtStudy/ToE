using GameСreator.ToePac;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

namespace GameСreator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var data = new PAC();
            data.Items.Add(new Item() { Data = "ТЕКСТ ТЕКСТ ТЕКСТ".GenerateStreamFromString(), FileType = FileTypes.Json, Identifier = 123 });
            data.Items.Add(new Item() { Data = "ТЕКСТ ТЕКСТ".GenerateStreamFromString(), FileType = FileTypes.Json, Identifier = 12345 });
            data.Items.Add(new Item() { Data = "ТЕКСТ".GenerateStreamFromString(), FileType = FileTypes.Json, Identifier = 12345678 });
            var r = PAC.GetPAC(PAC.CreatePAC(data));
            

            foreach(var item in r.Items)
            {
                StreamReader reader = new StreamReader( item.Data);
                string text = reader.ReadToEnd();
                Debug.WriteLine(item.FileType + " " +item.Identifier  + " " +text);
            }
           
           
        }
    }
}
