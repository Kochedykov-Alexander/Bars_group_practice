using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Subscriptions.Data
{
    public class SubscriptionsContext : DbContext
    {
        public SubscriptionsContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }
    }
}