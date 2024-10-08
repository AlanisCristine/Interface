using Exemplo1;
using Exemplo2;
Cachorro c = new Cachorro();
Gato g = new Gato();
Passaro p = new Passaro();

GerenciadorAnimal gerrenciado = new GerenciadorAnimal();
gerrenciado.RealizarAcao(g);
gerrenciado.RealizarAcao(p);