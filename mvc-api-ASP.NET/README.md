# Aplicação ASP.NET

> .NET Core 3.1<br>
> Web API Application.<br>

Instalação dos pacotes NuGets pelo console:<br>
 ```
Install-Package Microsoft.EntityFrameworkCore.SqlServer

Install-Package Microsoft.EntityFrameworkCore.Tools


```

## 💻 Conceitos :
<br>

- [x] MVC; 
- [X] DbContext;
- [X] System.ComponentModel.DataAnnotations;
- [X] Migrations;
- [X] Scaffold;

___________________________________________________________________________________________________________________________________________
  ## 💻 DBContext:<br>
  
  - Subscrita do método para configuração do Entity com o BD:<b>
  > String = Assistente de conexão. Se não estivesse na classe, poderia ser colocada como parãmetro no ServiceConfigure.<br>
  
  ```
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CursoMvc;Integrated Security=True");
        }
  ```
  <br>
  - Service do Startup:
  ```
  ConfigureServices.AddDbContext<Context>();
  ```
  <br>
  - Após asconfigurações acima, realizar os seguintes comandos no controller para adicionar o migrations e BD:
  ````
  Add-Migrations InitialCreate

  ````
  ````
  Update-Database
  ````
  <br>
  - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  <br>
  # Aplicação ASP.NET API
