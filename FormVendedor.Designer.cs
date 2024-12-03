// 
// txtNombre
// 
this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.txtNombre.Location = new System.Drawing.Point(314, 363);
this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
this.txtNombre.Name = "txtNombre";
this.txtNombre.Size = new System.Drawing.Size(304, 31);
this.txtNombre.TabIndex = 28;
this.txtNombre.Text = "Nombre";

//Estas son las lineas que se agregan a cada TXT
this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter); 
this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);


// 
// txtDescripcion
// 
this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.txtDescripcion.Location = new System.Drawing.Point(21, 653);
this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
this.txtDescripcion.Name = "txtDescripcion";
this.txtDescripcion.Size = new System.Drawing.Size(597, 31);
this.txtDescripcion.TabIndex = 29;
this.txtDescripcion.Text = "Descripcion";
this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);

//Estas son las lineas que se agregan a cada TXT
this.txtDescripcion.Enter += new System.EventHandler(this.txtDescripcion_Enter);
this.txtDescripcion.Leave += new System.EventHandler(this.txtDescripcion_Leave);


// 
// txtPrecio
// 
this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.txtPrecio.Location = new System.Drawing.Point(23, 565);
this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
this.txtPrecio.Name = "txtPrecio";
this.txtPrecio.Size = new System.Drawing.Size(278, 31);
this.txtPrecio.TabIndex = 33;
this.txtPrecio.Text = "Precio de Compra";

//Estas son las lineas que se agregan a cada TXT
this.txtPrecio.Enter += new System.EventHandler(this.txtPrecio_Enter);
this.txtPrecio.Leave += new System.EventHandler(this.txtPrecio_Leave);


// 
// txtStock
// 
this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
this.txtStock.Location = new System.Drawing.Point(340, 565);
this.txtStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
this.txtStock.Name = "txtStock";
this.txtStock.Size = new System.Drawing.Size(278, 31);
this.txtStock.TabIndex = 37;
this.txtStock.Text = "Stock";

//Estas son las lineas que se agregan a cada TXT
this.txtStock.Enter += new System.EventHandler(this.txtStock_Enter);
this.txtStock.Leave += new System.EventHandler(this.txtStock_Leave);
