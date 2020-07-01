﻿namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            if (ProdutoId == 0)
                AddCritica("Não foi possível identificar a referência do produto");
            if (Quantidade == 0)
                AddCritica("Informe a quantidade");
        }
    }
}
