let valor1 = "";
let valor2 = "";
let operador = "";
let resultado;

function adicionarNumero(numero) {
  let visor = document.getElementById("visor");
  visor.value += numero;
}


function adicionarVirgula() {
	let visor = document.getElementById("visor");
	// Verifica se já existe uma vírgula no visor
	if (!visor.value.includes(".")) {
	  visor.value += ".";
	}
  }

function operacao(op) {
	valor1 = document.getElementById("visor").value;
	document.getElementById("visor").value = "";      
	operador = op;
  }
  

function limpar() {
  document.getElementById("visor").value = "";
  valor1 = "";
  valor2 = "";
  operador = "";
}

function calcular() {
  valor2 = document.getElementById("visor").value;
  if (operador === "+") {
    resultado = parseFloat(valor1) + parseFloat(valor2);
  } else if (operador === "-") {
    resultado = parseFloat(valor1) - parseFloat(valor2);
  } else if (operador === "*") {
    resultado = parseFloat(valor1) * parseFloat(valor2);
  } else if (operador === "/") {
    resultado = parseFloat(valor1) / parseFloat(valor2);
  }
  document.getElementById("visor").value = resultado;
}
