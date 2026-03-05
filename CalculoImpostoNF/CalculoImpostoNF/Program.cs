

using CalculoImpostoNF;
using CalculoImpostoNF.Domain;
using CalculoImpostoNF.Services;

public class Program
{
    public static void Main()
    {
        var mouse = new Produto(1, "Mouse", 79.90m, CategoriaProduto.Eletronico);
        var arroz = new Produto(2, "Arroz", 15.00m, CategoriaProduto.Alimento);
        var servico = new Produto(3, "Serviço de instalação", 80.00m, CategoriaProduto.Servico);

        var nota = new NotaFiscal();
        nota.AdicionarItem(mouse, 2);
        nota.AdicionarItem(arroz, 3);
        nota.AdicionarItem(servico, 1);

        nota.ExibirResumo();

        var impostos = new List<ImpostoBase>
        {
            new ImpostoEletronico(),
            new ImpostoAlimento(),
            new ImpostoServico()
        };

        var calculadora = new CalculadoraImpostos();
        var totalImpostos = calculadora.CalcularTotalImpostos(nota, impostos);
        var totalFinal = nota.TotalBruto() + totalImpostos;

        Console.WriteLine($"Impostos: {totalImpostos:N2}");
        Console.WriteLine($"Total final: {totalFinal:N2}");
        Console.WriteLine("==================");
    }
}
