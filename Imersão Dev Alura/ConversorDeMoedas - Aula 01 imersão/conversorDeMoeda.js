var valorEmDolar = 30;
var cotacaoDolar = 5.32;

var valorCambioRealDolar = valorEmDolar * cotacaoDolar;

var campoNumericoElement = document.getElementById('campoNumerico');

campoNumericoElement.innerHTML = valorCambioRealDolar.toFixed(2);
