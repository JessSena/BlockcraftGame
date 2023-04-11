
using Blockcraft;

Console.WriteLine("Bienvenido a Blockcraft!");

Arma pico = new Arma("PicoDeDiamante", 10);
Arma hacha = new Arma("HachaDePiedra", 20);
Arma espada = new Arma("EspadaDeOro", 30);

Personaje protagonista = new Personaje( 100, pico );

Enemigo enemigo = new Enemigo(100);

protagonista.Atacar(enemigo);

Console.WriteLine("Energia del enemigo" + enemigo.getEnergiaActual());

protagonista.CambiarArma(hacha);

protagonista.Atacar(enemigo);

Console.WriteLine("Energia del enemigo" + enemigo.getEnergiaActual());

protagonista.CambiarArma(espada);

protagonista.Atacar(enemigo);

Console.WriteLine("Energia del enemigo" + enemigo.getEnergiaActual());


