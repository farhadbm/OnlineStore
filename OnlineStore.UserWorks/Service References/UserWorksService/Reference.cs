﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineStore.UserWorks.UserWorksService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserWorksService.UserWorksServiceSoap")]
    public interface UserWorksServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/StartTime", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int StartTime(string username, string title);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/StartTime", ReplyAction="*")]
        System.Threading.Tasks.Task<int> StartTimeAsync(string username, string title);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EndTime", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void EndTime(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EndTime", ReplyAction="*")]
        System.Threading.Tasks.Task EndTimeAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetLatestByUsername", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EntityBase))]
        OnlineStore.UserWorks.UserWorksService.UserWork[] GetLatestByUsername(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetLatestByUsername", ReplyAction="*")]
        System.Threading.Tasks.Task<OnlineStore.UserWorks.UserWorksService.UserWork[]> GetLatestByUsernameAsync(string username);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class UserWork : EntityBase {
        
        private string usernameField;
        
        private string titleField;
        
        private System.Nullable<System.DateTime> startTimeField;
        
        private System.Nullable<System.DateTime> endTimeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
                this.RaisePropertyChanged("Username");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
                this.RaisePropertyChanged("Title");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public System.Nullable<System.DateTime> StartTime {
            get {
                return this.startTimeField;
            }
            set {
                this.startTimeField = value;
                this.RaisePropertyChanged("StartTime");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public System.Nullable<System.DateTime> EndTime {
            get {
                return this.endTimeField;
            }
            set {
                this.endTimeField = value;
                this.RaisePropertyChanged("EndTime");
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserWork))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3761.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public abstract partial class EntityBase : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idField;
        
        private System.DateTime lastUpdateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public System.DateTime LastUpdate {
            get {
                return this.lastUpdateField;
            }
            set {
                this.lastUpdateField = value;
                this.RaisePropertyChanged("LastUpdate");
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
    public interface UserWorksServiceSoapChannel : OnlineStore.UserWorks.UserWorksService.UserWorksServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserWorksServiceSoapClient : System.ServiceModel.ClientBase<OnlineStore.UserWorks.UserWorksService.UserWorksServiceSoap>, OnlineStore.UserWorks.UserWorksService.UserWorksServiceSoap {
        
        public UserWorksServiceSoapClient() {
        }
        
        public UserWorksServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserWorksServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserWorksServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserWorksServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int StartTime(string username, string title) {
            return base.Channel.StartTime(username, title);
        }
        
        public System.Threading.Tasks.Task<int> StartTimeAsync(string username, string title) {
            return base.Channel.StartTimeAsync(username, title);
        }
        
        public void EndTime(int id) {
            base.Channel.EndTime(id);
        }
        
        public System.Threading.Tasks.Task EndTimeAsync(int id) {
            return base.Channel.EndTimeAsync(id);
        }
        
        public OnlineStore.UserWorks.UserWorksService.UserWork[] GetLatestByUsername(string username) {
            return base.Channel.GetLatestByUsername(username);
        }
        
        public System.Threading.Tasks.Task<OnlineStore.UserWorks.UserWorksService.UserWork[]> GetLatestByUsernameAsync(string username) {
            return base.Channel.GetLatestByUsernameAsync(username);
        }
    }
}
