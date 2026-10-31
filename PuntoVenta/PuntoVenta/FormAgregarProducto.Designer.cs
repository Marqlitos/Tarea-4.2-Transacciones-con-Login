/*
 * Created by SharpDevelop.
 * User: marco
 * Date: 31/10/2026
 * Time: 02:33 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PuntoVenta
{
	partial class FormAgregarProducto
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtClave;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.TextBox txtStock;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnGuardarProducto;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.ToolTip toolTip1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarProducto));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtClave = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.txtStock = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnGuardarProducto = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(201, 27);
			this.label1.TabIndex = 0;
			this.label1.Text = "Agregar Producto:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Clave Producto:";
			// 
			// txtClave
			// 
			this.txtClave.Location = new System.Drawing.Point(145, 55);
			this.txtClave.Name = "txtClave";
			this.txtClave.Size = new System.Drawing.Size(343, 22);
			this.txtClave.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Descripcion:";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(145, 82);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(343, 22);
			this.txtDescripcion.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(13, 109);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "Precio: ";
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(145, 110);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(343, 22);
			this.txtPrecio.TabIndex = 6;
			// 
			// txtStock
			// 
			this.txtStock.Location = new System.Drawing.Point(145, 138);
			this.txtStock.Name = "txtStock";
			this.txtStock.Size = new System.Drawing.Size(343, 22);
			this.txtStock.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(13, 136);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Stock";
			// 
			// btnGuardarProducto
			// 
			this.btnGuardarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarProducto.Image")));
			this.btnGuardarProducto.Location = new System.Drawing.Point(425, 177);
			this.btnGuardarProducto.Name = "btnGuardarProducto";
			this.btnGuardarProducto.Size = new System.Drawing.Size(63, 54);
			this.btnGuardarProducto.TabIndex = 16;
			this.toolTip1.SetToolTip(this.btnGuardarProducto, "Guardar Producto / Registrar Producto");
			this.btnGuardarProducto.UseVisualStyleBackColor = true;
			this.btnGuardarProducto.Click += new System.EventHandler(this.BtnGuardarProductoClick);
			// 
			// btnSalir
			// 
			this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
			this.btnSalir.Location = new System.Drawing.Point(12, 177);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(62, 54);
			this.btnSalir.TabIndex = 17;
			this.toolTip1.SetToolTip(this.btnSalir, "Cerrar Ventana / Salir");
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// FormAgregarProducto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(500, 243);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnGuardarProducto);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtStock);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtDescripcion);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtClave);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormAgregarProducto";
			this.Text = "FormAgregarProducto";
			this.Load += new System.EventHandler(this.FormAgregarProductoLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
