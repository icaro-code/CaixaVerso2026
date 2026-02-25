using System;
using System.Collections.Generic;
using System.Linq;

// Classe genérica
public class Gerenciador<T>
{
    private List<T> itens = new List<T>();

    public void Adicionar(T item)
    {
        itens.Add(item);
    }

    public List<T> ObterTodos()
    {
        return itens;
    }

    public List<T> Filtrar(Func<T, bool> criterio)
    {
        return itens.Where(criterio).ToList();
    }
}
