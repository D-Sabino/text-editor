using System;
using System.IO;
using System.Text;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==== Editor de Texto ====");
                Console.WriteLine("1 - Abrir arquivo");
                Console.WriteLine("2 - Criar novo arquivo");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                if (!short.TryParse(Console.ReadLine(), out short option))
                {
                    Console.WriteLine("Entrada inválida! Pressione Enter para tentar novamente.");
                    Console.ReadLine();
                    continue;
                }

                switch (option)
                {
                    case 0:
                        Console.WriteLine("Saindo do programa...");
                        Environment.Exit(0);
                        break;
                    case 1:
                        Abrir();
                        break;
                    case 2:
                        Editar();
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Pressione Enter para tentar novamente.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Digite o caminho completo do arquivo para abrir ou pressione Enter para listar diretórios:");
            string inputPath = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(inputPath))
            {
                ListarDiretorios();
                Console.WriteLine("\nDigite o caminho completo do arquivo:");
                inputPath = Console.ReadLine();
            }

            try
            {
                using (var file = new StreamReader(inputPath))
                {
                    string text = file.ReadToEnd();
                    Console.Clear();
                    Console.WriteLine("==== Conteúdo do Arquivo ====\n");
                    Console.WriteLine(text);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao abrir o arquivo: {ex.Message}");
            }

            Console.WriteLine("\nPressione Enter para voltar ao menu.");
            Console.ReadLine();
        }


        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo. (Ctrl + S para salvar, Ctrl + Q para sair sem salvar)");

            var textBuilder = new StringBuilder();

            while (true)
            {
                var keyInfo = Console.ReadKey(intercept: true);

                // Detectar comandos especiais (Ctrl + S e Ctrl + Q)
                if (keyInfo.Modifiers == ConsoleModifiers.Control)
                {
                    if (keyInfo.Key == ConsoleKey.S)
                    {
                        Salvar(textBuilder.ToString());
                        break;
                    }
                    else if (keyInfo.Key == ConsoleKey.Q)
                    {
                        Console.WriteLine("\nSaindo sem salvar...");
                        break;
                    }
                }
                // Tratar Enter como quebra de linha
                else if (keyInfo.Key == ConsoleKey.Enter)
                {
                    textBuilder.Append(Environment.NewLine);
                    Console.WriteLine(); // Quebra a linha na interface do console
                }
                // Permitir apagar caracteres com Backspace
                else if (keyInfo.Key == ConsoleKey.Backspace && textBuilder.Length > 0)
                {
                    textBuilder.Remove(textBuilder.Length - 1, 1);
                    Console.Write("\b \b"); // Remove o caractere visualmente no console
                }
                // Adicionar outros caracteres ao texto
                else
                {
                    textBuilder.Append(keyInfo.KeyChar);
                    Console.Write(keyInfo.KeyChar); // Mostra o caractere digitado no console
                }
            }
        }


        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Digite o caminho completo para salvar o arquivo ou pressione Enter para listar diretórios:");
            string inputPath = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(inputPath))
            {
                ListarDiretorios();
                Console.WriteLine("\nDigite o caminho completo para salvar o arquivo:");
                inputPath = Console.ReadLine();
            }

            try
            {
                using (var file = new StreamWriter(inputPath))
                {
                    file.Write(text);
                }
                Console.WriteLine($"Arquivo salvo com sucesso em: {inputPath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar o arquivo: {ex.Message}");
            }

            Console.WriteLine("Pressione Enter para voltar ao menu.");
            Console.ReadLine();
        }

        static void ListarDiretorios()
        {
            Console.WriteLine("Listando arquivos e diretórios no diretório atual:");
            string currentDir = Directory.GetCurrentDirectory();

            foreach (var dir in Directory.GetDirectories(currentDir))
            {
                Console.WriteLine($"[D] {dir}");
            }

            foreach (var file in Directory.GetFiles(currentDir))
            {
                Console.WriteLine($"[F] {file}");
            }
        }


    }
}
