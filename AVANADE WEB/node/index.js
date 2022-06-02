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
 altura: 1.75};
}
console.log(teste);