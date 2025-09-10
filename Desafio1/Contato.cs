
namespace DIO.Desafio1.Contato
{
    public class Contato
    {
        public string nome { get; set; }
        public string telefone { get; set; }

        public void exibirInfos() {
            Console.WriteLine($"Nome: {nome}, Telefone: {telefone}\n");
        }
    }
}

