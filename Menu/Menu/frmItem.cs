using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Menu
{
    public partial class frmItem : Form
    {
        public frmItem()
        {
            InitializeComponent();
        }
        float price;
        float discount=0;
        float grandtotal = 0.0f;
        int quantity=1;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            price = 12.5f;
            picShow.Image=picPizza.Image;
            lblnshow.Text = lblPizza.Text;
            lblpshow.Text = price.ToString("C");
        }

        private void picPepsi_Click(object sender, EventArgs e)
        {
            price = 1.0f;
            picShow.Image = picPepsi.Image;
            lblnshow.Text = lblPepsi.Text;
            lblpshow.Text = price.ToString("C");
        }

        private void picPotato_Click(object sender, EventArgs e)
        {
            price = 1.0f;
            picShow.Image = picPotato.Image;
            lblnshow.Text = lblPotao.Text;
            lblpshow.Text = price.ToString("C");
        }

        private void picChicken_Click(object sender, EventArgs e)
        {
            price = 7.0f;
            picShow.Image = picChicken.Image;
            lblnshow.Text = lblChicken.Text;
            lblpshow.Text = price.ToString("C");
        }

        private void picBurger_Click(object sender, EventArgs e)
        {
            price = 2.5f;
            picShow.Image= picBurger.Image;
            lblnshow.Text = lblBurger.Text;
            lblpshow.Text = price.ToString("C");
        }

        private void picCoca_Click(object sender, EventArgs e)
        {
            price = 1.0f;
            picShow.Image = picCoca.Image;
            lblnshow.Text = lblCoca.Text;
            lblpshow.Text = price.ToString("C");
        }

        private void picFanta_Click(object sender, EventArgs e)
        {
            price = 1.0f;
            picShow.Image = picFanta.Image;
            lblnshow.Text = lblFanta.Text;
            lblpshow.Text = price.ToString("C");
        }

        private void picSprite_Click(object sender, EventArgs e)
        {
            price=1.5f; 
            picShow.Image = picSprite.Image;  
            lblnshow.Text=lblSprite.Text;
            lblpshow.Text = price.ToString("C");
        }

        private void picApple_Click(object sender, EventArgs e)
        {
            price = 0.25f;
            picShow.Image = picApple.Image;
            lblnshow.Text = lblApple.Text;
            lblpshow.Text = price.ToString("C");
        }

        private void picOrange_Click(object sender, EventArgs e)
        {
            price = 0.25f;
            picShow.Image = picGrape.Image;
            lblnshow.Text = lblOrange.Text;
            lblpshow.Text = price.ToString("C");
        }

        private void picMango_Click(object sender, EventArgs e)
        {
            price = 1.0f;
            picShow.Image = picMango.Image; 
            lblnshow.Text = lblMango.Text;
            lblpshow.Text = price.ToString("C");
        }

        private void picMilk_Click(object sender, EventArgs e)
        {
            price = 1.25f;
            picShow.Image= picMilk.Image;
            lblnshow.Text = lblMilk.Text;
            lblpshow.Text = price.ToString("C");
        }

        private void picStrawberry_Click(object sender, EventArgs e)
        {
            price = 1.25f;
            picShow.Image = picStrawberry.Image;
            lblnshow.Text= lblStrawberry.Text + " Icecream";
            lblpshow.Text = price.ToString("C");
        }

        private void p_Click(object sender, EventArgs e)
        {
            price = 1.25f;
            picShow.Image = p.Image;
            lblnshow.Text = lblStrawberry.Text + " Icecream";
            lblpshow.Text = price.ToString("C");
        }

        private void picVanila_Click(object sender, EventArgs e)
        {
            price = 1.25f;
            picShow.Image = picVanila.Image;
            lblnshow.Text = lblStrawberry.Text + " Icecream";
            lblpshow.Text = price.ToString("C");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            float Total;
            quantity = int.Parse(lblqshow.Text);

            if(txtDiscount.Text == "" || txtDiscount==null )
            {
                discount = 0;
                txtDiscount.Text = "0";
            }
            if(txtDiscount.Text != "")
            {
                discount = float.Parse(txtDiscount.Text);
            }
           
            Total = (price * quantity)-(((price*quantity)*discount)/100);
            lblTotal.Text = Total.ToString("C");
            
            lblqshow.Text = quantity.ToString();
            
            grandtotal += Total;
            txtGrand.Text = grandtotal.ToString("C");
            //add to listbox
            AddItem();
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            quantity++;
            lblqshow.Text = quantity.ToString();
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            if(quantity == 1)
            {
                return;
            }
            if(quantity > 1)
            {
                quantity--;
                lblqshow.Text = quantity.ToString();
            }
        }

        private void frmItem_Load(object sender, EventArgs e)
        {
            columnHeader1.Width = lvwOrder.Width/4;
            columnHeader2.Width = lvwOrder.Width / 4;
            columnHeader3.Width = lvwOrder.Width / 4;
            columnHeader4.Width = lvwOrder.Width / 4;
        }
        public void AddItem()
        {
            ListViewItem lvi = new ListViewItem();
            lvi = lvwOrder.Items.Add(lblnshow.Text);
            lvi.SubItems.Add(quantity.ToString());
            lvi.SubItems.Add(txtDiscount.Text);
            lvi.SubItems.Add(lblTotal.Text);
            quantity = 1;
        }

        private void picGrape_Click(object sender, EventArgs e)
        {
            price = 0.5f;
            picShow.Image = picGrape.Image;
            lblnshow.Text = lblGrape.Text;
            lblpshow.Text = price.ToString("C");
        }

        private void btnFastFood_Click(object sender, EventArgs e)
        {
            pnlPizza.Show();
            pnlBurger.Show();
            PnlPotato.Show();
            pnlChicken.Show();
            pnlApple.Hide();    
            pnlOrange.Hide();
            pnlGrape.Hide();
            pnlMango.Hide();
            pnlCoca.Hide();
            pnlPepsi.Hide();
            pnlSprite.Hide();
            pnlFanta.Hide();
            pnlMilk.Hide();
            pnlStraberry.Hide();    
            pnlVanila.Hide();
            pnlChocolate.Hide();
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            pnlCoca.Show();
            pnlPepsi.Show();
            pnlSprite.Show();
            pnlFanta.Show();
            pnlApple.Hide();
            pnlOrange.Hide();
            pnlGrape.Hide();
            pnlMango.Hide();
            pnlMilk.Hide();
            pnlStraberry.Hide();
            pnlVanila.Hide();
            pnlChocolate.Hide();
            pnlPizza.Hide();
            pnlBurger.Hide();
            PnlPotato.Hide();
            pnlChicken.Hide();
        }

        private void btnFruit_Click(object sender, EventArgs e)
        {
            pnlOrange.Show();
            pnlGrape.Show();
            pnlMango.Show();
            pnlApple.Show();
            pnlMilk.Hide();
            pnlStraberry.Hide();
            pnlVanila.Hide();
            pnlChocolate.Hide();
            pnlPizza.Hide();
            pnlBurger.Hide();
            PnlPotato.Hide();
            pnlChicken.Hide();
            pnlCoca.Hide();
            pnlPepsi.Hide();
            pnlSprite.Hide();
            pnlFanta.Hide();
        }

        private void btnIcecream_Click(object sender, EventArgs e)
        {
            pnlStraberry.Show();
            pnlVanila.Show();
            pnlChocolate.Show();
            pnlMilk.Show();
            pnlPizza.Hide();
            pnlBurger.Hide();
            PnlPotato.Hide();
            pnlChicken.Hide();
            pnlCoca.Hide();
            pnlPepsi.Hide();
            pnlSprite.Hide();
            pnlFanta.Hide();
            pnlApple.Hide();
            pnlOrange.Hide();
            pnlGrape.Hide();
            pnlMango.Hide();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            pnlStraberry.Show();
            pnlVanila.Show();
            pnlChocolate.Show();
            pnlMilk.Show();
            pnlApple.Show();
            pnlOrange.Show();
            pnlGrape.Show();
            pnlMango.Show();
            pnlCoca.Show();
            pnlPepsi.Show();
            pnlSprite.Show();
            pnlFanta.Show();
            pnlPizza.Show();
            pnlBurger.Show();
            PnlPotato.Show();
            pnlChicken.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
