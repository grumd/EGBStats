using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGBStats
{
    static class CSGLHistory
    {
        public static List<CSGLMatchRecord> records = null;
        public static List<CSGLMatchOdds> odds = null;
        public static int MaxID = 0;
        public static void GetHistory()
        {
            string resp = Http.GET("http://csgolounge.com/api/matches");
            records = Json.ReadFromString<List<CSGLMatchRecord>>(resp);
            resp = Http.GET("http://csgolounge.com/api/matches_stats");
            odds = Json.ReadFromString<List<CSGLMatchOdds>>(resp);
            MaxID = records.Last().match;
        }
    }
    public class CSGLMatch
    {
        private string DateTimeFormat = "yyyy-MM-dd HH:mm:ss";
        public int matchId {get; set;}
        public string teamA {get; set;}
        public string teamB {get; set;}
        public double coefA {get; set;}
        public double coefB {get; set;}
        public double oddsA {get; set;}
        public double oddsB {get; set;}
        public string date
        {
            get
            {
                return full_date.ToString(DateTimeFormat);
            }
            set
            {
                DateTime dt = new DateTime();
                DateTime.TryParse(value, out dt);
                full_date = dt;
            }
        }
        public DateTime full_date;
        public string winner {get; set;}
        public string format {get; set;}
        public CSGLMatch()
        { }
        public CSGLMatch(CSGLMatchRecord NewRecord, CSGLMatchOdds NewOdds)
        {
            if (NewRecord.match != NewOdds.match)
                throw new Exception("Matches do not match");
            if (NewRecord.closed == 0)
                throw new Exception("Match not yet ended");
            RecOddsToMatch(NewRecord, NewOdds);
        }
        public bool GetMatch(int MatchID)
        {
            if (CSGLHistory.records == null || CSGLHistory.odds == null)
                CSGLHistory.GetHistory();
            if (MatchID > CSGLHistory.MaxID)
                return false;
            GetMatch(MatchID, CSGLHistory.records, CSGLHistory.odds);
            return true;
        }
        public void GetMatch(int MatchID, List<CSGLMatchRecord> records, List<CSGLMatchOdds> odds)
        {
            CSGLMatchRecord NewRecord = null;
            CSGLMatchOdds NewOdds = null;
            foreach (CSGLMatchRecord rec in records)
                if (rec.match == MatchID)
                    NewRecord = rec;
            foreach (CSGLMatchOdds odd in odds)
                if (odd.match == MatchID)
                    NewOdds = odd;
            if (NewRecord == null || NewOdds == null)
                throw new Exception("MatchID not found");
                        
            RecOddsToMatch(NewRecord, NewOdds);
        }
        private void RecOddsToMatch(CSGLMatchRecord NewRecord, CSGLMatchOdds NewOdds)
        {
            matchId = NewRecord.match;
            teamA = NewRecord.a;
            teamB = NewRecord.b;
            date = NewRecord.when;
            winner = NewRecord.winner;
            format = NewRecord.format;

            double itemsA = NewOdds.a;
            double itemsB = NewOdds.b;
            double totalItems = itemsA + itemsB;
            oddsA = itemsA / totalItems;
            oddsB = itemsB / totalItems;
            coefA = 1 + itemsB / itemsA;
            coefB = 1 + itemsA / itemsB;
        }
        public void FixTeamNames()
        {
            teamA = TeamNames.FixName(teamA);
            teamB = TeamNames.FixName(teamB);
        }
    }
    public class CSGLMatchRecord
    {
        // Match id
        public int match {get; set;}
        // Match date and time
        public string when {get; set;}
        // Team A name
        public string a { get; set; }
        // Team B name
        public string b { get; set; }
        // Winner
        public string winner { get; set; }
        // Closed or opened bet
        public int closed { get; set; }
        // Best of 1/2/3/5
        public string format { get; set; }
        public CSGLMatchRecord()
        { }
    }
    public class CSGLMatchOdds
    {
        // Match id
        public int match { get; set; }
        // Items bet on Team A
        public int a { get; set; }
        // Items bet on Team B
        public int b { get; set; }
        public CSGLMatchOdds()
        { }
    }
}
