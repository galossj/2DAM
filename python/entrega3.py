# 1- Secuencia de Fibonacci: Solicita al usuario un número N.
# Genera y muestra por pantalla los primeros N términos de la sucesión de Fibonacci utilizando un bucle.
# valor:int = int(input('Introduzca un número: '))
# a:int = 0
# b:int = 1
# cont:int = 0

# while cont < valor:
#     print(a, ' ')
#     nuevo = a+b
#     a=b
#     b=nuevo
#     cont+=1


# 2- Calculadora de promedio: Pide al usuario que introduzca varias notas o números separados por comas.
# Convierte la entrada en una lista de números flotantes y calcula la media aritmética. Muestra la media
# por pantalla.
# valores = input('Introduzca las notas separadas por comas: ')

# notas = valores.split(',')
# notas = [float(nota) for nota in notas]

# suma = sum(notas)
# media = suma / len(notas)
# print(f'La media es: ', media)
# 3- Separador de pares e impares: Pide al usuario una serie de números separados por espacios. Recórrelos
# y clasifícalos creando dos listas distintas: una para los números pares y otra para los impares.
# Muestra ambas listas al final.

# 4- Eliminación de duplicados: Pide al usuario que introduzca una lista de elementos (o palabras)
# separados por comas. Crea una nueva lista que contenga los mismos elementos pero sin repetir ninguno.
# Imprime la lista limpia.

# 5- Filtrado por longitud: Solicita al usuario que introduzca una frase. Transfórmala en una lista de
# palabras e imprime únicamente aquellas palabras que tengan más de 5 caracteres.
# frase:str = input('Introduzca una frase: ')
# palabras = frase.split(' ')
# # cont:int = 0

# for palabras in frase:
#     if len(palabras)> 5:
#         print(palabras)
# 6- Filtro de vocales iniciales: Pide al usuario una serie de palabras separadas por espacios. Recorre la
# lista e imprime solo aquellas palabras que empiecen por una vocal (a, e, i, o, u), sin importar si
# es mayúscula o minúscula.

# 7- Simulador de carrito de compra con precios: Crea un programa que permita al usuario introducir
# nombres de productos y sus respectivos precios. El bucle se repetirá hasta que el usuario
# escriba "total". Al finalizar, muestra el importe total de la compra.

# 8- Juego de Piedra, Papel o Tijera: Genera una elección aleatoria para la máquina entre "piedra",
# "papel" o "tijera" (usando el módulo random). Pide la elección del usuario y determina quién gana
# mediante condicionales.

# 9- Validador de contraseñas seguras: Pide al usuario que cree una contraseña. Comprueba mediante
# condicionales si cumple las siguientes reglas: al menos 8 caracteres, al menos un número y al menos una
# letra mayúscula. Muestra si la contraseña es "Válida" o "Insegura".

# 10- Conversor de temperaturas: Pide al usuario que introduzca una temperatura en grados Celsius y le dé
# a elegir mediante condicionales si prefiere convertirla a Fahrenheit o a Kelvin, mostrando el cálculo
# correspondiente.

# 11- Generador de nombres de usuario: Solicita al usuario su nombre, su primer apellido y su año de
# nacimiento. Genera e imprime un nombre de usuario en minúsculas combinando las 3 primeras letras del
# nombre, las 3 primeras del apellido y las 2 últimas cifras del año.
# nombre:str = input('Introduzca un nombre: ')
# apellido:str = input('Introduzca un apellido: ')
# year:str = input('Introduzca un año de nacimiento: ')

# print(f'{nombre[:3].upper()}{apellido[:3].upper()}{year[-2:].upper()}')

# 12- Censura de vocales: Pide al usuario que introduzca una frase. Recórrela con un bucle y sustituye
# todas las vocales por un asterisco (*). Imprime la frase modificada final.
# frase:str = input('Introduzca una frase: ')
# vocales:str = 'aeiouáéíóú'

# for l in frase:
#     if l.lower() in vocales:
#         print('*', end='')
#     else:
#         print(l, end='')

# Opcion 2:
# print(*['*' if l.lower() in 'aeiouáéíóú' else l for l in frase], sep='')

# 13- Buscador con índice en lista: Define una lista previa de nombres. Pide al usuario que introduzca
# un nombre a buscar: si está en la lista, indica en qué posición (índice) se encuentra; si no está,
# muestra un mensaje de advertencia.
# nombres:list = ['Diego', 'Marcos', 'Nixon', 'Andres']
# nombre:str = input('Introduzca el nombre a buscar: ')

# if nombre in nombres:
#     print(nombres.index(nombre))
# else:
#     print('No está')

# 14- Calculadora de descuento por tramos: Solicita el precio total de una compra. Aplica un 10% de
# descuento si la compra supera los 50€ y un 20% si supera los 100€. Muestra por pantalla la cantidad
# descontada y el precio final a pagar.
# precio:int = int(input('Precio total de la compra: '))
# descuento:float = 0.2 if precio >= 100 else 0.1 if precio >= 50 else 0
# print('Precio final: ', precio*(1-descuento), 'Cantidad descontada: ', precio*descuento)

# 15- Inversor de palabras dentro de una frase: Pide al usuario una frase. Utiliza .split() y un bucle
# para invertir únicamente las letras de cada palabra individual (sin alterar el orden general de las
# palabras en la frase) e imprime el resultado.

# 16- Simulador de cajero automático: Establece un saldo inicial fijo. Utiliza un bucle while con un menú
# de opciones para realizar ingresos o retiradas. Si el usuario intenta retirar más dinero del disponible,
# muestra un mensaje de saldo insuficiente.
# saldo:float = 123.45
# while True:
#     print('0 - Salir')
#     print('1 - Ingresar')
#     print('2 - Retirar')
#     opcion:str = input('Opción: ')
#     if opcion == '0':
#         break
#     elif opcion == '1':
#         saldo += float(input('Ingreso: '))
#     elif opcion == '2':
#         retiro = float(input('Retiro: '))
#         if retiro > saldo:
#             print('Saldo insuficiente.')
#         else:
#             saldo -= retiro
#     else:
#         print('No válido.')
#     print(f'Saldo actual: , {saldo:.2f}')

# 17- Generador de acrónimos: Pide al usuario que introduzca el nombre completo de una organización o
# título formado por varias palabras. Recorre cada palabra y extrae su primera letra en mayúscula para
# formar e imprimir el acrónimo final.
# frase:str = 'Vinicius chimpancé'
# acronimo:str = ''
# for p in frase.split():
#     acronimo += p[0].upper()
# print(acronimo)

# Opcion 2
# print(''.join([p[0].upper() for p in frase.split()]))

# 18- Patrón de triangulo con asteriscos: Solicita al usuario un número entero $N$. Utiliza un bucle
# para imprimir una pirámide o triángulo de asteriscos que aumente progresivamente de 1 a N asteriscos,
# fila por fila.
# n:int = int(input('Introduzca un número entero: '))

# for i in range(1, n+1):
#     print(' '*(n-i) + '* '*i)

# 19- Simulador de lanzamiento de dados: Simula la tirada de dos dados aleatorios (enteros entre 1 y 6
# usando random). Muestra el valor de cada dado y la suma total. Si la suma resulta en 7 u 11, muestra el
# mensaje "¡Ganaste!", en caso contrario "Sigue intentándolo".
# import random

# n1:int = random.randint(1, 6)
# n2:int = random.randint(1, 6)
# total:int = n1+n2

# print('Número 1: ', n1)
# print('Número 2: ', n2)
# print('Total: ', total)
# if total ==7 or total ==11:
#     print('¡Ganaste!')
# else:
#     print('Sigue intentándolo.')
# 20- Filtro por longitud exacta: Pide al usuario una frase y, a continuación, un número entero. Recorre
# la frase e imprime por pantalla únicamente aquellas palabras cuya longitud coincida exactamente con la
# cifra introducida.
# frase:str = input('Introduzca una frase: ')
# num:int = int(input('Introduzca un número entero: '))
# palabras:list[str] = frase.split()
# for p in palabras:
#     if len(p) == num:
#         print(p, end=' ')

# Opcion 2:
# print(' '.join([p for p in frase.split() if len(p) == num]))