using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace  Subscriptions.Data.Models
{
    /// <summary>
    /// ��������.
    /// </summary>
    public class TicketDto
    {
        /// <summary>
        /// �������������. ���������� ����.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// id ����������
        /// </summary>
        public int? VisorId { get; set; }

        /// <summary>
        /// �� ������ ��������
        /// </summary>
        public int LastDay { get; set; }

         /// <summary>
        // ����
        /// </summary>
        public int Price { get; set; }
  
        /// <summary>
        /// id �������
        /// </summary>
        public int? TeamId { get; set; }
       
    }
}

