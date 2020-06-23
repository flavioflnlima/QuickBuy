using System;
using QuickBuy.Dominio.ObjetoValor;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido: Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido{ get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP{ get; set; }
        public string Estado{ get; set; }
        public string Cidade{ get; set; }
        public string EnderecoCompleto{ get; set; }
        public string NumeroEndereco{ get; set; }
        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        /// <summary>
        /// Pedido deve ter pelo menos um item de pedido
        /// ou muitos itens de pedido
        /// </summary>
        public ICollection<ItemPedido> ItensPedido{ get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();
            if (ItensPedido.Any())
                AddCritica("Pedido deve conter ao menos um item");
            if (string.IsNullOrEmpty(CEP))
                AddCritica("CEP não pode estar vazio");
        }
    }
}
