using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTD_G_UNIT
{
    class ControllerForWindows
    {
        List<string> _allData;
        //Name of controller
        public ControllerForWindows()
        {
            _allData = new List<string>();
        }

        internal void SaveNotification(String data)
        {
            _allData.Add(data);
        }

        public string DataToDisplay()
        {
            string returnData = "";
            foreach (string s in _allData )
            {
            returnData += s + "\n";

            }
             return returnData;
        }
    }
}
