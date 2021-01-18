using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace  Subscriptions.Data.Models
{
    /// <summary>
    /// Подписка.
    /// </summary>
    public class TicketDto
    {
        /// <summary>
        /// Идентификатор. Уникальный ключ.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// id подписчика
        /// </summary>
        public int? VisorId { get; set; }

        /// <summary>
        /// До какого подписка
        /// </summary>
        public int LastDay { get; set; }

         /// <summary>
        // цена
        /// </summary>
        public int Price { get; set; }
  
        /// <summary>
        /// id команды
        /// </summary>
        public int? TeamId { get; set; }
       
    }
}

