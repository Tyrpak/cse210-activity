using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("Földrajzi Múzeum", "Érd", "Pest", "Hungary");

        Lecture lecture = new Lecture("Christmas Folklore: How Our Ancestors Celebrated", "An afternoon at the museum with some authentic items for illustration", "December 9, 2023", "1 PM", address, "Tiborcz István", 120);
        Console.WriteLine();

        Console.WriteLine("Event Number: 1");
        Console.WriteLine();
        Console.WriteLine(lecture.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(lecture.GenerateDetailedLecture());

        Console.WriteLine();
        Console.WriteLine(lecture.GenerateShortLecture());

        Address addressR = new Address("Branch House", "Érd", "Pest", "Hungary");

        Reception reception = new Reception("Christmas Gathering", "Festive play by the children of our branch", "December 15, 2023", "4 PM", addressR, "unszjke_erd@churchofjesuschrist.org");
        Console.WriteLine();

        Console.WriteLine("Event Number: 2");
        Console.WriteLine();
        Console.WriteLine(reception.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(reception.GenerateDetailedReception());

        Console.WriteLine();
        Console.WriteLine(reception.GenerateShortReception());

        Address addressOG = new Address("Alsó utca 1.", "Érd", "Pest", "Hungary");

        OutdoorGathering outdoorGathering = new OutdoorGathering("Christmas Carol Singing", "Singing Christmas songs on the main square of Érd", "September 14, 2023", "6 PM", addressOG, "windy but dry");
        Console.WriteLine();

        Console.WriteLine("Event Number: 3");

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateDetailedOutdoorGathering());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateShortOutdoorGathering());
    }
}