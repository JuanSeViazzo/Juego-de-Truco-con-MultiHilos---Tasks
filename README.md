# ViazzoPerrone.JuanSebastian.TP2-
# JUGATE UN TRUCO - SIMULADOR DE TRUCO KIDS

_Es una sistema para simular partidas de truco para niños, la idea es que las manos sean sencillas y faciles de una ronda o dos, con pocos puntos para que sea didactico a los infantes, es un juego recomendado para niñxs de 4 a 12 años, ademas se podra leer como son las partidas de truco, para eso debera seleccionar 1ero dos jugadores distintos que actualmente no esten jugando ninguna partida, cargar el mazo por primera vez (secuencia para demostrar funcionalidad de serializacion), e iniciar la partida, una vez iniciada, haciendo doble click sobre las partidas, podra observar la misma_


## Sobre mi: 😎😥😍😫😖🤬🤡🛠🧐💀☠🦈🦆🦋🎸🕯🥂

- Mi nombre es Juan Sebastian Viazzo Perrone, estoy recursando la materia, y mirando lo que codee el cuatri anterior, no puedo de sentir alegria por mi avance, aun a sabiendas que falta mucho mucho por mejorar, agregue muchisimos temas nuevos, aprendi DELEGADOS EVENTOS Y TASK, y no solo eso, PUDE AYUDAR A OTROS, a mas de un compañero lo ayude para implementar delegados, ventos, task, y hasta unit testing. 
- Los emoji son parte de lo que significo el codigo para mi (Repetido del readme anterior? si, pero esta vez creo que fue peor, se me acumulo el trabajo y problemas personales), empezando por alguien confiado que iba a poder, a poco del comienzo ya me senti triste porque era una sensacion de un codigo inmenso para mi capacidad. Cuando empece a darle forma no senti otra cosa que amor por mi pequeño proyecto, aunque dias despues me senti frustrado, cansado, enojado! y hasta un payaso. Pero tome otra decision, manos a la obra y empece a buscar documentacion oficial, a investigar sobre los eventos, metodos, etc, sentia que moria, pero _MENTE DE TIBURON_ uno no tiene que aflojar, aunque sientas que sea un paso una caga**, y aunque el codigo viva un dia como una mariposa, guitarrear tal vez es lo que mejor me sale, y por eso prendo una velita, para poder brindar una buena nota.
- Al final de cuentas disfrute el codigo, disfrute mayormente la parte de eventos, delegados, SQL (al final de cuentas me gusta, y no es tan facil eh) y me hubiese gustado mejorar muchisimo la logica y hacer mas clean code y SOLID, por otro lado tenia intenciones de hacer MVP no solo para interfaces sino para implementar los metodos, pero bueno, no es sencillo y no hay que comparse con los demas, cada uno tiene sus tiempos sus problemas, su vida. 
- 

## RESUMEN 📜

_Estas instrucciones te permitirán poder navegar dentro del proyecto y disfrutar de una experiencia satisfactoria_

## Menu principal - Pivote de la App 🏛

_Aca usted podra visualizar la ventana, en la cual donde podra ir a cada una de las opciones disponibles como usuario_

![image](https://user-images.githubusercontent.com/86853488/202911202-78897428-d647-4b23-bb70-2813e7f4b21b.png)


## Crear Nueva Sala - Primero debera cargar un mazo, despues podra iniciar la partida  💸
![image](https://user-images.githubusercontent.com/86853488/202913909-0225ab8d-8abe-4df0-917c-788711091fd0.png)

### Nuevas caracteristicas en la proxima version
-Mejor interfaz
- Eliminar Usuarios
- Modificar Usuarios
- Modificar Mazo
- Caracteristicas del menu, diseño, etc.

## Nuevo Jugador 🛫🛬

![image](https://user-images.githubusercontent.com/86853488/202911503-8164bed6-7d97-4eca-8a91-ea9d70465a38.png)
_Aca usted podra crear un nuevo jugador, colocar su carta preferida, y edad_
### Nuevas caracteristicas en la proxima version
-Validacion de atributos
-Mayores caracteristicas de usuario
-agregar imagen de perfil

## Estadisticas de Partida 🔍

![image](https://user-images.githubusercontent.com/86853488/202912017-e547b0d9-91ee-4fd2-8811-bb32b5e9d0c6.png)

_En esta pantalla ud podra visualizar las estadisticas de las partidas, donde podra ver que ID de jugador gano la partida;_

### Nuevas caracteristicas en la proxima version
-Mas informacion y con mejores descripciones
-Poder en el mismo form de estadisticas, ver otro tipo de estadisticas
-Habilitar la opcion de filtrado
-hacer doble click sobre esa partida, y poder simularla (debera guardarse toda la secuencia de la partida, y volver a correr solo el texto).
-hacer doble click sobre la partida y estara la opcion de simularla pero tambien la opcion de ver estadisticas de cada jugar, manos etc.

## Estadisticas Jugadores
![image](https://user-images.githubusercontent.com/86853488/202913663-9ba9a03d-c55e-48b5-b1b2-11a676f9ca58.png)

- Al finalizar la partida, podra ver las estadisticas de los jugadores, la misma es una relacion entre la tabla de jugadores, y partidas-
### Nuevas caracteristicas en la proxima version
-Al hacer doble click sobre un jugador, poder abrir su fichca y modificarla o elimiar.
-Agregar las columnas de partidas perdidas, rival habitual, carta elegida habitualmente


![image](https://user-images.githubusercontent.com/86853488/202913725-4dcf5f06-e8b8-4c82-90d8-7a792beb70f5.png)


**En este paso ud debe cargar el mazo, y tambien esta la opcion de guardar el mazo, el cual en una feature sera apto para modificar**

![image](https://user-images.githubusercontent.com/86853488/202913807-c29a60e9-ae31-4e98-ab51-ac4bde6afd8f.png)

**debera elegir el mazo serializado para iniciar la partida**


## Construido 🛠️ con Amor y Odio, no no, solo con Amor 🥰


**Justificacion Tecnica**

### 1- SQL - QUERY INNER JOIN - COUNT - GROUP BY - SUM => (HERMOSA)
![image](https://user-images.githubusercontent.com/86853488/202914208-fbd8ee65-976f-4182-9747-a0efd9749333.png)
![image](https://user-images.githubusercontent.com/86853488/202914251-39983c41-07a2-4b16-a7d0-a75dbce0f801.png)
![image](https://user-images.githubusercontent.com/86853488/202914315-0e1a019a-800b-46f3-af42-a5268190ea8b.png)
-EN ESTA TABLA ULTIMA, PROBABLEMENTE EL NUEVO ID A PARTIR DE HOY SERA 26, YA QUE HUBO PRUEBAS.
![image](https://user-images.githubusercontent.com/86853488/202915618-d93e7ea6-cc06-451b-9b5c-01c20da30f17.png)
-CLASE CONEXION A BASE DE DATOS

### 2 - MANEJO DE EXCEPCIONES
![image](https://user-images.githubusercontent.com/86853488/202915646-9116bb42-7010-4d98-97dd-908fec315d23.png)
![image](https://user-images.githubusercontent.com/86853488/202915659-1cee2613-d7c6-44f2-912a-6e581fa14414.png)
![image](https://user-images.githubusercontent.com/86853488/202915665-63f03224-75d5-45b1-8eec-46fe9f7de13d.png)
![image](https://user-images.githubusercontent.com/86853488/202915672-91cbc225-9915-4720-8686-ac087d828e4b.png)
-EXCEPCIONES PERSONALIZADAS, MANEJO DE EXCEPCIONES EN BD.

### 3 UNIT TESTING
![image](https://user-images.githubusercontent.com/86853488/202916697-34da4ae6-753e-4b5b-96fa-b55cc0a1894c.png)
![image](https://user-images.githubusercontent.com/86853488/202916736-7b72d38a-1d0a-4b35-8542-1530e0c918a8.png)

-Los test de jugador estan rompiendo por la serializacion, pero funciona correctamente, es mas la ruta que paso en ambos casos es la correcta.
-Los test de logica estan correctos, me falta agregar mas TEST.



## 4 GENERICS && INTERFACES
![image](https://user-images.githubusercontent.com/86853488/202916786-64c0508d-7477-479e-856b-e268a354534e.png)
![image](https://user-images.githubusercontent.com/86853488/202916847-3bfcc365-a7f4-42bc-8240-07314bb12048.png)

LA CLASE SERIALIZADORAJSON Y XML, IMPLEMENTAN GENERICOS E INTERFACES
-Queria implementar interfaces con MVP.


## 5 SERIALIZACION
CLASE SERIALIZADORA, SE SERIALIZA EL MAZO, SE CARGA ANTES DE INICIAR LA PARTIDA, Y DESPUES SI QUIERE SE PUEDE GUARDAR
LA IDEA ES IMPLEMENTAR ALGUNA MODIFICACION DEL MAZO PARA JUSTIFICAR EL GUARDADO, PERO FUNCIONA.
![image](https://user-images.githubusercontent.com/86853488/202917628-0118e93d-dca4-49b2-a996-36add2962cee.png)

## 6 - EVENTOS DELEGADOS

![image](https://user-images.githubusercontent.com/86853488/202920366-36890975-ce08-4afb-8a1d-cdd3d8e011d0.png)
-ACA SE UTILIZA EVENTOS, EN EL CUAL EL JUGADOR HARA EL INVOKE
![image](https://user-images.githubusercontent.com/86853488/202920375-044172e9-b7bf-4868-8bcc-9c908d0a9e31.png)
![image](https://user-images.githubusercontent.com/86853488/202920379-f04c448f-47b0-4dfe-9300-975d510d3043.png)
![image](https://user-images.githubusercontent.com/86853488/202920420-95f36fc3-a2a1-460b-80be-a74101441caa.png)
-DONDE CREO LA PARTIDA, ASIGNO AL EVENTO, EL METODO MOSTRARMENSAJE.
![image](https://user-images.githubusercontent.com/86853488/202920435-104ac98e-195e-4b7d-a1fe-fde43d8b535f.png)
-Y EL METODO LLAMADA AL DELEGADO.
![image](https://user-images.githubusercontent.com/86853488/202920453-7501d4b7-37eb-4dab-a8fe-b1fd753e870e.png)
![image](https://user-images.githubusercontent.com/86853488/202920463-d945fda7-e6ef-4d83-a1f6-d4eb0c2090e6.png)
![image](https://user-images.githubusercontent.com/86853488/202920470-b0259f5c-1f45-4b66-a8c2-cfc63b46253e.png)
-ACA ACTUALIZO LA SALA CON UN DELEGADO QUE RECIBE UNA LISTA DE SALAS.
![image](https://user-images.githubusercontent.com/86853488/202920505-2d08ffd8-e627-4115-9e3a-7789cff78111.png)

![image](https://user-images.githubusercontent.com/86853488/202920496-937f97ee-727a-43ea-927e-8ce5d4a0cf04.png)


## 7 TASK(HILOS)
![image](https://user-images.githubusercontent.com/86853488/202920557-a632a00a-060b-4c97-ac86-1238575f1cf2.png)
-ESTO TAL VEZ ES LO QUE MAS ME GUSTO, AL METODO LE PUSE ASYNC Y AWAIT, ENTIENDO QUE : YO CORRO LA TAREA DE JUGAR, Y PUEDO CORRER VARIOS HILOS A LA VEZ, SON HILOS SECUNDARIOS, LO QUE SI, VAN A QUEDAR CORRIENDO Y YO ESPERANDO A QUE TERMINE, AWAITANDO...COMO YA NO AWAITO MAS, PREGUNTO SI LA TASK IS COMPLETED, Y CUANDO ME DICE QUE SI GUARDO EN BASE DE DATOS LA PARTIDA.



## BASE DE DATOS DONDE ESTA?

![image](https://user-images.githubusercontent.com/86853488/202922731-72d77fc9-f714-4ebd-a996-fdb9b3f1d6a3.png)

![image](https://user-images.githubusercontent.com/86853488/202922739-7a8dcb48-6c9b-49ae-8bc5-202c20c3a486.png)
![image](https://user-images.githubusercontent.com/86853488/202922748-da0e4a82-3847-41d0-9adf-c2413c6c59cf.png)







GRACIAS POR TODO. QUE DISFRUTEN LA EXPERIENCIA.





