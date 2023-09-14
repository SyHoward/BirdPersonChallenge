//Establishing objects
using Game;

Hero Birdperson = new Hero();

friendlyBirds Bird = new friendlyBirds();
friendlyBirds CrestedIbis = new friendlyBirds();
friendlyBirds GreatKiskudee = new friendlyBirds();
friendlyBirds RedCrossbill = new friendlyBirds();
friendlyBirds RedneckedPhalarope = new friendlyBirds();
friendlyBirds EveningGrosbeak = new friendlyBirds();
friendlyBirds GreaterPrairieChicken = new friendlyBirds();
friendlyBirds IcelandGull = new friendlyBirds();
friendlyBirds OrangeBelliedParrot = new friendlyBirds();

Enemies InvincibleBirdHunter = new Enemies();
Enemies VulnerableBirdHunter = new Enemies();

//Hero
Birdperson.Name = "Birdperson";
Birdperson.Health = 3;
Birdperson.Points = 5000;

//Birds
Bird.Name = "Bird";
Bird.Points = 10;

CrestedIbis.Name = "Crested Ibis";
CrestedIbis.Points = 100;

GreatKiskudee.Name = "Great Kiskudee";
GreatKiskudee.Points = 300;

RedCrossbill.Name = "Red Crossbill";
RedCrossbill.Points = 500;

RedneckedPhalarope.Name = "Red-necked Phalarope";
RedneckedPhalarope.Points = 700;

EveningGrosbeak.Name = "Evening Grosbeak";
EveningGrosbeak.Points = 1000;

GreaterPrairieChicken.Name = "Greater Prairie Chicken";
GreaterPrairieChicken.Points = 2000;

IcelandGull.Name = "Iceland Gull";
IcelandGull.Points = 3000;

OrangeBelliedParrot.Name = "Orange-Bellied Parrot";
OrangeBelliedParrot.Points = 5000;

//Hunters
InvincibleBirdHunter.Name = "Invincible Bird Hunter";
InvincibleBirdHunter.Damage = 1;
InvincibleBirdHunter.Points = 0;

VulnerableBirdHunter.Name = "Vulnerable Bird Hunter";
VulnerableBirdHunter.Damage = 0;
VulnerableBirdHunter.Points = 200;

// Linking
string filePath = @"C:\Users\Syman\OneDrive\Desktop\Projects\BirdPerson\game-sequence.txt";
string lines = File.ReadAllLines(filePath).ToString();
Console.ReaLine();

// Game Loop
string[] entities = lines.Split(",");
foreach (string entity in entities)
{
    
    if (entity == "Bird")
    {
        Console.WriteLine(10);
    }
    Console.WriteLine(entity);
}
// File.WriteAllLines(filePath, lines);
// Console.ReadLine();

// while (Birdperson.Health > 0)
// {
    
// }

//Namespace
namespace Game
{
    class Hero
    {
        public string Name {get; set; }
        public int Health {get; set; }
        public int Points {get; set; }
    }

    class friendlyBirds
    {
        public string Name {get; set; }
        public int Points {get; set; }
    }

    class Enemies
    {
        public string Name {get; set; }
        public int Damage{get; set; }
        public int Points{get; set; }
    }
}