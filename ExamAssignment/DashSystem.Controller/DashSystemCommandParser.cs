using ExamAssignment.Core;
using ExamAssignment.Core.UI;

namespace DashSystemController
{
    public class DashSystemCommandParser
    {
        private IDashSystem _dashSystem;
        private IDashSystemUI _dashSystemUi;
        
        public DashSystemCommandParser(IDashSystem dashSystem, IDashSystemUI dashSystemUi)
        {
            _dashSystem = dashSystem;
            _dashSystemUi = dashSystemUi;
        }
        
        
        
        
    }
}