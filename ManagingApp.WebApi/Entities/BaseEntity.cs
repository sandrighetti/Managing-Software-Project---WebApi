using System.ComponentModel.DataAnnotations;
using ManagingApp.WebApi.Entities.Interfaces;

namespace ManagingApp.WebApi.Entities
{
    public abstract class BaseEntity : IEntity
    {
        [Key]
        public long Id { get; set; }
    }
}
