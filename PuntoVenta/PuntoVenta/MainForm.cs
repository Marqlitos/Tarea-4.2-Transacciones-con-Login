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
using System.IO;

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
			
			foreach (DataGridViewRow fila in dataGridView1.Rows)
			{
				if (!fila.IsNewRow && fila.Cells["Importe"].Value != null)
				{
					subtotal += Convert.ToDecimal(fila.Cells["Importe"].Value);
				}
			}

			decimal descuento = 0;
			if (!string.IsNullOrWhiteSpace(txtDescuento.Text))
			{
				decimal.TryParse(txtDescuento.Text, out descuento);
			}

			decimal subtotalConDescuento = subtotal - descuento;
			if (subtotalConDescuento < 0) subtotalConDescuento = 0; 

			decimal iva = subtotalConDescuento * 0.16m;
			decimal total = subtotalConDescuento + iva;

			txtSubtotal.Text = subtotal.ToString("0.00");
			txtIva.Text = iva.ToString("0.00");
			txtTotal.Text = total.ToString("0.00");
			
			txtCambio.Text = "0.00";
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
			//Logica de Agregar
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
			//La caja de texto detecta cuando el usuario da enter
			if (e.KeyChar == (char)Keys.Enter)
			{
				e.Handled = true;
				BuscarYAgregarProducto();
			}
		}
		
		void BtnBorrarClick(object sender, EventArgs e)
		{
			//Logica de boton de borrado
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
		
		void BtnAumentarClick(object sender, EventArgs e)
		{
			//Boton de Aumentar Cantidad
			if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
			{
				int cantidad = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Cantidad"].Value);
				decimal precio = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["Precio"].Value);
				cantidad++;

				dataGridView1.CurrentRow.Cells["Cantidad"].Value = cantidad;
				dataGridView1.CurrentRow.Cells["Importe"].Value = precio * cantidad;

				CalcularTotales();
			}
			
			
		}
		void BtnDisminuirClick(object sender, EventArgs e)
		{
			//Boton de Aumentar Cantidad
			if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
			{
				int cantidad = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Cantidad"].Value);
				decimal precio = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["Precio"].Value);

				
				if (cantidad > 1)
				{
					cantidad--;

					dataGridView1.CurrentRow.Cells["Cantidad"].Value = cantidad;
					dataGridView1.CurrentRow.Cells["Importe"].Value = precio * cantidad;

					CalcularTotales();
				}
				else
				{
					MessageBox.Show("La cantidad no puede ser menor a 1. Si el cliente ya no quiere el producto, usa el botón rojo de eliminar.", "Aviso");
				}
				
			}
		}
		void BtnBuscarClick(object sender, EventArgs e)
		{
			//Logica de boton Buscar
			string nombreBuscado = txtBuscarNombre.Text.Trim();

			if (string.IsNullOrWhiteSpace(nombreBuscado))
			{
				MessageBox.Show("Escribe el nombre del producto que deseas buscar.", "Aviso");
				return;
			}

			
			string connectionString = "Server=localhost;Database=punto_venta;Uid=root;Pwd=root;SslMode=none;AllowPublicKeyRetrieval=True;";

			using (MySqlConnection conn = new MySqlConnection(connectionString))
			{
				try
				{
					conn.Open();
					
					string query = "SELECT clave, descripcion, precio FROM PRODUCTOS WHERE descripcion LIKE @nombre LIMIT 1";
					
					using (MySqlCommand cmd = new MySqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@nombre", "%" + nombreBuscado + "%");
						
						using (MySqlDataReader reader = cmd.ExecuteReader())
						{
							if (reader.Read())
							{
								string clave = reader.GetString("clave");
								string descripcion = reader.GetString("descripcion");
								decimal precio = reader.GetDecimal("precio");
								
								int cantidad = 1;
								decimal importe = precio * cantidad;

								// Agregamos el producto al GRID
								dataGridView1.Rows.Add(clave, descripcion, cantidad, precio, importe);

								// Limpiamos la caja de búsqueda
								txtBuscarNombre.Clear();

								// Actualizamos los totales
								CalcularTotales();
							}
							else
							{
								MessageBox.Show("No se encontró ningún producto con ese nombre.", "Búsqueda");
								txtBuscarNombre.SelectAll();
								txtBuscarNombre.Focus();
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
		
		void BtnEditarClick(object sender, EventArgs e)
		{
			//Logica de editar objeto
			if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
			{
				string claveSeleccionada = dataGridView1.CurrentRow.Cells["Clave"].Value.ToString();

				FormEditarProducto formEditar = new FormEditarProducto(claveSeleccionada);
				formEditar.ShowDialog();
			}
			else
			{
				MessageBox.Show("Por favor, selecciona un producto de la lista para editarlo.", "Aviso");
			}
		}
		
		void BtnGuardarVentaClick(object sender, EventArgs e)
		{
			//logica de guardar la venta
			if (dataGridView1.Rows.Count == 0 || (dataGridView1.Rows.Count == 1 && dataGridView1.Rows[0].IsNewRow))
			{
				MessageBox.Show("No hay productos en la lista para guardar.", "Aviso");
				return;
			}

			try
			{
				string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				string rutaArchivo = Path.Combine(rutaEscritorio, "Historial_Ventas_AbarroTECNM.txt");

				using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
				{
					// Escribir el encabezado del ticket
					sw.WriteLine("=========================================");
					sw.WriteLine("AbarroTECNM - Registro de Venta");
					sw.WriteLine("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
					sw.WriteLine("-----------------------------------------");
					sw.WriteLine("CANT. | DESCRIPCIÓN | PRECIO | IMPORTE");
					sw.WriteLine("-----------------------------------------");

					foreach (DataGridViewRow fila in dataGridView1.Rows)
					{
						if (!fila.IsNewRow && fila.Cells["Importe"].Value != null)
						{
							string cantidad = fila.Cells["Cantidad"].Value.ToString();
							string descripcion = fila.Cells["Descripcion"].Value.ToString();
							string precio = fila.Cells["Precio"].Value.ToString();
							string importe = fila.Cells["Importe"].Value.ToString();

							// Formato de línea para cada producto
							sw.WriteLine(cantidad + "x " + descripcion + " - $" + precio + " = $" + importe);
						}
					}
					sw.WriteLine("-----------------------------------------");
					sw.WriteLine("Subtotal: $" + txtSubtotal.Text);
					sw.WriteLine("IVA:      $" + txtIva.Text);
					sw.WriteLine("TOTAL:    $" + txtTotal.Text);
					sw.WriteLine("=========================================");
					sw.WriteLine();
				}

				MessageBox.Show("Historial de venta guardado correctamente en tu Escritorio.", "Éxito");
				
				// LimpiarVenta();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al guardar el archivo .txt: " + ex.Message, "Error");
			}
		}
		
		void BtnAbrirVentaClick(object sender, EventArgs e)
		{
			//Logica de abrir Archivo
			try
			{
				// Definir la misma ruta que usamos para guardar
				string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				string rutaArchivo = Path.Combine(rutaEscritorio, "Historial_Ventas_AbarroTECNM.txt");

				//Verificar si el archivo ya existe
				if (File.Exists(rutaArchivo))
				{
					System.Diagnostics.Process.Start(rutaArchivo);
				}
				else
				{
					// Si el archivo no existe, le avisamos al usuario
					MessageBox.Show("Aún no hay ningún historial de ventas guardado. Registra y guarda una venta primero.", "Archivo no encontrado");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al intentar abrir el historial: " + ex.Message, "Error");
			}
		}
		
		void BtnRegresarAccionClick(object sender, EventArgs e)
		{
			//Logicca de regregar accion btn
			int totalFilas = dataGridView1.Rows.Count;

			if (totalFilas > 0)
			{
				// Identificamos el índice de la última fila de la tabla
				int ultimoIndice = totalFilas - 1;

				// Si esa última fila es el espacio en blanco que C# pone por defecto al final, retrocedemos un espacio
				if (dataGridView1.Rows[ultimoIndice].IsNewRow)
				{
					ultimoIndice--;
				}

				// Si después de verificar hay un producto válido para borrar
				if (ultimoIndice >= 0)
				{
					// Eliminamos la fila exacta usando su índice
					dataGridView1.Rows.RemoveAt(ultimoIndice);
					
					// Recalculamos los totales para que la cuenta se ajuste
					CalcularTotales();
				}
				else
				{
					MessageBox.Show("La lista ya está vacía, no hay acciones para deshacer.", "Deshacer");
				}
			}
		}
		
		void BtnCorteClick(object sender, EventArgs e)
		{
			//Logica de boton de guardar Corte
			string connectionString = "Server=localhost;Database=punto_venta;Uid=root;Pwd=root;SslMode=none;AllowPublicKeyRetrieval=True;";

			using (MySqlConnection conn = new MySqlConnection(connectionString))
			{
				try
				{
					conn.Open();
					string query = "SELECT COUNT(id_venta) AS NumeroVentas, SUM(total) AS TotalIngresos FROM VENTAS WHERE DATE(fecha) = CURDATE()";
					
					using (MySqlCommand cmd = new MySqlCommand(query, conn))
					{
						using (MySqlDataReader reader = cmd.ExecuteReader())
						{
							if (reader.Read())
							{
								int totalTickets = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
								decimal totalDinero = reader.IsDBNull(1) ? 0m : reader.GetDecimal(1);

								string mensajeDeCorte =
									"====== CORTE DE CAJA ======\n\n" +
									"Fecha: " + DateTime.Now.ToString("dd/MM/yyyy") + "\n" +
									"--------------------------------------\n" +
									"Tickets cobrados hoy:  " + totalTickets + "\n" +
									"Ingresos del día:         $" + totalDinero.ToString("0.00") + "\n\n" +
									"===========================";

								MessageBox.Show(mensajeDeCorte, "Corte del Día", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error al generar el corte de caja: " + ex.Message, "Error BD");
				}
			}
		}
		
		void TextBox3KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				e.Handled = true;
				CalcularTotales();
			}
		}
		
		void TxtPagoKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				e.Handled = true;

				try
				{
					decimal total = Convert.ToDecimal(txtTotal.Text);
					decimal pago = Convert.ToDecimal(txtPago.Text);

					if (pago >= total)
					{
						decimal cambio = pago - total;
						txtCambio.Text = cambio.ToString("0.00");
						
						btnGuardarVenta.Focus();
					}
					else
					{
						MessageBox.Show("El efectivo ingresado es menor al total a pagar.", "Faltan fondos");
						txtCambio.Text = "0.00";
						txtPago.SelectAll(); 
					}
				}
				catch (Exception)
				{
					MessageBox.Show("Por favor, ingresa una cantidad numérica válida en el pago.", "Aviso");
					txtPago.SelectAll();
				}
			}
		}
	}
}