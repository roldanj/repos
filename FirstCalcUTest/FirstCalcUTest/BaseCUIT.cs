using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCalcUTest
{
    class BaseCUIT
    {
        private static WinWindow _parentWindow;

        public void SetParent(string windowName)
        {
            _parentWindow = new WinWindow();
            _parentWindow.SearchProperties[WinWindow.PropertyNames.Name] = windowName;

        }

    }
}
