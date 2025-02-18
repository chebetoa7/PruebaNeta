Estructura del Proyecto
El proyecto está organizado de la siguiente manera:

Carpetas Principales
Models:

Contiene la clase UserModel, que representa la estructura de los datos del usuario obtenidos de la API.

Services:

Incluye UserService, que se encarga de realizar la solicitud HTTP a la API y deserializar los datos JSON en objetos UserModel.

ViewModels:

Contiene ListUserViewModel, que maneja la lógica de la lista de usuarios y la navegación a la pantalla de detalles.

Views:

Incluye las páginas de la aplicación:

ListUserPage: Muestra la lista de usuarios.

UserDetailsPage: Muestra los detalles completos de un usuario seleccionado.

Utils:

(Opcional) Puede contener utilidades o constantes globales, como la URL de la API.

Archivos Clave
MauiProgram.cs: Configura la aplicación y registra los servicios, ViewModels y páginas en el contenedor de dependencias.

App.xaml.cs: Define la página principal de la aplicación.

Funcionalidades Principales
Lista de Usuarios:

La aplicación obtiene una lista de usuarios desde la API y los muestra en un CollectionView.

Cada usuario se presenta en un Border con un diseño personalizado que incluye su nombre, correo electrónico y teléfono.

Selección de Usuarios:

Al hacer clic en un usuario, la aplicación navega a una segunda pantalla donde se muestran los detalles completos del usuario seleccionado, incluyendo su nombre, correo, teléfono y dirección.

Navegación entre Pantallas:

La navegación se implementó utilizando Navigation.PushAsync, lo que permite una transición fluida entre la lista de usuarios y la pantalla de detalles.

Gestos y Eventos:

Para manejar la selección de usuarios, se utilizó un TapGestureRecognizer en cada Border, lo que permite detectar clics y obtener el Id del usuario seleccionado.

Cómo Ejecutar el Proyecto
Requisitos Previos
.NET 7 SDK o superior.

Visual Studio 2022 con la carga de trabajo .NET MAUI instalada.

Un emulador o dispositivo físico configurado para ejecutar aplicaciones .NET MAUI.

Pasos para Ejecutar el Proyecto
Clona el repositorio o descarga el código fuente del proyecto.

bash
Copy
git clone [URL del repositorio]
Abre el proyecto en Visual Studio 2022.

Selecciona el entorno de ejecución deseado (Android, iOS, Windows, etc.) en la barra de herramientas de Visual Studio.

Compila y ejecuta el proyecto presionando F5 o haciendo clic en el botón Iniciar.

La aplicación se abrirá en el emulador o dispositivo seleccionado, mostrando la lista de usuarios.

Tecnologías Utilizadas
.NET MAUI: Para el desarrollo de la interfaz de usuario multiplataforma.

HttpClient: Para consumir la API REST.

JSON Serialization: Para deserializar los datos JSON en objetos C#.

CommunityToolkit.Mvvm: Para implementar el patrón MVVM y simplificar la notificación de cambios en la interfaz.
