using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFEPlayGround.Tools {
  public static class TextTools {
    public static string RemoveAcentos(string text) {
      string formD = text.Normalize(NormalizationForm.FormD);
      StringBuilder sb = new StringBuilder();

      foreach (char ch in formD) {
        UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(ch);
        if (uc != UnicodeCategory.NonSpacingMark) {
          sb.Append(ch);
        }
      }

      return sb.ToString().Normalize(NormalizationForm.FormC);
    }

    /// <summary>
    /// Retorna uma string com o decimal formatado para d casas decimais.
    /// <para>Ex: Dec2Str(12.3, 5); // Retorna 12.30000</para>
    /// </summary>
    /// <param name="v">Valor Decimal</param>
    /// <param name="d">Numero de casas decimais</param>
    /// <returns></returns>
    public static string Dec2Str(decimal v, int d) {
      if (d <= 0) {
        return ((int)v).ToString();
      }

      string f = "{0:0.";
      for (int i=0; i<d; i++) {
        f += "#";
      }
      f += "}";

      return string.Format(f, d);
    }
    /// <summary>
    /// Retorna um decimal vindo de uma string invariante a cultura.
    /// <para>Ex: Str2Dec("10.300"); // Retorna um decimal 10.3</para>
    /// </summary>
    /// <param name="v"></param>
    /// <returns></returns>
    public static decimal Str2Dec(string v) {
      return decimal.Parse(v, CultureInfo.InvariantCulture);
    }
  }
}
