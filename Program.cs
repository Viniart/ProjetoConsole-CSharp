// Declarando as variáveis do meu sistema
string[] nomes = new string[2];
string[] origem = new string[2];
string[] destino = new string[2];
string[] data = new string[2]; // DateTime

Console.WriteLine("---------------------------");
Console.WriteLine("Sistema de Passagens Áereas");
Console.WriteLine("---------------------------");

EfetuarLogin();

Console.WriteLine("Menu Inicial");
Console.WriteLine("Selecione uma opção: ");
Console.WriteLine("[1] - Cadastrar uma Passagem");
Console.WriteLine("[2] - Listar as Passagens");
Console.WriteLine("[0] - Sair do Sistema");

int opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    // Decidir o que fazer quando o cara escolhe uma opcao
}

static void EfetuarLogin()
{
    string senhaRecebida;
    do
    {
        Console.WriteLine("Digite sua Senha: ");
        senhaRecebida = Console.ReadLine();
    } while (senhaRecebida != "123456");
}