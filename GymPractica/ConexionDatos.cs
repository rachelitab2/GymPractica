﻿using System;
using Microsoft.Data.SqlClient;

namespace GymDatos

{
    // nuevos cambios 
    //Realizar conexion 
    public class ConexionDatos //Conexion a  BD
    {
        public static string Conexion = "Server=.;Database=Gimnasio;Integrated Security=true;Encrypt=false;TrustServerCertificate=true";
    }
}
