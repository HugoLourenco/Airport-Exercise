using System;
using System.Collections.Generic;

namespace Trab5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Itinerario> voos = new();
            int opcao;
            do
            {
                Console.WriteLine("1 - Inserir voo");
                Console.WriteLine("2 - Listar todos os voos organizados por data");
                Console.WriteLine("3 - Listar voos para destino");
                Console.WriteLine("4 - Listar voos de origem");
                Console.WriteLine("5 - Pesquisar voo");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Selecione opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Itinerario voo = new();
                        Console.WriteLine("Indique identificação do voo");
                        voo.IdVoo = Console.ReadLine();
                        Console.WriteLine("Indique origem do voo");
                        voo.Origem = Console.ReadLine();
                        Console.WriteLine("Indique destino do voo");
                        voo.Destino = Console.ReadLine();
                        Console.WriteLine("Indique data e hora de partida do voo (AAAA/MM/DD HH:MM)");
                        voo.Partida = DateTime.Parse(Console.ReadLine()); 
                        Console.WriteLine("Indique data e hora de chegada do voo (AAAA/MM/DD HH:MM)");
                        voo.Chegada = DateTime.Parse(Console.ReadLine());
                        bool flag = true;
                        foreach(Itinerario v in voos)
                        {
                            if(v.Equals(voo))
                            {
                                Console.WriteLine("O voo já existe na lista");
                                flag = false;
                                break;
                            }
                        }
                        if (flag)
                        {
                            voos.Add(voo);
                        }
                        break;
                    case 2:
                        voos.Sort();
                        Console.WriteLine($"{"ID Voo", -8} {"Origem", -20} {"Partida", -20} {"Destino", -20} {"Chegada", -20}");
                        foreach(Itinerario v in voos)
                        {
                            Console.WriteLine($"{v.IdVoo,-8} {v.Origem,-20} {v.Partida,-20} {v.Destino,-20} {v.Chegada,-20}");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Indique destino");
                        String destino = Console.ReadLine();
                        Console.WriteLine($"{"ID Voo",-8} {"Origem",-20} {"Partida",-20} {"Destino",-20} {"Chegada",-20}");
                        foreach (Itinerario v in voos)
                        {
                            if (v.Destino == destino)
                            {
                                Console.WriteLine($"{v.IdVoo,-8} {v.Origem,-20} {v.Partida,-20} {v.Destino,-20} {v.Chegada,-20}");
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Indique origem");
                        String origem = Console.ReadLine();
                        Console.WriteLine($"{"ID Voo",-8} {"Origem",-20} {"Partida",-20} {"Destino",-20} {"Chegada",-20}");
                        foreach (Itinerario v in voos)
                        {
                            if (v.Origem == origem)
                            {
                                Console.WriteLine($"{v.IdVoo,-8} {v.Origem,-20} {v.Partida,-20} {v.Destino,-20} {v.Chegada,-20}");
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("Indique identificação do voo");
                        String idvoo = Console.ReadLine();
                        foreach (Itinerario v in voos)
                        {
                            if (v.IdVoo == idvoo)
                            {
                                Console.WriteLine($"ID: {v.IdVoo} {v.Origem,-20} {v.Partida,-20} {v.Destino,-20} {v.Chegada,-20}");
                                Console.WriteLine($"Origem: {v.Origem}");
                                Console.WriteLine($"Partida: {v.Partida}");
                                Console.WriteLine($"Destino: {v.Destino}");
                                Console.WriteLine($"Chegada: {v.Chegada}");
                                break;
                            }
                        }
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcao != 0);
        }
    }
}
