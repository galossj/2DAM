# Manual de markdown

**Nota:** Para verlo en `VSC formateado`  
a) Ctrl+K   v   
b) Ctrl+Shift+V  

## Listas

Prevision resultados Liga 26/27
1. Atlético de Madrid
2. Getafe CF
3. Rayo Vallecano
---  
Lista compra(desordenada)
- Vapel
- Zaza
- Yeti
- Pila de hoes
---
Párrafo de texto.  
Otro igual.  
Y otro también muy parecido.  
---
> Guillermo Galocha Pérez  
---
<br>Me llamo Guillermo<br>
---
Texto normal  
*Texto en cursiva*  
**Texto en negrita**  
***Texto en negrita y en cursiva***  
<!-- COMENTARIO OCULTO (ctrl+ç) -->
---
Ir a la [TIENDA](https://shop.atleticodemadrid.com/es/home)
---
### Ejemplo de código typescript  
```ts
// 1. Definición de una Interfaz
interface Producto {
    id: number;
    nombre: string;
    precio: number;
    disponible: boolean;
}

// 2. Creación de una Clase
class CarritoDeCompras {
    // Tipado explícito de arreglos
    private lista: Producto[] = [];

    // Método para agregar productos
    public agregar(producto: Producto): void {
        this.lista.push(producto);
        console.log(`🛒 Agregado: ${producto.nombre}`);
    }

    // Método que calcula y retorna un número
    public calcularTotal(): number {
        return this.lista.reduce((total, prod) => total + prod.precio, 0);
    }

    // Método para mostrar el resumen
    public mostrarResumen(): void {
        console.log("\n--- Resumen del Carrito ---");
        this.lista.forEach(prod => {
            console.log(`- ${prod.nombre}: $${prod.precio}`);
        });
        console.log(`Total a pagar: $${this.calcularTotal()}`);
    }
}

// 3. Uso del código
const miCarrito = new CarritoDeCompras();

// Objetos que cumplen con la interfaz 'Producto'
const producto1: Producto = { id: 1, nombre: "Laptop", precio: 899.99, disponible: true };
const producto2: Producto = { id: 2, nombre: "Mouse Óptico", precio: 25.50, disponible: true };

miCarrito.agregar(producto1);
miCarrito.agregar(producto2);

miCarrito.mostrarResumen();  
```

### Tablas
---
| Numero |  Nombre   | Teléfono  |
| :----: | :-------: | :-------: |
|   1    |  Perico   | 600700800 |
|   2    | Fulanito  | 600123123 |
|   3    | Menganito |    697    |
|   4    |   Luis    |  879811   |