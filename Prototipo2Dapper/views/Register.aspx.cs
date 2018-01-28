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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void register_Click(object sender, EventArgs e)
        {
            if (license.Checked == true)
            {
                UsuarioLN data = new UsuarioLN();
                List<Usuario> lst = data.Mostrar();
                Boolean noExiste = true;
                Usuario item = new Usuario();
                item.ID = 0;
                item.nombrecompleto = register_nombres.Text;
                item.clave = register_apellidos.Text;
                //item.ci = register_cedula.Text;
                //item.contrasenia = register_passowrd.Text;
                //item.FirmaSello = "";
                //DateTime dateTime = DateTime.Parse(register_fechaNacimiento.Text);
                //item.fechaNacimiento = dateTime;
                //Sexo sexo = new Sexo();
                //sexo.id_sexo = Convert.ToInt32(DropDownListSexo.SelectedValue);
                //item.sexo = sexo;
                //FormacionProfecional formacion = new FormacionProfecional();
                //formacion.id_formacionProfecional = Convert.ToInt32(DropDownListFormacionProfecional.SelectedValue);
                //item.formacionProfecional = formacion;
                //Especialidad especialidad = new Especialidad();
                //especialidad.id_especialidad = Convert.ToInt32(DropDownListEspecialidad.SelectedValue);
                //item.especialidad = especialidad;
                //Nacionalidad nacionalidad = new Nacionalidad();
                //nacionalidad.id_nacionalidad = Convert.ToInt32(DropDownListNacionalidad.SelectedValue);
                //item.nacionalidad = nacionalidad;
                //Autoidetificacion autoidetificacion = new Autoidetificacion();
                //autoidetificacion.id_autoidetificacion = Convert.ToInt32(DropDownListAutoidentificación.SelectedValue);
                //item.autoidetificacion = autoidetificacion;
                //CodigoMPS codigoMPSLN = new CodigoMPS();
                //codigoMPSLN.id_codigoMPS = Convert.ToInt32(DropDownListCodigoMPS.SelectedValue);
                //item.codigoMPS = codigoMPSLN;
                //item.foto = "graficos/avatar-2.jpg";
                foreach (Usuario ite in lst)
                {
                    if (ite.ID.Equals(item.ID))
                    {
                        noExiste = false;
                    }

                }
                if (noExiste)
                {
                    data.Insertar(item);//inserta y se va home 
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "successCreateAcount();", true);
                    //  Response.Redirect(GetRouteUrl("LoginRoute", null));
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "errorAlertUsuarioExiste();", true);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "errorAlertTerminos();", true);
            }

        }
    }
}