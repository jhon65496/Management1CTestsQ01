using sabatex.V1C77.Models;
using sabatex.V1C77;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connetc1C.Frmw48.WinForms01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {         
            string databasePath = @"e:\БД\HS_GB_7.24.03.02.1_20240319_ORIGINAL\";
            string userName = @"РазрабПользователь1";
            // string userName = @"Разраб1";
            string userPass = @"";

            GetDirectory2(databasePath, userName, userPass);
        }


        public async Task GetDirectory2(string databasePath, string userName, string userPass)
        {
            await Task.Run(() =>
            {

                var connection = new Connection
                {
                    DataBasePath = databasePath,
                    // PlatformType = EPlatform1C.V1CEnterprise,
                    // PlatformType = EPlatform1C.V77,
                    // PlatformType = EPlatform1C.V77L,                    
                    PlatformType = EPlatform1C.V77M,
                    UserName = userName,
                    UserPass = userPass
                };

                using (var oneCConnection = COMObject1C77.CreateConnection(connection))
                {
                    var fd = oneCConnection.GlobalContext.GetProperty<object>("");

                    var directories = oneCConnection.GlobalContext.CreateObject("Метаданные.Справочник");
                    if (directories.Method<double>("ВыбратьЭлементы") == 1)
                    {
                        while (directories.Method<double>("ПолучитьЭлемент") == 1)
                        {
                            var name = directories.GetProperty<string>("Наименование");
                            Console.WriteLine(name);
                        }
                    }
                }
            });
        }
    }
}
