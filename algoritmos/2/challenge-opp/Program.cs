using challenge_opp.Entities;

const int quantidadeDePatasMamiferos = 4;
const double pesoCao = 12.3;
var cao = new Cao(pesoCao, quantidadeDePatasMamiferos);
PerformAnimalActions(cao);
cao.Atacar();

const double pesoGato = 5;
var gato = new Gato(pesoGato, quantidadeDePatasMamiferos);
PerformAnimalActions(gato);

const double pesoElefante = 300.5;
var elefante = new Elefante(pesoElefante, quantidadeDePatasMamiferos);
PerformAnimalActions(elefante);

const double pesoCavalo = 50;
var cavalo = new Cavalo(pesoCavalo, quantidadeDePatasMamiferos);
PerformAnimalActions(cavalo);

const int quantidadeDePatasAves = 2;
const double pesoAndorinha = 2;
var andorinha = new Andorinha(pesoAndorinha, quantidadeDePatasAves);
PerformAnimalActions(andorinha);
andorinha.Voar();

const double pesoPato = 45;
var pato = new Pato(pesoPato, quantidadeDePatasAves);
PerformAnimalActions(pato);
pato.Voar();

const double pesoGalinha = 9;
var galinha = new Galinha(pesoGalinha, quantidadeDePatasAves);
PerformAnimalActions(galinha);

static void PerformAnimalActions(Animal animal)
{
    animal.Andar();
    animal.Comer();
}