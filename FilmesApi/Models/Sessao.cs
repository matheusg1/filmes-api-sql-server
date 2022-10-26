using FilmesAPI.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FilmesApi.Models
{
    public class Sessao
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [JsonIgnore]
        public virtual Filme Filme { get; set; }
        public int FilmeId { get; set; }
        public virtual Cinema Cinema { get; set; }
        public int CinemaId { get; set; }
        [JsonIgnore]
        public virtual DateTime HorarioDeEncerramento { get; set; }
    }
}