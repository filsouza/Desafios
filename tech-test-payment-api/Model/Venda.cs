using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tech_test_payment_api.NewFolder
{
  public class Venda
  {
    public int Id_Pedido { get; set; }
    public Vendedor vendedor { get; set; }
    public DateTime Data { get; set; }
    public List<ItensPedido> itensp { get; set; }

  }

}
