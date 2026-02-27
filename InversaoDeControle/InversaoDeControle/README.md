Contexto
Você está criando um sistema simples que precisa notificar o usuário quando uma conta é criada.

Objetivo

Aplicar Inversão de Controle removendo a responsabilidade da classe principal de instanciar sua dependência.

Requisitos obrigatórios
1. Crie uma classe ContaService que possua o método:
	CriarConta(string nome, string email)
2. ContaService deve notificar o usuário com a mensagem:
	"Conta criada para <nome> (<email>)"
3. A notificação deve ser feita por meio de um contrato (interface):
	INotificador com método Enviar(string mensagem)
4. Implemente 2 notificadores:
	NotificadorEmail (imprime no console: EMAIL: <mensagem>)
	NotificadorSms (imprime no console: SMS: <mensagem>)
5. Regra IoC (obrigatória):
	ContaService não pode fazer new NotificadorEmail() nem new
NotificadorSms() dentro dela.
	ContaService deve receber INotificador via construtor.
6. No Program.cs, demonstre:
	Uma execução usando NotificadorEmail
	Outra execução usando NotificadorSms
Critérios de aceite
	Trocar Email por SMS deve exigir alteração somente no Program.cs
	ContaService deve depender de INotificador (não de classe concreta)
