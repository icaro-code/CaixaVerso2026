using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversaoDeControle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Execução usando NotificadorEmail
            INotificador notificadorEmail = new NotificadorEmail();
            ContaService contaEmail = new ContaService(notificadorEmail);
            contaEmail.CriarConta("Maria", "maria@email.com");

            // Execução usando NotificadorSms
            INotificador notificadorSms = new NotificadorSms();
            ContaService contaSms = new ContaService(notificadorSms);
            contaSms.CriarConta("João", "joao@sms.com");
        }
    }
}

//using System;

//namespace IoCExemplo
//{
//    // 1. Contrato de notificação
//    public interface INotificador
//    {
//        void Enviar(string mensagem);
//    }
//    // 2. Implementação de notificador por Email
//    public class NotificadorEmail : INotificador
//    {
//        public void Enviar(string mensagem)
//        {
//            Console.WriteLine($"EMAIL: {mensagem}");
//        }
//    }
//    // 3. Implementação de notificador por SMS
//    public class NotificadorSms : INotificador
//    {
//        public void Enviar(string mensagem)
//        {
//            Console.WriteLine($"SMS: {mensagem}");
//        }
//    }
//    // 4. Serviço de conta que depende de INotificador
//    public class ContaService
//    {
//        private readonly INotificador _notificador;

//        //IoC: recebe a dependencia via construtor
//        public ContaService(INotificador notificador)
//        {
//            _notificador = notificador;
//        }
//        public void CriarConta(string nome, string email)
//        {
//            string mensagem = $"Conta criada para {nome} ({email})";
//        }
//    }
//    // 5. Program.cs demonstrando uso
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Execução usando NotificadorEmail
//            INotificador notificadorEmail = new NotificadorEmail();
//            ContaService contaEmail = new ContaService(notificadorEmail);
//            contaEmail.CriarConta("Maria", "maria@email.com");

//            // Execução usando NotificadorSms
//            INotificador notificadorSms = new NotificadorSms();
//            ContaService contaSms = new ContaService(notificadorSms);
//            contaSms.CriarConta("João", "joao@sms.com");
//        }
//    }
//}
