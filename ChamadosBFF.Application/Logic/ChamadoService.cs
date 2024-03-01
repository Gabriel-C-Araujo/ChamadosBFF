using ChamadosBFF.Core;
using ChamadosBFF.Core.Contract.Logic;
using ChamadosBFF.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChamadosBFF.Application.Logic
{
    public class ChamadoService : IChamadoService
    {
        public BusinessObject<List<ChamadoEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public BusinessObject<ChamadoEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public BusinessObject<ChamadoEntity> Insert(ChamadoEntity entity)
        {
            throw new NotImplementedException();
        }

        public BusinessObject<ChamadoEntity> Update(ChamadoEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
