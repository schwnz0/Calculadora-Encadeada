# Calculadora Encadeada com Histórico (C#)

Este projeto foi desenvolvido como parte de uma avaliação individual de lógica de programação. Trata-se de uma calculadora console que permite realizar operações matemáticas de forma encadeada, mantendo um histórico das últimas 10 operações realizadas.

## 🚀 Funcionalidades

- **Operações Básicas**: Soma, Subtração, Multiplicação e Divisão.
- **Cálculo Encadeado**: O resultado da operação anterior é utilizado automaticamente como base para a próxima.
- **Histórico (FIFO)**: Armazena as últimas 10 operações em um array. Quando o limite é atingido, a operação mais antiga é substituída pela nova.
- **Tratamento de Erros**: 
    - Impede divisão por zero.
    - Valida se a entrada de dados são números válidos.
    - Valida a operação antes de solicitar o próximo número.

## 🛠️ Comandos Especiais

Durante a execução, você pode usar os seguintes comandos:
- `h`: Exibe o histórico atual de operações.
- `x`: Encerra o programa e exibe o histórico final.

## 💻 Requisitos Técnicos Aplicados

- Estrutura de repetição `while`.
- Estrutura de decisão `switch`.
- Manipulação de arrays.
- Lógica de fila (First-In, First-Out).
- Top-level statements (C# moderno).

## 📖 Como executar

1. Certifique-se de ter o [.NET SDK](https://dotnet.microsoft.com/download) instalado.
2. Clone este repositório ou copie o arquivo `.cs`.
3. No terminal, execute:
   ```bash
   dotnet run
