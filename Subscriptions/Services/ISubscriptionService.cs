using Judges.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Subscriptions.Services
{
    public interface ISubscriptionService
    {
        Task<SubscriptionDto[]> Get(int id);

        Task<int> Create(SubscriptionDto subscriptionDto);

        Task<int> Update(SubscriptionDto subscriptionDto);

        Task Delete(int id);
    }
}
