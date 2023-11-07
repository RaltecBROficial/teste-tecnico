// See https://aka.ms/new-console-template for more information


using Animal;

Console.WriteLine("Ações dos animais:");

var cao = new Cao(20);
var gato = new Gato(5);
var elefante = new Elefante(1500);
var cavalo = new Cavalo(600);

Console.WriteLine(cao.Atacar());
Console.WriteLine(cavalo.Andar());
Console.WriteLine(elefante.Comer());
Console.WriteLine(gato.Peso);

Console.WriteLine("\nAções das aves:");

var andorinha = new Andorinha(0.1, 2);
var pato = new Pato(1,2);
var galinha = new Galinha(2, 2);

Console.WriteLine(andorinha.Andar());
Console.WriteLine(andorinha.Voar());
Console.WriteLine(pato.Voar());
Console.WriteLine(galinha.Comer());