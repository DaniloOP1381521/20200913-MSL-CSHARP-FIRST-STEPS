# Escreva seu primeiro código C#
Comece escrevendo pequenos exemplos de código para aprender o básico da sintaxe C#!

Neste módulo, você irá:

* Escreva suas primeiras linhas de código C#
* Use duas técnicas diferentes para imprimir uma mensagem em um console de texto
* Diagnosticar erros ao digitar o código incorretamente
* Identifique diferentes elementos de sintaxe C#, como operadores, classes e método

## Introdução
A linguagem de programação CSharp permite que você crie muitos tipos de aplicativos, como:

* Aplicativos de negócios para capturar, analisar e processar dados
* Aplicativos da web dinâmicos que podem ser acessados ​​de um navegador da web
* Jogos, 2D e 3D
* Aplicações financeiras e científicas
* Aplicativos baseados em nuvem
* 9 Aplicativos para celular

Mas como você pode começar?

De longe, a melhor maneira de aprender a codificar é escrever o máximo de código possível. Portanto, encorajamos você a digitar junto com os exercícios neste módulo e os outros neste caminho de aprendizagem. Digitar o código você mesmo em cada exercício e resolver pequenos desafios de codificação acelerará seu aprendizado.
Além disso, você precisa começar a aprender pequenos conceitos básicos e desenvolvê-los com prática e exploração contínuas.

Neste módulo, você irá:

    Escreva suas primeiras linhas do código CSharp
    Use duas técnicas diferentes para imprimir uma mensagem em um console de texto
    Diagnosticar erros ao digitar o código incorretamente
    Identifique diferentes elementos de sintaxe C #, como operadores, classes e métodos

Ao final deste módulo, você será capaz de escrever código CSharp para imprimir uma mensagem em um console de texto, como o prompt de comando do Windows. Essas linhas de código darão a você uma primeira visão da sintaxe CSharp e fornecerão imediatamente percepções valiosas. Na verdade, este módulo apresentará muitas novas idéias, que serão expandidas em outros módulos.

## Exercício - "Olá, Mundo!"

Neste primeiro exercício prático, você usará C # para imprimir uma frase consagrada do programador na janela Output.

### Escreva sua primeira linha de código

Há uma longa tradição entre os desenvolvedores de software de imprimir a frase "Hello World!" para uma linha de comando ou janela de console. Como você verá, você pode aprender muito sobre programação e a linguagem de programação C # com este exercício simples.

### Etapa 1: Digite o código no Editor .NET

O Editor .NET e o painel de saída fornecem uma ótima experiência no navegador que é perfeita para esta abordagem de tutorial. O .NET Editor está localizado no lado direito desta página da web. O painel de saída está abaixo dele.

Posteriormente, você passará a usar o Visual Studio Code ou o Visual Studio IDE completo para construir exemplos de código maiores e mais interessantes - até mesmo aplicativos inteiros.

Digite este código no Editor .NET à direita:

Explicaremos como e por que funciona em breve. Mas primeiro, você deve vê-lo em execução e garantir que não o digitou incorretamente. Para fazer isso, você executará seu código.

Nota
Você pode ficar tentado a usar o botão Copiar ou Executar abaixo e pular toda a digitação. No entanto, recomendamos que você digite essa linha de código. Digitar o código você mesmo constrói memória muscular e ajuda a obter percepções que você não obteria de outra forma.

### Etapa 2: Pressione o botão verde Executar

O botão verde Executar executa duas tarefas:

* Compila seu código em um formato executável que um computador pode entender.
* Ele executa seu aplicativo compilado e produz o comando desejado.

### Etapa 3: Na janela de saída, observe o resultado
Você deve ver a seguinte saída:

### O que fazer se você vir uma mensagem de erro

Escrever código C # é um exercício de precisão. Se você digitar apenas um caractere incorretamente, verá uma mensagem de erro na área Saída ao executar o código.

Por exemplo, se você tivesse que usar incorretamente um c minúsculo na palavra console, como:

console.WriteLine ("Olá, mundo!");

Veríamos a seguinte mensagem de erro:

(1,1): erro CS0103: O nome 'console' não existe no contexto atual

A primeira parte (1,1) indica a linha e coluna onde ocorreu o erro. Mas o que essa mensagem de erro significa?

C # é uma linguagem que diferencia maiúsculas de minúsculas, o que significa que o compilador C # considera as palavras console e console tão diferentes quanto as palavras gato e cachorro. Às vezes, a mensagem de erro pode ser um pouco enganosa. Você precisará entender a verdadeira razão pela qual o erro existe, e isso vem ao aprender mais sobre a sintaxe do C #.

Da mesma forma, se você usou aspas simples para circundar a string literal Hello World! igual a:

Console.WriteLine ('Olá, mundo!');

Você veria a seguinte mensagem de erro:

(1,19): erro CS1012: Muitos caracteres no literal de caractere

Novamente, a linha 1, personagem 19 nos aponta para o culpado. Podemos usar a mensagem como uma pista enquanto investigamos o problema. Mas o que significa a mensagem de erro? O que exatamente é um "literal de caractere"? Enquanto vamos discutir literais de vários tipos de dados (incluindo literais de caracteres) em outro módulo, nosso conselho por enquanto é ter cuidado ao digitar o código.

Felizmente, os erros nunca são permanentes. Você simplesmente identifica o erro, corrige-o e executa novamente o aplicativo.

Se você obteve um erro ao executar seu código, pare um momento, observe atentamente e examine cada caractere e certifique-se de ter digitado essa linha de código exatamente.

Nota

O editor de código monitora constantemente o código que você escreve, realizando a pré-compilação para encontrar possíveis erros. Ele tentará ajudá-lo adicionando linhas vermelhas onduladas abaixo do código que produzirão um erro.

Erros comuns que novos programadores cometem:

* Usando letras minúsculas em vez de maiúsculas C no Console, ou as letras W ou L no WriteLine
* Usando uma vírgula em vez de um ponto entre Console e WriteLine
* Esquecer aspas duplas ou usar aspas simples para cercar a frase Hello World!
* Esquecer o ponto e vírgula no final do comando

Cada um desses erros impede que seu código seja compilado com êxito.

Supondo que você obteve êxito nas etapas anteriores, vamos continuar.

### Etapa 4: comente a linha de código anterior e, em seguida, adicione novas linhas de código no Editor .NET para imprimir uma nova mensagem

Modifique o código que você escreveu para que seja prefixado por um comentário de código usando duas barras // e, em seguida, adicione novas linhas de código para corresponder ao seguinte snippet de código:

// Console.WriteLine ("Hello World!");
Console.Write ("Parabéns!");
Console.Write ("");
Console.Write ("Você escreveu suas primeiras linhas de código!");

Pressione o botão verde Executar novamente. Desta vez, você deve ver a seguinte saída.

Parabéns! Você escreveu suas primeiras linhas de código!

Você cria um comentário de código prefixando uma linha de código com duas barras //. Isso instrui o compilador a ignorar todas as instruções nessa linha. Os comentários do código são úteis quando você não está pronto para excluir o código ainda, mas deseja ignorá-lo por enquanto. Você também pode usar comentários de código para adicionar mensagens a você mesmo que o lembrem do que o código está fazendo. Falaremos sobre comentários de código em um próximo módulo.

As três novas linhas de código adicionadas demonstraram a diferença entre os métodos Console.WriteLine () e Console.Write (). É certo que as novas linhas de código que você adicionou poderiam ser facilmente reduzidas a uma única linha de código, como você escreveu na Etapa 1. No entanto, queríamos que você aprendesse uma segunda técnica para imprimir uma mensagem no console de saída.

A primeira técnica usou Console.WriteLine () para imprimir uma mensagem inteira no console de saída. No final da linha, ele adicionou uma alimentação de linha semelhante a como você pode usar a tecla Enter ou Return no teclado para criar uma nova linha de texto.

A segunda técnica usava Console.Write () para imprimir no console de saída, mas no final não adiciona uma alimentação de linha. Portanto, a próxima chamada para Console.Write () imprime uma mensagem adicional na mesma linha.

Além de duas técnicas para imprimir mensagens no console de saída, há mais para aprender com este exercício. O que todas essas palavras e símbolos significam

## Como funciona

Para entender como seu código funciona, precisamos dar um passo atrás e falar sobre o que é uma linguagem de programação e como ela comunica seus comandos ao computador.

### O que é uma linguagem de programação?

Linguagens de programação como C # permitem que você escreva instruções que deseja que o computador execute. Cada linguagem de programação tem uma sintaxe diferente, mas depois de aprender sua primeira linguagem de programação e tentar aprender uma segunda, você perceberá rapidamente que todas elas compartilham muitas ideias semelhantes. O trabalho de uma linguagem de programação é permitir que um ser humano escreva instruções de forma legível e compreensível. As instruções que você escreve em uma linguagem de programação são chamadas de "código-fonte" ou apenas "código".

Nesse ponto, o código pode ser atualizado e alterado por um desenvolvedor de software, mas o computador não consegue entender o código. Primeiro, ele deve ser compilado em um formato que o computador possa entender.

### O que é compilação?

Um programa especial chamado compilador converte seu código-fonte em um formato diferente que pode ser executado pela CPU do computador. Quando você usou o botão verde Executar na unidade anterior, o código que você escreveu foi primeiro compilado e depois executado.

Por que precisamos compilar nosso código? Embora a maioria das linguagens de programação pareça enigmática no início, elas podem ser mais facilmente compreendidas por humanos do que a linguagem preferida do computador, que é expressa ligando ou desligando milhares ou milhões de minúsculos interruptores. Os compiladores unem esses dois mundos ao traduzir suas instruções legíveis por humanos em um conjunto de instruções compreensível por computador.

### O que é sintaxe?

A sintaxe ou linguagem de programação inclui as palavras-chave, os operadores (aqueles caracteres especiais do teclado como o ponto-e-vírgula ou parênteses) e outras regras gramaticais que o compilador impõe. As linhas de código que você digitou seguiram cerca de uma dúzia de regras de sintaxe diferentes e usaram pelo menos quatro operadores diferentes. Há muito a aprender, mas felizmente cada conceito é simples. Não desista! Você pode aprender!

Ao digitar código no Editor .NET, você deve ter notado mudanças sutis na cor de diferentes palavras e símbolos. O realce de sintaxe é um recurso útil que você começará a usar para identificar facilmente erros em seu código que não estejam em conformidade com as regras de sintaxe do C #. Na verdade, uma versão semelhante (e ainda mais robusta) desse recurso está disponível no Visual Studio Code e no Visual Studio IDE completo.

Como seu código funcionou?

Vamos nos concentrar na seguinte linha de código que você escreveu:

Console.WriteLine ("Hello World!");

Ao executar o código, você viu que a mensagem Hello World! foi impresso no painel de saída. Quando a frase está entre aspas duplas em seu código C #, ela é chamada de string literal. Em outras palavras, queríamos literalmente que os caracteres H, e, l, l, o e assim por diante fossem enviados para a saída. Você aprenderá sobre strings literais no módulo intitulado "Armazenar e recuperar dados usando valores literais e variáveis ​​em C #".

A parte WriteLine () é chamada de método. Você sempre pode identificar um método porque ele tem um conjunto de parênteses depois dele. Cada método tem uma função. O trabalho do método WriteLine () é gravar uma linha de dados na janela de saída. Os dados impressos são enviados entre os parênteses de abertura e fechamento como um parâmetro de entrada. Alguns métodos precisam de parâmetros de entrada, outros não. Mas se você quiser invocar um método, você deve sempre usar o parêntese após o nome do método. Os parênteses são conhecidos como o operador de invocação de método. Você aprenderá mais sobre como chamar métodos no módulo intitulado "Aproveitar bibliotecas de funcionalidade chamando métodos da Biblioteca de classes .NET em C #".

A parte do console é chamada de classe. As classes "possuem" métodos, ou talvez a melhor maneira de dizer isso é que os métodos residem dentro de uma classe. Para visitar o método, você deve saber em qual classe ele está. Por enquanto, pense em uma classe como uma forma de armazenar e organizar todos os métodos que fazem coisas semelhantes. Nesse caso, todos os métodos que operam em nosso painel de saída são definidos dentro da classe Console.

Também havia um ponto, ou ponto, que separava o nome da classe Console e o nome do método WriteLine (). O período é o operador de acesso ao membro. Em outras palavras, o ponto é como você "navega" da classe para um de seus métodos.

Finalmente, o ponto e vírgula é o operador de fim de instrução. Uma declaração é uma instrução completa em C #. O ponto-e-vírgula informa ao compilador que terminamos de digitar o comando.

Não se preocupe se todas essas idéias e termos não fizerem sentido. Por enquanto, tudo o que você realmente precisa lembrar é que, se quiser imprimir uma mensagem em uma janela de saída como um console:

* use Console.WriteLine ("Sua mensagem aqui");
* capitalize Console, Write e Line
* use a pontuação correta, pois eles têm uma função especial em C #
* se você cometer um erro, apenas localize, corrija e execute novamente ... você não pode realmente falhar

Dica

Crie uma folha de dicas para você mesmo até que tenha memorizado certos comandos de tecla.

### Compreendendo o fluxo de execução

Além disso, é importante entender o fluxo de execução. Em outras palavras, suas instruções de código foram executadas em ordem, uma linha por vez, até que não houvesse mais instruções para executar. Algumas instruções exigirão que a CPU espere antes de continuar. Outras instruções podem ser usadas para alterar o fluxo de execução. Você aprenderá sobre essas situações especiais à medida que aprender mais sobre a sintaxe e os métodos do C # na biblioteca de classes .NET.

Agora vamos testar o que você aprendeu. Cada módulo apresenta um desafio simples e, se você ficar preso, forneceremos uma solução. Na próxima unidade, você terá a chance de escrever um pouco de C # por conta própria.


## Desafio

Os desafios do código ao longo desses módulos irão reforçar o que você aprendeu e ajudá-lo a ganhar alguma confiança antes de continuar.

### Etapa 1: Exclua todo o código do exercício anterior no Editor .NET.

Selecione todo o código no Editor .NET e selecione a tecla del ou backspace para excluí-lo.

### Etapa 2: Escreva o código no Editor .NET para exibir duas mensagens.

Use as duas técnicas diferentes para imprimir as duas linhas da saída. Em outras palavras, você aprendeu como exibir uma mensagem em apenas uma linha de código e como exibir uma mensagem usando várias linhas de código. Use ambas as técnicas para este desafio. Não importa qual técnica você aplica a cada linha, e não importa quantas maneiras você divide uma das mensagens em várias linhas de código. Essa é sua escolha.

Não importa como você faça isso, seu código deve produzir a seguinte saída.

	Esta é a primeira linha.
	Esta é a segunda linha.

Se você ficar preso e precisar espreitar a solução ou terminar com êxito, continue para ver uma solução para este desafio

## Solução

O código a seguir é uma solução possível para o desafio da unidade anterior.

	Console.WriteLine("This is the first line.");
	Console.Write("This is ");
	Console.Write("the second ");
	Console.Write("line.");

Este código é apenas "uma solução possível" porque não especificamos qual técnica aplicar a qual linha de saída. No entanto, você deve ter usado os métodos Console.WriteLine () e Console.Write () para produzir a saída desejada.

	This is the first line.
	This is the second line.

Se você teve sucesso, parabéns! Continue para a verificação de conhecimento na próxima unidade.

Importante

Se você teve problemas para completar este desafio, talvez você deva revisar as unidades anteriores antes de continuar. Todas as novas ideias que discutiremos em outros módulos dependerão de sua compreensão das ideias que foram apresentadas neste módulo.

## Verificação de Conhecimento

### Teste seus conhecimentos

1) Qual é a principal tarefa do compilador?

* O compilador localiza principalmente erros de ortografia em seu código.
* O compilador principalmente reformata seu código.
* O compilador executa principalmente seu código.
* O compilador converte principalmente seu código em um formato executável que o computador pode entender.

2) Qual das afirmações a seguir é verdadeira sobre C #.

* C # não diferencia maiúsculas de minúsculas.
* Console é um método e WriteLine () é uma classe.
* Use aspas duplas para criar uma string literal.
* Se você cometer um erro ao escrever o código, terá que deletar tudo e começar de novo.

3) O que há de errado com esta linha de código? Console.WriteLine ("O que há de errado comigo?")

* O L em WriteLine deve ser minúsculo.
* Está faltando um ponto e vírgula no final
* A string deve usar aspas simples.
* Uma vírgula deve ser usada em vez de um ponto entre Console e WriteLine.

## Resumo

Nosso objetivo era escrever código que exibisse mensagens simples em um console de saída e, ao fazer isso, nos familiarizar com a sintaxe. Escrevemos nossas primeiras linhas de código usando a sintaxe C # básica. Aprendemos duas técnicas para exibir dados de string literal no console. Aprendemos o que procurar quando encontramos um erro em nosso código. E identificamos os elementos da sintaxe C #, como classes e métodos, e a finalidade de vários símbolos especiais conhecidos como operadores.

Parabéns por dar os primeiros passos para criar aplicativos mais sofisticados.

Saiba mais com uma série de vídeos do Channel 9

* [C# 101](https://channel9.msdn.com/Series/CSharp-101/?WT.mc_id=Educationalcsharp-c9-scottha)
* [C# avançado](https://channel9.msdn.com/Series/C-Advanced/?&WT.mc_id=EducationalAdvancedCsharp-c9-niner)