package com.ggp.planes.ui.navigation

import android.util.Log
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.padding
import androidx.compose.material.icons.Icons
import androidx.compose.material.icons.outlined.Settings
import androidx.compose.material3.FloatingActionButton
import androidx.compose.material3.Icon
import androidx.compose.material3.Scaffold
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.ui.Modifier
import androidx.navigation3.runtime.entryProvider
import androidx.navigation3.runtime.rememberNavBackStack
import androidx.navigation3.ui.NavDisplay
import com.ggp.planes.ui.screen.SitesScreen
import org.w3c.dom.Text

@Composable
fun Navigator(){
    //Crear el componente que se encarga de gestionar la navegación entre pantallas
    //del proyecto. El último elemento que añadamos a backStack será el que veamos en la pantalla
    val backStack = rememberNavBackStack(SitesNav)

    //Función que elimina el último destino de la lista de destinos.
    val volver: () -> Unit = {
        if(backStack.size > 1){
            backStack.removeLastOrNull()
        }
    }

    //Contenedor del contenido de la aplicación
    //Recibe como parámetros el backStack(osea la lista que observa para saber el destino actual
    //y las rutas donde debe volver), la acción al volver atrás y entryProvider, que es el lugar
    //donde definimos la relación entre los NavKeys y lo que pintan en pantalla
    NavDisplay(
        backStack = backStack,
        onBack = {
            volver()
        },
        entryProvider = entryProvider {
            entry<SitesNav>{
                Scaffold(
                    modifier = Modifier.fillMaxSize(),
                    floatingActionButton = {
                        FloatingActionButton(
                            onClick = {
                                Log.d("HOLA","Click en ajustes")
                                backStack.add(SettingsNav(textoEjemplo = "2º DAM C"))
                            }
                        ) {
                            Icon(
                                imageVector = Icons.Outlined.Settings,
                                contentDescription = "Icono de ajustes"
                            )
                        }
                    }
                ) { innerPadding ->
                    SitesScreen(
                        modifier = Modifier.padding(innerPadding)
                    )
                }
            }

            // Al ser una lambda, el objeto con los argumentos de la ruta se
            //recupera de la misma forma
            entry<SettingsNav> { rutaDestino: SettingsNav ->
                Scaffold(
                    modifier = Modifier.fillMaxSize()
                ) { innerPadding ->
                    Column(
                        modifier = Modifier.padding(innerPadding)
                    ) {
                        Text(text = rutaDestino.textoEjemplo)
                    }
                }
            }
        }
    )
}