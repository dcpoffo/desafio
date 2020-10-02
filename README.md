## Desafio Pública Tecnologia

### Problema
Maria é jogadora de basquete e registra manualmente sua pontuação em uma tabela. Ela anota os pontos que fez e sempre mantém atualizado o mínimo e o máximo de pontos por partida, bem como quantas vezes quebrou o recorde mínimo e máximo de pontos marcados.

### Objetivo
Desenvolver uma aplicação para facilitar o acompanhamento dos resultados dos jogos de Maria.

#### Rodando a aplicação no VSCode
Para que a aplicação seja executada, deve-se abrir o terminal no VSCode e executar os seguintes comandos:
(os próximos dois passos, devem ser executados apenas na primeira vez ou somente quando necessário)
- Passo 1: dentro de \backend: (executar somente uma vez, para a criação da base de dados. Banco de dados utilizado: MySQL)
```
dotnet ef database update
```
- Passo 2: dentro de \frontend: 
O próximo passo faz-se necessário somente caso necessite baixar/atualizar alguma dependencia do projeto. Antes da primeira vez que for rodar a aplicação, deve-se baixar todas as dependencias do projeto, executando o procedimento abaixo.
```
npm update
```
(os passos a seguir, devem ser executados após os passos anteriores)
- Passo 3: dentro de \backend:
```
dotnet watch run
```
- Passo 4: dentro de \frontend:
```
npm start
```

Se não apresentar nenhum erro, pode-se acessar a aplicação pelo navegador, através do endereço http://localhost:4200
