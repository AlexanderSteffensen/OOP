using Core;
using UserInterface;

namespace Controller
{
    class Program
    {
        static void Main(string[] args)
        {
            IStregSystem ds = new StregSystem();
            IStregSystemUI ui = new StregSystemCLI(ds);
            StregSystemController controller = new StregSystemController(ui, ds);
            
            ui.Start();

        }
    }
}