namespace Unit04.Game.Casting
{
    /// <summary>
    /// <para>An item of cultural or historical interest.</para>
    /// <para>
    /// The responsibility of an Artifact is to provide a message about itself.
    /// </para>
    /// </summary>
    public class Artifact : Actor
    {
        private int score = 0;
        private int cellSize = 15;

        /// <summary>
        /// Constructs a new instance of an Artifact.
        /// </summary>
        public Artifact()
        {
            Random random = new Random();
            int dx = 0;
            int dy = random.Next(1, 3);

            Point direction = new Point(dx, dy);
            direction = direction.Scale(cellSize);
            this.SetVelocity(direction);
        }

        /// <summary>
        /// Gets the artifact's message.
        /// </summary>
        /// <returns>The message.</returns>
        public int GetScore()
        {
            return score;
        }

        /// <summary>
        /// Sets the artifact's message to the given score.
        /// </summary>
        /// <param name="message">The given message.</param>
        public void SetScore(int score)
        {
            this.score = score;
        }
    }
}