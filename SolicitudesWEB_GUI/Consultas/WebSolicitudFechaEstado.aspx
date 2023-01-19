<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="WebSolicitudFechaEstado.aspx.cs" Inherits="SolicitudesWEB_GUI.Consultas.WebSolicitudFechaEstado" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../CSS/bootstrap.css" rel="stylesheet" type="text/css" />
    <link href="../CSS/DemoCSS.css" rel="stylesheet" type="text/css" />
    <style type="text/css">       

        .DropDownList{ font-family: Verdana; font-size: 10pt;
	margin-left: 0px;
	  border:1px solid gray;
      height:25px;

	 /*box-shadow: 3px 3px 1px #888888;*/
}

        .encabezados {
            text-align: center;
            color: #092749;
        }
        .auto-style1 {
            text-align: center;
            color: #092749;
            font-size: 35px;
            font-weight: normal;
        }
        .auto-style2 {
            font-weight: normal;
            font-size: 20px;
        }
        .auto-style3 {
            width: 590px;
            height: 132px;
            margin-left: 3px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="pag-centrado">
    <h1 class="auto-style1">Estado de solicitudes por periodo</h1>
    <p class="encabezados" style="font-size: 25px; font-weight: 700;">
        &nbsp;</p>
    <h3 class="center"><span class="auto-style2">Estado de las solicitudes:</span>&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;
        <asp:DropDownList ID="cboEstado" runat="server" Width="192px" CssClass="display">
            <asp:ListItem Value="3">Aprobadas</asp:ListItem>
            <asp:ListItem Value="1">Rechazadas</asp:ListItem>
            <asp:ListItem Value="2">En proceso</asp:ListItem>
        </asp:DropDownList>
    </h3>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <table class="auto-style3 center" align="center">
        <tr>
            <td>Desde:</td>
            <td>
                <asp:TextBox ID="txtFI" runat="server" BorderStyle="Groove"></asp:TextBox>
                <ajaxToolkit:CalendarExtender ID="txtFI_CalendarExtender" runat="server" BehaviorID="txtFI_CalendarExtender" TargetControlID="txtFI">
                </ajaxToolkit:CalendarExtender>
            </td>
            <td>Hasta:</td>
            <td>
                <asp:TextBox ID="txtFF" runat="server" BorderStyle="Groove"></asp:TextBox>
                <ajaxToolkit:CalendarExtender ID="txtFF_CalendarExtender" runat="server" BehaviorID="txtFF_CalendarExtender" TargetControlID="txtFF">
                </ajaxToolkit:CalendarExtender>
            </td>
        </tr>
        <tr>
            <td class="center" colspan="4">
                <br />
                <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" CssClass="boton2" />
                <br />
            </td>
        </tr>
    </table>
    <p class="center">
        &nbsp;</p>
        <p class="center">
        <asp:HyperLink ID="HyperLink1" runat="server" BackColor="#092749" CssClass="btn btn-dark" Height="32px" NavigateUrl="~/MenuSolicitudes.aspx" Style="color: #fff" Width="97px">Retornar</asp:HyperLink>
    </p>
    <p class="center">
        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
    </p>
        </div>
    <p class="text-center">
        <asp:GridView ID="grvSolicitudes" runat="server" Width="88%" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="233px" ShowHeaderWhenEmpty="True" HorizontalAlign="Center">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="ld_solicitud" HeaderText="Solicitud" />
                <asp:BoundField DataField="Id_cli" HeaderText="Cod. Cliente" />
                <asp:BoundField DataField="Ape_cli" HeaderText="Apellidos" />
                <asp:BoundField DataField="Nom_cli" HeaderText="Nombre" />
                <asp:BoundField DataField="PRODUCTO" HeaderText="Producto" />
                <asp:BoundField DataField="Fec_solicitud" HeaderText="Fec. Solicitud" DataFormatString="{0:d}" />
                <asp:BoundField DataField="Monto_solici" HeaderText="Monto solicitado (€)" DataFormatString="{0:C0}" />
                <asp:BoundField DataField="AprobacionFecha" HeaderText="Fec. Aprobacion" />
                <asp:BoundField DataField="PruebaFecha" HeaderText="Fec. Rechazo" />
                <asp:BoundField DataField="Motivo_rechazo" HeaderText="Motivo rechazo" />
                <asp:BoundField DataField="Est_desembolso" HeaderText="Est. Desembolso" />
                <asp:BoundField DataField="RechazoFecha" HeaderText="Fec. Desembolso" />
                <asp:BoundField DataField="Cuotas" HeaderText="Cuotas" />
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
</asp:Content>
