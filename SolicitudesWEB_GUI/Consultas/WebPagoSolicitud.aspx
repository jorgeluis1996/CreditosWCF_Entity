<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="WebPagoSolicitud.aspx.cs" Inherits="SolicitudesWEB_GUI.WebPagoSolicitud" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../CSS/bootstrap.css" rel="stylesheet" type="text/css" />
    <link href="../CSS/DemoCSS.css" rel="stylesheet" type="text/css" />
    <style type="text/css">

        .encabezados {
            text-align: center;
            color: #092749;
        }
        .auto-style1 {
            position: center;
            width: 83%;
            margin-left: 184px;
            text-align: center;
        }
        .auto-style2 {
            width: 243px;
            margin-left: 812px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="encabezados" style="font-size: 35px; font-weight: 700; font-family: 'calibri Light';">
        Pagos de los creditos/solicitudes aprobados/as</p>
    <p class="center">
        Escriba el codigo de su solicitud:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtIdSolicitud" runat="server" BorderStyle="Groove" CssClass="display"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="Consultar" CssClass="boton2" />
    </p>
    <p class="center">
        *Probar con S00002</p>
    <p class="auto-style2">
&nbsp;<asp:Label ID="lblInfo" runat="server"></asp:Label>
    <br />
    <br />
    <asp:HyperLink ID="HyperLink1" runat="server" BackColor="#092749" CssClass="btn btn-dark" Height="32px" NavigateUrl="~/MenuSolicitudes.aspx" Style="color: #fff" Width="97px">Retornar</asp:HyperLink>
    <br />
    <br />
    <asp:Label ID="lblMensaje" runat="server"></asp:Label>
    <br />
        <br />
        <br />
    </p>
    <p class="auto-style1">
        <asp:GridView ID="grvSolicitudes" runat="server" Width="1457px" AutoGenerateColumns="False" CellPadding="4" ForeColor="Black" GridLines="Horizontal" Height="233px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" HorizontalAlign="Center">
            <Columns>
                <asp:BoundField DataField="Boleta" HeaderText="Boleta" />
                <asp:BoundField DataField="ld_solicitud" HeaderText="Solicitud" />
                <asp:BoundField DataField="Nom_cli" HeaderText="Cliente" />
                <asp:BoundField DataField="Id_cli" HeaderText="Cod. Cliente" />
                <asp:BoundField DataField="MontCancelado" HeaderText="Monto cancelado (€)" DataFormatString="{0:C0}" />
                <asp:BoundField DataField="CuotaNro" HeaderText="Nro. Cuota" />
                <asp:BoundField DataField="Cuotas" HeaderText="Cuotas" />
                <asp:BoundField DataField="Fec_pago" HeaderText="Fec. Pago" DataFormatString="{0:d}" />
                <asp:BoundField DataField="Fec_rechazo" HeaderText="Fec. Cancelacion" DataFormatString="{0:d}" />
                <asp:BoundField DataField="Retraso" HeaderText="Dias de retraso" />
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
    </p>
</asp:Content>
