package com.ggp.planes.ui.navigation

import androidx.navigation3.runtime.NavKey
import kotlinx.serialization.Serializable

// AQUI VAN TODAS LAS REFERENCIAS A LAS RUTAS DISPONIBLES
// IMPORTANTE: NO ES SU CONTENIDO, SOLO SU DECLARACIÓN


// data object -> Rutas que NO necesitan argumentos
@Serializable
data object SitesNav: NavKey

// data class -> Rutas que SI necesitan argumentos
// LOS QUE QUERAMOS
@Serializable
data class SettingsNav(
    val textoEjemplo: String
): NavKey
