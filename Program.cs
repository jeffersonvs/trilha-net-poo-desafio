using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone maca = new Iphone();
maca.smartphone("98989898","20S","11aa22bb33cc" );
maca.Ligar();
maca.ReceberLigacao();
maca.InstalarAplicativo("Opera");

Nokia android = new Nokia();
android.smartphone("87878787","FashioCan", "dd44ee55ff66");
android.Ligar();
android.ReceberLigacao();
android.InstalarAplicativo("Chrome");