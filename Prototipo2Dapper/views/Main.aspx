<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="Prototipo2Dapper.views.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">    
        <strong>MENU PRINCIPAL</strong>

    </div>
        <label>CREAR NUEVO CUESTIONARIO</label><label>O</label>
        <asp:ImageButton ID="ImageButton1" runat="server" Height="162px" OnClick="ImageButton1_Click" Width="204px" ImageUrl="~/img/calidad.png" />
        <br /> 
        <label>CUESTIONARIOS CREADOS</label>
        <asp:ImageButton ID="ImageButton2" runat="server" Height="162px" Width="204px" />
        <br />
        <label>EDITAR PERFIL PROFESIONAL</label>
        <asp:ImageButton ID="ImageButton3" runat="server" Height="148px" Width="215px" />
    </form>
    <footer style="height: 30px; margin-top: 160px"></footer>
</body>
</html>
