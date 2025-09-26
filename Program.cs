using DesafioPOO.Models;

// Criando um Nokia
Smartphone nokia = new Nokia("12345", "Nokia Tijolão", "111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

// Criando um iPhone
Smartphone iphone = new Iphone("67890", "iPhone 15", "222222", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
