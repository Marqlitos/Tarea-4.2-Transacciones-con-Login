/*
 * Created by SharpDevelop.
 * User: marco
 * Date: 28/10/2026
 * Time: 04:21 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PuntoVenta
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private void BuscarYAgregarProducto()
		{
			string codigoBuscado = txtCodigoBarra.Text.Trim();

			if (string.IsNullOrWhiteSpace(codigoBuscado)) return;

			string connectionString = "Server=localhost;Database=punto_venta;Uid=root;Pwd=root;SslMode=none;AllowPublicKeyRetrieval=True;";

			using (MySqlConnection conn = new MySqlConnection(connectionString))
			{
				try
				{
					conn.Open();
					// Buscamos el producto por su clave
					string query = "SELECT clave, descripcion, precio FROM PRODUCTOS WHERE clave = @clave";

					using (MySqlCommand cmd = new MySqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@clave", codigoBuscado);

						using (MySqlDataReader reader = cmd.ExecuteReader())
						{
							if (reader.Read()) 
							{
								string clave = reader.GetString("clave");
								string descripcion = reader.GetString("descripcion");
								decimal precio = reader.GetDecimal("precio");

								int cantidad = 1; 
								decimal importe = precio * cantidad;

								dataGridView1.Rows.Add(clave, descripcion, cantidad, precio, importe);

								txtCodigoBarra.Clear();
								txtCodigoBarra.Focus();

								CalcularTotales();
							}
							else
							{
								MessageBox.Show("Producto no encontrado.", "Aviso");
								txtCodigoBarra.SelectAll();
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error al buscar: " + ex.Message, "Error BD");
				}
			}
		}
		
		private void LimpiarVenta()
		{
			dataGridView1.Rows.Clear();

			txtSubtotal.Text = "0.00";
			txtIva.Text = "0.00";
			txtTotal.Text = "0.00";

			txtCodigoBarra.Clear();
			txtCodigoBarra.Focus();
		}
		
		private void CalcularTotales()
		{
			decimal subtotal = 0;
			
			// Sumar el importe de todos los productos en el GRID
			foreach (DataGridViewRow fila in dataGridView1.Rows)
			{
				if (!fila.IsNewRow && fila.Cells["Importe"].Value != null)
				{
					subtotal += Convert.ToDecimal(fila.Cells["Importe"].Value);
				}
			}

			// Calcular IVA y Total
			decimal iva = subtotal * 0.16m;
			decimal total = subtotal + iva;

			txtSubtotal.Text = subtotal.ToString("0.00");
			txtIva.Text = iva.ToString("0.00");
			txtTotal.Text = total.ToString("0.00");
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			DialogResult respuesta = MessageBox.Show("¿Estás seguro de que deseas Salir?",
			                                         "Confirmación", MessageBoxButtons.YesNo,
			                                         MessageBoxIcon.Question);
			if (respuesta == DialogResult.Yes)
			{
				MessageBox.Show("Sesion Cerrada, ¡Hasta luego!.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Application.Exit();
			}
			else
			{
				// Código que se ejecuta si el usuario hace clic en "No" o cierra la ventana
				MessageBox.Show("¡Operación cancelada!.", "¡Cancelado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		void ToolTip1Popup(object sender, PopupEventArgs e)
		{
			
		}
		
		void BtnGuardarClick(object sender, EventArgs e)
		{
			//Logica de boton de guardar
			
			if(dataGridView1.Rows.Count ==0){
				MessageBox.Show("No hay productos para vender...");
				return;
			}
			
			string connectionString = "Server=localhost;Database=punto_venta;Uid=root;Pwd=root;SslMode=none;AllowPublicKeyRetrieval=True;";

			
			using (MySqlConnection conn = new MySqlConnection(connectionString))
			{
				conn.Open();
				MySqlTransaction transaccion = conn.BeginTransaction();

				try
				{
					string queryVenta = "INSERT INTO VENTAS (fecha, subtotal, iva, total) VALUES (@fecha, @subtotal, @iva, @total); SELECT LAST_INSERT_ID();";
					MySqlCommand cmdVenta = new MySqlCommand(queryVenta, conn, transaccion);
					cmdVenta.Parameters.AddWithValue("@fecha", DateTime.Now);
					cmdVenta.Parameters.AddWithValue("@subtotal", Convert.ToDecimal(txtSubtotal.Text));
					cmdVenta.Parameters.AddWithValue("@iva", Convert.ToDecimal(txtIva.Text));
					cmdVenta.Parameters.AddWithValue("@total", Convert.ToDecimal(txtTotal.Text));

					long idVentaInsertada = Convert.ToInt64(cmdVenta.ExecuteScalar());

					foreach (DataGridViewRow fila in dataGridView1.Rows)
					{

						if (fila.IsNewRow) continue;

						string claveProd = fila.Cells["Clave"].Value.ToString();
						int cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value);
						decimal precio = Convert.ToDecimal(fila.Cells["Precio"].Value);
						decimal importe = Convert.ToDecimal(fila.Cells["Importe"].Value);
						
						string queryDetalle = "INSERT INTO DETALLES_VENTA (id_venta, clave_producto, cantidad, precio_unitario, importe) VALUES (@idVenta, @clave, @cantidad, @precio, @importe)";
						MySqlCommand cmdDetalle = new MySqlCommand(queryDetalle, conn, transaccion);
						cmdDetalle.Parameters.AddWithValue("@idVenta", idVentaInsertada);
						cmdDetalle.Parameters.AddWithValue("@clave", claveProd);
						cmdDetalle.Parameters.AddWithValue("@cantidad", cantidad);
						cmdDetalle.Parameters.AddWithValue("@precio", precio);
						cmdDetalle.Parameters.AddWithValue("@importe", importe);
						cmdDetalle.ExecuteNonQuery();

						string queryStock = "UPDATE PRODUCTOS SET stock = stock - @cantidad WHERE clave = @clave";
						MySqlCommand cmdStock = new MySqlCommand(queryStock, conn, transaccion);
						cmdStock.Parameters.AddWithValue("@cantidad", cantidad);
						cmdStock.Parameters.AddWithValue("@clave", claveProd);
						cmdStock.ExecuteNonQuery();
					}

					transaccion.Commit();
					MessageBox.Show("Venta guardada y stock actualizado correctamente.");
					LimpiarVenta();
				}
				catch (Exception ex)
				{
					transaccion.Rollback();
					MessageBox.Show("Error al procesar la venta. Se cancelaron los cambios: " + ex.Message);
				}
			}
		}
		void BtnAgregarClick(object sender, EventArgs e)
		{
			string codigoEscaneado = txtCodigoBarra.Text.Trim();

			if (string.IsNullOrWhiteSpace(codigoEscaneado))
			{
				MessageBox.Show("Por favor, ingresa o escanea un código de barras primero.", "Aviso");
				return;
			}

			FormAgregarProducto formNuevo = new FormAgregarProducto(codigoEscaneado);
			
			formNuevo.ShowDialog();
		}
		void TxtCodigoBarraKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				e.Handled = true; 
				BuscarYAgregarProducto(); 
			}
		}
		void BtnBorrarClick(object sender, EventArgs e)
		{
			if (dataGridView1.CurrentRow != null)
			{
				if (!dataGridView1.CurrentRow.IsNewRow)
				{
					dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

					CalcularTotales();
				}
				else
				{
					MessageBox.Show("Selecciona un producto válido para eliminar, no la fila vacía.", "Aviso");
				}
			}
			else
			{
				MessageBox.Show("Por favor, haz clic sobre el producto que deseas eliminar de la lista.", "Aviso");
			}
		}
		
		
	}
}