using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyTodoApp.Models
{
    public class Todo
    {
        public int Id { get; set; }
        [DisplayName("Título")]
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public string Title { get; set; }
        [DisplayName("Concluido")]
        public bool Done { get; set; }
        [DisplayName("Criado em")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [DisplayName("Utima atualização")]
        public DateTime LastUpdateDate { get; set; } = DateTime.Now;
        [DisplayName("Usuario")]
        public string User { get; set; }
    }
}