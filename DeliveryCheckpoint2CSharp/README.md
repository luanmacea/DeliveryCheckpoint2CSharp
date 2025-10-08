```markdown
# DeliveryCheckpoint2CSharp

Sistema de Delivery/Restaurante — Projeto ASP.NET Core Web API com Oracle

## 🎯 Objetivo
API RESTful para gerenciar clientes, produtos, pedidos e entregas de um sistema de delivery. Permite login, cadastro, edição e consulta de dados no banco Oracle.

---

## 🗂️ Estrutura do Projeto

```

├── Controllers/      # Lógica das APIs (Cliente, Produto, Pedido, Entrega, Auth)
├── Models/           # Entidades do sistema
├── Data/             # ApplicationDbContext (EF Core)
├── appsettings.json  # Configuração (inclui string de conexão Oracle)
├── Program.cs        # Inicialização e configuração do projeto

```

---

## ⚙️ Como rodar o projeto

1. **Clone o repositório**
2. **Configure o banco Oracle** (verifique a string de conexão em `appsettings.json`)
3. **Restaure os pacotes**
```

dotnet restore

```
4. **Execute as migrações (opcional, se usar EF para criar o schema)**
```

dotnet ef database update

```
5. **Rode a aplicação**
```

dotnet run

````
6. **Acesse o Swagger**  
O Swagger abre automaticamente (ex: [https://localhost:7068/swagger](https://localhost:7068/swagger))

---

## 🔗 Endpoints Principais

| Método | URL                      | Descrição                  |
|--------|--------------------------|----------------------------|
| POST   | /api/Auth/login          | Login                      |
| GET    | /api/Cliente             | Listar clientes            |
| POST   | /api/Cliente             | Cadastrar cliente          |
| PUT    | /api/Cliente/{id}        | Editar cliente             |
| DELETE | /api/Cliente/{id}        | Excluir cliente            |
| GET    | /api/Produto             | Listar produtos            |
| POST   | /api/Produto             | Cadastrar produto          |
| ...    | ...                      | ...                        |

> Veja o Swagger para lista completa.

---

## 🧑‍💻 Exemplo de JSON (POST /api/Cliente)
```json
{
 "nome": "Maria Silva",
 "email": "maria@email.com",
 "telefone": "11988887777",
 "endereco": "Rua Exemplo, 123"
}
````

---

## 🛠️ Tecnologias usadas

* .NET 8 (ASP.NET Core Web API)
* Entity Framework Core
* Oracle Database (via Oracle.EntityFrameworkCore)
* Swagger para documentação

---

## 🙏 Observações

* Para testar login, cadastre usuários direto no banco.
* Senhas neste exemplo são armazenadas como texto puro por simplicidade (não recomendado para produção).
* Os endpoints foram organizados seguindo o padrão REST, com nomes intuitivos para cada recurso.

---

## 👨‍🏫 Autores

* Nome(s) da dupla
* Orientador: [Seu Professor]

---

```

---

Só **copie, cole e personalize** com o nome do seu grupo!  
Se quiser, posso adaptar para incluir links de exemplos do Postman, prints, ou outro detalhe específico.

Quer mais algum detalhe no README?  
##### 👑 Try the Premium version 👉🏻 [More details](https://gptstore.link/product/c-ai-net-sharp-wizard/)
```
