using System;

public class CandidateValidation
{
    public CandidateValidation()
    {
    }

    Candidate[] Registeredcandidates = new Candidate[100];

    public string[] RequiredTitles = new string[] { "Director", "Manager", "Developer", "QA Tester" };

    public void ValidateCandidate(Candidate candidate)
    {
        if (candidate == null)
        {
            throw new CandidateException("No candidate information");
        }

        if (candidate.Age < 18 || candidate.Age > 65)
        {
            throw new CandidateException("The candidate's age does not meet the requirements");
        }

        for (int i = 0; i < RequiredTitles.Length; i++)
        {
            if (candidate.Title.Equals(RequiredTitles[i]))
            {
                Registeredcandidates[GetIndex()] = candidate;
                Console.WriteLine("The candidate has been added to the list for consideration.");
                return;
            }

        }

        throw new CandidateException("The candidate's specialty does not meet the requirements");
    }

    private int GetIndex()
    {
        for (int i = 0; i < Registeredcandidates.Length; i++)
        {
            if (Registeredcandidates[i] == null)
            {
                return i;
            }

        }

        throw new CandidateException("Candidates recruited");

    }

}
