﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MD.GA.BE.Entidades;
using MD.GA.BL.Base;
using MD.GA.COMMOM.Response;

namespace MD.GA.BL.BusinessInterfaces
{
    public interface IArticuloService : IBaseService<Articulo>
    {
        Response<List<Articulo>> ListarArticulosByStock(int idArea, string nombreArticulo, bool conStock, bool bajoStock, bool sinStock);
    }
}
