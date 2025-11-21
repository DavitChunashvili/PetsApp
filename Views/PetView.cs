using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_Project.Views
{
    public partial class PetView : Form, IPetView
    {
        //Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        private string petcolour;

        //Constructor
        public PetView()
        {
            InitializeComponent();
            AssiciateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPagePetDetail);
            btnClose.Click += delegate { this.Close(); };
        }

        private void AssiciateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            //Add new
            btnAddNew.Click += delegate
            { 
                AddNewEvent?.Invoke(this, EventArgs.Empty); 
                tabControl1.TabPages.Remove(tabPagePetList);
                tabControl1.TabPages.Add(tabPagePetDetail);
                tabPagePetDetail.Text = "Add New Pet";
            };
            //Edit
            btnEdit.Click += delegate 
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPagePetList);
                tabControl1.TabPages.Add(tabPagePetDetail);
                tabPagePetDetail.Text = "Add Edit Pet";
            };
            //Delete
            btnDelete.Click += delegate 
            {
                DeleteEvent?.Invoke(this, EventArgs.Empty);
                var result = MessageBox.Show("Are you sure that you want to delete the selected pet?", "Warning",
                             MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
            //Save
            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPagePetDetail);
                    tabControl1.TabPages.Add(tabPagePetList);
                }
                MessageBox.Show(Message);
            };
            //Cancel
            btnCancel.Click += delegate 
            { 
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPagePetDetail);
                tabControl1.TabPages.Add(tabPagePetList);

            };
        }

        //Properties - Fields
        public string PetID 
        { 
            get => txtPetId.Text;
            set => txtPetId.Text = value;
        }
        public string PetName
        { 
            get => txtPetName.Text;
            set => txtPetName.Text = value;
        }
        public string PetType
        {
            get => txtPetType.Text; 
            set => txtPetType.Text = value; 
        }
        public string PetColour 
        { 
            get => txtPetColour.Text; 
            set => txtPetColour.Text = value;
        }
        public string SearchValue
        { 
            get => txtSearch.Text; 
            set => txtSearch.Text = value;
        }
        public bool IsEdit 
        {
            get => isEdit;
            set => isEdit = value;
        }
        public bool IsSuccessful
        {
            get => isSuccessful;
            set => isSuccessful = value;
        }
        public string Message 
        {
            get => message;
            set => message = value; 
        }

        //Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        //Methods
        public void SetPetListBindingSource(BindingSource petList)
        {
            dataGridView.DataSource = petList;
        }
        //Singleton pattern (Open a single form instance)
        private static PetView instance;
        public static PetView GetInstance(Form parrentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PetView();
                instance.MdiParent = parrentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill; 
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                    instance.BringToFront();    
                }
            }
                
            return instance;
        }
    }
}
