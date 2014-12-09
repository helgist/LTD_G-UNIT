using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTD_G_UNIT
{//
    class ControllerForWindows
    {
        DatabaseController _datcontr = new DatabaseController();
        List<string> _allData;
        //Name of controller

        //lIST FOR CLIENTS CLASS 
        public List<Client> _clientlist = new List<Client>();

        //Method for clear Data
        public void ClearData()
        {
            _allData.Clear();
        }
        public ControllerForWindows()
        {
            _allData = new List<string>();
           

        }
        public List<Client> getclientlist()
        {
           
            _clientlist = _datcontr.getlistofcostumers();
            return _clientlist;
        }

        public void newClient()
        {
            Client clie = new Client();
            _clientlist.Add(clie);

        }
        public void addClientstolist(string Name, int Phone, int MobilePhone, string Address, string CompanyName, int CostumerID)
        {
            Client clie = new Client();

            clie.Name = Name;
            clie.Phone = Phone;
            clie.MobilePhone = MobilePhone;
            clie.Address = Address;
            clie.CompanyName = CompanyName;
            clie.CostumerID = CostumerID;
                       
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
