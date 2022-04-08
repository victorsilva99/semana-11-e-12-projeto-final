var audioClick = new Audio('/medias/audios/champion-select.mp3');
var audioBackground = new Audio('/medias/audios/background-sound.mp3');

var selecionados = new Array();


function iniciar() {
    var restantes = 16 - selecionados.length;

    if (selecionados.length == 16) {
        passarSelecionados();
    }
    else {
        if (restantes.length < 16) {
            alert('Ainda faltam selecionar ' + restantes + " campeões!");
        }
        else {
            alert('Ainda falta selecionar ' + restantes + " campeão!");
        }
    }
}
function passarSelecionados() {
    var ids = JSON.stringify(selecionados.toString());

    return $.ajax({
        type: 'POST',
        url: "Torneio/MataMata",
        contentType: 'application/json',
        data: ids,
        success: function (data) {
            window.location = data.url;
        }
    });
}

function diminuirVolume() {
    audioBackground.volume = 0.1;
    audioClick.volume = 0.1;
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
    }
    console.log(selecionados);
}

function deletarListaSelecionados(id) {
    if (selecionados.indexOf(id) != -1) {
        selecionados.splice(selecionados.indexOf(id), 1);
    }
    console.log(selecionados);
}