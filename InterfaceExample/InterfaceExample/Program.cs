// See https://aka.ms/new-console-template for more information
using InterfaceExample;


Console.WriteLine("Hello, World!");

var dog1 = new dog { Breed = "Golden Retriever", Color = "Yellow", Speak = "Woof" };
var dog2 = new dog { Breed = "English Mastiff", Color = "Brindle", Speak = "A very Deep Bark" };

var cat1 = new Cat { Breed = "American Short Hair", Age = 5, Speak = "Purrrrrrrr" };
var cat2 = new Cat { Breed = "Hairless", Age = 3, Speak = "Clicking and Chirping" };

var hamster1 = new Hamster { Breed = "Fancy", Color = "Gold", Speak = "Squeak" };
var hamster2 = new Hamster { Breed = "Teddy Bear", Color = "Black & White", Speak = "Rawr" };

IBreedSpeak[] pets = { dog1, dog2, cat1, cat2, hamster1, hamster2 };
foreach (var pet in pets)
{
    Console.WriteLine($"We have a {pet.Breed} which makes a sound of {pet.Speak} ");
}

interface IBreedSpeak
{
    string Breed { get; set; }
    string Speak { get; set; }
}
