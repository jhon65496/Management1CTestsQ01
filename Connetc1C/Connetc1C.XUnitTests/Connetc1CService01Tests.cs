/*
 * �����: `unit testing name patterns`
    ���������_�������_���������
    ���� ������� ����������, �� �� ����� ��������.
 */


using Connetc1C.Service01;

namespace Connetc1C.XUnitTests
{
    public class Connetc1CService01Tests
    {
        private string databasePath;
        private string userName;
        private string userPass;

        Connetc1CService01 connetc1CService;

        public Connetc1CService01Tests()
        {
            // connetc1CService = new Connetc1CService01();
        }

        [Fact]
        public async Task Get_Notifies_User()
        {
            databasePath = @"e:\��\HSGB7240302120240319ORIGINAL2\";
            userName = "";
            // userName = @"������1";
            // userName = @"������������������1";
            userPass = "";

            // == Arrange ==
            connetc1CService = new Connetc1CService01(databasePath, userName, userPass);


            // == Act ==
            await connetc1CService.TestGlobalContext();

            // == Assert ==
        }
    }
}