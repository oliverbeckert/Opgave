using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filmopgave.Models
{
    internal class Movies
    {
        string Title;
        string Overview;
        double VoteAverage;
        DateTime ReleaseDate;
        string OriginalLanguage;

        internal string GetTitle() { return Title; }
        internal void SetTitle(string Title) { this.Title = Title; }

        internal string GetOverview() { return Overview; }
        internal void SetOverview(string Overview) { this.Overview = Overview; }

        internal double GetVoteAverage() { return VoteAverage; }
        internal void SetVoteAverage(Double VoteAverage) { this.VoteAverage = VoteAverage; }

        internal DateTime GetReleaseDate() { return ReleaseDate; }
        internal void SetReleaseDate(DateTime ReleaseDate) { this.ReleaseDate = ReleaseDate; }

        internal string GetOriginalLanguage() { return OriginalLanguage; }
        internal void SetOriginalDate(string OriginalLanguage) { this.OriginalLanguage = OriginalLanguage; }



    }
}
