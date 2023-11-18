var listaFilmes = [];
listaFilmes[0] = "filme1.png";
listaFilmes[1] = "filme2.png";
listaFilmes[2] = "filme3.png";

for (var i = 0; i < 3; i++) {
  document.write('<img src="' + listaFilmes[i] + '">');
}
