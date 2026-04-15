using System;
namespace OOP_IKTpv25_1_Tsalko
{
    public enum TööTüüp
    {
        Palk,
        Toetus
    }
    public interface ITööline
    {
        TööTüüp VäljamakseTüüp { get; set; }
        double ArvutaPalk();
    }
}


