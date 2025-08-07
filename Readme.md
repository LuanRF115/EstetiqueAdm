# EstetiqueAdmWeb

Sistema de administração para gerenciamento de empresas, usuários e serviços de um salão de estética, desenvolvido em C# com Windows Forms e MySQL.

## Funcionalidades

- **Empresas:** Visualização, atualização e exclusão de empresas cadastradas.
- **Usuários:** Visualização, atualização e exclusão de usuários cadastrados.
- **Serviços:** Busca, atualização e exclusão de serviços, com visualização de imagem via URL.

## Estrutura do Projeto

- `EstetiqueAdmWeb/`
  - `Form1.cs`: Tela principal do sistema.
  - `Empresas.cs`: Gerenciamento de empresas.
  - `Usuarios.cs`: Gerenciamento de usuários.
  - `Servicos.cs`: Gerenciamento de serviços.
  - `Database.cs`: Classe utilitária para conexão com o banco de dados.
  - `App.config`: Configuração da string de conexão com o MySQL.
  - `Properties/Resources.resx`: Recursos de imagens do sistema.
  - Arquivos `.Designer.cs` e `.resx`: Arquivos auxiliares do Windows Forms.

## Configuração do Banco de Dados

O sistema utiliza um banco MySQL chamado `bd_estetique`. Configure o acesso no arquivo [`App.config`](EstetiqueAdmWeb/App.config):

```xml
<connectionStrings>
  <add name="MinhaConexao" connectionString="SERVER=localhost;DATABASE=bd_estetique;UID=root;PASSWORD=;" />
</connectionStrings>
```

## Dependências

As principais dependências estão listadas em packages.config, incluindo:

- MySql.Data
- System.Configuration.ConfigurationManager
- BouncyCastle.Cryptography


## Como Executar
- Abra a solução EstetiqueAdmWeb.sln no Visual Studio.
- Restaure os pacotes NuGet.
- Certifique-se de que o banco de dados MySQL está rodando e configurado.
- Execute o projeto (F5).


## Telas
- Tela Principal: Acesso rápido para Empresas, Usuários e Serviços.
- Empresas: Listagem em grid, atualização inline e exclusão.
- Usuários: Listagem em grid, atualização inline e exclusão (remove também agendamentos relacionados).
- Serviços: Busca por ID, edição de dados, exclusão (remove também agendamentos relacionados) e visualização de imagem.


## Observações
- O projeto utiliza Windows Forms e não é compatível com .NET Core/5+.
- As imagens de fundo estão em Resources/ e são carregadas via arquivo de recursos.
- Para adicionar novas funcionalidades, utilize as classes e padrões já existentes