/*
 * Created by SharpDevelop.
 * User: marco
 * Date: 31/10/2026
 * Time: 04:15 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PuntoVenta
{
	partial class FormEditarProducto
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtStock;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtClave;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarProducto));
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txtStock = new System.Windows.Forms.TextBox();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtClave = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// btnSalir
			// 
			this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
			this.btnSalir.Location = new System.Drawing.Point(12, 177);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(62, 54);
			this.btnSalir.TabIndex = 28;
			this.toolTip1.SetToolTip(this.btnSalir, "Salir / Cerrar Ventana");
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// btnActualizar
			// 
			this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
			this.btnActualizar.Location = new System.Drawing.Point(425, 177);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(63, 54);
			this.btnActualizar.TabIndex = 27;
			this.toolTip1.SetToolTip(this.btnActualizar, "Guardar Cambios / Actualizar");
			this.btnActualizar.UseVisualStyleBackColor = true;
			this.btnActualizar.Click += new System.EventHandler(this.BtnActualizarClick);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(13, 136);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 26;
			this.label5.Text = "Stock";
			// 
			// txtStock
			// 
			this.txtStock.Location = new System.Drawing.Point(145, 138);
			this.txtStock.Name = "txtStock";
			this.txtStock.Size = new System.Drawing.Size(343, 22);
			this.txtStock.TabIndex = 25;
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(145, 110);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(343, 22);
			this.txtPrecio.TabIndex = 24;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(13, 109);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 23;
			this.label4.Text = "Precio: ";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(145, 82);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(343, 22);
			this.txtDescripcion.TabIndex = 22;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 21;
			this.label3.Text = "Descripcion:";
			// 
			// txtClave
			// 
			this.txtClave.Location = new System.Drawing.Point(145, 55);
			this.txtClave.Name = "txtClave";
			this.txtClave.Size = new System.Drawing.Size(343, 22);
			this.txtClave.TabIndex = 20;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 23);
			this.label2.TabIndex = 19;
			this.label2.Text = "Clave Producto:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(201, 27);
			this.label1.TabIndex = 18;
			this.label1.Text = "Agregar Producto:";
			// 
			// FormEditarProducto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(498, 243);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtStock);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtDescripcion);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtClave);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormEditarProducto";
			this.Text = "FormEditarProducto";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
