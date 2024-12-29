# Gerenciador de Usuários
Este é um aplicativo simples de gerenciamento de usuários. Ele permite registrar usuários, listar todos os usuários registrados e buscar usuários pelo início do nome. O sistema utiliza uma lista para armazenar os dados dos usuários.

Funcionalidades
Registrar Usuário: Adiciona um novo usuário com nome, email e idade.

Listar Usuários: Exibe todos os usuários registrados, mostrando nome, email e idade.

Procurar Usuário: Permite procurar usuários pelo início do nome.

Tecnologias Utilizadas
C#: Linguagem de programação principal.
.NET: Plataforma para desenvolvimento da aplicação.

Como Usar
1. Clonar o Repositório
    Primeiramente, faça o clone deste repositório para a sua máquina local:
        git clone https://github.com/seuusuario/gerenciador-de-usuarios.git

2. Compilar e Executar o Programa
    Este projeto pode ser compilado e executado utilizando o Visual Studio ou a linha de comando do .NET. Para compilar e executar via linha de comando:

    Abra o terminal na pasta do projeto.
    Execute o comando para restaurar pacotes e compilar:

        dotnet build

    Para executar o programa, use:

        dotnet run

3. Interagindo com o Programa
    Após iniciar o programa, você verá o menu com as seguintes opções:

        --- Gerenciador de usuários ---
        1. Registrar Usuário
        2. Listar Todos Usuários
        3. Procurar usuário por nome
        4. Sair
        Selecione uma opção:

        Escolha a opção desejada digitando o número correspondente.

4. Exemplo de Fluxo

    Registrar Usuário:
    O programa pedirá para inserir o nome, email e idade do usuário.
    Caso algum dado seja inválido, uma mensagem de erro será exibida.

    Listar Usuários:
    Exibe todos os usuários registrados até o momento, com informações como nome, email e idade.

    Procurar Usuário:
    Você pode digitar o início do nome do usuário, e o programa retornará todos os usuários que correspondem à busca.