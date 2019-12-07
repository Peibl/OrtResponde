using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrtResponde.Models
{
    public class Question
    {
        public int Id { get; set; }

        [DisplayName("Pregunta")]
        [Required(ErrorMessage = "El campo no puede estar vacio.")]
        public string Descripcion { get; set; }

        public ICollection<Like> Likes { get; set; }

        [DisplayName("Id Usuario")]
        public string UserId { get; set; }

        [DisplayName("Respuestas")]
        public virtual ICollection<Answer> Answers { get; set; }
    }
}
