using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alura.Procel.App.Modelo
{
    enum EficienciaEnergetica
    {
        A, B, C, D, E, F,  G
    }

    static class EficienciaEnergeticaExtensions
    {
        private static Dictionary<string, EficienciaEnergetica> mapa =
            new Dictionary<string, EficienciaEnergetica>
            {
                { "A", EficienciaEnergetica.A },
                { "B", EficienciaEnergetica.B },
                { "C", EficienciaEnergetica.C },
                { "D", EficienciaEnergetica.D },
                { "E", EficienciaEnergetica.E },
                { "F", EficienciaEnergetica.F },
                { "G", EficienciaEnergetica.G },
            };

        public static string ParaString(this EficienciaEnergetica ee)
        {
            return mapa.First(e => e.Value == ee).Key;
        }

        public static EficienciaEnergetica ParaEnum(this string str)
        {
            return mapa[str];
        }
    }

    class SeloProcel
    {
        public int Id { get; set; }
        public string TipoEquipamento { get; set; }
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public decimal ConsumoMensal { get; set; }
        public EficienciaEnergetica Eficiencia { get; set; }
    }
}
