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

        public virtual ICollection<Like> Likes { get; set; }

        [DisplayName("Id Usuario")]
        public string UserId { get; set; }

        [DisplayName("Respuestas")]
        public virtual ICollection<Answer> Answers { get; set; }

        [DisplayName("Fecha")]
        public DateTime CreationDate { get; set; }


        public Boolean hasUserLike(String userId) {
            var xx = this.Likes.SingleOrDefault(t => t.UserId == userId && t.LikeType);
            return xx != null;
        }
        public int getLikeId(String userId)
        {
            var xx = this.Likes.SingleOrDefault(t => t.UserId == userId && t.LikeType);
            if (xx != null) { 
            return xx.Id;
            }else {
                return -1;
            }
        }
    }
}
