const express = require('express');
const bodyParser = require('body-parser');
const app = express();
app.use(bodyParser.json());

var lista = [];

function teste(req, res) {
    res.send(lista);
}

        function testedeinsercao(req, res) {
            const pokemon = req.body;
                lista.push(pokemon);
                res.send('Pokemon adicionado com Sucesso');
            }
        
    
 

app.get('/pokemon', teste);
app.post('/pokemon', testedeinsercao );


/////

var lista2 = [];

function getProduto(req, res) {
    res.send(lista2);
}

function criandoProduto(req, res) {
    const produto = req.body;
    const produtoPesquisado = lista2.find((produtoNaLista) => produtoNaLista.name == produto.name);
    if (!produtoPesquisado) {
        lista2.push(produto);
        res.send('inserido com sucesso');
    } else {
        res.send(`não é possível inserir pois já existe um Produto com nome ${produto.name}`);
    }
}

function getProdutoById(req, res) {
    const nomeProduto = req.params.id;
    const produtoPesquisado = lista2.find((produtoNaLista) => produtoNaLista.name == nomeProduto);
    if(!produtoPesquisado){
        res.send(`não existe um produto com este nome ${nomeProduto}`)
    } else {
        res.send(produtoPesquisado);
    }
}

function deleteProduto(req, res) {
    const nomeProduto = req.params.id;
    lista2 = lista2.filter((produto) => produto.name != nomeProduto);
    res.send(`O produto com o nome ${nomeProduto} foi removido com sucesso!`);
}

function updateProduto(req, res) {
    const nomeProduto = req.params.id;
    const produto = req.body;
    const produtoPesquisado = lista2.find((produtoNaLista) => produtoNaLista.name == nomeProduto);
    if(!produtoPesquisado){
        res.send(`não existe o produto ${nomeProduto} no estoque`)
    } else {
        produtoPesquisado.name = produto.name;
        produtoPesquisado.preco = produto.preco;
        produtoPesquisado.categoria = produto.categoria;
        produtoPesquisado.descricao = produto.descricao;

        
        res.send(`Produto de nome ${nomeProduto} alterado com sucesso!`);
    }
}


app.get('/produto', getProduto);
app.get('/produto/:id', getProdutoById);
app.post('/produto', criandoProduto);
app.put('/produto/:id', updateProduto);
app.delete('/produto/:id', deleteProduto);

app.listen(3000);