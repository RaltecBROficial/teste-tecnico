# Questionário conceitual

Responda as questões neste mesmo arquivo, por favor, responda com suas próprias palavras, com sinceridade quando não conhecer determinado assunto.

1. Conhece GIT? Já o utilizou em algum projeto?
 - Sim, GIT é um versionador de código nativo do Linux, amplamente utilizado nem projetos comerciais. Trabalho com versionamento de código utilizando GIT
 desde o início da minha carreira como desenvolvedor. Ainda falando um pouco sobre GIT, já trabalhei com workflow GitFlow, e ultimamente tenho estudado sobre trunk based.

2. Qual a diferença entre GIT e GITHUB?
 - Como falei na resposta anterior, Git é um tecnologia para versionamento de código, que cria um repositório para seu código, o GitHub é um repositório online para
 hospedar repositórios GIT.

3. Conhece ou tem experiência com desenvolvimento Web? Descreva como se dá a requisição HTTP entre um cliente e o servidor, e como se dá a resposta.
 - Tenho experiência sim desenvolvimento web, também deste a minha carreira sempre foi trabalhando em projetos web com ASP.NET, e agora ASP.NET CORE
 Entender como funcionar o protocolo HTTP é fundamental para o desenvolvimento. Basicamente o protocolo HTTP se baseia na comunicação entre client e server
 realizando request e reponses. o Client (navegador ou qualquer outro serviço) realiza uma request através do HTTP, um verbo GET ou POST, por exemplo, o server processa a request e devolve um response para o client, contento o resultado e também um status de sucesso, ou erro, ou outros códigos HTTP mais específicos.

4. Conhece API REST? Para que são utilizadas? Cite dois exemplos.
 - Conheço sim. As API são usadas para expor "portas de acesso" para obter informações de um sistema, repositório, dados de uma base de dados.
 Estas portas são os chamados endpoints, que é o ponto para onde é feita uma requisição. API REST porque se baseia nos verbos HTTP: GET, POST, PUT, DELETE, etc
 Exemplo muito simples, vou pegar os desafios deste teste, onde tem um repositório de dados sobre animais, estes dados estão num banco de dados, então desenvolvo uma API REST
 para poder expor estes, através, por exemplo, do verbo GET, onde um endpoint realiza a busca na base pode um determinado tipo de animal e retorna o resultado através do endpoint para quem fez a request, o caso devolvendo a response.
 Um outro exemplo, posso pegar algo do mundo real, o IBGE disponibiliza uma WEB API REST pública onde é possível buscar por todas as cidades do brasil através do código IBGE.

5. Conhece o conceito de AJAX? Descreva a tecnologia utilizada.
  - Conheço, é uma tecnologia que permite requisições assíncronas dentro de uma página web através do JavaScript. Confesso que trabalhei muito pouco com Ajax, pois hoje em dia com novos frameworks front-end, existem novas opções que são amplamente usadas, como axios e fetch.

6. Conhece o conceito de assincronicidade? Como usar na tecnologia deste desafio?
 - Conheço sim, o termo assíncrono diz que uma tarefa não precisa depender de outra finalizar para que esta tarefa inicie e termine sua execução. Vou dar o exemplo de e padeiros: O padeiro A precisa de massa, leite, ovo e sal (exemplos de ingrediente ilustrativos, não sei como se faz um pão kkkk) para fazer um pão, ao iniciar o processo
 de fazer o pão, o padeiro A começa pela batendo a massa, e em sequência adicionando os outros ingredientes, o padeiro B não precisa esperar o padeiro A terminar de fazer todo
 o processo do pão, enquanto o padeiro A já bateu a massa e começa a colocar os outros ingredientes, o padeiro B já pode iniciar a sua tarefa batendo a massa. Este foi um exemplo bem simples de tarefas assíncronas.
  - Neste desafio é possível aplicar assincronicidade nas açães dos animais, onde um animal, não necessariamente, precisa estar parado, sem andar, para comer.

7. Conhece padrões de projeto? Descreva um cenário onde usaria um padrão de projeto que implementa IoC, e qual seria este padrão.
 - Conheço padrões sim, são extremamentes recomendados e exigidos no desenvolvimento de software. IoC, também mais conhecido como Inversão de Controle, ou também Inversão de Dependência, é o padrão que especifica que a dependência de um objeto não deve depender da instaciação de um objeto. Por exemplo: eu tenho uma classe de serviço de CRUD
para a entidade Animal, esta classe de serviço precisa da instância da classe DAO, que realiza as operações CRUD, para a classe de serviço não precisar instanciar a classe DAO,
a classe DAO é injetada, através do constructor, ou outro meio, dentro da classe de serviço, isso é mais conhecido como Injeção de Dependência, que é o melhor exemplo para Inversão de Dependência.