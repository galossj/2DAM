# Ejercicio 1: Solicitar al usuario que introduzca un
# texto e imprimir por pantalla la cantidad total de
# caracteres que han sido introducidos
texto:str = input('Introduzca un texto: ')
cantidad:int = len(texto)

print('Texto: ', texto)
print('Cantidad total de caracteres: ', cantidad)

# Ejercicio 2: Solicitar al usuario que introduzca un
# texto e imprimir por pantalla el mismo texto pero
# empezando por mayúscula
texto:str = input('Introduzca un texto: ')
print(texto.capitalize())

# Ejercicio 3: Solicitar al usuario que introduzca un
# email e imprimir si tiene el caracter '@' o no
correo:str = input('Introduzca un correo electrónico: ')

# Opcion 1
# if '@' in correo:
#     print(correo)
# else:
#     print('Correo electrónico no válido.')

# Opcion 2
# if correo.find('@') > -1:
#     print(correo)
#
# else:
#     print('Correo electrónico no válido.')

# Opcion 3
# try:
#     correo.index('@', 1, -1)
#     print('Tiene @')
# except Exception:
#     print('No vale')

# Opcion 4
# if correo.count('@') == 1:
#     print('Tiene @')
# else:
#     print('No tiene @')

# Opcion 5
# partes: list = correo.split('@')
# if len(partes) == 2 and partes[0] and partes[-1]:
#     print('Tiene @')
# else:
#     print('No tiene @.')

# Opcion 6
if  correo.count('@') == 1 and '@' not in correo[0] and not correo.endswith('@') :
    print(correo, ' tiene @')
else:
    print('No tiene @')

# Opcion 7,8 y 9
# rfind, rindex y rsplit

# Ejercicio 4: Solicitar al usuario que introduzca un
# email e imprimir si termina por '@iepgroup.com' o no
correo:str = input("Introduzca otro correo electrónico: ")

if correo.endswith('@iepgroup.com'):
    print(correo, 'Sí termina por "@iepgroup.com"')
else:
    print(correo, 'No termina por "@iepgroup.com"')

# Ejercicio 5: Solicitar al usuario que introduzca un
# email e imprimir el email reemplazando '@iepgroup.com' por '@joyfe.es'
correo:str = input("Introduzca otro correo electrónico que termine en @iepgroup.com: ")

if correo.endswith('@iepgroup.com'):
    print(correo.replace('@iepgroup.com', '@joyfe.es'))
else:
    print(correo, 'No válido.')

# Ejercicio 6: Solicitar al usuario que introduzca un
# nombre y una contraseña. Imprimir 'Administrador' si ha introducido
# 'admin' - '1234', 'Usuario básico' si ha introducido 'bob' - 'qwerty'
# o 'Usuario no existe' si no es ninguno de los dos casos anteriores
nombre:str = input('Introduzca un nombre: ')
contrasena:str = input('Introduzca una contraseña: ')

if nombre == 'admin' and contrasena == '1234':
    print('Administrador')
elif nombre == 'bob' and contrasena == 'qwerty':
    print('Usuario básico')
else:
    print('Usuario no existe')