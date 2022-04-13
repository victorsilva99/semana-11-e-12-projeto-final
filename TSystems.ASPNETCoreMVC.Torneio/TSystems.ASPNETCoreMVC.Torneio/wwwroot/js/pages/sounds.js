var audioClick = new Audio('/medias/audios/champion-select-sound.mp3');
var audioBackgroundIndex = new Audio('/medias/audios/index-background-sound.mp3');
var audioBackgroundVencedor = new Audio('/medias/audios/vencedor-background-sound.mp3');
var audioBackgroundChampions = new Audio('/medias/audios/champions-backgound-sound.mp3');
var audioVictory = new Audio('/medias/audios/victory-voice-sound.mp3');

function diminuirVolumeGeral()
{
    audioClick.volume = 0.05;
    audioBackgroundIndex.volume = 0.05;
    audioBackgroundVencedor.volume = 0.05;
    audioBackgroundChampions.volume = 0.05;
    audioVictory.volume = 0.05;
}