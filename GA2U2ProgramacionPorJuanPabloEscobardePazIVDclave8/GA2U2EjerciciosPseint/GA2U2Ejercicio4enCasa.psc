Algoritmo GA2U2Ejercicio4enCasa
	Definir cant, m, fts, cm, pulg Como Real
	Definir op Como Entero
	Escribir "CONVERSOR DE MEDIDAS DE LONGITUD"
	Escribir "Ingrese la cantidad a convertir:"
	Leer cant
	Escribir "Seleccione la unidad de medida original:"
	Escribir "1 - Metros"
	Escribir "2 - Pies"
	Escribir "3 - Centímetros"
	Escribir "4 - Pulgadas"
	Leer op
	Segun op Hacer
		1:
			m = cant
			fts = cant * 3.28084
			cm = cant * 100
			pulg = cant * 39.3701
		2:
			m = cant / 3.28084
			fts = cant
			cm = cant * 30.48
			pulg = cant * 12
		3: 
			m = cant / 100
			fts = cant / 30.48
			cm = cant
			pulg = cant / 2.54
		4:
			m = cant / 39.3701
			fts = cant / 12
			cm = cant * 2.54
			pulg = cant
		De Otro Modo:
			Escribir "Opción no válida"
	Fin Segun
	Escribir "Resultados de la conversión:"
	Escribir m, " Metros"
	Escribir fts, " Pies"
	Escribir cm, " Centímetros"
	Escribir pulg, " Pulgadas"
FinAlgoritmo
