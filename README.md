# TextEditor

Um simples editor de texto baseado em console, desenvolvido em C#. Este programa permite criar, editar e salvar arquivos de texto diretamente no terminal. Além disso, você pode abrir arquivos existentes e visualizar seu conteúdo.

## Funcionalidades

1. **Abrir arquivo**: Visualize o conteúdo de arquivos de texto existentes.
2. **Criar novo arquivo**: Escreva e salve textos diretamente no console.
3. **Listagem de diretórios**: Visualize os arquivos e pastas no diretório atual para facilitar a navegação.
4. **Atalhos no modo de edição**:
   - `Ctrl + S`: Salvar o arquivo.
   - `Ctrl + Q`: Sair do modo de edição sem salvar.

## Requisitos

- .NET 6.0 ou superior instalado na máquina.

## Como usar

1. Clone este repositório:
   ```bash
   git clone https://github.com/seu-usuario/TextEditor.git
   ```

2. Navegue até o diretório do projeto:
   ```bash
   cd TextEditor
   ```

3. Compile e execute o programa:
   ```bash
   dotnet run
   ```

4. Use o menu para selecionar a funcionalidade desejada:

Digite o número correspondente à opção.
Siga as instruções exibidas no console.

## Menu Principal

### Opções disponíveis:

- **`1 - Abrir arquivo`**  
  Permite abrir um arquivo de texto para visualização.  
  - Digite o caminho completo do arquivo que deseja abrir.  
  - Caso não saiba o caminho, pressione `Enter` para listar os arquivos e diretórios no local atual.  

- **`2 - Criar novo arquivo`**  
  Permite criar e editar um novo texto.  
  - Digite o texto diretamente no console.  
  - Use os atalhos:  
    - `Ctrl + S`: Salvar o arquivo.  
    - `Ctrl + Q`: Sair do editor sem salvar.  

- **`0 - Sair`**  
  Encerra o programa.

### Exemplo de uso:

#### Criar e salvar um arquivo:
1. Escolha a opção **`2`** no menu principal.  
2. Digite o texto que deseja criar.  
3. Pressione **`Ctrl + S`** para salvar o texto.  
4. Informe o caminho onde o arquivo será salvo.  

#### Abrir um arquivo existente:
1. Escolha a opção **`1`** no menu principal.  
2. Digite o caminho completo do arquivo que deseja abrir ou pressione **`Enter`** para listar os arquivos no diretório atual.  
3. O conteúdo do arquivo será exibido no console.

#### Listar diretórios:
Caso precise localizar arquivos no diretório atual:
1. Pressione **`Enter`** quando solicitado o caminho do arquivo.  
2. O programa exibirá todos os diretórios e arquivos no local atual.  
3. Use as informações listadas para fornecer o caminho correto do arquivo ou diretório desejado.


## Conclusão
O **TextEditor** é uma ferramenta simples e prática para manipulação de arquivos de texto diretamente no console. Ele foi projetado com foco na facilidade de uso, permitindo criar, editar e abrir arquivos de maneira eficiente. Com recursos básicos como listagem de diretórios e atalhos úteis no modo de edição, este programa pode ser um ótimo ponto de partida para quem deseja explorar projetos em C#.

Sinta-se à vontade para contribuir com melhorias ou adaptações! Caso encontre problemas ou tenha sugestões, abra uma *issue* no repositório. 

Obrigado por utilizar o **TextEditor**! 🚀
