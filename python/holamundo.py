# Python es TIPADO.

nombre = 'Bob' 
edad = 18 
dinero: int = 1_000_000 # El '_' no sirve para nada, es solo visual.
nota:float = 4.9 # Para decimales solo float, no double ni nada.
aprobado:bool = False
nulo:None = None

print('Hola mundo!')
print ('Hola ' + nombre + '! Tienes ' + str(edad) + ' años.') # No se usa el ";".
print(f'Hola {nombre}! Tienes {edad} años.')