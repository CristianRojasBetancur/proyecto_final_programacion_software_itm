﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Nucleo
{
    public class DatosGenerales
    {
        public static string ruta_json = @"C:\Users\salak401\Desktop\proyecto_final_programacion_software_itm\secrets.json";
        public static bool usa_azure = false;
        public static string clave = "EVBgi345936456ghhVBJGtgnifytsidi3456678jhgUTytutyiiyi";
        public static string usuario_datos = EncriptarConversor.Encriptar("Test.Trghhjsgdj");
    }
}

