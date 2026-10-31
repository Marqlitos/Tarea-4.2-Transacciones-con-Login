/*
 * Created by SharpDevelop.
 * User: marco
 * Date: 31/10/2026
 * Time: 04:15 p. m.
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
	/// Description of FormEditarProducto.
	/// </summary>
	public partial class FormEditarProducto : Form
	{
		string cadenaConexion = "Server=localhost;Database=punto_venta;Uid=root;Pwd=root;SslMode=none;AllowPublicKeyRetrieval=True;";
		
		public FormEditarProducto(string claveBuscada)
		{
			InitializeComponent();
			
			// Bloqueamos la clave para que no la puedan modificar
			txtClave.Text = claveBuscada;
			txtClave.ReadOnly = true;

			// Llamamos al método que carga los datos de la base de datos
			CargarDatos();
		}
		
		public FormEditarProducto()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private void CargarDatos()
		{
			using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
			{
				try
				{
					conn.Open();
					string query = "SELECT descripcion, precio, stock FROM PRODUCTOS WHERE clave = @clave";
					using (MySqlCommand cmd = new MySqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@clave", txtClave.Text);
						using (MySqlDataReader reader = cmd.ExecuteReader())
						{
							if (reader.Read())
							{
								
								txtDescripcion.Text = reader.GetString("descripcion");
								txtPrecio.Text = reader.GetDecimal("precio").ToString("0.00");
								txtStock.Text = reader.GetInt32("stock").ToString();
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error al cargar el producto: " + ex.Message);
				}
			}
		}
		
		void BtnActualizarClick(object sender, EventArgs e)
		{
			using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
			{
				try
				{
					conn.Open();
					string query = "UPDATE PRODUCTOS SET descripcion = @desc, precio = @precio, stock = @stock WHERE clave = @clave";
					
					using (MySqlCommand cmd = new MySqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@desc", txtDescripcion.Text.ToUpper());
						cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtPrecio.Text));
						cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(txtStock.Text));
						cmd.Parameters.AddWithValue("@clave", txtClave.Text);

						cmd.ExecuteNonQuery();
					}

					MessageBox.Show("¡Producto actualizado correctamente en la base de datos!", "Éxito");
					this.Close(); 
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error al actualizar: " + ex.Message, "Error BD");
				}
			}
		}
		void BtnSalirClick(object sender, EventArgs e)
		{
			
		}
	}
}