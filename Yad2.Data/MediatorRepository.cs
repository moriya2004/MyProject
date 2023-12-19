using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.Core.Entities;
using Yad2.Core.Repository;

namespace Yad2.Data
{
    
    public class MediatorRepository : IMediatorRepository
    {
        private readonly DataContext _context;

        public MediatorRepository(DataContext context)
        {
            _context = context;
        }
        public List<Mediator> GetMediators()
        {
            return _context.MediatorsList;
        }
        public Mediator GetMediatorById(int id)
        {
            return _context.MediatorsList.Find(m => m.Id == id);
        }

        public Mediator AddMediator(Mediator mediator)
        {
            mediator.Id = _context.MediatorsList.Count() + 1;
            _context.MediatorsList.Add(new Mediator { Id = mediator.Id, Name = mediator.Name, Seniority = mediator.Seniority, Commission = mediator.Commission, NumDeals = mediator.NumDeals });
            return mediator;
        }
        public void UpdateMediator(Mediator mediator1, Mediator mediator2)
        {
            _context.MediatorsList.Remove(mediator1);
            _context.MediatorsList.Add(mediator2);
        }
        public void DeleteMediator(Mediator mediator)
        {
            _context.MediatorsList.Remove(mediator);
        }
    }
}
