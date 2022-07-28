using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tech_test_payment_api.NewFolder;

namespace tech_test_payment_api
{
  public class VendaUseCase
  {
    public List<Venda> vendas = new List<Venda>();
    public Venda GetVenda(int idPedido)
    {
      var listVenda = new List<Venda>()
      {
        new Venda()
        {
          Id_Pedido = 1,
          Data = DateTime.Now,
          vendedor = new Vendedor()
          {
           Id = 1,
           Cpf = "123456789",
           Nome = "Vendedor 1",
           Email = "vendedor1@email.com",
           Telefone = "3133998855"
          },
          itensp = new List<ItensPedido>()
          {
            new ItensPedido()
            {
              Id_item = 1,
               Nome_item = "CD"
            }
          }
        },
        new Venda()
        {
          Id_Pedido = 2,
          Data = DateTime.Now,
          vendedor = new Vendedor()
          {
           Id = 1,
           Cpf = "123456789",
           Nome = "Vendedor 1",
           Email = "vendedor1@email.com",
           Telefone = "3133998855"
          },
          itensp = new List<ItensPedido>()
          {
            new ItensPedido()
            {
              Id_item = 1,
               Nome_item = "CD"
            }
          }
        }
      };
      var saida = new Venda();

      foreach (var item in vendas)
      {
        if (item.Id_Pedido == idPedido)
          saida = item;
      }
      return saida;
    }
    public Venda InserirVenda(Venda venda)
    {
      int idpedido = 0;
      var idPedido = idpedido + 1;

      venda.Id_Pedido = idPedido;
      var listVendas = new List<Venda>();

      vendas.Add(venda);
      return vendas.Where(c => c.Id_Pedido == idPedido).FirstOrDefault();
    }
  }
}
