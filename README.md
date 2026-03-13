Actividad #1 de la clase de CIBERINFRESTRUCTURA.

Validador de Contraseñas Seguras en Windows Forms.

Sirve para la creación y validación de contraseñas, asegurando que cumplan con estándares modernos de seguridad mediante el uso de expresiones regulares (Regex).

/Interfaz/

![Interfaz]("https://github.com/Tapiab358/Formulario-Simple-WinForms/tree/master/Capturas")

/Funcion/

Validación Robusta: Implementa un sistema de verificación que exige requisitos de complejidad específicos.

Validacion de campos nulos: Verifica que los campos de contraseña se encuentren completos

Confirmación de Coincidencia: Compara dos campos para asegurar que el usuario ha ingresado la misma contraseña correctamente.

Retroalimentación Visual: Utiliza cuadros de mensaje (MessageBox) con iconos de éxito, advertencia o error según el resultado.

/Requisitos de Seguridad/

Para que una contraseña sea considerada válida por el sistema, debe cumplir con los siguientes criterios:

-Mínimo 8 caracteres de longitud.

-Minimo una letra mayúscula.

-Minimo una letra minúscula.

-Minimo un número.

-Minimo un carácter especial (símbolo).

/Explicación Técnica/

El núcleo de la validación reside en el método ValidarContrasena, que utiliza la siguiente expresión regular:

C#

"string pattern = @"^(?=.[a-z])(?=.[A-Z])(?=.\d)(?=.[^\da-zA-Z]).{8,}$";"

Desglose del Regex:

(?=.*[a-z]): Busca al menos una minúscula.

(?=.*[A-Z]): Busca al menos una mayúscula.

(?=.*\d) : Busca al menos un dígito.

(?=.*[^\da-zA-Z]): Busca al menos un carácter que no sea alfanumérico (símbolo).

.{8,} : Define la longitud mínima de 8 caracteres.

/¿Cómo usarlo?/

Ingresa tu contraseña en el primer campo.

Repítela en el segundo campo para confirmar.

Haz clic en el botón de validar para obtener el diagnóstico del sistema.
