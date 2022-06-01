// 1 - Faça uma função que retorne um 
//objeto que represente você, com os 
//seguintes atributos: 
//altura: ponto flutuante
//corCabelo: string
//cursos: array
//escreverNome: função que escreve seu nome
//filhos: array de objetos, o objeto filho precisa ter nome e idade
//habilitado: boolean
//idade: inteiro
//mae: objeto com nome e idade
//nome: string

function eu (){
    return {nome: "Cassia" ,
    escrevernome: function (){
        console.log(this.nome);
    },
    mae: {Nome: "Divina", Idade: 67}, 
    idade: 32,
    habilitado: true,
    filhos: [{nome: "Benjamin", idade: 7},
    {nome: "Samuel", idade: 4}],
    cursos: ["Análise e Desenvolvimento de Sistemas", "Metodologias Ágil", "Eletrônica"], 
    corcabelo: "Castanhos", 
    altura: 1.61};}

2 - faça uma função que utilize a função anterior e filtre pelos filhos com mais de 1 ano de idade.

3 - faça uma função que utilize a função 1 e obtenha somente o nome dos filhos com mais de 1 ano de idade.
