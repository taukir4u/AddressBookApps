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
    public partial class SetInfoUI : Form
    {
        public SetInfoUI()
        {
            InitializeComponent();
        }
        AddressBook aAddress = new AddressBook();
        

        private void showAllInfo_Click(object sender, EventArgs e)
        {

            ShowInfoUI aShowInfoUi = new ShowInfoUI(aAddress.GetAllPersons());
            aShowInfoUi.ShowDialog();
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            Person aPerson = new Person();
            aPerson.FirstName = firstNameTextBox.Text;
            aPerson.LastName = lastNameTextBox.Text;
            aPerson.Email = emailTextBox.Text;
            aPerson.Mobile = mobileTextBox.Text;
            string msg = aAddress.SetAddressInfo(aPerson);
            MessageBox.Show(msg);
        }

        private void searchByFirstNameButton_Click(object sender, EventArgs e)
        {
            List<Person> aList = aAddress.GetListByFirstName(searchTextBox.Text);
            SearchingResultView(aList);
        }


        private void SearchingResultView(List<Person> aList)
        {
            searchResultListView.Items.Clear();
            foreach (Person aPerson in aList)
            {
                string[] row = {aPerson.FirstName, aPerson.LastName, aPerson.Email, aPerson.Mobile};
                var listViewItem = new ListViewItem(row);
                searchResultListView.Items.Add(listViewItem);
            }
        }

        private void searchByLastNameButton_Click(object sender, EventArgs e)
        {
            List<Person> aList = aAddress.GetListByLastName(searchTextBox.Text);
            SearchingResultView(aList);
        }

        private void searchByEmailButton_Click(object sender, EventArgs e)
        {
            List<Person> aList = aAddress.GetListByEmail(searchTextBox.Text);
            SearchingResultView(aList);
        }

        private void searchByMobileButton_Click(object sender, EventArgs e)
        {
            List<Person> aList = aAddress.GetListByMobile(searchTextBox.Text);
            SearchingResultView(aList);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                Person aPerson = aAddress.GetMatchEmail(searchEmailTextBox.Text);
                firstNameUpdateTextBox.Text = aPerson.FirstName;
                lastNameUpdateTextBox.Text = aPerson.LastName;
                emailUpdateTextBox.Text = aPerson.Email;
                mobileUpdateTextBox.Text = aPerson.Mobile;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Person aPerson = new Person();
            aPerson.FirstName = firstNameUpdateTextBox.Text;
            aPerson.LastName = lastNameUpdateTextBox.Text;
            aPerson.Email = emailUpdateTextBox.Text;
            aPerson.Mobile = mobileUpdateTextBox.Text;
            string msg = aAddress.UpdatePerson(aPerson);
            MessageBox.Show(msg);
        }
    }
}
