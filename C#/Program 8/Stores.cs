//Timothy Lockhart
//Program 8
//12/1/2022
//This program allows you to open and close files. insert and delete
//items in the file
using System.Windows.Forms;
using System;

namespace Program8
{
    public partial class Store : Form
    {
        //creates and instance to for other forms to refrence to
        public static Store instance;

        //sets Listview to LV
        public ListView LV;
        public Store()
        {
            InitializeComponent();
            
            instance = this;

            //sets LV to listview
            LV = listView;
        }

    }
}
