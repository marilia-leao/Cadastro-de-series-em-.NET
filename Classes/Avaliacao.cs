using System;

namespace DIO.Series
{
	public class Avaliacao : EntidadeBase
	{
		// Atributos
		private Classificacao Classificacao { get; set; }
		private string Serie_id { get; set; }
		

		// Métodos
		public Serie(int id, int serie_id, Classificacao classificacao)
		{
			this.Id = id;
			this.Classificacao = classificacao;
			this.Serie_id = serie_id;
		}

		public override string ToString()
		{
			// Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
			string retorno = "";
			retorno += "Classificação: " + this.Classificacao + Environment.NewLine
			return retorno;
		}

		public string retornaClassificacao()
		{
			return this.Classificacao;
		}

		public int retornaId()
		{
			return this.Id;
		}
		}
	}
}