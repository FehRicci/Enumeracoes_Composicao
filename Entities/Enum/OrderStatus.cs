using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerecoes_Composicao.Enumeracoes_Composicao.Entities.Enum
{
    enum OrderStatus : int
    {
        PendingPayment = 0, 
        Processing = 1, 
        Shipped = 2, 
        Delivered = 3
    }
}
