meses:list = ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio']

# print(len(meses))
# print(meses[0])
# print(meses[-1])
# print(meses[1:-1])
# print(meses.count('Febrero'))

meses.append('Julio')
meses.insert(7,'Agosto')
meses.extend(['Septiembre', 'Octubre'])

# meses.reverse()

print(meses)

meses:list = [
    ['enero', 'febrero', 'marzo'],
    ['abril', 'mayo', 'junio'],
    ['julio', 'agosto', 'septiembre'],
    ['octubre', 'noviembre', 'diciembre'],
]

# meses.clear()
meses_copia:list = meses.copy()
meses_copia[1] = 'MHDP' #Cambia el elemento entero que haya en esa posición

print(meses)