using System;

namespace ArtifactDeckSharp
{
    public class CardSetApiClientException : Exception
    {
        public CardSetApiClientException()
        {
        }

        public CardSetApiClientException(string message)
            : base(message)
        {
        }

        public CardSetApiClientException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
