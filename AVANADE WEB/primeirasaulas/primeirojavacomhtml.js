function enviarnotificacao(){
    var name = document.getElementById('name').value;
    var email = document.getElementById('email').value;
    var telephone = document.getElementById('telephone').value;
    var user = document.getElementById('user').value;
    var password = document.getElementById('password').value;
    alert (`Prezado(a) ${name}, \nfoi enviado um email de confirmação para\n${email} \ncontendo: \nTelefone: ${telephone} \nUsuário: ${user} \nSenha: ${password}`);
}


//1 - Crie um novo HTML, importe um arquivo JS, 
//crie os seguintes campos: 

//nome, email, telefone (não precisa ter máscara),
//usuário, senha e um botão.

//ao clicar no botão, use um alert para dizer:

//prezado NOME, foi enviado um email de confirmação para 
//EMAIL contendo:

//telefone: TELEFONE
//usuário: usuário
//senha: senha.
