using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeVenda.Entities.Ennuns
{
    enum OrderStatus : int
    {
        PenDing_Payment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
