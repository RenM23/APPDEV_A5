using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace HeatherMcConnellA5_1_.Model
{
    /// <summary>
    /// Attempt class.
    /// </summary>
    public class Attempt
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? Score { get; set; }
        public decimal? Time { get; set; }
        public DateTime? RunDate { get; set; }

        public bool IsTimeBelowRecord => Time.HasValue && Time.Value < 120.0m;

        /// <summary>
        /// Initializes a new instance of the <see cref="Attempt"/> class.
        /// </summary>
        public Attempt()
        {

            FirstName = String.Empty;
            LastName = String.Empty;
            Score = 0;
            Time = 0;
            RunDate = DateTime.Now;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attempt"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="score">The score.</param>
        /// <param name="time">The time.</param>
        /// <exception cref="System.ArgumentNullException">
        /// firstName - First name cannot be null.
        /// or
        /// lastName - Last name cannot be null
        /// </exception>
        /// <exception cref="System.ArgumentOutOfRangeException">score - Score must be between 0 and 100.</exception>
        /// <exception cref="System.ArgumentException">Time must be between 0.0 and 120.0 seconds. - time</exception>
        public Attempt(string? firstName, string? lastName, int? score, decimal? time)
        {
            if (firstName == null)
                throw new ArgumentNullException(nameof(firstName), "First name cannot be null.");
            if (lastName == null)
                throw new ArgumentNullException(nameof(lastName), "Last name cannot be null");
            if (score < 0 || score > 100)
                throw new ArgumentOutOfRangeException(nameof(score), "Score must be between 0 and 100.");
            if (time < 0.0m || time > 120.0m)
                throw new ArgumentException("Time must be between 0.0 and 120.0 seconds.", nameof(time));

            FirstName = firstName;
            LastName = lastName;
            Score = score;
            Time = time;
            RunDate = DateTime.Now;
        }
        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"{LastName}, {FirstName}, {Score}, {Time}";
        }
    }
}
