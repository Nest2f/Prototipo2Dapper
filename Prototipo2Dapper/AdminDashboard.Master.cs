using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using LogicaNegocios;

namespace Prototipo2Dapper
{
    public partial class AdminDashboard : System.Web.UI.MasterPage
    {
        static Usuario usuario = null;
        String hola = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["logeado"] == null)//si existe estara logeado
            {
                //Response.Redirect("Login.aspx");
                Response.Redirect(GetRouteUrl("LoginRoute", null));

            }
            else
            {
                if (IsPostBack)
                {
                    System.Diagnostics.Debug.WriteLine("is postback");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("no postback");
                    usuario = new Usuario();
                    usuario.ID = Convert.ToInt32(Session["id_Profecional"].ToString());
                    UsuarioLN ln = new UsuarioLN();
                    usuario = ln.UsuarioID(usuario);

                    cargarDatos();
                }


                //if (profecional == null)
                //{
                //    profecional = new Profecional();
                //    profecional.id_Profecional = Convert.ToInt32(Session["id_Profecional"].ToString());
                //    ProfecionalLN ln = new ProfecionalLN();
                //    profecional = ln.ProfecionalID(profecional);

                //    cargarDatos();
                //}
                //else
                //{
                //    cargarDatos();
                //}
            }
        }

        protected void click_LogOut(object sender, EventArgs e)
        {
            usuario = null;
            Session.Clear();
            Response.Redirect(GetRouteUrl("LoginRoute", null));
            //   Response.Redirect("Login.aspx");
        }
        public void cargarDatos()
        {
            //ImagePerfil.ImageUrl = usuario.foto;
            register_nombres.Text = usuario.nombre;
            register_apellidos.Text = usuario.apellidos;
            //register_passowrd.Text = usuario.ID;
            //register_fechaNacimiento.Text = usuario.fechaNacimiento.ToString("yyyy-MM-dd");
            //register_cedula.Text = profecional.ci;
            //SexoLN sexoLN = new SexoLN();
            //List<Sexo> lstSexo = new List<Sexo>();
            //foreach (Sexo item in sexoLN.Mostrar())
            //{
            //    if (profecional.sexo.id_sexo == item.id_sexo)
            //    {
            //        DropDownListSexo.SelectedValue = Convert.ToString(item.id_sexo);
            //    }
            //}

            //FormacionProfecionalLN formacionProfecionalLN = new FormacionProfecionalLN();
            //List<FormacionProfecional> lstFormacionProfecional = new List<FormacionProfecional>();
            //foreach (FormacionProfecional item in formacionProfecionalLN.Mostrar())
            //{
            //    if (profecional.formacionProfecional.id_formacionProfecional == item.id_formacionProfecional)
            //    {
            //        DropDownListFormacionProfecional.SelectedValue = Convert.ToString(item.id_formacionProfecional);
            //    }
            //}

            //EspecialidadLN especialidadLN = new EspecialidadLN();

            //foreach (Especialidad item in especialidadLN.Mostrar())
            //{
            //    if (profecional.especialidad.id_especialidad == item.id_especialidad)
            //    {
            //        DropDownListEspecialidad.SelectedValue = Convert.ToString(item.id_especialidad);
            //    }
            //}

            //NacionalidadLN nacionalidadLN = new NacionalidadLN();

            //foreach (Nacionalidad item in nacionalidadLN.Mostrar())
            //{
            //    if (profecional.nacionalidad.id_nacionalidad == item.id_nacionalidad)
            //    {
            //        DropDownListNacionalidad.SelectedValue = Convert.ToString(item.id_nacionalidad);
            //    }
            //}

            //AutoidetificacionLN autoidetificacionLN = new AutoidetificacionLN();

            //foreach (Autoidetificacion item in autoidetificacionLN.Mostrar())
            //{
            //    if (profecional.autoidetificacion.id_autoidetificacion == item.id_autoidetificacion)
            //    {
            //        DropDownListAutoidentificación.SelectedValue = Convert.ToString(item.id_autoidetificacion);
            //    }
            //}

            //CodigoMPSLN codigoMPSLNL = new CodigoMPSLN();

            //foreach (CodigoMPS item in codigoMPSLNL.Mostrar())
            //{
            //    if (profecional.codigoMPS.id_codigoMPS == item.id_codigoMPS)
            //    {
            //        DropDownListCodigoMPS.SelectedValue = Convert.ToString(item.id_codigoMPS);
            //    }
            //}



        }

        protected void btnEditarPerdil_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioLN data = new UsuarioLN();
                List<Usuario> lst = data.Mostrar();

                Usuario item = new Usuario();
                item = usuario;
                //item.id_Profecional = 0;
                item.nombre = register_nombres.Text;
                item.apellidos = register_apellidos.Text;
                //item.ID = register_cedula.Text;
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
                //if (FileUploadFotoPerfil.HasFile)
                //{
                //    Imagen.Instance.GuardarImagen(FileUploadFotoPerfil);
                //    item.foto = "img/" + Imagen.Instance.nombreArchivo;
                //}
                // item.foto = "graficos/avatar-2.jpg";

                data.Update(item);//inserta y se va home 
                usuario = null;
                guardarSession(item);
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "AlertReload('Actualización!','Se Realizo Correctamente','success','OK');", true);
                //  Response.Redirect(GetRouteUrl("HomeAdminRoute", null));
                //string script = @"<script type='text/javascript'>
                //            alert('Usuario Ya registrado ');
                //        </script>";
                //ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);


            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error:->" + ex.Message);

            }





        }
        public void guardarSession(Usuario usuario)
        {
            Session["logeado"] = true;
            Session["id_Profecional"] = usuario.ID;
            Session["nombres"] = usuario.nombre;
            Session["apellidos"] = usuario.apellidos;
            //Session["fechaNacimiento"] = usuario.fechaNacimiento;
            //Session["ci"] = usuario.ci;
            //Session["contrasenia"] = usuario.contrasenia;
            //Session["foto"] = usuario.foto;
            //Session["foto"] = "";
            //Session["FirmaSello"] = usuario.FirmaSello;
            //Session["id_sexo"] = usuario.sexo.id_sexo;
            //Session["id_formacionProfecional"] = usuario.formacionProfecional.id_formacionProfecional;
            //Session["id_especialidad"] = usuario.especialidad.id_especialidad;
            //Session["id_nacionalidad"] = usuario.nacionalidad.id_nacionalidad;
            //Session["id_autoidetificacion"] = usuario.autoidetificacion.id_autoidetificacion;
            //Session["id_codigoMPS"] = usuario.codigoMPS.id_codigoMPS;
        }
    }
}