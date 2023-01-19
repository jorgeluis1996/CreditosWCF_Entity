<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="Web SolicitudFechaAnalista.aspx.cs" Inherits="SolicitudesWEB_GUI.Web_SolicitudFechaAnalista" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../CSS/bootstrap.css" rel="stylesheet" type="text/css" />
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

        .auto-style7 {
            width: 56%;
            height: 83px;
            margin-left: 412px;
            margin-right: 0px;
            margin-top: 33px;
        }
        .auto-style9 {
            color: #092749;
            font-size: 30px;
            width: 100%;
            justify-content: center;
            text-align: center;
        }
        .auto-style10 {
            height: 48px;
            text-align: center;
        }
        .auto-style11 {
            width: 198px;
        }
        .auto-style12 {
            font-weight: normal;
        }
        .auto-style13 {
            text-align: center;
            font-weight: normal;
            font-size: 20px;
        }
        .auto-style14 {
            font-size: 15px;
        }
        .auto-style15 {
            height: 26px;
            width: 101px;
            text-align: center;
        }
        .auto-style16 {
            text-align: center;
            height: 26px;
            width: 65px;
        }
        .auto-style17 {
            width: 50%;
            height: 60px;
            margin-top: 43px;
            
        }
        .auto-style19 {
            width: 165px;
        }
        .auto-style20 {
            width: 176px;
        }
        .auto-style21 {
            width: 118px;
        }
        .auto-style22 {
            font-weight: bold;
        }
        .auto-style26 {
            margin-left: 0px;
        }
        .auto-style28 {
            height: 26px;
            width: 120px;
            text-align: center;
        }
        .auto-style29 {
            height: 26px;
            width: 135px;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="auto-style9" style="font-size: 45px; font-weight: 700; font-family: 'Calibri Light'; font-style: normal;">Solicitudes Generadas</h1>
    <h1 class="encabezados" style="font-size: 28px; font-weight: 700;">&nbsp;<span class="auto-style12">Analistas por fechas</span></h1>
    <p class="encabezados" style="font-size: 25px; font-weight: 700;">&nbsp;</p>
    <h3 class="auto-style13" style="font-family: 'calibri Light'; font-size: 25px">
        Seleccione a un analista a consultar:</h3>
    <p class="center">
        <span class="auto-style14" style="font-family: 'calibri Light'; font-size: 23px">Analista:</span>
        <asp:DropDownList ID="cboAnalista" runat="server" Width="192px" CssClass="verde">
        </asp:DropDownList>
&nbsp;
        </p>
    <table class="auto-style17" align="center">
        <tr>
            <td class="auto-style29" style="font-family: 'calibri Light'; font-size: 20px">Desde:</td>
            <td class="auto-style16">
        <asp:TextBox ID="txtFI" runat="server" BorderStyle="Ridge" CssClass="auto-style26"></asp:TextBox>
        <ajaxToolkit:CalendarExtender ID="txtFI_CalendarExtender" runat="server" BehaviorID="txtFI_CalendarExtender" TargetControlID="txtFI">
        </ajaxToolkit:CalendarExtender>
            </td>
            <td class="auto-style15" style="font-family: 'calibri Light'; font-size: 20px">Hasta:</td>
            <td class="auto-style28"> <asp:TextBox ID="txtFF" runat="server" BorderStyle="Ridge"></asp:TextBox>
        <ajaxToolkit:CalendarExtender ID="txtFF_CalendarExtender" runat="server" BehaviorID="txtFF_CalendarExtender" TargetControlID="txtFF">
        </ajaxToolkit:CalendarExtender>
            </td>
        </tr>
        <tr>
            <td class="auto-style10" colspan="4">
                <br />
        <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" CssClass="boton2" />
            </td>
        </tr>
    </table>
    <br />
    <table class="auto-style7">
        <tr>
            <td class="auto-style19" style="font-family: 'Calibri Light'; font-size: large;">Codigo:</td>
            <td class="auto-style11">
                <asp:TextBox ID="txtCod" runat="server" ReadOnly="True" Style="background: #F3F4EE;" BorderStyle="Groove" CssClass="auto-style22"></asp:TextBox>
            </td>
            <td class="auto-style20" style="font-family: 'Calibri Light'; font-size: large">DNI:</td>
            <td class="auto-style21">
                <asp:TextBox ID="txtDNI" runat="server" ReadOnly="True" Style="background: #F3F4EE;" BorderStyle="Groove" CssClass="auto-style22"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style19" style="font-family: 'Calibri Light'; font-size: large;">Nombre:</td>
            <td class="auto-style11">
                <asp:TextBox ID="txtNombre" runat="server" ReadOnly="True" Style="background: #F3F4EE;" BorderStyle="Groove"></asp:TextBox>
            </td>
            <td class="auto-style20" style="font-family: 'Calibri Light'; font-size: large">Correo:</td>
            <td class="auto-style21">
                <asp:TextBox ID="txtEmail" runat="server" ReadOnly="True" Style="background: #F3F4EE;" BorderStyle="Groove"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style19" style="font-family: 'Calibri Light'; font-size: large;">Apellido:</td>
            <td class="auto-style11">
                <asp:TextBox ID="txtApellido" runat="server" ReadOnly="True" Style="background: #F3F4EE;" BorderStyle="Groove"></asp:TextBox>
            </td>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style21">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style19">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style21">&nbsp;</td>
        </tr>
    </table>
    <p class="center">
        &nbsp;</p>
    <p class="center">
        <asp:HyperLink ID="HyperLink2" runat="server" BackColor="#092749" CssClass="btn btn-dark" Height="32px" NavigateUrl="~/MenuAnalistas.aspx" Style="color: #fff" Width="97px">Retornar</asp:HyperLink>
    </p>
    <p class="center">
        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
    </p>
    <p>
        <div class="center">
        <asp:GridView ID="grvSolicitudes" runat="server" Width="80%" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="233px" ShowHeaderWhenEmpty="True" HorizontalAlign="Center">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="ld_solicitud" HeaderText="Solicitud" />
                <asp:BoundField DataField="Id_cli" HeaderText="Cod. Cliente" />
                <asp:BoundField DataField="Ape_cli" HeaderText="Apellidos" />
                <asp:BoundField DataField="Nom_cli" HeaderText="Nombre" />
                <asp:BoundField DataField="PRODUCTO" HeaderText="Producto" />
                <asp:BoundField DataField="Fec_solicitud" HeaderText="Fec. Solicitud" DataFormatString="{0:d}" />
                <asp:BoundField DataField="Monto_solici" HeaderText="Monto solicitado (S/.)" DataFormatString="{0:C0}" />
                <asp:BoundField DataField="Est_solicitud" HeaderText="Estado" />
                <asp:BoundField DataField="AprobacionFecha" HeaderText="Fec. Aprobacion" DataFormatString="{0:d}" />
                <asp:BoundField DataField="PruebaFecha" HeaderText="Fec. Rechazo" />
                <asp:BoundField DataField="Motivo_rechazo" HeaderText="Motivo rechazo" />
                <asp:BoundField DataField="Est_desembolso" HeaderText="Est. Desembolso" />
                <asp:BoundField DataField="RechazoFecha" HeaderText="Fec.Desembolso" DataFormatString="{0:d}" />
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
        </div>
        s</p>
</asp:Content>
