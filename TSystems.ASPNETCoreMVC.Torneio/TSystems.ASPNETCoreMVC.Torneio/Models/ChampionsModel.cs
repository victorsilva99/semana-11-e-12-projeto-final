﻿using System.ComponentModel.DataAnnotations;


namespace TSystems.ASPNETCoreMVC.Torneio.Models
{
    public class ChampionsModel
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Habilidades { get; set; }
        public int TotalDeLutas { get; set; }
        public int Vitorias { get; set; }
        public int Derrotas { get; set; }
    }
}
