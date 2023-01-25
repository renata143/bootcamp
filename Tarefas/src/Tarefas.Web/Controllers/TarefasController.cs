
using Microsoft.AspNetCore.Mvc;
using Tarefas.Web.Models;

namespace Tarefas.Web.Controllers;

public class TarefasController : Controller 
{
    public IActionResult Create()
    {
        return View ();
    }

    public IActionResult Index()
    {
        var listaDeTarefas = new List <TarefaViewModel>()
        {
            new TarefaViewModel() {Titulo = "Escovar os dentes", Descricao = "Usar sensodine de manhã e não a noite"},
            new TarefaViewModel() {Titulo = "Arrumar a cama"},
            new TarefaViewModel() {Titulo = "Tirar o lixo", Descricao = "seg, quar, sex"},
        };
        return View(listaDeTarefas);
    }
}