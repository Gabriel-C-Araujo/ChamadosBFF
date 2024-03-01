using Mvp24Hours.Core.Contract.Domain.Entity;

namespace ChamadosBFF.Core.Entities
{
    public class ChamadoEntity : IEntityBase
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Prioridade { get; set; }
        public string Sistema { get; set; }
        public string Tela { get; set; }
        public string Problema { get; set; }
        public string Status { get; set; }

        public object EntityKey => this.Id;
    }
}
