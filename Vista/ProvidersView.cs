using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Vista
{
    public partial class ProvidersView : Form, IProvidersView
    {
        private bool isEdit;
        private bool isSuccesful;
        private string message;
        public ProvidersView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPageProvidersDetail);

            BtnExit.Click += delegate { this.Close(); };
        }
        private void AssociateAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            // agregar el evento cuando se ahaga clic en el boton New
            BtnNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageProvidersList);
                tabControl1.TabPages.Add(tabPageProvidersDetail);
                tabPageProvidersDetail.Text = "Add New Providers"; // cambia titutlo pestaña
            };

            BtnEdit.Click += delegate
            {
                SearchEvent?.Invoke(this, EventArgs.Empty);
                EditEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageProvidersList);
                tabControl1.TabPages.Add(tabPageProvidersDetail);
                tabPageProvidersDetail.Text = "Edit New Providers";
            };

            BtnDelete.Click += delegate
            {
                SearchEvent?.Invoke(this, EventArgs.Empty);
                var result = MessageBox.Show(
                    "Are you sure you want to delete the selected Providers",
                    "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            BtnSave.Click += delegate
            {
                SearchEvent?.Invoke(this, EventArgs.Empty);
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccesful) // Si Grabar fue exitoso
                {
                    tabControl1.TabPages.Remove(tabPageProvidersDetail);
                    tabControl1.TabPages.Add(tabPageProvidersList);
                }
                MessageBox.Show(Message);
            };

            BtnCancel.Click += delegate
            {
                SearchEvent?.Invoke(this, EventArgs.Empty);
                CancelEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageProvidersDetail);
                tabControl1.TabPages.Add(tabPageProvidersList);
            };
        }

        public string ProvidersId
        {
            get { return TxtProvidersId.Text; }
            set { TxtProvidersId.Text = value; }
        }
        public string ProvidersName
        {
            get { return TxtProvidersName.Text; }
            set { TxtProvidersName.Text = value; }
        }
        public string ProvidersDescription
        {
            get { return TxtProvidersDescription.Text; }
            set { TxtProvidersDescription.Text = value; }
        }
        public string SearchValue
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }

        }
        public bool
            Edit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccesful
        {
            get { return isSuccesful; }
            set { isSuccesful = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public bool IsEdit { get { return isEdit; } set { isEdit = value; } }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetProvidersListBildingSource(BindingSource providersList)
        {
            DgProviders.DataSource = providersList;

        }
        //Patron singleton, controla que solo haya una instancia
        private static ProvidersView instance;
        public static ProvidersView GetInstance(Form parentCointainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProvidersView();
                instance.MdiParent = parentCointainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }

    }
}

