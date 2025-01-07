Universidad  Privada  de  Tacna    ![ref1]![ref2]![ref3]![ref4]![ref5]![ref6]![ref3]![ref7]![ref3]![ref8]

Facultad  de Ingeniería ![ref3]   ![ref6]![ref5]![ref9]![ref3]![ref10]

Escuela  Profesional  de  Ingeniería  de  Sistemas ![ref3]   ![ref11]![ref12]![ref5]![ref6]![ref3]![ref10]![ref3]![ref6]![ref5]![ref13]![ref3]![ref7]

“AÑO DEL BICENTENARIO  De JOSE FAUSTINO SANCHEZ CARRION” 

**FACULTAD DE INGENIERÍA**   

**ESCUELA PROFESIONAL DE INGENIERÍA DE SISTEMAS**   

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.014.png)

NOMBRE DEL TRABAJO: “Trabajo de Asignación N°01**”**  TEMA DEL TRABAJO*:* **“Avance FD03 - Diagramas”**  

**Integrantes:** 

|**Nº**  |**Código Universitario**  |**Apellidos y Nombres** |
| - | - | - |
|**1.-**  |**2017057528**  |**Ccalli Chata Joel Robert**  |
|**2.-** |**2018060915** |**Apaza Mamani Edward** |

**CURSO : “Programación Web II”** 

**SECCION : “A”**   

**DOCENTE**  **:**   **Ing. “Patrick Cuadros Quiroga”**  

**Tacna - Perú**  **2025** 

**Historias de Usuario: 10** 1.-Registrar Usuario 

2\.-Iniciar Sesión 

3\.-Actualizar Perfil 

4\.-Agregar Mascota 5.-Notificaciones de Vacunas 6.-Historial Médico de Mascota 7.-Agregar Veterinarias 8.-Eliminar Mascota 9.-Cambiar Contraseña 

10\.-Rol de Administrador 

**CA: Criterios de Aceptación en Orden 1. Registrar Usuario** 

**Criterios de Aceptación Funcionales** 

1. **CAF01: Validación de Campos** 

   Dado: El formulario de registro 

   Cuando: Se omite un campo obligatorio 

   Entonces: El sistema muestra un mensaje indicando el campo que falta. 

2. **CAF02: Validación de Correo Electrónico** 

   Dado: Un usuario nuevo 

   Cuando: Ingresa un correo no válido 

   Entonces: El sistema muestra un mensaje de error. 

3. **CAF03: Contraseña Segura** 

   Dado: Un usuario nuevo 

   Cuando: Ingresa una contraseña débil 

   Entonces: El sistema muestra un mensaje indicando los requisitos de seguridad. 

4. **CAF04: Verificación de Duplicados** 

   Dado: Un usuario nuevo 

   Cuando: Intenta registrar un correo ya existente 

   Entonces: El sistema informa que el correo ya está registrado. 

5. **CAF05: Confirmación de Registro** 

   Dado: Un usuario nuevo 

   Cuando: Completa correctamente el formulario 

   Entonces: El sistema envía un correo de confirmación. 

**Criterios de Aceptación No Funcionales** 

1. **CANF01: Seguridad de Contraseñas** 

   Las contraseñas deben almacenarse cifradas utilizando un algoritmo como bcrypt. 

2. **CANF02: Tiempo de Respuesta** 

   El registro debe completarse en menos de 3 segundos en condiciones normales. ![ref14]

**2. Iniciar Sesión** 

**Criterios de Aceptación Funcionales** 

1. **CAF01: Validación de Credenciales** 

   Dado: Un usuario registrado 

   Cuando: Ingresa un correo y contraseña válidos 

   Entonces: El sistema permite el acceso. 

2. **CAF02: Manejo de Errores** 

   Dado: Un usuario 

   Cuando: Ingresa credenciales incorrectas 

   Entonces: El sistema muestra un mensaje de error. 

3. **CAF03: Bloqueo por Intentos Fallidos** 

   Dado: Un usuario 

   Cuando: Se exceden 5 intentos fallidos de inicio de sesión 

   Entonces: El sistema bloquea la cuenta temporalmente. 

4. **CAF04: Recordar Sesión** 

   Dado: Un usuario 

   Cuando: Activa la opción "Recordar sesión" 

   Entonces: El sistema mantiene la sesión iniciada hasta que el usuario la cierre. 

5. **CAF05: Cierre Automático** 

   Dado: Un usuario 

   Cuando: No realiza actividades durante 15 minutos 

   Entonces: El sistema cierra la sesión automáticamente. 

**Criterios de Aceptación No Funcionales** 

1. **CANF01: Tiempo de Respuesta** 

   El inicio de sesión debe completarse en menos de 2 segundos. 

2. **CANF02: Seguridad de Sesión** 

   Las sesiones deben utilizar tokens seguros con expiración. ![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.016.png)

3. **Actualizar Perfil** 

**Criterios de Aceptación Funcionales** 

1. **CAF01: Validación de Datos** 

   Dado: El formulario de perfil 

   Cuando: Se ingresan datos inválidos 

   Entonces: El sistema muestra un mensaje indicando el error. 

2. **CAF02: Confirmación de Cambios** 

   Dado: Un usuario 

   Cuando: Actualiza correctamente su perfil 

   Entonces: El sistema confirma los cambios realizados. 

3. **CAF03: Verificación de Correo** 

   Dado: Un usuario 

   Cuando: Cambia su correo electrónico 

   Entonces: El sistema envía un correo para verificarlo. 

4. **CAF04: Mantener Sesión Activa** 

   Dado: Un usuario 

   Cuando: Actualiza su perfil 

   Entonces: La sesión permanece activa. 

5. **CAF05: Reversión de Cambios** 

   Dado: Un usuario 

   Cuando: Encuentra un error en los datos actualizados Entonces: El sistema permite revertir los cambios. 

**Criterios de Aceptación No Funcionales** 

1. **CANF01: Respuesta del Servidor** 

   Los cambios deben reflejarse en menos de 3 segundos. 

2. **CANF02: Compatibilidad de Navegadores** 

   La funcionalidad debe operar correctamente en Chrome, Firefox y Edge. ![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.017.png)

**4. Agregar Mascota** 

**Criterios de Aceptación Funcionales** 

1. **CAF01: Validación de Campos Obligatorios** Dado: El formulario de agregar mascota 

   Cuando: Falta un campo obligatorio 

   Entonces: El sistema muestra un mensaje de error. 

2. **CAF02: Registro Exitoso** 

   Dado: Un usuario 

   Cuando: Completa correctamente el formulario Entonces: La mascota se registra en su cuenta. 

3. **CAF03: Especies y Razas** 

   Dado: Un usuario 

   Cuando: Selecciona la especie de la mascota Entonces: El sistema muestra las razas disponibles. 

4. **CAF04: Fecha de Nacimiento** 

   Dado: Un usuario 

   Cuando: Ingresa una fecha inválida 

   Entonces: El sistema muestra un mensaje de error. 

5. **CAF05: Confirmación de Registro** 

   Dado: Un usuario 

   Cuando: Agrega una mascota correctamente Entonces: El sistema confirma el registro exitoso. 

**Criterios de Aceptación No Funcionales** 

1. **CANF01: Tiempo de Respuesta** 

   El registro de la mascota debe completarse en menos de 3 segundos. 

2. **CANF02: Seguridad de Datos** 

   Los datos de la mascota deben almacenarse de manera segura para evitar accesos no autorizados. 

**5. Notificaciones de Vacunas** 

**Criterios de Aceptación Funcionales** 

1. **CAF01: Registro de Vacunas** 

   Dado: Una mascota registrada 

   Cuando: El usuario añade una vacuna con fecha 

   Entonces: El sistema programa una notificación de recordatorio. 

2. **CAF02: Configuración de Notificaciones** 

   Dado: Un usuario 

   Cuando: Accede a la configuración de notificaciones 

   Entonces: Puede personalizar los tiempos de aviso antes de las vacunas. 

3. **CAF03: Notificación Automática** 

   Dado: Una vacuna programada 

   Cuando: Llega la fecha de recordatorio 

   Entonces: El sistema envía una notificación al usuario. 

4. **CAF04: Varios Canales** 

   Dado: Un usuario 

   Cuando: Configura las notificaciones 

   Entonces: Puede elegir entre correo electrónico, SMS o notificaciones push. 

5. **CAF05: Confirmación de Recepción** 

   Dado: Una notificación enviada 

   Cuando: El usuario interactúa con ella 

   Entonces: El sistema registra la confirmación de recepción. 

**Criterios de Aceptación No Funcionales** 

1. **CANF01: Frecuencia de Envío** 

   Las notificaciones deben enviarse con una tasa máxima de 2 por segundo para evitar sobrecargas. 

2. **CANF02: Disponibilidad del Sistema** 

   Las notificaciones deben funcionar con un 99.9% de disponibilidad anual. ![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.018.png)

**6. Historial Médico de Mascota** 

**Criterios de Aceptación Funcionales** 

1. **CAF01: Visualización de Historial** 

   Dado: Una mascota seleccionada 

   Cuando: El usuario accede a su perfil 

   Entonces: El sistema muestra el historial médico completo. 

2. **CAF02: Registro de Consultas** 

   Dado: Una mascota 

   Cuando: El usuario registra una consulta médica 

   Entonces: El sistema guarda los detalles en el historial. 

3. **CAF03: Filtros de Búsqueda** 

   Dado: Un historial médico extenso 

   Cuando: El usuario aplica filtros por fecha o tipo de evento 

   Entonces: El sistema muestra los resultados relevantes. 

4. **CAF04: Edición de Eventos** 

   Dado: Un usuario 

   Cuando: Desea corregir información de un evento médico 

   Entonces: El sistema permite la edición con restricciones de permisos. 

5. **CAF05: Exportar Historial** 

   Dado: Un usuario 

   Cuando: Solicita exportar el historial 

   Entonces: El sistema genera un archivo en formato PDF o Excel. 

**Criterios de Aceptación No Funcionales** 

1. **CANF01: Escalabilidad** 

   El historial debe manejar hasta 1,000 registros por mascota sin disminuir el rendimiento. 

2. **CANF02: Seguridad de Datos** 

   Los historiales deben estar protegidos con cifrado en tránsito y en reposo. ![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.019.png)

**7. Agregar Veterinarias** 

**Criterios de Aceptación Funcionales** 

1. **CAF01: Validación de Datos** 

   Dado: El formulario de registro de veterinarias 

   Cuando: Faltan datos obligatorios 

   Entonces: El sistema muestra un mensaje de error. 

2. **CAF02: Registro Exitoso** 

   Dado: Un usuario administrador 

   Cuando: Completa el formulario correctamente 

   Entonces: La veterinaria se registra en el sistema. 

3. **CAF03: Geolocalización** 

   Dado: Una veterinaria registrada 

   Cuando: Se añaden coordenadas geográficas 

   Entonces: El sistema las asocia correctamente para búsquedas. 

4. **CAF04: Confirmación de Registro** 

   Dado: Un usuario administrador 

   Cuando: Registra una veterinaria 

   Entonces: El sistema muestra un mensaje de éxito. 

5. **CAF05: Gestión de Veterinarias** 

   Dado: Una veterinaria registrada 

   Cuando: El usuario desea actualizar información 

   Entonces: El sistema permite realizar modificaciones. 

**Criterios de Aceptación No Funcionales** 

1. **CANF01: Respuesta del Servidor** 

   La veterinaria debe registrarse en menos de 2 segundos. 

2. **CANF02: Accesibilidad** 

   La funcionalidad debe ser accesible desde dispositivos móviles y de escritorio. ![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.020.png)

**8. Eliminar Mascota** 

**Criterios de Aceptación Funcionales** 

1. **CAF01: Confirmación de Eliminación** 

   Dado: Un usuario 

   Cuando: Solicita eliminar una mascota 

   Entonces: El sistema solicita confirmación antes de proceder. 

2. **CAF02: Validación de Permisos** 

   Dado: Un usuario 

   Cuando: Intenta eliminar una mascota 

   Entonces: El sistema valida que sea el propietario de la cuenta. 

3. **CAF03: Eliminación Exitosa** 

   Dado: Una mascota registrada 

   Cuando: El usuario confirma la eliminación 

   Entonces: La mascota se elimina del sistema. 

4. **CAF04: Historial Asociado** 

   Dado: Una mascota eliminada 

   Cuando: Se intenta acceder a su historial 

   Entonces: El sistema informa que la mascota ya no está disponible. 

5. **CAF05: Cancelación de Notificaciones** 

   Dado: Una mascota eliminada 

   Cuando: Tenía vacunas programadas 

   Entonces: El sistema cancela las notificaciones asociadas. 

**Criterios de Aceptación No Funcionales** 

1. **CANF01: Persistencia** 

   La eliminación debe reflejarse en la base de datos en menos de 3 segundos. 

2. **CANF02: Seguridad de Permisos** 

   Solo usuarios autenticados y autorizados pueden eliminar mascotas. ![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.021.png)

**9. Cambiar Contraseña** 

**Criterios de Aceptación Funcionales** 

1. **CAF01: Validación de Contraseña Actual** 

   Dado: Un usuario 

   Cuando: Ingresa su contraseña actual incorrecta 

   Entonces: El sistema muestra un mensaje de error. 

2. **CAF02: Validación de Nueva Contraseña** 

   Dado: Un usuario 

   Cuando: Ingresa una nueva contraseña que no cumple con los requisitos Entonces: El sistema muestra un mensaje indicando los errores. 

3. **CAF03: Confirmación de Cambio** 

   Dado: Un usuario 

   Cuando: Cambia su contraseña exitosamente 

   Entonces: El sistema confirma el cambio. 

4. **CAF04: Notificación de Cambio** 

   Dado: Un usuario 

   Cuando: Cambia su contraseña 

   Entonces: El sistema envía una notificación al correo asociado. 

5. **CAF05: Expiración de Sesiones** 

   Dado: Un usuario 

   Cuando: Cambia su contraseña 

   Entonces: Todas las sesiones activas se cierran automáticamente. 

**Criterios de Aceptación No Funcionales** 

1. **CANF01: Seguridad de Contraseñas** 

   Las contraseñas deben encriptarse antes de ser almacenadas. 

2. **CANF02: Tiempo de Respuesta** 

   El cambio de contraseña debe reflejarse en menos de 3 segundos. ![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.022.png)

**10. Rol de Administrador** 

**Criterios de Aceptación Funcionales** 

1. **CAF01: Gestión de Usuarios** 

   Dado: Un administrador 

   Cuando: Accede al panel de usuarios 

   Entonces: Puede ver, editar o eliminar usuarios. 

2. **CAF02: Gestión de Veterinarias** 

   Dado: Un administrador 

   Cuando: Accede al panel de veterinarias 

   Entonces: Puede agregar, editar o eliminar veterinarias. 

3. **CAF03: Visualización de Reportes** 

   Dado: Un administrador 

   Cuando: Accede a la sección de reportes 

   Entonces: Puede generar reportes de usuarios y mascotas. 

4. **CAF04: Gestión de Roles** 

   Dado: Un administrador 

   Cuando: Accede a la configuración de roles 

   Entonces: Puede asignar o cambiar permisos de usuarios. 

5. **CAF05: Registro de Actividades** 

   Dado: Un administrador 

   Cuando: Realiza cambios en el sistema 

   Entonces: El sistema registra las acciones para auditoría. 

**Criterios de Aceptación No Funcionales** 

1. **CANF01: Escalabilidad** 

   El sistema debe manejar hasta 1,000 administradores concurrentes sin degradación. 

2. **CANF02: Seguridad** 

   El acceso a funciones administrativas debe estar protegido por autenticación de dos factores (2FA). 

DIAGRAMA DE CASO DE USO: 

1. **Registrar Usuario** 

plantuml 

Copiar código 

@startuml 

actor Usuario 

Usuario --> (Registrar Usuario) 

(Registrar Usuario) --> (Validar datos del formulario) (Registrar Usuario) --> (Enviar correo de confirmación) (Registrar Usuario) --> (Almacenar datos cifrados) @enduml ![ref15]

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.024.png)

2. **Iniciar Sesión** 

plantuml 

Copiar código 

@startuml 

actor Usuario 

Usuario --> (Iniciar Sesión) 

(Iniciar Sesión) --> (Validar credenciales) 

(Iniciar Sesión) --> (Mostrar error en caso de fallas) (Iniciar Sesión) --> (Generar sesión segura) 

@enduml ![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.025.png)

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.026.png)

3. **Actualizar Perfil** 

plantuml 

Copiar código 

@startuml 

actor Usuario 

Usuario --> (Actualizar Perfil) 

(Actualizar Perfil) --> (Validar datos ingresados) (Actualizar Perfil) --> (Guardar cambios) (Actualizar Perfil) --> (Confirmar actualizaciones) @enduml ![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.027.png)

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.028.png)

4. **Agregar Mascota** 

plantuml 

Copiar código 

@startuml 

actor Usuario 

Usuario --> (Agregar Mascota) 

(Agregar Mascota) --> (Validar datos de la mascota) (Agregar Mascota) --> (Registrar mascota en el sistema) (Agregar Mascota) --> (Confirmar registro) 

@enduml ![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.029.png)

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.030.png)

5. **Notificaciones de Vacunas** 

plantuml 

Universidad  Privada  de  Tacna    ![ref1]![ref2]![ref3]![ref3]![ref4]![ref5]![ref6]![ref3]![ref7]![ref8]

Facultad  de Ingeniería ![ref3]   ![ref9]![ref5]![ref6]![ref10]![ref3]

Escuela  Profesional  de  Ingeniería  de  Sistemas ![ref3]   ![ref11]![ref3]![ref13]![ref5]![ref6]![ref3]![ref7]![ref3]![ref6]![ref5]![ref12]![ref10]

Copiar código 

@startuml 

actor Usuario 

Usuario --> (Notificaciones de Vacunas) 

(Notificaciones de Vacunas) --> (Registrar fechas de vacunación) (Notificaciones de Vacunas) --> (Configurar recordatorios) (Notificaciones de Vacunas) --> (Enviar notificaciones automáticas) @enduml ![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.031.png)

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.032.png)

6. **Historial Médico de Mascota** 

plantuml 

Copiar código 

@startuml 

actor Usuario 

Usuario --> (Historial Médico de Mascota) 

(Historial Médico de Mascota) --> (Visualizar historial médico) (Historial Médico de Mascota) --> (Registrar consultas médicas) (Historial Médico de Mascota) --> (Filtrar eventos médicos) (Historial Médico de Mascota) --> (Exportar historial) 

@enduml ![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.033.png)![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.034.png)

7. **Agregar Veterinarias** 

plantuml 

Copiar código @startuml 

actor Administrador 

Administrador --> (Agregar Veterinarias) 

(Agregar Veterinarias) --> (Validar datos de la veterinaria) (Agregar Veterinarias) --> (Registrar veterinaria en el sistema) (Agregar Veterinarias) --> (Asociar ubicación geográfica) (Agregar Veterinarias) --> (Confirmar registro) 

@enduml ![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.035.png)

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.036.png)

8. **Eliminar Mascota** 

plantuml 

Copiar código 

@startuml 

actor Usuario 

Usuario --> (Eliminar Mascota) 

(Eliminar Mascota) --> (Validar permisos) 

(Eliminar Mascota) --> (Solicitar confirmación) 

(Eliminar Mascota) --> (Eliminar datos de la mascota) (Eliminar Mascota) --> (Cancelar notificaciones asociadas) @enduml ![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.037.png)

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.038.png)

9. **Cambiar Contraseña** 

plantuml 

Copiar código 

@startuml 

actor Usuario 

Usuario --> (Cambiar Contraseña) 

(Cambiar Contraseña) --> (Validar contraseña actual) (Cambiar Contraseña) --> (Validar nueva contraseña) (Cambiar Contraseña) --> (Actualizar contraseña) (Cambiar Contraseña) --> (Cerrar sesiones activas) @enduml 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.039.png)

10. **Rol de Administrador** 

plantuml 

Copiar código 

@startuml 

actor Administrador 

Administrador --> (Gestionar Usuarios) Administrador --> (Gestionar Veterinarias) Administrador --> (Visualizar Reportes) Administrador --> (Configurar Roles) Administrador --> (Auditar Actividades) @enduml 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.040.png)

DIAGRAMAS DE SECUENCIA 

1. **Registrar Usuario** 

**Diagrama de Caso de Uso** 

mermaid 

Copiar código 

usecaseDiagram 

`    `actor Usuario 

`    `Usuario --> (Registrar Usuario) 

`    `(Registrar Usuario) --> (Validar datos del formulario)     (Registrar Usuario) --> (Enviar correo de confirmación)     (Registrar Usuario) --> (Almacenar datos cifrados) 

**Diagramas de Secuencia CAF01: Validación de Campos** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Envía formulario con campos obligatorios incompletos 

`    `Sistema-->>Usuario: Retorna mensaje de error indicando los campos faltantes 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.041.png)

**CAF02: Validación de Correo Electrónico** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Ingresa correo electrónico no válido     Sistema-->>Usuario: Muestra mensaje de error 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.042.png)

**CAF03: Contraseña Segura** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Ingresa una contraseña débil 

`    `Sistema-->>Usuario: Solicita contraseña que cumpla con requisitos de seguridad 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.043.png)

**CAF04: Verificación de Duplicados** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Intenta registrar un correo ya existente 

`    `Sistema-->>Usuario: Retorna mensaje indicando que el correo ya está registrado 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.044.png)

**CAF05: Confirmación de Registro** 

mermaid 

Copiar código sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Envía formulario válido 

`    `Sistema-->>Usuario: Muestra mensaje confirmando el registro exitoso 

`    `Sistema-->>Usuario: Envía correo de confirmación 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.045.png)

**CANF01: Seguridad de Contraseñas** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Sistema 

`    `Sistema->>Sistema: Cifra las contraseñas utilizando bcrypt 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.046.png)

**CANF02: Tiempo de Respuesta** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Completa el registro 

`    `Sistema-->>Usuario: Confirma el registro en menos de 3 segundos ![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.047.png)

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.048.png)

2. **Iniciar Sesión** 

**Diagrama de Caso de Uso** 

mermaid 

Copiar código 

usecaseDiagram 

`    `actor Usuario 

`    `Usuario --> (Iniciar Sesión) 

`    `(Iniciar Sesión) --> (Validar credenciales) 

`    `(Iniciar Sesión) --> (Mostrar error en caso de fallas)     (Iniciar Sesión) --> (Generar sesión segura) 

**Diagramas de Secuencia** 

**CAF01: Validación de Credenciales** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Ingresa correo y contraseña válidos     Sistema-->>Usuario: Permite acceso al sistema 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.049.png)

**CAF02: Manejo de Errores** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Ingresa credenciales incorrectas     Sistema-->>Usuario: Muestra mensaje de error 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.050.png)

**CAF03: Bloqueo por Intentos Fallidos** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `loop Hasta 5 intentos 

`        `Usuario->>Sistema: Ingresa credenciales incorrectas         Sistema-->>Usuario: Muestra mensaje de error 

`    `end 

`    `Sistema-->>Usuario: Bloquea la cuenta temporalmente 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.051.png)

**CAF04: Recordar Sesión** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Activa opción "Recordar sesión"     Sistema-->>Usuario: Mantiene la sesión iniciada 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.052.png)

**CAF05: Cierre Automático** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: No realiza actividad por 15 minutos     Sistema-->>Usuario: Cierra sesión automáticamente 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.053.png)

**CANF01: Tiempo de Respuesta** 

mermaid 

Copiar código sequenceDiagram 

`    `participant Usuario 

participant Sistema 

Usuario->>Sistema: Solicita iniciar sesión Sistema-->>Usuario: Responde en menos de 2 segundos 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.054.png)

**CANF02: Seguridad de Sesión** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Sistema 

`    `Sistema->>Sistema: Genera token seguro con expiración 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.055.png)

3. **Actualizar Perfil** 

**Diagrama de Caso de Uso** 

mermaid 

Copiar código 

usecaseDiagram 

`    `actor Usuario 

`    `Usuario --> (Actualizar Perfil) 

`    `(Actualizar Perfil) --> (Validar datos ingresados)     (Actualizar Perfil) --> (Guardar cambios) 

`    `(Actualizar Perfil) --> (Confirmar actualizaciones) 

**Diagramas de Secuencia CAF01: Validación de Datos** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Ingresa datos inválidos 

`    `Sistema-->>Usuario: Retorna mensaje indicando los errores 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.056.png)

**CAF02: Confirmación de Cambios** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Actualiza su perfil 

`    `Sistema-->>Usuario: Confirma que los cambios fueron realizados exitosamente ![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.057.png)

**CAF03: Verificación de Correo** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Cambia su correo electrónico     Sistema-->>Usuario: Envía correo de verificación 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.058.png)

**CAF04: Mantener Sesión Activa** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Realiza actualizaciones en su perfil 

`    `Sistema-->>Usuario: Mantiene la sesión activa durante el proceso 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.059.png)

**CAF05: Reversión de Cambios** 

mermaid 

Copiar código sequenceDiagram 

`    `participant Usuario     participant Sistema 

Usuario->>Sistema: Solicita deshacer cambios en su perfil Sistema-->>Usuario: Reversa los cambios y confirma la acción 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.060.png)

**CANF01: Respuesta del Servidor** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Solicita actualizar su perfil 

`    `Sistema-->>Usuario: Responde en menos de 3 segundos ![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.061.png)

**CANF02: Compatibilidad de Navegadores** 

mermaid 

Copiar código sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Accede desde un navegador compatible 

`    `Sistema-->>Usuario: Funciona correctamente en Chrome, Firefox y Edge 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.062.png)

4. **Agregar Mascota** 

**Diagrama de Caso de Uso** 

mermaid 

Copiar código 

usecaseDiagram 

`    `actor Usuario 

`    `Usuario --> (Agregar Mascota) 

`    `(Agregar Mascota) --> (Validar datos de la mascota) 

`    `(Agregar Mascota) --> (Registrar mascota en el sistema)     (Agregar Mascota) --> (Confirmar registro) 

**Diagramas de Secuencia** 

**CAF01: Validación de Campos Obligatorios** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Envía formulario con campos incompletos 

`    `Sistema-->>Usuario: Muestra mensaje indicando los campos faltantes 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.063.png)

**CAF02: Registro Exitoso** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Completa el formulario con datos válidos 

`    `Sistema-->>Usuario: Registra la mascota y confirma el registro 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.064.png)

**CAF03: Especies y Razas** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Selecciona especie de mascota 

`    `Sistema-->>Usuario: Muestra las razas disponibles para la especie 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.065.png)

**CAF04: Fecha de Nacimiento** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Ingresa fecha de nacimiento inválida     Sistema-->>Usuario: Muestra mensaje indicando el error 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.066.png)

**CAF05: Confirmación de Registro** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Registra mascota con datos válidos 

`    `Sistema-->>Usuario: Confirma que la mascota fue agregada correctamente 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.067.png)

**CANF01: Tiempo de Respuesta** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Completa el registro 

`    `Sistema-->>Usuario: Responde en menos de 3 segundos 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.068.png)

**CANF02: Seguridad de Datos** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Sistema 

`    `Sistema->>Sistema: Cifra datos sensibles de la mascota al almacenarlos 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.069.png)

5. **Notificaciones de Vacunas** 

**Diagrama de Caso de Uso** 

mermaid 

Copiar código 

usecaseDiagram 

`    `actor Usuario 

`    `Usuario --> (Notificaciones de Vacunas) 

`    `(Notificaciones de Vacunas) --> (Registrar fechas de vacunación)     (Notificaciones de Vacunas) --> (Configurar recordatorios) 

`    `(Notificaciones de Vacunas) --> (Enviar notificaciones automáticas) 

**Diagramas de Secuencia CAF01: Registro de Vacunas** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Registra una vacuna con fecha 

`    `Sistema-->>Usuario: Programa la notificación correspondiente 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.070.png)

**CAF02: Configuración de Notificaciones** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Configura el tiempo de aviso antes de la vacuna     Sistema-->>Usuario: Guarda la configuración personalizada 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.071.png)

**CAF03: Notificación Automática** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Sistema 

`    `participant Usuario 

`    `Sistema-->>Usuario: Envía notificación en la fecha programada     Usuario->>Sistema: Confirma recepción de la notificación 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.072.png)

**CAF04: Varios Canales** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Selecciona canal de notificación (email, SMS, push) 

`    `Sistema-->>Usuario: Guarda la configuración seleccionada 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.073.png)

**CAF05: Confirmación de Recepción** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Sistema 

`    `participant Usuario 

`    `Sistema-->>Usuario: Envía notificación 

`    `Usuario->>Sistema: Confirma que recibió el recordatorio 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.074.png)

**CANF01: Frecuencia de Envío** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Sistema 

`    `Sistema->>Sistema: Envía notificaciones con una tasa máxima de 2 por segundo 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.075.png)

**CANF02: Disponibilidad del Sistema** 

mermaid 

Copiar código sequenceDiagram 

`    `participant Usuario     participant Sistema 

Usuario->>Sistema: Solicita configurar una notificación Sistema-->>Usuario: Asegura un 99.9% de disponibilidad anual ![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.076.png)

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.077.png)

6. **Historial Médico de Mascota** 

**Diagrama de Caso de Uso** 

mermaid 

Copiar código 

usecaseDiagram 

`    `actor Usuario 

`    `Usuario --> (Historial Médico de Mascota) 

`    `(Historial Médico de Mascota) --> (Visualizar historial médico)     (Historial Médico de Mascota) --> (Registrar consultas médicas)     (Historial Médico de Mascota) --> (Filtrar eventos médicos) 

`    `(Historial Médico de Mascota) --> (Exportar historial) 

**Diagramas de Secuencia** 

**CAF01: Visualización de Historial** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Solicita ver el historial médico     Sistema-->>Usuario: Muestra el historial completo 

Universidad  Privada  de  Tacna    ![ref1]![ref2]![ref3]![ref4]![ref5]![ref6]![ref3]![ref7]![ref3]![ref8]

Facultad  de Ingeniería ![ref3]   ![ref3]![ref6]![ref5]![ref9]![ref10]

Escuela  Profesional  de  Ingeniería  de  Sistemas ![ref3]   ![ref11]![ref12]![ref5]![ref6]![ref3]![ref10]![ref3]![ref6]![ref5]![ref13]![ref3]![ref7]

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.078.png)

**CAF02: Registro de Consultas** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Añade una consulta médica 

`    `Sistema-->>Usuario: Guarda la consulta en el historial 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.079.png)

**CAF03: Filtros de Búsqueda** 

mermaid Copiar código sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Aplica filtro por fecha o tipo de evento 

`    `Sistema-->>Usuario: Muestra los eventos relevantes según el filtro 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.080.png)

**CAF04: Edición de Eventos** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Solicita editar un evento médico 

`    `Sistema-->>Usuario: Permite la edición de los datos del evento 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.081.png)

**CAF05: Exportar Historial** 

mermaid 

Copiar código sequenceDiagram 

Universidad  Privada  de  Tacna    ![ref1]![ref2]![ref3]![ref4]![ref5]![ref6]![ref3]![ref7]![ref3]![ref8]

Facultad  de Ingeniería ![ref3]   ![ref3]![ref6]![ref5]![ref9]![ref10]

Escuela  Profesional  de  Ingeniería  de  Sistemas ![ref3]   ![ref11]![ref12]![ref5]![ref6]![ref3]![ref10]![ref3]![ref6]![ref5]![ref13]![ref3]![ref7]

participant Usuario 

participant Sistema 

Usuario->>Sistema: Solicita exportar el historial Sistema-->>Usuario: Genera archivo en formato PDF o Excel 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.082.png)

**CANF01: Escalabilidad** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Sistema 

`    `Sistema->>Sistema: Soporta hasta 1,000 registros por mascota sin afectar el rendimiento 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.083.png)

**CANF02: Seguridad de Datos** 

mermaid Copiar código 

sequenceDiagram 
Universidad  Privada  de  Tacna    ![ref1]![ref2]![ref3]![ref4]![ref5]![ref6]![ref3]![ref7]![ref3]![ref8]

Facultad  de Ingeniería ![ref3]   ![ref6]![ref5]![ref9]![ref3]![ref10]

Escuela  Profesional  de  Ingeniería  de  Sistemas ![ref3]   ![ref11]![ref12]![ref5]![ref6]![ref3]![ref10]![ref3]![ref6]![ref5]![ref13]![ref3]![ref7]

`    `participant Sistema 

`    `Sistema->>Sistema: Cifra el historial médico en tránsito y en reposo 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.084.png)

7. **Agregar Veterinarias** 

**Diagrama de Caso de Uso** 

mermaid 

Copiar código 

usecaseDiagram 

`    `actor Administrador 

`    `Administrador --> (Agregar Veterinarias) 

`    `(Agregar Veterinarias) --> (Validar datos de la veterinaria) 

`    `(Agregar Veterinarias) --> (Registrar veterinaria en el sistema)     (Agregar Veterinarias) --> (Asociar ubicación geográfica) 

`    `(Agregar Veterinarias) --> (Confirmar registro) 

**Diagramas de Secuencia CAF01: Validación de Datos** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Administrador 

`    `participant Sistema 

`    `Administrador->>Sistema: Envía formulario con datos incompletos     Sistema-->>Administrador: Retorna mensaje indicando los campos faltantes 


Universidad  Privada  de  Tacna    ![ref1]![ref2]![ref3]![ref4]![ref5]![ref6]![ref3]![ref7]![ref3]![ref8]

Facultad  de Ingeniería ![ref3]   ![ref6]![ref5]![ref9]![ref10]![ref3]

Escuela  Profesional  de  Ingeniería  de  Sistemas ![ref3]   ![ref11]![ref12]![ref5]![ref6]![ref3]![ref10]![ref3]![ref6]![ref5]![ref13]![ref3]![ref7]

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.085.png)

**CAF02: Registro Exitoso** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Administrador 

`    `participant Sistema 

`    `Administrador->>Sistema: Completa formulario con datos válidos     Sistema-->>Administrador: Registra la veterinaria y confirma el registro 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.086.png)

**CAF03: Geolocalización** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Administrador 

`    `participant Sistema 

`    `Administrador->>Sistema: Añade coordenadas geográficas 

`    `Sistema-->>Administrador: Asocia la ubicación a la veterinaria 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.087.png)

**CAF04: Confirmación de Registro** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Administrador 

`    `participant Sistema 

`    `Administrador->>Sistema: Completa el registro 

`    `Sistema-->>Administrador: Confirma que la veterinaria fue registrada ![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.088.png)

**CAF05: Gestión de Veterinarias** 

mermaid 

Copiar código sequenceDiagram 

`    `participant Administrador     participant Sistema 

`    `Administrador->>Sistema: Solicita modificar datos de una veterinaria 

`    `Sistema-->>Administrador: Permite realizar los cambios 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.089.png)

**CANF01: Tiempo de Respuesta** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Administrador 

`    `participant Sistema 

`    `Administrador->>Sistema: Completa el registro 

`    `Sistema-->>Administrador: Responde en menos de 2 segundos 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.090.png)

**CANF02: Accesibilidad** 

mermaid 

Copiar código sequenceDiagram 

`    `participant Administrador 

`    `participant Sistema 

`    `Administrador->>Sistema: Accede desde un navegador móvil o de escritorio 

`    `Sistema-->>Administrador: Funciona correctamente en ambos entornos ![ref14]

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.091.png)

8. **Eliminar Mascota** 

**Diagrama de Caso de Uso** 

mermaid 

Copiar código 

usecaseDiagram 

`    `actor Usuario 

`    `Usuario --> (Eliminar Mascota) 

`    `(Eliminar Mascota) --> (Validar permisos) 

`    `(Eliminar Mascota) --> (Solicitar confirmación) 

`    `(Eliminar Mascota) --> (Eliminar datos de la mascota) 

`    `(Eliminar Mascota) --> (Cancelar notificaciones asociadas) 

**Diagramas de Secuencia** 

**CAF01: Confirmación de Eliminación** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Solicita eliminar una mascota 

`    `Sistema-->>Usuario: Solicita confirmación 

`    `Usuario->>Sistema: Confirma eliminación 

`    `Sistema-->>Usuario: Borra la mascota y muestra mensaje de éxito 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.092.png)

**CAF02: Validación de Permisos** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Intenta eliminar una mascota 

`    `Sistema-->>Usuario: Verifica que sea el propietario de la cuenta 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.093.png)

**CAF03: Eliminación Exitosa** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Confirma la eliminación 

`    `Sistema-->>Usuario: Elimina los datos de la mascota 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.094.png)

**CAF04: Historial Asociado** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Intenta acceder al historial de una mascota eliminada 

`    `Sistema-->>Usuario: Muestra mensaje indicando que ya no está disponible 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.095.png)

**CAF05: Cancelación de Notificaciones** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Solicita eliminar mascota con vacunas programadas 

`    `Sistema-->>Usuario: Cancela todas las notificaciones asociadas 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.096.png)

**CANF01: Persistencia** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Sistema 

`    `Sistema->>Sistema: Refleja la eliminación en la base de datos en menos de 3 segundos 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.097.png)

**CANF02: Seguridad de Permisos** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Solicita eliminar una mascota 

`    `Sistema-->>Sistema: Verifica que el usuario esté autenticado y autorizado ![ref15]

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.098.png)

9. **Cambiar Contraseña** 

**Diagrama de Caso de Uso** 

mermaid 

Copiar código 

usecaseDiagram 

`    `actor Usuario 

`    `Usuario --> (Cambiar Contraseña) 

`    `(Cambiar Contraseña) --> (Validar contraseña actual)     (Cambiar Contraseña) --> (Validar nueva contraseña)     (Cambiar Contraseña) --> (Actualizar contraseña) 

`    `(Cambiar Contraseña) --> (Cerrar sesiones activas) 

**Diagramas de Secuencia** 

**CAF01: Validación de Contraseña Actual** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Ingresa contraseña actual incorrecta     Sistema-->>Usuario: Muestra mensaje de error 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.099.png)

**CAF02: Validación de Nueva Contraseña** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Ingresa nueva contraseña que no cumple requisitos 

`    `Sistema-->>Usuario: Solicita contraseña que cumpla con requisitos 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.100.png)

**CAF03: Confirmación de Cambio** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Completa el cambio de contraseña 

`    `Sistema-->>Usuario: Muestra mensaje confirmando el cambio 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.101.png)

**CAF04: Notificación de Cambio** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Sistema 

`    `participant Usuario 

`    `Sistema-->>Usuario: Envía correo notificando el cambio de contraseña 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.102.png)

**CAF05: Expiración de Sesiones** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Cambia su contraseña 

`    `Sistema-->>Usuario: Cierra todas las sesiones activas 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.103.png)

**CANF01: Seguridad de Contraseñas** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Sistema 

`    `Sistema->>Sistema: Almacena las contraseñas cifradas con bcrypt ![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.104.png)

**CANF02: Tiempo de Respuesta** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Usuario 

`    `participant Sistema 

`    `Usuario->>Sistema: Solicita cambiar la contraseña     Sistema-->>Usuario: Responde en menos de 3 segundos ![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.105.png)

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.106.png)

10. **Rol de Administrador** 

**Diagrama de Caso de Uso** 

mermaid 

Copiar código 

usecaseDiagram 

`    `actor Administrador 

`    `Administrador --> (Gestionar Usuarios) 

`    `Administrador --> (Gestionar Veterinarias)     Administrador --> (Visualizar Reportes) 

`    `Administrador --> (Configurar Roles) 

`    `Administrador --> (Auditar Actividades) 

**Diagramas de Secuencia CAF01: Gestión de Usuarios** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Administrador 

`    `participant Sistema 

`    `Administrador->>Sistema: Solicita acceso al panel de usuarios     Sistema-->>Administrador: Muestra la lista de usuarios 

`    `Administrador->>Sistema: Edita o elimina un usuario 

`    `Sistema-->>Administrador: Confirma cambios 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.107.png)

**CAF02: Gestión de Veterinarias** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Administrador 

`    `participant Sistema 

`    `Administrador->>Sistema: Solicita acceso al panel de veterinarias     Sistema-->>Administrador: Permite agregar, editar o eliminar veterinarias 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.108.png)

**CAF03: Visualización de Reportes** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Administrador 

`    `participant Sistema 

`    `Administrador->>Sistema: Genera un reporte de usuarios o mascotas     Sistema-->>Administrador: Proporciona el reporte solicitado 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.109.png)

**CAF04: Gestión de Roles** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Administrador 

`    `participant Sistema 

`    `Administrador->>Sistema: Solicita modificar roles de un usuario     Sistema-->>Administrador: Permite editar permisos 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.110.png)

**CAF05: Registro de Actividades** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Administrador 

`    `participant Sistema 

`    `Administrador->>Sistema: Realiza cambios en el sistema 

`    `Sistema-->>Administrador: Registra las acciones para auditoría 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.111.png)

**CANF01: Escalabilidad** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Sistema 

`    `Sistema->>Sistema: Maneja hasta 1,000 administradores concurrentes 

![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.112.png)

**CANF02: Seguridad** 

mermaid 

Copiar código 

sequenceDiagram 

`    `participant Administrador 

`    `participant Sistema 

`    `Administrador->>Sistema: Accede a funciones administrativas 

`    `Sistema-->>Administrador: Solicita autenticación de dos factores (2FA) ![](img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.113.png)

[ref1]: img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.001.png
[ref2]: img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.002.png
[ref3]: img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.003.png
[ref4]: img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.004.png
[ref5]: img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.005.png
[ref6]: img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.006.png
[ref7]: img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.007.png
[ref8]: img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.008.png
[ref9]: img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.009.png
[ref10]: img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.010.png
[ref11]: img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.011.png
[ref12]: img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.012.png
[ref13]: img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.013.png
[ref14]: img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.015.png
[ref15]: img/Aspose.Words.64a506e7-bf2e-41ae-95af-f301b8fabc10.023.png
