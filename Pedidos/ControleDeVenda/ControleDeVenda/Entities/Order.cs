using System;
using System.Collections.Generic;
using System.Text;
using ControleDeVenda.Entities.Ennuns;
using System.Globalization;

namespace ControleDeVenda.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus  Status { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Client Client { get; set; }

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        public void AddItems(OrderItem oi)
        {
            Items.Add(oi);
        }

        public void RemoveItems(OrderItem oi)
        {
            Items.Remove(oi);
        }

        public double Total()
        {
            double sum = 0;
            foreach(OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine( "ORDER SUMMARY:");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.Append(Status);
            sb.Append("Client: ");// Alex Green(15 / 03 / 1985) -alex@gmail.com
            sb.Append(Client);
            sb.AppendLine("Order items:");
            foreach (OrderItem i in Items)
            {
                sb.AppendLine(i.ToString());
            }
            sb.Append("Total price: $");
            sb.AppendLine(this.Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
