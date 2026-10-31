/*
 * Created by SharpDevelop.
 * User: marco
 * Date: 31/10/2026
 * Time: 02:33 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PuntoVenta
{
	/// <summary>
	/// Description of FormAgregarProducto.
	/// </summary>
	public partial class FormAgregarProducto : Form
	{
		public FormAgregarProducto(string codigoDeBarras)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			txtClave.Text = codigoDeBarras;
			txtClave.ReadOnly = true;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void FormAgregarProductoLoad(object sender, EventArgs e)
		{
			
		}
		void BtnGuardarProductoClick(object sender, EventArgs e)
		{
			// Validaciones básicas
			if (string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
			    string.IsNullOrWhiteSpace(txtPrecio.Text) ||
			    string.IsNullOrWhiteSpace(txtStock.Text))
			{
				MessageBox.Show("Por favor, llena todos los campos.");
				return;
			}

			string connectionString = "Server=localhost;Database=punto_venta;Uid=root;Pwd=root;SslMode=none;AllowPublicKeyRetrieval=True;";

			using (MySqlConnection conn = new MySqlConnection(connectionString))
			{
				try
				{
					conn.Open();
					string query = "INSERT INTO PRODUCTOS (clave, descripcion, precio, stock) VALUES (@clave, @descripcion, @precio, @stock)";
					
					using (MySqlCommand cmd = new MySqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@clave", txtClave.Text);
						cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text.ToUpper()); // Guardar en mayúsculas
						cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtPrecio.Text));
						cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(txtStock.Text));

						cmd.ExecuteNonQuery();
					}

					MessageBox.Show("¡Producto registrado con éxito!", "Éxito");
					this.Close(); 
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error al guardar el producto: " + ex.Message, "Error BD");
				}
			}
		}
		void BtnSalirClick(object sender, EventArgs e)
		{
			
			DialogResult respuesta = MessageBox.Show("¿Estás seguro de que ya no quieres agregar un producto?",
			                                         "Confirmación", MessageBoxButtons.YesNo,
			                                         MessageBoxIcon.Question);
			if (respuesta == DialogResult.Yes)
			{
				MessageBox.Show("Operacion Cancelada, ¡Hasta luego!.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
			else
			{
				MessageBox.Show("¡Operación cancelada!.", "¡Cancelado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}
}