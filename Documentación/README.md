# FinalSadboys

## Integrantes

Mario Andres Cálix Sosa				00309119 
Juan Humberto Gallardo Hernández	00091813
Kevin Alexander Cea Patriz			00203919

## IDE

JetBrains Rider 2019

## FAQ

1-*¿Cómo iniciar el juego?*
Luego de cargar el juego, pulsar el botón **PLAY** o la tecla **Enter** para acceder a la pantalla siguiente. 
Aparecerá el menú para ingresar su nombre de usuario y, a continuación, digitar su nombre de usuario en el área indicada y presionar el botón **BEGIN ARKANOID** o la tecla **Enter** para comenzar el juego.

2-*¿Cómo escoger mi nombre de usuario?*
Debe que ser un nombre que contenga entre 1 y 25 caracteres.
Se permite el uso de letras, números y caracteres especiales(Unicode).
Si el nombre de usuario no existe en la base de datos, se creará uno nuevo con ese nombre.

4-*¿Cómo funciona el sistema de puntajes del juego?*
El juego guarda el puntaje final del jugador en una base de datos al terminar una partida. 
Si el jugador es victorioso, se agregan puntos extra al puntaje final, basados en el tiempo transcurrido y vidas restantes. 
Si el jugador pierde, se guarda el puntaje final obtenido sin cambio alguno.

5-*¿Cómo se calcula el puntaje final?*
Destruye bloques para conseguir puntos!

Verde = 80 pts.
Morado = 110 pts.
Azul = 100 pts.
Amarillo = 120 pts.
Rojo = 90 pts.
Plata = 50 pts.

5-*¿Cómo puedo ver mi puntaje?*
En la pantalla del menú principal, pulsar el botón *HIGH SCORES*. Aparecerá la pantalla de los mejores puntajes donde se muestran lo diez mejores puntajes obtenidos con el nombre del jugador que los obtuvo.

6-*¿Cómo salir del juego y qué sucede con mi puntaje?*
Pulsar la tecla **Esc** para regresar al menú de inicio en el cual podrá pulsar el botón **EXIT** si desea salir de la aplicación. 
Al salir de una partida en curso, se pierde el puntaje actual y solo se almacenará el nombre de usuario en la base de datos, si este no existía previamente.

## Trello

https://trello.com/b/wac8JSum/fullsadboysarkanoid