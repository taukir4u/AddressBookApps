using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBookApps
{
    public partial class ShowInfoUI : Form
    {
        public ShowInfoUI(List<Person> aList)
        {
            InitializeComponent();
            ShowAllInfo(aList);
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
         
        private void ShowAllInfo(List<Person> aList)
        {
            
            foreach (Person aPerson in aList)
            {
                string[] row = { aPerson.FirstName, aPerson.LastName,aPerson.Email,aPerson.Mobile };
                var listViewItem = new ListViewItem(row);
                showAllListView.Items.Add(listViewItem);
            }
        }
    }
}
