var numeroSecreto = parseInt(Math.random() * 1001);
var numeroSelecionado = 1;

while (entradaUsuario != numeroSecreto) {
  var entradaUsuario = prompt("Digite o número entre 1 e 1000");
  if (entradaUsuario == numeroSecreto) {
    alert("Acertou o Número secreto é " + entradaUsuario);
    numeroSelecionado += numeroSecreto;
  } else if (entradaUsuario > numeroSecreto) {
    alert("O Numero secreto é menor que " + entradaUsuario);
  } else if (entradaUsuario < numeroSecreto) {
    alert("O Numero é maior que o numero secreto");
  }
}
