<%@ Page Title="" Language="C#" MasterPageFile="~/Theme.Master" AutoEventWireup="true" CodeBehind="RegisterUser.aspx.cs" Inherits="Prototipo2Dapper.views.RegisterUser1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server"></asp:ScriptManager>
    <div class="content mt-3">
    <div class="col-sm-6">
        <div class="card">
            <div class="card-header"><strong>Registro de Usuarios</strong><%--<small> </small>--%>
            </div>
           <%-- INICIO DE TABLAS DE REGISTROS--%>
            <form id="register-form">
             <div class="card-body card-block">                
                <div class="form-group">
                    <label class=" form-control-label">Nombres Completos</label>
                    <div class="input-group">
                        <div class="input-group-addon"><i class="fa fa-male"></i></div>
                        <asp:TextBox ID="register_nombres" runat="server" class="form-control" required=""></asp:TextBox>
                    </div>
                    <small class="form-text text-muted">Juan Pérez</small>
                </div>
                <div class="form-group">
                    <label class=" form-control-label">E-mail</label>
                    <div class="input-group">
                        <div class="input-group-addon"><i class="fa fa-book"></i></div>
                        <asp:TextBox ID="register_email" runat="server" class="form-control" required=""></asp:TextBox>
                    </div>
                    <small class="form-text text-muted">jperez@yahoo.es</small>
                </div>
                <div class="form-group">
                    <label class=" form-control-label">Usuario</label>
                    <div class="input-group">
                        <div class="input-group-addon"><i class="fa fa-male"></i></div>
                        <asp:TextBox ID="register_user" runat="server" class="form-control" required=""></asp:TextBox>
                    </div>
                    <small class="form-text text-muted">jperez</small>
                </div> 
                <div class="form-group">
                    <label class=" form-control-label">Clave</label>
                    <div class="input-group">
                        <div class="input-group-addon"><i class="fa fa-key"></i></div>
                        <asp:TextBox ID="register_pass" runat="server" class="form-control" required=""></asp:TextBox>
                    </div>
                    <small class="form-text text-muted"></small>
                </div>
                 <div class="form-group">
                    <label class=" form-control-label">Rol</label>
                    <div class="input-group">
                        <div class="input-group-addon"><i class="fa fa-apple"></i></div>
                        <asp:TextBox ID="register_rol" runat="server" class="form-control" required=""></asp:TextBox>
                    </div>
                    <small class="form-text text-muted">Usuario</small>
                </div>                  
                <div class="row form-group">                   
                    <div class="col-8">
                        <div class="form-group">
                            <label for="pass" class=" form-control-label">Estado de la Cuenta</label>
                            <label class="switch switch-3d switch-primary mr-3">
                                <input type="checkbox" class="switch-input" checked="true"/>
                                <span class="switch-label"></span><span class="switch-handle"></span>
                            </label>
                        </div>
                    </div>                   
                </div>
                <asp:Button ID="register" runat="server" Text="Register" CssClass="btn btn-primary" OnClick="register_Click" />
            </div> 
               </form>   
          <%--  FIN DE TABLAS DE REGISTRO  --%>                
        </div>       
    </div> 
    <div class="col-xs-6 col-sm-6">
        <div class="card">
            <div class="card-header">
                <strong class="card-title">Lista de Usuarios</strong>
            </div>
            <div class="card-body">
                <asp:DataList ID="DataList1" runat="server" DataSourceID="ListView" >
                    <ItemTemplate>
<%--                        nombrecompleto:
                        
                        <br />
                        email:
                        
                        <br />
                        clave:
                        
                        <br />
                        usuario:
                        
                        <br />
                        activo:
                        <asp:Label ID="activoLabel" runat="server" Text='<%# Eval("activo") %>' />
                        <br />
                        rol:
                        <asp:Label ID="rolLabel" runat="server" Text='<%# Eval("rol") %>' />
                        <br />
<br />--%>
                    </ItemTemplate>
                </asp:DataList>
                <asp:SqlDataSource ID="ListView" runat="server" ConnectionString="<%$ ConnectionStrings:encuesta_turismoConnectionString %>" ProviderName="<%$ ConnectionStrings:encuesta_turismoConnectionString.ProviderName %>" SelectCommand="SELECT &quot;nombrecompleto&quot;, &quot;email&quot;, &quot;clave&quot;, &quot;usuario&quot;, &quot;activo&quot;, &quot;rol&quot; FROM &quot;usuario&quot;"></asp:SqlDataSource>
            </div>
        </div> 
    </div> 
    </div>
</asp:Content>
