//PARA QUE LOS NOMBRE ESTEN EN EL TEXBOX

//NOMBRE
private void txtNombre_Enter(object sender, EventArgs e)
{
    if (txtNombre.Text == "Nombre")
    {
        txtNombre.Text = "";
    }
}

private void txtNombre_Leave(object sender, EventArgs e)
{
    if (txtNombre.Text == "")
    {
        txtNombre.Text = "Nombre";
    }
}

//DESCRIPCION
private void txtDescripcion_Enter(object sender, EventArgs e)
{
    if (txtNombre.Text == "Descripcion")
    {
        txtNombre.Text = "";
    }
}

private void txtDescripcion_Leave(object sender, EventArgs e)
{
    if (txtNombre.Text == "")
    {
        txtNombre.Text = "Descripcion";
    }
}

//PRECIO
private void txtPrecio_Enter(object sender, EventArgs e)
{
    if (txtNombre.Text == "Precio de Compra")
    {
        txtNombre.Text = "";
    }
}

private void txtPrecio_Leave(object sender, EventArgs e)
{
    if (txtNombre.Text == "")
    {
        txtNombre.Text = "Precio de Compra";
    }
}

//STOCK
private void txtStock_Enter(object sender, EventArgs e)
{
    if (txtNombre.Text == "Stock")
    {
        txtNombre.Text = "";
    }
}

private void txtStock_Leave(object sender, EventArgs e)
{
    if (txtNombre.Text == "")
    {
        txtNombre.Text = "Stock";
    }
}
