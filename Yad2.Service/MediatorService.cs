using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.Core.Entities;
using Yad2.Core.Repository;

namespace Yad2.Service
{
    
    public class MediatorService
    {
        private readonly IMediatorRepository _mediatorRepository;

        public MediatorService(IMediatorRepository mediatorRepository)
        {
            _mediatorRepository = mediatorRepository;
        }
        public List<Mediator> GetAllMediators()
        {
            //business logic

            return _mediatorRepository.GetMediators();
        }
        public Mediator GetMediatorById(int id)
        {
            //business logic

            return _mediatorRepository.GetMediatorById(id);
        }

        public Mediator AddMediator(Mediator m)
        {
            //business logic

            return _mediatorRepository.AddMediator(m);
        }
        public void UpdateMediator(int id, Mediator mediator2)
        {
            //business logic
            var mediator1 = _mediatorRepository.GetMediators().Find(m => m.Id == id);
            mediator2.Id = id;
            _mediatorRepository.UpdateMediator(mediator1, mediator2);
        }
        public void DeleteMediator(int id)
        {
            //business logic
            var mediator = _mediatorRepository.GetMediators().Find(m => m.Id == id);
            _mediatorRepository.DeleteMediator(mediator);
        }

    }
}
