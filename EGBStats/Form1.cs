using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace EGBStats
{
    public partial class F : Form
    {
        public F()
        {
            InitializeComponent();
        }

        List<EGBMatch> MatchesEGB;
        List<CSGLMatch> MatchesCSGL;
        List<int> MatchesCount = new List<int>(new int[100]);
        List<int> WinsCount = new List<int>(new int[100]);

        /////////////////////
        // EGAMINGBETS.COM //
        // EGAMINGBETS.COM //
        // EGAMINGBETS.COM //
        // EGAMINGBETS.COM //
        // EGAMINGBETS.COM //
        /////////////////////

        private void getEGBbtn_Click(object sender, EventArgs e)
        {
            // mid = Match ID
            int mid_from = Convert.ToInt32(egb_mid_fromBox.Text);
            int mid_to = Convert.ToInt32(egb_mid_toBox.Text);

            MatchesEGB = new List<EGBMatch>();
            List<int> dateerr = new List<int>();

            if (EGBautosave.Checked)
                saveFileDialog.ShowDialog();
            
            for (int mid = mid_from; mid <= mid_to; mid++)
            {
                this.Invalidate(true);
                if (F.ActiveForm != null)
                    F.ActiveForm.Text = "Matches checked: " + mid.ToString() + "; Matches recorded:" + MatchesEGB.Count.ToString();
                if (EGBautosave.Checked && MatchesEGB.Count % 10 == 0)
                    Json.WriteToJsonFile<List<EGBMatch>>(saveFileDialog.FileName, MatchesEGB);
                try
                {
                    EGBMatch current = new EGBMatch();
                    current.GetMatch(mid);
                    MatchesEGB.Add(current);
                    if (EGBautodraw.Checked)
                    {
                        int odds;
                        if (current.winner == "a")
                        {
                            odds = (int)Math.Round(100 * current.coefA / (current.coefA + current.coefB));
                            WinsCount[odds]++;
                            MatchesCount[odds]++;
                            MatchesCount[100 - odds]++;
                        }
                        else if (current.winner == "b")
                        {
                            odds = (int)Math.Round(100 * current.coefB / (current.coefA + current.coefB));
                            WinsCount[odds]++;
                            MatchesCount[odds]++;
                            MatchesCount[100 - odds]++;
                        }
                        DrawGraph("EGB");
                    }
                }
                catch (Exception err)
                {
                    if (err.Message == "Date parsing error")
                        dateerr.Add(mid);
                }
            }
            MatchesEGB.RemoveAll(ClosedMatch); // remove closed matches; winner = c
            ActivateEGB();
        }
        private void ActivateEGB()
        {
            EGBlabel.Text = "Loaded";
            EGBlabel.ForeColor = Color.Green;
            saveEGB.Enabled = true;
            drawEGB.Enabled = true;
        }
        private static bool ClosedMatch(EGBMatch M)
        {
            return M.winner == "c";
        }

        private void loadEGB_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            MatchesEGB = Json.ReadFromJsonFile<List<EGBMatch>>(openFileDialog.FileName);
            
            if (MatchesEGB.Count > 0)
                ActivateEGB();
        }

        private void saveEGB_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
            Json.WriteToJsonFile<List<EGBMatch>>(saveFileDialog.FileName, MatchesEGB);
        }

        private void drawEGB_Click(object sender, EventArgs e)
        {
            if (MatchesEGB.Count > 0)
            {
                MatchesCount = new List<int>(new int[100]);
                WinsCount = new List<int>(new int[100]);
                foreach (EGBMatch m in MatchesEGB)
                {
                    if (m.matchId > Convert.ToInt32(egb_mid_fromBox.Text) && m.matchId < Convert.ToInt32(egb_mid_toBox.Text))
                    {
                        int odds;
                        if (m.winner == "b")
                        {
                            odds = (int)Math.Round(100 * m.oddsB);
                            WinsCount[odds]++;
                            MatchesCount[odds]++;
                            MatchesCount[100 - odds]++;
                        }
                        if (m.winner == "a")
                        {
                            odds = (int)Math.Round(100 * m.oddsA);
                            WinsCount[odds]++;
                            MatchesCount[odds]++;
                            MatchesCount[100 - odds]++;
                        }
                    }
                }
            }
            AddGraph("EGB");
        }

        ////////////////////
        // CSGOLOUNGE.COM //
        // CSGOLOUNGE.COM //
        // CSGOLOUNGE.COM //
        // CSGOLOUNGE.COM //
        // CSGOLOUNGE.COM //
        ////////////////////

        private void loadCSGL_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            MatchesCSGL = Json.ReadFromJsonFile<List<CSGLMatch>>(openFileDialog.FileName);
            if (MatchesCSGL.Count > 0)
                ActivateCSGL();
        }

        private void ActivateCSGL()
        {
            CSGLlabel.Text = "Loaded";
            CSGLlabel.ForeColor = Color.Green;
            saveCSGL.Enabled = true;
            drawCSGL.Enabled = true;
        }

        private void saveCSGL_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
            Json.WriteToJsonFile<List<CSGLMatch>>(saveFileDialog.FileName, MatchesCSGL);
        }

        private void getCSGLbtn_Click(object sender, EventArgs e)
        {
            // mid = Match ID
            int mid_from = Convert.ToInt32(csgl_mid_fromBox.Text);
            int mid_to = Convert.ToInt32(csgl_mid_toBox.Text);

            MatchesCSGL = new List<CSGLMatch>();
            
            for (int mid = mid_from; mid <= mid_to; mid++)
            {
                this.Invalidate(true);
                if (F.ActiveForm != null)
                    F.ActiveForm.Text = "Matches checked: " + mid.ToString() + "; Matches recorded:" + MatchesCSGL.Count.ToString();
                try
                {
                    CSGLMatch current = new CSGLMatch();
                    if (current.GetMatch(mid))
                        MatchesCSGL.Add(current);
                }
                catch
                {
                }
            }
            MatchesCSGL.RemoveAll(ClosedMatch); // remove closed matches; winner = c
            ActivateCSGL();
        }
        private static bool ClosedMatch(CSGLMatch M)
        {
            return M.winner == "c";
        }

        private void drawCSGL_Click(object sender, EventArgs e)
        {
            if (MatchesCSGL.Count > 0)
            {
                MatchesCount = new List<int>(new int[100]);
                WinsCount = new List<int>(new int[100]);
                foreach (CSGLMatch m in MatchesCSGL)
                {
                    int odds;
                    if (m.winner == "b")
                    {
                        odds = (int)Math.Round(100 * m.coefA / (m.coefA + m.coefB));
                        WinsCount[odds]++;
                        MatchesCount[odds]++;
                        MatchesCount[100 - odds]++;
                    }
                    if (m.winner == "a")
                    {
                        odds = (int)Math.Round(100 * m.coefB / (m.coefA + m.coefB));
                        WinsCount[odds]++;
                        MatchesCount[odds]++;
                        MatchesCount[100 - odds]++;
                    }
                }
            }
            AddGraph("CSGL");
        }

        //////////
        // MAIN //
        // MAIN //
        // MAIN //
        //////////

        List<EgbCsglPair> pairs = new List<EgbCsglPair>();

        private int GetPairs()
        {
            if (!drawCSGL.Enabled || !drawEGB.Enabled)
                return 0;
            pairs.Clear();
           
            foreach (CSGLMatch csglm in MatchesCSGL)
            {
                if ((Convert.ToDouble(csglmaxodds.Text, CultureInfo.InvariantCulture) < csglm.oddsA) ||
                           (Convert.ToDouble(csglminodds.Text, CultureInfo.InvariantCulture) > csglm.oddsA) ||
                           (Convert.ToInt32(maxmatchid.Text) < csglm.matchId) ||
                           (Convert.ToInt32(minmatchid.Text) > csglm.matchId) ||
                           (!bo1.Checked && csglm.format == "1") ||
                           (!bo2.Checked && csglm.format == "2") ||
                           (!bo3.Checked && csglm.format == "3") ||
                           (!bo5.Checked && csglm.format == "5"))
                    continue;

                List<EGBMatch> clones = new List<EGBMatch>();
                List<double> LDist = new List<double>();
                foreach (EGBMatch egbm in MatchesEGB)
                {
                    TimeSpan ts = egbm.full_date - csglm.full_date;
                    if (ts.Days == 0 && Math.Abs(ts.TotalHours) <= 3)
                    {
                        double Score = 0;
                        egbm.FixTeamNames();
                        csglm.FixTeamNames();
                        int AA = LevenshteinDistance.Compute(egbm.teamA, csglm.teamA);
                        int BB = LevenshteinDistance.Compute(egbm.teamB, csglm.teamB);
                        int AB = LevenshteinDistance.Compute(egbm.teamA, csglm.teamB);
                        int BA = LevenshteinDistance.Compute(egbm.teamB, csglm.teamA);
                        bool passed = true;
                        double leniency = 1.2;
                        EGBMatch copy = new EGBMatch(egbm);
                        if (AA + BB > AB + BA)
                        {
                            if (AB * leniency > egbm.teamA.Length || AB * leniency > csglm.teamB.Length)
                                passed = false;
                            if (BA * leniency > egbm.teamB.Length || BA * leniency > csglm.teamA.Length)
                                passed = false;
                            copy.SwapTeams();
                        }
                        else
                        {
                            if (AA * leniency > egbm.teamA.Length || AA * leniency > csglm.teamA.Length)
                                passed = false;
                            if (BB * leniency > egbm.teamB.Length || BB * leniency > csglm.teamB.Length)
                                passed = false;
                        }
                        if (passed)
                        {
                            Score += Math.Min(AA + BB, AB + BA);
                            Score += ts.TotalHours * 3;
                            Score += 80 * Math.Abs(copy.coefB / (copy.coefA + copy.coefB) - csglm.oddsA);
                            clones.Add(copy);
                            LDist.Add(Score);
                        }
                    }
                }
                if (LDist.Count > 0)
                {
                    EGBMatch egbm1 = clones[LDist.IndexOf(LDist.Min())];
                    pairs.Add(new EgbCsglPair(egbm1, csglm));
                }
            }
            return pairs.Count;
        }

        // GET PAIRS BTN
        private void button2_Click(object sender, EventArgs e)
        {
            if (GetPairs() > 0)
            {
                pairsLabel.Text = "Pairs found: " + pairs.Count.ToString();
                drawDiffBtn.Enabled = true;
                kellyBtn.Enabled = true;
            }
        }

        private void kellyBtn_Click(object sender, EventArgs e)
        {
            if (pairs.Count > 0)
            {
                string name = "Kelly";
                if (!graph.Series.IsUniqueName(name))
                    graph.Series.Remove(graph.Series[name]);
                graph.Series.Add(name);
                graph.Series[name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                graph.Series[0].Points[0].YValues[0] = 100;

                double startingBankroll = 100;
                double bankroll = startingBankroll;
                double maximum = startingBankroll;
                double minimum = startingBankroll;
                double multiplier = Convert.ToDouble(kellyMultiplier.Text, CultureInfo.InvariantCulture);
                double bet = 0;
                double graphStep = 100 / (double)pairs.Count;
                foreach (EgbCsglPair pair in pairs)
                {
                    double minodds = Convert.ToDouble(csglminodds.Text, CultureInfo.InvariantCulture);
                    double maxodds = Convert.ToDouble(csglmaxodds.Text, CultureInfo.InvariantCulture);
                    if (pair.oddsAdiff > pair.oddsBdiff)
                    {   // A wins (EGB logic)
                        if (pair.csglm.oddsA < minodds || pair.csglm.oddsA > maxodds) continue;
                        bet = multiplier * startingBankroll * (pair.egbm.oddsA * pair.csglm.coefA - 1) / (pair.csglm.coefA - 1);
                        bankroll -= bet;
                        if (pair.csglm.winner == "a")
                        {   // A wins (really)
                            bankroll += bet * pair.csglm.coefA;
                        }
                    }
                    else
                    {   // B wins (EGB logic)
                        if (pair.csglm.oddsB < minodds || pair.csglm.oddsB > maxodds) continue;
                        bet = multiplier * startingBankroll * (pair.egbm.oddsB * pair.csglm.coefB - 1) / (pair.csglm.coefB - 1);
                        bankroll -= bet;
                        if (pair.csglm.winner == "b")
                        {   // B wins (really)
                            bankroll += bet * pair.csglm.coefB;
                        }
                    }
                    if (maximum < bankroll)
                        maximum = bankroll;
                    if (minimum > bankroll)
                        minimum = bankroll;
                    // Draw progress
                    graph.Series[name].Points.AddXY(pairs.IndexOf(pair) * graphStep, bankroll);
                    graph.ChartAreas[0].Axes[1].Maximum = maximum;
                    graph.ChartAreas[0].Axes[1].Minimum = minimum;
                }
                graph.Update();
            }
        }

        private void drawDiffBtn_Click(object sender, EventArgs e)
        {
            if (pairs.Count > 0)
            {
                string name = "Diffs";
                if (!graph.Series.IsUniqueName(name))
                    graph.Series.Remove(graph.Series[name]);
                graph.Series.Add(name);
                graph.Series[name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                foreach (EgbCsglPair pair in pairs)
                {
                    graph.Series[name].Points.AddXY(pair.csglm.oddsA * 100, pair.egbm.oddsA * 100);
                    if (pair.csglm.winner == "a")
                        graph.Series[name].Points.Last().Color = Color.Green;
                    else
                        graph.Series[name].Points.Last().Color = Color.Red;
                }
                graph.Update();
            }
        }

        private void DrawGraph(string name)
        {
            for (int i = 0; i < 100; i++)
            {
                int odds;
                if (MatchesCount[i] != 0)
                    odds = WinsCount[i] * 100 / MatchesCount[i];
                else
                    odds = i;
                graph.Series[name].Points.AddXY(i, odds);
            }
            graph.Update();
        }
        private void AddGraph(string name)
        {
            if (!graph.Series.IsUniqueName(name))
                graph.Series.Remove(graph.Series[name]);
            graph.Series.Add(name);
            graph.Series[name].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            DrawGraph(name);
        }
        private void CleanGraph()
        {
            System.Windows.Forms.DataVisualization.Charting.Series s = graph.Series[0];
            s.Points[0].YValues[0] = 0;
            graph.ChartAreas[0].Axes[1].Maximum = 100;
            graph.ChartAreas[0].Axes[1].Minimum = 0;
            graph.Series.Clear();
            graph.Series.Add(s);
            graph.Update();
        }
        private void cleanGraphBtn_Click(object sender, EventArgs e)
        {
            CleanGraph();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (EGBMatch m in MatchesEGB)
            {
                m.oddsA = (1 / m.coefA + 1 - 1 / m.coefB) / 2;
                m.oddsB = (1 / m.coefB + 1 - 1 / m.coefA) / 2;
            }
            foreach (EgbCsglPair pair in pairs)
            {
                pair.egbm.oddsA = (1 / pair.egbm.coefA + 1 - 1 / pair.egbm.coefB) / 2;
                pair.egbm.oddsB = (1 / pair.egbm.coefB + 1 - 1 / pair.egbm.coefA) / 2;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (EGBMatch m in MatchesEGB)
            {
                m.oddsA = m.coefB / (m.coefA + m.coefB);
                m.oddsB = m.coefA / (m.coefB + m.coefA);
            }
            foreach (EgbCsglPair pair in pairs)
            {
                pair.egbm.oddsA = pair.egbm.coefB / (pair.egbm.coefA + pair.egbm.coefB);
                pair.egbm.oddsB = pair.egbm.coefA / (pair.egbm.coefB + pair.egbm.coefA);
            }
        }







    }
}
