using Tickets.Data;
using Tickets.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;

namespace  Subscriptions.Services
{
    public class SubscriptionService : ISubscriptionService
    {
        private readonly SubscriptionsDbContext _subscriptionssDbContext;

        public TicketService(SubscriptionsDbContext _subscriptionssDbContext)
        {
            _subscriptionsDbContext = subscriptionsDbContext ?? throw new ArgumentNullException(nameof(subscriptionsDbContext));
        }

        public async Task<SubscriptionDto[]> Get(int id)
        {
            var subscriptions = await _subscriptionsDbContext.Subscription
                .Where(x => x.TeamId.HasValue)
                .ToArrayAsync();

            var SubscriptionsDtos = new List<SubscriptionDto>();
            foreach(var s in subscriptions)
            {
                SubscriptionsDtos.Add(new SubscriptionDto
                {
                    TeamName = s.Team.Name
                });
            }

            return await _subscriptionsDbContext.Subscription
                .Where(x => x.Team.Name == "ёвентус")
                .Select(x => new SubscriptionDto
                {
                    Id = x.Id,
                    VisorId = x.VisorId,
                    TeamId = x.TeamId,
                    LastDay = x.LastDay,
                    Price = x.Price,
                    
                })
                .ToArrayAsync();
        }

        public async Task<int> Create(SubscriptionDto subscriptionDto)
        {
            Subscription subscription = new Subscription();

            AplyDtoToEntity(subscription, subscriptionDto);

            _subscriptionDbContext.Subscriptions.Add(subscription);
            await _subscriptionsDbContext.SaveChangesAsync();

            return subscription.Id;
        }

        public async Task<int> Update(SubscriptionDto subscriptionDto)
        {
            Subscription subscription = _subscriptionsDbContext.Subscriptions.Find(subscriptionDto.Id);

            AplyDtoToEntity(subscription, subscriptionDto);

            await _subscriptionsDbContext.SaveChangesAsync();

            return subscription.Id;
        }

        public async Task Delete(int id)
        {
            Subscription subscription = _subscriptionsDbContext.Subscriptions.Find(id);

            _subscriptionsDbContext.Subscriptions.Remove(subscription);
            await _subscriptionsDbContext.SaveChangesAsync();
        }

        private void AplyDtoToEntity(Subscription subscription, SubscriptionDto subscriptionDto)
        {
            subscription.LastDay = subscriptionDto.LastDay;
            subscription.Price = subscriptionDto.Price;
            subscription.TeamId = subscriptionDto.TeamId;
            subscription.VisorId = subscriptionDto.VisorId;

        }
    }
}