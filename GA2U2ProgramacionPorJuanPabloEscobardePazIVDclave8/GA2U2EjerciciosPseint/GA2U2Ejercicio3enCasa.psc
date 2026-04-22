Algoritmo GA2U2Ejercicio3enCasa
	Definir opc, entrada Como Entero
	Escribir "COMPRA DE ENTRADAS-Estadio Doroteo Guamuch"
	Escribir Sin Saltar "Ingrese el numero de entradas que desea adquirir:"
	Leer entrada
	Escribir "SECTORES DEL ESTADIO-PRECIOS"
	Escribir "1 - Palco: Q300.00"
	Escribir "2 - Tribuna: Q100.00 - Q125.00"
	Escribir "3 - Preferencia: Q50.00 - Q75.00"
	Escribir "4 - Generales: Q30.00 - Q50.00"
	Escribir "5 - SALIR"
	Escribir "Seleccione un sector del estadio:"
	Leer opc
	Segun opc Hacer
		1:
			total = entrada*300
			Escribir "Palco"
			Escribir "Precio Total de entradas: Q",total
		2:
			total = entrada*100
			total2 = entrada*125
			Escribir "Tributaria"
			Escribir "Precio Total de entradas: Q",total "-Q",total2
		3:
			total = entrada*50
			total2 = entrada*75
			Escribir "Preferencia"
			Escribir "Precio Total de entradas: Q",total "-Q",total2
		4:
			total = entrada*30
			total2 = entrada*50
			Escribir "Generales"
			Escribir "Precio Total de entradas: Q",total "-Q",total2
		5:
			Escribir "Saliendo..."
		De Otro Modo:
			Escribir "Valor invalido"
	Fin Segun
FinAlgoritmo
