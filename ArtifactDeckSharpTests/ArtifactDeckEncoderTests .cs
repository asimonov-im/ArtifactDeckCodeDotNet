using Xunit;

namespace ArtifactDeckSharp.Tests
{
    public class ArtifactDeckEncoderTests
    {
        [Fact]
        public void ParseDeckShouldCorrectlyParseDesk()
        {
            // Act
            string deckCode = ArtifactDeckEncoder.EncodeDeck(TestDecks.GreenBlackExample);

            // Verify
            Assert.Equal(TestDeckCodes.GreenBlackExample, deckCode);
        }
    }
}