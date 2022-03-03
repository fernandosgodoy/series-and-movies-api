using System;

namespace MoviesCollection.BusinessApp.Dtos.Movies
{
    [Flags]
    public enum MovieLanguage : short
    {
        English = 0,
        Japanese = 1,
        Portuguese = 2,
        Spanish = 4,
        Italian = 8,
        Germany = 16,
        Chinese = 32,
        Korean = 64,
        French = 128,
    }
}
