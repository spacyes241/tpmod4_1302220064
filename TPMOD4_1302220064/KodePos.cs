using System;

public class KodePos
{
    private Dictionary<string, string> data_KodePos = new Dictionary<string, string>()
    {
        { "Batununggal", "40266" },
        { "A. Kujangsari", "40287" },
        { "Mengger", "40267" },
        { "Wates", "40256" },
        { "Cijaura", "40287" },
        { "Jatisari", "40286" },
        { "Margasari", "40286" },
        { "Sekejati", "40286" },
        { "Kebonwaru", "40272" },
        { "Maleer", "40274" },
        { "Samoja", "40273" }
    };

    public string GetKodePos(string kelurahan_kodePos)
    {
        return data_KodePos.ContainsKey(kelurahan_kodePos) ? data_KodePos[kelurahan_kodePos] : "Kode pos tidak ditemukan";
    }
}