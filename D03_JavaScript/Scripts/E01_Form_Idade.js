function ValidateAge() {
//1. Declarar variaveis : valor da textbox, mensagem
let age;
let mensagem;
    //2. Ler da textbox e atribuir à variavel
    // window.document.form.textbox
    age = document.getElementById("textAge").value;
    

//3. Avaliar o valor da variavel da idade e dar a respetiva mensagem

    if (age <= "18" || isNaN(age)) {
        mensagem = "Entrada não sucedida!";
    }
    else {
        mensagem = "Entrada bem sucedida!";
    }
    //4. Escrever no ecrã a mensagem ( window.alert)
    document.getElementById("pMessage").innerHTML = mensagem;


}