using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeatherMcConnellA5_1_.Model
{
    public class LevelAttempts
    {
        public List<Attempt> RunAttempts { get; } = new List<Attempt>();

        public string LevelName { get; set; }

        public int RunCount => RunAttempts.Count;

        public int RecordRunCount => RunAttempts.Count(attempt => attempt.IsTimeBelowRecord);

        /// <summary>
        /// Initializes a new instance of the <see cref="Level"/> class.
        /// </summary>
        public LevelAttempts()
        {
            LevelName = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Level"/> class.
        /// </summary>
        /// <param name="levelName">Name of the level.</param>
        public LevelAttempts(string levelName)
        {
            LevelName = levelName;
        }

        /// <summary>
        /// Adds the level.
        /// </summary>
        /// <param name="attempt">The attempt.</param>
        public void AddLevel(Attempt attempt)
        {
            RunAttempts.Add(attempt);
        }

        /// <summary>
        /// Adds the level.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="score">The score.</param>
        /// <param name="time">The time.</param>
        public void AddLevelAttempt(string firstName, string lastName, int score, decimal time)
        {
            Attempt attempt = new Attempt
            {
                FirstName = firstName,
                LastName = lastName,
                Score = score,
                Time = time,
                RunDate = DateTime.Now
            };
            RunAttempts.Add(attempt);

        }

        /// <summary>
        /// Gets the minimum score.
        /// </summary>
        /// <returns></returns>
        public int? GetMinimumScore()
        {
            return RunAttempts.Min(attempt => attempt.Score);
        }

        /// <summary>
        /// Gets the maximum score.
        /// </summary>
        /// <returns></returns>
        public int? GetMaximumScore()
        {
            return RunAttempts.Max(attempt => attempt.Score);
        }

        /// <summary>
        /// Gets the average time.
        /// </summary>
        /// <returns></returns>
        public decimal? GetAverageTime()
        {
            return RunAttempts.Average(attempt => attempt.Time);
        }

        /// <summary>
        /// Gets the time range.
        /// </summary>
        /// <returns></returns>
        public decimal? GetTimeRange()
        {
            var minTime = RunAttempts.Min(attempt => attempt.Time);
            var maxTime = RunAttempts.Max(attempt => attempt.Time);
            return maxTime - minTime;
        }

        /// <summary>
        /// Gets the score range.
        /// </summary>
        /// <param name="low">The low.</param>
        /// <param name="high">The high.</param>
        /// <returns></returns>
        public int GetScoreRange(int low, int high)
        {
            return RunAttempts.Count(attempt => attempt.Score >= low && attempt.Score <= high);
        }

        /// <summary>
        /// Gets the stats summary.
        /// </summary>
        /// <returns>Summary of Stats</returns>
        public string GetStatsSummary()
        {
            int totalAttempts = RunCount;
            int? minScore = GetMinimumScore();
            int? maxScore = GetMaximumScore();
            decimal? avgTime = GetAverageTime();
            int scoreRange = maxScore.HasValue && minScore.HasValue ? maxScore.Value - minScore.Value : 0;

            return $"Total Attempts: {totalAttempts}\n" + Environment.NewLine +
                   $"Min Score: {minScore}\n" + Environment.NewLine +
                   $"Max Score: {maxScore}\n" + Environment.NewLine +
                   $"Average Time: {avgTime?.ToString("F2")}\n" + Environment.NewLine +
                   $"Score Range: {scoreRange}";
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"Level: {LevelName} - Total Attempts: {RunCount}, Record Runs: {RecordRunCount}";
        }

    }
}

