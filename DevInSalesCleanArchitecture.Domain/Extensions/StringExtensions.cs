using System.Globalization;
using System.Text;

namespace DevInSalesCleanArchitecture.Domain.Extensions
{
    internal static class StringExtensions
    {
        /// <summary>
        /// Extensão do tipo string que recebe o parâmetro <paramref name="text"/> e o 
        /// transforma no padrão slug.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        internal static string ToSlug(this string text)
        {
            var normalizedString = text.ToLower().Replace(" ", "-").Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder(capacity: normalizedString.Length);

            for (int i = 0; i < normalizedString.Length; i++)
            {
                char c = normalizedString[i];
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder
                .ToString()
                .Normalize(NormalizationForm.FormC);
        }
    }
}
