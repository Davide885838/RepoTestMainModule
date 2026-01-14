using TestSubModule1;

namespace RepoTestMainModule
{
    public class TestMainModuleClass
    {
        public string GetMessage()
        {
            return new TestSubModuleClass().GetGreeting();
        }
    }
}
