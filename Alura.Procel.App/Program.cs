using Alura.Procel.App.Data;
using Alura.Procel.App.Modelo;
using System;

namespace Alura.Procel.App
{
    //valores obtidos deste site:
    //http://inmetro.gov.br/consumidor/pbe/pbetab3.asp
    class Program
    {
        static void Main()
        {
            //var geladeira1 = new SeloProcel
            //{
            //    TipoEquipamento = "Geladeira",
            //    Fabricante = "Brastemp",
            //    Modelo = "BCF07A",
            //    Tensao = "127",
            //    Eficiencia = "A",
            //    ConsumoMensal = 10.39M,
            //};

            //var geladeira2 = new SeloProcel
            //{
            //    TipoEquipamento = "Geladeira",
            //    Fabricante = "Electrolux",
            //    Modelo = "AE12F",
            //    Tensao = "220",
            //    Eficiencia = "D",
            //    ConsumoMensal = 8.5M
            //};

            var arCondicionado = new SeloProcel
            {
                TipoEquipamento = "Ar Condicionado",
                Fabricante = "Consul",
                Modelo = "UIDASJ23",
                Eficiencia = EficienciaEnergetica.E,
                ConsumoMensal = 34.5M
            };

            using (var ctx = new AppDbContext())
            {
                ctx.EficienciaEnergetica.Add(arCondicionado);
                ctx.SaveChanges();
            }
        }
    }
}
