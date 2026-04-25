// Variáveis 
double resultadoAtual = 0;
string[] historico = new string[10];
int totalOperacoes = 0;
bool executando = true;

Console.WriteLine("=== Calculadora Encadeada ===");
Console.WriteLine("Opções: 'h' para histórico, 'x' para sair");

Console.Write("Informe o número inicial: "); // Imput inicial
while (!double.TryParse(Console.ReadLine(), out resultadoAtual))
{
    Console.Write("Número inválido. Digite novamente: ");
}

while (executando) // Loop Principal
{
    Console.WriteLine($"\nResultado atual: {resultadoAtual}");
    Console.Write("Informe a operação (+, -, *, /) ou comando (h, x): ");
    string entrada = Console.ReadLine().ToLower();

    switch (entrada) // Switch para processar a entrada do usuário
    {
        case "x":
            executando = false;
            Console.WriteLine("\n--- Histórico Final ---");
            if (totalOperacoes == 0) Console.WriteLine("Vazio.");
            else
            {
                for (int i = 0; i < totalOperacoes; i++) Console.WriteLine(historico[i]);
            }
            break;

        case "h":
            Console.WriteLine("\n--- Histórico Atual ---");
            if (totalOperacoes == 0) Console.WriteLine("Nenhuma operação realizada.");
            else
            {
                for (int i = 0; i < totalOperacoes; i++) Console.WriteLine(historico[i]);
            }
            break;

        case "+":
        case "-":
        case "*":
        case "/":
            // Validação de operação antes do número
            Console.Write("Informe o próximo número: ");
            double proximo;
            while (!double.TryParse(Console.ReadLine(), out proximo))
            {
                Console.Write("Número inválido. Digite novamente: ");
            }

            double numAnterior = resultadoAtual;
            bool erro = false;

            switch (entrada) // Switch para realizar a operação matemática
            {
                case "+": resultadoAtual += proximo;
                break;

                case "-": resultadoAtual -= proximo; 
                break;

                case "*": resultadoAtual *= proximo; 
                break;

                case "/":
                    if (proximo == 0)
                    {
                        Console.WriteLine("Erro: Divisão por zero!");
                        erro = true;
                    }
                    else
                    {
                        resultadoAtual /= proximo;
                    }
                    break;
            }

            if (!erro)
            {
                string registro = $"{numAnterior} {entrada} {proximo} = {resultadoAtual}";

                // Armazenamento do histórico.
                if (totalOperacoes < 10)
                {
                    historico[totalOperacoes] = registro;
                    totalOperacoes++;
                }
                else
                {
                    for (int i = 0; i < 9; i++) historico[i] = historico[i + 1];
                    historico[9] = registro;
                }
            }
            break;

        default:
            Console.WriteLine("Erro: Operação inválida!");
            break;
    }
}