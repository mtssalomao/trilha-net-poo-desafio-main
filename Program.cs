using DesafioPOO.Models;


Iphone iphone = new Iphone("","","",0); 
Nokia nokia = new Nokia("","","",0);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("nomeApp");

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("nomeApp");


// TODO: Realizar os testes com as classes Nokia e Iphone