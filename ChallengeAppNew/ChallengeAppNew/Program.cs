string name = "Jacek";
int age = 33;
char sex = 'M';

if(name == "Jacek" && age == 33 &&  sex == 'M')
{
    Console.WriteLine("Przystojny mężczyzna w wieku 33 lat o niebagatelnym imieniu Jacek");
}
else if(name == "Ewa" && age < 30 && sex != 'M')
{
    Console.WriteLine("Kobieta o imieniu Ewa, wiek: Ponizej 30 lat");
}
else if(age < 18 && sex == 'M')
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}

