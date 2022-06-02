function teste () {
    return {nome: "Marcos",
    escrevernome: function (){
    console.log(this.nome);
    },
    mae: {nome: "Iza", idade: 62}, 
    idade: 25,
    habilitado: false,
    filhos: [{nome: "José", idade: 50}, {nome: "Maria", idade: 0}],
    cursos: ["JS", "JAVA", "C#"], 
    corCabelo: "Preto", 
    altura: 1.75
    };
}
console.log(teste());

function filhoscommaisdeumano () {
    return teste().filhos.filter((filhos) => {return filhos.idade > 1});
}
console.log(filhoscommaisdeumano());

/////////

function parouimpar (n1){
    var n1 = 7
    console.log(`O número ${n1} é par?`)
    if (n1%2 == 0){
        return true
    }else{
        return false
    };
}
console.log(parouimpar());