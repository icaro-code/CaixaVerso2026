Exercício 2 — Loja: Carrinho e Entrega

Enunciado
Você vai criar um sistema de Console App para uma loja simples.
Requisitos obrigatórios
	
	1. Produto
		Propriedades: Id, Nome, Preco
		Regras: Nome obrigatório, Preco > 0
	
	2. ItemCarrinho
		Propriedades: Produto, Quantidade
		Regras: Quantidade >= 1
		Método: Subtotal() retorna Preco * Quantidade
	
	3. Carrinho
		Deve manter internamente uma coleção de itens (não expor lista mutável)
		Métodos:
			Adicionar(Produto produto) (adiciona 1)
			Adicionar(Produto produto, int quantidade) (sobrecarga)
			Remover(int produtoId)
			Total() soma os subtotais
			ExibirResumo() imprime itens e total
			Regra: se adicionar um produto que já existe, deve somar a quantidade

	4. Entrega (Herança + Polimorfismo)
	Crie uma classe base EntregaBase com:
		Endereco
		Método CalcularFrete(decimal totalDoCarrinho) (virtual)
	Crie duas entregas filhas:
		EntregaNormal: frete = 10% do total (mínimo R$ 15)
		EntregaExpressa: frete = 20% do total (mínimo R$ 30)
	
	5. Checkout
		Recebe um Carrinho e uma EntregaBase
		Método Finalizar() imprime:
		Total carrinho
		Frete calculado
		Total geral

Regras de qualidade (obrigatórias)
	Não pode ter public set em tudo (use private set quando fizer sentido)
	Validações devem estar dentro das classes (não só no Program)
	Não pode usar if/else no Program para decidir frete: use polimorfismo

Bônus (se der tempo)
	Criar Cupom com percentual de desconto e aplicar no Checkout
	Criar Adicionar(params Produto[] produtos) no Carrinho (sobrecarga com params)