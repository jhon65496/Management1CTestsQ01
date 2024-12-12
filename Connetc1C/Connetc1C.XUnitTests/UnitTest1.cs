/*
 * Поиск: `unit testing name patterns`
    ИмяМетода_условия_результат
    Если условия неизвестны, то их можно опустить.
 */


using Connetc1C.Service01;

namespace Connetc1C.XUnitTests
{
    public class UnitTest1
    {

        Connetc1CService01 connetc1CService;

        public UnitTest1()
        {
            connetc1CService = new Connetc1CService01();
        }

        [Fact]
        public void Modal_Ok_Notifies_User()
        {
            // == Arrange ==

            // == Act ==
            connetc1CService.Method();

            // == Assert ==
        }
    }
}