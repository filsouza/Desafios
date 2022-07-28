namespace tech_test_payment_api.NewFolder
{
  public class ItensPedido
  {
    public int Id_item { get; set; }
    public string Nome_item { get; set; }

    public void adicionar(int iD_item, string nome_item)
    {
      this.Id_item = iD_item;
      this.Nome_item = nome_item;
    }
    
  }
}