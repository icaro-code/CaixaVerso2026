Objetivo
Implementar um repositório genérico que funcione apenas para entidades que possuam Id.
Aqui o aluno começa a trabalhar com constraints (where).
Enunciado
Crie uma interface:
IEntidade
Ela deve conter:
int Id { get; set; }
Agora crie duas classes que implementem essa interface:
Cliente
Pedido
Agora implemente:
Repository<T>
Com a seguinte constraint:
where T : IEntidade
O Repository deve conter:
void Adicionar(T entidade);
T? ObterPorId(int id);
List<T> ObterTodos();
void Remover(int id);
Regras
	O repositório deve usar List<T> internamente
	ObterPorId deve localizar pelo Id
	Remover deve remover pelo Id
	Não pode usar cast
	Deve funcionar tanto para Cliente quanto para Pedido
No Program:
1. Criar Repository<Cliente>
2. Adicionar 3 clientes
3. Buscar por Id
4. Remover um cliente
Depois:
5. Criar Repository<Pedido>
6. Repetir os testes