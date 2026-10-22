package com.ggp.planes.ui.screen

import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.foundation.lazy.items
import androidx.compose.foundation.text.KeyboardActions
import androidx.compose.foundation.text.KeyboardOptions
import androidx.compose.material3.Checkbox
import androidx.compose.material3.Switch
import androidx.compose.material3.Text
import androidx.compose.material3.TextField
import androidx.compose.runtime.Composable
import androidx.compose.runtime.getValue
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.runtime.setValue
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.text.input.ImeAction
import androidx.compose.ui.text.input.KeyboardType
import androidx.compose.ui.tooling.preview.Preview
import com.ggp.planes.ui.component.SiteCard
import com.ggp.planes.data.Site

@Composable
fun SitesScreen(modifier: Modifier = Modifier){

    // DATOS QUE MUESTRA LA INTERFAZ

    //VARIABLE PARA BUSCAR EN LA LISTA DE SITIOS
    var textoBusqueda by remember{ mutableStateOf("") }
    var isCheckBoxFavPresionado by remember { mutableStateOf(false) }
    var isSwitchFavPresionado by remember { mutableStateOf(false) }

    //LAMBDA QUE VA A FILTRAR LA LISTA, TANTO POR EL [textoBusqueda]
    //COMO POR [isCheckBoxFavPresionado]
    val listaFiltrada = { listaSitios: List<Site>, esPresionado: Boolean ->
        var listaFinal = listOf<Site>()
        if(esPresionado){
            listaFinal  = listaSitios.filter { sitio : Site ->
                sitio.esFavorito &&
                        sitio.nombre.contains(textoBusqueda, ignoreCase = true) ||
                        sitio.direccion.contains(textoBusqueda, ignoreCase = true)
            }
        } else {
            listaFinal = listaSitios.filter { sitio: Site ->
                sitio.nombre.contains(textoBusqueda, ignoreCase = true) ||
                        sitio.direccion.contains(textoBusqueda, ignoreCase = true)
            }
        }
        //NO HAY RETURN EXPLICITO, DIRECTAMENTE SE REFERENCIA LA VARIABLE
        listaFinal
    }
    //LISTA CON LOS SITIOS QUE MOSTRAREMOS EN LA COLUMNA
    val listaSitios = listOf<Site>(
        Site(
            nombre = "Colegio Joyfe",
            direccion = "Calle Vital Aza 65",
            esFavorito = true
        ),
        Site(
            nombre = "Colegio Fundacion Caldeiro",
            direccion = "Avenida de los Toreros 48",
            rating = 3.5
        ),
        Site(
            nombre = "Colegio Goyfe",
            direccion = "Calle Vital Zaza 67",
            esFavorito = true
        )
    )

    //INTERFAZ
    LazyColumn(
        modifier = modifier.fillMaxWidth(),
        horizontalAlignment = Alignment.CenterHorizontally
    ) {
        //ITEM -> ELEMENTO EN PARTICULAR, SOLO UNO
        item {
            TextField(
                value = textoBusqueda,
                onValueChange = { textoUsuario ->
                    textoBusqueda = textoUsuario
                },
                maxLines = 1,
                //TODO: Acciones a definir en el teclado
                keyboardActions = KeyboardActions(


                ),
                keyboardOptions = KeyboardOptions(
                    imeAction = ImeAction.Search,
                    keyboardType = KeyboardType.Text
                )
            )
        }
        item {
            Checkbox(
                onCheckedChange = {
                    isCheckBoxFavPresionado = !isCheckBoxFavPresionado
                },
                checked = isCheckBoxFavPresionado,
                enabled = false
            )
            Text(text = "Filtrar favorito")
        }

        item {
            Column(
                horizontalAlignment = Alignment.CenterHorizontally
            ) { }

                Switch(
                    checked = isSwitchFavPresionado,
                    onCheckedChange = {
                        isSwitchFavPresionado = !isSwitchFavPresionado
                        isCheckBoxFavPresionado = false
                    }
                )
                Text(text = "Habilitar Checkbox")

        }
        //ESTAMOS FILTRANDO LOS ELEMENTOS DE LA LISTA PERO, AL TENENER LA LLAMADA A FILTRER, SOLO PINTAREMOS LOS ELEMENTOS QUE CUMPLAN
        // LA CONDICION EN ESTE CASO LA CONDICION ES QUE EL TEXTOBUSQUEDA CONTENGA CARCATERES DEL NOMBRE O DIRECCION
        items(listaFiltrada(listaSitios,isCheckBoxFavPresionado)
        ){ sitio ->
            SiteCard(sitio=sitio)
        }
    }
}


@Composable
@Preview
fun SitesScreenPreview(){
    SitesScreen()
}