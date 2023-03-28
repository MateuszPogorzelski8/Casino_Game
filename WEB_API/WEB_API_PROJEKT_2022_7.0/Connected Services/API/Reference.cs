﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//
//     Zmiany w tym pliku mogą spowodować niewłaściwe zachowanie i zostaną utracone
//     w przypadku ponownego wygenerowania kodu.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Player", Namespace="http://schemas.datacontract.org/2004/07/WCF")]
    public partial class Player : object
    {
        
        private decimal CashField;
        
        private string NameField;
        
        private string TokenField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Cash
        {
            get
            {
                return this.CashField;
            }
            set
            {
                this.CashField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Token
        {
            get
            {
                return this.TokenField;
            }
            set
            {
                this.TokenField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="API.IService1")]
    public interface IService1
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Register", ReplyAction="http://tempuri.org/IService1/RegisterResponse")]
        System.Threading.Tasks.Task<bool> RegisterAsync(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        System.Threading.Tasks.Task<string> LoginAsync(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPlayers", ReplyAction="http://tempuri.org/IService1/GetPlayersResponse")]
        System.Threading.Tasks.Task<API.Player[]> GetPlayersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPlayer", ReplyAction="http://tempuri.org/IService1/GetPlayerResponse")]
        System.Threading.Tasks.Task<API.Player> GetPlayerAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Deposit_Money", ReplyAction="http://tempuri.org/IService1/Deposit_MoneyResponse")]
        System.Threading.Tasks.Task Deposit_MoneyAsync(string token, decimal money);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Update_Money", ReplyAction="http://tempuri.org/IService1/Update_MoneyResponse")]
        System.Threading.Tasks.Task Update_MoneyAsync(string token, decimal money);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Change_Password", ReplyAction="http://tempuri.org/IService1/Change_PasswordResponse")]
        System.Threading.Tasks.Task<string> Change_PasswordAsync(string login, string password, string new_password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Ban_Player", ReplyAction="http://tempuri.org/IService1/Ban_PlayerResponse")]
        System.Threading.Tasks.Task Ban_PlayerAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Delete_Player", ReplyAction="http://tempuri.org/IService1/Delete_PlayerResponse")]
        System.Threading.Tasks.Task Delete_PlayerAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPlayersBy", ReplyAction="http://tempuri.org/IService1/GetPlayersByResponse")]
        System.Threading.Tasks.Task<API.Player[]> GetPlayersByAsync(string login);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IService1Channel : API.IService1, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<API.IService1>, API.IService1
    {
        
        /// <summary>
        /// Wdróż tę metodę częściową, aby skonfigurować punkt końcowy usługi.
        /// </summary>
        /// <param name="serviceEndpoint">Punkt końcowy do skonfigurowania</param>
        /// <param name="clientCredentials">Poświadczenia klienta</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public Service1Client() : 
                base(Service1Client.GetDefaultBinding(), Service1Client.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IService1.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), Service1Client.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<bool> RegisterAsync(string login, string password)
        {
            return base.Channel.RegisterAsync(login, password);
        }
        
        public System.Threading.Tasks.Task<string> LoginAsync(string login, string password)
        {
            return base.Channel.LoginAsync(login, password);
        }
        
        public System.Threading.Tasks.Task<API.Player[]> GetPlayersAsync()
        {
            return base.Channel.GetPlayersAsync();
        }
        
        public System.Threading.Tasks.Task<API.Player> GetPlayerAsync(string login)
        {
            return base.Channel.GetPlayerAsync(login);
        }
        
        public System.Threading.Tasks.Task Deposit_MoneyAsync(string token, decimal money)
        {
            return base.Channel.Deposit_MoneyAsync(token, money);
        }
        
        public System.Threading.Tasks.Task Update_MoneyAsync(string token, decimal money)
        {
            return base.Channel.Update_MoneyAsync(token, money);
        }
        
        public System.Threading.Tasks.Task<string> Change_PasswordAsync(string login, string password, string new_password)
        {
            return base.Channel.Change_PasswordAsync(login, password, new_password);
        }
        
        public System.Threading.Tasks.Task Ban_PlayerAsync(string login)
        {
            return base.Channel.Ban_PlayerAsync(login);
        }
        
        public System.Threading.Tasks.Task Delete_PlayerAsync(string login)
        {
            return base.Channel.Delete_PlayerAsync(login);
        }
        
        public System.Threading.Tasks.Task<API.Player[]> GetPlayersByAsync(string login)
        {
            return base.Channel.GetPlayersByAsync(login);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService1))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Nie można znaleźć punktu końcowego o nazwie „{0}”.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService1))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8733/Design_Time_Addresses/WCF/Service1/");
            }
            throw new System.InvalidOperationException(string.Format("Nie można znaleźć punktu końcowego o nazwie „{0}”.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return Service1Client.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IService1);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return Service1Client.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IService1);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IService1,
        }
    }
}
