using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorBombaCombustivel
{
    public class BombaDeCombustivel
    {
        private string tipoCombustivel;
        private double valorLitro;
        private double quantidadeCombustivel;

        public BombaDeCombustivel(string tipoCombustivel, double valorLitro, double quantidadeCombustivel)
        {
            this.tipoCombustivel = tipoCombustivel;
            this.valorLitro = valorLitro;
            this.quantidadeCombustivel = quantidadeCombustivel;
        }

        public string TipoCombustivel
        {
            get
            {
                return tipoCombustivel;
            }

        }
        public double ValorLitro
        {
            get
            {
                return valorLitro;
            }

        }
        public double QuantidadeCombustivel
        {
            get
            {
                return quantidadeCombustivel;
            }

        }

        public double AbastecerPorValor(double valorAbast)
        {
            double quantLitros = valorAbast / ValorLitro;

            if (valorAbast <= QuantidadeCombustivel)
            { 
                quantidadeCombustivel -= quantLitros;               
            }
            return quantLitros;
        }
        public double AbastecerPorLitro(double quantLitros)
        {
            double valorASerPago = quantLitros * ValorLitro;

            if (quantLitros <= QuantidadeCombustivel)
            {
                quantidadeCombustivel -= quantLitros;                
            }
            return valorASerPago;

        }
        public void AlterarValor(double nvValor)
        {
            valorLitro = nvValor;
        }
        public void AlterarCombustivel(string nvTipo)
        {
            tipoCombustivel = nvTipo;
        }
        public void AlterarQuantidadeDeCombustivel(double nvQuant)
        {
            quantidadeCombustivel = nvQuant;
        }
        public void MostarInformacoesBomba()
        {
            Console.WriteLine($"\n\t\t---Informações Bomba---\n" +
                $"======================================================\n" +
                $"Tipo de Combustivel\t\t\t{TipoCombustivel}\n" +
                $"Valor por Litro\t\t\t\t{ValorLitro:c2}\n" +
                $"Quantidade de Combustivel restante\t{QuantidadeCombustivel} litros\n" +
                $"======================================================\n");
        }
    }
}
