using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagingApp.WebApi.Entities.Interfaces
{
    // Criado essa interface para definir o que é Entidade (e com isso o que poderá se tornar um repositorio no meu banco de dados)
    public interface IEntity
    {
        long Id { get; set; } 
    }
}
