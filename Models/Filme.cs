using System;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class Filme
    {   
        public int Id {get;set;}
        
        [Required(ErrorMessage = "Titulo é obrigatório")]
        public string Titulo {get;set;}
        [Required(ErrorMessage = "Diretor é obrigatório")]
        public string Diretor {get;set;}
        public string Genero {get;set;}
        [Range(1, 250, ErrorMessage = "Duração entre 1 e 250 minutos")]
        public int Duracao {get;set;}
    }
}