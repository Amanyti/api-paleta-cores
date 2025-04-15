# 🎨 Projeto API - Paleta de Cores

Este projeto foi desenvolvido como parte do curso de extensão **"Trabalhando com APIs em C# e JavaScript"**. O objetivo do exercício é criar uma API própria e consumi-la por meio de uma interface HTML simples. Este projeto é um aplicação web que permite visualizar e explorar diferentes paletas de cores. Ele consome uma API REST que fornece combinações de cores pré-definidas. O usuário pode buscar paletas específicas por nome ou aleatórias.
> 🧠 Este projeto contou com o apoio da IA **DeepSeek** como assistente no desenvolvimento de código e da IA **ChatGPT** para a documentação.


## 📌 Funcionalidades e Estrutura do Projeto

A aplicação permite que o usuário:

- Digite o nome de uma **paleta de cores** e veja suas cores exibidas na página, junto com informações sobre cada uma.
- Clique em um botão para **escolher uma paleta aleatória**, que também será exibida dinamicamente.
- Utilize uma API criada no próprio projeto que armazena uma coleção de paletas de cores (em formato JSON), funcionando como um pequeno banco de dados.
- Consumo dos dados via JavaScript diretamente de um "endpoint" local
- Temas atualmente disponíveis: ocean, dark, light, pastel, summer, christmas, neon, coffee, retro e gold

O projeto é composto por dois principais arquivos:

- `index.html` → Página web com a interface de interação
- `PaletaCores` → Diretório da API ASP.NET Core


## 🛠️ Tecnologias Utilizadas


- Frontend → HTML5, CSS3 (com variáveis CSS) e JavaScript (Fetch API para consumo da API)
- Backend → ASP.NET Core (API REST) e Swagger para documentação da API

