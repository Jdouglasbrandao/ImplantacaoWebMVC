using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;
using LHPet.model;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01, "Joao Douglas Rocha Brandao", "524.265.368-02", "jdouglasbb@gmail.com", "Kiko");
        Cliente cliente2 = new Cliente(02, "Joao  Rocha Brandao", "524.265.368-03", "jrocha@gmail.com", "zeze");
        Cliente cliente3 = new Cliente(03, "Douglas Rocha Brandao", "524.265.368-04", "douglasbb@gmail.com", "Dodo");
        Cliente cliente4 = new Cliente(04, "Douglas Brandao", "524.265.368-05", "Douglasbrandaob@gmail.com", "Jaum");
        Cliente cliente5 = new Cliente(05, "Joao  Brandao", "524.265.368-06", "joaobrandao@gmail.com", "Dao");
         
        List<Cliente> ListaClientes = new List<Cliente>();
        ListaClientes.Add(cliente1);
        ListaClientes.Add(cliente2);
        ListaClientes.Add(cliente3);
        ListaClientes.Add(cliente4);
        ListaClientes.Add(cliente5);

        ViewBag.ListaClientes=ListaClientes;

        Fornecedor fornecedor1 = new Fornecedor(01, "Douglas SA", "14.185.290/0008-90", "jdouglasbb@gmail.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "Rocha SA", "14.185.290/0008-70", "jdouglasdd@gmail.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "BrandaoD SA", "14.185.290/0008-40", "Brandao@gmail.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "Joao SA", "14.185.290/0008-50", "joao@gmail.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "Douglas Brandao SA", "14.185.290/0008-20", "douglasbrandao@gmail.com");

        List<Fornecedor> ListaFornecedores = new List<Fornecedor>();
        ListaFornecedores.Add(fornecedor1);
        ListaFornecedores.Add(fornecedor2);
        ListaFornecedores.Add(fornecedor3);
        ListaFornecedores.Add(fornecedor4);
        ListaFornecedores.Add(fornecedor5);

        ViewBag.ListaFornecedores=ListaFornecedores;
        
        
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
