using System.ComponentModel.DataAnnotations;

namespace EtecBookAPI.DataTransferObjects;

    public class RegisterDto
    {
        [Required(ErrorMessage ="Informe o Nome do Usuario")]
        [StringLength(60, ErrorMessage ="O nome deve possuir no maximo 60 caracteres")]

        public string Name { get; set; }
        [Required(ErrorMessage ="Informe o Email do Usuario")]
        [StringLength(100, ErrorMessage ="O Email deve possuir no maximo 100 caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Informe a Senha de Acesso")]
        [StringLength(20, MinimumLength = 6, ErrorMessage ="A senha deve possuir no maximo 6 caracteres e no maximo 20 caracteres")]
        public string Password { get; set; }

    }
