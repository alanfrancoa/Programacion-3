using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarritoServices.Models;
using CarritoServices.Services;

namespace CarritoClient
{
    public partial class Form1 : Form
    {   //Creamos
        private long lastId = 0;
        private readonly List<Articulo> articleList;
        private readonly Carrito carrito;
        public Form1()
        {
            InitializeComponent();
            //Instanciamos 
            this.articleList = new List<Articulo>();
            this.carrito = new Carrito();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string detail = detailTextBox.Text;
            string sPrice = priceTextBox.Text; //el textbox captura string
            decimal price = decimal.Parse(sPrice);//parseamos precio

            this.lastId++;//aumentamos valor de ID
            Articulo newArticle = new Articulo(lastId, detail, price);//Creamos objeto
            this.articleList.Add(newArticle);//agregamos objeto a la lista

            //visualizamos el datagrid con la lista de articulos
            dataGridView.DataSource = null; //hace que actualice cada vez que se agrega un item
            dataGridView.DataSource = articleList; 


        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string sId= idCartTextBox.Text; //capturo id de textbox
            long id = long.Parse(sId); //parseo

            //itero en lista de articulos
            foreach (Articulo article in articleList)
            {
                if (article.id == id) //si el id de mi articulo es igual al ingresado
                {
                    carrito.add(article); //agrego articulo al carrito
                    break;
                }
            }
            string sTotalCarrito = carrito.getTotal().ToString();
            this.totalLabel.Text = sTotalCarrito;
        }
    }
}
