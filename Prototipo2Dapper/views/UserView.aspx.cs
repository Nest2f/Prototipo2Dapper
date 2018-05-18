using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using LogicaNegocios;

namespace Prototipo2Dapper.views
{
    public partial class UserView : System.Web.UI.Page
    {
        static Usuario usuarioEdit = new Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {           
        }

        //protected void btn_usuarios_Click(object sender, EventArgs e)
        //{

        //}

        //public void mostrarEdit()
        //{
        //    //panelEditPaciente.Visible = true;
        //    panelAllUsuario.Visible = false;
        //}

        //protected void lnkEdit_Command(object sender, CommandEventArgs e)
        //{
        //    //usuarioEdit = new Usuario();
        //    //mostrarEdit();
        //    //usuarioEdit. = Convert.ToInt32(e.CommandArgument.ToString());
        //    //UsuarioLN ln = new UsuarioLN();
        //    //usuarioEdit = ln.UsuarioID(usuarioEdit);
        //    //cargarDatosSelect(usuarioEdit);
        //}

        //public void cargarDatosSelect(Usuario usuarioEdit)
        //{
        //    //cargar Datos
        //    //Edit_register_nombres.Text = pacientesEdit.nombres;
        //    //Edit_register_apellidos.Text = pacientesEdit.Apellidos;
        //    //Edit_register_cedula.Text = pacientesEdit.cedula;
          
        //}

        //protected void shopanelAdd(object sender, EventArgs e)
        //{
        //    panelAllUsuario.Visible = false;
        //    //panelAddUser.Visible = true;

        //}
        //protected void btnCalcel_Click(object sender, EventArgs e)
        //{
        //    panelAddUser.Visible = false;
        //    panelAllUsuario.Visible = true;
        //}

        //protected void btnNuevo_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        panelAddUser.Visible = false;
        //        panelAllUsuario.Visible = true;
        //        Usuario item = new Usuario();
        //        UsuarioLN data = new UsuarioLN();
        //        //item.ID = Convert.ToInt32(listSearchingPerson.SelectedDataKey.Value.ToString());
        //        item.ID = 0;
        //        item.nombrecompleto = register_nombres.Text;
        //        // System.Diagnostics.Debug.WriteLine(" Add persona   Id SElect =" + listSearchingPerson.SelectedDataKey.Value);
        //        ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "AlertReload('Creación!','Se Realizo Correctamente','success','OK');", true);


        //    }
        //    catch (Exception ex)
        //    {
        //        // Response.Redirect(GetRouteUrl("PacientesRoute", new { idGrupo = grupo.idGrupo }));
        //        Response.Write("<script>alert('" + ex.Message + "')</script>");

        //    }
        //    finally
        //    {
        //        // Response.Redirect(GetRouteUrl("PacientesRoute", new { idGrupo = grupo.idGrupo }));
        //    }


        //}

        //protected void selectedIndexChanging(object sender, ListViewSelectEventArgs e)
        //{
        //    if (lvwDatos.SelectedIndex != e.NewSelectedIndex)
        //    {
        //        lvwDatos.SelectedIndex = e.NewSelectedIndex;
        //    }
        //    else
        //    {
        //        lvwDatos.SelectedIndex = -1;
        //    }
        //    //string idGrupo =  lvwDatos.SelectedDataKey.Value.ToString();
        //    lvwDatos.DataBind();
        //    //  Response.Write("<script>alert('" + lvwDatos.SelectedDataKey.Value.ToString() + "')</script>");
        //}

        //public void cargarSeachPeopleDefaul()
        //{

        //    UsuarioLN nUsuario = new UsuarioLN();
        //    nUsuario.Mostrar();
        //    // nUsuario.Mostrar();
        //    //if (txt_searchItem.Text == "")
        //    //{
        //    //    listSearchingPerson.DataSource = nUsuario.UsuarioID;
        //    //    listSearchingPerson.DataBind();
        //    //}
        //    //else
        //    //{
        //    //    Usuario u = new Usuario();
        //    //    u.ID = txt_searchItem.Text;

        //    //    listSearchingPerson.DataSource = nUsuario.UsuarioID.
        //    //    System.Diagnostics.Debug.WriteLine("cedula  usuario =" + u.cedula + " -" + "id grupo = " + grupo.idGrupo);
        //    //    listSearchingPerson.DataBind();
        //    //}

        //}

        //protected void selectedIndexChangingListSearch(object sender, ListViewSelectEventArgs e)
        //{
        //    cargarSeachPeopleDefaul();

        //    listSearchingPerson.SelectedIndex = e.NewSelectedIndex;

        //    //string idGrupo =  lvwDatos.SelectedDataKey.Value.ToString();
        //    listSearchingPerson.DataBind();
        //    //  Response.Write("<script>alert('" + lvwDatos.SelectedDataKey.Value.ToString() + "')</script>");
        //}

        //protected void btnSearch_Click(object sender, EventArgs e)
        //{
        //    UsuarioLN ln = new UsuarioLN();

        //    string buscar = txt_searchItem.Text;

        //    cargarSeachPeopleDefaul();
        //}
    }
}