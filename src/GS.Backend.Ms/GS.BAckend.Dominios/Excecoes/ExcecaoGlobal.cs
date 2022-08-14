using System;
using Newtonsoft.Json;

namespace GS.BAckend.Dominios.Excecoes
{
    public class ExcecaoGlobal
    {
        [JsonProperty("codigo")]
        public int Codigo { get; set; }

        [JsonProperty("mensagem")]
        public string Mensagem { get; set; }
    }
}

