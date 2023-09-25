# Questionário conceitual

Responda as questões neste mesmo arquivo, por favor, responda com suas próprias palavras, com sinceridade quando não conhecer determinado assunto.

1. Conhece GIT? Já o utilizou em algum projeto?
Conheço, utilizo desde o início da minha carreira.

2. Qual a diferença entre GIT e GITHUB?
Git é a ferramenta utilizada para versionamento de código. Github é o site onde repositórios são criados e compartilhados.

3. Conhece ou tem experiência com desenvolvimento Web? Descreva como se dá a requisição HTTP entre um cliente e o servidor, e como se dá a resposta.
Sim, atuo em desenvolvimento web desde o início da minha carreira, o cliente por meio de uma requisição estabelece um contato com o servidor, 
sendo este realizado por meio de um método HTTP (POST, PUT, DELETE, PATCH, GET). Então a resposta é retornada ao cliente retornando um status code e podendo ou não possuir um body.

4. Conhece API REST? Para que são utilizadas? Cite dois exemplos.
Sim, são utilizadas para realizar alguma ação em sistemas por meio de uma requisição HTTP e podem ser utilizadas 
em desenvolvimento web e desenvolvimento de aplicativos desktop.

5. Conhece o conceito de AJAX? Descreva a tecnologia utilizada.
Sim, é uma library de javascript que pode ser utilizada como um client HTTP e pode estabelecer comunicações com API's REST.

6. Conhece o conceito de assincronicidade ? Como usar na tecnologia deste desafio ?
Sim, é uma forma de executar tarefas de forma paralela (assíncrona). Em C# se utiliza esse conceito por meio do uso das seguintes palavras chave:
"async", "await" e "Task".

Se usa async seguido de Task na assinatura do método e dentro dele quando alguma operação assíncrona for chamada se utiliza await. Exemplo:
async Task MetodoAssincrono()
{
    await MethodoAssincronoOutro();
}

7. Conhece padrões de projeto ? Descreva um cenário onde usaria um padrão de projeto que implementa IoC, e qual seria este padrão.
Sim, conheço a maioria das design patterns e aplico quando necessário.
Em projetos de API em C# é comum utilizarmos a inversão de controle, a fim de que não tenhamos que construir as classes e dependências necessárias se aplica a inversão de controle,
comumente aplicado no padrão repository.
