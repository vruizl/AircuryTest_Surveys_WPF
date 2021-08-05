# AircuryTest_Surveys_WPF

# Modo de ejecución
Para ejecutar este proyecto es necesario ir a la carpeta AircuryTest_Surveys_WPF\bin\Debug y ejecutar AircuryTest_Surveys_WPF.exe.
Al estar los datos mockeados no es necesario realizar ninguna modificación en el archivo .config para poder comunicar con un WS ni nada similar.

# Explicación de la solución
He decidido utilizar WPF con apoyo de la libreria Prism que permite desarrollar formularios con patrón MVVM de una manera más sencilla que si se tuviera que hacer de forma manual.
WPF/PRISM no es algo que controle al 100% ya que lo que he hecho ha sido de forma "no profesional", por ello pueden existir detalles que no me ha dado tiempo a contemplar, pero creo que se ve claramente la esencia del desarrollo y la modularidad e independencia de los componentes.
Además de utilizar WPF/PRISM he decidido utilizar el desarrollo por módulos para que éstos, en un momento dado, pudieran ser reutilizados así pues la solución está conformada por proyectos independientes según la función a ejercer (Diseño de las vistas a mostrar, definición de clases, definición de comunicaciones...).

En el proyecto AircuryTest_Surveys_WPF es donde se ha creado la ventana principal donde, a lo largo de la ejecución, se irán insertando los diferentes controles de usuario mediante las opciones de navegación que proporciona Prism.
AircuryTest_Surveys_WPF.Business contiene las clases que nos permiten recoger los datos de las encuestas.
AircuryTest_Surveys_WPF.Core contiene una clase para definir los nombres de las regiones en las que se divide la ventana principal, este desarrollo es más sencillo y puede no tener sentido pero si se quisiera desarrollar algo más grande sería interesante tenerlo así.
AircuryTest_Surveys_WPF.Services contiene las clases que permitirían comunicar con WS/API... 
AircuryTest_Surveys_WPF.Interfaces contiene la definición de interfaces
Modules es la carpeta que contiene la definición de los módulos que se cargarán en la ventana principal. Para cada uno se ha creado un proyecto independiente y se definen la vista a mostar y el VM asociado.


