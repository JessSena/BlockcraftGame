
using Blockcraft;

Console.WriteLine("Bienvenido a Blockcraft!");

Arma pico = new Arma(10);
Arma hacha = new Arma(20);
Arma espada = new Arma(30);

Personaje protagonista = new Personaje( pico );

Enemigo enemigo = new Enemigo(100);

protagonista.Atacar(enemigo);

Console.WriteLine("Energia del enemigo " + enemigo.getEnergiaActual());

protagonista.CambiarArma(hacha);

protagonista.Atacar(enemigo);

Console.WriteLine("Energia del enemigo " + enemigo.getEnergiaActual());

protagonista.CambiarArma(espada);

protagonista.Atacar(enemigo);

Console.WriteLine("Energia del enemigo "  + enemigo.getEnergiaActual());


