using System.Collections.Generic;

namespace MoviesCollection.BusinessApp.Dtos.Messages
{
    public class Result
    {

        public int InsertedId { get; set; }
        public bool Success { get; set; }
        public IList<string> Messages { get; set; } = new List<string>();

    }
}
