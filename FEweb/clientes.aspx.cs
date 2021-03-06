﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Seguridad;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace FE
{
    public partial class clientes : System.Web.UI.Page
    {
        public GestorBitacora _gestorBitacora = new GestorBitacora();
        public GestorMensaje _gestormensaje = new GestorMensaje();
        public BLL.gestorCliente _gestorCliente = new BLL.gestorCliente();
        public BLL.GestorIntegridadBLL _gestorIntegridadBLL = new BLL.GestorIntegridadBLL();
        public validacion _check = new validacion();
        //string Cultura = SesionActualWindows.SesionActual().ObtenerUsuarioActual().Cultura.ToString();
        string Cultura = "";
        public int totalItemSeleccionados = 0;
        public bool borraMasivo = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (SesionActualWindows.SesionActual().ObtenerUsuarioActual() != null)
                {
                    Cultura = SesionActualWindows.SesionActual().ObtenerUsuarioActual().Cultura.ToString();
                    LimpiarCampos();
                    LlenarTabla();
                    LlenarListas();
                    phAlta.Visible = false;
                    phBotonera.Visible = true;
                    phLista.Visible = true;
                }
                //Traductor.TraducirControles(Page.Form.Controls, Cultura);

            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e) 
        {
            GridView1.PageIndex = e.NewPageIndex;
            LlenarTabla();
        }

        protected void LlenarTabla()
        {
            GridView1.DataSource = null;
            GridView1.AutoGenerateColumns = false;
            GridView1.DataSource = _gestorCliente.leer_cliente();
            GridView1.DataBind();
        }

        protected void LlenarListas()
        {

        }
        protected void LimpiarCampos()
        {
            txtIdCliente.Enabled = false;
            txtCP.Text = "";
            txtDomicilio.Text = "";
            txtIdCliente.Text = "";
            txtLocalidad.Text = "";
            txtPais.Text = "";
            txtProvincia.Text = "";
            txtRazonSocial.Text = "";
            txtSFI.Text = "";
            UCMail.Text = "";
            UCCuit.Text = "";

        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            phAlta.Visible = true;
            phBotonera.Visible = false;
            phLista.Visible = false;
        }
        protected void btnCerrar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            phAlta.Visible = false;
            phBotonera.Visible = true;
            phLista.Visible = true;
            lblInfo.Text = "";

        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtRazonSocial.Text) && !String.IsNullOrEmpty(txtDomicilio.Text) && !String.IsNullOrEmpty(txtCP.Text) && !String.IsNullOrEmpty(txtPais.Text) && !String.IsNullOrEmpty(UCMail.Text) && !String.IsNullOrEmpty(txtProvincia.Text))
            {
                if ((UCCuit.BackColor != System.Drawing.Color.Empty) || (UCMail.BackColor != System.Drawing.Color.Empty) || (txtSFI.BackColor != System.Drawing.Color.Empty))
                {
                    lblInfo.Text = Traductor.Mensaje("ERR170", SesionActualWindows.SesionActual().ObtenerUsuarioActual().Cultura.ToString());
                }
                else
                {

                    try
                    {
                        BE.Cliente cliente = new BE.Cliente();
                        cliente.idCliente = 0;
                        cliente.razonSocial = txtRazonSocial.Text;
                        cliente.domicilio = txtDomicilio.Text;
                        string cuit = UCCuit.Text;
                        cuit = cuit.Replace("-", "");
                        cliente.cuit = cuit;
                        cliente.Email = UCMail.Text;
                        cliente.localidad = txtLocalidad.Text;
                        cliente.provincia = txtProvincia.Text;
                        cliente.pais = txtPais.Text;
                        cliente.SFI = Convert.ToInt16(txtSFI.Text);
                        cliente.CP = txtCP.Text;
                        cliente.fechaAlta = DateTime.Today;
                        cliente.clienteDVH = "1";

                        _gestorCliente.insertar_cliente(cliente);
                        {
                            LlenarTabla();
                            LimpiarCampos();
                            lblInfo.Text = Traductor.Mensaje("ERR140", SesionActualWindows.SesionActual().ObtenerUsuarioActual().Cultura.ToString());
                            _gestorIntegridadBLL.recalcular_t_Cliente("corregir");
                        }

                    }
                    catch (SeguridadException ex)
                    {
                        lblInfo.Text = Traductor.TraducirMensage(ex.CodigError, ex.Message);
                    }
                    catch (Exception ex)
                    {
                        lblInfo.Text = ex.Message;
                    }
                }
            }
            else
            {
                lblInfo.Text = Traductor.Mensaje("ERR141", SesionActualWindows.SesionActual().ObtenerUsuarioActual().Cultura.ToString());
            }
        }
        
        protected void GridView1_RowDeleting(Object sender, GridViewDeleteEventArgs e)
        {
            _gestorCliente.eliminar_cliente(GridView1.Rows[e.RowIndex].Cells[2].Text);
            if (!borraMasivo)
            {
                LlenarTabla();
            }
        }
        protected void GridView1_RowUpdating(Object sender, GridViewUpdateEventArgs e)
        {

            BE.Cliente miCliente = _gestorCliente.leer_cliente(e.Keys[0].ToString());

            if (e.NewValues[0] == null || e.NewValues[1] == null || e.NewValues[2] == null || e.NewValues[3] == null)
            {
                lblInfo.Text = Traductor.Mensaje("ERR141",SesionActualWindows.SesionActual().ObtenerUsuarioActual().Cultura.ToString());
            }
            else
            {
                bool chequeoFormato = true;

                if (!_check.ValidarCuit(e.NewValues[1].ToString()))
                {
                    chequeoFormato = false;
                }
                else
                {
                    string cuit = e.NewValues[1].ToString();
                    cuit = cuit.Replace("-", "");
                    miCliente.cuit = cuit;
                }
                if (!_check.ValidarEMail(e.NewValues[2].ToString()))
                {
                    chequeoFormato = false;
                }
                if (!_check.ValidarTextoNumEspacio(e.NewValues[4].ToString()))
                {
                    chequeoFormato = false;
                }
                if (!_check.ValidarTextoNumEspacio(e.NewValues[5].ToString()))
                {
                    chequeoFormato = false;
                }
                if (!_check.ValidarTextoNumEspacio(e.NewValues[6].ToString()))
                {
                    chequeoFormato = false;
                }
                if (!_check.ValidarTextoNumEspacio(e.NewValues[7].ToString()))
                {
                    chequeoFormato = false;
                }
                if (!_check.ValidarNumerico(e.NewValues[8].ToString()))
                {
                    chequeoFormato = false;
                }
                else
                {
                    miCliente.SFI = Convert.ToInt16(e.NewValues[8].ToString());
                }


                miCliente.razonSocial = e.NewValues[0].ToString();
                miCliente.Email = e.NewValues[2].ToString();
                miCliente.domicilio = e.NewValues[3].ToString();
                miCliente.localidad = e.NewValues[4].ToString();
                miCliente.provincia = e.NewValues[5].ToString();
                miCliente.pais = e.NewValues[6].ToString();
                miCliente.CP = e.NewValues[7].ToString();
                
                
                if (chequeoFormato)
                {
                    _gestorCliente.insertar_cliente(miCliente);
                    GridView1.EditIndex = -1;
                    lblInfo.Text = "";
                    LlenarTabla();
                    _gestorIntegridadBLL.recalcular_t_Cliente("corregir");
                }
                else
                {
                    lblInfo.Text = Traductor.Mensaje("ERR169", SesionActualWindows.SesionActual().ObtenerUsuarioActual().Cultura.ToString());

                }
            }
        
        }
        protected void GridView1_RowEditing(Object sender, GridViewEditEventArgs e)
        {
            //Todas los campos excepto dropdownlist
            GridView1.EditIndex = e.NewEditIndex;
            LlenarTabla();
            lblInfo.Text = "";

        }
        protected void GridView1_RowCancelingEdit(Object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            LlenarTabla();
            lblInfo.Text = "";
        }
        protected void btnQuitarSeleccionados_Click(Object sender, EventArgs e)
        {
            //Recorrer las filas del GridView...
        
           for (int i = 0; i<=(GridView1.Rows.Count - 1);i++)
            {
                CheckBox chkElim = GridView1.Rows[i].FindControl("chkEliminar") as CheckBox;
                if (chkElim.Checked)
                {
                    borraMasivo = true;
                    GridView1.DeleteRow(i);
                }
                
            }
           borraMasivo = false;
           LlenarTabla();
        
        }
        //protected void btnLlamarAFIP_Click(object sender, EventArgs e)
        //{
        //    WSAfip.WSAfipSoapClient WSAfip = new WSAfip.WSAfipSoapClient();
        //    string Cuit = UCCuit.Text.Replace("-", "");
        //    List<string> cadena = new List<string>();
        //    cadena = WSAfip.RecuperarDatosCUIT(Cuit);
        //    List<string> cadenaFiltrada = new List<string>();
        //    for (int i = 1; i <= cadena.Count - 1; i++)
        //    {
        //        if (!string.Equals(cadena[i].ToString(), ""))
        //        {
        //            cadenaFiltrada.Add(cadena[i].ToString());
        //        }
        //    }
        //    for (int i = 0; i <= cadenaFiltrada.Count - 1; i++)
        //    {
        //        switch (cadenaFiltrada[i].ToString())
        //        {
        //            case "success":
        //                lblInfo.Text = "consulta AFIP OK";
        //                break;
        //            case "nombre":
        //                txtRazonSocial.Text = cadenaFiltrada[i + 1].ToString();
        //                break;
        //            case "codPostal":
        //                txtCP.Text = cadenaFiltrada[i + 1].ToString();
        //                break;
        //            case "direccion":
        //                txtDomicilio.Text = cadenaFiltrada[i + 1].ToString();
        //                break;
        //            default:
        //                break;
        //        }
        //    }
        //}
        protected void chk_OnCheckedChanged(Object sender, EventArgs e)
        {
            //Recorrer las filas del GridView...
        
               
            //Quita el mensaje de información si lo hubiera...
            lblInfo.Text = "";
        
            for (int i = 0; i==(GridView1.Rows.Count - 1);i++)
            {
                //CheckBox CheckBoxElim = (CheckBox)(GridView1.Rows(i).FindControl("chkEliminar");
                CheckBox chkElim = GridView1.Rows[i].FindControl("chkEliminar") as CheckBox;
                if (chkElim.Checked)
                {
                    totalItemSeleccionados += 1;
                }
            }
        }


    }
}