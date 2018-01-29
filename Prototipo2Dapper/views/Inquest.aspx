<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inquest.aspx.cs" Inherits="Prototipo2Dapper.views.Inquest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
    </div>
        <div>
        <h1>Formulario de Datos Empresariales</h1>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <label>Nombre de la Encuesta</label>
        </div>
        <div>
            <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
            <label>Cabecera de la Encuesta</label></div>
        <div><asp:TextBox ID="TextBox3" runat="server" ></asp:TextBox>

            <label>Descripción</label>
        </div>
        <div>
            <label>Tipo de Cuestionario</label>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="PGSQL" DataTextField="descripcion" DataValueField="id">
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            <asp:SqlDataSource ID="PGSQL" runat="server" ConnectionString="<%$ ConnectionStrings:encuesta_turismoConnectionString %>" ProviderName="<%$ ConnectionStrings:encuesta_turismoConnectionString.ProviderName %>" SelectCommand="SELECT &quot;descripcion&quot;, &quot;id&quot; FROM &quot;tipo_cuestionario&quot;"></asp:SqlDataSource>

        </div>
        <div>
            <label>Estado del Cuestionario</label><br />
            <asp:RadioButton ID="RadioButton1" runat="server" Text="Activo"/><br />
            <asp:RadioButton ID="RadioButton2" runat="server"  Text="Inactivo"/>
        </div>
        <p style="height: 33px; margin-top: 442px">
            <asp:Button ID="CrearCuestionario" runat="server" Height="32px" Text="Crear" Width="68px" />
        </p>
    </form>
</body>
</html>
