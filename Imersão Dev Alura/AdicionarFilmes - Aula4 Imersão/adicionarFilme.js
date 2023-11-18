function adicionarFilme() {
  var filmeFavorito = document.getElementById("filme").value;
  var elementoListaFilmes = document.getElementById("listaFilmes");

  if (filmeFavorito != "") {
    elementoListaFilmes.innerHTML =
      elementoListaFilmes.innerHTML + '<img src="' + filmeFavorito + '">';
    document.getElementById("filme").value = "";
  }
  document.getElementById("filme").value = "";
}
