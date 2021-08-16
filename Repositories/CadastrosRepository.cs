using System.Collections.Generic;
using System.Linq;
using Cadastros.Models;

namespace Cadastros.Repositories {
    public static class CadastrosRepository {
        public static Cadastro Get() {
            var Cadastros = new List<Cadastro>();
            Cadastros.Add(
                new Cadastro {
                    Id = 1, 
                    Nome = "Tony Stark", 
                    CPF = "000.000.000-00", 
                    UF = "GO",
                    DataNascimento = "01/01/1981" 
                }
            );
            
            return Cadastros.FirstOrDefault();
        }
    }
}