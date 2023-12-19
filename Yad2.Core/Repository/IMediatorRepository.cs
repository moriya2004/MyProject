using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.Core.Entities;

namespace Yad2.Core.Repository
{
    public interface IMediatorRepository
    {
        List<Mediator> GetMediators();
        Mediator AddMediator(Mediator c);
        Mediator GetMediatorById(int id);
        void UpdateMediator(Mediator mediator1, Mediator mediator2);
        void DeleteMediator(Mediator c);
    }
}
