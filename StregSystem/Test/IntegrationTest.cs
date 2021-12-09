using Controller;
using Core;
using UserInterface;
using Xunit;
using Xunit.Abstractions;

namespace Test
{
    public class IntegrationTest
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public IntegrationTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void ControllerCoreTest()
        {
            IStregSystem stregSystem = new StregSystem();
            IStregSystemUI stregSystemUi = new StregSystemCLI(stregSystem);
            StregSystemController controller = new StregSystemController(stregSystemUi, stregSystem);
            
            //act
            
            
            //assert
            

        }
        
        
        
        
    }
}