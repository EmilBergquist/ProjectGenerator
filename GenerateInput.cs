using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektGenerator_Test1
{
    class GenerateInput
    {
        public List<DataToInsert> GetInputPaymentPlan()
        {
            List<DataToInsert> dataList = new List<DataToInsert>();

            DataToInsert projectname = new DataToInsert();
            DataToInsert projectnr = new DataToInsert();
            DataToInsert extent = new DataToInsert();
            DataToInsert date = new DataToInsert();
            DataToInsert projectManager = new DataToInsert();
            DataToInsert projectManagerPhoneNr = new DataToInsert();
            DataToInsert CustomerName = new DataToInsert();
            DataToInsert CustomerNr = new DataToInsert();
            DataToInsert ReferenceCustomer = new DataToInsert();
            DataToInsert resourceAccount = new DataToInsert();
            DataToInsert AdressToWorkplace = new DataToInsert();
            DataToInsert zipcodeAndTown = new DataToInsert();

            dataList.Add(projectname);
            dataList.Add(projectnr);
            dataList.Add(extent);
            dataList.Add(date);
            dataList.Add(projectManager);
            dataList.Add(projectManagerPhoneNr);
            dataList.Add(CustomerName);
            dataList.Add(CustomerNr);
            dataList.Add(ReferenceCustomer);
            dataList.Add(resourceAccount);
            dataList.Add(AdressToWorkplace);
            dataList.Add(zipcodeAndTown);

            projectname.Column = 2;
            projectname.Row = 6;
            projectname.Text = "Ullna Golfklubb";

            projectnr.Column = 2;
            projectnr.Row = 8;
            projectnr.Text = "600113";

            extent.Column = 2;
            extent.Row = 10;
            extent.Text = "Ventilation inkl styr och regler";

            date.Column = 2;
            date.Row = 12;
            date.Text = DateTime.Today.ToString();

            projectManager.Column = 2;
            projectManager.Row = 14;
            projectManager.Text = Properties.Settings.Default.ProjectManager;

            projectManagerPhoneNr.Column = 2;
            projectManagerPhoneNr.Row = 16;
            projectManagerPhoneNr.Text = Properties.Settings.Default.ProjectManagerPhoneNr;

            CustomerName.Column = 2;
            CustomerName.Row = 21;
            CustomerName.Text = "HGP Bygg och konsult AB";

            CustomerNr.Column = 2;
            CustomerNr.Row = 23;
            CustomerNr.Text = "23";

            ReferenceCustomer.Column = 2;
            ReferenceCustomer.Row = 25;
            ReferenceCustomer.Text = "Bengt Hedin";

            resourceAccount.Column = 2;
            resourceAccount.Row = 27;
            resourceAccount.Text = "2568";

            AdressToWorkplace.Column = 2;
            AdressToWorkplace.Row = 29;
            AdressToWorkplace.Text = "Ullna Golfklubb";

            zipcodeAndTown.Column = 2;
            zipcodeAndTown.Row = 31;
            zipcodeAndTown.Text = "725 92 Västerås";

            return dataList;

        }

        public List<DataToInsert> GetInputKMA()
        {
            List<DataToInsert> dataList = new List<DataToInsert>();




            return dataList;
        }
    }
}
