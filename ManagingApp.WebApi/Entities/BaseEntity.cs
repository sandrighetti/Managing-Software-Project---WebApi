using ManagingApp.WebApi.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManagingApp.WebApi.Entities
{
    // classe intermediária de Entity. Ele já implementa o Id e diz que é a chave primária
    public abstract class BaseEntity : IEntity
    {
        [Key]
        public long Id { get; set; }
    }
}
