Tema: “Checkout de E-commerce sem switch gigante”

Enunciado
Você recebeu o seguinte código em um Console App:
Código inicial

using System;

public enum TipoPagamento
{
	Debito,
	Credito,
	Pix
}
public class CarrinhoDeCompras
{
	public decimal ValorTotal { get; private set; }
	public void AdicionarProduto(string descricao, decimal valorUnitario, int quantidade)
	{
		ValorTotal += valorUnitario * quantidade;
	}
	public void FinalizarCompra(TipoPagamento tipoPagamento)
	{
	// Pagamento
		if (tipoPagamento == TipoPagamento.Debito)
			Console.WriteLine($"Pagamento no DÉBITO: R$ {ValorTotal:0.00}");
		else if (tipoPagamento == TipoPagamento.Credito)
			Console.WriteLine($"Pagamento no CRÉDITO: R$ {ValorTotal:0.00}");
		else if (tipoPagamento == TipoPagamento.Pix)
			Console.WriteLine($"Pagamento no PIX: R$ {ValorTotal:0.00}");
		else
			Console.WriteLine("Forma inválida!");
	// Comprovante
		Console.WriteLine($"Comprovante: compra no valor de R$ {ValorTotal:0.00}");
	}
}

Sua tarefa

Parte A — Aplicar SRP
Separe as responsabilidades do carrinho:

1. Carrinho deve cuidar apenas do total da compra e itens (se quiser)
2. Crie uma classe responsável por pagamento
3. Crie uma classe responsável por comprovante
O carrinho não deve imprimir nem decidir pagamento.
Parte B — Aplicar OCP
Remova if/else de forma de pagamento.
Crie uma abstração (interface ou classe abstrata) para pagamentos, por exemplo:
	IPagamento com Pagar(decimal valor) e Nome
Implemente pelo menos:
	PagamentoDebito
	PagamentoCredito
	PagamentoPix
Requisito OCP: adicionar uma nova forma de pagamento (ex: “Boleto”) deve ser
possível sem alterar classes já prontas (só criando nova classe).
Regras obrigatórias
	Não pode ter if/else ou switch dentro de pagamento para escolher forma
	Program.cs deve escolher qual pagamento usar (injeção manual)
	Deve rodar em Console App
Cenário de execução (obrigatório)
No Program.cs:
	Adicionar:
o Mouse: 79,90 (2)
o Teclado: 159,90 (1)
	Total esperado: 319,70
	Executar com Pix e imprimir comprovante
Critérios de aceite
	O carrinho não sabe como paga nem como imprime
	Trocar Pix por Crédito exige mudar apenas o Program.cs
	Adicionar “Boleto” exige criar uma nova classe e não mexer em código pronto
Dica didática (pra você conduzir em sala)
Pergunte:
“Se amanhã surgir ApplePay, qual classe deve mudar?”