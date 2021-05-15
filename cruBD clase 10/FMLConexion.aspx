<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FMLConexion.aspx.cs" Inherits="cruBD_clase_10.FMLConexion" %>

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
        <asp:Button ID="ButtonCargarArchivo" runat="server" Height="30px" OnClick="ButtonCargarArchivo_Click" Text="Cargar Info  CSV" Width="131px" />
        <p>
            <asp:Label ID="Label1" runat="server" Text="BASE DE DATOS DE SQL SERVER"></asp:Label>
        </p>
        <p>
            <asp:Button ID="ButtonBuscar" runat="server" Height="22px" OnClick="Button1_Click" Text="Buscar CON CORRELATIVO" Width="187px" />
            <asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="182px"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="TextBoxBuscar" runat="server" Height="17px" Width="264px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="ButtonBuscarNombre" runat="server" Height="43px" OnClick="ButtonBuscarNombre_Click" Text="Buscar  Por Nombre" Width="243px" />
            <asp:TextBox ID="TextBox2" runat="server" Height="22px" Width="184px"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="TextBoxBuscarpornombre" runat="server" Height="18px" Width="264px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="BASE DE DATOS DE  MYSQL"></asp:Label>
        </p>
        <p>
            <asp:Button ID="ButtonBuscarcorrelativo" runat="server" Height="26px" OnClick="ButtonBuscarcorrelativo_Click" Text="Buscar por Correlativo" Width="175px" />
            <asp:TextBox ID="TextBoxCorrelativo1" runat="server" Height="19px" Width="159px"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="TextBoxCorrelativo2" runat="server" Height="18px" Width="205px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="ButtonBuscarpornombre" runat="server" Height="32px" OnClick="ButtonBuscarpornombre_Click" Text="Buscar por nombre" Width="251px" />
            <asp:TextBox ID="TextBoxnombre1" runat="server" Height="26px" Width="199px"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="TextBoxnombre2" runat="server" Height="16px" Width="269px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
