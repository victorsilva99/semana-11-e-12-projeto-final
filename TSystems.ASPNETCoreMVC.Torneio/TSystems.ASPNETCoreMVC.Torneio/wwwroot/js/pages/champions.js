var selecionados = new Array();
var restantes = 16;

function iniciar() {
    if (restantes == 0) {
        enviarSelecionados();
    }
    else if (restantes == 1) {
        alert('Ainda falta selecionar 1 campeão!');
    } else {
        alert('Ainda falta selecionar '+ restantes + ' campeões!');
    }
}

function enviarSelecionados() {
    var ids = JSON.stringify(selecionados.toString());
    return $.ajax({
        type: 'POST',
        url: "/Torneio/MataMata",
        contentType: 'application/json',
        data: ids,
        success: function (data) {
            window.location = data.url;
            console.log(url);
        }
    });
}

function selecionar(id) {
    var card = document.getElementById(id);
    var selected = document.getElementById('selected-' + id).textContent;

    if (selected == "false" && selecionados.length < 16) {
        audioClick.load();
        audioClick.play();
        document.getElementById('selected-' + id).textContent = "true";
        adicionarListaSelecionados(id);
        card.style = "filter: drop-shadow(5px 5px 5px #29a6f8); transform: scale(1.05, 1.05);";
    }
    else {
        card.style = "";
        document.getElementById('selected-' + id).textContent = "false";
        deletarListaSelecionados(id);
    }
}

function adicionarListaSelecionados(id) {
    if (selecionados.indexOf(id) == -1) {
        selecionados.push(id);
        restantes -= 1;
    }
}

function deletarListaSelecionados(id) {
    if (selecionados.indexOf(id) != -1) {
        selecionados.splice(selecionados.indexOf(id), 1);
        restantes += 1;
    }
}