using DIO.Desafio1.Contato;
using DIO.Desafio2.ContaBancaria;
Contato c1 = new Contato();
Contato c2 = new Contato();

c1.nome = "João Victor";
c1.telefone = "(11) 98765-4321";

c2.nome = "Vinicius Martins";
c2.telefone = "(11) 91234-5678";

c1.exibirInfos();
c2.exibirInfos();

ContaBancaria conta1 = new ContaBancaria();
conta1.saldo = 500;

conta1.depositar();
conta1.sacarSaldo();