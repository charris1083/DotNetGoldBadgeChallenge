using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class MenuRepo
    {
        public List<MenuItem> _menuItem = new List<MenuItem>();

        public void AddMenuItem(MenuItem newMenuItem)
        {
            _menuItem.Add(newMenuItem);
        }
        public void RemoveMenuItem(MenuItem delete)
        {
            _menuItem.Remove(delete);
        }
        public List<MenuItem> SeeAllMenuItems()
        {
            return _menuItem;
        }
        
            
        
    
    }
}
