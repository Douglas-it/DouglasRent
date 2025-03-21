
# 📌 DouglasRent (Em Desenvolvimento)
⚠️ Este projeto ainda está em construção! Algumas funcionalidades podem estar incompletas ou sujeitas a mudanças.


> Um sistema de empréstimos e venda de livros desenvolvido em **ASP.NET Core MVC**.

## 🚀 Tecnologias Utilizadas

Este projeto foi desenvolvido com as seguintes tecnologias:

- 🟢 **ASP.NET Core MVC**
- 🟢 **Entity Framework Core**
- 🟢 **SQL Server**
- 🟢 **Bootstrap** (para o frontend)
- 🟢 **Identity Framework** (para autenticação)

## 🔧 Como Rodar o Projeto Localmente

### 1️⃣ Clonar o repositório
```bash
git clone https://github.com/Douglas-it/DouglasRent.git
cd DouglasRent
```

### 2️⃣ Configurar o Banco de Dados
- Certifique-se de ter o **SQL Server** instalado e rodando.
- Atualize as configurações de conexão no arquivo `appsettings.json`.
- Rode as migrations para criar o banco de dados:
```bash
dotnet ef database update
```

### 3️⃣ Executar o Projeto
```bash
dotnet run
```
O projeto estará disponível em `http://localhost:5000`.

## ✅ Funcionalidades

- 🔹 Cadastro, edição e exclusão de livros
- 🔹 Sistema de reservas e empréstimos
- 🔹 Login e autenticação de usuários


## 🛠️ Contribuição

Caso queira contribuir:
1. Faça um fork do repositório.
2. Crie uma branch com a sua feature (`git checkout -b minha-feature`).
3. Commit suas mudanças (`git commit -m 'Adicionando nova feature'`).
4. Faça um push para a branch (`git push origin minha-feature`).
5. Abra um Pull Request 🚀.

## 📜 Licença

Este projeto está sob a licença MIT. Sinta-se à vontade para utilizá-lo e modificá-lo.

---

