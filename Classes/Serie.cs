using System;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        // Atributos
		private Genero Genero { get; set; }
		private string Titulo { get; set; }
		private string Descricao { get; set; }
		private int Ano { get; set; }
		private Classificacao Classificacao { get; set; }
		private bool Excluido { get; set; }
   
		// Métodos
		public Serie(int id, Genero genero, string titulo, string descricao, int ano, Classificacao classificacao)
		{
			this.Id = id;
			this.Genero = genero;
			this.Titulo = titulo;
			this.Descricao = descricao;
			this.Ano = ano;
			this.Classificacao = classificacao;
			this.Excluido = Excluido;
		}

        public override string ToString()
		{
			// Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
			retorno += "Classificação: " + this.Classificacao + Environment.NewLine;
			retorno += "Excluido: " + this.Excluido + Environment.NewLine;
			return retorno;
		}

        public string retornaTitulo()
		{
			return this.Titulo;
		}
		public int retornaId()
		{
			return this.Id;
		}
		public bool retornaExcluido()
		{
			return this.Excluido;
		}
        public void Excluir() 
		{
            this.Excluido = true;
        }
    }

}