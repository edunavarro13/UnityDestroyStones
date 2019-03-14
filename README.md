# UnityDestroyStones

## Destroy Stones

Destroy Stones es un proyecto que realicé en el curso online de [Introducción al desarrollo de videojuegos con Unity](https://courses.edx.org/courses/course-v1:UPValenciaX+UNY201.x+2T2018/course/) de la Universidad Politécnica de Valencia.

Es un juego para ordenador que va lanzando piedras que pasan por la pantalla. El jugador ha de pulsar encima de las piedras para destruirlas y ganar puntos.

## Juego

El ejecutable del juego está en la carpeta [Exe](https://github.com/edunavarro13/UnityDestroyStones/tree/master/DestroyStones/Exe).

## Herramientas usadas

* Lenguaje: C#
* Entorno de desarrollo: Unity

## Funcionamiento

Una vez ejecutado el juego, saldrá la pantalla inicial en la que el jugador podrá seleccionar la dificultad del juego. Tras eso, saldrá un pequeño tutorial en el que explican:
* Si destruyes una piedra roja, el jugador pederá una vida.
* Si destruyes una piedra verde, el jugador ganará 2 puntos.
* Si destruyes una piedra gris, el jugador ganará 1 punto.
El funcionamiento es simple: el jugador debe conseguir el mayor número de puntos posible. La partida terminará si el jugador destruye por error 3 piedras rojas (equivalentes a las 3 vidas que posee).
Una vez terminado el juego, saldrá un resumen del juego realizado y el jugador tendrá 2 opciones:
* Volver a jugar con la misma dificultad.
* Volver a la pantalla inicial para poder cambiar la dificultad.
