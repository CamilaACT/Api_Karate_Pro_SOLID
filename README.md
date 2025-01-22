# API KaratePro

**API KaratePro** es una aplicación backend desarrollada con .NET 8, que proporciona funcionalidades para gestionar competencias de karate. La API permite la gestión de usuarios, peleas, rivales, técnicas y puntuaciones en un entorno seguro y eficiente.

## **Principios SOLID Aplicados**

### **1. Principio de Responsabilidad Única (SRP)**
- Separé la lógica de negocio y el acceso a datos:
  - **`InformeService`** maneja la lógica de negocio.
  - **`InformeDAO`** se encarga exclusivamente del acceso a datos.

### **2. Principio de Inversión de Dependencias (DIP)**
- Creé la interfaz **`IInformeDAO`** para abstraer el acceso a datos.
- **`InformeService`** depende de esta interfaz en lugar de una implementación concreta.

---

## **Patrones de Diseño Implementados**

### **1. Singleton**
- **`ConexionSingleton`** asegura que solo haya una instancia de conexión a la base de datos.
- Todas las consultas reutilizan esta instancia, optimizando recursos.

### **2. Builder**
- **`CompetidorBuilder`** simplifica la creación de objetos `competidor_A_competidor` paso a paso.
- Facilita la configuración de propiedades de forma legible y extensible.

### **3. Repository**
- **`CompetenciaRepository`** encapsula consultas complejas a la base de datos.
- Centraliza el acceso a datos y evita que la lógica de negocio interactúe directamente con la base de datos.

---
### Controladores expuestos:

#### **ClubController**

1. **GET `/api/Club/consultaTodo`**  
   Devuelve la lista completa de todos los clubes registrados.
   - **Parámetros**: 
     - Ninguno.
   - **Respuesta**: 
     - Objeto `Respuesta` que incluye la lista de clubes.

2. **PUT `/api/Club/actualizar`**  
   Actualiza la información de un club existente.
   - **Parámetros**: 
     - `club`: Objeto `club_A_club` con la información del club a actualizar.
   - **Respuesta**: 
     - Objeto `Respuesta` que indica el éxito o fallo de la actualización.

3. **POST `/api/Club/grabar`**  
   Registra un nuevo club en la base de datos.
   - **Parámetros**: 
     - `club`: Objeto `club_A_club` con la información del nuevo club.
   - **Respuesta**: 
     - Objeto `Respuesta` que indica el éxito o fallo del registro.

4. **DELETE `/api/Club/eliminar/{clu_id}`**  
   Elimina un club específico por su ID.
   - **Parámetros**: 
     - `clu_id`: ID del club a eliminar.
   - **Respuesta**: 
     - Objeto `Respuesta` que indica el éxito o fallo de la eliminación.

#### **CompetenciaController**

1. **GET `/api/Competencia/consultaTodo`**  
   Devuelve la lista completa de todas las competencias registradas.
   - **Parámetros**: 
     - Ninguno.
   - **Respuesta**: 
     - Objeto `Respuesta` que incluye la lista de competencias.

2. **PUT `/api/Competencia/actualizar`**  
   Actualiza la información de una competencia existente.
   - **Parámetros**: 
     - `competencia`: Objeto `competencia_A_competencia` con la información de la competencia a actualizar.
   - **Respuesta**: 
     - Objeto `Respuesta` que indica el éxito o fallo de la actualización.

3. **POST `/api/Competencia/grabar`**  
   Registra una nueva competencia en la base de datos.
   - **Parámetros**: 
     - `competencia`: Objeto `competencia_A_competencia` con la información de la nueva competencia.
   - **Respuesta**: 
     - Objeto `Respuesta` que indica el éxito o fallo del registro.

4. **DELETE `/api/Competencia/eliminar/{com_id}`**  
   Elimina una competencia específica por su ID.
   - **Parámetros**: 
     - `com_id`: ID de la competencia a eliminar.
   - **Respuesta**: 
     - Objeto `Respuesta` que indica el éxito o fallo de la eliminación.
### Controladores expuestos:

#### **CompetidorController**

1. **GET `/api/Competidor/consultaTodo`**  
   Devuelve la lista completa de todos los competidores registrados.
   - **Parámetros**: 
     - Ninguno.
   - **Respuesta**: 
     - Objeto `Respuesta` que incluye la lista de competidores.

2. **PUT `/api/Competidor/actualizar`**  
   Actualiza la información de un competidor existente.
   - **Parámetros**: 
     - `competidor`: Objeto `competidor_A_competidor` con la información del competidor a actualizar.
   - **Respuesta**: 
     - Objeto `Respuesta` que indica el éxito o fallo de la actualización.

3. **POST `/api/Competidor/grabar`**  
   Registra un nuevo competidor en la base de datos.
   - **Parámetros**: 
     - `competidor`: Objeto `competidor_A_competidor` con la información del nuevo competidor.
   - **Respuesta**: 
     - Objeto `Respuesta` que indica el éxito o fallo del registro.

4. **DELETE `/api/Competidor/eliminar/{cmp_id}`**  
   Elimina un competidor específico por su ID.
   - **Parámetros**: 
     - `cmp_id`: ID del competidor a eliminar.
   - **Respuesta**: 
     - Objeto `Respuesta` que indica el éxito o fallo de la eliminación.

#### **LoginController**

1. **POST `/api/Login/registrarse`**  
   Registra un nuevo usuario en la plataforma encriptando la contraseña utilizando SHA256.
   - **Parámetros**: 
     - `usaurio1`: Objeto `usuario_A_usuario` con la información del usuario a registrar.
   - **Respuesta**: 
     - Objeto `Respuesta` que indica el éxito o fallo del registro.

2. **POST `/api/Login/inicioSesion`**  
   Inicia sesión para un usuario existente, valida las credenciales y devuelve un token JWT en caso de éxito.
   - **Parámetros**: 
     - `log`: Objeto `Login` con las credenciales de acceso (usuario y contraseña).
   - **Respuesta**: 
     - Objeto `Respuesta` que incluye un token JWT para el usuario.

3. **GET `/api/Login/validarToken`**  
   Valida si el token JWT proporcionado es válido.
   - **Parámetros**: 
     - `token`: El token JWT que se quiere validar.
   - **Respuesta**: 
     - Objeto `Respuesta` que indica si el token es válido o no.
### Controladores expuestos:

#### **PeleaController**

1. **GET `/api/Pelea/consultaTodo`**  
   Devuelve la lista completa de todas las peleas registradas.
   - **Parámetros**: Ninguno.
   - **Respuesta**: Objeto `Respuesta` con la lista de peleas.

2. **GET `/api/Pelea/consultaRivalesID/{pel_id}`**  
   Consulta los detalles de los rivales en una pelea específica por su ID.
   - **Parámetros**: `pel_id` (ID de la pelea).
   - **Respuesta**: Objeto `Respuesta` con los detalles de los rivales.

3. **PUT `/api/Pelea/actualizar`**  
   Actualiza la información de una pelea existente.
   - **Parámetros**: Objeto `pelea_A_pelea` con los datos de la pelea.
   - **Respuesta**: Objeto `Respuesta` que indica el éxito o fallo de la actualización.

4. **POST `/api/Pelea/grabar`**  
   Registra una nueva pelea en la base de datos.
   - **Parámetros**: Objeto `pelea_A_pelea` con los datos de la pelea.
   - **Respuesta**: Objeto `Respuesta` que indica el éxito o fallo del registro.

5. **DELETE `/api/Pelea/eliminar/{pel_id}`**  
   Elimina una pelea específica por su ID.
   - **Parámetros**: `pel_id` (ID de la pelea).
   - **Respuesta**: Objeto `Respuesta` que indica el éxito o fallo de la eliminación.

#### **PuntuacionController**

1. **GET `/api/Puntuacion/consultaPuntosPorPelID/{pel_id}`**  
   Consulta las puntuaciones de una pelea específica por su ID.
   - **Parámetros**: `pel_id` (ID de la pelea).
   - **Respuesta**: Objeto `Respuesta` con las puntuaciones de la pelea.

2. **POST `/api/Puntuacion/grabar`**  
   Registra una nueva puntuación en la base de datos.
   - **Parámetros**: Objeto `puntuacion_A_puntuacion` con los datos de la puntuación.
   - **Respuesta**: Objeto `Respuesta` que indica el éxito o fallo del registro.

3. **DELETE `/api/Puntuacion/eliminar/{pun_id}`**  
   Elimina una puntuación específica por su ID.
   - **Parámetros**: `pun_id` (ID de la puntuación).
   - **Respuesta**: Objeto `Respuesta` que indica el éxito o fallo de la eliminación.

#### **RangoController**

1. **GET `/api/Rango/consultaTodo`**  
   Devuelve la lista completa de todos los rangos registrados.
   - **Parámetros**: Ninguno.
   - **Respuesta**: Objeto `Respuesta` con la lista de rangos.

2. **PUT `/api/Rango/actualizar`**  
   Actualiza la información de un rango existente.
   - **Parámetros**: Objeto `rango_A_rango` con los datos del rango.
   - **Respuesta**: Objeto `Respuesta` que indica el éxito o fallo de la actualización.

3. **POST `/api/Rango/grabar`**  
   Registra un nuevo rango en la base de datos.
   - **Parámetros**: Objeto `rango_A_rango` con los datos del rango.
   - **Respuesta**: Objeto `Respuesta` que indica el éxito o fallo del registro.

4. **DELETE `/api/Rango/eliminar/{ran_id}`**  
   Elimina un rango específico por su ID.
   - **Parámetros**: `ran_id` (ID del rango).
   - **Respuesta**: Objeto `Respuesta` que indica el éxito o fallo de la eliminación.

#### **RolController**

1. **GET `/api/Rol/consultaTodo`**  
   Devuelve la lista completa de todos los roles registrados.
   - **Parámetros**: Ninguno.
   - **Respuesta**: Objeto `Respuesta` con la lista de roles.

2. **PUT `/api/Rol/actualizar`**  
   Actualiza la información de un rol existente.
   - **Parámetros**: Objeto `rol_A_rol` con los datos del rol.
   - **Respuesta**: Objeto `Respuesta` que indica el éxito o fallo de la actualización.

3. **POST `/api/Rol/grabar`**  
   Registra un nuevo rol en la base de datos.
   - **Parámetros**: Objeto `rol_A_rol` con los datos del rol.
   - **Respuesta**: Objeto `Respuesta` que indica el éxito o fallo del registro.

4. **DELETE `/api/Rol/eliminar/{rol_id}`**  
   Elimina un rol específico por su ID.
   - **Parámetros**: `rol_id` (ID del rol).
   - **Respuesta**: Objeto `Respuesta` que indica el éxito o fallo de la eliminación.

#### **TecnicaController**

1. **GET `/api/Tecnica/consultaTodo`**  
   Devuelve la lista completa de todas las técnicas registradas.
   - **Parámetros**: Ninguno.
   - **Respuesta**: Objeto `Respuesta` con la lista de técnicas.

2. **PUT `/api/Tecnica/actualizar`**  
   Actualiza la información de una técnica existente.
   - **Parámetros**: Objeto `tecnica_A_tecnica` con los datos de la técnica.
   - **Respuesta**: Objeto `Respuesta` que indica el éxito o fallo de la actualización.

3. **POST `/api/Tecnica/grabar`**  
   Registra una nueva técnica en la base de datos.
   - **Parámetros**: Objeto `tecnica_A_tecnica` con los datos de la técnica.
   - **Respuesta**: Objeto `Respuesta` que indica el éxito o fallo del registro.

4. **DELETE `/api/Tecnica/eliminar/{tec_id}`**  
   Elimina una técnica específica por su ID.
   - **Parámetros**: `tec_id` (ID de la técnica).
   - **Respuesta**: Objeto `Respuesta` que indica el éxito o fallo de la eliminación.

#### **UsuarioController**

1. **GET `/api/Usuario/consultaTodo`**  
   Devuelve la lista completa de todos los usuarios registrados.
   - **Parámetros**: Ninguno.
   - **Respuesta**: Objeto `Respuesta` con la lista de usuarios.

2. **PUT `/api/Usuario/actualizar`**  
   Actualiza la información de un usuario existente encriptando su contraseña.
   - **Parámetros**: Objeto `usuario_A_usuario` con los datos del usuario.
   - **Respuesta**: Objeto `Respuesta` que indica el éxito o fallo de la actualización.

3. **POST `/api/Usuario/grabar`**  
   Registra un nuevo usuario en la base de datos encriptando su contraseña.
   - **Parámetros**: Objeto `usuario_A_usuario` con los datos del usuario.
   - **Respuesta**: Objeto `Respuesta` que indica el éxito o fallo del registro.

4. **DELETE `/api/Usuario/eliminar/{us_id}`**  
   Elimina un usuario específico por su ID.
   - **Parámetros**: `us_id` (ID del usuario).
   - **Respuesta**: Objeto `Respuesta` que indica el éxito o fallo de la eliminación.
  
   - ### Objeto Respuesta

El objeto `Respuesta` es utilizado para estandarizar las respuestas de las operaciones en la API. Está compuesto por los siguientes campos:

- **`CodigoError`**: Un valor entero que indica si la operación fue exitosa o si ocurrió un error.
  - `-1`: Indica que la operación fue exitosa.
  - `1`: Indica que ocurrió un error en la operación.

- **`Message`**: Una cadena de texto que contiene un mensaje adicional sobre el resultado de la operación. Este mensaje puede describir el éxito o los detalles del error.

- **`Result`**: Un objeto que contiene el resultado de la operación realizada. Este campo es dinámico y puede variar dependiendo del tipo de operación:
  - Puede ser un objeto de usuario, una lista de elementos, o cualquier otro tipo de dato esperado como resultado de la operación.
  - Si la operación es de tipo "inicio de sesión", este campo puede incluir un token JWT.



## Características

- Autenticación y autorización mediante JWT.
- Gestión de competidores, rivales y peleas.
- Registro y consulta de técnicas y puntuaciones.
- Implementación de CORS para permitir solicitudes desde diferentes orígenes.
- Respuesta estructurada con manejo de errores.

## Tecnologías utilizadas

- **.NET 8**: Framework principal para la construcción de la API.
- **SQL Server**: Base de datos utilizada para el almacenamiento de la información.
- **Entity Framework Core**: ORM para facilitar la comunicación con la base de datos.
- **JWT (JSON Web Token)**: Seguridad y autenticación.
- **CORS**: Configuración para solicitudes desde diferentes orígenes.

## Instalación

1. **Clonar el repositorio**:
   ```bash
   git clone https://github.com/CamilaACT/Api_KaratePro.git
   cd Api_KaratePro
2. **Clonar el repositorio**:
   Configurar la base de datos: Configura la cadena de conexión en appsettings.json para que coincida con tu entorno de SQL Server.
