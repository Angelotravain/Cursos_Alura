
import { Cliente } from "./Cliente.js";
import { ContaCorrente } from "./ContaCorrente.js";

const cliente1 = new Cliente();
const cliente2 = new Cliente();

cliente1.nome = "Angelo";
cliente1.cpf = 1111111111111111;

cliente2.nome = "Maria";
cliente2.cpf = 22222222222;


const contaCorenteRicardo = new ContaCorrente();

contaCorenteRicardo.agencia = 1001;

contaCorenteRicardo.sacar(80);
contaCorenteRicardo.depositar(100);





console.log("Saldo final: " + contaCorenteRicardo.saldo);
console.log(cliente1);
console.log(cliente2);