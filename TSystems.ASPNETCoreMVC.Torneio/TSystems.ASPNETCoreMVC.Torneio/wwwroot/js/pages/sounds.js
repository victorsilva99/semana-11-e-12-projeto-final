var audioClick = new Audio('/medias/audios/champion-select.mp3');
var audioBackground = new Audio('/medias/audios/background-sound.mp3');

function diminuirVolumeGeral()
{
    audioClick.volume = 0.05;
    audioBackground.volume = 0.05;
}