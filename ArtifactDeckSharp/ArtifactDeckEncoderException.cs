using System;

namespace ArtifactDeckSharp
{
    public class ArtifactDeckEncoderException : Exception
    {
        public ArtifactDeckEncoderException()
        {
        }

        public ArtifactDeckEncoderException(string message)
            : base(message)
        {
        }

        public ArtifactDeckEncoderException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
