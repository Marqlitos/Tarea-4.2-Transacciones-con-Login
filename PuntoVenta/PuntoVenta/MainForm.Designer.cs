/*
 * Created by SharpDevelop.
 * User: marco
 * Date: 28/10/2026
 * Time: 04:21 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PuntoVenta
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnBorrar;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.VScrollBar vScrollBar1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnHistorial;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnCorte;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnAumentar;
		private System.Windows.Forms.Button btnDisminuir;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox txtSubtotal;
		private System.Windows.Forms.TextBox txtIva;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.TextBox txtCodigoBarra;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtPago;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtCambio;
		private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
		private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnBorrar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCodigoBarra = new System.Windows.Forms.TextBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnHistorial = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txtSubtotal = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtIva = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnCorte = new System.Windows.Forms.Button();
			this.btnAumentar = new System.Windows.Forms.Button();
			this.btnDisminuir = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtPago = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtCambio = new System.Windows.Forms.TextBox();
			this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label2.Location = new System.Drawing.Point(815, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(346, 56);
			this.label2.TabIndex = 1;
			this.label2.Text = "AbarroTECNM";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(103, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Le atiende:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"Marco",
			"Alex",
			"Prof. Germán"});
			this.comboBox1.Location = new System.Drawing.Point(121, 12);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(177, 24);
			this.comboBox1.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(361, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(121, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Tipo de pago: ";
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
			"Efectivo",
			"Tarjeta",
			"Transferencia",
			"Vales de despensa",
			"Cheque"});
			this.comboBox2.Location = new System.Drawing.Point(488, 10);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(195, 24);
			this.comboBox2.TabIndex = 5;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(12, 43);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(286, 22);
			this.dateTimePicker1.TabIndex = 6;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Clave,
			this.Descripcion,
			this.Cantidad,
			this.Precio,
			this.Importe});
			this.dataGridView1.Location = new System.Drawing.Point(185, 78);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(976, 396);
			this.dataGridView1.TabIndex = 7;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// btnEditar
			// 
			this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
			this.btnEditar.Location = new System.Drawing.Point(107, 174);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(62, 54);
			this.btnEditar.TabIndex = 8;
			this.toolTip1.SetToolTip(this.btnEditar, "Editar Producto");
			this.btnEditar.UseVisualStyleBackColor = true;
			// 
			// btnBorrar
			// 
			this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
			this.btnBorrar.Location = new System.Drawing.Point(15, 99);
			this.btnBorrar.Name = "btnBorrar";
			this.btnBorrar.Size = new System.Drawing.Size(62, 54);
			this.btnBorrar.TabIndex = 9;
			this.toolTip1.SetToolTip(this.btnBorrar, "Borrar Producto");
			this.btnBorrar.UseVisualStyleBackColor = true;
			this.btnBorrar.Click += new System.EventHandler(this.BtnBorrarClick);
			// 
			// btnSalir
			// 
			this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
			this.btnSalir.Location = new System.Drawing.Point(1126, 492);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(62, 54);
			this.btnSalir.TabIndex = 10;
			this.toolTip1.SetToolTip(this.btnSalir, "Salir / Cerrar programa");
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.Button1Click);
			// 
			// vScrollBar1
			// 
			this.vScrollBar1.Location = new System.Drawing.Point(1164, 78);
			this.vScrollBar1.Name = "vScrollBar1";
			this.vScrollBar1.Size = new System.Drawing.Size(24, 396);
			this.vScrollBar1.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(354, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(141, 23);
			this.label4.TabIndex = 12;
			this.label4.Text = "Codigo de Barra:";
			// 
			// txtCodigoBarra
			// 
			this.txtCodigoBarra.Location = new System.Drawing.Point(501, 41);
			this.txtCodigoBarra.Name = "txtCodigoBarra";
			this.txtCodigoBarra.Size = new System.Drawing.Size(183, 22);
			this.txtCodigoBarra.TabIndex = 13;
			this.txtCodigoBarra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigoBarraKeyPress);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
			this.btnAgregar.Location = new System.Drawing.Point(690, 37);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(44, 31);
			this.btnAgregar.TabIndex = 14;
			this.toolTip1.SetToolTip(this.btnAgregar, "Agregar Codigo de Barras a un Producto");
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.Location = new System.Drawing.Point(106, 99);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(63, 54);
			this.btnGuardar.TabIndex = 15;
			this.toolTip1.SetToolTip(this.btnGuardar, "Guardar Producto");
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// btnHistorial
			// 
			this.btnHistorial.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnHistorial.Image = ((System.Drawing.Image)(resources.GetObject("btnHistorial.Image")));
			this.btnHistorial.Location = new System.Drawing.Point(490, 496);
			this.btnHistorial.Name = "btnHistorial";
			this.btnHistorial.Size = new System.Drawing.Size(62, 54);
			this.btnHistorial.TabIndex = 16;
			this.toolTip1.SetToolTip(this.btnHistorial, "Historial");
			this.btnHistorial.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(11, 395);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 17;
			this.label5.Text = "Subtotal:";
			// 
			// txtSubtotal
			// 
			this.txtSubtotal.Location = new System.Drawing.Point(106, 392);
			this.txtSubtotal.Name = "txtSubtotal";
			this.txtSubtotal.Size = new System.Drawing.Size(71, 22);
			this.txtSubtotal.TabIndex = 18;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(11, 424);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(89, 23);
			this.label6.TabIndex = 20;
			this.label6.Text = "Descuento:";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(106, 421);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(72, 22);
			this.textBox3.TabIndex = 21;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(11, 451);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 22;
			this.label7.Text = "Iva:";
			// 
			// txtIva
			// 
			this.txtIva.Location = new System.Drawing.Point(106, 452);
			this.txtIva.Name = "txtIva";
			this.txtIva.Size = new System.Drawing.Size(72, 22);
			this.txtIva.TabIndex = 23;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(12, 511);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(131, 39);
			this.label8.TabIndex = 24;
			this.label8.Text = "Total:";
			// 
			// txtTotal
			// 
			this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotal.Location = new System.Drawing.Point(149, 508);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(167, 38);
			this.txtTotal.TabIndex = 25;
			// 
			// toolTip1
			// 
			this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.ToolTip1Popup);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
			this.btnBuscar.Location = new System.Drawing.Point(13, 174);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(64, 54);
			this.btnBuscar.TabIndex = 26;
			this.toolTip1.SetToolTip(this.btnBuscar, "Buscar Productos");
			this.btnBuscar.UseVisualStyleBackColor = true;
			// 
			// btnCorte
			// 
			this.btnCorte.Image = ((System.Drawing.Image)(resources.GetObject("btnCorte.Image")));
			this.btnCorte.Location = new System.Drawing.Point(558, 496);
			this.btnCorte.Name = "btnCorte";
			this.btnCorte.Size = new System.Drawing.Size(62, 54);
			this.btnCorte.TabIndex = 27;
			this.toolTip1.SetToolTip(this.btnCorte, "Corte / Total de ventas");
			this.btnCorte.UseVisualStyleBackColor = true;
			// 
			// btnAumentar
			// 
			this.btnAumentar.Image = ((System.Drawing.Image)(resources.GetObject("btnAumentar.Image")));
			this.btnAumentar.Location = new System.Drawing.Point(15, 299);
			this.btnAumentar.Name = "btnAumentar";
			this.btnAumentar.Size = new System.Drawing.Size(64, 54);
			this.btnAumentar.TabIndex = 29;
			this.toolTip1.SetToolTip(this.btnAumentar, "Aumentar Cantidad de Producto");
			this.btnAumentar.UseVisualStyleBackColor = true;
			// 
			// btnDisminuir
			// 
			this.btnDisminuir.Image = ((System.Drawing.Image)(resources.GetObject("btnDisminuir.Image")));
			this.btnDisminuir.Location = new System.Drawing.Point(85, 299);
			this.btnDisminuir.Name = "btnDisminuir";
			this.btnDisminuir.Size = new System.Drawing.Size(64, 54);
			this.btnDisminuir.TabIndex = 30;
			this.toolTip1.SetToolTip(this.btnDisminuir, "Disminuir cantidad de Producto");
			this.btnDisminuir.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(354, 496);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(62, 54);
			this.button1.TabIndex = 31;
			this.toolTip1.SetToolTip(this.button1, "Guardar Venta");
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.Location = new System.Drawing.Point(422, 496);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(62, 54);
			this.button2.TabIndex = 32;
			this.toolTip1.SetToolTip(this.button2, "Abrir Venta");
			this.button2.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(15, 257);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(130, 39);
			this.label9.TabIndex = 28;
			this.label9.Text = "Cantidad";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(690, 480);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(130, 39);
			this.label10.TabIndex = 33;
			this.label10.Text = "Pago con:";
			// 
			// txtPago
			// 
			this.txtPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPago.Location = new System.Drawing.Point(898, 480);
			this.txtPago.Name = "txtPago";
			this.txtPago.Size = new System.Drawing.Size(167, 27);
			this.txtPago.TabIndex = 34;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(690, 517);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(209, 33);
			this.label11.TabIndex = 35;
			this.label11.Text = "Cambio del cliente:";
			// 
			// txtCambio
			// 
			this.txtCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCambio.Location = new System.Drawing.Point(898, 519);
			this.txtCambio.Name = "txtCambio";
			this.txtCambio.ReadOnly = true;
			this.txtCambio.Size = new System.Drawing.Size(167, 27);
			this.txtCambio.TabIndex = 36;
			// 
			// Clave
			// 
			this.Clave.HeaderText = "Clave";
			this.Clave.Name = "Clave";
			// 
			// Descripcion
			// 
			this.Descripcion.HeaderText = "Descripcion";
			this.Descripcion.Name = "Descripcion";
			// 
			// Cantidad
			// 
			this.Cantidad.HeaderText = "Cantidad";
			this.Cantidad.Name = "Cantidad";
			// 
			// Precio
			// 
			this.Precio.HeaderText = "Precio";
			this.Precio.Name = "Precio";
			// 
			// Importe
			// 
			this.Importe.HeaderText = "Importe";
			this.Importe.Name = "Importe";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 558);
			this.Controls.Add(this.txtCambio);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.txtPago);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnDisminuir);
			this.Controls.Add(this.btnAumentar);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.btnCorte);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtIva);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtSubtotal);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnHistorial);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.txtCodigoBarra);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.vScrollBar1);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnBorrar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Name = "MainForm";
			this.Text = "PuntoVenta";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
