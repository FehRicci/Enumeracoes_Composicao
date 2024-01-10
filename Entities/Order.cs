﻿using Enumerecoes_Composicao.Enumeracoes_Composicao.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerecoes_Composicao.Enumeracoes_Composicao.Entities
{
    internal class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime date, OrderStatus status, Client client)
        {
            Date = date;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }
    }
}
