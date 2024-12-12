using System.Diagnostics;
using System.Reflection;
using sabatex.V1C77;
using sabatex.V1C77.Models;

namespace Connetc1C.Service01
{
    public class Connetc1CService01
    {

        private readonly string _databasePath;
        private readonly string _userName;
        private readonly string _userPass;

        public Connetc1CService01()
        {
            
        }

        public Connetc1CService01(string databasePath, string userName, string userPass)
        {
            _databasePath = databasePath;
            _userName = userName;
            _userPass = userPass;
        }


        public async Task TestGlobalContext()
        {
            await Task.Run(() =>
            {

                var connection = new Connection
                {
                    DataBasePath = _databasePath,
                    PlatformType = EPlatform1C.V77M,
                    UserName = _userName,
                    UserPass = _userPass
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

        public async Task GetDirectoriesAsync()
        {
            await Task.Run(() =>
            {

                var connection = new Connection
                {
                    DataBasePath = _databasePath,
                    PlatformType = EPlatform1C.V77M,
                    UserName = _userName,
                    UserPass = _userPass
                };

                using (var oneCConnection = COMObject1C77.CreateConnection(connection))
                {
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

        public async Task GetDirectoriesAsync2()
        {
            await Task.Run(() =>
            {

                var connection = new Connection
                {
                    DataBasePath = _databasePath,
                    PlatformType = EPlatform1C.V77M,
                    UserName = _userName,
                    UserPass = _userPass
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

        public void Method()
        {
            Debug.WriteLine("\n=======================");
            Debug.WriteLine("Class - Connetc1CService");
            Debug.WriteLine("=======================\n");
        }


    }
}