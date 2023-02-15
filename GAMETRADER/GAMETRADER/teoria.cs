/* El polimorfismo es como un objeto puede tomar varias formas. En el polimorfismo por abstraccion un objeto toma varias formas otorgando propiedades comunes a todos los objetos del mismo tipo (Creo una clase abstracta auto que tenga como propiedad RUEDAS, todos los otro autos tendran RUEDAS al igual que el), el polimorfismo por herencia nos permite crear Listas con objetos que tienen en comun un tipo (Ejmplo auto, dentro de la lista contengo sedanes, cupes, combis pero nunca un objeto AUTO, esto permite que mi objeto tome varias formas.)
 * 2) Son un conjunto de metodos que facilitan la programacion, ayudando al usuario a crear acciones comhnes que usaran luego.
 * 3) En un parametro por valor yo no puedk modificar ese parametro dentro de la variable y que "salga" de ello, mientras que si cambio un parametro por referencia este si cambiara fuera de el metodo y se archivara en la memoria
 *int ejemplo = 1;
 *public List<int> ListaEjemplo 
 *public void MetodoEjemplo (ejemplo){
 *  ejemplo = ejemplo +1;
 *  ListaEjemplo.Add(ejemplo);
 *}
 *En este caso el valor "Ejemplo" No cambio su valor, mientras que a la lista si se le cambio una posicion de memoria.
 *4) Se entiende por desarrollo por capas al agregado de interfaces para que estas sean quien "comuniquen" nuestro codigo con winforms (ejemplo) y no se comuniquen directamente entre ellos, el beneficio que trae es que, al agregar capas es mas dificil de desglosar y esto proporciona ma sseguridad al codigo
 *5)La diferencia es que en al sobrecarga de metodos yo tengo varios metodos con un mismo nombre, pero estos reciben parametros distintos y no necesariamente hacen lo mismo. Cuando realizo una sobreescritura de metodos Estoy dandole el mismo nombre a un metodo que adoptaran varios objetos del mismo tipo pero que implementaran de manera diferente
 *Ejemplo sobrecarga: Varios metodos llamados "Cargar Usuario", los cuales reciben distintos parametros y crean usuarios de distinto tipo
 *ejemplo sobreescritura: Varios metodos realizados en clases, en los que tengo una idea base o un nombre base y modificio ciertos comportamientos
 *6) Propiedades, comportamientos y 
