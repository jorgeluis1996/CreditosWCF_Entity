﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SolicitudesAppWindows.ProxyClientes {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClienteBE", Namespace="http://schemas.datacontract.org/2004/07/WCF_SolicitudesCreditos")]
    [System.SerializableAttribute()]
    public partial class ClienteBE : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Ape_cliField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellNombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartamentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DistritoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Dni_cliField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short EdadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstCivilField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short Est_cliField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short Estado_civilField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Fec_nacimientoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Fec_regField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Fec_ult_modField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Id_clienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Id_ubigeoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Nivel_EducacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Nom_cliField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProvinciaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Ruc_cliField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SexoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Usu_registroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Usu_ult_modField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ape_cli {
            get {
                return this.Ape_cliField;
            }
            set {
                if ((object.ReferenceEquals(this.Ape_cliField, value) != true)) {
                    this.Ape_cliField = value;
                    this.RaisePropertyChanged("Ape_cli");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApellNombre {
            get {
                return this.ApellNombreField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellNombreField, value) != true)) {
                    this.ApellNombreField = value;
                    this.RaisePropertyChanged("ApellNombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Departamento {
            get {
                return this.DepartamentoField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartamentoField, value) != true)) {
                    this.DepartamentoField = value;
                    this.RaisePropertyChanged("Departamento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Distrito {
            get {
                return this.DistritoField;
            }
            set {
                if ((object.ReferenceEquals(this.DistritoField, value) != true)) {
                    this.DistritoField = value;
                    this.RaisePropertyChanged("Distrito");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Dni_cli {
            get {
                return this.Dni_cliField;
            }
            set {
                if ((object.ReferenceEquals(this.Dni_cliField, value) != true)) {
                    this.Dni_cliField = value;
                    this.RaisePropertyChanged("Dni_cli");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short Edad {
            get {
                return this.EdadField;
            }
            set {
                if ((this.EdadField.Equals(value) != true)) {
                    this.EdadField = value;
                    this.RaisePropertyChanged("Edad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EstCivil {
            get {
                return this.EstCivilField;
            }
            set {
                if ((object.ReferenceEquals(this.EstCivilField, value) != true)) {
                    this.EstCivilField = value;
                    this.RaisePropertyChanged("EstCivil");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short Est_cli {
            get {
                return this.Est_cliField;
            }
            set {
                if ((this.Est_cliField.Equals(value) != true)) {
                    this.Est_cliField = value;
                    this.RaisePropertyChanged("Est_cli");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short Estado_civil {
            get {
                return this.Estado_civilField;
            }
            set {
                if ((this.Estado_civilField.Equals(value) != true)) {
                    this.Estado_civilField = value;
                    this.RaisePropertyChanged("Estado_civil");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fec_nacimiento {
            get {
                return this.Fec_nacimientoField;
            }
            set {
                if ((this.Fec_nacimientoField.Equals(value) != true)) {
                    this.Fec_nacimientoField = value;
                    this.RaisePropertyChanged("Fec_nacimiento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fec_reg {
            get {
                return this.Fec_regField;
            }
            set {
                if ((this.Fec_regField.Equals(value) != true)) {
                    this.Fec_regField = value;
                    this.RaisePropertyChanged("Fec_reg");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fec_ult_mod {
            get {
                return this.Fec_ult_modField;
            }
            set {
                if ((this.Fec_ult_modField.Equals(value) != true)) {
                    this.Fec_ult_modField = value;
                    this.RaisePropertyChanged("Fec_ult_mod");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id_cliente {
            get {
                return this.Id_clienteField;
            }
            set {
                if ((object.ReferenceEquals(this.Id_clienteField, value) != true)) {
                    this.Id_clienteField = value;
                    this.RaisePropertyChanged("Id_cliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id_ubigeo {
            get {
                return this.Id_ubigeoField;
            }
            set {
                if ((object.ReferenceEquals(this.Id_ubigeoField, value) != true)) {
                    this.Id_ubigeoField = value;
                    this.RaisePropertyChanged("Id_ubigeo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nivel_Educacion {
            get {
                return this.Nivel_EducacionField;
            }
            set {
                if ((object.ReferenceEquals(this.Nivel_EducacionField, value) != true)) {
                    this.Nivel_EducacionField = value;
                    this.RaisePropertyChanged("Nivel_Educacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom_cli {
            get {
                return this.Nom_cliField;
            }
            set {
                if ((object.ReferenceEquals(this.Nom_cliField, value) != true)) {
                    this.Nom_cliField = value;
                    this.RaisePropertyChanged("Nom_cli");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Provincia {
            get {
                return this.ProvinciaField;
            }
            set {
                if ((object.ReferenceEquals(this.ProvinciaField, value) != true)) {
                    this.ProvinciaField = value;
                    this.RaisePropertyChanged("Provincia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ruc_cli {
            get {
                return this.Ruc_cliField;
            }
            set {
                if ((object.ReferenceEquals(this.Ruc_cliField, value) != true)) {
                    this.Ruc_cliField = value;
                    this.RaisePropertyChanged("Ruc_cli");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sexo {
            get {
                return this.SexoField;
            }
            set {
                if ((object.ReferenceEquals(this.SexoField, value) != true)) {
                    this.SexoField = value;
                    this.RaisePropertyChanged("Sexo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Usu_registro {
            get {
                return this.Usu_registroField;
            }
            set {
                if ((object.ReferenceEquals(this.Usu_registroField, value) != true)) {
                    this.Usu_registroField = value;
                    this.RaisePropertyChanged("Usu_registro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Usu_ult_mod {
            get {
                return this.Usu_ult_modField;
            }
            set {
                if ((object.ReferenceEquals(this.Usu_ult_modField, value) != true)) {
                    this.Usu_ult_modField = value;
                    this.RaisePropertyChanged("Usu_ult_mod");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyClientes.IServicioCliente")]
    public interface IServicioCliente {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCliente/InsertClient", ReplyAction="http://tempuri.org/IServicioCliente/InsertClientResponse")]
        bool InsertClient(SolicitudesAppWindows.ProxyClientes.ClienteBE objClienteBE);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCliente/InsertClient", ReplyAction="http://tempuri.org/IServicioCliente/InsertClientResponse")]
        System.Threading.Tasks.Task<bool> InsertClientAsync(SolicitudesAppWindows.ProxyClientes.ClienteBE objClienteBE);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCliente/UpdateClient", ReplyAction="http://tempuri.org/IServicioCliente/UpdateClientResponse")]
        bool UpdateClient(SolicitudesAppWindows.ProxyClientes.ClienteBE objClienteBE);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCliente/UpdateClient", ReplyAction="http://tempuri.org/IServicioCliente/UpdateClientResponse")]
        System.Threading.Tasks.Task<bool> UpdateClientAsync(SolicitudesAppWindows.ProxyClientes.ClienteBE objClienteBE);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCliente/DeleteClient", ReplyAction="http://tempuri.org/IServicioCliente/DeleteClientResponse")]
        bool DeleteClient(string Id_cli);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCliente/DeleteClient", ReplyAction="http://tempuri.org/IServicioCliente/DeleteClientResponse")]
        System.Threading.Tasks.Task<bool> DeleteClientAsync(string Id_cli);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCliente/GetClient", ReplyAction="http://tempuri.org/IServicioCliente/GetClientResponse")]
        SolicitudesAppWindows.ProxyClientes.ClienteBE GetClient(string Id_cli);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCliente/GetClient", ReplyAction="http://tempuri.org/IServicioCliente/GetClientResponse")]
        System.Threading.Tasks.Task<SolicitudesAppWindows.ProxyClientes.ClienteBE> GetClientAsync(string Id_cli);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCliente/GetAllClientes", ReplyAction="http://tempuri.org/IServicioCliente/GetAllClientesResponse")]
        SolicitudesAppWindows.ProxyClientes.ClienteBE[] GetAllClientes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCliente/GetAllClientes", ReplyAction="http://tempuri.org/IServicioCliente/GetAllClientesResponse")]
        System.Threading.Tasks.Task<SolicitudesAppWindows.ProxyClientes.ClienteBE[]> GetAllClientesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioClienteChannel : SolicitudesAppWindows.ProxyClientes.IServicioCliente, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioClienteClient : System.ServiceModel.ClientBase<SolicitudesAppWindows.ProxyClientes.IServicioCliente>, SolicitudesAppWindows.ProxyClientes.IServicioCliente {
        
        public ServicioClienteClient() {
        }
        
        public ServicioClienteClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioClienteClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioClienteClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioClienteClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool InsertClient(SolicitudesAppWindows.ProxyClientes.ClienteBE objClienteBE) {
            return base.Channel.InsertClient(objClienteBE);
        }
        
        public System.Threading.Tasks.Task<bool> InsertClientAsync(SolicitudesAppWindows.ProxyClientes.ClienteBE objClienteBE) {
            return base.Channel.InsertClientAsync(objClienteBE);
        }
        
        public bool UpdateClient(SolicitudesAppWindows.ProxyClientes.ClienteBE objClienteBE) {
            return base.Channel.UpdateClient(objClienteBE);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateClientAsync(SolicitudesAppWindows.ProxyClientes.ClienteBE objClienteBE) {
            return base.Channel.UpdateClientAsync(objClienteBE);
        }
        
        public bool DeleteClient(string Id_cli) {
            return base.Channel.DeleteClient(Id_cli);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteClientAsync(string Id_cli) {
            return base.Channel.DeleteClientAsync(Id_cli);
        }
        
        public SolicitudesAppWindows.ProxyClientes.ClienteBE GetClient(string Id_cli) {
            return base.Channel.GetClient(Id_cli);
        }
        
        public System.Threading.Tasks.Task<SolicitudesAppWindows.ProxyClientes.ClienteBE> GetClientAsync(string Id_cli) {
            return base.Channel.GetClientAsync(Id_cli);
        }
        
        public SolicitudesAppWindows.ProxyClientes.ClienteBE[] GetAllClientes() {
            return base.Channel.GetAllClientes();
        }
        
        public System.Threading.Tasks.Task<SolicitudesAppWindows.ProxyClientes.ClienteBE[]> GetAllClientesAsync() {
            return base.Channel.GetAllClientesAsync();
        }
    }
}
