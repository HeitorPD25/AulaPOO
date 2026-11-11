# POO em C#: exemplos e exercícios de aula

Repositório com os códigos e exercícios das aulas de **Programação Orientada a Objetos em C#** da UC12 (Técnico em Informática, Senac), ministradas por Heitor Pereira Duarte.

Os projetos são aplicações de console e servem de material de consulta para a turma.

## O que você encontra aqui

| Tema | O que foi visto |
| --- | --- |
| Introdução ao C# e à POO | História do C#, estrutura de um programa, classes e objetos |
| Classes, métodos e construtores | Atributos com e sem valor inicial, métodos com e sem retorno, construtores com e sem parâmetros, comentários |
| Encapsulamento e herança | Modificadores de acesso, propriedades com validação, `private set`, `protected`, `: base(...)` |
| Abstração e polimorfismo | Classes e métodos `abstract`, `virtual` e `override`, `base.Metodo()`, sobrecarga x sobrescrita |
| Pacotes | Namespaces, `using`, organização em pastas e noções de pacotes NuGet |

## Os quatro pilares da POO

| Pilar | Ideia | Como aparece em C# |
| --- | --- | --- |
| Encapsulamento | Proteger os dados e validar o que entra | Atributos `private` e propriedades com validação |
| Herança | Reaproveitar o que já existe ("é um") | `class Filha : Pai` e `: base(...)` |
| Abstração | Modelar só o essencial | `abstract class` e métodos `abstract` |
| Polimorfismo | O mesmo pedido, respostas diferentes | `virtual`, `override` e coleções do tipo pai |

## Exercícios

O arquivo de enunciados traz quatro exercícios, um para cada tema principal:

1. **Conta bancária (encapsulamento):** classe `ContaBancaria` com `Saldo` protegido, `Depositar` (só valores positivos) e `Sacar` (devolve `bool`).
2. **Animais (herança):** `Animal` com `Nome` e `Apresentar()`, e as filhas `Cachorro` e `Gato`, cada uma com atributo e método próprios.
3. **Motores (abstração):** `Motor` abstrata com `Ligar()` abstrato, implementado em `MotorCombustao` e `MotorEletrico`.
4. **Notificações (polimorfismo):** `Notificacao` com `Formatar` virtual, sobrescrito em `NotificacaoEmail` e `NotificacaoSms`, percorridas em um `Notificacao[]` com `foreach`.

## Como executar

Pré-requisito: [.NET SDK](https://dotnet.microsoft.com/download) instalado (confira com `dotnet --version`).

```bash
# clonar o repositório
git clone <URL-DO-REPOSITORIO>
cd <PASTA-DO-REPOSITORIO>

# entrar na pasta de um projeto e executar
cd <PASTA-DO-PROJETO>
dotnet run
```

Também é possível abrir a pasta no Visual Studio ou no VS Code e executar por lá.

## Estrutura sugerida

```
.
├── README.md
├── enunciados.txt        # enunciados dos 4 exercícios
└── <um projeto por aula ou exercício>
    ├── Program.cs
    └── <classes do projeto>
```

## Observação

Os códigos são material didático e podem ter sido escritos durante as aulas, então servem de ponto de partida para estudo, não como solução definitiva.

## Autor

**Heitor Pereira Duarte** ([@HeitorPD25](https://github.com/HeitorPD25))
