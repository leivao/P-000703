# P-000703
1 Datos generales
- Prueba de Seguros
- Fecha recepción: 20 de agosto de 2019 a las 15:02.
- Autor: Ing. José Alberto Leiva Obando, MBD, MBA

2 Documentación
- Se adjunta una breve documentación de la solución en la raíz del proyecto con el nombre P-000703_JoséAlbertoLeiva.pdf. 

3 Iniciar

- Crear la base de datos.

- Crear las estructuras (tablas y procedimientos) y cargar datos base.

-- 01_Esquema.sql: Tablas y procedimientos.
-- 02_Datos.sql: Carga de catálogos.
-- 03_Seguridad.sql: Creación de tablas y carga de datos para autenticación y autorización

- Actualizar las hileras de conexión.
- Ejecutar la solución.


4 Listado de control
- Mantenimientos incluidos:
o Pólizas.
o Pólizas por cliente.
- Para cumplir con la regla de negocio del porcentaje de cobertura contra el riesgo, se parametriza, a nivel del catálogo de riesgos, el máximo de cobertura soportado y en el mantenimiento se realiza la validación, de forma que se tiene un punto de acceso único y controlado. La misma validación puede agregarse en otras capas para evitar el viaje hasta BD, no obstante se recomienda volver a validar en BD para evitar omisiones de controles..
- Implementado con ASP.NET MVC.
- Se utiliza AngularJS para interfaz e invocación de servicios, así como Bootstrap para responsive.
- Se utiliza Bootstrap para que el sitio sea responsive.
- Los servicios para interacción con los componentes de datos se exponen por medio de ASP.NET Web API
- La interacción con la base de datos se realiza por medio de Entity Framework, con el enfoque Database First.
- Entity Framework implementa el Patrón Repositorio.
- El sitio tiene la opción de logueo por medio de usuario y contraseña para autenticar los usuarios.
- Para la autorización, se crearon roles y se asignaron a algunas de las vistas para que solo los usuarios con el rol correspondiente puedan ingresar
- Para la inyección de dependencias, se utilizan como parámetros entidades que se cargan desde la capa superior y se envían hasta la de datos para el procesamiento correspondiente.
- Se crea un proyecto de pruebas para verificar la regla de negocio acerca de la cobertura y el riesgo. Para cada riesgo se definió en base de datos el máximo de cobertura que permite. En caso de que el mismo sea sobrepasado, se retorna desde base de datos un código de advertencia (98) con el mensaje correspondiente.
