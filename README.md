# SnakesLadders
Inicio de kata para el juego snakes and ladders C#

Es un juego multijugador, que consta de un tablero, un dado y las normas correspondientes de como jugar a este juego
# Para ejecutar
Es un proyecto de consola C# Net Core 6.0. Una vez descargado el proyecto, nos situamos en el directorio bin/Debug/net6.0 y
doble click en el archivo SnakeLadders de tipo aplicacion

![image](https://user-images.githubusercontent.com/9914387/206599335-db042b8a-fd4b-4d73-b96f-eabddfa3a8f9.png)


El programa nos pedirá un tamaño del tablero (entre 5 y 100), y un numero total de jugadores (entre 1 y 50)

![image](https://user-images.githubusercontent.com/9914387/206528081-33375c88-d8eb-4667-ae70-82cb2ca6f1e6.png)

Se sortea quien es el primer jugador a tirar el dado. A partir de este momento, el turno es correlativo según el Id de cada jugador.
Se visualizan todas las tiradas del dado efectuadas por los jugadores, y el ganador final.

![image](https://user-images.githubusercontent.com/9914387/206529935-9c47272b-c2bc-4e29-ba4e-5f5998342098.png)

Presione Enter para terminar la ejecución

# Resumen de la Kata y patrones de Diseño empleados
- Se ha usado un patrón FluentBuilder para la creación del juego
- Se ha usado un método factory para la creación del tablero de juego
- Se ha incluido un proyecto de pruebas unitarias con xUnit, esta ha sido una de las prioridades de desarrollo, que todo el código se pueda testear con pruebas unitarias

![image](https://user-images.githubusercontent.com/9914387/206600728-f7ebc190-0339-46d1-9b77-5f5c972e4c0b.png)

- Para poder ejecutar las pruebas, se tienen que cargar las pruebas en Visual Studio (yo he usado VS2022 Community), y buscar la opción de menú Prueba -> Explorador de Pruebas

![image](https://user-images.githubusercontent.com/9914387/206601007-f1525cc4-a673-43a3-be22-a5e51a4e1a7f.png)

- Se ha intentado respetar los principios SOLID, pero sobre todo el de single responsibility, y para ello se han definido todas las clases necesarias 
para que cada una de ellas solo pueda tener un motivo de cambio

![image](https://user-images.githubusercontent.com/9914387/206601054-67c5d6da-294c-4262-ac47-5bf7ad8d1e94.png)

# Posibles mejoras y forma de continuar esta kata
- Programación con interfaces, que permitan inyectar las despendencias donde sea necesario. Es un tema muy importante para conseguir código desacoplado, pero para esta kata no se ha incluido este concepto.
- La programación con interfaces también permite tener un código más testeable, y permite incluir mocks de las mismas en los tests unitarios cuando sea necesario.
- Para continuar esta kata, sería necesario incluir en el tablero celdas de tipo Snake y de tipo Ladder (herencia de la clase Cell en ambos casos), e incluir en las normas de juego (clase Rules) el comportamiento de estas casillas.
- Dada la naturaleza del juego, no se ha utilizado ningún tipo de programación asíncrona ni paralelismo, un tema que siempre cabe considerar en cualquier proyecto, dependiendo de la naturaleza del mismo.
- Al ser un proyecto de consola, no existe ningún tipo de interficie gráfica para este juego
- Al ser una kata, tampoco se ha tenido en cuenta la posibilidad de crear un juego real en el que varios jugadores puedieran jugar desde terminales distintos, compartiendo realmente el tablero y el dado, y que cada jugador pudiera ver las tiradas del resto de jugadores. Se han simulado los jugadores con una cola cirdular de jugadores, en la que el turno va pasando de un jugador al siguiente, y cuando se llega al último jugador, el tuno pasa de nuevo al primer jugador.

