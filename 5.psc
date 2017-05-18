Algoritmo cinco
	Escribir "ingresa el codigo de la materia"
	leer codigo
	Escribir "ingresa el nombre del alumno"
	leer nombre
	Escribir "ingresa la primer calificacion"
	leer c1
	Escribir "ingresa la segunda calificacion"
	leer c2
	Escribir "ingresa la tercer calificacion"
	leer c3
	prom<-((c1*.3)+(c2*.3)+(c3*.4))
	si(prom=10)
		Escribir "alumno exelente"
	FinSi
	si(prom>=7) Entonces
		
		Escribir "aprobado"
	FinSi	
	si(prom<7)
		Escribir "reprobado"
	FinSi
	
	Escribir  "en la materia de "
	Escribir  codigo
	Escribir "el alumno "
	Escribir nombre
	Escribir "su promedio es "
	Escribir prom
	
	
FinAlgoritmo
