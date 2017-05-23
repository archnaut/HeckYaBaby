using System;

namespace Service.Domain
{
    public interface IAuditable
    {
        DateTime RowDate { get; set; } 
        string RowStatus { get; set; }
    }
}