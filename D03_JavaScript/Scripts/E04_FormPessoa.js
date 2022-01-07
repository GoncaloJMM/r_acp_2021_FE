function LoadForm() {
    document.formPessoa.inputNome.focus();
}

function ValidateNome() {
    let nome = document.getElementById('inputNome');

    if (nome.value == '') {
        nome.focus();
        nome.style.color = 'red';
        return false;
    }
    else {
        nome.style.color = 'black';
        return true;
    }
}

function CalculateAge() {
    let inputUser = document.getElementById('inputData').value;

    let anoAtual;
    let anoNascimento;
    let idade;

    anoAtual = new Date().getFullYear();
    anoNascimento = new Date(inputUser).getFullYear();
    idade = anoAtual - anoNascimento;
   

    if (idade == 1)
    {
        let anos = 'ano'
    } else
    {
        let anos = 'anos'
    }

   document.getElementById('result').innerHTML = idade + anos;


}

function ValidateMail() {
    let email = document.getElementById('inputMail');
    let regexEmail = /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;

    if (!regexEmail.test(email.value)) {
        email.focus();
        email.style.color = 'red';
        return false;
    }
    else {
        nome.stye.color = 'black';
        return true;
    }

}

function ValidateTelefone() {
    let telefone = document.getElementById('inputTelefone');
    let regexTelefone = /^\d{9}$/;

    if (!regexTelefone.test(telefone.value)) {
        telefone.focus();
        telefone.style.color = 'red';
        return false;
    }
    else {
        telefone.style.color = 'black';
        return true;
    }
}

function ValidateNif() {
    let nif = document.getElementById('inputTelefone');
    let regexNif = /^\d{9}$/;

    if (!regexNif.test(nif.value)) {
        nif.focus();
        nif.style.color = 'red';
        return false;
    }
    else {
        nif.style.color = 'black';
        return true;
    }
}