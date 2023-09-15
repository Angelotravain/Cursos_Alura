export class ContaCorrente {
    agencia;
    #saldo;

    sacar(valor) {
        if (this.#saldo >= valor) {
            this.#saldo -= valor;
            return valor;
        }
    };
    depositar(valor) {
        if (valor <= 0) {
            return; // serve para retornar ou parar a execução 
        }
        this.#saldo += valor;
        console.log(this.#saldo);
    }
}


// # => é um caractere para deixar o atributo protegido

// _ => é um caractere para deixar o atributo privado


