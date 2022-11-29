// See https://aka.ms/new-console-template for more information
using Exercicio2;

string pathTXT = "C:\\Users\\Carla\\Desktop\\Unidade 1 - Exercicios - Parte 3\\texto.txt";
string ignore = "C:\\Users\\Carla\\Desktop\\Unidade 1 - Exercicios - Parte 3\\ignore.txt";
IndiceRemissivo indiceRemissivo = new IndiceRemissivo(pathTXT, ignore);
//IndiceRemissivo indiceRemissivo2 = new IndiceRemissivo(pathTXT);
indiceRemissivo.Imprime();