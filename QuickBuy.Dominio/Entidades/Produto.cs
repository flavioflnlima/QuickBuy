namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Preco{ get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                AddCritica("Nome do produto não foi informado");

            if (string.IsNullOrEmpty(Descricao))
                AddCritica("Descrição não foi informado");
        }
    }
}
