﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CN_Auto
    {
        private CD_Auto AutoCD = new CD_Auto();
        public CE_Time GuardarAuto(CE_Auto a, CE_Time t)
        {
            t = AutoCD.ActualizarAuto(a, t);
            return t;
        }
        public DataTable ListarArchivos(DataTable archivo)
        {
            archivo = AutoCD.ListArchive(archivo);
            return archivo;
        }
        public DataTable ListarActivos(DataTable activos)
        {
            activos = AutoCD.ListArchive(activos);
            return activos;
        }
        public DataTable ObtenerAuto(DataTable auto)
        {
            auto = AutoCD.ObtenerAuto(auto);
            return auto;
        }
    }
}