<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="MenuSolicitudes.aspx.cs" Inherits="ProySolicitudesWEB_GUI.MenuSolicitudes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/bootstrap.css" rel="stylesheet" type="text/css" />
    <link href="CSS/DemoCSS.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
    .encabezados{
        text-align: center;
        color: black;
    }
    .principal {
        width: 90%;
        margin: 0 auto;
    }
    /*.tarjetas {
        display:flex;
    }*/
        .auto-style3 {
            width: 80%;
            background-color: white;
            margin: 0 auto;
            border-style:double;
            border-width: 3px;
        }
        .auto-style4 {
            width: 1015px;
        }
    .auto-style5 {
        width: 389px;
    }
        .auto-style7 {
            width: 1015px;
            
            height: 208px;
        }
        .auto-style8 {
            width: 389px;
            height: 208px;
        }
        .auto-style9 {
            width: 1015px;
            height: 27px;
        }
        .auto-style10 {
            width: 389px;
            height: 27px;
        }
        .auto-style11 {
            width: 80%;
        }
        .auto-style12 {
            font-size: 30px;
            color: #092749;
        }
        .auto-style13 {
            font-size: 40pt;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="pag-centrado">
    <h2 class="encabezados" style="color:#092749">
        <strong>
        <asp:Label ID="lblBienvenida" runat="server" CssClass="auto-style13"></asp:Label>
        </strong>
    </h2>
    <div class="principal">
        <h3 class="auto-style12">Reporte de solicitudes</h3>
        <!--<div class="tarjetas">
            <div class="tarjeta">
                <h4>Evaluacion de clientes</h4>
                <p>Conozca mas del estado financiero del cliente para las aprobaciones de sus solicitudes</p>
                <p>Revise los ingresos, garantias y solicitudes previamente realizadas por los clientes</p>
            </div>
            <div class="tarjeta">
                <h4>Reportes de analistas</h4>
                <p>Para un buen control de las solicitudes atendidas o que faltan atender por los colaboradoes a su cargo</p>
                <p>Obtenga una vista de la solicitudes pendientes, aprobadas y rechazadas de cada analista</p>
            </div>
            <div class="tarjeta">
                <h4>Pagos realizados</h4>
                <p>Consulte los pagos que se realizaron a las solicitudes que fueron previamente aprovadas</p>
                <p>Filtre por cliente o id de solicitud para saber si estan pagadas, en mora y en que numero de cuota estan</p>
            </div>
            </div>-->
                <table class="auto-style3" aling="center">
                    <tr>
                        <td class="auto-style7"; style="color: #092749; padding:20px">
                            <h4 style="font-weight:700; font-size:25px">Solicitudes generadas por cliente</h4>
                            <p>Reporte de todas las solicitudes generadas por el cliente.</p>
                            <p>Revise el historial de sus solicitudes para referencias de aprobacion o rechazo.</p>
                        </td>
                        <td style="text-align:center" class="auto-style8">
                            <asp:Button ID="Button5" runat="server" CssClass="btn btn-dark" PostBackUrl="~/Consultas/WebSolicitudCliente.aspx" Text="Consultar" Height="41px" Width="163px" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style9">
                            </td>
                        <td class="auto-style10">
                            </td>
                    </tr>
                    <tr>
                        <td class="auto-style4"; style="color: #092749; padding:20px">
                            <h4 style="font-weight:700; font-size:25px">Solicitudes atendidas por periodos</h4>
                <p>Para un buen control de las solicitudes atendidas o que faltan atender por los colaboradoes a su cargo</p>
                <p>Obtenga una vista de la solicitudes pendientes, aprobadas y rechazadas de cada analista en el periodo indicado</p>
                        </td>
                        <td style="text-align:center" class="auto-style5">
            <asp:Button ID="Button7" runat="server" CssClass="btn btn-dark" PostBackUrl="~/Consultas/WebSolicitudFechaEstado.aspx" Text="Consultar" Height="42px" Width="166px" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            &nbsp;</td>
                        <td class="auto-style5">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style4"; style="color: #092749; padding:20px">
                            <h4 style="font-weight:700; font-size:25px">&nbsp;Consulte los pagos hechos de las solicitudes aprobadas</h4>
                <p>Consulte los pagos que se realizaron a las solicitudes que fueron previamente aprobadas</p>
                <p>Filtre por Id de solicitud para saber si estan pagadas, en mora y en que numero de cuota estan</p>
                        </td>
                        <td style="text-align:center" class="auto-style5">
            <asp:Button ID="Button6" runat="server" CssClass="btn btn-dark" PostBackUrl="~/Consultas/WebPagoSolicitud.aspx" Text="Consultar" Height="44px" Width="162px" />
                        </td>
                    </tr>
                    </table>
            
        <br />
        <table class="auto-style11">
            <tr>
                <td>
            
                            <asp:Button ID="Button8" runat="server" CssClass="btn btn-dark" PostBackUrl="~/Menu.aspx" Text="Volver" Height="44px" Width="188px" />
        
                </td>
            </tr>
        </table>
        </div>
    </div>
</asp:Content>
