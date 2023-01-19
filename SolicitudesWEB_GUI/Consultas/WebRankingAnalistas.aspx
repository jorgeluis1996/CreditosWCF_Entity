<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="WebRankingAnalistas.aspx.cs" Inherits="SolicitudesWEB_GUI.Consultas.WebRankingAnalistas" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../CSS/bootstrap.css" rel="stylesheet" type="text/css" />
    <link href="../CSS/DemoCSS.css" rel="stylesheet" type="text/css" />
    <style type="text/css">

        .encabezados {
            text-align: center;
            color: #092749;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="encabezados" style="font-size: 35px; font-weight: 700; font-family: 'Calibri Light';">
        Ranking Analistas</p>
    <p class="center">
        Busque a sus tops en operaciones</p>
    <p class="center">
        Nro Tops:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtTop" runat="server" Width="125px" BorderStyle="Groove" CssClass="azul"></asp:TextBox>
    </p>
    <p class="center">
        Estado Solicitud:
        <asp:DropDownList ID="cboEstado" runat="server" Width="192px" CssClass="azul">
            <asp:ListItem Value="3">Aprobadas</asp:ListItem>
            <asp:ListItem Value="1">Rechazadas</asp:ListItem>
            <asp:ListItem Value="2">En proceso</asp:ListItem>
        </asp:DropDownList>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnConsultar" runat="server" OnClick="btnConsultar_Click" Text="Consultar" CssClass="boton2" />
    </p>
    <p class="center">
        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
    </p>
    <p class="center">
        <asp:HyperLink ID="HyperLink2" runat="server" BackColor="#092749" CssClass="btn btn-dark" Height="32px" NavigateUrl="~/MenuAnalistas.aspx" Style="color: #fff" Width="97px">Retornar</asp:HyperLink>
    </p>
    <p class="center">
        <asp:GridView ID="grvSolicitudes" runat="server" Width="80%" AutoGenerateColumns="False" Height="233px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" HorizontalAlign="Center">
            <Columns>
                <asp:BoundField DataField="Id_analista" HeaderText="Id Analista" />
                <asp:BoundField DataField="Nom_analista" HeaderText="Analista" />
                <asp:BoundField DataField="net_value" HeaderText="Monto" DataFormatString="{0:C0}" >
                <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="NumeroSolicitudes" HeaderText="Cant. Solicitudes" >
                <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
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
    <p>
        &nbsp;</p>
</asp:Content>
