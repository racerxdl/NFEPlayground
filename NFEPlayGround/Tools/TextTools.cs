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
  }
}
