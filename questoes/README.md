# Questionário conceitual

Responda as questões neste mesmo arquivo, por favor, responda com suas próprias palavras, com sinceridade quando não conhecer determinado assunto.

1. Conhece GIT? Já o utilizou em algum projeto?
Sim. Em vários projetos em equipe, trabalhando com branch, merge, pull request

2. Qual a diferença entre GIT e GITHUB?
GitHub é uma plataforma para o armazenamento dos códigos, tanto para projetos pessoais, ou o compartilhamento entre a equipe, de forma a gerenciar o projeto.
Já o Git é um sistema de controle de versão, onde o usuário consegue criar seu repositório, branchs, commits, pull, push, merge, entre outros para a plataforma que seu código será armazenado, como por exemplo GitHub, Gitlab, Bitbucket, etc

3. Conhece ou tem experiência com desenvolvimento Web? Descreva como se dá a requisição HTTP entre um cliente e o servidor, e como se dá a resposta.
O HTTP funciona como uma ponte entre cliente e o servidor. No caso o cliente faz uma requisição para o servidor, podendo enviar ou não alguma informação, dependo o método utilizado, como post, get, delete, put, etc, se os dados forem enviados da forma correta, o servidor retornará uma resposta.

4. Conhece API REST? Para que são utilizadas? Cite dois exemplos.
Sim. Ela é quem faz a ponte entre os dados do back end, para o front end, sendo o intermediador. Isso, facilita a manutenção, pois é possível alterar a tecnologia do back ou do front sem quebrar a API, respeitando claro os formatos que já foram definidos. Exemplos: Google Maps, Via Cep

5. Conhece o conceito de AJAX? Descreva a tecnologia utilizada.
É o uso do objeto XMLHttpRequest para se comunicar com o servidor, e que pode enviar e receber informações em vários formatos, como JSON, XML, HTML.
Com ele é possivel fazer requisições pra o servidor sem recarregar a página, e receber e trabalhar com dados do servidor.

6. Conhece o conceito de assincronicidade ? Como usar na tecnologia deste desafio ?
Sim. Alguns recursos externos podem levar um certo tempo para ser processado, podendo causar erros na aplicação. Com isso as funções assíncronas esperam que as informações sejam carregadas, para depois ser mostrado o conteúdo, e também permite tratar esse conteúdo, de forma a mostar ao usuário que a informação ainda está sendo carregada, e caso ocorra algum erro, esse erro será tratado também.

7. Conhece padrões de projeto ? Descreva um cenário onde usaria um padrão de projeto que implementa IoC, e qual seria este padrão.
Sim. É muito importante separar a lógica da interface, visto que para fazer manutenção é muito mais simples e seguro, além de abstrair os widgets para serem reaproveitado.
A estrutura que criaria utilizando o Getx como gerenciador seria:
Na raiz da nossa lib temos o main.dart que é exigido nele no nosso main temos as inicializações dele com WidgetsFlutterBinding, GetStorage, Firabase, etc. e nosso runAPP executa o arquivo AppWidget, que é o MateriaApp ou GetMarialApp que é inicializado, com nosso tema, rotas, internacionalização, e por ultimo nosso AppBinding que faz as injeções com o GetConnect, Token.
- Core: Nessa pasta estaria os arquivos para imagens, cores, erros, tema do app, validadores, constants e tokens.
- Infra: Essa pasta estaria os arquivos para a comunicação com a API, como arguments, models, repositories, providers e end-point.
- Presenter: Nela contém nossa Inferface, e cada uma das telas, são separadas em pastas, que contêm: Page(View), Controller(Lógica), Bindings(Injeções) e Widgets(os componentes que são extraídos das View).
- Routes: Para facilitar o uso das importações, essa pasta possui dois arquivos, um para as Paginas - AppPages com todas as telas com seus Bindings, as animações de transição, e ela recebe o RoutesImports, onde todos os paths das paginas estão nela seguido do prefixo 'export'.
- Shared: Nessa ultima pasta temos tudo que é usado em comum no app todo, ela é dividida em Utils => que são as snackbar, loader, ternarios, etc.
e a Widgets => que são todos os widgets que são utilizados em mais de uma pagina.



