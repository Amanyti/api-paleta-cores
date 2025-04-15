using Microsoft.AspNetCore.Mvc;

namespace PaletaCores.Controllers;

[ApiController]
[Route("[controller]")]
public class PaletaCoresController : ControllerBase
{
    private static readonly List<Dictionary<string, object>> Themes = new()
    {
        new Dictionary<string, object>
        {
            { "theme", "ocean" },
            { "cores", new Dictionary<string, string>
                {
                    { "primaria", "#B9E5E8" },    //COR DO FUNDO ESQUERDO 
                    { "secundaria", "#7AB2D3" },  //COR DO FUNDO DIREITO 
                    { "extra", "#4A628A" }    //COR DAS LETRAS E SHADOWS
                }
            }
           
        },
        new Dictionary<string, object>
        {
            { "theme", "dark" },
            { "cores", new Dictionary<string, string>
                {
                    {"primaria", "#040D12" },    
                    { "secundaria", "#183D3D" },   
                    { "extra", "#5C8374" }    
                }
            }
            
        },
        new Dictionary<string, object>
        {
            { "theme", "ligt" },
            { "cores", new Dictionary<string, string>
                {
                    { "primaria", "#F8FAFC" },
                    { "secundaria", "#BCCCDC" },
                    { "extra", "#424242" }
                }
            }
        },
        new Dictionary<string, object>
        {
            { "theme", "pastel" }, 
            { "cores", new Dictionary<string, string>
                {
                    { "primaria", "#ADB2D4" },
                    { "secundaria", "#F7CFD8" },
                    { "extra", "#727D73" }
                }
            }
        },
        new Dictionary<string, object>
        {
            { "theme", "summer" },
            { "cores", new Dictionary<string, string>
                {
                    { "primaria", "#FF9B17" },
                    { "secundaria", "#FCB454" },
                    { "extra", "#4E1F00" }
                }
            }
        },
        new Dictionary<string, object>
        {
            { "theme", "christmas" },
            { "cores", new Dictionary<string, string>
                {
                    { "primaria", "#446A46" },
                    { "secundaria", "#990000" },
                    { "extra", "#FF9800" }
                }
            }
        },
        new Dictionary<string, object>
        {
            { "theme", "neon" },
            { "cores", new Dictionary<string, string>
                {
                    { "primaria", "#16FF00" },
                    { "secundaria", "#F0FF42" },
                    { "extra", "#E900FF" }
                }
            }
        },
         new Dictionary<string, object>
        {
            { "theme", "coffee" },
            { "cores", new Dictionary<string, string>
                {
                    { "primaria", "#503C3C" },
                    { "secundaria", "#7E6363" },
                    { "extra", "#3E3232" }
                }
            }
        },
          new Dictionary<string, object>
        {
            { "theme", "retro" },
            { "cores", new Dictionary<string, string>
                {
                    { "primaria", "#A0C878" },
                    { "secundaria", "#EB5B00" },
                    { "extra", "#143D60" }
                }
            }
        },
           new Dictionary<string, object>
        {
            { "theme", "gold" },
            { "cores", new Dictionary<string, string>
                {
                    { "primaria", "#F3FEB8" },
                    { "secundaria", "#FFDE4D" },
                    { "extra", "#FFB22C" }
                }
            }
        }

    };  

    [HttpGet(Name = "GetPaletaCores")]
    public IActionResult Get()
    {
        var randomTheme = Themes[Random.Shared.Next(Themes.Count)];
        return Ok(randomTheme);
    }


    // NOVO ENDPOINT - Busca paleta por nome
    [HttpGet("{nomePaleta}")]
    public IActionResult GetPorNome(string nomePaleta)
    {
        // Busca a paleta com nome correspondente (case insensitive)
        var paleta = Themes.FirstOrDefault(t =>
            t["theme"].ToString().Equals(nomePaleta, StringComparison.OrdinalIgnoreCase));

        if (paleta == null)
        {
            return NotFound($"Paleta '{nomePaleta}' não encontrada");
        }

        return Ok(paleta);
    }

}



