﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace ProyectoIPC2.WServiceIPC2 {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WSIPC2PortBinding", Namespace="http://Servicio/")]
    public partial class WSIPC2 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback loginOperationCompleted;
        
        private System.Threading.SendOrPostCallback añadirParticipanteAOrganizacionOperationCompleted;
        
        private System.Threading.SendOrPostCallback listarOrganizacionesOperationCompleted;
        
        private System.Threading.SendOrPostCallback crearOrganizacionOperationCompleted;
        
        private System.Threading.SendOrPostCallback crearEmpleadoOperationCompleted;
        
        private System.Threading.SendOrPostCallback crearUsuarioOperationCompleted;
        
        private System.Threading.SendOrPostCallback pruebaOperationCompleted;
        
        private System.Threading.SendOrPostCallback getCargoUsuarioOperationCompleted;
        
        private System.Threading.SendOrPostCallback helloOperationCompleted;
        
        private System.Threading.SendOrPostCallback listarEmpleadosOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WSIPC2() {
            this.Url = global::ProyectoIPC2.Properties.Settings.Default.ProyectoIPC2_WServiceIPC2_WSIPC2;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event loginCompletedEventHandler loginCompleted;
        
        /// <remarks/>
        public event añadirParticipanteAOrganizacionCompletedEventHandler añadirParticipanteAOrganizacionCompleted;
        
        /// <remarks/>
        public event listarOrganizacionesCompletedEventHandler listarOrganizacionesCompleted;
        
        /// <remarks/>
        public event crearOrganizacionCompletedEventHandler crearOrganizacionCompleted;
        
        /// <remarks/>
        public event crearEmpleadoCompletedEventHandler crearEmpleadoCompleted;
        
        /// <remarks/>
        public event crearUsuarioCompletedEventHandler crearUsuarioCompleted;
        
        /// <remarks/>
        public event pruebaCompletedEventHandler pruebaCompleted;
        
        /// <remarks/>
        public event getCargoUsuarioCompletedEventHandler getCargoUsuarioCompleted;
        
        /// <remarks/>
        public event helloCompletedEventHandler helloCompleted;
        
        /// <remarks/>
        public event listarEmpleadosCompletedEventHandler listarEmpleadosCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://Servicio/", ResponseNamespace="http://Servicio/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string login([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string usuario, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string contraseña) {
            object[] results = this.Invoke("login", new object[] {
                        usuario,
                        contraseña});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void loginAsync(string usuario, string contraseña) {
            this.loginAsync(usuario, contraseña, null);
        }
        
        /// <remarks/>
        public void loginAsync(string usuario, string contraseña, object userState) {
            if ((this.loginOperationCompleted == null)) {
                this.loginOperationCompleted = new System.Threading.SendOrPostCallback(this.OnloginOperationCompleted);
            }
            this.InvokeAsync("login", new object[] {
                        usuario,
                        contraseña}, this.loginOperationCompleted, userState);
        }
        
        private void OnloginOperationCompleted(object arg) {
            if ((this.loginCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.loginCompleted(this, new loginCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://Servicio/", ResponseNamespace="http://Servicio/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string añadirParticipanteAOrganizacion([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string email, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string organizacion) {
            object[] results = this.Invoke("añadirParticipanteAOrganizacion", new object[] {
                        email,
                        organizacion});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void añadirParticipanteAOrganizacionAsync(string email, string organizacion) {
            this.añadirParticipanteAOrganizacionAsync(email, organizacion, null);
        }
        
        /// <remarks/>
        public void añadirParticipanteAOrganizacionAsync(string email, string organizacion, object userState) {
            if ((this.añadirParticipanteAOrganizacionOperationCompleted == null)) {
                this.añadirParticipanteAOrganizacionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnañadirParticipanteAOrganizacionOperationCompleted);
            }
            this.InvokeAsync("añadirParticipanteAOrganizacion", new object[] {
                        email,
                        organizacion}, this.añadirParticipanteAOrganizacionOperationCompleted, userState);
        }
        
        private void OnañadirParticipanteAOrganizacionOperationCompleted(object arg) {
            if ((this.añadirParticipanteAOrganizacionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.añadirParticipanteAOrganizacionCompleted(this, new añadirParticipanteAOrganizacionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://Servicio/", ResponseNamespace="http://Servicio/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] listarOrganizaciones([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string email) {
            object[] results = this.Invoke("listarOrganizaciones", new object[] {
                        email});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void listarOrganizacionesAsync(string email) {
            this.listarOrganizacionesAsync(email, null);
        }
        
        /// <remarks/>
        public void listarOrganizacionesAsync(string email, object userState) {
            if ((this.listarOrganizacionesOperationCompleted == null)) {
                this.listarOrganizacionesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnlistarOrganizacionesOperationCompleted);
            }
            this.InvokeAsync("listarOrganizaciones", new object[] {
                        email}, this.listarOrganizacionesOperationCompleted, userState);
        }
        
        private void OnlistarOrganizacionesOperationCompleted(object arg) {
            if ((this.listarOrganizacionesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.listarOrganizacionesCompleted(this, new listarOrganizacionesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://Servicio/", ResponseNamespace="http://Servicio/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string crearOrganizacion([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string nombre, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string email) {
            object[] results = this.Invoke("crearOrganizacion", new object[] {
                        nombre,
                        email});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void crearOrganizacionAsync(string nombre, string email) {
            this.crearOrganizacionAsync(nombre, email, null);
        }
        
        /// <remarks/>
        public void crearOrganizacionAsync(string nombre, string email, object userState) {
            if ((this.crearOrganizacionOperationCompleted == null)) {
                this.crearOrganizacionOperationCompleted = new System.Threading.SendOrPostCallback(this.OncrearOrganizacionOperationCompleted);
            }
            this.InvokeAsync("crearOrganizacion", new object[] {
                        nombre,
                        email}, this.crearOrganizacionOperationCompleted, userState);
        }
        
        private void OncrearOrganizacionOperationCompleted(object arg) {
            if ((this.crearOrganizacionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.crearOrganizacionCompleted(this, new crearOrganizacionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://Servicio/", ResponseNamespace="http://Servicio/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string crearEmpleado([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string dpi, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string nombres, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string apellidos, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string contraseña, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string contraseñaRep, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string emailEmpleado, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string emailUsuario) {
            object[] results = this.Invoke("crearEmpleado", new object[] {
                        dpi,
                        nombres,
                        apellidos,
                        contraseña,
                        contraseñaRep,
                        emailEmpleado,
                        emailUsuario});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void crearEmpleadoAsync(string dpi, string nombres, string apellidos, string contraseña, string contraseñaRep, string emailEmpleado, string emailUsuario) {
            this.crearEmpleadoAsync(dpi, nombres, apellidos, contraseña, contraseñaRep, emailEmpleado, emailUsuario, null);
        }
        
        /// <remarks/>
        public void crearEmpleadoAsync(string dpi, string nombres, string apellidos, string contraseña, string contraseñaRep, string emailEmpleado, string emailUsuario, object userState) {
            if ((this.crearEmpleadoOperationCompleted == null)) {
                this.crearEmpleadoOperationCompleted = new System.Threading.SendOrPostCallback(this.OncrearEmpleadoOperationCompleted);
            }
            this.InvokeAsync("crearEmpleado", new object[] {
                        dpi,
                        nombres,
                        apellidos,
                        contraseña,
                        contraseñaRep,
                        emailEmpleado,
                        emailUsuario}, this.crearEmpleadoOperationCompleted, userState);
        }
        
        private void OncrearEmpleadoOperationCompleted(object arg) {
            if ((this.crearEmpleadoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.crearEmpleadoCompleted(this, new crearEmpleadoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://Servicio/", ResponseNamespace="http://Servicio/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string crearUsuario([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string dpi, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string nombres, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string apellidos, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string contraseña, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string contraseñaRep, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string email) {
            object[] results = this.Invoke("crearUsuario", new object[] {
                        dpi,
                        nombres,
                        apellidos,
                        contraseña,
                        contraseñaRep,
                        email});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void crearUsuarioAsync(string dpi, string nombres, string apellidos, string contraseña, string contraseñaRep, string email) {
            this.crearUsuarioAsync(dpi, nombres, apellidos, contraseña, contraseñaRep, email, null);
        }
        
        /// <remarks/>
        public void crearUsuarioAsync(string dpi, string nombres, string apellidos, string contraseña, string contraseñaRep, string email, object userState) {
            if ((this.crearUsuarioOperationCompleted == null)) {
                this.crearUsuarioOperationCompleted = new System.Threading.SendOrPostCallback(this.OncrearUsuarioOperationCompleted);
            }
            this.InvokeAsync("crearUsuario", new object[] {
                        dpi,
                        nombres,
                        apellidos,
                        contraseña,
                        contraseñaRep,
                        email}, this.crearUsuarioOperationCompleted, userState);
        }
        
        private void OncrearUsuarioOperationCompleted(object arg) {
            if ((this.crearUsuarioCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.crearUsuarioCompleted(this, new crearUsuarioCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://Servicio/", ResponseNamespace="http://Servicio/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int prueba([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string Dato1, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string Dato2) {
            object[] results = this.Invoke("prueba", new object[] {
                        Dato1,
                        Dato2});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void pruebaAsync(string Dato1, string Dato2) {
            this.pruebaAsync(Dato1, Dato2, null);
        }
        
        /// <remarks/>
        public void pruebaAsync(string Dato1, string Dato2, object userState) {
            if ((this.pruebaOperationCompleted == null)) {
                this.pruebaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnpruebaOperationCompleted);
            }
            this.InvokeAsync("prueba", new object[] {
                        Dato1,
                        Dato2}, this.pruebaOperationCompleted, userState);
        }
        
        private void OnpruebaOperationCompleted(object arg) {
            if ((this.pruebaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.pruebaCompleted(this, new pruebaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://Servicio/", ResponseNamespace="http://Servicio/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int getCargoUsuario([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string email) {
            object[] results = this.Invoke("getCargoUsuario", new object[] {
                        email});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void getCargoUsuarioAsync(string email) {
            this.getCargoUsuarioAsync(email, null);
        }
        
        /// <remarks/>
        public void getCargoUsuarioAsync(string email, object userState) {
            if ((this.getCargoUsuarioOperationCompleted == null)) {
                this.getCargoUsuarioOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetCargoUsuarioOperationCompleted);
            }
            this.InvokeAsync("getCargoUsuario", new object[] {
                        email}, this.getCargoUsuarioOperationCompleted, userState);
        }
        
        private void OngetCargoUsuarioOperationCompleted(object arg) {
            if ((this.getCargoUsuarioCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getCargoUsuarioCompleted(this, new getCargoUsuarioCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://Servicio/", ResponseNamespace="http://Servicio/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string hello([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string name) {
            object[] results = this.Invoke("hello", new object[] {
                        name});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void helloAsync(string name) {
            this.helloAsync(name, null);
        }
        
        /// <remarks/>
        public void helloAsync(string name, object userState) {
            if ((this.helloOperationCompleted == null)) {
                this.helloOperationCompleted = new System.Threading.SendOrPostCallback(this.OnhelloOperationCompleted);
            }
            this.InvokeAsync("hello", new object[] {
                        name}, this.helloOperationCompleted, userState);
        }
        
        private void OnhelloOperationCompleted(object arg) {
            if ((this.helloCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.helloCompleted(this, new helloCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://Servicio/", ResponseNamespace="http://Servicio/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] listarEmpleados([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string email) {
            object[] results = this.Invoke("listarEmpleados", new object[] {
                        email});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void listarEmpleadosAsync(string email) {
            this.listarEmpleadosAsync(email, null);
        }
        
        /// <remarks/>
        public void listarEmpleadosAsync(string email, object userState) {
            if ((this.listarEmpleadosOperationCompleted == null)) {
                this.listarEmpleadosOperationCompleted = new System.Threading.SendOrPostCallback(this.OnlistarEmpleadosOperationCompleted);
            }
            this.InvokeAsync("listarEmpleados", new object[] {
                        email}, this.listarEmpleadosOperationCompleted, userState);
        }
        
        private void OnlistarEmpleadosOperationCompleted(object arg) {
            if ((this.listarEmpleadosCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.listarEmpleadosCompleted(this, new listarEmpleadosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void loginCompletedEventHandler(object sender, loginCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class loginCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal loginCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void añadirParticipanteAOrganizacionCompletedEventHandler(object sender, añadirParticipanteAOrganizacionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class añadirParticipanteAOrganizacionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal añadirParticipanteAOrganizacionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void listarOrganizacionesCompletedEventHandler(object sender, listarOrganizacionesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class listarOrganizacionesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal listarOrganizacionesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void crearOrganizacionCompletedEventHandler(object sender, crearOrganizacionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class crearOrganizacionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal crearOrganizacionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void crearEmpleadoCompletedEventHandler(object sender, crearEmpleadoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class crearEmpleadoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal crearEmpleadoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void crearUsuarioCompletedEventHandler(object sender, crearUsuarioCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class crearUsuarioCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal crearUsuarioCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void pruebaCompletedEventHandler(object sender, pruebaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class pruebaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal pruebaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void getCargoUsuarioCompletedEventHandler(object sender, getCargoUsuarioCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getCargoUsuarioCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getCargoUsuarioCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void helloCompletedEventHandler(object sender, helloCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class helloCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal helloCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void listarEmpleadosCompletedEventHandler(object sender, listarEmpleadosCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class listarEmpleadosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal listarEmpleadosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591