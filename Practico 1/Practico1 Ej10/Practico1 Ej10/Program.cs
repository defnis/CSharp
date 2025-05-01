/*  Algoritmo para resolver el problema de los misioneros y caníbales
El objetivo es mover a los tres misioneros y tres caníbales desde la orilla izquierda (Izq.) 
a la orilla derecha (Der.) de manera segura, respetando las reglas del problema.

Variables iniciales:
OrillaIzq: {3M, 3C} (tres misioneros, tres caníbales)
OrillaDer: {0M, 0C} (vacía)
Bote: {0M, 0C} (vacío al inicio en la orilla izquierda)

Reglas:
El bote no puede viajar vacío.
En cualquier orilla (o en el bote), el número de caníbales no puede superar al número de misioneros
si hay al menos un misionero presente.

Algoritmo:
Mover 1 caníbal y 1 misionero a la derecha
Mover(1, 1, Der)
Estado:
Izq.: {2M, 2C}
Der.: {1M, 1C}

Regresar 1 caníbal a la izquierda
Mover(0, 1, Izq)
Estado:
Izq.: {2M, 3C}
Der.: {1M, 0C}

Mover 2 misioneros a la derecha
Mover(2, 0, Der)
Estado:
Izq.: {0M, 3C}
Der.: {3M, 0C}

Regresar 1 misionero a la izquierda
Mover(1, 0, Izq)
Estado:
Izq.: {1M, 3C}
Der.: {2M, 0C}

Mover 2 caníbales a la derecha
Mover(0, 2, Der)
Estado:
Izq.: {1M, 1C}
Der.: {2M, 2C}

Regresar 1 caníbal a la izquierda
Mover(0, 1, Izq)
Estado:
Izq.: {1M, 2C}
Der.: {2M, 1C}

Mover 1 misionero y 1 caníbal a la derecha
Mover(1, 1, Der)
Estado:
Izq.: {0M, 1C}
Der.: {3M, 2C}

Regresar 1 caníbal a la izquierda
Mover(0, 1, Izq)
Estado:
Izq.: {0M, 2C}
Der.: {3M, 1C}

Mover 2 caníbales a la derecha
Mover(0, 2, Der)
Estado:
Izq.: {0M, 0C}
Der.: {3M, 3C}
 */
