namespace DIO.Desafio2.ContaBancaria
{
    public class ContaBancaria
    {
        public int saldo { get; set; }

        public void sacarSaldo()
        {
            string saque;
            int saqueInteiro;
            Console.WriteLine("Digite o valor a ser sacado: ");
            saque = Console.ReadLine();
            saqueInteiro = int.Parse(saque);
            if (saqueInteiro > saldo)
            {
                Console.WriteLine("Saldo insuficiente.");
                return;
            }
            else if (saqueInteiro == 0)
            {
                Console.WriteLine("Saque inválido");
            }

            saldo = saldo - saqueInteiro;
            Console.WriteLine($"Seu novo saldo é: {saldo}");
        }

        public void depositar()
        {
            Console.WriteLine("Digite o valor a ser depositado: ");
            string deposito = Console.ReadLine();
            int depositoInteiro = int.Parse(deposito);
            saldo = saldo + depositoInteiro;
            Console.WriteLine($"Deposito realizado com sucesso. Seu novo saldo é {saldo}");
        }
    }
}