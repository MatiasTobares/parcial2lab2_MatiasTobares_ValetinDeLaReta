using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial2lab2_MatiasTobares_ValetinDeLaReta
{
    public partial class Form1 : Form
    {

        int valorTotal=0, cantidadTotal = 0,precioUnidad = 0,aux=0,aux2=0;
        Pantalon pantalon = new Pantalon();
        Camisa camisa = new Camisa();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            precioUnidad = Convert.ToInt32(txtPrecio.Text);
            cantidadTotal = Convert.ToInt32(txtCantidad.Text);
            //Saca los valores de las camisas 

            if (rbtCamisa.Checked == true) //CAMISA SOLO
            { 
                valorTotal = cantidadTotal * precioUnidad;
            }
            
            if (rbtCamisa.Checked == true && ckbMangaCorta.Checked == true) //CAMISA Y MANGA CORTA
            {
                valorTotal= cantidadTotal* precioUnidad; 
                aux = 10 * valorTotal / 100;  
                valorTotal = valorTotal -  aux;               
            }
            if(rbtCamisa.Checked == true && rtbPremium.Checked == true) //CAMISA Y PREMIUM
            {
                valorTotal = cantidadTotal * precioUnidad;
                aux = 30 * valorTotal / 100;
                valorTotal = valorTotal + aux;
            }                      
            if (rbtCamisa.Checked == true && ckbMangaCorta.Checked == true && rtbPremium.Checked == true) //CAMISA MANGA CORTA Y PREMIUM
            {
                valorTotal = cantidadTotal * precioUnidad; //200
                aux = 10 * valorTotal / 100;  
                valorTotal = valorTotal - aux; 
                aux2 = 30 * valorTotal / 100;
                valorTotal = valorTotal + aux2;          
            }

            //Saca los valores de las pantalones
            if (rbnPantalones.Checked == true && ckbBermuda.Checked == false) //pantalon
            {
                valorTotal = cantidadTotal * precioUnidad;
            }          
            if (rbnPantalones.Checked == true && ckbBermuda.Checked == true) //Pantalon y bermuda
            {
                valorTotal = cantidadTotal * precioUnidad;
                aux = 20 * valorTotal / 100;
                valorTotal = valorTotal - aux;
            }
            if(rbnPantalones.Checked==true && rtbPremium.Checked == true) //Pantalon y premium
            {
                valorTotal = cantidadTotal * precioUnidad;
                aux = 30 * valorTotal / 100;
                valorTotal = valorTotal + aux;
            }       
            if (rbnPantalones.Checked == true && ckbBermuda.Checked == true&& rtbPremium.Checked == true)//Pantalon bermuda y premium
            {
                valorTotal = cantidadTotal * precioUnidad;
                aux = 20 * valorTotal / 100;
                valorTotal = valorTotal - aux;             
                aux2 = 30 * valorTotal / 100;
                valorTotal = valorTotal + aux2;
            }

            MessageBox.Show("El precio total es: " + valorTotal);


        }





    }
}



