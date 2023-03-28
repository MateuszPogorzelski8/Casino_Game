using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę interfejsu „IService1” w kodzie i pliku konfiguracji.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        bool Register(string login, string password);

        [OperationContract]
        string Login(string login, string password);

        [OperationContract]
        Player[] GetPlayers();

        [OperationContract]
        Player GetPlayer(string login);

        [OperationContract]
        void Deposit_Money(string token, decimal money);

        [OperationContract]
        void Update_Money(string token, decimal money);

        [OperationContract]
        string Change_Password(string login, string password, string new_password);

        [OperationContract]
        void Ban_Player(string login);

        [OperationContract]
        void Delete_Player(string login);

        [OperationContract]
        Player[] GetPlayersBy(string login);
    }

    // Użyj kontraktu danych, jak pokazano w poniższym przykładzie, aby dodać typy złożone do operacji usługi.
    // Możesz dodać pliki XSD do projektu. Po skompilowaniu projektu możesz bezpośrednio użyć zdefiniowanych w nim typów danych w przestrzeni nazw „WCF.ContractType”.
    [DataContract]
    public class Player
    {

        [DataMember]
        public string Name { get; set; }

        
        public string Password { get; set; }

        [DataMember]
        public string Token { get; set; }   

        [DataMember]
        public decimal Cash { get; set; }

        
    }
}
