
def saludar(nombre:str, apellido:str, edad:int=18) -> None:  #Cuando le das valor aqui a una variable, a las siguientes también estás obligado.
    print(f'Hola {nombre} {apellido}. Tienes {edad} años.')

saludar('Guillermo', 'Galocha', 20)
saludar('Guillermo', apellido='Galocha')
saludar('Guillermo', 'Galocha', edad=19)
# Desde que nombras uno de las variables llamando a la función, tienes que nombrar todas las 
# que hay a continuación.

def sumar(num1:int, num2:int, *numeros:int, **kargs):
    print(num1, num2)
    print(numeros)
    print(kargs)
    return num1 + num2 + sum(numeros)

print(sumar(1, 3, 5, 7, 9, nota1=4, nota2=7))

print(*[1, 2, 3], sep='-') #El asterisco es para desempaquetar una lista y devolver los valores uno por uno