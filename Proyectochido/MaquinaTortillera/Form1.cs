using MaquinaTortillera.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinaTortillera
{
    public partial class frmDatosMaquinaTortillera : MetroFramework.Forms.MetroForm 
    {
        

        public frmDatosMaquinaTortillera()
        {
            InitializeComponent();
        }

        private void txtNotas_Click(object sender, EventArgs e)
        {

        }

        private void txtTipo_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void FrmDatosMaquinaTortillera_Load(object sender, EventArgs e)
        {
            using (DataContext dataContext = new DataContext())
            {
                productBindingSource.DataSource =
                        dataContext.Products.ToList();
            }
            this.pnlDatos.Enabled = false;
            Product product = productBindingSource.Current as Product;
            if(product!=null&&product .ImageUrl!=null)
            {
                pctFoto.Image = Image.FromFile(product.ImageUrl);
            }
            else

            {
                this.pctFoto.Image = null;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.pnlDatos.Enabled = true;
            this.txtTamaño.Focus();
            Product product = productBindingSource.Current as Product;

        }

        private void lblRiego_Click(object sender, EventArgs e)
        {

        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            this.pnlDatos.Enabled = true;
            this.pctFoto .Image = null;
            productBindingSource.Add(new Product());
            productBindingSource.MoveLast();
            this.txtTamaño.Focus();

        }
       


        private void metroButton5_Click(object sender, EventArgs e)
        {

            using(DataContext dataContext =new DataContext ())
            {
                Product product = productBindingSource.Current as Product;
                if(product!=null)
                {
                    if (dataContext.Entry<Product>(product).State == EntityState.Detached)
                        dataContext.Set<Product>().Attach(product);
                    if (product.Id == 0)
                        dataContext.Entry<Product>(product).State = EntityState.Added;
                  else
                        dataContext.Entry<Product>(product).State = EntityState.Modified ;
                    dataContext.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "producto agregado");
                    this.grdDatos.Refresh();
                    this.pnlDatos.Enabled = false;
                }
            }
        }

        private void pnlDatos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd=new OpenFileDialog()
            {
                Filter ="Archivos JPEG|*.jpeg|Todos los archivos|*.*|Archivos PNG|*.png"
            })
            {
                if(ofd.ShowDialog ()==DialogResult.OK )
                {
                    try
                    {
                        this.pctFoto.Image = Image.FromFile(ofd.FileName);
                        Product product = productBindingSource.Current as Product;
                        if (product != null)
                        {
                            product.ImageUrl = ofd.FileName;

                        }
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message);
                    }


                }
            }
        }

        private void grdDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Product product = productBindingSource.Current as Product;
            if (product != null && product.ImageUrl != null)
            {
                pctFoto.Image = Image.FromFile(product.ImageUrl);
            }
            else

            {
                this.pctFoto.Image = null;
            }

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            this.pnlDatos.Enabled = false;
            productBindingSource.ResetBindings(false);
            this.FrmDatosMaquinaTortillera_Load(sender, e);
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "¿Quieres eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                using(DataContext dataContext = new DataContext())
            {
                    Product product = productBindingSource.Current as Product;
                    if(product !=null)
                    {
                        if (dataContext.Entry<Product>(product).State == EntityState.Detached)
                        {
                            dataContext.Set<Product>().Attach(product);
                        }
                            dataContext.Entry<Product>(product).State = EntityState.Deleted ;
                        dataContext.SaveChanges();
                        MetroFramework.MetroMessageBox.Show(this, "Producto eliminado");
                        productBindingSource.RemoveCurrent();
                        this.pctFoto.Image = null;
                        pnlDatos.Enabled = false;

                    }
                }
            } }
    }
}
