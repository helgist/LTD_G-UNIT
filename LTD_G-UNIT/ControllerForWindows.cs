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

      

        //lIST FOR CLIENTS CLASS 
        List<Client> _clientlist;

        //Method for clear Data
        public void ClearData()
        {
            _allData.Clear();
        }
        public ControllerForWindows()
        {
            _allData = new List<string>();
            _clientlist = new List<Client>();
        }

        public void newClient()
        {
            Client clie = new Client();
            _clientlist.Add(clie);

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
