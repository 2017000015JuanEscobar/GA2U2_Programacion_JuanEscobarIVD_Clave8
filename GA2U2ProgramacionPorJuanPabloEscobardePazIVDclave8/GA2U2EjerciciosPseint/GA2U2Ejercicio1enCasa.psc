Algoritmo GA2U2Ejercicio1enCasa
	Definir opc, op, ady, hip, result Como Real
	Definir msj Como Caracter
	Escribir "CALCULADORA FUNCIONES TRIGONOMETRICAS BASICAS"
	Escribir "Escriba el valor del: Opuesto, Adyacente e Hipotenusa"
	Leer op
	Leer ady
	Leer hip
	Escribir "**************"
	Escribir "MENU PRINCIPAL"
	Escribir "1 - Seno"
	Escribir "2 - Coseno"
	Escribir "3 - Tangente"
	Escribir "4 - Salir"
	Escribir "Digite el numero segun su operacion"
	Escribir "**************"
	Leer opc
	Segun opc Hacer
		1:
			msj = "El seno del angulo es:"
			result = op/hip
		2:
			msj = "El coseno del angulo es:"
			result = ady/hip
		3:
			msj = "La tangente del angulo es:"
			result = op/ady
		4:
			msj = "Saliendo del sistema..."
		De Otro Modo:
			msj = "Seleccione un opcion valida..."
	Fin Segun
	Escribir msj
	Escribir result
FinAlgoritmo
