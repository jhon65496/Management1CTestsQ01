using Connetc1C.Service01;
using sabatex.V1C77.Models;
using sabatex.V1C77;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Connetc1CWinForms01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetDirectory();
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            string databasePath = @"e:\БД\HS_GB_7.24.03.02.1_20240319_ORIGINAL\";
            string userName = @"РазрабПользователь1";            
            // string userName = @"Разраб1";
            string userPass = @"";

            GetDirectory2(databasePath, userName, userPass);
        }


        public async Task GetDirectory()
        {
            string databasePath = @"e:\БД\ОткройТвойБизнес01БДTest\";
            string userName = @"Разраб1";
            string userPass = @"";

            // == Arrange ==
            var connetc1CService = new Connetc1CService01(databasePath, userName, userPass);


            // == Act ==
            await connetc1CService.TestGlobalContext();

            // == Assert ==
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
