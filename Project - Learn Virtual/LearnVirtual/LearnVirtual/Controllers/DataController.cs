using LearnVirtual.Entities;

namespace LearnVirtual.Controllers
{
    public class DataController
    {
       
        private DataContex _context;
        public DataController(DataContex contxt)
        {
            _context = contxt;
        }
    }
}
