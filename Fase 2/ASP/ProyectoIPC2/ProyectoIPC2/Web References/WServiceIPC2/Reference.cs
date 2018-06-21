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
        
        private System.Threading.SendOrPostCallback crearOrganizacionOperationCompleted;
        
        private System.Threading.SendOrPostCallback crearUsuarioOperationCompleted;
        
        private System.Threading.SendOrPostCallback helloOperationCompleted;
        
        private System.Threading.SendOrPostCallback pruebaOperationCompleted;
        
        private System.Threading.SendOrPostCallback getCargoUsuarioOperationCompleted;
        
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
        public event crearOrganizacionCompletedEventHandler crearOrganizacionCompleted;
        
        /// <remarks/>
        public event crearUsuarioCompletedEventHandler crearUsuarioCompleted;
        
        /// <remarks/>
        public event helloCompletedEventHandler helloCompleted;
        
        /// <remarks/>
        public event pruebaCompletedEventHandler pruebaCompleted;
        
        /// <remarks/>
        public event getCargoUsuarioCompletedEventHandler getCargoUsuarioCompleted;
        
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
        public string crearOrganizacion([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string nombre) {
            object[] results = this.Invoke("crearOrganizacion", new object[] {
                        nombre});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void crearOrganizacionAsync(string nombre) {
            this.crearOrganizacionAsync(nombre, null);
        }
        
        /// <remarks/>
        public void crearOrganizacionAsync(string nombre, object userState) {
            if ((this.crearOrganizacionOperationCompleted == null)) {
                this.crearOrganizacionOperationCompleted = new System.Threading.SendOrPostCallback(this.OncrearOrganizacionOperationCompleted);
            }
            this.InvokeAsync("crearOrganizacion", new object[] {
                        nombre}, this.crearOrganizacionOperationCompleted, userState);
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
        public int prueba([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string email) {
            object[] results = this.Invoke("prueba", new object[] {
                        email});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void pruebaAsync(string email) {
            this.pruebaAsync(email, null);
        }
        
        /// <remarks/>
        public void pruebaAsync(string email, object userState) {
            if ((this.pruebaOperationCompleted == null)) {
                this.pruebaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnpruebaOperationCompleted);
            }
            this.InvokeAsync("prueba", new object[] {
                        email}, this.pruebaOperationCompleted, userState);
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
}

#pragma warning restore 1591