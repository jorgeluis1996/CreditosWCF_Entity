<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="WebEstadoAnalistaSolicitud.aspx.cs" Inherits="SolicitudesWEB_GUI.WebEstadoSolicitud" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../CSS/bootstrap.css" rel="stylesheet" type="text/css" />
    <link href="../CSS/DemoCSS.css" rel="stylesheet" type="text/css" />
    <style type="text/css">

        .encabezados {
            text-align: center;
            color: #092749;
        }
    h1 {
    font-size: 2.5rem;
  }

h1 {
  font-size: calc(1.375rem + 1.5vw);
}

h1 {
  margin-top: 0;
  margin-bottom: 0.5rem;
  font-weight: 500;
  line-height: 1.2;
}

        .auto-style1 {
            text-align: center;
            color: #092749;
            font-size: 45px;
        }
        .auto-style2 {
            font-size: 25px;
        }
        .auto-style3 {
            width: 701px;
            height: 102px;
        }
        .auto-style4 {
            width: 260px;
        }
        .auto-style5 {
            width: 157px;
        }

        .auto-style6 {
            font-family: Verdana;
            box-shadow: 3px 3px 1px #888888;
            color: white;
            border-style: none;
            border-color: inherit;
            border-width: medium;
            padding: 2px 5px;
            background-color: #006699;
        }

        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3 class="auto-style1" style="font-weight: 700; font-family: 'calibri Light';">Listado de solicitudes por estado y analista</h1>
    <p class="center">
        <span class="auto-style2" style="font-family: 'calibri Light'">Seleccione un analista:</span>&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="cboAnalistas" runat="server" Width="352px" CssClass="marron">
        </asp:DropDownList>
        </p>
    <p class="center" style="font-family: 'calibri Light'; font-size: x-large;">
        Seleccione el estado de las solicitudes:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    <p class="center" style="font-family: 'Calibri Light'; font-size: 20px">
        Estado : <asp:DropDownList ID="cboEstado" runat="server" Width="192px" OnSelectedIndexChanged="cboEstado_SelectedIndexChanged" CssClass="verde">
            <asp:ListItem Value="3">Aprobadas</asp:ListItem>
            <asp:ListItem Value="1">Rechazadas</asp:ListItem>
            <asp:ListItem Value="2">En proceso</asp:ListItem>
        </asp:DropDownList>
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="Consultar" CssClass="auto-style6" Height="33px" Width="124px" />
    </p>
    <table class="auto-style3" align="center">
        <tr>
            <td class="auto-style5">Codigo:</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtCod" runat="server" ReadOnly="True" Style="background: #F3F4EE;" BorderStyle="Groove"></asp:TextBox>
            </td>
            <td>DNI:</td>
            <td>
                <asp:TextBox ID="txtDNI" runat="server" ReadOnly="True" Style="background: #F3F4EE;" BorderStyle="Groove"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Nombre:</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtNombre" runat="server" Style="background: #F3F4EE;" BorderStyle="Groove"></asp:TextBox>
            </td>
            <td>Correo:</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server" ReadOnly="True" Width="261px" Style="background: #F3F4EE;" BorderStyle="Groove"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Apellido:</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtApellido" runat="server" Style="background: #F3F4EE;" BorderStyle="Groove"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <p class="center">
        &nbsp;</p>
    <p class="center">
        <asp:Label ID="lblInfo" runat="server"></asp:Label>
    </p>
    <p class="center">
        <asp:HyperLink ID="HyperLink2" runat="server" BackColor="#092749" CssClass="btn btn-dark" Height="32px" NavigateUrl="~/MenuAnalistas.aspx" Style="color: #fff" Width="97px">Retornar</asp:HyperLink>
    </p>
    <p class="center">
        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
    </p>
        <div class="center">
        <asp:GridView ID="grvSolicitudes" runat="server" Width="80%" AutoGenerateColumns="False" Height="264px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" HorizontalAlign="Center">
            <Columns>
                <asp:BoundField DataField="ld_solicitud" HeaderText="Solicitud" />
                <asp:BoundField DataField="Id_cli" HeaderText="Cod. Cliente" />
                <asp:BoundField DataField="Ape_cli" HeaderText="Apellidos" />
                <asp:BoundField DataField="Nom_cli" HeaderText="Nombre" />
                <asp:BoundField DataField="Id_analista" HeaderText="Cod. Analista" />
                <asp:BoundField DataField="Nom_analista" HeaderText="Analista" />
                <asp:BoundField DataField="PRODUCTO" HeaderText="Producto" />
                <asp:BoundField DataField="Fec_solicitud" HeaderText="Fec. Solicitud" DataFormatString="{0:d}" />
                <asp:BoundField DataField="Monto_solici" HeaderText="Monto solicitado (S/.)" DataFormatString="{0:C0}" />
                <asp:BoundField DataField="Estado" HeaderText="Estado" />
                <asp:BoundField DataField="Est_desembolso" HeaderText="Est. Desembolso" />
                <asp:BoundField DataField="Cuotas" HeaderText="Cuotas" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
    </div>
</asp:Content>
