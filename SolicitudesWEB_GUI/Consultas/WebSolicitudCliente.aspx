<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="WebSolicitudCliente.aspx.cs" Inherits="SolicitudesWEB_GUI.WebSolicitudCliente" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../CSS/bootstrap.css" rel="stylesheet" type="text/css" />
    <link href="../CSS/DemoCSS.css" rel="stylesheet" type="text/css" />
    <style type="text/css">

        .encabezados {
            text-align: center;
            color: #092749;
        }
        .auto-style1 {
            width: 45%;
            height: 153px;
        }
        .auto-style2 {
            height: 29px;
            text-align: center;
        }
        .auto-style3 {
            height: 30px;
            text-align: center;
        }
        .auto-style4 {
            text-align: center;
            color: #092749;
            font-size: 35px;
            font-weight: normal;
        }
        .auto-style5 {
            text-align: center;
            font-size: 20px;
        }
        .auto-style6 {
            height: 30px;
            text-align: center;
            width: 235px;
        }
        .auto-style7 {
            height: 29px;
            text-align: center;
            width: 235px;
        }
        .auto-style8 {
            width: 201px;
        }
        .auto-style9 {
            height: 29px;
            width: 201px;
            text-align: center;
        }
        .auto-style10 {
            height: 30px;
            width: 201px;
            text-align: center;
        }
        .auto-style11 {
            text-align: center;
            width: 235px;
        }
        .auto-style12 {
            width: 201px;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="auto-style4">
        Solicitudes Generadas por Cliente</h1>
    <p class="auto-style5">
        Seleccione el cliente a consultar:</p>
    <p class="center">
        Cliente :
        <asp:DropDownList ID="cboClientes" runat="server" Width="192px" CssClass="azul">
        </asp:DropDownList>
&nbsp;
        <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" CssClass="boton2" />
    </p>
    <table class="auto-style1" align="center">
        <tr>
            <td class="auto-style12">Nombre:</td>
            <td class="auto-style11">
                <asp:TextBox ID="txtNombre" runat="server" ReadOnly="True" Style="background: #F3F4EE;" BorderStyle="Groove"></asp:TextBox>
            </td>
            <td class="center">DNI:</td>
            <td class="center">
                <asp:TextBox ID="txtDNI" runat="server" ReadOnly="True" Style="background: #F3F4EE;" BorderStyle="Groove"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">Apellido:</td>
            <td class="auto-style7">
                <asp:TextBox ID="txtApellido" runat="server" ReadOnly="True" Style="background: #F3F4EE;" BorderStyle="Groove" CssClass="offset-sm-0"></asp:TextBox>
            </td>
            <td class="auto-style2">RUC:</td>
            <td class="auto-style2">
                <asp:TextBox ID="txtRUC" runat="server" ReadOnly="True" Style="background: #F3F4EE;" BorderStyle="Groove"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style10">Correo:</td>
            <td class="auto-style6">
                <asp:TextBox ID="txtCorreo" runat="server" ReadOnly="True" Style="background: #F3F4EE;" BorderStyle="Groove" Width="289px"></asp:TextBox>
            </td>
            <td class="auto-style3">Est.Civil:</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtEstCivil" runat="server" ReadOnly="True" Style="background: #F3F4EE;" BorderStyle="Groove"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <p class="center">
        &nbsp;</p>
    <p class="center">
        <asp:Label ID="lblPrueba" runat="server"></asp:Label>
    </p>
    <p class="center">
        
        <asp:HyperLink ID="HyperLink1" runat="server" BackColor="#092749" CssClass="btn btn-dark" Height="32px" NavigateUrl="~/MenuSolicitudes.aspx" Style="color: #fff" Width="97px">Retornar</asp:HyperLink>
    </p>
    <p class="center">
        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
    </p>
    <p class="center">
        <asp:GridView ID="grvSolicitudes" runat="server" Width="84%"  AutoGenerateColumns="False" Height="230px" CellPadding="4" ForeColor="Black" GridLines="None" HorizontalAlign="Center" BackColor="White" BorderColor="#CCCCCC">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="ld_solicitud" HeaderText="Solicitud" />
                <asp:BoundField DataField="Id_cli" HeaderText="Cod. Cliente" />
                <asp:BoundField DataField="Nom_cli" HeaderText="Nombre" />
                <asp:BoundField DataField="PRODUCTO" HeaderText="Producto" />
                <asp:BoundField DataField="Fec_solicitud" HeaderText="Fec. Solicitud" DataFormatString="{0:d}" />
                <asp:BoundField DataField="Monto_solici" HeaderText="Monto solicitado (€)" DataFormatString="{0:C0}" />
                <asp:BoundField DataField="Estado" HeaderText="Estado" />
                <asp:BoundField DataField="AprobacionFecha" HeaderText="Fec. Aprobacion" />
                <asp:BoundField DataField="PruebaFecha" HeaderText="Fec. Rechazo" />
                <asp:BoundField DataField="Motivo_rechazo" HeaderText="Motivo rechazo" />
                <asp:BoundField DataField="Est_desembolso" HeaderText="Est. Desembolso" />
                <asp:BoundField DataField="Cuotas" HeaderText="Cuotas" />
                <asp:BoundField DataField="RechazoFecha" HeaderText="Fec. Desembolso" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
