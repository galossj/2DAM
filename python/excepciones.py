# while True:
#     try:
#         input()
#         0/0
#     except Exception:
#         print('No')

# expect Exception OBLIGATORIO
class NumeroNegativoError(Exception):
    pass


try:
    num:int = int(input('Mete un numero: '))
    if num < 0:
        raise NumeroNegativoError()
    
except ZeroDivisionError:
    print('Error por dividir entre 0.')
except ValueError:
    print('Valor no apto para este ejercicio.')
except NumeroNegativoError:
    print('Número menor de 0.')
except Exception as e:
    print('Fallo', e)
