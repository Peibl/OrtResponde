using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrtResponde.Models
{
    public class Answer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo no puede estar vacio.")]
        public string Respuesta { get; set; }

        public ICollection<Like> Likes { get; set; }

        [DisplayName("Id Usuario")]
        public string UserId { get; set; }

        public int QuestionId { get; set; }
        
        [DisplayName("Pregunta")]
        public Question Question { get; set; }
    }
}
