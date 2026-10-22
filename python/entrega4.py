# Ejercicio 1: Hacer una función que: reciba un parámetro 
# de tipo str, solicite al usuario que introduzca un texto 
# usando como prompt el parámetro recibido y devuelva el texto 
# leído

# Ejercicio 2: Hacer otra función similar a la anterior pero 
# el usuario debe introducir un número. Se pedirá al usuario 
# introducir el número constantemente hasta que escriba un
# número valido. 
# def pedir_numero(prompt:str) -> int:
#     while True:
#         try:
#             return int(input(prompt))
#         except Exception:
#             print('No es un numero')

# print(pedir_numero('Escribe un numero: '))

# Ejercicio 3: Hacer una función que reciba 2 números y 
# devuelva el primer número elevado al segundo. El segundo
# es opcional, si no se pasa se debe elevar al cuadrado
# def potencia(n1:int, n2:int=2) -> int:
#     return pow(n1,n2)

# print(potencia(3, 4))

# Ejercicio 4: Escribe una función que tome una lista de números como entrada
# y devuelva la suma de todos los elementos de la lista.
# def suma(numeros:list[int]):
#     return sum(numeros)

# print(suma([2, 3, 4, 5]))

# Ejercicio 5: Hacer una función que tome una lista de números como entrada
# y devuelva el número mayor por defecto o el menor si se indica
# en un parámetro de la función
# def mayormenor(numeros:list[int],mayor:bool=True) -> int:
#     return max(numeros) if mayor else min(numeros)

# print(mayormenor([5, 6, 3, 6, 3, 4, 5, 7, 9], False))

# Ejercicio 6: Hacer una función que tome una lista de palabras
# como entrada y devuelva la(s) palabra(s) más larga(s).
# Nota: puede haber varias palabras con la misma longitud.
# def palabralarga(palabras:list[str]) -> list[str]:
#     result:list[str] = [palabras[0]]
#     for p in palabras[1:]:
#         if len(p) == len(result[0]):
#             result.append(p)
#         elif len(p) > len(result[0]):
#             result.clear()
#             result.append(p)
#     return result

# print(palabralarga(['Guillermo', 'Galocha', 'Pérez']))

# Ejercicio 7: Hacer una función que tome un número entero como
# entrada y devuelva una lista que contenga los cuadrados
# de todos los números enteros desde 1 hasta el número dado.
# def cuadrados(num:int) -> list[int]:
#     res:list[int] = []
#     i = 1
#     while num > 0:
#         res.insert(0, num**2)
#         num-=1
#     return res

# print(cuadrados(6))

# Ejercicio 8: Hacer una función que tome un lista de números y
# devuelva otra lista con los números pares de la primera.
# O los impares si se indica por parámetro.
# def paresimpares(numeros:list[int], par:bool=True) -> list[int]:
#     pares:list[int] = []
#     impares:list[int] = []

#     for n in numeros:
#         if n%2 == 0:
#             pares.append(n)
#         else:
#             impares.append(n)

#     return pares if par else impares

# print(paresimpares([1, 4, 5, 3, 6, 2, 9, 7, 10, 14], False))

# Ejercicio 9: Hacer una función que reciba un entero y devuelva su factorial.
# def factorial(num:int) -> int:
#     import math
#     return math.factorial(num)
# -------------------------------
#   result:int = num
#   for i in range(1, num):
#       result *= i
#   return result

# print(factorial(6))

# Ejercicio 10: Hacer una función que reciba un entero y devuelva su factorial de forma recursiva.
def factorial_r(num:int) -> int:
    return 1 if num <= 1 else num * factorial_r(num - 1)

print(factorial_r(9))