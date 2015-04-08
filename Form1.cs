using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parse;

namespace TVTS
{
    public partial class TVTS : Form
    {
        public Inventory inventory = new Inventory();

        public TVTS()
        {
            InitializeComponent();
            ParseClient.Initialize("IjwXqmqCIAJYdsZgR6IFfRqZWCcz6ZRzc1HtIVXt", "pTVqs58DwvOqrzrQSHHhtsd0Slsz6QG8Y6m8ro13");
        }

        //Searches through all cars on the lot
        private void btn_sInv_Click(object sender, EventArgs e)
        {
            String make = textBox_make.Text;
            String model = textBox_model.Text;
            int year = Convert.ToInt32(textBox_year.Text);
        

            inventory.searchCar(make, model, year, false, listBox);

        }

        //Needs to pop up new form or panel to enter new data for a new car
        //do we need a batch entry option?
        private void btn_addCar_Click(object sender, EventArgs e)
        {
           

        }

        //don't need and don't know how to disable without breaking the designer
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        //Searches through owned cars only
        private void btn_ownedSearch_Click(object sender, EventArgs e)
        {
            String make = tb_ownMake.Text;
            String model = tb_ownModel.Text;
            int year = Convert.ToInt32(tb_ownYear.Text);

            inventory.searchCar(make, model, year, true, listBox_Owned);
        }

        //private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    MessageBox.Show("blah blah line is selected");

        //}

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("blah blah line is selected");
        }



  
    }
}
