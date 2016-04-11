using System.Collections.Generic;

namespace NVTest.Models
{
    public interface IResultsRepository
    {
        float ScoreForAgeGroup(int low, int high);
        float ScoreForGender(string gender);

    }
}