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
    public partial class ProductsView : Form, IProductsView
    {

        private bool isEdit;
        private bool isSuccesful;
        private string message;

        public ProductsView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPageProductsDetails);

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

                tabControl1.TabPages.Remove(tabPageProductsList);
                tabControl1.TabPages.Add(tabPageProductsDetails);
                tabPageProductsDetails.Text = "Add New Products"; // cambia titutlo pestaña
            };

            BtnEdit.Click += delegate
            {
                SearchEvent?.Invoke(this, EventArgs.Empty);
                EditEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageProductsList);
                tabControl1.TabPages.Add(tabPageProductsDetails);
                tabPageProductsDetails.Text = "Edit New Products";
            };

            BtnDelete.Click += delegate
            {
                SearchEvent?.Invoke(this, EventArgs.Empty);
                var result = MessageBox.Show(
                    "Are you sure you want to delete the selected Products",
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
                    tabControl1.TabPages.Remove(tabPageProductsDetails);
                    tabControl1.TabPages.Add(tabPageProductsList);
                }
                MessageBox.Show(Message);
            };

            BtnCancel.Click += delegate
            {
                SearchEvent?.Invoke(this, EventArgs.Empty);
                CancelEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageProductsDetails);
                tabControl1.TabPages.Add(tabPageProductsList);
            };


        }

        public string ProductsId
        {
            get { return TxtProductsId.Text; }
            set { TxtProductsId.Text = value; }
        }
        public string ProductsName
        {
            get { return TxtProductsName.Text; }
            set { TxtProductsName.Text = value; }
        }
        public string ProductsPrice
        {
            get { return TxtPrice.Text; }
            set { TxtPrice.Text = value; }
        }
        public string ProductsStock
        {
            get { return TxtStock.Text; }
            set { TxtStock.Text = value; }
        }
        public string Products_IdCategory
        {
            get { return CBoxIdCategory.Text; }
            set { CBoxIdCategory.Text = value; }
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

        public void SetProductsListBildingSource(BindingSource productsList)
        {
            DgProducts.DataSource = productsList;

        }
        //Patron singleton, controla que solo haya una instancia
        private static ProductsView instance;
        public static ProductsView GetInstance(Form parentCointainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProductsView();
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
