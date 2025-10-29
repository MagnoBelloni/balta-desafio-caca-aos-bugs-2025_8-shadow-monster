﻿using BugStore.Domain.Constants;
using System.Globalization;

namespace BugStore.Domain.Helpers
{
    public static class CultureInfoHelper
    {
        public static string GetMonthNameByInteger(int month, string culture = CultureConstants.BR_CULTURE_INFO)
        {
            var cultureInfo = new CultureInfo(culture);
            return cultureInfo.DateTimeFormat.GetMonthName(month);
        }
    }
}
