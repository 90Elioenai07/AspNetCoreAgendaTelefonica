using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaTelefonica.Models
{
    public class Pessoa
    {
        public int PessoaId { get; set; }

        [Required(ErrorMessage = "{0} é obrigatorio")]
        [StringLength(40, ErrorMessage = "Use menos caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [StringLength(40, ErrorMessage = "Use menos caracteres")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [Range(18, int.MaxValue, ErrorMessage = "Idade Invalida")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [StringLength(40, ErrorMessage = "Use menos caracteres")]
        [EmailAddress(ErrorMessage = "Email Invalido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "é obigatório")]
        public string Teleone { get; set; }

        [Required(ErrorMessage = "é obrigatório")]
        public TipoTelefone TipoTelefone { get; set; }

        public string Foto { get; set; }
    }

    public enum TipoTelefone
    {
        Pessoal, Comercial
    }
}
