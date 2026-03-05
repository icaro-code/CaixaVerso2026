

using MiniSerializador;

public class Program
{
    public static void Main()
    {
        var aluno = new Aluno
        {
            Nome = "Pedro",
            Ano = AnoEscolar.Setimo,
            DataNascimento = new DateTime(2010, 5, 20),
            Documento = "123456789",
            Endereco = new Endereco { Rua = "Rua A", Numero = 123 }
        };

        var serializer = new MiniSerializer();
        string resultado = serializer.Serializar(aluno);

        Console.WriteLine(resultado);
        // Saída esperada:
        // Nome=Pedro;Ano=sétimo;DataNascimento=2010-05-20;Endereco.Rua=Rua A;Endereco.Numero=123
    }
}
