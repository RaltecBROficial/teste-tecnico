# Questionário conceitual

Responda as questões neste mesmo arquivo, por favor, responda com suas próprias palavras, com sinceridade quando não conhecer determinado assunto.

1. Conhece GIT? Já o utilizou em algum projeto?
Sim, Já utilizei em diversos projetos

2. Qual a diferença entre GIT e GITHUB?
Basicamente o git é a ferramente que a gente usa para versionar os codigos, já o Github é a plataforma de hospedagem desse codigo

3. Conhece ou tem experiência com desenvolvimento Web? Descreva como se dá a requisição HTTP entre um cliente e o servidor, e como se dá a resposta.

Quando um cliente (geralmente um navegador da web) deseja obter informações de um servidor web, ele envia uma requisição HTTP para o servidor. Essa requisição geralmente é iniciada quando um usuário digita um URL em um navegador ou clica em um link. que basicamente executa uma ação no servidor e tras pra gente uma resposta, que é tratada e exibida para o cliente


4. Conhece API REST? Para que são utilizadas? Cite dois exemplos.
Sim, servem basicamente para diferentes aplicações com uma unica chamada. Um exemplo, precisa a gente tem um ecommerce que precisa acessar diferente banco de dados, pra isso a gente tem um unico serviço que faz a consulta nesses banco e retorna pra gente so o json que a gente precisa. Outro exemplo, e que a api rest oferece um padrão de comunicação

5. Conhece o conceito de AJAX? Descreva a tecnologia utilizada.
Sim, técnicas de desenvolvimento voltado para a web que permite que aplicações trabalhem de modo assíncrono, processando qualquer requisição ao servidor em segundo plano.
Um exemplo comum de uso do AJAX é a atualização de conteúdo dinâmico em uma página da web, como a sugestão de pesquisa enquanto um usuário digita em um campo de pesquisa, a atualização de comentários em uma postagem de blog sem recarregar a página inteira ou a verificação de novas mensagens em aplicativos de bate-papo em tempo real.

6. Conhece o conceito de assincronicidade ? Como usar na tecnologia deste desafio ?
Sim. Basicamente no desafio que a gente precisa fazer um sistema de vendas, nele os produtos poderiam estar dentro de um banco de dados, e quando a gente faz a chamada para buscar um deles por exemplo, existe um delay entre a chamada e o retorno da informação esse daily pode acabar quebrando nosso codigo caso não exista essa forma de tratar a assincronicidade. Basicamente no trecho do codigo aonde a gente sinaliza que vai rolar uma demora, o nosso codigo ele para naquele momento espera a resposta e continua a execução do codigo

7. Conhece padrões de projeto ? Descreva um cenário onde usaria um padrão de projeto que implementa IoC, e qual seria este padrão.
 Sim estou familiarizado. Um exemplo é: Suponha que você esteja desenvolvendo um sistema de comércio eletrônico que precisa calcular o custo de envio de produtos para diferentes destinos. Existem várias transportadoras disponíveis, como X, Y e Z, cada uma com suas próprias regras de cálculo de custo de envio. Além disso, você pode precisar adicionar novas transportadoras no futuro.

Nesse cenário, você poderia usar o padrão de Injeção de Dependência junto com o padrão IoC


