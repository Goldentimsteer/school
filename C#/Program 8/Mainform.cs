//Timothy Lockhart
//Program 8
//12/1/2022
//This program allows you to open and close files, insert and delete
//items in the file
using System.Collections.Generic;
using System.IO;
using System;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using static System.Windows.Forms.AxHost;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace Program8
{
    public partial class Mainform : Form
    {
        // object for deserializing Record in binary format
        private BinaryFormatter reader = new BinaryFormatter();

        //Mainform instance makes it posible to use items in diffrent MDI forms
        public static Mainform instance;
        public Mainform()
        {
            InitializeComponent();
            instance = this;
        }

        public object ID { get; internal set; }

        
        //insert tool is used to add items to the listview 
        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //creates the child
            Input child = new Input();

            //sets MDI parent
            child.MdiParent = this;

            //shows child
            child.Show();


        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            //open file with write access
            //FileStream output = new FileStream("Hardware.Inv", FileMode.OpenOrCreate, FileAccess.Write);

            //Record containing TextBox values to serialize
            //Record record = new Record();


            //store TextBox fields in Record
            //record.ID = "4568";
            //record.Name = "Hammer";
            //record.Price = "12.99";
            //record.Quantity = "5";
            //record.Store = "Hardware";
            //List<Record> records = new List<Record>();
            //records.Add(record);

            //write Record to FileStream(serialize object)
            //reader.Serialize(output, records);

            //closes file
            //output.Close();

        }


        //opentoolstrip will open a new file by using the open file dialog
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens new file dialog
            OpenFileDialog ofd = new OpenFileDialog();

            //shows file dialog
            ofd.ShowDialog();

            // open file with write access
            FileStream infile = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
            StreamReader filereader = new StreamReader(infile);

            // Record containing TextBox values to deserialize
            List<Record> records = (List<Record>)reader.Deserialize(infile);


            Store child = new Store();

            //sets MDI parent
            child.MdiParent = this;

            //set name of new child to the name of the company
            child.Text = records[0].Store;

            //adds items to lst view
            for (int i = 0; i < records.Count; i++)
            {
                Store.instance.LV.Items.Add(new ListViewItem(new string[] 
                { records[i].ID, records[i].Name, records[i].Price, 
                    records[i].Quantity }));
            }

            //shows child mdi
            child.Show();
        }


        //savetoolstripmenu calles the savefile dialog to save the file that
        //was created
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //creates a new savefile dialog
            SaveFileDialog sfd = new SaveFileDialog();

            //shows dialog
            sfd.ShowDialog();

            //creates the file useing safe file name as the new name
            FileStream output = new FileStream(sfd.FileName, FileMode.OpenOrCreate,
                FileAccess.Write);
            StreamWriter fileWriter = new StreamWriter(output);

            // creates a list of records
            List<Record> records = new List<Record>();
            Record record = new Record();

            //gives accsess to the active MDI child
            Store activeStore = (Store)this.ActiveMdiChild;

            //makes a new record to save items in the Listview
            foreach (ListViewItem l in activeStore.LV.Items)
            {
                //stores items in new record
                Record record1 = new Record();
                record1.ID = l.SubItems[0].Text;
                record1.Name = l.SubItems[1].Text;
                record1.Price = l.SubItems[2].Text;
                record1.Quantity = l.SubItems[3].Text;
                record1.Store = activeStore.Text;

                // adds the records to record1
                records.Add(record1);
            }

            //writes to and serializes to new file
            reader.Serialize(output, records);
            fileWriter.Close();
        }


        //deletetoolstripmenuitem click will delete an item that the user has
        //clicked
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //gives accsess to the active MDI child
            Store activeStore = (Store)this.ActiveMdiChild;

            // deletes item from list
            activeStore.LV.FocusedItem.Remove();

        }
        //exit tool is used to exit the program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}