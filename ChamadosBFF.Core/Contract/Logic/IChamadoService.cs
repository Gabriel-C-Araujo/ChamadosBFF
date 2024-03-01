using ChamadosBFF.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosBFF.Core.Contract.Logic
{
    public interface IChamadoService
    {
        public BusinessObject<ChamadoEntity> Insert(ChamadoEntity entity);
        public BusinessObject<ChamadoEntity> Update(ChamadoEntity entity);
        public BusinessObject<List<ChamadoEntity>> GetAll();
        public BusinessObject<ChamadoEntity> GetById(int id);
    }
}
