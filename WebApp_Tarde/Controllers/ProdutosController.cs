﻿using Microsoft.AspNetCore.Mvc;

namespace WebApp_Tarde.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly Contexto db;

        public ProdutosController(Contexto opt)
        {
            db = opt;
        }

        public IActionResult Lista()
        {
            return View( db.Produtos.ToList() );
        }
    }
}
