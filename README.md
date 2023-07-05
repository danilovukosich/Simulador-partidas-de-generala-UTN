# Vukosich.Danilo.TP2

Segundo Parcial Laboratorio 2 UTN(Universidad Tecnologica Nacional) - "GENERALA"

Aumno: Vukosich Danilo 

Curso: 2do A 

## Sobre mi:
Mi nombre es Danilo Vukosich, programar este proyecto fue bastante complejo en cuanto a la logica y a la implementacion de los temas que se pedian, pero dentro de todo bastante entretenido de codear y resolver los problemas logicos que contiene la Genearala. Intente hacer un diseño mas minimalista en cuanto a la parte estetica y centra mas en la logica del codigo.

## Resumen de la aplicacion:


  ![Inicio Sesion](https://github.com/danilovukosich/Vukosich.Danilo.TP2/assets/86834937/b8e98600-5661-4a11-9bda-3463cc6676d8)  
  La aplicacion cuenta con una pantallade inicio en la que se puede iniciar sesion con un jugador ya existente y tambien registrarse para luego poder acceder con el mismo.


  ### Una vez iniciada la sesion pasamos al la pantalla principal donde se presentan 3 opciones:

  ![PantallaPrincipal](https://github.com/danilovukosich/Vukosich.Danilo.TP2/assets/86834937/f9dde5a0-16d4-4141-bbfb-e88a278b67a3)


  ### Crear partida: 
  Crea una partida con el jugador con el cual se ingreso y juega contra la maquina. Se pueden jugar cualquier cantidad de partidas en simultaneo y estas pueden se canceladas siempre y cuando no hayan terminado. Al finalizar cada partida salta un fomulario indicando el ganador y sus puntos.

  ### Estadisticas: 
  Podremos ver la cantidas de partidas jugadas, ganadas y perdidas del jugador y su historial de partidas.

  ### Historial partidas: 
  Podremos ver el historial general de todas la partidas jugadas de todos los usuarios que ingresaron.

## Diagrama de Clases:

![Diagrama de clases](https://github.com/danilovukosich/Vukosich.Danilo.TP2/assets/86834937/60ef4b1e-5c18-46b8-87ba-c3002cfdbafd)

## Justificacion Tecnica:



### -SQL

![SQLnuevo](https://github.com/danilovukosich/Vukosich.Danilo.TP2/assets/86834937/4f26aad3-a806-45bd-a2df-1e2b02c5cbfc)

Utilizo SQL para guardar los datos de cada jugador una vez creados y actualizarlos unavaz terminada la partida.

### -Excepciones

![Manejo de Excepciones](https://github.com/danilovukosich/Vukosich.Danilo.TP2/assets/86834937/0eafcf45-2471-4610-8fb9-65ae0591bb1d)

Excepciones utilizadas por si el usuario ingresado llega a ser NULL;

### -Unit Testing

![Testeo de los resultados de las tiradas](https://github.com/danilovukosich/Vukosich.Danilo.TP2/assets/86834937/3422b244-f637-4040-8c60-a20b465e59e9)

Testeo si los metodos de los puntos funcionan correctamente al pasarles un array de numeros que simboliza una tirada.

### -Generics y Serializacion

![Serializacion](https://github.com/danilovukosich/Vukosich.Danilo.TP2/assets/86834937/f9b9762a-3565-498b-aea5-523bec7597c4)

Utilizo generics en la serializacion de Json para poder serializar cualquier tipo de objeto. 

### Interfaces

![Interfaz](https://github.com/danilovukosich/Vukosich.Danilo.TP2/assets/86834937/3ad4802b-e186-4b8b-9940-becaf5a186dd)

Utilizo una interfaz para la serializacion.


### -Task

![Task](https://github.com/danilovukosich/Vukosich.Danilo.TP2/assets/86834937/5bdd3ad2-735f-4052-8594-d01da497d098)

Utilizo Tasks para poder crear varias partidas al mismo tiempo si problema.

### -Eventos y Delegados

![Eventos y Delegados](https://github.com/danilovukosich/Vukosich.Danilo.TP2/assets/86834937/953bc0c0-1e31-4825-80fb-b8d7a8f2db5d)

Utilizo eventos y delegados en el fomulario del ganador para mostrar los puntos y el nombre del ganador.



















