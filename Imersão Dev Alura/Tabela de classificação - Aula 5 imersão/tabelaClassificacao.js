var paulo = {
  nome: "Paulo",
  vitoria: 0,
  empate: 0,
  derrota: 0,
  pontos: 0,
};

var rafa = {
  nome: "Rafa",
  vitoria: 15,
  empate: 0,
  derrota: 0,
  pontos: 0,
};
var angelo = {
  nome: "Angelo",
  vitoria: 25,
  empate: 0,
  derrota: 0,
  pontos: 0,
};

var elementoTabela = document.getElementById("tabelaJogadores");

exibitNaTela();

function exibitNaTela() {
  elementoTabela.innerHTML = `        <tr>
          <td>${paulo.nome}</td>
          <td>${paulo.vitoria}</td>
          <td>${paulo.empate}</td>
          <td>${paulo.derrota}</td>
          <td>${paulo.pontos}</td>
          <td><button onClick="adicionarVitoria(paulo)">Vitória</button></td>
          <td><button onClick="adicionarEmpate(paulo)">Empate</button></td>
          <td><button onClick="adicionarDerrota(paulo)">Derrota</button></td>
        </tr>
        <tr>
          <td>${rafa.nome}</td>
          <td>${rafa.vitoria}</td>
          <td>${rafa.empate}</td>
          <td>${rafa.derrota}</td>
          <td>${rafa.pontos}</td>
          <td><button onClick="adicionarVitoria(rafa)">Vitória</button></td>
          <td><button onClick="adicionarEmpate(rafa)">Empate</button></td>
          <td><button onClick="adicionarDerrota(rafa)">Derrota</button></td>
        </tr>
        <tr>
          <td>${angelo.nome}</td>
          <td>${angelo.vitoria}</td>
          <td>${angelo.empate}</td>
          <td>${angelo.derrota}</td>
          <td>${angelo.pontos}</td>
          <td><button onClick="adicionarVitoria(angelo)">Vitória</button></td>
          <td><button onClick="adicionarEmpate(angelo)">Empate</button></td>
          <td><button onClick="adicionarDerrota(angelo)">Derrota</button></td>
        </tr>`;
}

function adicionarVitoria(jogador) {
  jogador.vitoria++;
  jogador.pontos += 3;
  exibitNaTela();
}
function adicionarEmpate(jogador) {
  jogador.empate++;
  jogador.pontos += 1;
  exibitNaTela();
}
function adicionarDerrota(jogador) {
  jogador.derrota++;
  exibitNaTela();
}
