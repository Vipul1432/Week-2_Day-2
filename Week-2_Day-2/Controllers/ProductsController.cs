﻿using Microsoft.AspNetCore.Mvc;
using Week_2_Day_2.Interfaces;
using Week_2_Day_2.Models;

namespace Week_2_Day_2.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductRepository _productRepository;
        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<Product> products = _productRepository.GetAllProducts();
            return View(products);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Product product = _productRepository.GetProductById(id);
            return View(product);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _productRepository.AddProduct(product);
                return RedirectToAction("Index");
            }

            return View(product);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Product product = _productRepository.GetProductById(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _productRepository.UpdateProduct(product);
                return RedirectToAction("Index");
            }

            return View(product);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _productRepository.DeleteProduct(id);
            return RedirectToAction("Index");
        }
    }
}
