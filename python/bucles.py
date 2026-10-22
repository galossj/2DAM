# While
cont:int = 0

while cont < 10:
    if cont == 8:
        break
    if cont == 9:
        continue
    print(cont)
    cont += 1

#For
meses:list = ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio']

for pos, mes in enumerate(meses): #enumerate: Enumera los elementos de la lista y devuelve un elemento iterable
    print(f'El mes {pos+1} es {mes}') #F es para concatenar


for i in range(10): #Range te devuelve un elemento iterable con el valor que quieras darle
    print(i+1, 'MHDP')
