Algoritmo GA2U2Ejercicio2enClase
	Definir num1, num2, opc, result Como Real
	Definir  msj Como Caracter
	Escribir Sin Saltar "Dijite valores numericos:"
	Leer num1
	Leer num2
	Escribir "*******************"
	Escribir "Menu Principal"
	Escribir "1- suma"
	Escribir "2- resta"
	Escribir "3- mutiplicacion"
	Escribir "4- division"
	Escribir "5- SALIR"
	Escribir Sin Saltar "Dijite el numero segun su Operacion:"
	leer opc
	segun opc Hacer
		1:
			msj="El resultado de la suma es:"
			result=num1+num2
		2:
			msj="El resultado de la resta es:"
			result=num1-num2	
		3:
			msj="El resultado de la multiplicacion es:"
			result=num1*num2
		4:
			msj="El resultado de la divicion es:"
			result=num1/num2
		5:
			msj="Saliendo del programa:"
		De Otro Modo:
			msj="Seleccione una opcion valida"
	FinSegun
	Escribir msj
	Escribir result
FinAlgoritmo
