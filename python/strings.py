
texto:str = 'madridistas hijos de puta'


print(texto.capitalize())       # Primera letra a mayúscula
print(texto.count('a', 1, 25))  # 1º Caracter que quieras contar,
                                # 2º Posición en la que empieza a contar,(INCLUIDO)
                                # 3º la posición en la que deja de contar(NO INCLUIDO)
print(texto.endswith('puta'))
print(texto.find('a', 10, 20))
print(texto.replace('a', 'X'))
print(texto.split('a'))