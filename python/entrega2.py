# 1- Pide al usuario que introduzca tres números. Utiliza condicionales para determinar cuál de los tres es el mayor y muéstralo por pantalla. 
# # Opcion 1:
# num1:int = int(input('Número 1 '))
# num2:int = int(input('Número 2 '))
# num3:int = int(input('Número 3 '))

# if num1 > num2 and num1>num3:
#     print(f'El mayor es {num1}')
# elif num2 > num3:
#     print(f'El mayor es {num2}')
# else:
#     print(f'El mayor es {num3}')

# # Opcion 2:
# numeros:list[int] = []
# for i in range(3):
#     numeros.append(int(input(f'El numero {i+1}: ')))

# # Opcion 3:
# import sys
# mayor:int = -sys.maxsize
# for i in range(3):
#     num:int = int(input(f'Numero {i+1}: '))
#     if num > mayor:
#         mayor = num

# print(f'El mayor es: {mayor}')

# # 2- Solicita al usuario un número entero. Utiliza un bucle for para imprimir la tabla de multiplicar de ese número del 1 al 10.
# numero:int = int(input('Introduzca un numero: '))

# for i in range(11):
#     print(f'{numero}x{i} = {numero*i}')

# # 3- Crea una lista vacía llamada lista_compra. Pide al usuario que introduzca artículos para añadir a la lista. Permite al usuario añadir elementos hasta que escriba "fin". Finalmente, imprime la lista de la compra.
# lista_compra:list[str] = []
# palabra:str = ''
# while True:
#     palabra:str = input('Escribe algo: ')
#     if palabra.lower() == 'fin':
#         break
#     lista_compra.append(palabra)

#     print(lista_compra)

# 4- Define una palabra secreta. Pide al usuario que intente adivinar la palabra. Dale pistas (por ejemplo,
# la primera letra) si falla. Permite un número limitado de intentos. Usa un bucle while y condicionales 
# para controlar el juego.



# 5- Pide al usuario que introduzca una serie de números separados por espacios. Convierte la entrada en
# una lista de números. Utiliza un bucle for y un condicional para calcular la suma de todos los números
# pares en la lista. Imprime la suma.
# numeros_str:str = '3 2 6 4 5 1 7 6'
# numeros_list_str:list[str] = numeros_str.strip()
# resultado:int = 0
# for num in numeros_list_str:
#     numero:int = int(num)
#     if numero % 2 == 0:
#         resultado += numero

# print(f'La suma es {resultado}')

# # Opcion 2
# numeros_str:str = '3 2 6 4 5 1 7 6'
# numeros:list[int] = [int(n) for n in numeros_str.split()]
# numeros_pares:list[int] = [n for n in numeros if not n%2]
# print(sum(numeros_pares))

# # Opcion 3
# numeros_str:str = '3 2 6 4 5 1 7 6'
# print(sum([int(n) for n in numeros_str.split() if not int(n)%2]))

# 6- Pide al usuario que introduzca una frase. Utiliza un bucle for para recorrer la frase y cuenta
# cuántas vocales (a, e, i, o, u) contiene. Imprime el número total de vocales.
# Opcion 1
frase:str = 'Puta Real Madrid'
contador:int = 0
vocales:str = 'aeiouáéíóú'
for letra in frase:
    if letra.lower() in vocales:
        contador += 1

print(contador)

# Opcion 2
frase:str = 'Puta Real Madrid'
print(sum([1 for letra in frase if letra in 'aeiouáéíóú']))

# Opcion 3(Sin if)
frase:str = 'Puta Real Madrid'
print(sum([frase.lower().count(vocal) for vocal in 'aeiouáéíóú']))

# Opcion 4
frase:str = 'Puta Real Madrid'
print(sum([letra.lower() in 'aeiouáéíóú']))

# 7- Pide al usuario un número entero positivo. Utiliza un bucle for y condicionales para determinar si
# el número es primo o no. Imprime el resultado. (Un número primo solo es divisible por 1 y por sí mismo).



# 8- Crea una lista vacía llamada tareas. Permite al usuario realizar las siguientes acciones:
# Añadir una tarea (usando input y .append()).
# Mostrar todas las tareas (usando un bucle for).
# Salir del programa.
# Utiliza un bucle while para mantener el programa en funcionamiento hasta que el usuario decida salir.





# 9- Genera un número aleatorio entre 1 y 100 (puedes usar el módulo random). Pide al usuario que adivine
# el número. Dale pistas si el número es mayor o menor. Cuenta el número de intentos que necesita el
# usuario hasta acertar. Usa un bucle while y condicionales.



# 10- Pide al usuario que introduzca una cadena de texto. Utiliza un bucle for para recorrer la cadena e
# imprimirla en orden inverso