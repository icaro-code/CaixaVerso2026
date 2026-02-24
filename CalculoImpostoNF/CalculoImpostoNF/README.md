Sistema de Cálculo de Impostos (NFsimplificada)

Objetivo
Aplicar abstração + polimorfismo em um domínio real. Esse exercício é perfeito porque na aula seguinte você consegue migrar diretamente
para:
	Interfaces
	Classes abstratas
	OCP/DIP
	DI
Contexto
Uma empresa vende produtos e precisa calcular impostos diferentes dependendo do tipo
de produto.

Requisitos obrigatórios
	1) Produto
		Propriedades:
		Id (int)
		Nome (string)
		Preco (decimal)
		Categoria (enum CategoriaProduto)
		CategoriaProduto:
		Alimento
		Eletronico
		Servico
			Validações:
				Nome obrigatório
				Preço > 0
	2) ItemNotaFiscal
		Propriedades:
		Produto
		Quantidade
		Método:
			decimal Subtotal() → Preco * Quantidade

	3) NotaFiscal
		Deve conter uma lista interna de itens (não expor mutável)
		Métodos:
		AdicionarItem(Produto produto, int quantidade)
		decimal TotalBruto()
		ExibirResumo()

	4) Abstração de imposto
		Crie uma classe abstrata:
		ImpostoBase
		Método abstrato:
		decimal Calcular(decimal valor)

	5) Impostos concretos (herança)
		Crie 3 classes que herdam ImpostoBase:
		ImpostoAlimento 5%
		ImpostoEletronico 15%
		ImpostoServico 12%

	6) CalculadoraImpostos
		Deve receber uma lista de impostos aplicáveis e calcular:
		total de impostos
		total final
	Sugestão de assinatura:
		public decimal CalcularTotalImpostos(NotaFiscal nota,
		List<ImpostoBase> impostos)
Regras obrigatórias

	Não pode existir if/else calculando imposto por categoria dentro da calculadora.
	A regra de imposto deve estar dentro da classe do imposto.
	O Program.cs deve criar os objetos e executar o fluxo.
	Saída esperada no console
	O aluno deve imprimir algo como:

=== NOTA FISCAL ===
Mouse x2 = 159,80
Arroz x3 = 45,00
Serviço de instalação x1 = 80,00
Total bruto: 284,80
Impostos: 33,xx
Total final: 318,xx
==================

Bônus (para alunos avançados)

Bônus 1 — Imposto por faixa
	Eletrônico acima de R$ 1000 tem 18% em vez de 15%
Bônus 2 — Relatório detalhado
	Mostrar quanto foi de imposto por categoria
Bônus 3 — Organização
	Separar em pastas Domain, Services