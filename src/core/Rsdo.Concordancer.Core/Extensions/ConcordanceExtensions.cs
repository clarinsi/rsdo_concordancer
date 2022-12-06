using System;
using Rsdo.Concordancer.Core.Entities;
using Rsdo.Concordancer.Core.Model;

namespace Rsdo.Concordancer.Core.Extensions;

public static class ConcordanceExtensions
{
    public static void SetToken(this Concordance concordance, Token token, int position)
    {
        switch (position)
        {
            case -10:
                concordance.TokenLeft10 = token;
                break;
            case -9:
                concordance.TokenLeft9 = token;
                break;
            case -8:
                concordance.TokenLeft8 = token;
                break;
            case -7:
                concordance.TokenLeft7 = token;
                break;
            case -6:
                concordance.TokenLeft6 = token;
                break;
            case -5:
                concordance.TokenLeft5 = token;
                break;
            case -4:
                concordance.TokenLeft4 = token;
                break;
            case -3:
                concordance.TokenLeft3 = token;
                break;
            case -2:
                concordance.TokenLeft2 = token;
                break;
            case -1:
                concordance.TokenLeft1 = token;
                break;
            case 0:
                concordance.Token = token;
                break;
            case 1:
                concordance.TokenRight1 = token;
                break;
            case 2:
                concordance.TokenRight2 = token;
                break;
            case 3:
                concordance.TokenRight3 = token;
                break;
            case 4:
                concordance.TokenRight4 = token;
                break;
            case 5:
                concordance.TokenRight5 = token;
                break;
            case 6:
                concordance.TokenRight6 = token;
                break;
            case 7:
                concordance.TokenRight7 = token;
                break;
            case 8:
                concordance.TokenRight8 = token;
                break;
            case 9:
                concordance.TokenRight9 = token;
                break;
            case 10:
                concordance.TokenRight10 = token;
                break;
            default:
                throw new ArgumentException($"Invalid position {position}. Position should be between -10 and 10.", nameof(position));
        }
    }
}