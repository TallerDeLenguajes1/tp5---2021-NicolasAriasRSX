# tp5---2021-NicolasAriasRSX
## Ejercicio 4
* ¿String es una tipo por valor o un tipo por referencia?
String es un tipo por referencian ya que se almacena en el heap, y se la pasa a la funcion como una copia de la referencia al dato.
¿Qué secuencias de escape tiene el tipo string?
Secuencias de escape de C#
```
\ '- comilla simple (0x0027)
\ "- comillas dobles (0x0022)
\\ - barra invertida (0x005C)
\ 0 - nulo (0x0000)
\ a - alerta (0x0007)
\ b - retroceso (0x0008)
\ f - alimentación de formulario (0x000C)
\ n - nueva línea (0x000A)
\ r - retorno de carro (0x000D)
\ t - pestaña horizontal (0x0009)
\ v - pestaña vertical (0x000B)
\ u0000 - \ uFFFF - Carácter Unicode
\ x0 - \ xFFFF - Carácter Unicode (código con longitud variable)
\ U00000000 - \ U0010FFFF - Carácter Unicode (para generar sustitutos)
```
* ¿Qué sucede cuando utiliza el carácter @ antes de una cadena de texto?
Al anteponer @ antes de la cadena estamos Inicializando con un literal de cadena literal o sea interpreta literalmente el contenido de la cadena. este sirve para mayor comodidad en la lectura de la salida.
Ejemplo:
string filePath = @"C:\Users\scoleridge\Documents\";
//Output: C:\Users\scoleridge\Documents\
string text = @"My pensive SARA ! thy soft cheek reclined
    Thus on mine arm, most soothing sweet it is
    To sit beside our Cot,...";
/* Output:
My pensive SARA ! thy soft cheek reclined
   Thus on mine arm, most soothing sweet it is
   To sit beside our Cot,...
*/
string quote = @"Her name was ""Sara.""";
//Output: Her name was "Sara." 
