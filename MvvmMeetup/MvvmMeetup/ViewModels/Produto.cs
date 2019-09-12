using System.Windows.Input;
using Xamarin.Forms;

namespace MvvmMeetup.ViewModels
{
    public class Produto : BaseViewModel
    {
        private int quantidade;
        
        public string NomeProduto { get; set; }
        public int Quantidade
        {
            get => quantidade;
            set
            {
                if (quantidade != value)
                {
                    quantidade = value;
                    this.OnPropertyChanged();
                    this.OnPropertyChanged(nameof(Total));
                }
            }
        }
        public decimal Preco { get; set; }
        public decimal Total
        {
            get
            {
                return this.Quantidade * this.Preco;
            }
        }
    }
}
