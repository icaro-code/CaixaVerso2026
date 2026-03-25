Projeto final da disciplina Técnicas de Programação I 
do curso de Educação Continuada oferido pela parceria entre a 
Caixa Economica Federal e a empresa ADA.TECH pelo programa Caixa Verso
aos seus funcionários 


###############################################################


Enunciado:


Projeto Prático Avaliativo: SmartNet Manager 🌐
1. O Cenário
A empresa de telecomunicações SmartNet Solutions está desenvolvendo o novo firmware para sua linha de roteadores Mesh corporativos. Você foi contratado como Desenvolvedor(a) Backend C# para construir o "motor" do painel de administração via terminal (Console).

O sistema precisa gerenciar a alocação de IPs, o tráfego da rede, aplicar regras de firewall dinâmicas e manter um histórico seguro de ações dos administradores, utilizando as melhores estruturas de dados e práticas do .NET.

2. O Modelo de Domínio (A Classe Base)
Para padronizar o projeto, todos devem utilizar (no mínimo) a seguinte classe para representar os aparelhos conectados à rede:

public class Dispositivo
{
    public string MacAddress { get; set; } // Ex: "AA:BB:CC:11:22"
    public string EnderecoIP { get; set; } // Ex: "192.168.0.10"
    public string Nome { get; set; }       // Ex: "PC-Contabilidade"
    public string Fabricante { get; set; } // Ex: "Dell", "Apple", "Samsung"
    public double ConsumoBanda { get; set; } // Em Mbps
    public DateTime DataConexao { get; set; }
}

3. Requisitos Técnicos (O que o sistema deve fazer)
O seu sistema em Console deve possuir um menu interativo e cumprir obrigatoriamente as missões abaixo, utilizando as estruturas de dados solicitadas:

Missão 1: Servidor DHCP (Reserva de IP)
O sistema deve permitir cadastrar endereços IP fixos para dispositivos específicos.

Exigência Técnica: Utilize um Dictionary<string, string>.
Regra: A chave deve ser o MacAddress e o valor o EnderecoIP. O sistema não pode permitir que o mesmo MAC seja cadastrado duas vezes.
Missão 2: Fila de Autenticação (QoS)
Quando um dispositivo tenta conectar, ele não entra na rede direto. Ele vai para uma fila de espera para verificação de segurança.

Exigência Técnica: Utilize uma Queue<Dispositivo>.
Regra: Crie uma opção no menu para "Adicionar dispositivo à fila" e outra para "Processar fila (Autenticar)", que deve remover (Dequeue) o dispositivo mais antigo e enviá-lo para a Lista de Ativos.
Missão 3: Conexões Ativas e Dashboard
Uma vez autenticados, os dispositivos navegam na rede.

Exigência Técnica: Utilize uma List<Dispositivo> para armazenar quem está online e o LINQ para gerar um painel estatístico.
Regra: Crie uma opção "Exibir Dashboard" que imprima:
O consumo total de banda atual. .
O Top 3 dispositivos que mais estão consumindo internet.
Quantos aparelhos de cada Fabricante estão conectados.
Um alerta de anomalia se algum dispositivo estiver consumindo mais de 500 Mbps.
Missão 4: Histórico de Auditoria (Rollback)
Os administradores de rede costumam cometer erros ao configurar o sistema.

Exigência Técnica: Utilize uma Stack<string>.
Regra: Toda vez que um dispositivo for Autenticado (Missão 2) ou uma Regra de Firewall for aplicada (Missão 6), registre uma mensagem em texto nesta pilha. Crie uma opção "Desfazer última ação", que dê um Pop() e mostre o que foi revertido na tela.
Missão 5: O Gerador de Relatórios Universal
A diretoria quer imprimir relatórios.

Exigência Técnica: Crie um método chamado ImprimirRelatorio(IEnumerable<Dispositivo> colecao).
Regra: O método deve ser capaz de receber tanto a Fila de Autenticação quanto a Lista de Dispositivos Ativos para imprimi-los na tela usando um foreach.
Missão 6: Firewall Dinâmico
O roteador precisa bloquear dispositivos baseados em regras que podem mudar a qualquer momento.

Exigência Técnica: Crie um método AplicarFirewall(Func<Dispositivo, bool> regraBloqueio).
Regra: No seu menu, crie opções de bloqueio passando expressões Lambda na chamada do método.
Ex: Bloquear aparelhos da "Apple" (d => d.Fabricante == "Apple").
Ex: Bloquear aparelhos consumindo mais de 100 Mbps (d => d.ConsumoBanda > 100).
Os dispositivos que caírem na regra devem ser removidos da List<Dispositivo>.