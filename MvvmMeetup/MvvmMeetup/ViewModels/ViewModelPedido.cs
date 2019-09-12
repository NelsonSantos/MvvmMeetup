using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MvvmMeetup.ViewModels
{

    public class ViewModelPedido : BaseViewModel
    {
        public ViewModelPedido()
        {
            this.NomeCliente = "Nelson Santos";
            this.Produtos = new ObservableCollection<Produto>
            {
                new Produto { NomeProduto = "Bolacha", Preco = 2, Quantidade=1},
                new Produto { NomeProduto = "Coca Cola", Preco = 5, Quantidade=1}
            };

            this.AumentaQuantidadeCommand = new Command<Produto>((produto) =>
            {
                produto.Quantidade++;
                this.OnPropertyChanged(nameof(TotalPedido));
            });

            this.DiminuiQuantidadeCommand = new Command<Produto>((produto) =>
            {
                produto.Quantidade--;

                if (produto.Quantidade <= 0)
                    produto.Quantidade = 1;

                this.OnPropertyChanged(nameof(TotalPedido));
            });

        }
        public string NomeCliente { get; set; }
        public decimal TotalPedido
        {
            get
            {
                return this.Produtos.Sum(p => p.Total);
            }
        }
        public ObservableCollection<Produto> Produtos { get; set; }
        public ICommand AumentaQuantidadeCommand { get; }
        public ICommand DiminuiQuantidadeCommand { get; }
    }
}
