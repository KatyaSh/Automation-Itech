//Task1

MassiveMethod.ShowMassiveElements();

Console.WriteLine("----------------------------");

//Task2

//Create a custom exception class that will store some additional variables
//Create a class that will contain the method/property that throws the given exception.
try
{
    Candidate candidate1 = new Candidate("Vasia", "Director", 45);
    Candidate candidate2 = null;
    CandidateValidation validation = new CandidateValidation();
    validation.ValidateCandidate(candidate1);
    validation.ValidateCandidate(candidate2);
}

catch (CandidateException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}