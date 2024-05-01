//Timothy Lockhart
//Program 8
//12/1/2022
//This program allows you to open and close files. insert and delete
//items in the file
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program8
{

    public partial class Input : Form
    {
        //creats instance for MDI to comunicate with other MDI.
        public static Input instance;

        public Input()
        {
            InitializeComponent();
            instance = this;
        }


        private void OK_Button_Click(object sender, EventArgs e)
        {

            //adds items to Listview 
            Store.instance.LV.Items.Add(new ListViewItem(new string[] { ID_textbox.Text, Name_textbox.Text, Price_textBox.Text, Quantity_textBox.Text }));

            //closes MDI child
            this.Close();
        }

        //When cancel button is clicked, the MDI child will close
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            //closes the input MDI
            this.Close();
        }
    }
}
