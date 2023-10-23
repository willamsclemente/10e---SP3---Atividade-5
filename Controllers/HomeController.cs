using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

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
        Cliente cliente1 = new Cliente(01, "Arthur A.Ferreira", "857.032.950-41", "arthur antunes@sp.senai.br", "Madruga");
        Cliente cliente2 = new Cliente(02, "William Henry Gates III", "039.618.250-09", "bill@microsoft.com", "Bug");
        Cliente cliente3 = new Cliente(03, "Ada Lovelace", "800.777.920-50", "ada@ada.language.com", "Byron");
        Cliente cliente4 = new Cliente(04, "Linus Torvalds", "933.622.400-03", "torvalds@osdl.org", "Pinguim");
        Cliente cliente5 = new Cliente(05, "Grace Hopper", "911.702.988-00", "grace.hopper@cobol.com", "Loboc");

        List<Cliente> ListaClientes = new List<Cliente>();
        ListaClientes.Add(cliente1);
        ListaClientes.Add(cliente2);
        ListaClientes.Add(cliente3);
        ListaClientes.Add(cliente4);
        ListaClientes.Add(cliente5);

        ViewBag.ListaClientes = ListaClientes;

        Fornecedor fornecedor1 = new Fornecedor(01, "C# PET S/A", "14.182.102/0001-80", "c-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "Ctrl Alt Dog", "15.836.698/0001-57", "ctrl@alt.dog.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "BootsPet INC", "40.810.224/0001-83", "boots.pet@gatomania.us");
        Fornecedor fornecedor4 = new Fornecedor(04, "TikTok Dogs", "87.945.350/0001-09","noisnamidia@tiktokdogs.uk");
        Fornecedor fornecedor5 = new Fornecedor(05, "Bifinho Forever", "18.760.614/0001-37","contato@bff.us");

        List<Fornecedor> ListaFornecedores = new List<Fornecedor>();
        ListaFornecedores.Add(fornecedor1);
        ListaFornecedores.Add(fornecedor2);
        ListaFornecedores.Add(fornecedor3);
        ListaFornecedores.Add(fornecedor4);
        ListaFornecedores.Add(fornecedor5);

        ViewBag.ListaFornecedores = ListaFornecedores;

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
