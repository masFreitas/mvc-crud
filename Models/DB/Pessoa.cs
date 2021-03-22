using System;

namespace mvc_crud.Models.DB
{
    public class Pessoa
    {
        public int Id {get; set; }
        public string Nome {get; set; }
        public DateTime Nascimento { get; set; }
        public string Email { get; set; }
    }
}