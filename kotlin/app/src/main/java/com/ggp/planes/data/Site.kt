package com.ggp.planes.data


//CLASE SITE
data class Site(
    val nombre: String,
    val direccion: String,
    val rating: Double=1.0,
    var esFavorito: Boolean = false
)
