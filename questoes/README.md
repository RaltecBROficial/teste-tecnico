# Questionário conceitual

Responda as questões neste mesmo arquivo, por favor, responda com suas próprias palavras, com sinceridade quando não conhecer determinado assunto.

1. Conhece GIT? Já o utilizou em algum projeto?
* Conheço GIT. 
* Utilizo na minha empresa junto com o SVN e em todos os projetos que faço.

2. Qual a diferença entre GIT e GITHUB?
* O GIT é um controlador de versionamento local , já o GITHUB é principalmente uma plataforma de versionamento em nuvem mas que também conta com outras funcionalidades

3. Conhece ou tem experiência com desenvolvimento Web? Descreva como se dá a requisição HTTP entre um cliente e o servidor, e como se dá a resposta.
* Conheço e tenho projetos pessoais com desenvolvimento Web.
* O primeiro passo para um requisição http acontecer é o cliente informar um método para se comunicar com servidor , como por exemplo , get , post ,put , patch , delete , entre outros. Após isso é necessário uma url para informar ao servidor qual é o endereço do recurso que o cliente está esperando , junto a isso existe também os cabeçalhos que disponibilizam várias informações sobre a requisição e também algumas sobre a resposta , por exemplo , chave de autenticação para acessar o recurso , tipo de conteúdo dentro da requisição , tipo de conteúdo esperado do servidor e vários outros. Pode ser incluído na requisição algum "corpo", ou seja, algum dado necessário para acessar o recurso do servidor. Depois de enviada a requisição o servidor verifica as informações recebidas e retorna uma resposta junto com um código de status que pode ir de 100 até 599 , sendo os mais comuns os códigos 200 que indicam sucesso na requisição e os códigos 400 e 500 que indicam erro na requisição , erro de cliente e de servidor respectivamente.

4. Conhece API REST? Para que são utilizadas? Cite dois exemplos.
* Sim. 
* A API REST é utilizada para padronizar a criação e o consumo de APIS, para ser considerada uma API REST é necessário que a API siga algumas regras na maneira que ela é criada , algumas das principais carácteristicas da API REST é que ela é stateless, ou seja , não tem estado, outra carácteristica muito importante é que ela deve utilizar o protocolo http para se comunicar. 
* Como exemplos de API REST : api do spotify e api do google tradutor.

5. Conhece o conceito de AJAX? Descreva a tecnologia utilizada.
* Conheço o conceito central de AJAX , mas nunca utilizei ele "puro", normalmente utilizo com a abstração do axios. 
* A ideia central do AJAX é fazer atualizações na interface do usuário sem ser necessário recarregar toda a tela.

6. Conhece o conceito de assincronicidade ? Como usar na tecnologia deste desafio ?
* Sim.
* Assincronidade é realizar uma ou mais ações ao mesmo tempo. Um exemplo de utilização seria em uma aplicação frontend fazer uma requisição http para um servidor enquanto o usuário continua interagindo normalmente na aplicação , conseguindo assim executar duas ação em parelelismo sem ser necessário uma terminar para começar a outra.

7. Conhece padrões de projeto ? Descreva um cenário onde usaria um padrão de projeto que implementa IoC, e qual seria este padrão.
* Conheço um pouco , atualmente trabalho utilizando o padrão MVVM para desenvolvimento mobile. 
* Não tenho conhecimento em IOC para descrever um cenário ideal para utiliza-lo , mas sei que ele trabalha junto com DI (Dependency Injection).


