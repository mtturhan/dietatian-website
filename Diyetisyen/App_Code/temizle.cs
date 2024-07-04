using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for temizle
/// </summary>

public static class Temizle
{
    //public static string UrlCevir(this string kelime)
    //{
    //    if (kelime == "" || kelime == null) { return ""; }
    //    kelime = kelime.Replace("ş", "s");
    //    kelime = kelime.Replace("Ş", "S");
    //    kelime = kelime.Replace(".", "");
    //    kelime = kelime.Replace(":", "");
    //    kelime = kelime.Replace(";", "");
    //    kelime = kelime.Replace(",", "");
    //    kelime = kelime.Replace(" ", "-");
    //    kelime = kelime.Replace("!", "");
    //    kelime = kelime.Replace("(", "");
    //    kelime = kelime.Replace(")", "");
    //    kelime = kelime.Replace("'", "");
    //    kelime = kelime.Replace("ğ", "g");
    //    kelime = kelime.Replace("Ğ", "G");
    //    kelime = kelime.Replace("ı", "i");
    //    kelime = kelime.Replace("I", "i");
    //    kelime = kelime.Replace("ç", "c");
    //    kelime = kelime.Replace("ç", "C");
    //    kelime = kelime.Replace("ö", "o");
    //    kelime = kelime.Replace("Ö", "O");
    //    kelime = kelime.Replace("ü", "u");
    //    kelime = kelime.Replace("Ü", "U");
    //    kelime = kelime.Replace("`", "");
    //    kelime = kelime.Replace("=", "");
    //    kelime = kelime.Replace("&", "");
    //    kelime = kelime.Replace("%", "");
    //    kelime = kelime.Replace("#", "");
    //    kelime = kelime.Replace("<", "");
    //    kelime = kelime.Replace(">", "");
    //    kelime = kelime.Replace("*", "");
    //    kelime = kelime.Replace("?", "");
    //    kelime = kelime.Replace("+", "-");
    //    kelime = kelime.Replace("\"", "-");
    //    kelime = kelime.Replace("»", "-");
    //    kelime = kelime.Replace("|", "-");
    //    kelime = kelime.Replace("^", "");
    //    kelime = kelime.Replace(" ", "-");
    //    return kelime;
    //}

    public static string UrlCevir(string veri)
    {
        // Ürün, kategori, blog başlık vs..de sadece rakam harf ve boşluk olacak!
        // \\i kontrol et böyle yapınca çift olarak mı görüyor yoksa kaçış karakteri olarak mı
        // *" i kontrol et çift tırnak olarakmı alıyor yoksa kaçış karakterini görmüyor mu
        veri = veri.Trim().ToLower();
        veri = veri.Replace("&#sfr;x", "0x");
        veri = veri.Replace("&#sfr;X", "0x");
        veri = veri.Replace("-", " ");
        veri = veri.Replace("&#32;", " ");
        veri = veri.Replace("ç", "c");
        veri = veri.Replace("Ç", "C");
        veri = veri.Replace("ğ", "g");
        veri = veri.Replace("Ğ", "G");
        veri = veri.Replace("ü", "u");
        veri = veri.Replace("Ü", "U");
        veri = veri.Replace("ş", "s");
        veri = veri.Replace("Ş", "S");
        veri = veri.Replace("ö", "o");
        veri = veri.Replace("Ö", "O");
        veri = veri.Replace("ı", "i");
        veri = veri.Replace("İ", "I");
        veri = veri.Replace("!", "");
        veri = veri.Replace("'", "");
        veri = veri.Replace("&#33;", ""); //!
        veri = veri.Replace("$", "");
        veri = veri.Replace("&#36;", ""); //$
        veri = veri.Replace("%", "");
        veri = veri.Replace("&#37;", ""); //%
        veri = veri.Replace("'", "");
        veri = veri.Replace("&#39;", ""); //'
        veri = veri.Replace("(", "");
        veri = veri.Replace("&#40;", ""); //(
        veri = veri.Replace(")", "");
        veri = veri.Replace("&#41;", ""); //)
        veri = veri.Replace("*", "");
        veri = veri.Replace("&#42;", ""); //*
        veri = veri.Replace("+", "");
        veri = veri.Replace("&#43;", ""); //+
        veri = veri.Replace(",", "");
        veri = veri.Replace("&#44;", ""); //,
        veri = veri.Replace("/", "");
        veri = veri.Replace("&#47;", ""); // /
        veri = veri.Replace(":", "");
        veri = veri.Replace("&#58;", ""); //:
        veri = veri.Replace("<", "");
        veri = veri.Replace("&lt;", "");
        veri = veri.Replace("&#60;", "");//<
        veri = veri.Replace("=", "");
        veri = veri.Replace("&#61;", ""); //-
        veri = veri.Replace(">", "");
        veri = veri.Replace("&gt;", "");
        veri = veri.Replace("&#62;", "");//>
        veri = veri.Replace("?", "");
        veri = veri.Replace("&#63;", "");//?
        veri = veri.Replace("@", "");
        veri = veri.Replace("&#64;", "");//@
        veri = veri.Replace("\\", "");
        veri = veri.Replace("&#92;", "");// \
        veri = veri.Replace("[", "");
        veri = veri.Replace("&#91;", ""); //[
        veri = veri.Replace("]", "");
        veri = veri.Replace("&#93;", ""); //]
        veri = veri.Replace("^", "");
        veri = veri.Replace("&#94;", ""); //^
        veri = veri.Replace("_", "-");
        veri = veri.Replace("&#95;", ""); //_
        veri = veri.Replace("`", "");
        veri = veri.Replace("&#96;", ""); //`
        veri = veri.Replace("{", "");
        veri = veri.Replace("&#123;", ""); //{
        veri = veri.Replace("|", "");
        veri = veri.Replace("&#124;", ""); //|
        veri = veri.Replace("}", "");
        veri = veri.Replace("&#125;", ""); //}
        veri = veri.Replace("~", "");
        veri = veri.Replace("&#126;", ""); //~
        veri = veri.Replace("\"", "");
        veri = veri.Replace("&quot;", "");
        veri = veri.Replace("&#34;", ""); //"
        veri = veri.Replace("	", " ");
        veri = veri.Replace("&#09;", " "); //tab
        veri = veri.Replace("&", ""); //olası encodeden kalan artıklar için
        veri = veri.Replace("#", ""); //olası encodeden kalan artıklar için
        veri = veri.Replace(";", ""); //olası encodeden kalan artıklar için
        veri = veri.Replace("          ", "-");//10space
        veri = veri.Replace("         ", "-");//9space
        veri = veri.Replace("        ", "-");//8space
        veri = veri.Replace("       ", "-");//7space
        veri = veri.Replace("      ", "-");//6space
        veri = veri.Replace("     ", "-");//5space
        veri = veri.Replace("    ", "-");//4space
        veri = veri.Replace("   ", "-");//3space
        veri = veri.Replace("  ", "-");//2space
        veri = veri.Replace(" ", "-");//1space
        return veri;
    }
}