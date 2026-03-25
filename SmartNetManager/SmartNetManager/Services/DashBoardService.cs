using SmartNetManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNetManager.Services
{
    internal class DashBoardService
    {
        public List<Dispositivo> ConexoesAtivas { get; set; } = new List<Dispositivo>();

        public void ExibirDashboard()
        {
            Console.WriteLine("\n=== Dashboard ===");
            Console.WriteLine($"Consumo total: {ConexoesAtivas.Sum(d => d.ConsumoBanda)} Mbps");

            var top3 = ConexoesAtivas.OrderByDescending(d => d.ConsumoBanda).Take(3);
            Console.WriteLine("Top 3 consumidores:");
            foreach (var d in top3)
                Console.WriteLine($"{d.Nome} - {d.ConsumoBanda} Mbps");

            var fabricantes = ConexoesAtivas.GroupBy(d => d.Fabricante);
            foreach (var grupo in fabricantes)
                Console.WriteLine($"{grupo.Key}: {grupo.Count()} dispositivos");

            var anomalia = ConexoesAtivas.FirstOrDefault(d => d.ConsumoBanda > 500);
            if (anomalia != null)
                Console.WriteLine($"ALERTA: {anomalia.Nome} consumindo {anomalia.ConsumoBanda} Mbps!");
        }
    }
}
