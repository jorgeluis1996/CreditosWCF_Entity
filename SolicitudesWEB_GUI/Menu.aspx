<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="ProySolicitudesWEB_GUI.Menu" %>
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
        .auto-style14 {
            font-size: 25px;
            font-weight: bold;
        }
        .auto-style15 {
            width: 1015px;
            height: 205px;
        }
        .auto-style16 {
            width: 389px;
            height: 205px;
        }
        .auto-style17 {
            font-size: 40pt;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="pag-centrado">
    
    <h2 class="encabezados" style="color:#092749">
        <strong>
        <asp:Label ID="lblBienvenida" runat="server" CssClass="auto-style17"></asp:Label>
        </strong>
    </h2>
    <div class="principal">
        <h3 style="color:#092749; font-size: 30px">¿Que consulta desea hacer el dia de hoy?</h3>
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
                            <h4 style="font-weight:700; font-size:25px">MENU ANALISTA</h4>
                            <p>Lleve un control sobre el progreso de los analistas a su cargo.</p>
                            <p>Revise quienes son sus mejores colaboradores, y la informacion detallada de sus operaciones.</p>
                        </td>
                        <td style="text-align:center" class="auto-style8">
                            <asp:Button ID="Button5" runat="server" CssClass="btn btn-dark" PostBackUrl="~/MenuAnalistas.aspx" Text="Ir a  Analista" Height="51px" Width="187px" Style="color: #fff;background-color: #212529;border-color: #212529;cursor: pointer; margin-left: 0;" ValidateRequestMode="Enabled" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style9">
                            </td>
                        <td class="auto-style10">
                            </td>
                    </tr>
                    <tr>
                        <td class="auto-style15"; style="color: #092749; padding:20px">
                            <h4 class="auto-style14">MENU SOLICITUDES</h4>
                            <p>Analice y revice las solicitudes hechas, los pagos realizados por las solicitudes aprobadas.&nbsp; </p>
                        </td>
                        <td style="text-align:center" class="auto-style16">
            <asp:Button ID="Button7" runat="server" CssClass="btn btn-dark" PostBackUrl="~/MenuSolicitudes.aspx" Text="Ir a Solicitudes" Height="45px" Width="180px" />
                        </td>
                    </tr>
                    </table>
            
        <br />
        <table class="auto-style11">
            <tr>
                <td>&nbsp;</td>
                <td>
            
                    &nbsp;</td>
            </tr>
        </table>
        
    </div>
</asp:Content>
