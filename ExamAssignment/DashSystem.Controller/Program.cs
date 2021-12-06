using ExamAssignment.Core;
using ExamAssignment.Core.UI;
using ExamAssignment.UI;

namespace DashSystemController
{
    class Program
    {
        static void Main(string[] args)
        {
            IDashSystem ds = new DashSystem();
            IDashSystemUI ui = new DashSystemCLI(ds);
            DashSystemController controller = new DashSystemController(ui, ds);
            
            ui.Start();

        }
    }
}