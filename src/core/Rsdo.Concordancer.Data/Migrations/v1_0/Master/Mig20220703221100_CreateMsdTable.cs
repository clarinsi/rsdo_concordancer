using System;
using System.Collections.Generic;
using FluentMigrator;
using Rsdo.Concordancer.Core.Entities;
using Rsdo.Concordancer.Data.Extensions;
using Rsdo.Concordancer.Data.Framework;

namespace Rsdo.Concordancer.Data.Migrations.v1_0.Master;

[MasterDb]
[Migration(20220703221100)]
public class Mig20220703221100_CreateMsdTable : ForwardOnlyMigration
{
    public override void Up()
    {
        // Msd
        Create.Table(nameof(Msd))
            .WithEntity()
            .WithColumn(nameof(Msd.Code))
            .AsString(32)
            .NotNullable()
            .WithColumn(nameof(Msd.Description))
            .AsString(255)
            .NotNullable()
            .WithColumn(nameof(Msd.EnglishDescription))
            .AsString(255)
            .NotNullable();

        Create.Index().OnTable(nameof(Msd)).OnColumn(nameof(Msd.Code)).Ascending().WithOptions().Unique();

        InsertMsds();
    }

    private void InsertMsds()
    {
        InsertMsd(
            "Ncmsn",
            "samostalnik vrsta=obcno_ime spol=moški število=ednina sklon=imenovalnik",
            "Noun Type=common Gender=masculine Number=singular Case=nominative");
        InsertMsd(
            "Ncmsg",
            "samostalnik vrsta=obcno_ime spol=moški število=ednina sklon=rodilnik",
            "Noun Type=common Gender=masculine Number=singular Case=genitive");
        InsertMsd(
            "Ncmsd",
            "samostalnik vrsta=obcno_ime spol=moški število=ednina sklon=dajalnik",
            "Noun Type=common Gender=masculine Number=singular Case=dative");
        InsertMsd(
            "Ncmsan",
            "samostalnik vrsta=obcno_ime spol=moški število=ednina sklon=tožilnik živost=ne",
            "Noun Type=common Gender=masculine Number=singular Case=accusative Animate=no");
        InsertMsd(
            "Ncmsay",
            "samostalnik vrsta=obcno_ime spol=moški število=ednina sklon=tožilnik živost=da",
            "Noun Type=common Gender=masculine Number=singular Case=accusative Animate=yes");
        InsertMsd(
            "Ncmsl",
            "samostalnik vrsta=obcno_ime spol=moški število=ednina sklon=mestnik",
            "Noun Type=common Gender=masculine Number=singular Case=locative");
        InsertMsd(
            "Ncmsi",
            "samostalnik vrsta=obcno_ime spol=moški število=ednina sklon=orodnik",
            "Noun Type=common Gender=masculine Number=singular Case=instrumental");
        InsertMsd(
            "Ncmdn",
            "samostalnik vrsta=obcno_ime spol=moški število=dvojina sklon=imenovalnik",
            "Noun Type=common Gender=masculine Number=dual Case=nominative");
        InsertMsd(
            "Ncmdg",
            "samostalnik vrsta=obcno_ime spol=moški število=dvojina sklon=rodilnik",
            "Noun Type=common Gender=masculine Number=dual Case=genitive");
        InsertMsd(
            "Ncmdd",
            "samostalnik vrsta=obcno_ime spol=moški število=dvojina sklon=dajalnik",
            "Noun Type=common Gender=masculine Number=dual Case=dative");
        InsertMsd(
            "Ncmda",
            "samostalnik vrsta=obcno_ime spol=moški število=dvojina sklon=tožilnik",
            "Noun Type=common Gender=masculine Number=dual Case=accusative");
        InsertMsd(
            "Ncmdl",
            "samostalnik vrsta=obcno_ime spol=moški število=dvojina sklon=mestnik",
            "Noun Type=common Gender=masculine Number=dual Case=locative");
        InsertMsd(
            "Ncmdi",
            "samostalnik vrsta=obcno_ime spol=moški število=dvojina sklon=orodnik",
            "Noun Type=common Gender=masculine Number=dual Case=instrumental");
        InsertMsd(
            "Ncmpn",
            "samostalnik vrsta=obcno_ime spol=moški število=množina sklon=imenovalnik",
            "Noun Type=common Gender=masculine Number=plural Case=nominative");
        InsertMsd(
            "Ncmpg",
            "samostalnik vrsta=obcno_ime spol=moški število=množina sklon=rodilnik",
            "Noun Type=common Gender=masculine Number=plural Case=genitive");
        InsertMsd(
            "Ncmpd",
            "samostalnik vrsta=obcno_ime spol=moški število=množina sklon=dajalnik",
            "Noun Type=common Gender=masculine Number=plural Case=dative");
        InsertMsd(
            "Ncmpa",
            "samostalnik vrsta=obcno_ime spol=moški število=množina sklon=tožilnik",
            "Noun Type=common Gender=masculine Number=plural Case=accusative");
        InsertMsd(
            "Ncmpl",
            "samostalnik vrsta=obcno_ime spol=moški število=množina sklon=mestnik",
            "Noun Type=common Gender=masculine Number=plural Case=locative");
        InsertMsd(
            "Ncmpi",
            "samostalnik vrsta=obcno_ime spol=moški število=množina sklon=orodnik",
            "Noun Type=common Gender=masculine Number=plural Case=instrumental");
        InsertMsd(
            "Ncfsn",
            "samostalnik vrsta=obcno_ime spol=ženski število=ednina sklon=imenovalnik",
            "Noun Type=common Gender=feminine Number=singular Case=nominative");
        InsertMsd(
            "Ncfsg",
            "samostalnik vrsta=obcno_ime spol=ženski število=ednina sklon=rodilnik",
            "Noun Type=common Gender=feminine Number=singular Case=genitive");
        InsertMsd(
            "Ncfsd",
            "samostalnik vrsta=obcno_ime spol=ženski število=ednina sklon=dajalnik",
            "Noun Type=common Gender=feminine Number=singular Case=dative");
        InsertMsd(
            "Ncfsa",
            "samostalnik vrsta=obcno_ime spol=ženski število=ednina sklon=tožilnik",
            "Noun Type=common Gender=feminine Number=singular Case=accusative");
        InsertMsd(
            "Ncfsl",
            "samostalnik vrsta=obcno_ime spol=ženski število=ednina sklon=mestnik",
            "Noun Type=common Gender=feminine Number=singular Case=locative");
        InsertMsd(
            "Ncfsi",
            "samostalnik vrsta=obcno_ime spol=ženski število=ednina sklon=orodnik",
            "Noun Type=common Gender=feminine Number=singular Case=instrumental");
        InsertMsd(
            "Ncfdn",
            "samostalnik vrsta=obcno_ime spol=ženski število=dvojina sklon=imenovalnik",
            "Noun Type=common Gender=feminine Number=dual Case=nominative");
        InsertMsd(
            "Ncfdg",
            "samostalnik vrsta=obcno_ime spol=ženski število=dvojina sklon=rodilnik",
            "Noun Type=common Gender=feminine Number=dual Case=genitive");
        InsertMsd(
            "Ncfdd",
            "samostalnik vrsta=obcno_ime spol=ženski število=dvojina sklon=dajalnik",
            "Noun Type=common Gender=feminine Number=dual Case=dative");
        InsertMsd(
            "Ncfda",
            "samostalnik vrsta=obcno_ime spol=ženski število=dvojina sklon=tožilnik",
            "Noun Type=common Gender=feminine Number=dual Case=accusative");
        InsertMsd(
            "Ncfdl",
            "samostalnik vrsta=obcno_ime spol=ženski število=dvojina sklon=mestnik",
            "Noun Type=common Gender=feminine Number=dual Case=locative");
        InsertMsd(
            "Ncfdi",
            "samostalnik vrsta=obcno_ime spol=ženski število=dvojina sklon=orodnik",
            "Noun Type=common Gender=feminine Number=dual Case=instrumental");
        InsertMsd(
            "Ncfpn",
            "samostalnik vrsta=obcno_ime spol=ženski število=množina sklon=imenovalnik",
            "Noun Type=common Gender=feminine Number=plural Case=nominative");
        InsertMsd(
            "Ncfpg",
            "samostalnik vrsta=obcno_ime spol=ženski število=množina sklon=rodilnik",
            "Noun Type=common Gender=feminine Number=plural Case=genitive");
        InsertMsd(
            "Ncfpd",
            "samostalnik vrsta=obcno_ime spol=ženski število=množina sklon=dajalnik",
            "Noun Type=common Gender=feminine Number=plural Case=dative");
        InsertMsd(
            "Ncfpa",
            "samostalnik vrsta=obcno_ime spol=ženski število=množina sklon=tožilnik",
            "Noun Type=common Gender=feminine Number=plural Case=accusative");
        InsertMsd(
            "Ncfpl",
            "samostalnik vrsta=obcno_ime spol=ženski število=množina sklon=mestnik",
            "Noun Type=common Gender=feminine Number=plural Case=locative");
        InsertMsd(
            "Ncfpi",
            "samostalnik vrsta=obcno_ime spol=ženski število=množina sklon=orodnik",
            "Noun Type=common Gender=feminine Number=plural Case=instrumental");
        InsertMsd(
            "Ncnsn",
            "samostalnik vrsta=obcno_ime spol=srednji število=ednina sklon=imenovalnik",
            "Noun Type=common Gender=neuter Number=singular Case=nominative");
        InsertMsd(
            "Ncnsg",
            "samostalnik vrsta=obcno_ime spol=srednji število=ednina sklon=rodilnik",
            "Noun Type=common Gender=neuter Number=singular Case=genitive");
        InsertMsd(
            "Ncnsd",
            "samostalnik vrsta=obcno_ime spol=srednji število=ednina sklon=dajalnik",
            "Noun Type=common Gender=neuter Number=singular Case=dative");
        InsertMsd(
            "Ncnsa",
            "samostalnik vrsta=obcno_ime spol=srednji število=ednina sklon=tožilnik",
            "Noun Type=common Gender=neuter Number=singular Case=accusative");
        InsertMsd(
            "Ncnsl",
            "samostalnik vrsta=obcno_ime spol=srednji število=ednina sklon=mestnik",
            "Noun Type=common Gender=neuter Number=singular Case=locative");
        InsertMsd(
            "Ncnsi",
            "samostalnik vrsta=obcno_ime spol=srednji število=ednina sklon=orodnik",
            "Noun Type=common Gender=neuter Number=singular Case=instrumental");
        InsertMsd(
            "Ncndn",
            "samostalnik vrsta=obcno_ime spol=srednji število=dvojina sklon=imenovalnik",
            "Noun Type=common Gender=neuter Number=dual Case=nominative");
        InsertMsd(
            "Ncndg",
            "samostalnik vrsta=obcno_ime spol=srednji število=dvojina sklon=rodilnik",
            "Noun Type=common Gender=neuter Number=dual Case=genitive");
        InsertMsd("Ncndd", "samostalnik vrsta=obcno_ime spol=srednji število=dvojina sklon=dajalnik", "Noun Type=common Gender=neuter Number=dual Case=dative");
        InsertMsd(
            "Ncnda",
            "samostalnik vrsta=obcno_ime spol=srednji število=dvojina sklon=tožilnik",
            "Noun Type=common Gender=neuter Number=dual Case=accusative");
        InsertMsd(
            "Ncndl",
            "samostalnik vrsta=obcno_ime spol=srednji število=dvojina sklon=mestnik",
            "Noun Type=common Gender=neuter Number=dual Case=locative");
        InsertMsd(
            "Ncndi",
            "samostalnik vrsta=obcno_ime spol=srednji število=dvojina sklon=orodnik",
            "Noun Type=common Gender=neuter Number=dual Case=instrumental");
        InsertMsd(
            "Ncnpn",
            "samostalnik vrsta=obcno_ime spol=srednji število=množina sklon=imenovalnik",
            "Noun Type=common Gender=neuter Number=plural Case=nominative");
        InsertMsd(
            "Ncnpg",
            "samostalnik vrsta=obcno_ime spol=srednji število=množina sklon=rodilnik",
            "Noun Type=common Gender=neuter Number=plural Case=genitive");
        InsertMsd(
            "Ncnpd",
            "samostalnik vrsta=obcno_ime spol=srednji število=množina sklon=dajalnik",
            "Noun Type=common Gender=neuter Number=plural Case=dative");
        InsertMsd(
            "Ncnpa",
            "samostalnik vrsta=obcno_ime spol=srednji število=množina sklon=tožilnik",
            "Noun Type=common Gender=neuter Number=plural Case=accusative");
        InsertMsd(
            "Ncnpl",
            "samostalnik vrsta=obcno_ime spol=srednji število=množina sklon=mestnik",
            "Noun Type=common Gender=neuter Number=plural Case=locative");
        InsertMsd(
            "Ncnpi",
            "samostalnik vrsta=obcno_ime spol=srednji število=množina sklon=orodnik",
            "Noun Type=common Gender=neuter Number=plural Case=instrumental");
        InsertMsd(
            "Npmsn",
            "samostalnik vrsta=lastno_ime spol=moški število=ednina sklon=imenovalnik",
            "Noun Type=proper Gender=masculine Number=singular Case=nominative");
        InsertMsd(
            "Npmsg",
            "samostalnik vrsta=lastno_ime spol=moški število=ednina sklon=rodilnik",
            "Noun Type=proper Gender=masculine Number=singular Case=genitive");
        InsertMsd(
            "Npmsd",
            "samostalnik vrsta=lastno_ime spol=moški število=ednina sklon=dajalnik",
            "Noun Type=proper Gender=masculine Number=singular Case=dative");
        InsertMsd(
            "Npmsan",
            "samostalnik vrsta=lastno_ime spol=moški število=ednina sklon=tožilnik živost=ne",
            "Noun Type=proper Gender=masculine Number=singular Case=accusative Animate=no");
        InsertMsd(
            "Npmsay",
            "samostalnik vrsta=lastno_ime spol=moški število=ednina sklon=tožilnik živost=da",
            "Noun Type=proper Gender=masculine Number=singular Case=accusative Animate=yes");
        InsertMsd(
            "Npmsl",
            "samostalnik vrsta=lastno_ime spol=moški število=ednina sklon=mestnik",
            "Noun Type=proper Gender=masculine Number=singular Case=locative");
        InsertMsd(
            "Npmsi",
            "samostalnik vrsta=lastno_ime spol=moški število=ednina sklon=orodnik",
            "Noun Type=proper Gender=masculine Number=singular Case=instrumental");
        InsertMsd(
            "Npmdn",
            "samostalnik vrsta=lastno_ime spol=moški število=dvojina sklon=imenovalnik",
            "Noun Type=proper Gender=masculine Number=dual Case=nominative");
        InsertMsd(
            "Npmdg",
            "samostalnik vrsta=lastno_ime spol=moški število=dvojina sklon=rodilnik",
            "Noun Type=proper Gender=masculine Number=dual Case=genitive");
        InsertMsd(
            "Npmdd",
            "samostalnik vrsta=lastno_ime spol=moški število=dvojina sklon=dajalnik",
            "Noun Type=proper Gender=masculine Number=dual Case=dative");
        InsertMsd(
            "Npmda",
            "samostalnik vrsta=lastno_ime spol=moški število=dvojina sklon=tožilnik",
            "Noun Type=proper Gender=masculine Number=dual Case=accusative");
        InsertMsd(
            "Npmdl",
            "samostalnik vrsta=lastno_ime spol=moški število=dvojina sklon=mestnik",
            "Noun Type=proper Gender=masculine Number=dual Case=locative");
        InsertMsd(
            "Npmdi",
            "samostalnik vrsta=lastno_ime spol=moški število=dvojina sklon=orodnik",
            "Noun Type=proper Gender=masculine Number=dual Case=instrumental");
        InsertMsd(
            "Npmpn",
            "samostalnik vrsta=lastno_ime spol=moški število=množina sklon=imenovalnik",
            "Noun Type=proper Gender=masculine Number=plural Case=nominative");
        InsertMsd(
            "Npmpg",
            "samostalnik vrsta=lastno_ime spol=moški število=množina sklon=rodilnik",
            "Noun Type=proper Gender=masculine Number=plural Case=genitive");
        InsertMsd(
            "Npmpd",
            "samostalnik vrsta=lastno_ime spol=moški število=množina sklon=dajalnik",
            "Noun Type=proper Gender=masculine Number=plural Case=dative");
        InsertMsd(
            "Npmpa",
            "samostalnik vrsta=lastno_ime spol=moški število=množina sklon=tožilnik",
            "Noun Type=proper Gender=masculine Number=plural Case=accusative");
        InsertMsd(
            "Npmpl",
            "samostalnik vrsta=lastno_ime spol=moški število=množina sklon=mestnik",
            "Noun Type=proper Gender=masculine Number=plural Case=locative");
        InsertMsd(
            "Npmpi",
            "samostalnik vrsta=lastno_ime spol=moški število=množina sklon=orodnik",
            "Noun Type=proper Gender=masculine Number=plural Case=instrumental");
        InsertMsd(
            "Npfsn",
            "samostalnik vrsta=lastno_ime spol=ženski število=ednina sklon=imenovalnik",
            "Noun Type=proper Gender=feminine Number=singular Case=nominative");
        InsertMsd(
            "Npfsg",
            "samostalnik vrsta=lastno_ime spol=ženski število=ednina sklon=rodilnik",
            "Noun Type=proper Gender=feminine Number=singular Case=genitive");
        InsertMsd(
            "Npfsd",
            "samostalnik vrsta=lastno_ime spol=ženski število=ednina sklon=dajalnik",
            "Noun Type=proper Gender=feminine Number=singular Case=dative");
        InsertMsd(
            "Npfsa",
            "samostalnik vrsta=lastno_ime spol=ženski število=ednina sklon=tožilnik",
            "Noun Type=proper Gender=feminine Number=singular Case=accusative");
        InsertMsd(
            "Npfsl",
            "samostalnik vrsta=lastno_ime spol=ženski število=ednina sklon=mestnik",
            "Noun Type=proper Gender=feminine Number=singular Case=locative");
        InsertMsd(
            "Npfsi",
            "samostalnik vrsta=lastno_ime spol=ženski število=ednina sklon=orodnik",
            "Noun Type=proper Gender=feminine Number=singular Case=instrumental");
        InsertMsd(
            "Npfdn",
            "samostalnik vrsta=lastno_ime spol=ženski število=dvojina sklon=imenovalnik",
            "Noun Type=proper Gender=feminine Number=dual Case=nominative");
        InsertMsd(
            "Npfdg",
            "samostalnik vrsta=lastno_ime spol=ženski število=dvojina sklon=rodilnik",
            "Noun Type=proper Gender=feminine Number=dual Case=genitive");
        InsertMsd(
            "Npfdd",
            "samostalnik vrsta=lastno_ime spol=ženski število=dvojina sklon=dajalnik",
            "Noun Type=proper Gender=feminine Number=dual Case=dative");
        InsertMsd(
            "Npfda",
            "samostalnik vrsta=lastno_ime spol=ženski število=dvojina sklon=tožilnik",
            "Noun Type=proper Gender=feminine Number=dual Case=accusative");
        InsertMsd(
            "Npfdl",
            "samostalnik vrsta=lastno_ime spol=ženski število=dvojina sklon=mestnik",
            "Noun Type=proper Gender=feminine Number=dual Case=locative");
        InsertMsd(
            "Npfdi",
            "samostalnik vrsta=lastno_ime spol=ženski število=dvojina sklon=orodnik",
            "Noun Type=proper Gender=feminine Number=dual Case=instrumental");
        InsertMsd(
            "Npfpn",
            "samostalnik vrsta=lastno_ime spol=ženski število=množina sklon=imenovalnik",
            "Noun Type=proper Gender=feminine Number=plural Case=nominative");
        InsertMsd(
            "Npfpg",
            "samostalnik vrsta=lastno_ime spol=ženski število=množina sklon=rodilnik",
            "Noun Type=proper Gender=feminine Number=plural Case=genitive");
        InsertMsd(
            "Npfpd",
            "samostalnik vrsta=lastno_ime spol=ženski število=množina sklon=dajalnik",
            "Noun Type=proper Gender=feminine Number=plural Case=dative");
        InsertMsd(
            "Npfpa",
            "samostalnik vrsta=lastno_ime spol=ženski število=množina sklon=tožilnik",
            "Noun Type=proper Gender=feminine Number=plural Case=accusative");
        InsertMsd(
            "Npfpl",
            "samostalnik vrsta=lastno_ime spol=ženski število=množina sklon=mestnik",
            "Noun Type=proper Gender=feminine Number=plural Case=locative");
        InsertMsd(
            "Npfpi",
            "samostalnik vrsta=lastno_ime spol=ženski število=množina sklon=orodnik",
            "Noun Type=proper Gender=feminine Number=plural Case=instrumental");
        InsertMsd(
            "Npnsn",
            "samostalnik vrsta=lastno_ime spol=srednji število=ednina sklon=imenovalnik",
            "Noun Type=proper Gender=neuter Number=singular Case=nominative");
        InsertMsd(
            "Npnsg",
            "samostalnik vrsta=lastno_ime spol=srednji število=ednina sklon=rodilnik",
            "Noun Type=proper Gender=neuter Number=singular Case=genitive");
        InsertMsd(
            "Npnsd",
            "samostalnik vrsta=lastno_ime spol=srednji število=ednina sklon=dajalnik",
            "Noun Type=proper Gender=neuter Number=singular Case=dative");
        InsertMsd(
            "Npnsa",
            "samostalnik vrsta=lastno_ime spol=srednji število=ednina sklon=tožilnik",
            "Noun Type=proper Gender=neuter Number=singular Case=accusative");
        InsertMsd(
            "Npnsl",
            "samostalnik vrsta=lastno_ime spol=srednji število=ednina sklon=mestnik",
            "Noun Type=proper Gender=neuter Number=singular Case=locative");
        InsertMsd(
            "Npnsi",
            "samostalnik vrsta=lastno_ime spol=srednji število=ednina sklon=orodnik",
            "Noun Type=proper Gender=neuter Number=singular Case=instrumental");
        InsertMsd(
            "Npnpn",
            "samostalnik vrsta=lastno_ime spol=srednji število=množina sklon=imenovalnik",
            "Noun Type=proper Gender=neuter Number=plural Case=nominative");
        InsertMsd(
            "Npnpg",
            "samostalnik vrsta=lastno_ime spol=srednji število=množina sklon=rodilnik",
            "Noun Type=proper Gender=neuter Number=plural Case=genitive");
        InsertMsd(
            "Npnpd",
            "samostalnik vrsta=lastno_ime spol=srednji število=množina sklon=dajalnik",
            "Noun Type=proper Gender=neuter Number=plural Case=dative");
        InsertMsd(
            "Npnpa",
            "samostalnik vrsta=lastno_ime spol=srednji število=množina sklon=tožilnik",
            "Noun Type=proper Gender=neuter Number=plural Case=accusative");
        InsertMsd(
            "Npnpl",
            "samostalnik vrsta=lastno_ime spol=srednji število=množina sklon=mestnik",
            "Noun Type=proper Gender=neuter Number=plural Case=locative");
        InsertMsd(
            "Npnpi",
            "samostalnik vrsta=lastno_ime spol=srednji število=množina sklon=orodnik",
            "Noun Type=proper Gender=neuter Number=plural Case=instrumental");
        InsertMsd("Vmen", "glagol vrsta=glavni vid=dovršni oblika=nedolocnik", "Verb Type=main Aspect=perfective VForm=infinitive");
        InsertMsd("Vmeu", "glagol vrsta=glavni vid=dovršni oblika=namenilnik", "Verb Type=main Aspect=perfective VForm=supine");
        InsertMsd(
            "Vmep-sm",
            "glagol vrsta=glavni vid=dovršni oblika=deležnik število=ednina spol=moški",
            "Verb Type=main Aspect=perfective VForm=participle Number=singular Gender=masculine");
        InsertMsd(
            "Vmep-sf",
            "glagol vrsta=glavni vid=dovršni oblika=deležnik število=ednina spol=ženski",
            "Verb Type=main Aspect=perfective VForm=participle Number=singular Gender=feminine");
        InsertMsd(
            "Vmep-sn",
            "glagol vrsta=glavni vid=dovršni oblika=deležnik število=ednina spol=srednji",
            "Verb Type=main Aspect=perfective VForm=participle Number=singular Gender=neuter");
        InsertMsd(
            "Vmep-pm",
            "glagol vrsta=glavni vid=dovršni oblika=deležnik število=množina spol=moški",
            "Verb Type=main Aspect=perfective VForm=participle Number=plural Gender=masculine");
        InsertMsd(
            "Vmep-pf",
            "glagol vrsta=glavni vid=dovršni oblika=deležnik število=množina spol=ženski",
            "Verb Type=main Aspect=perfective VForm=participle Number=plural Gender=feminine");
        InsertMsd(
            "Vmep-pn",
            "glagol vrsta=glavni vid=dovršni oblika=deležnik število=množina spol=srednji",
            "Verb Type=main Aspect=perfective VForm=participle Number=plural Gender=neuter");
        InsertMsd(
            "Vmep-dm",
            "glagol vrsta=glavni vid=dovršni oblika=deležnik število=dvojina spol=moški",
            "Verb Type=main Aspect=perfective VForm=participle Number=dual Gender=masculine");
        InsertMsd(
            "Vmep-df",
            "glagol vrsta=glavni vid=dovršni oblika=deležnik število=dvojina spol=ženski",
            "Verb Type=main Aspect=perfective VForm=participle Number=dual Gender=feminine");
        InsertMsd(
            "Vmep-dn",
            "glagol vrsta=glavni vid=dovršni oblika=deležnik število=dvojina spol=srednji",
            "Verb Type=main Aspect=perfective VForm=participle Number=dual Gender=neuter");
        InsertMsd(
            "Vmer1s",
            "glagol vrsta=glavni vid=dovršni oblika=sedanjik oseba=prva število=ednina",
            "Verb Type=main Aspect=perfective VForm=present Person=first Number=singular");
        InsertMsd(
            "Vmer1p",
            "glagol vrsta=glavni vid=dovršni oblika=sedanjik oseba=prva število=množina",
            "Verb Type=main Aspect=perfective VForm=present Person=first Number=plural");
        InsertMsd(
            "Vmer1d",
            "glagol vrsta=glavni vid=dovršni oblika=sedanjik oseba=prva število=dvojina",
            "Verb Type=main Aspect=perfective VForm=present Person=first Number=dual");
        InsertMsd(
            "Vmer2s",
            "glagol vrsta=glavni vid=dovršni oblika=sedanjik oseba=druga število=ednina",
            "Verb Type=main Aspect=perfective VForm=present Person=second Number=singular");
        InsertMsd(
            "Vmer2p",
            "glagol vrsta=glavni vid=dovršni oblika=sedanjik oseba=druga število=množina",
            "Verb Type=main Aspect=perfective VForm=present Person=second Number=plural");
        InsertMsd(
            "Vmer2d",
            "glagol vrsta=glavni vid=dovršni oblika=sedanjik oseba=druga število=dvojina",
            "Verb Type=main Aspect=perfective VForm=present Person=second Number=dual");
        InsertMsd(
            "Vmer3s",
            "glagol vrsta=glavni vid=dovršni oblika=sedanjik oseba=tretja število=ednina",
            "Verb Type=main Aspect=perfective VForm=present Person=third Number=singular");
        InsertMsd(
            "Vmer3p",
            "glagol vrsta=glavni vid=dovršni oblika=sedanjik oseba=tretja število=množina",
            "Verb Type=main Aspect=perfective VForm=present Person=third Number=plural");
        InsertMsd(
            "Vmer3d",
            "glagol vrsta=glavni vid=dovršni oblika=sedanjik oseba=tretja število=dvojina",
            "Verb Type=main Aspect=perfective VForm=present Person=third Number=dual");
        InsertMsd(
            "Vmem1p",
            "glagol vrsta=glavni vid=dovršni oblika=velelnik oseba=prva število=množina",
            "Verb Type=main Aspect=perfective VForm=imperative Person=first Number=plural");
        InsertMsd(
            "Vmem1d",
            "glagol vrsta=glavni vid=dovršni oblika=velelnik oseba=prva število=dvojina",
            "Verb Type=main Aspect=perfective VForm=imperative Person=first Number=dual");
        InsertMsd(
            "Vmem2s",
            "glagol vrsta=glavni vid=dovršni oblika=velelnik oseba=druga število=ednina",
            "Verb Type=main Aspect=perfective VForm=imperative Person=second Number=singular");
        InsertMsd(
            "Vmem2p",
            "glagol vrsta=glavni vid=dovršni oblika=velelnik oseba=druga število=množina",
            "Verb Type=main Aspect=perfective VForm=imperative Person=second Number=plural");
        InsertMsd(
            "Vmem2d",
            "glagol vrsta=glavni vid=dovršni oblika=velelnik oseba=druga število=dvojina",
            "Verb Type=main Aspect=perfective VForm=imperative Person=second Number=dual");
        InsertMsd("Vmpn", "glagol vrsta=glavni vid=nedovršni oblika=nedolocnik", "Verb Type=main Aspect=progressive VForm=infinitive");
        InsertMsd("Vmpu", "glagol vrsta=glavni vid=nedovršni oblika=namenilnik", "Verb Type=main Aspect=progressive VForm=supine");
        InsertMsd(
            "Vmpp-sm",
            "glagol vrsta=glavni vid=nedovršni oblika=deležnik število=ednina spol=moški",
            "Verb Type=main Aspect=progressive VForm=participle Number=singular Gender=masculine");
        InsertMsd(
            "Vmpp-sf",
            "glagol vrsta=glavni vid=nedovršni oblika=deležnik število=ednina spol=ženski",
            "Verb Type=main Aspect=progressive VForm=participle Number=singular Gender=feminine");
        InsertMsd(
            "Vmpp-sn",
            "glagol vrsta=glavni vid=nedovršni oblika=deležnik število=ednina spol=srednji",
            "Verb Type=main Aspect=progressive VForm=participle Number=singular Gender=neuter");
        InsertMsd(
            "Vmpp-pm",
            "glagol vrsta=glavni vid=nedovršni oblika=deležnik število=množina spol=moški",
            "Verb Type=main Aspect=progressive VForm=participle Number=plural Gender=masculine");
        InsertMsd(
            "Vmpp-pf",
            "glagol vrsta=glavni vid=nedovršni oblika=deležnik število=množina spol=ženski",
            "Verb Type=main Aspect=progressive VForm=participle Number=plural Gender=feminine");
        InsertMsd(
            "Vmpp-pn",
            "glagol vrsta=glavni vid=nedovršni oblika=deležnik število=množina spol=srednji",
            "Verb Type=main Aspect=progressive VForm=participle Number=plural Gender=neuter");
        InsertMsd(
            "Vmpp-dm",
            "glagol vrsta=glavni vid=nedovršni oblika=deležnik število=dvojina spol=moški",
            "Verb Type=main Aspect=progressive VForm=participle Number=dual Gender=masculine");
        InsertMsd(
            "Vmpp-df",
            "glagol vrsta=glavni vid=nedovršni oblika=deležnik število=dvojina spol=ženski",
            "Verb Type=main Aspect=progressive VForm=participle Number=dual Gender=feminine");
        InsertMsd(
            "Vmpp-dn",
            "glagol vrsta=glavni vid=nedovršni oblika=deležnik število=dvojina spol=srednji",
            "Verb Type=main Aspect=progressive VForm=participle Number=dual Gender=neuter");
        InsertMsd(
            "Vmpr1s",
            "glagol vrsta=glavni vid=nedovršni oblika=sedanjik oseba=prva število=ednina",
            "Verb Type=main Aspect=progressive VForm=present Person=first Number=singular");
        InsertMsd(
            "Vmpr1s-n",
            "glagol vrsta=glavni vid=nedovršni oblika=sedanjik oseba=prva število=ednina nikalnost=nezanikani",
            "Verb Type=main Aspect=progressive VForm=present Person=first Number=singular Negative=no");
        InsertMsd(
            "Vmpr1s-y",
            "glagol vrsta=glavni vid=nedovršni oblika=sedanjik oseba=prva število=ednina nikalnost=zanikani",
            "Verb Type=main Aspect=progressive VForm=present Person=first Number=singular Negative=yes");
        InsertMsd(
            "Vmpr1p",
            "glagol vrsta=glavni vid=nedovršni oblika=sedanjik oseba=prva število=množina",
            "Verb Type=main Aspect=progressive VForm=present Person=first Number=plural");
        InsertMsd(
            "Vmpr1p-n",
            "glagol vrsta=glavni vid=nedovršni oblika=sedanjik oseba=prva število=množina nikalnost=nezanikani",
            "Verb Type=main Aspect=progressive VForm=present Person=first Number=plural Negative=no");
        InsertMsd(
            "Vmpr1p-y",
            "glagol vrsta=glavni vid=nedovršni oblika=sedanjik oseba=prva število=množina nikalnost=zanikani",
            "Verb Type=main Aspect=progressive VForm=present Person=first Number=plural Negative=yes");
        InsertMsd(
            "Vmpr1d",
            "glagol vrsta=glavni vid=nedovršni oblika=sedanjik oseba=prva število=dvojina",
            "Verb Type=main Aspect=progressive VForm=present Person=first Number=dual");
        InsertMsd(
            "Vmpr1d-n",
            "glagol vrsta=glavni vid=nedovršni oblika=sedanjik oseba=prva število=dvojina nikalnost=nezanikani",
            "Verb Type=main Aspect=progressive VForm=present Person=first Number=dual Negative=no");
        InsertMsd(
            "Vmpr1d-y",
            "glagol vrsta=glavni vid=nedovršni oblika=sedanjik oseba=prva število=dvojina nikalnost=zanikani",
            "Verb Type=main Aspect=progressive VForm=present Person=first Number=dual Negative=yes");
        InsertMsd(
            "Vmpr2s",
            "glagol vrsta=glavni vid=nedovršni oblika=sedanjik oseba=druga število=ednina",
            "Verb Type=main Aspect=progressive VForm=present Person=second Number=singular");
        InsertMsd(
            "Vmpr2s-n",
            "glagol vrsta=glavni vid=nedovršni oblika=sedanjik oseba=druga število=ednina nikalnost=nezanikani",
            "Verb Type=main Aspect=progressive VForm=present Person=second Number=singular Negative=no");
        InsertMsd(
            "Vmpr2s-y",
            "glagol vrsta=glavni vid=nedovršni oblika=sedanjik oseba=druga število=ednina nikalnost=zanikani",
            "Verb Type=main Aspect=progressive VForm=present Person=second Number=singular Negative=yes");
        InsertMsd(
            "Vmpr2p",
            "glagol vrsta=glavni vid=nedovršni oblika=sedanjik oseba=druga število=množina",
            "Verb Type=main Aspect=progressive VForm=present Person=second Number=plural");
        InsertMsd(
            "Vmpr2p-n",
            "glagol vrsta=glavni vid=nedovršni oblika=sedanjik oseba=druga število=množina nikalnost=nezanikani",
            "Verb Type=main Aspect=progressive VForm=present Person=second Number=plural Negative=no");
        InsertMsd(
            "Vmpr2p-y",
            "glagol vrsta=glavni vid=nedovršni oblika=sedanjik oseba=druga število=množina nikalnost=zanikani",
            "Verb Type=main Aspect=progressive VForm=present Person=second Number=plural Negative=yes");
        InsertMsd(
            "Vmpr2d",
            "glagol vrsta=glavni vid=nedovršni oblika=sedanjik oseba=druga število=dvojina",
            "Verb Type=main Aspect=progressive VForm=present Person=second Number=dual");
        InsertMsd(
            "Vmpr2d-n",
            "glagol vrsta=glavni vid=nedovršni oblika=sedanjik oseba=druga število=dvojina nikalnost=nezanikani",
            "Verb Type=main Aspect=progressive VForm=present Person=second Number=dual Negative=no");
        InsertMsd(
            "Vmpr2d-y",
            "glagol vrsta=glavni vid=nedovršni oblika=sedanjik oseba=druga število=dvojina nikalnost=zanikani",
            "Verb Type=main Aspect=progressive VForm=present Person=second Number=dual Negative=yes");
        InsertMsd(
            "Vmpr3s",
            "glagol vrsta=glavni vid=nedovršni oblika=sedanjik oseba=tretja število=ednina",
            "Verb Type=main Aspect=progressive VForm=present Person=third Number=singular");
        InsertMsd(
            "Vmpr3s-n",
            "glagol vrsta=glavni vid=nedovršni oblika=sedanjik oseba=tretja število=ednina nikalnost=nezanikani",
            "Verb Type=main Aspect=progressive VForm=present Person=third Number=singular Negative=no");
        InsertMsd(
            "Vmpr3s-y",
            "glagol vrsta=glavni vid=nedovršni oblika=sedanjik oseba=tretja število=ednina nikalnost=zanikani",
            "Verb Type=main Aspect=progressive VForm=present Person=third Number=singular Negative=yes");
        InsertMsd(
            "Vmpr3p",
            "glagol vrsta=glavni vid=nedovršni oblika=sedanjik oseba=tretja število=množina",
            "Verb Type=main Aspect=progressive VForm=present Person=third Number=plural");
        InsertMsd(
            "Vmpr3p-n",
            "glagol vrsta=glavni vid=nedovršni oblika=sedanjik oseba=tretja število=množina nikalnost=nezanikani",
            "Verb Type=main Aspect=progressive VForm=present Person=third Number=plural Negative=no");
        InsertMsd(
            "Vmpr3p-y",
            "glagol vrsta=glavni vid=nedovršni oblika=sedanjik oseba=tretja število=množina nikalnost=zanikani",
            "Verb Type=main Aspect=progressive VForm=present Person=third Number=plural Negative=yes");
        InsertMsd(
            "Vmpr3d",
            "glagol vrsta=glavni vid=nedovršni oblika=sedanjik oseba=tretja število=dvojina",
            "Verb Type=main Aspect=progressive VForm=present Person=third Number=dual");
        InsertMsd(
            "Vmpr3d-n",
            "glagol vrsta=glavni vid=nedovršni oblika=sedanjik oseba=tretja število=dvojina nikalnost=nezanikani",
            "Verb Type=main Aspect=progressive VForm=present Person=third Number=dual Negative=no");
        InsertMsd(
            "Vmpr3d-y",
            "glagol vrsta=glavni vid=nedovršni oblika=sedanjik oseba=tretja število=dvojina nikalnost=zanikani",
            "Verb Type=main Aspect=progressive VForm=present Person=third Number=dual Negative=yes");
        InsertMsd(
            "Vmpm1p",
            "glagol vrsta=glavni vid=nedovršni oblika=velelnik oseba=prva število=množina",
            "Verb Type=main Aspect=progressive VForm=imperative Person=first Number=plural");
        InsertMsd(
            "Vmpm1d",
            "glagol vrsta=glavni vid=nedovršni oblika=velelnik oseba=prva število=dvojina",
            "Verb Type=main Aspect=progressive VForm=imperative Person=first Number=dual");
        InsertMsd(
            "Vmpm2s",
            "glagol vrsta=glavni vid=nedovršni oblika=velelnik oseba=druga število=ednina",
            "Verb Type=main Aspect=progressive VForm=imperative Person=second Number=singular");
        InsertMsd(
            "Vmpm2p",
            "glagol vrsta=glavni vid=nedovršni oblika=velelnik oseba=druga število=množina",
            "Verb Type=main Aspect=progressive VForm=imperative Person=second Number=plural");
        InsertMsd(
            "Vmpm2d",
            "glagol vrsta=glavni vid=nedovršni oblika=velelnik oseba=druga število=dvojina",
            "Verb Type=main Aspect=progressive VForm=imperative Person=second Number=dual");
        InsertMsd("Vmbn", "glagol vrsta=glavni vid=dvovidski oblika=nedolocnik", "Verb Type=main Aspect=biaspectual VForm=infinitive");
        InsertMsd("Vmbu", "glagol vrsta=glavni vid=dvovidski oblika=namenilnik", "Verb Type=main Aspect=biaspectual VForm=supine");
        InsertMsd(
            "Vmbp-sm",
            "glagol vrsta=glavni vid=dvovidski oblika=deležnik število=ednina spol=moški",
            "Verb Type=main Aspect=biaspectual VForm=participle Number=singular Gender=masculine");
        InsertMsd(
            "Vmbp-sf",
            "glagol vrsta=glavni vid=dvovidski oblika=deležnik število=ednina spol=ženski",
            "Verb Type=main Aspect=biaspectual VForm=participle Number=singular Gender=feminine");
        InsertMsd(
            "Vmbp-sn",
            "glagol vrsta=glavni vid=dvovidski oblika=deležnik število=ednina spol=srednji",
            "Verb Type=main Aspect=biaspectual VForm=participle Number=singular Gender=neuter");
        InsertMsd(
            "Vmbp-pm",
            "glagol vrsta=glavni vid=dvovidski oblika=deležnik število=množina spol=moški",
            "Verb Type=main Aspect=biaspectual VForm=participle Number=plural Gender=masculine");
        InsertMsd(
            "Vmbp-pf",
            "glagol vrsta=glavni vid=dvovidski oblika=deležnik število=množina spol=ženski",
            "Verb Type=main Aspect=biaspectual VForm=participle Number=plural Gender=feminine");
        InsertMsd(
            "Vmbp-pn",
            "glagol vrsta=glavni vid=dvovidski oblika=deležnik število=množina spol=srednji",
            "Verb Type=main Aspect=biaspectual VForm=participle Number=plural Gender=neuter");
        InsertMsd(
            "Vmbp-dm",
            "glagol vrsta=glavni vid=dvovidski oblika=deležnik število=dvojina spol=moški",
            "Verb Type=main Aspect=biaspectual VForm=participle Number=dual Gender=masculine");
        InsertMsd(
            "Vmbp-df",
            "glagol vrsta=glavni vid=dvovidski oblika=deležnik število=dvojina spol=ženski",
            "Verb Type=main Aspect=biaspectual VForm=participle Number=dual Gender=feminine");
        InsertMsd(
            "Vmbp-dn",
            "glagol vrsta=glavni vid=dvovidski oblika=deležnik število=dvojina spol=srednji",
            "Verb Type=main Aspect=biaspectual VForm=participle Number=dual Gender=neuter");
        InsertMsd(
            "Vmbr1s",
            "glagol vrsta=glavni vid=dvovidski oblika=sedanjik oseba=prva število=ednina",
            "Verb Type=main Aspect=biaspectual VForm=present Person=first Number=singular");
        InsertMsd(
            "Vmbr1p",
            "glagol vrsta=glavni vid=dvovidski oblika=sedanjik oseba=prva število=množina",
            "Verb Type=main Aspect=biaspectual VForm=present Person=first Number=plural");
        InsertMsd(
            "Vmbr1d",
            "glagol vrsta=glavni vid=dvovidski oblika=sedanjik oseba=prva število=dvojina",
            "Verb Type=main Aspect=biaspectual VForm=present Person=first Number=dual");
        InsertMsd(
            "Vmbr1df",
            "glagol vrsta=glavni vid=dvovidski oblika=sedanjik oseba=prva število=dvojina spol=ženski",
            "Verb Type=main Aspect=biaspectual VForm=present Person=first Number=dual Gender=feminine");
        InsertMsd(
            "Vmbr2s",
            "glagol vrsta=glavni vid=dvovidski oblika=sedanjik oseba=druga število=ednina",
            "Verb Type=main Aspect=biaspectual VForm=present Person=second Number=singular");
        InsertMsd(
            "Vmbr2p",
            "glagol vrsta=glavni vid=dvovidski oblika=sedanjik oseba=druga število=množina",
            "Verb Type=main Aspect=biaspectual VForm=present Person=second Number=plural");
        InsertMsd(
            "Vmbr2d",
            "glagol vrsta=glavni vid=dvovidski oblika=sedanjik oseba=druga število=dvojina",
            "Verb Type=main Aspect=biaspectual VForm=present Person=second Number=dual");
        InsertMsd(
            "Vmbr3s",
            "glagol vrsta=glavni vid=dvovidski oblika=sedanjik oseba=tretja število=ednina",
            "Verb Type=main Aspect=biaspectual VForm=present Person=third Number=singular");
        InsertMsd(
            "Vmbr3p",
            "glagol vrsta=glavni vid=dvovidski oblika=sedanjik oseba=tretja število=množina",
            "Verb Type=main Aspect=biaspectual VForm=present Person=third Number=plural");
        InsertMsd(
            "Vmbr3d",
            "glagol vrsta=glavni vid=dvovidski oblika=sedanjik oseba=tretja število=dvojina",
            "Verb Type=main Aspect=biaspectual VForm=present Person=third Number=dual");
        InsertMsd(
            "Vmbf1s",
            "glagol vrsta=glavni vid=dvovidski oblika=prihodnjik oseba=prva število=ednina",
            "Verb Type=main Aspect=biaspectual VForm=future Person=first Number=singular");
        InsertMsd(
            "Vmbf1p",
            "glagol vrsta=glavni vid=dvovidski oblika=prihodnjik oseba=prva število=množina",
            "Verb Type=main Aspect=biaspectual VForm=future Person=first Number=plural");
        InsertMsd(
            "Vmbf1d",
            "glagol vrsta=glavni vid=dvovidski oblika=prihodnjik oseba=prva število=dvojina",
            "Verb Type=main Aspect=biaspectual VForm=future Person=first Number=dual");
        InsertMsd(
            "Vmbf2s",
            "glagol vrsta=glavni vid=dvovidski oblika=prihodnjik oseba=druga število=ednina",
            "Verb Type=main Aspect=biaspectual VForm=future Person=second Number=singular");
        InsertMsd(
            "Vmbf2p",
            "glagol vrsta=glavni vid=dvovidski oblika=prihodnjik oseba=druga število=množina",
            "Verb Type=main Aspect=biaspectual VForm=future Person=second Number=plural");
        InsertMsd(
            "Vmbf2d",
            "glagol vrsta=glavni vid=dvovidski oblika=prihodnjik oseba=druga število=dvojina",
            "Verb Type=main Aspect=biaspectual VForm=future Person=second Number=dual");
        InsertMsd(
            "Vmbf3s",
            "glagol vrsta=glavni vid=dvovidski oblika=prihodnjik oseba=tretja število=ednina",
            "Verb Type=main Aspect=biaspectual VForm=future Person=third Number=singular");
        InsertMsd(
            "Vmbf3p",
            "glagol vrsta=glavni vid=dvovidski oblika=prihodnjik oseba=tretja število=množina",
            "Verb Type=main Aspect=biaspectual VForm=future Person=third Number=plural");
        InsertMsd(
            "Vmbf3d",
            "glagol vrsta=glavni vid=dvovidski oblika=prihodnjik oseba=tretja število=dvojina",
            "Verb Type=main Aspect=biaspectual VForm=future Person=third Number=dual");
        InsertMsd(
            "Vmbm1p",
            "glagol vrsta=glavni vid=dvovidski oblika=velelnik oseba=prva število=množina",
            "Verb Type=main Aspect=biaspectual VForm=imperative Person=first Number=plural");
        InsertMsd(
            "Vmbm1d",
            "glagol vrsta=glavni vid=dvovidski oblika=velelnik oseba=prva število=dvojina",
            "Verb Type=main Aspect=biaspectual VForm=imperative Person=first Number=dual");
        InsertMsd(
            "Vmbm2s",
            "glagol vrsta=glavni vid=dvovidski oblika=velelnik oseba=druga število=ednina",
            "Verb Type=main Aspect=biaspectual VForm=imperative Person=second Number=singular");
        InsertMsd(
            "Vmbm2p",
            "glagol vrsta=glavni vid=dvovidski oblika=velelnik oseba=druga število=množina",
            "Verb Type=main Aspect=biaspectual VForm=imperative Person=second Number=plural");
        InsertMsd(
            "Vmbm2d",
            "glagol vrsta=glavni vid=dvovidski oblika=velelnik oseba=druga število=dvojina",
            "Verb Type=main Aspect=biaspectual VForm=imperative Person=second Number=dual");
        InsertMsd("Va-n", "glagol vrsta=pomožni oblika=nedolocnik", "Verb Type=auxiliary VForm=infinitive");
        InsertMsd("Va-u", "glagol vrsta=pomožni oblika=namenilnik", "Verb Type=auxiliary VForm=supine");
        InsertMsd(
            "Va-p-sm",
            "glagol vrsta=pomožni oblika=deležnik število=ednina spol=moški",
            "Verb Type=auxiliary VForm=participle Number=singular Gender=masculine");
        InsertMsd(
            "Va-p-sf",
            "glagol vrsta=pomožni oblika=deležnik število=ednina spol=ženski",
            "Verb Type=auxiliary VForm=participle Number=singular Gender=feminine");
        InsertMsd(
            "Va-p-sn",
            "glagol vrsta=pomožni oblika=deležnik število=ednina spol=srednji",
            "Verb Type=auxiliary VForm=participle Number=singular Gender=neuter");
        InsertMsd(
            "Va-p-pm",
            "glagol vrsta=pomožni oblika=deležnik število=množina spol=moški",
            "Verb Type=auxiliary VForm=participle Number=plural Gender=masculine");
        InsertMsd(
            "Va-p-pf",
            "glagol vrsta=pomožni oblika=deležnik število=množina spol=ženski",
            "Verb Type=auxiliary VForm=participle Number=plural Gender=feminine");
        InsertMsd(
            "Va-p-pn",
            "glagol vrsta=pomožni oblika=deležnik število=množina spol=srednji",
            "Verb Type=auxiliary VForm=participle Number=plural Gender=neuter");
        InsertMsd(
            "Va-p-dm",
            "glagol vrsta=pomožni oblika=deležnik število=dvojina spol=moški",
            "Verb Type=auxiliary VForm=participle Number=dual Gender=masculine");
        InsertMsd(
            "Va-p-df",
            "glagol vrsta=pomožni oblika=deležnik število=dvojina spol=ženski",
            "Verb Type=auxiliary VForm=participle Number=dual Gender=feminine");
        InsertMsd(
            "Va-p-dn",
            "glagol vrsta=pomožni oblika=deležnik število=dvojina spol=srednji",
            "Verb Type=auxiliary VForm=participle Number=dual Gender=neuter");
        InsertMsd(
            "Va-r1s-n",
            "glagol vrsta=pomožni oblika=sedanjik oseba=prva število=ednina nikalnost=nezanikani",
            "Verb Type=auxiliary VForm=present Person=first Number=singular Negative=no");
        InsertMsd(
            "Va-r1s-y",
            "glagol vrsta=pomožni oblika=sedanjik oseba=prva število=ednina nikalnost=zanikani",
            "Verb Type=auxiliary VForm=present Person=first Number=singular Negative=yes");
        InsertMsd(
            "Va-r1p-n",
            "glagol vrsta=pomožni oblika=sedanjik oseba=prva število=množina nikalnost=nezanikani",
            "Verb Type=auxiliary VForm=present Person=first Number=plural Negative=no");
        InsertMsd(
            "Va-r1p-y",
            "glagol vrsta=pomožni oblika=sedanjik oseba=prva število=množina nikalnost=zanikani",
            "Verb Type=auxiliary VForm=present Person=first Number=plural Negative=yes");
        InsertMsd(
            "Va-r1d-n",
            "glagol vrsta=pomožni oblika=sedanjik oseba=prva število=dvojina nikalnost=nezanikani",
            "Verb Type=auxiliary VForm=present Person=first Number=dual Negative=no");
        InsertMsd(
            "Va-r1d-y",
            "glagol vrsta=pomožni oblika=sedanjik oseba=prva število=dvojina nikalnost=zanikani",
            "Verb Type=auxiliary VForm=present Person=first Number=dual Negative=yes");
        InsertMsd(
            "Va-r1dfn",
            "glagol vrsta=pomožni oblika=sedanjik oseba=prva število=dvojina spol=ženski nikalnost=nezanikani",
            "Verb Type=auxiliary VForm=present Person=first Number=dual Gender=feminine Negative=no");
        InsertMsd(
            "Va-r2s-n",
            "glagol vrsta=pomožni oblika=sedanjik oseba=druga število=ednina nikalnost=nezanikani",
            "Verb Type=auxiliary VForm=present Person=second Number=singular Negative=no");
        InsertMsd(
            "Va-r2s-y",
            "glagol vrsta=pomožni oblika=sedanjik oseba=druga število=ednina nikalnost=zanikani",
            "Verb Type=auxiliary VForm=present Person=second Number=singular Negative=yes");
        InsertMsd(
            "Va-r2p-n",
            "glagol vrsta=pomožni oblika=sedanjik oseba=druga število=množina nikalnost=nezanikani",
            "Verb Type=auxiliary VForm=present Person=second Number=plural Negative=no");
        InsertMsd(
            "Va-r2p-y",
            "glagol vrsta=pomožni oblika=sedanjik oseba=druga število=množina nikalnost=zanikani",
            "Verb Type=auxiliary VForm=present Person=second Number=plural Negative=yes");
        InsertMsd(
            "Va-r2d-n",
            "glagol vrsta=pomožni oblika=sedanjik oseba=druga število=dvojina nikalnost=nezanikani",
            "Verb Type=auxiliary VForm=present Person=second Number=dual Negative=no");
        InsertMsd(
            "Va-r2d-y",
            "glagol vrsta=pomožni oblika=sedanjik oseba=druga število=dvojina nikalnost=zanikani",
            "Verb Type=auxiliary VForm=present Person=second Number=dual Negative=yes");
        InsertMsd(
            "Va-r3s-n",
            "glagol vrsta=pomožni oblika=sedanjik oseba=tretja število=ednina nikalnost=nezanikani",
            "Verb Type=auxiliary VForm=present Person=third Number=singular Negative=no");
        InsertMsd(
            "Va-r3s-y",
            "glagol vrsta=pomožni oblika=sedanjik oseba=tretja število=ednina nikalnost=zanikani",
            "Verb Type=auxiliary VForm=present Person=third Number=singular Negative=yes");
        InsertMsd(
            "Va-r3p-n",
            "glagol vrsta=pomožni oblika=sedanjik oseba=tretja število=množina nikalnost=nezanikani",
            "Verb Type=auxiliary VForm=present Person=third Number=plural Negative=no");
        InsertMsd(
            "Va-r3p-y",
            "glagol vrsta=pomožni oblika=sedanjik oseba=tretja število=množina nikalnost=zanikani",
            "Verb Type=auxiliary VForm=present Person=third Number=plural Negative=yes");
        InsertMsd(
            "Va-r3d-n",
            "glagol vrsta=pomožni oblika=sedanjik oseba=tretja število=dvojina nikalnost=nezanikani",
            "Verb Type=auxiliary VForm=present Person=third Number=dual Negative=no");
        InsertMsd(
            "Va-r3d-y",
            "glagol vrsta=pomožni oblika=sedanjik oseba=tretja število=dvojina nikalnost=zanikani",
            "Verb Type=auxiliary VForm=present Person=third Number=dual Negative=yes");
        InsertMsd(
            "Va-f1s-n",
            "glagol vrsta=pomožni oblika=prihodnjik oseba=prva število=ednina nikalnost=nezanikani",
            "Verb Type=auxiliary VForm=future Person=first Number=singular Negative=no");
        InsertMsd(
            "Va-f1s-y",
            "glagol vrsta=pomožni oblika=prihodnjik oseba=prva število=ednina nikalnost=zanikani",
            "Verb Type=auxiliary VForm=future Person=first Number=singular Negative=yes");
        InsertMsd(
            "Va-f1p-n",
            "glagol vrsta=pomožni oblika=prihodnjik oseba=prva število=množina nikalnost=nezanikani",
            "Verb Type=auxiliary VForm=future Person=first Number=plural Negative=no");
        InsertMsd(
            "Va-f1p-y",
            "glagol vrsta=pomožni oblika=prihodnjik oseba=prva število=množina nikalnost=zanikani",
            "Verb Type=auxiliary VForm=future Person=first Number=plural Negative=yes");
        InsertMsd("Va-f1d", "glagol vrsta=pomožni oblika=prihodnjik oseba=prva število=dvojina", "Verb Type=auxiliary VForm=future Person=first Number=dual");
        InsertMsd(
            "Va-f1d-n",
            "glagol vrsta=pomožni oblika=prihodnjik oseba=prva število=dvojina nikalnost=nezanikani",
            "Verb Type=auxiliary VForm=future Person=first Number=dual Negative=no");
        InsertMsd(
            "Va-f1d-y",
            "glagol vrsta=pomožni oblika=prihodnjik oseba=prva število=dvojina nikalnost=zanikani",
            "Verb Type=auxiliary VForm=future Person=first Number=dual Negative=yes");
        InsertMsd(
            "Va-f2s-n",
            "glagol vrsta=pomožni oblika=prihodnjik oseba=druga število=ednina nikalnost=nezanikani",
            "Verb Type=auxiliary VForm=future Person=second Number=singular Negative=no");
        InsertMsd(
            "Va-f2s-y",
            "glagol vrsta=pomožni oblika=prihodnjik oseba=druga število=ednina nikalnost=zanikani",
            "Verb Type=auxiliary VForm=future Person=second Number=singular Negative=yes");
        InsertMsd(
            "Va-f2p-n",
            "glagol vrsta=pomožni oblika=prihodnjik oseba=druga število=množina nikalnost=nezanikani",
            "Verb Type=auxiliary VForm=future Person=second Number=plural Negative=no");
        InsertMsd(
            "Va-f2d-n",
            "glagol vrsta=pomožni oblika=prihodnjik oseba=druga število=dvojina nikalnost=nezanikani",
            "Verb Type=auxiliary VForm=future Person=second Number=dual Negative=no");
        InsertMsd(
            "Va-f3s-n",
            "glagol vrsta=pomožni oblika=prihodnjik oseba=tretja število=ednina nikalnost=nezanikani",
            "Verb Type=auxiliary VForm=future Person=third Number=singular Negative=no");
        InsertMsd(
            "Va-f3s-y",
            "glagol vrsta=pomožni oblika=prihodnjik oseba=tretja število=ednina nikalnost=zanikani",
            "Verb Type=auxiliary VForm=future Person=third Number=singular Negative=yes");
        InsertMsd(
            "Va-f3p-n",
            "glagol vrsta=pomožni oblika=prihodnjik oseba=tretja število=množina nikalnost=nezanikani",
            "Verb Type=auxiliary VForm=future Person=third Number=plural Negative=no");
        InsertMsd(
            "Va-f3p-y",
            "glagol vrsta=pomožni oblika=prihodnjik oseba=tretja število=množina nikalnost=zanikani",
            "Verb Type=auxiliary VForm=future Person=third Number=plural Negative=yes");
        InsertMsd(
            "Va-f3d-n",
            "glagol vrsta=pomožni oblika=prihodnjik oseba=tretja število=dvojina nikalnost=nezanikani",
            "Verb Type=auxiliary VForm=future Person=third Number=dual Negative=no");
        InsertMsd("Va-c", "glagol vrsta=pomožni oblika=pogojnik", "Verb Type=auxiliary VForm=conditional");
        InsertMsd("Va-c---y", "glagol vrsta=pomožni oblika=pogojnik nikalnost=zanikani", "Verb Type=auxiliary VForm=conditional Negative=yes");
        InsertMsd(
            "Va-m1p",
            "glagol vrsta=pomožni oblika=velelnik oseba=prva število=množina",
            "Verb Type=auxiliary VForm=imperative Person=first Number=plural");
        InsertMsd("Va-m1d", "glagol vrsta=pomožni oblika=velelnik oseba=prva število=dvojina", "Verb Type=auxiliary VForm=imperative Person=first Number=dual");
        InsertMsd(
            "Va-m2s",
            "glagol vrsta=pomožni oblika=velelnik oseba=druga število=ednina",
            "Verb Type=auxiliary VForm=imperative Person=second Number=singular");
        InsertMsd(
            "Va-m2p",
            "glagol vrsta=pomožni oblika=velelnik oseba=druga število=množina",
            "Verb Type=auxiliary VForm=imperative Person=second Number=plural");
        InsertMsd(
            "Va-m2d",
            "glagol vrsta=pomožni oblika=velelnik oseba=druga število=dvojina",
            "Verb Type=auxiliary VForm=imperative Person=second Number=dual");
        InsertMsd(
            "Agpmsnn",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=moški število=ednina sklon=imenovalnik dolocnost=ne",
            "Adjective Type=general Degree=positive Gender=masculine Number=singular Case=nominative Definiteness=no");
        InsertMsd(
            "Agpmsny",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=moški število=ednina sklon=imenovalnik dolocnost=da",
            "Adjective Type=general Degree=positive Gender=masculine Number=singular Case=nominative Definiteness=yes");
        InsertMsd(
            "Agpmsg",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=moški število=ednina sklon=rodilnik",
            "Adjective Type=general Degree=positive Gender=masculine Number=singular Case=genitive");
        InsertMsd(
            "Agpmsd",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=moški število=ednina sklon=dajalnik",
            "Adjective Type=general Degree=positive Gender=masculine Number=singular Case=dative");
        InsertMsd(
            "Agpmsa",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=moški število=ednina sklon=tožilnik",
            "Adjective Type=general Degree=positive Gender=masculine Number=singular Case=accusative");
        InsertMsd(
            "Agpmsan",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=moški število=ednina sklon=tožilnik dolocnost=ne",
            "Adjective Type=general Degree=positive Gender=masculine Number=singular Case=accusative Definiteness=no");
        InsertMsd(
            "Agpmsay",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=moški število=ednina sklon=tožilnik dolocnost=da",
            "Adjective Type=general Degree=positive Gender=masculine Number=singular Case=accusative Definiteness=yes");
        InsertMsd(
            "Agpmsl",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=moški število=ednina sklon=mestnik",
            "Adjective Type=general Degree=positive Gender=masculine Number=singular Case=locative");
        InsertMsd(
            "Agpmsi",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=moški število=ednina sklon=orodnik",
            "Adjective Type=general Degree=positive Gender=masculine Number=singular Case=instrumental");
        InsertMsd(
            "Agpmdn",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=moški število=dvojina sklon=imenovalnik",
            "Adjective Type=general Degree=positive Gender=masculine Number=dual Case=nominative");
        InsertMsd(
            "Agpmdg",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=moški število=dvojina sklon=rodilnik",
            "Adjective Type=general Degree=positive Gender=masculine Number=dual Case=genitive");
        InsertMsd(
            "Agpmdd",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=moški število=dvojina sklon=dajalnik",
            "Adjective Type=general Degree=positive Gender=masculine Number=dual Case=dative");
        InsertMsd(
            "Agpmda",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=moški število=dvojina sklon=tožilnik",
            "Adjective Type=general Degree=positive Gender=masculine Number=dual Case=accusative");
        InsertMsd(
            "Agpmdl",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=moški število=dvojina sklon=mestnik",
            "Adjective Type=general Degree=positive Gender=masculine Number=dual Case=locative");
        InsertMsd(
            "Agpmdi",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=moški število=dvojina sklon=orodnik",
            "Adjective Type=general Degree=positive Gender=masculine Number=dual Case=instrumental");
        InsertMsd(
            "Agpmpn",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=moški število=množina sklon=imenovalnik",
            "Adjective Type=general Degree=positive Gender=masculine Number=plural Case=nominative");
        InsertMsd(
            "Agpmpg",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=moški število=množina sklon=rodilnik",
            "Adjective Type=general Degree=positive Gender=masculine Number=plural Case=genitive");
        InsertMsd(
            "Agpmpd",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=moški število=množina sklon=dajalnik",
            "Adjective Type=general Degree=positive Gender=masculine Number=plural Case=dative");
        InsertMsd(
            "Agpmpa",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=moški število=množina sklon=tožilnik",
            "Adjective Type=general Degree=positive Gender=masculine Number=plural Case=accusative");
        InsertMsd(
            "Agpmpl",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=moški število=množina sklon=mestnik",
            "Adjective Type=general Degree=positive Gender=masculine Number=plural Case=locative");
        InsertMsd(
            "Agpmpi",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=moški število=množina sklon=orodnik",
            "Adjective Type=general Degree=positive Gender=masculine Number=plural Case=instrumental");
        InsertMsd(
            "Agpfsn",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=ženski število=ednina sklon=imenovalnik",
            "Adjective Type=general Degree=positive Gender=feminine Number=singular Case=nominative");
        InsertMsd(
            "Agpfsg",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=ženski število=ednina sklon=rodilnik",
            "Adjective Type=general Degree=positive Gender=feminine Number=singular Case=genitive");
        InsertMsd(
            "Agpfsd",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=ženski število=ednina sklon=dajalnik",
            "Adjective Type=general Degree=positive Gender=feminine Number=singular Case=dative");
        InsertMsd(
            "Agpfsa",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=ženski število=ednina sklon=tožilnik",
            "Adjective Type=general Degree=positive Gender=feminine Number=singular Case=accusative");
        InsertMsd(
            "Agpfsl",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=ženski število=ednina sklon=mestnik",
            "Adjective Type=general Degree=positive Gender=feminine Number=singular Case=locative");
        InsertMsd(
            "Agpfsi",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=ženski število=ednina sklon=orodnik",
            "Adjective Type=general Degree=positive Gender=feminine Number=singular Case=instrumental");
        InsertMsd(
            "Agpfdn",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=ženski število=dvojina sklon=imenovalnik",
            "Adjective Type=general Degree=positive Gender=feminine Number=dual Case=nominative");
        InsertMsd(
            "Agpfdg",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=ženski število=dvojina sklon=rodilnik",
            "Adjective Type=general Degree=positive Gender=feminine Number=dual Case=genitive");
        InsertMsd(
            "Agpfdd",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=ženski število=dvojina sklon=dajalnik",
            "Adjective Type=general Degree=positive Gender=feminine Number=dual Case=dative");
        InsertMsd(
            "Agpfda",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=ženski število=dvojina sklon=tožilnik",
            "Adjective Type=general Degree=positive Gender=feminine Number=dual Case=accusative");
        InsertMsd(
            "Agpfdl",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=ženski število=dvojina sklon=mestnik",
            "Adjective Type=general Degree=positive Gender=feminine Number=dual Case=locative");
        InsertMsd(
            "Agpfdi",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=ženski število=dvojina sklon=orodnik",
            "Adjective Type=general Degree=positive Gender=feminine Number=dual Case=instrumental");
        InsertMsd(
            "Agpfpn",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=ženski število=množina sklon=imenovalnik",
            "Adjective Type=general Degree=positive Gender=feminine Number=plural Case=nominative");
        InsertMsd(
            "Agpfpg",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=ženski število=množina sklon=rodilnik",
            "Adjective Type=general Degree=positive Gender=feminine Number=plural Case=genitive");
        InsertMsd(
            "Agpfpd",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=ženski število=množina sklon=dajalnik",
            "Adjective Type=general Degree=positive Gender=feminine Number=plural Case=dative");
        InsertMsd(
            "Agpfpa",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=ženski število=množina sklon=tožilnik",
            "Adjective Type=general Degree=positive Gender=feminine Number=plural Case=accusative");
        InsertMsd(
            "Agpfpl",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=ženski število=množina sklon=mestnik",
            "Adjective Type=general Degree=positive Gender=feminine Number=plural Case=locative");
        InsertMsd(
            "Agpfpi",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=ženski število=množina sklon=orodnik",
            "Adjective Type=general Degree=positive Gender=feminine Number=plural Case=instrumental");
        InsertMsd(
            "Agpnsn",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=srednji število=ednina sklon=imenovalnik",
            "Adjective Type=general Degree=positive Gender=neuter Number=singular Case=nominative");
        InsertMsd(
            "Agpnsg",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=srednji število=ednina sklon=rodilnik",
            "Adjective Type=general Degree=positive Gender=neuter Number=singular Case=genitive");
        InsertMsd(
            "Agpnsd",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=srednji število=ednina sklon=dajalnik",
            "Adjective Type=general Degree=positive Gender=neuter Number=singular Case=dative");
        InsertMsd(
            "Agpnsa",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=srednji število=ednina sklon=tožilnik",
            "Adjective Type=general Degree=positive Gender=neuter Number=singular Case=accusative");
        InsertMsd(
            "Agpnsl",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=srednji število=ednina sklon=mestnik",
            "Adjective Type=general Degree=positive Gender=neuter Number=singular Case=locative");
        InsertMsd(
            "Agpnsi",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=srednji število=ednina sklon=orodnik",
            "Adjective Type=general Degree=positive Gender=neuter Number=singular Case=instrumental");
        InsertMsd(
            "Agpndn",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=srednji število=dvojina sklon=imenovalnik",
            "Adjective Type=general Degree=positive Gender=neuter Number=dual Case=nominative");
        InsertMsd(
            "Agpndg",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=srednji število=dvojina sklon=rodilnik",
            "Adjective Type=general Degree=positive Gender=neuter Number=dual Case=genitive");
        InsertMsd(
            "Agpndd",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=srednji število=dvojina sklon=dajalnik",
            "Adjective Type=general Degree=positive Gender=neuter Number=dual Case=dative");
        InsertMsd(
            "Agpnda",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=srednji število=dvojina sklon=tožilnik",
            "Adjective Type=general Degree=positive Gender=neuter Number=dual Case=accusative");
        InsertMsd(
            "Agpndl",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=srednji število=dvojina sklon=mestnik",
            "Adjective Type=general Degree=positive Gender=neuter Number=dual Case=locative");
        InsertMsd(
            "Agpndi",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=srednji število=dvojina sklon=orodnik",
            "Adjective Type=general Degree=positive Gender=neuter Number=dual Case=instrumental");
        InsertMsd(
            "Agpnpn",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=srednji število=množina sklon=imenovalnik",
            "Adjective Type=general Degree=positive Gender=neuter Number=plural Case=nominative");
        InsertMsd(
            "Agpnpg",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=srednji število=množina sklon=rodilnik",
            "Adjective Type=general Degree=positive Gender=neuter Number=plural Case=genitive");
        InsertMsd(
            "Agpnpd",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=srednji število=množina sklon=dajalnik",
            "Adjective Type=general Degree=positive Gender=neuter Number=plural Case=dative");
        InsertMsd(
            "Agpnpa",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=srednji število=množina sklon=tožilnik",
            "Adjective Type=general Degree=positive Gender=neuter Number=plural Case=accusative");
        InsertMsd(
            "Agpnpl",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=srednji število=množina sklon=mestnik",
            "Adjective Type=general Degree=positive Gender=neuter Number=plural Case=locative");
        InsertMsd(
            "Agpnpi",
            "pridevnik vrsta=splošni stopnja=nedoloceno spol=srednji število=množina sklon=orodnik",
            "Adjective Type=general Degree=positive Gender=neuter Number=plural Case=instrumental");
        InsertMsd(
            "Agcmsny",
            "pridevnik vrsta=splošni stopnja=primernik spol=moški število=ednina sklon=imenovalnik dolocnost=da",
            "Adjective Type=general Degree=comparative Gender=masculine Number=singular Case=nominative Definiteness=yes");
        InsertMsd(
            "Agcmsg",
            "pridevnik vrsta=splošni stopnja=primernik spol=moški število=ednina sklon=rodilnik",
            "Adjective Type=general Degree=comparative Gender=masculine Number=singular Case=genitive");
        InsertMsd(
            "Agcmsd",
            "pridevnik vrsta=splošni stopnja=primernik spol=moški število=ednina sklon=dajalnik",
            "Adjective Type=general Degree=comparative Gender=masculine Number=singular Case=dative");
        InsertMsd(
            "Agcmsa",
            "pridevnik vrsta=splošni stopnja=primernik spol=moški število=ednina sklon=tožilnik",
            "Adjective Type=general Degree=comparative Gender=masculine Number=singular Case=accusative");
        InsertMsd(
            "Agcmsay",
            "pridevnik vrsta=splošni stopnja=primernik spol=moški število=ednina sklon=tožilnik dolocnost=da",
            "Adjective Type=general Degree=comparative Gender=masculine Number=singular Case=accusative Definiteness=yes");
        InsertMsd(
            "Agcmsl",
            "pridevnik vrsta=splošni stopnja=primernik spol=moški število=ednina sklon=mestnik",
            "Adjective Type=general Degree=comparative Gender=masculine Number=singular Case=locative");
        InsertMsd(
            "Agcmsi",
            "pridevnik vrsta=splošni stopnja=primernik spol=moški število=ednina sklon=orodnik",
            "Adjective Type=general Degree=comparative Gender=masculine Number=singular Case=instrumental");
        InsertMsd(
            "Agcmdn",
            "pridevnik vrsta=splošni stopnja=primernik spol=moški število=dvojina sklon=imenovalnik",
            "Adjective Type=general Degree=comparative Gender=masculine Number=dual Case=nominative");
        InsertMsd(
            "Agcmdg",
            "pridevnik vrsta=splošni stopnja=primernik spol=moški število=dvojina sklon=rodilnik",
            "Adjective Type=general Degree=comparative Gender=masculine Number=dual Case=genitive");
        InsertMsd(
            "Agcmdd",
            "pridevnik vrsta=splošni stopnja=primernik spol=moški število=dvojina sklon=dajalnik",
            "Adjective Type=general Degree=comparative Gender=masculine Number=dual Case=dative");
        InsertMsd(
            "Agcmda",
            "pridevnik vrsta=splošni stopnja=primernik spol=moški število=dvojina sklon=tožilnik",
            "Adjective Type=general Degree=comparative Gender=masculine Number=dual Case=accusative");
        InsertMsd(
            "Agcmdl",
            "pridevnik vrsta=splošni stopnja=primernik spol=moški število=dvojina sklon=mestnik",
            "Adjective Type=general Degree=comparative Gender=masculine Number=dual Case=locative");
        InsertMsd(
            "Agcmdi",
            "pridevnik vrsta=splošni stopnja=primernik spol=moški število=dvojina sklon=orodnik",
            "Adjective Type=general Degree=comparative Gender=masculine Number=dual Case=instrumental");
        InsertMsd(
            "Agcmpn",
            "pridevnik vrsta=splošni stopnja=primernik spol=moški število=množina sklon=imenovalnik",
            "Adjective Type=general Degree=comparative Gender=masculine Number=plural Case=nominative");
        InsertMsd(
            "Agcmpg",
            "pridevnik vrsta=splošni stopnja=primernik spol=moški število=množina sklon=rodilnik",
            "Adjective Type=general Degree=comparative Gender=masculine Number=plural Case=genitive");
        InsertMsd(
            "Agcmpd",
            "pridevnik vrsta=splošni stopnja=primernik spol=moški število=množina sklon=dajalnik",
            "Adjective Type=general Degree=comparative Gender=masculine Number=plural Case=dative");
        InsertMsd(
            "Agcmpa",
            "pridevnik vrsta=splošni stopnja=primernik spol=moški število=množina sklon=tožilnik",
            "Adjective Type=general Degree=comparative Gender=masculine Number=plural Case=accusative");
        InsertMsd(
            "Agcmpl",
            "pridevnik vrsta=splošni stopnja=primernik spol=moški število=množina sklon=mestnik",
            "Adjective Type=general Degree=comparative Gender=masculine Number=plural Case=locative");
        InsertMsd(
            "Agcmpi",
            "pridevnik vrsta=splošni stopnja=primernik spol=moški število=množina sklon=orodnik",
            "Adjective Type=general Degree=comparative Gender=masculine Number=plural Case=instrumental");
        InsertMsd(
            "Agcfsn",
            "pridevnik vrsta=splošni stopnja=primernik spol=ženski število=ednina sklon=imenovalnik",
            "Adjective Type=general Degree=comparative Gender=feminine Number=singular Case=nominative");
        InsertMsd(
            "Agcfsg",
            "pridevnik vrsta=splošni stopnja=primernik spol=ženski število=ednina sklon=rodilnik",
            "Adjective Type=general Degree=comparative Gender=feminine Number=singular Case=genitive");
        InsertMsd(
            "Agcfsd",
            "pridevnik vrsta=splošni stopnja=primernik spol=ženski število=ednina sklon=dajalnik",
            "Adjective Type=general Degree=comparative Gender=feminine Number=singular Case=dative");
        InsertMsd(
            "Agcfsa",
            "pridevnik vrsta=splošni stopnja=primernik spol=ženski število=ednina sklon=tožilnik",
            "Adjective Type=general Degree=comparative Gender=feminine Number=singular Case=accusative");
        InsertMsd(
            "Agcfsl",
            "pridevnik vrsta=splošni stopnja=primernik spol=ženski število=ednina sklon=mestnik",
            "Adjective Type=general Degree=comparative Gender=feminine Number=singular Case=locative");
        InsertMsd(
            "Agcfsi",
            "pridevnik vrsta=splošni stopnja=primernik spol=ženski število=ednina sklon=orodnik",
            "Adjective Type=general Degree=comparative Gender=feminine Number=singular Case=instrumental");
        InsertMsd(
            "Agcfdn",
            "pridevnik vrsta=splošni stopnja=primernik spol=ženski število=dvojina sklon=imenovalnik",
            "Adjective Type=general Degree=comparative Gender=feminine Number=dual Case=nominative");
        InsertMsd(
            "Agcfdg",
            "pridevnik vrsta=splošni stopnja=primernik spol=ženski število=dvojina sklon=rodilnik",
            "Adjective Type=general Degree=comparative Gender=feminine Number=dual Case=genitive");
        InsertMsd(
            "Agcfdd",
            "pridevnik vrsta=splošni stopnja=primernik spol=ženski število=dvojina sklon=dajalnik",
            "Adjective Type=general Degree=comparative Gender=feminine Number=dual Case=dative");
        InsertMsd(
            "Agcfda",
            "pridevnik vrsta=splošni stopnja=primernik spol=ženski število=dvojina sklon=tožilnik",
            "Adjective Type=general Degree=comparative Gender=feminine Number=dual Case=accusative");
        InsertMsd(
            "Agcfdl",
            "pridevnik vrsta=splošni stopnja=primernik spol=ženski število=dvojina sklon=mestnik",
            "Adjective Type=general Degree=comparative Gender=feminine Number=dual Case=locative");
        InsertMsd(
            "Agcfdi",
            "pridevnik vrsta=splošni stopnja=primernik spol=ženski število=dvojina sklon=orodnik",
            "Adjective Type=general Degree=comparative Gender=feminine Number=dual Case=instrumental");
        InsertMsd(
            "Agcfpn",
            "pridevnik vrsta=splošni stopnja=primernik spol=ženski število=množina sklon=imenovalnik",
            "Adjective Type=general Degree=comparative Gender=feminine Number=plural Case=nominative");
        InsertMsd(
            "Agcfpg",
            "pridevnik vrsta=splošni stopnja=primernik spol=ženski število=množina sklon=rodilnik",
            "Adjective Type=general Degree=comparative Gender=feminine Number=plural Case=genitive");
        InsertMsd(
            "Agcfpd",
            "pridevnik vrsta=splošni stopnja=primernik spol=ženski število=množina sklon=dajalnik",
            "Adjective Type=general Degree=comparative Gender=feminine Number=plural Case=dative");
        InsertMsd(
            "Agcfpa",
            "pridevnik vrsta=splošni stopnja=primernik spol=ženski število=množina sklon=tožilnik",
            "Adjective Type=general Degree=comparative Gender=feminine Number=plural Case=accusative");
        InsertMsd(
            "Agcfpl",
            "pridevnik vrsta=splošni stopnja=primernik spol=ženski število=množina sklon=mestnik",
            "Adjective Type=general Degree=comparative Gender=feminine Number=plural Case=locative");
        InsertMsd(
            "Agcfpi",
            "pridevnik vrsta=splošni stopnja=primernik spol=ženski število=množina sklon=orodnik",
            "Adjective Type=general Degree=comparative Gender=feminine Number=plural Case=instrumental");
        InsertMsd(
            "Agcnsn",
            "pridevnik vrsta=splošni stopnja=primernik spol=srednji število=ednina sklon=imenovalnik",
            "Adjective Type=general Degree=comparative Gender=neuter Number=singular Case=nominative");
        InsertMsd(
            "Agcnsg",
            "pridevnik vrsta=splošni stopnja=primernik spol=srednji število=ednina sklon=rodilnik",
            "Adjective Type=general Degree=comparative Gender=neuter Number=singular Case=genitive");
        InsertMsd(
            "Agcnsd",
            "pridevnik vrsta=splošni stopnja=primernik spol=srednji število=ednina sklon=dajalnik",
            "Adjective Type=general Degree=comparative Gender=neuter Number=singular Case=dative");
        InsertMsd(
            "Agcnsa",
            "pridevnik vrsta=splošni stopnja=primernik spol=srednji število=ednina sklon=tožilnik",
            "Adjective Type=general Degree=comparative Gender=neuter Number=singular Case=accusative");
        InsertMsd(
            "Agcnsl",
            "pridevnik vrsta=splošni stopnja=primernik spol=srednji število=ednina sklon=mestnik",
            "Adjective Type=general Degree=comparative Gender=neuter Number=singular Case=locative");
        InsertMsd(
            "Agcnsi",
            "pridevnik vrsta=splošni stopnja=primernik spol=srednji število=ednina sklon=orodnik",
            "Adjective Type=general Degree=comparative Gender=neuter Number=singular Case=instrumental");
        InsertMsd(
            "Agcndn",
            "pridevnik vrsta=splošni stopnja=primernik spol=srednji število=dvojina sklon=imenovalnik",
            "Adjective Type=general Degree=comparative Gender=neuter Number=dual Case=nominative");
        InsertMsd(
            "Agcndg",
            "pridevnik vrsta=splošni stopnja=primernik spol=srednji število=dvojina sklon=rodilnik",
            "Adjective Type=general Degree=comparative Gender=neuter Number=dual Case=genitive");
        InsertMsd(
            "Agcndd",
            "pridevnik vrsta=splošni stopnja=primernik spol=srednji število=dvojina sklon=dajalnik",
            "Adjective Type=general Degree=comparative Gender=neuter Number=dual Case=dative");
        InsertMsd(
            "Agcnda",
            "pridevnik vrsta=splošni stopnja=primernik spol=srednji število=dvojina sklon=tožilnik",
            "Adjective Type=general Degree=comparative Gender=neuter Number=dual Case=accusative");
        InsertMsd(
            "Agcndl",
            "pridevnik vrsta=splošni stopnja=primernik spol=srednji število=dvojina sklon=mestnik",
            "Adjective Type=general Degree=comparative Gender=neuter Number=dual Case=locative");
        InsertMsd(
            "Agcndi",
            "pridevnik vrsta=splošni stopnja=primernik spol=srednji število=dvojina sklon=orodnik",
            "Adjective Type=general Degree=comparative Gender=neuter Number=dual Case=instrumental");
        InsertMsd(
            "Agcnpn",
            "pridevnik vrsta=splošni stopnja=primernik spol=srednji število=množina sklon=imenovalnik",
            "Adjective Type=general Degree=comparative Gender=neuter Number=plural Case=nominative");
        InsertMsd(
            "Agcnpg",
            "pridevnik vrsta=splošni stopnja=primernik spol=srednji število=množina sklon=rodilnik",
            "Adjective Type=general Degree=comparative Gender=neuter Number=plural Case=genitive");
        InsertMsd(
            "Agcnpd",
            "pridevnik vrsta=splošni stopnja=primernik spol=srednji število=množina sklon=dajalnik",
            "Adjective Type=general Degree=comparative Gender=neuter Number=plural Case=dative");
        InsertMsd(
            "Agcnpa",
            "pridevnik vrsta=splošni stopnja=primernik spol=srednji število=množina sklon=tožilnik",
            "Adjective Type=general Degree=comparative Gender=neuter Number=plural Case=accusative");
        InsertMsd(
            "Agcnpl",
            "pridevnik vrsta=splošni stopnja=primernik spol=srednji število=množina sklon=mestnik",
            "Adjective Type=general Degree=comparative Gender=neuter Number=plural Case=locative");
        InsertMsd(
            "Agcnpi",
            "pridevnik vrsta=splošni stopnja=primernik spol=srednji število=množina sklon=orodnik",
            "Adjective Type=general Degree=comparative Gender=neuter Number=plural Case=instrumental");
        InsertMsd(
            "Agsmsny",
            "pridevnik vrsta=splošni stopnja=presežnik spol=moški število=ednina sklon=imenovalnik dolocnost=da",
            "Adjective Type=general Degree=superlative Gender=masculine Number=singular Case=nominative Definiteness=yes");
        InsertMsd(
            "Agsmsg",
            "pridevnik vrsta=splošni stopnja=presežnik spol=moški število=ednina sklon=rodilnik",
            "Adjective Type=general Degree=superlative Gender=masculine Number=singular Case=genitive");
        InsertMsd(
            "Agsmsd",
            "pridevnik vrsta=splošni stopnja=presežnik spol=moški število=ednina sklon=dajalnik",
            "Adjective Type=general Degree=superlative Gender=masculine Number=singular Case=dative");
        InsertMsd(
            "Agsmsa",
            "pridevnik vrsta=splošni stopnja=presežnik spol=moški število=ednina sklon=tožilnik",
            "Adjective Type=general Degree=superlative Gender=masculine Number=singular Case=accusative");
        InsertMsd(
            "Agsmsay",
            "pridevnik vrsta=splošni stopnja=presežnik spol=moški število=ednina sklon=tožilnik dolocnost=da",
            "Adjective Type=general Degree=superlative Gender=masculine Number=singular Case=accusative Definiteness=yes");
        InsertMsd(
            "Agsmsl",
            "pridevnik vrsta=splošni stopnja=presežnik spol=moški število=ednina sklon=mestnik",
            "Adjective Type=general Degree=superlative Gender=masculine Number=singular Case=locative");
        InsertMsd(
            "Agsmsi",
            "pridevnik vrsta=splošni stopnja=presežnik spol=moški število=ednina sklon=orodnik",
            "Adjective Type=general Degree=superlative Gender=masculine Number=singular Case=instrumental");
        InsertMsd(
            "Agsmdn",
            "pridevnik vrsta=splošni stopnja=presežnik spol=moški število=dvojina sklon=imenovalnik",
            "Adjective Type=general Degree=superlative Gender=masculine Number=dual Case=nominative");
        InsertMsd(
            "Agsmdg",
            "pridevnik vrsta=splošni stopnja=presežnik spol=moški število=dvojina sklon=rodilnik",
            "Adjective Type=general Degree=superlative Gender=masculine Number=dual Case=genitive");
        InsertMsd(
            "Agsmdd",
            "pridevnik vrsta=splošni stopnja=presežnik spol=moški število=dvojina sklon=dajalnik",
            "Adjective Type=general Degree=superlative Gender=masculine Number=dual Case=dative");
        InsertMsd(
            "Agsmda",
            "pridevnik vrsta=splošni stopnja=presežnik spol=moški število=dvojina sklon=tožilnik",
            "Adjective Type=general Degree=superlative Gender=masculine Number=dual Case=accusative");
        InsertMsd(
            "Agsmdl",
            "pridevnik vrsta=splošni stopnja=presežnik spol=moški število=dvojina sklon=mestnik",
            "Adjective Type=general Degree=superlative Gender=masculine Number=dual Case=locative");
        InsertMsd(
            "Agsmdi",
            "pridevnik vrsta=splošni stopnja=presežnik spol=moški število=dvojina sklon=orodnik",
            "Adjective Type=general Degree=superlative Gender=masculine Number=dual Case=instrumental");
        InsertMsd(
            "Agsmpn",
            "pridevnik vrsta=splošni stopnja=presežnik spol=moški število=množina sklon=imenovalnik",
            "Adjective Type=general Degree=superlative Gender=masculine Number=plural Case=nominative");
        InsertMsd(
            "Agsmpg",
            "pridevnik vrsta=splošni stopnja=presežnik spol=moški število=množina sklon=rodilnik",
            "Adjective Type=general Degree=superlative Gender=masculine Number=plural Case=genitive");
        InsertMsd(
            "Agsmpd",
            "pridevnik vrsta=splošni stopnja=presežnik spol=moški število=množina sklon=dajalnik",
            "Adjective Type=general Degree=superlative Gender=masculine Number=plural Case=dative");
        InsertMsd(
            "Agsmpa",
            "pridevnik vrsta=splošni stopnja=presežnik spol=moški število=množina sklon=tožilnik",
            "Adjective Type=general Degree=superlative Gender=masculine Number=plural Case=accusative");
        InsertMsd(
            "Agsmpl",
            "pridevnik vrsta=splošni stopnja=presežnik spol=moški število=množina sklon=mestnik",
            "Adjective Type=general Degree=superlative Gender=masculine Number=plural Case=locative");
        InsertMsd(
            "Agsmpi",
            "pridevnik vrsta=splošni stopnja=presežnik spol=moški število=množina sklon=orodnik",
            "Adjective Type=general Degree=superlative Gender=masculine Number=plural Case=instrumental");
        InsertMsd(
            "Agsfsn",
            "pridevnik vrsta=splošni stopnja=presežnik spol=ženski število=ednina sklon=imenovalnik",
            "Adjective Type=general Degree=superlative Gender=feminine Number=singular Case=nominative");
        InsertMsd(
            "Agsfsg",
            "pridevnik vrsta=splošni stopnja=presežnik spol=ženski število=ednina sklon=rodilnik",
            "Adjective Type=general Degree=superlative Gender=feminine Number=singular Case=genitive");
        InsertMsd(
            "Agsfsd",
            "pridevnik vrsta=splošni stopnja=presežnik spol=ženski število=ednina sklon=dajalnik",
            "Adjective Type=general Degree=superlative Gender=feminine Number=singular Case=dative");
        InsertMsd(
            "Agsfsa",
            "pridevnik vrsta=splošni stopnja=presežnik spol=ženski število=ednina sklon=tožilnik",
            "Adjective Type=general Degree=superlative Gender=feminine Number=singular Case=accusative");
        InsertMsd(
            "Agsfsl",
            "pridevnik vrsta=splošni stopnja=presežnik spol=ženski število=ednina sklon=mestnik",
            "Adjective Type=general Degree=superlative Gender=feminine Number=singular Case=locative");
        InsertMsd(
            "Agsfsi",
            "pridevnik vrsta=splošni stopnja=presežnik spol=ženski število=ednina sklon=orodnik",
            "Adjective Type=general Degree=superlative Gender=feminine Number=singular Case=instrumental");
        InsertMsd(
            "Agsfdn",
            "pridevnik vrsta=splošni stopnja=presežnik spol=ženski število=dvojina sklon=imenovalnik",
            "Adjective Type=general Degree=superlative Gender=feminine Number=dual Case=nominative");
        InsertMsd(
            "Agsfdg",
            "pridevnik vrsta=splošni stopnja=presežnik spol=ženski število=dvojina sklon=rodilnik",
            "Adjective Type=general Degree=superlative Gender=feminine Number=dual Case=genitive");
        InsertMsd(
            "Agsfdd",
            "pridevnik vrsta=splošni stopnja=presežnik spol=ženski število=dvojina sklon=dajalnik",
            "Adjective Type=general Degree=superlative Gender=feminine Number=dual Case=dative");
        InsertMsd(
            "Agsfda",
            "pridevnik vrsta=splošni stopnja=presežnik spol=ženski število=dvojina sklon=tožilnik",
            "Adjective Type=general Degree=superlative Gender=feminine Number=dual Case=accusative");
        InsertMsd(
            "Agsfdl",
            "pridevnik vrsta=splošni stopnja=presežnik spol=ženski število=dvojina sklon=mestnik",
            "Adjective Type=general Degree=superlative Gender=feminine Number=dual Case=locative");
        InsertMsd(
            "Agsfdi",
            "pridevnik vrsta=splošni stopnja=presežnik spol=ženski število=dvojina sklon=orodnik",
            "Adjective Type=general Degree=superlative Gender=feminine Number=dual Case=instrumental");
        InsertMsd(
            "Agsfpn",
            "pridevnik vrsta=splošni stopnja=presežnik spol=ženski število=množina sklon=imenovalnik",
            "Adjective Type=general Degree=superlative Gender=feminine Number=plural Case=nominative");
        InsertMsd(
            "Agsfpg",
            "pridevnik vrsta=splošni stopnja=presežnik spol=ženski število=množina sklon=rodilnik",
            "Adjective Type=general Degree=superlative Gender=feminine Number=plural Case=genitive");
        InsertMsd(
            "Agsfpd",
            "pridevnik vrsta=splošni stopnja=presežnik spol=ženski število=množina sklon=dajalnik",
            "Adjective Type=general Degree=superlative Gender=feminine Number=plural Case=dative");
        InsertMsd(
            "Agsfpa",
            "pridevnik vrsta=splošni stopnja=presežnik spol=ženski število=množina sklon=tožilnik",
            "Adjective Type=general Degree=superlative Gender=feminine Number=plural Case=accusative");
        InsertMsd(
            "Agsfpl",
            "pridevnik vrsta=splošni stopnja=presežnik spol=ženski število=množina sklon=mestnik",
            "Adjective Type=general Degree=superlative Gender=feminine Number=plural Case=locative");
        InsertMsd(
            "Agsfpi",
            "pridevnik vrsta=splošni stopnja=presežnik spol=ženski število=množina sklon=orodnik",
            "Adjective Type=general Degree=superlative Gender=feminine Number=plural Case=instrumental");
        InsertMsd(
            "Agsnsn",
            "pridevnik vrsta=splošni stopnja=presežnik spol=srednji število=ednina sklon=imenovalnik",
            "Adjective Type=general Degree=superlative Gender=neuter Number=singular Case=nominative");
        InsertMsd(
            "Agsnsg",
            "pridevnik vrsta=splošni stopnja=presežnik spol=srednji število=ednina sklon=rodilnik",
            "Adjective Type=general Degree=superlative Gender=neuter Number=singular Case=genitive");
        InsertMsd(
            "Agsnsd",
            "pridevnik vrsta=splošni stopnja=presežnik spol=srednji število=ednina sklon=dajalnik",
            "Adjective Type=general Degree=superlative Gender=neuter Number=singular Case=dative");
        InsertMsd(
            "Agsnsa",
            "pridevnik vrsta=splošni stopnja=presežnik spol=srednji število=ednina sklon=tožilnik",
            "Adjective Type=general Degree=superlative Gender=neuter Number=singular Case=accusative");
        InsertMsd(
            "Agsnsl",
            "pridevnik vrsta=splošni stopnja=presežnik spol=srednji število=ednina sklon=mestnik",
            "Adjective Type=general Degree=superlative Gender=neuter Number=singular Case=locative");
        InsertMsd(
            "Agsnsi",
            "pridevnik vrsta=splošni stopnja=presežnik spol=srednji število=ednina sklon=orodnik",
            "Adjective Type=general Degree=superlative Gender=neuter Number=singular Case=instrumental");
        InsertMsd(
            "Agsndn",
            "pridevnik vrsta=splošni stopnja=presežnik spol=srednji število=dvojina sklon=imenovalnik",
            "Adjective Type=general Degree=superlative Gender=neuter Number=dual Case=nominative");
        InsertMsd(
            "Agsndg",
            "pridevnik vrsta=splošni stopnja=presežnik spol=srednji število=dvojina sklon=rodilnik",
            "Adjective Type=general Degree=superlative Gender=neuter Number=dual Case=genitive");
        InsertMsd(
            "Agsndd",
            "pridevnik vrsta=splošni stopnja=presežnik spol=srednji število=dvojina sklon=dajalnik",
            "Adjective Type=general Degree=superlative Gender=neuter Number=dual Case=dative");
        InsertMsd(
            "Agsnda",
            "pridevnik vrsta=splošni stopnja=presežnik spol=srednji število=dvojina sklon=tožilnik",
            "Adjective Type=general Degree=superlative Gender=neuter Number=dual Case=accusative");
        InsertMsd(
            "Agsndl",
            "pridevnik vrsta=splošni stopnja=presežnik spol=srednji število=dvojina sklon=mestnik",
            "Adjective Type=general Degree=superlative Gender=neuter Number=dual Case=locative");
        InsertMsd(
            "Agsndi",
            "pridevnik vrsta=splošni stopnja=presežnik spol=srednji število=dvojina sklon=orodnik",
            "Adjective Type=general Degree=superlative Gender=neuter Number=dual Case=instrumental");
        InsertMsd(
            "Agsnpn",
            "pridevnik vrsta=splošni stopnja=presežnik spol=srednji število=množina sklon=imenovalnik",
            "Adjective Type=general Degree=superlative Gender=neuter Number=plural Case=nominative");
        InsertMsd(
            "Agsnpg",
            "pridevnik vrsta=splošni stopnja=presežnik spol=srednji število=množina sklon=rodilnik",
            "Adjective Type=general Degree=superlative Gender=neuter Number=plural Case=genitive");
        InsertMsd(
            "Agsnpd",
            "pridevnik vrsta=splošni stopnja=presežnik spol=srednji število=množina sklon=dajalnik",
            "Adjective Type=general Degree=superlative Gender=neuter Number=plural Case=dative");
        InsertMsd(
            "Agsnpa",
            "pridevnik vrsta=splošni stopnja=presežnik spol=srednji število=množina sklon=tožilnik",
            "Adjective Type=general Degree=superlative Gender=neuter Number=plural Case=accusative");
        InsertMsd(
            "Agsnpl",
            "pridevnik vrsta=splošni stopnja=presežnik spol=srednji število=množina sklon=mestnik",
            "Adjective Type=general Degree=superlative Gender=neuter Number=plural Case=locative");
        InsertMsd(
            "Agsnpi",
            "pridevnik vrsta=splošni stopnja=presežnik spol=srednji število=množina sklon=orodnik",
            "Adjective Type=general Degree=superlative Gender=neuter Number=plural Case=instrumental");
        InsertMsd(
            "Aspmsnn",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=moški število=ednina sklon=imenovalnik dolocnost=ne",
            "Adjective Type=possessive Degree=positive Gender=masculine Number=singular Case=nominative Definiteness=no");
        InsertMsd(
            "Aspmsg",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=moški število=ednina sklon=rodilnik",
            "Adjective Type=possessive Degree=positive Gender=masculine Number=singular Case=genitive");
        InsertMsd(
            "Aspmsd",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=moški število=ednina sklon=dajalnik",
            "Adjective Type=possessive Degree=positive Gender=masculine Number=singular Case=dative");
        InsertMsd(
            "Aspmsa",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=moški število=ednina sklon=tožilnik",
            "Adjective Type=possessive Degree=positive Gender=masculine Number=singular Case=accusative");
        InsertMsd(
            "Aspmsan",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=moški število=ednina sklon=tožilnik dolocnost=ne",
            "Adjective Type=possessive Degree=positive Gender=masculine Number=singular Case=accusative Definiteness=no");
        InsertMsd(
            "Aspmsl",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=moški število=ednina sklon=mestnik",
            "Adjective Type=possessive Degree=positive Gender=masculine Number=singular Case=locative");
        InsertMsd(
            "Aspmsi",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=moški število=ednina sklon=orodnik",
            "Adjective Type=possessive Degree=positive Gender=masculine Number=singular Case=instrumental");
        InsertMsd(
            "Aspmdn",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=moški število=dvojina sklon=imenovalnik",
            "Adjective Type=possessive Degree=positive Gender=masculine Number=dual Case=nominative");
        InsertMsd(
            "Aspmdg",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=moški število=dvojina sklon=rodilnik",
            "Adjective Type=possessive Degree=positive Gender=masculine Number=dual Case=genitive");
        InsertMsd(
            "Aspmdd",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=moški število=dvojina sklon=dajalnik",
            "Adjective Type=possessive Degree=positive Gender=masculine Number=dual Case=dative");
        InsertMsd(
            "Aspmda",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=moški število=dvojina sklon=tožilnik",
            "Adjective Type=possessive Degree=positive Gender=masculine Number=dual Case=accusative");
        InsertMsd(
            "Aspmdl",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=moški število=dvojina sklon=mestnik",
            "Adjective Type=possessive Degree=positive Gender=masculine Number=dual Case=locative");
        InsertMsd(
            "Aspmdi",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=moški število=dvojina sklon=orodnik",
            "Adjective Type=possessive Degree=positive Gender=masculine Number=dual Case=instrumental");
        InsertMsd(
            "Aspmpn",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=moški število=množina sklon=imenovalnik",
            "Adjective Type=possessive Degree=positive Gender=masculine Number=plural Case=nominative");
        InsertMsd(
            "Aspmpg",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=moški število=množina sklon=rodilnik",
            "Adjective Type=possessive Degree=positive Gender=masculine Number=plural Case=genitive");
        InsertMsd(
            "Aspmpd",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=moški število=množina sklon=dajalnik",
            "Adjective Type=possessive Degree=positive Gender=masculine Number=plural Case=dative");
        InsertMsd(
            "Aspmpa",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=moški število=množina sklon=tožilnik",
            "Adjective Type=possessive Degree=positive Gender=masculine Number=plural Case=accusative");
        InsertMsd(
            "Aspmpl",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=moški število=množina sklon=mestnik",
            "Adjective Type=possessive Degree=positive Gender=masculine Number=plural Case=locative");
        InsertMsd(
            "Aspmpi",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=moški število=množina sklon=orodnik",
            "Adjective Type=possessive Degree=positive Gender=masculine Number=plural Case=instrumental");
        InsertMsd(
            "Aspfsn",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=ženski število=ednina sklon=imenovalnik",
            "Adjective Type=possessive Degree=positive Gender=feminine Number=singular Case=nominative");
        InsertMsd(
            "Aspfsg",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=ženski število=ednina sklon=rodilnik",
            "Adjective Type=possessive Degree=positive Gender=feminine Number=singular Case=genitive");
        InsertMsd(
            "Aspfsd",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=ženski število=ednina sklon=dajalnik",
            "Adjective Type=possessive Degree=positive Gender=feminine Number=singular Case=dative");
        InsertMsd(
            "Aspfsa",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=ženski število=ednina sklon=tožilnik",
            "Adjective Type=possessive Degree=positive Gender=feminine Number=singular Case=accusative");
        InsertMsd(
            "Aspfsl",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=ženski število=ednina sklon=mestnik",
            "Adjective Type=possessive Degree=positive Gender=feminine Number=singular Case=locative");
        InsertMsd(
            "Aspfsi",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=ženski število=ednina sklon=orodnik",
            "Adjective Type=possessive Degree=positive Gender=feminine Number=singular Case=instrumental");
        InsertMsd(
            "Aspfdn",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=ženski število=dvojina sklon=imenovalnik",
            "Adjective Type=possessive Degree=positive Gender=feminine Number=dual Case=nominative");
        InsertMsd(
            "Aspfdg",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=ženski število=dvojina sklon=rodilnik",
            "Adjective Type=possessive Degree=positive Gender=feminine Number=dual Case=genitive");
        InsertMsd(
            "Aspfdd",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=ženski število=dvojina sklon=dajalnik",
            "Adjective Type=possessive Degree=positive Gender=feminine Number=dual Case=dative");
        InsertMsd(
            "Aspfda",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=ženski število=dvojina sklon=tožilnik",
            "Adjective Type=possessive Degree=positive Gender=feminine Number=dual Case=accusative");
        InsertMsd(
            "Aspfdl",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=ženski število=dvojina sklon=mestnik",
            "Adjective Type=possessive Degree=positive Gender=feminine Number=dual Case=locative");
        InsertMsd(
            "Aspfdi",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=ženski število=dvojina sklon=orodnik",
            "Adjective Type=possessive Degree=positive Gender=feminine Number=dual Case=instrumental");
        InsertMsd(
            "Aspfpn",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=ženski število=množina sklon=imenovalnik",
            "Adjective Type=possessive Degree=positive Gender=feminine Number=plural Case=nominative");
        InsertMsd(
            "Aspfpg",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=ženski število=množina sklon=rodilnik",
            "Adjective Type=possessive Degree=positive Gender=feminine Number=plural Case=genitive");
        InsertMsd(
            "Aspfpd",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=ženski število=množina sklon=dajalnik",
            "Adjective Type=possessive Degree=positive Gender=feminine Number=plural Case=dative");
        InsertMsd(
            "Aspfpa",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=ženski število=množina sklon=tožilnik",
            "Adjective Type=possessive Degree=positive Gender=feminine Number=plural Case=accusative");
        InsertMsd(
            "Aspfpl",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=ženski število=množina sklon=mestnik",
            "Adjective Type=possessive Degree=positive Gender=feminine Number=plural Case=locative");
        InsertMsd(
            "Aspfpi",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=ženski število=množina sklon=orodnik",
            "Adjective Type=possessive Degree=positive Gender=feminine Number=plural Case=instrumental");
        InsertMsd(
            "Aspnsn",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=srednji število=ednina sklon=imenovalnik",
            "Adjective Type=possessive Degree=positive Gender=neuter Number=singular Case=nominative");
        InsertMsd(
            "Aspnsg",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=srednji število=ednina sklon=rodilnik",
            "Adjective Type=possessive Degree=positive Gender=neuter Number=singular Case=genitive");
        InsertMsd(
            "Aspnsd",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=srednji število=ednina sklon=dajalnik",
            "Adjective Type=possessive Degree=positive Gender=neuter Number=singular Case=dative");
        InsertMsd(
            "Aspnsa",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=srednji število=ednina sklon=tožilnik",
            "Adjective Type=possessive Degree=positive Gender=neuter Number=singular Case=accusative");
        InsertMsd(
            "Aspnsl",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=srednji število=ednina sklon=mestnik",
            "Adjective Type=possessive Degree=positive Gender=neuter Number=singular Case=locative");
        InsertMsd(
            "Aspnsi",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=srednji število=ednina sklon=orodnik",
            "Adjective Type=possessive Degree=positive Gender=neuter Number=singular Case=instrumental");
        InsertMsd(
            "Aspndn",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=srednji število=dvojina sklon=imenovalnik",
            "Adjective Type=possessive Degree=positive Gender=neuter Number=dual Case=nominative");
        InsertMsd(
            "Aspndg",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=srednji število=dvojina sklon=rodilnik",
            "Adjective Type=possessive Degree=positive Gender=neuter Number=dual Case=genitive");
        InsertMsd(
            "Aspndd",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=srednji število=dvojina sklon=dajalnik",
            "Adjective Type=possessive Degree=positive Gender=neuter Number=dual Case=dative");
        InsertMsd(
            "Aspnda",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=srednji število=dvojina sklon=tožilnik",
            "Adjective Type=possessive Degree=positive Gender=neuter Number=dual Case=accusative");
        InsertMsd(
            "Aspndl",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=srednji število=dvojina sklon=mestnik",
            "Adjective Type=possessive Degree=positive Gender=neuter Number=dual Case=locative");
        InsertMsd(
            "Aspndi",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=srednji število=dvojina sklon=orodnik",
            "Adjective Type=possessive Degree=positive Gender=neuter Number=dual Case=instrumental");
        InsertMsd(
            "Aspnpn",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=srednji število=množina sklon=imenovalnik",
            "Adjective Type=possessive Degree=positive Gender=neuter Number=plural Case=nominative");
        InsertMsd(
            "Aspnpg",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=srednji število=množina sklon=rodilnik",
            "Adjective Type=possessive Degree=positive Gender=neuter Number=plural Case=genitive");
        InsertMsd(
            "Aspnpd",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=srednji število=množina sklon=dajalnik",
            "Adjective Type=possessive Degree=positive Gender=neuter Number=plural Case=dative");
        InsertMsd(
            "Aspnpa",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=srednji število=množina sklon=tožilnik",
            "Adjective Type=possessive Degree=positive Gender=neuter Number=plural Case=accusative");
        InsertMsd(
            "Aspnpl",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=srednji število=množina sklon=mestnik",
            "Adjective Type=possessive Degree=positive Gender=neuter Number=plural Case=locative");
        InsertMsd(
            "Aspnpi",
            "pridevnik vrsta=svojilni stopnja=nedoloceno spol=srednji število=množina sklon=orodnik",
            "Adjective Type=possessive Degree=positive Gender=neuter Number=plural Case=instrumental");
        InsertMsd(
            "Appmsnn",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=moški število=ednina sklon=imenovalnik dolocnost=ne",
            "Adjective Type=participle Degree=positive Gender=masculine Number=singular Case=nominative Definiteness=no");
        InsertMsd(
            "Appmsny",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=moški število=ednina sklon=imenovalnik dolocnost=da",
            "Adjective Type=participle Degree=positive Gender=masculine Number=singular Case=nominative Definiteness=yes");
        InsertMsd(
            "Appmsg",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=moški število=ednina sklon=rodilnik",
            "Adjective Type=participle Degree=positive Gender=masculine Number=singular Case=genitive");
        InsertMsd(
            "Appmsd",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=moški število=ednina sklon=dajalnik",
            "Adjective Type=participle Degree=positive Gender=masculine Number=singular Case=dative");
        InsertMsd(
            "Appmsa",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=moški število=ednina sklon=tožilnik",
            "Adjective Type=participle Degree=positive Gender=masculine Number=singular Case=accusative");
        InsertMsd(
            "Appmsan",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=moški število=ednina sklon=tožilnik dolocnost=ne",
            "Adjective Type=participle Degree=positive Gender=masculine Number=singular Case=accusative Definiteness=no");
        InsertMsd(
            "Appmsay",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=moški število=ednina sklon=tožilnik dolocnost=da",
            "Adjective Type=participle Degree=positive Gender=masculine Number=singular Case=accusative Definiteness=yes");
        InsertMsd(
            "Appmsl",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=moški število=ednina sklon=mestnik",
            "Adjective Type=participle Degree=positive Gender=masculine Number=singular Case=locative");
        InsertMsd(
            "Appmsi",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=moški število=ednina sklon=orodnik",
            "Adjective Type=participle Degree=positive Gender=masculine Number=singular Case=instrumental");
        InsertMsd(
            "Appmdn",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=moški število=dvojina sklon=imenovalnik",
            "Adjective Type=participle Degree=positive Gender=masculine Number=dual Case=nominative");
        InsertMsd(
            "Appmdg",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=moški število=dvojina sklon=rodilnik",
            "Adjective Type=participle Degree=positive Gender=masculine Number=dual Case=genitive");
        InsertMsd(
            "Appmdd",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=moški število=dvojina sklon=dajalnik",
            "Adjective Type=participle Degree=positive Gender=masculine Number=dual Case=dative");
        InsertMsd(
            "Appmda",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=moški število=dvojina sklon=tožilnik",
            "Adjective Type=participle Degree=positive Gender=masculine Number=dual Case=accusative");
        InsertMsd(
            "Appmdl",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=moški število=dvojina sklon=mestnik",
            "Adjective Type=participle Degree=positive Gender=masculine Number=dual Case=locative");
        InsertMsd(
            "Appmdi",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=moški število=dvojina sklon=orodnik",
            "Adjective Type=participle Degree=positive Gender=masculine Number=dual Case=instrumental");
        InsertMsd(
            "Appmpn",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=moški število=množina sklon=imenovalnik",
            "Adjective Type=participle Degree=positive Gender=masculine Number=plural Case=nominative");
        InsertMsd(
            "Appmpg",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=moški število=množina sklon=rodilnik",
            "Adjective Type=participle Degree=positive Gender=masculine Number=plural Case=genitive");
        InsertMsd(
            "Appmpd",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=moški število=množina sklon=dajalnik",
            "Adjective Type=participle Degree=positive Gender=masculine Number=plural Case=dative");
        InsertMsd(
            "Appmpa",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=moški število=množina sklon=tožilnik",
            "Adjective Type=participle Degree=positive Gender=masculine Number=plural Case=accusative");
        InsertMsd(
            "Appmpl",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=moški število=množina sklon=mestnik",
            "Adjective Type=participle Degree=positive Gender=masculine Number=plural Case=locative");
        InsertMsd(
            "Appmpi",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=moški število=množina sklon=orodnik",
            "Adjective Type=participle Degree=positive Gender=masculine Number=plural Case=instrumental");
        InsertMsd(
            "Appfsn",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=ženski število=ednina sklon=imenovalnik",
            "Adjective Type=participle Degree=positive Gender=feminine Number=singular Case=nominative");
        InsertMsd(
            "Appfsg",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=ženski število=ednina sklon=rodilnik",
            "Adjective Type=participle Degree=positive Gender=feminine Number=singular Case=genitive");
        InsertMsd(
            "Appfsd",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=ženski število=ednina sklon=dajalnik",
            "Adjective Type=participle Degree=positive Gender=feminine Number=singular Case=dative");
        InsertMsd(
            "Appfsa",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=ženski število=ednina sklon=tožilnik",
            "Adjective Type=participle Degree=positive Gender=feminine Number=singular Case=accusative");
        InsertMsd(
            "Appfsl",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=ženski število=ednina sklon=mestnik",
            "Adjective Type=participle Degree=positive Gender=feminine Number=singular Case=locative");
        InsertMsd(
            "Appfsi",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=ženski število=ednina sklon=orodnik",
            "Adjective Type=participle Degree=positive Gender=feminine Number=singular Case=instrumental");
        InsertMsd(
            "Appfdn",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=ženski število=dvojina sklon=imenovalnik",
            "Adjective Type=participle Degree=positive Gender=feminine Number=dual Case=nominative");
        InsertMsd(
            "Appfdg",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=ženski število=dvojina sklon=rodilnik",
            "Adjective Type=participle Degree=positive Gender=feminine Number=dual Case=genitive");
        InsertMsd(
            "Appfdd",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=ženski število=dvojina sklon=dajalnik",
            "Adjective Type=participle Degree=positive Gender=feminine Number=dual Case=dative");
        InsertMsd(
            "Appfda",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=ženski število=dvojina sklon=tožilnik",
            "Adjective Type=participle Degree=positive Gender=feminine Number=dual Case=accusative");
        InsertMsd(
            "Appfdl",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=ženski število=dvojina sklon=mestnik",
            "Adjective Type=participle Degree=positive Gender=feminine Number=dual Case=locative");
        InsertMsd(
            "Appfdi",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=ženski število=dvojina sklon=orodnik",
            "Adjective Type=participle Degree=positive Gender=feminine Number=dual Case=instrumental");
        InsertMsd(
            "Appfpn",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=ženski število=množina sklon=imenovalnik",
            "Adjective Type=participle Degree=positive Gender=feminine Number=plural Case=nominative");
        InsertMsd(
            "Appfpg",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=ženski število=množina sklon=rodilnik",
            "Adjective Type=participle Degree=positive Gender=feminine Number=plural Case=genitive");
        InsertMsd(
            "Appfpd",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=ženski število=množina sklon=dajalnik",
            "Adjective Type=participle Degree=positive Gender=feminine Number=plural Case=dative");
        InsertMsd(
            "Appfpa",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=ženski število=množina sklon=tožilnik",
            "Adjective Type=participle Degree=positive Gender=feminine Number=plural Case=accusative");
        InsertMsd(
            "Appfpl",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=ženski število=množina sklon=mestnik",
            "Adjective Type=participle Degree=positive Gender=feminine Number=plural Case=locative");
        InsertMsd(
            "Appfpi",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=ženski število=množina sklon=orodnik",
            "Adjective Type=participle Degree=positive Gender=feminine Number=plural Case=instrumental");
        InsertMsd(
            "Appnsn",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=srednji število=ednina sklon=imenovalnik",
            "Adjective Type=participle Degree=positive Gender=neuter Number=singular Case=nominative");
        InsertMsd(
            "Appnsg",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=srednji število=ednina sklon=rodilnik",
            "Adjective Type=participle Degree=positive Gender=neuter Number=singular Case=genitive");
        InsertMsd(
            "Appnsd",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=srednji število=ednina sklon=dajalnik",
            "Adjective Type=participle Degree=positive Gender=neuter Number=singular Case=dative");
        InsertMsd(
            "Appnsa",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=srednji število=ednina sklon=tožilnik",
            "Adjective Type=participle Degree=positive Gender=neuter Number=singular Case=accusative");
        InsertMsd(
            "Appnsl",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=srednji število=ednina sklon=mestnik",
            "Adjective Type=participle Degree=positive Gender=neuter Number=singular Case=locative");
        InsertMsd(
            "Appnsi",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=srednji število=ednina sklon=orodnik",
            "Adjective Type=participle Degree=positive Gender=neuter Number=singular Case=instrumental");
        InsertMsd(
            "Appndn",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=srednji število=dvojina sklon=imenovalnik",
            "Adjective Type=participle Degree=positive Gender=neuter Number=dual Case=nominative");
        InsertMsd(
            "Appndg",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=srednji število=dvojina sklon=rodilnik",
            "Adjective Type=participle Degree=positive Gender=neuter Number=dual Case=genitive");
        InsertMsd(
            "Appndd",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=srednji število=dvojina sklon=dajalnik",
            "Adjective Type=participle Degree=positive Gender=neuter Number=dual Case=dative");
        InsertMsd(
            "Appnda",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=srednji število=dvojina sklon=tožilnik",
            "Adjective Type=participle Degree=positive Gender=neuter Number=dual Case=accusative");
        InsertMsd(
            "Appndl",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=srednji število=dvojina sklon=mestnik",
            "Adjective Type=participle Degree=positive Gender=neuter Number=dual Case=locative");
        InsertMsd(
            "Appndi",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=srednji število=dvojina sklon=orodnik",
            "Adjective Type=participle Degree=positive Gender=neuter Number=dual Case=instrumental");
        InsertMsd(
            "Appnpn",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=srednji število=množina sklon=imenovalnik",
            "Adjective Type=participle Degree=positive Gender=neuter Number=plural Case=nominative");
        InsertMsd(
            "Appnpg",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=srednji število=množina sklon=rodilnik",
            "Adjective Type=participle Degree=positive Gender=neuter Number=plural Case=genitive");
        InsertMsd(
            "Appnpd",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=srednji število=množina sklon=dajalnik",
            "Adjective Type=participle Degree=positive Gender=neuter Number=plural Case=dative");
        InsertMsd(
            "Appnpa",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=srednji število=množina sklon=tožilnik",
            "Adjective Type=participle Degree=positive Gender=neuter Number=plural Case=accusative");
        InsertMsd(
            "Appnpl",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=srednji število=množina sklon=mestnik",
            "Adjective Type=participle Degree=positive Gender=neuter Number=plural Case=locative");
        InsertMsd(
            "Appnpi",
            "pridevnik vrsta=deležniški stopnja=nedoloceno spol=srednji število=množina sklon=orodnik",
            "Adjective Type=participle Degree=positive Gender=neuter Number=plural Case=instrumental");
        InsertMsd("Rgp", "prislov vrsta=splošni stopnja=nedoloceno", "Adverb Type=general Degree=positive");
        InsertMsd("Rgc", "prislov vrsta=splošni stopnja=primernik", "Adverb Type=general Degree=comparative");
        InsertMsd("Rgs", "prislov vrsta=splošni stopnja=presežnik", "Adverb Type=general Degree=superlative");
        InsertMsd("Rr", "prislov vrsta=deležje", "Adverb Type=participle");
        InsertMsd(
            "Pp1-sn",
            "zaimek vrsta=osebni oseba=prva število=ednina sklon=imenovalnik",
            "Pronoun Type=personal Person=first Number=singular Case=nominative");
        InsertMsd("Pp1-sg", "zaimek vrsta=osebni oseba=prva število=ednina sklon=rodilnik", "Pronoun Type=personal Person=first Number=singular Case=genitive");
        InsertMsd(
            "Pp1-sg--y",
            "zaimek vrsta=osebni oseba=prva število=ednina sklon=rodilnik naslonskost=kliticna",
            "Pronoun Type=personal Person=first Number=singular Case=genitive Clitic=yes");
        InsertMsd("Pp1-sd", "zaimek vrsta=osebni oseba=prva število=ednina sklon=dajalnik", "Pronoun Type=personal Person=first Number=singular Case=dative");
        InsertMsd(
            "Pp1-sd--y",
            "zaimek vrsta=osebni oseba=prva število=ednina sklon=dajalnik naslonskost=kliticna",
            "Pronoun Type=personal Person=first Number=singular Case=dative Clitic=yes");
        InsertMsd(
            "Pp1-sa",
            "zaimek vrsta=osebni oseba=prva število=ednina sklon=tožilnik",
            "Pronoun Type=personal Person=first Number=singular Case=accusative");
        InsertMsd(
            "Pp1-sa--y",
            "zaimek vrsta=osebni oseba=prva število=ednina sklon=tožilnik naslonskost=kliticna",
            "Pronoun Type=personal Person=first Number=singular Case=accusative Clitic=yes");
        InsertMsd(
            "Pp1-sa--b",
            "zaimek vrsta=osebni oseba=prva število=ednina sklon=tožilnik naslonskost=navezna",
            "Pronoun Type=personal Person=first Number=singular Case=accusative Clitic=bound");
        InsertMsd("Pp1-sl", "zaimek vrsta=osebni oseba=prva število=ednina sklon=mestnik", "Pronoun Type=personal Person=first Number=singular Case=locative");
        InsertMsd(
            "Pp1-si",
            "zaimek vrsta=osebni oseba=prva število=ednina sklon=orodnik",
            "Pronoun Type=personal Person=first Number=singular Case=instrumental");
        InsertMsd("Pp1-dg", "zaimek vrsta=osebni oseba=prva število=dvojina sklon=rodilnik", "Pronoun Type=personal Person=first Number=dual Case=genitive");
        InsertMsd("Pp1-dd", "zaimek vrsta=osebni oseba=prva število=dvojina sklon=dajalnik", "Pronoun Type=personal Person=first Number=dual Case=dative");
        InsertMsd("Pp1-da", "zaimek vrsta=osebni oseba=prva število=dvojina sklon=tožilnik", "Pronoun Type=personal Person=first Number=dual Case=accusative");
        InsertMsd("Pp1-dl", "zaimek vrsta=osebni oseba=prva število=dvojina sklon=mestnik", "Pronoun Type=personal Person=first Number=dual Case=locative");
        InsertMsd("Pp1-di", "zaimek vrsta=osebni oseba=prva število=dvojina sklon=orodnik", "Pronoun Type=personal Person=first Number=dual Case=instrumental");
        InsertMsd("Pp1-pg", "zaimek vrsta=osebni oseba=prva število=množina sklon=rodilnik", "Pronoun Type=personal Person=first Number=plural Case=genitive");
        InsertMsd("Pp1-pd", "zaimek vrsta=osebni oseba=prva število=množina sklon=dajalnik", "Pronoun Type=personal Person=first Number=plural Case=dative");
        InsertMsd(
            "Pp1-pa",
            "zaimek vrsta=osebni oseba=prva število=množina sklon=tožilnik",
            "Pronoun Type=personal Person=first Number=plural Case=accusative");
        InsertMsd("Pp1-pl", "zaimek vrsta=osebni oseba=prva število=množina sklon=mestnik", "Pronoun Type=personal Person=first Number=plural Case=locative");
        InsertMsd(
            "Pp1-pi",
            "zaimek vrsta=osebni oseba=prva število=množina sklon=orodnik",
            "Pronoun Type=personal Person=first Number=plural Case=instrumental");
        InsertMsd(
            "Pp1mdn",
            "zaimek vrsta=osebni oseba=prva spol=moški število=dvojina sklon=imenovalnik",
            "Pronoun Type=personal Person=first Gender=masculine Number=dual Case=nominative");
        InsertMsd(
            "Pp1mpn",
            "zaimek vrsta=osebni oseba=prva spol=moški število=množina sklon=imenovalnik",
            "Pronoun Type=personal Person=first Gender=masculine Number=plural Case=nominative");
        InsertMsd(
            "Pp1fdn",
            "zaimek vrsta=osebni oseba=prva spol=ženski število=dvojina sklon=imenovalnik",
            "Pronoun Type=personal Person=first Gender=feminine Number=dual Case=nominative");
        InsertMsd(
            "Pp1fpn",
            "zaimek vrsta=osebni oseba=prva spol=ženski število=množina sklon=imenovalnik",
            "Pronoun Type=personal Person=first Gender=feminine Number=plural Case=nominative");
        InsertMsd(
            "Pp2-sn",
            "zaimek vrsta=osebni oseba=druga število=ednina sklon=imenovalnik",
            "Pronoun Type=personal Person=second Number=singular Case=nominative");
        InsertMsd(
            "Pp2-sg",
            "zaimek vrsta=osebni oseba=druga število=ednina sklon=rodilnik",
            "Pronoun Type=personal Person=second Number=singular Case=genitive");
        InsertMsd(
            "Pp2-sg--y",
            "zaimek vrsta=osebni oseba=druga število=ednina sklon=rodilnik naslonskost=kliticna",
            "Pronoun Type=personal Person=second Number=singular Case=genitive Clitic=yes");
        InsertMsd("Pp2-sd", "zaimek vrsta=osebni oseba=druga število=ednina sklon=dajalnik", "Pronoun Type=personal Person=second Number=singular Case=dative");
        InsertMsd(
            "Pp2-sd--y",
            "zaimek vrsta=osebni oseba=druga število=ednina sklon=dajalnik naslonskost=kliticna",
            "Pronoun Type=personal Person=second Number=singular Case=dative Clitic=yes");
        InsertMsd(
            "Pp2-sa",
            "zaimek vrsta=osebni oseba=druga število=ednina sklon=tožilnik",
            "Pronoun Type=personal Person=second Number=singular Case=accusative");
        InsertMsd(
            "Pp2-sa--y",
            "zaimek vrsta=osebni oseba=druga število=ednina sklon=tožilnik naslonskost=kliticna",
            "Pronoun Type=personal Person=second Number=singular Case=accusative Clitic=yes");
        InsertMsd(
            "Pp2-sa--b",
            "zaimek vrsta=osebni oseba=druga število=ednina sklon=tožilnik naslonskost=navezna",
            "Pronoun Type=personal Person=second Number=singular Case=accusative Clitic=bound");
        InsertMsd(
            "Pp2-sl",
            "zaimek vrsta=osebni oseba=druga število=ednina sklon=mestnik",
            "Pronoun Type=personal Person=second Number=singular Case=locative");
        InsertMsd(
            "Pp2-si",
            "zaimek vrsta=osebni oseba=druga število=ednina sklon=orodnik",
            "Pronoun Type=personal Person=second Number=singular Case=instrumental");
        InsertMsd("Pp2-dg", "zaimek vrsta=osebni oseba=druga število=dvojina sklon=rodilnik", "Pronoun Type=personal Person=second Number=dual Case=genitive");
        InsertMsd("Pp2-dd", "zaimek vrsta=osebni oseba=druga število=dvojina sklon=dajalnik", "Pronoun Type=personal Person=second Number=dual Case=dative");
        InsertMsd(
            "Pp2-da",
            "zaimek vrsta=osebni oseba=druga število=dvojina sklon=tožilnik",
            "Pronoun Type=personal Person=second Number=dual Case=accusative");
        InsertMsd("Pp2-dl", "zaimek vrsta=osebni oseba=druga število=dvojina sklon=mestnik", "Pronoun Type=personal Person=second Number=dual Case=locative");
        InsertMsd(
            "Pp2-di",
            "zaimek vrsta=osebni oseba=druga število=dvojina sklon=orodnik",
            "Pronoun Type=personal Person=second Number=dual Case=instrumental");
        InsertMsd(
            "Pp2-pg",
            "zaimek vrsta=osebni oseba=druga število=množina sklon=rodilnik",
            "Pronoun Type=personal Person=second Number=plural Case=genitive");
        InsertMsd("Pp2-pd", "zaimek vrsta=osebni oseba=druga število=množina sklon=dajalnik", "Pronoun Type=personal Person=second Number=plural Case=dative");
        InsertMsd(
            "Pp2-pa",
            "zaimek vrsta=osebni oseba=druga število=množina sklon=tožilnik",
            "Pronoun Type=personal Person=second Number=plural Case=accusative");
        InsertMsd("Pp2-pl", "zaimek vrsta=osebni oseba=druga število=množina sklon=mestnik", "Pronoun Type=personal Person=second Number=plural Case=locative");
        InsertMsd(
            "Pp2-pi",
            "zaimek vrsta=osebni oseba=druga število=množina sklon=orodnik",
            "Pronoun Type=personal Person=second Number=plural Case=instrumental");
        InsertMsd(
            "Pp2mdn",
            "zaimek vrsta=osebni oseba=druga spol=moški število=dvojina sklon=imenovalnik",
            "Pronoun Type=personal Person=second Gender=masculine Number=dual Case=nominative");
        InsertMsd(
            "Pp2mpn",
            "zaimek vrsta=osebni oseba=druga spol=moški število=množina sklon=imenovalnik",
            "Pronoun Type=personal Person=second Gender=masculine Number=plural Case=nominative");
        InsertMsd(
            "Pp2fdn",
            "zaimek vrsta=osebni oseba=druga spol=ženski število=dvojina sklon=imenovalnik",
            "Pronoun Type=personal Person=second Gender=feminine Number=dual Case=nominative");
        InsertMsd(
            "Pp2fpn",
            "zaimek vrsta=osebni oseba=druga spol=ženski število=množina sklon=imenovalnik",
            "Pronoun Type=personal Person=second Gender=feminine Number=plural Case=nominative");
        InsertMsd(
            "Pp2ndn",
            "zaimek vrsta=osebni oseba=druga spol=srednji število=dvojina sklon=imenovalnik",
            "Pronoun Type=personal Person=second Gender=neuter Number=dual Case=nominative");
        InsertMsd(
            "Pp2npn",
            "zaimek vrsta=osebni oseba=druga spol=srednji število=množina sklon=imenovalnik",
            "Pronoun Type=personal Person=second Gender=neuter Number=plural Case=nominative");
        InsertMsd(
            "Pp3msn",
            "zaimek vrsta=osebni oseba=tretja spol=moški število=ednina sklon=imenovalnik",
            "Pronoun Type=personal Person=third Gender=masculine Number=singular Case=nominative");
        InsertMsd(
            "Pp3msg",
            "zaimek vrsta=osebni oseba=tretja spol=moški število=ednina sklon=rodilnik",
            "Pronoun Type=personal Person=third Gender=masculine Number=singular Case=genitive");
        InsertMsd(
            "Pp3msg--y",
            "zaimek vrsta=osebni oseba=tretja spol=moški število=ednina sklon=rodilnik naslonskost=kliticna",
            "Pronoun Type=personal Person=third Gender=masculine Number=singular Case=genitive Clitic=yes");
        InsertMsd(
            "Pp3msd",
            "zaimek vrsta=osebni oseba=tretja spol=moški število=ednina sklon=dajalnik",
            "Pronoun Type=personal Person=third Gender=masculine Number=singular Case=dative");
        InsertMsd(
            "Pp3msd--y",
            "zaimek vrsta=osebni oseba=tretja spol=moški število=ednina sklon=dajalnik naslonskost=kliticna",
            "Pronoun Type=personal Person=third Gender=masculine Number=singular Case=dative Clitic=yes");
        InsertMsd(
            "Pp3msa",
            "zaimek vrsta=osebni oseba=tretja spol=moški število=ednina sklon=tožilnik",
            "Pronoun Type=personal Person=third Gender=masculine Number=singular Case=accusative");
        InsertMsd(
            "Pp3msa--y",
            "zaimek vrsta=osebni oseba=tretja spol=moški število=ednina sklon=tožilnik naslonskost=kliticna",
            "Pronoun Type=personal Person=third Gender=masculine Number=singular Case=accusative Clitic=yes");
        InsertMsd(
            "Pp3msa--b",
            "zaimek vrsta=osebni oseba=tretja spol=moški število=ednina sklon=tožilnik naslonskost=navezna",
            "Pronoun Type=personal Person=third Gender=masculine Number=singular Case=accusative Clitic=bound");
        InsertMsd(
            "Pp3msl",
            "zaimek vrsta=osebni oseba=tretja spol=moški število=ednina sklon=mestnik",
            "Pronoun Type=personal Person=third Gender=masculine Number=singular Case=locative");
        InsertMsd(
            "Pp3msi",
            "zaimek vrsta=osebni oseba=tretja spol=moški število=ednina sklon=orodnik",
            "Pronoun Type=personal Person=third Gender=masculine Number=singular Case=instrumental");
        InsertMsd(
            "Pp3mdn",
            "zaimek vrsta=osebni oseba=tretja spol=moški število=dvojina sklon=imenovalnik",
            "Pronoun Type=personal Person=third Gender=masculine Number=dual Case=nominative");
        InsertMsd(
            "Pp3mdg",
            "zaimek vrsta=osebni oseba=tretja spol=moški število=dvojina sklon=rodilnik",
            "Pronoun Type=personal Person=third Gender=masculine Number=dual Case=genitive");
        InsertMsd(
            "Pp3mdg--y",
            "zaimek vrsta=osebni oseba=tretja spol=moški število=dvojina sklon=rodilnik naslonskost=kliticna",
            "Pronoun Type=personal Person=third Gender=masculine Number=dual Case=genitive Clitic=yes");
        InsertMsd(
            "Pp3mdd",
            "zaimek vrsta=osebni oseba=tretja spol=moški število=dvojina sklon=dajalnik",
            "Pronoun Type=personal Person=third Gender=masculine Number=dual Case=dative");
        InsertMsd(
            "Pp3mdd--y",
            "zaimek vrsta=osebni oseba=tretja spol=moški število=dvojina sklon=dajalnik naslonskost=kliticna",
            "Pronoun Type=personal Person=third Gender=masculine Number=dual Case=dative Clitic=yes");
        InsertMsd(
            "Pp3mda",
            "zaimek vrsta=osebni oseba=tretja spol=moški število=dvojina sklon=tožilnik",
            "Pronoun Type=personal Person=third Gender=masculine Number=dual Case=accusative");
        InsertMsd(
            "Pp3mda--y",
            "zaimek vrsta=osebni oseba=tretja spol=moški število=dvojina sklon=tožilnik naslonskost=kliticna",
            "Pronoun Type=personal Person=third Gender=masculine Number=dual Case=accusative Clitic=yes");
        InsertMsd(
            "Pp3mda--b",
            "zaimek vrsta=osebni oseba=tretja spol=moški število=dvojina sklon=tožilnik naslonskost=navezna",
            "Pronoun Type=personal Person=third Gender=masculine Number=dual Case=accusative Clitic=bound");
        InsertMsd(
            "Pp3mdl",
            "zaimek vrsta=osebni oseba=tretja spol=moški število=dvojina sklon=mestnik",
            "Pronoun Type=personal Person=third Gender=masculine Number=dual Case=locative");
        InsertMsd(
            "Pp3mdi",
            "zaimek vrsta=osebni oseba=tretja spol=moški število=dvojina sklon=orodnik",
            "Pronoun Type=personal Person=third Gender=masculine Number=dual Case=instrumental");
        InsertMsd(
            "Pp3mpn",
            "zaimek vrsta=osebni oseba=tretja spol=moški število=množina sklon=imenovalnik",
            "Pronoun Type=personal Person=third Gender=masculine Number=plural Case=nominative");
        InsertMsd(
            "Pp3mpg",
            "zaimek vrsta=osebni oseba=tretja spol=moški število=množina sklon=rodilnik",
            "Pronoun Type=personal Person=third Gender=masculine Number=plural Case=genitive");
        InsertMsd(
            "Pp3mpg--y",
            "zaimek vrsta=osebni oseba=tretja spol=moški število=množina sklon=rodilnik naslonskost=kliticna",
            "Pronoun Type=personal Person=third Gender=masculine Number=plural Case=genitive Clitic=yes");
        InsertMsd(
            "Pp3mpd",
            "zaimek vrsta=osebni oseba=tretja spol=moški število=množina sklon=dajalnik",
            "Pronoun Type=personal Person=third Gender=masculine Number=plural Case=dative");
        InsertMsd(
            "Pp3mpd--y",
            "zaimek vrsta=osebni oseba=tretja spol=moški število=množina sklon=dajalnik naslonskost=kliticna",
            "Pronoun Type=personal Person=third Gender=masculine Number=plural Case=dative Clitic=yes");
        InsertMsd(
            "Pp3mpa",
            "zaimek vrsta=osebni oseba=tretja spol=moški število=množina sklon=tožilnik",
            "Pronoun Type=personal Person=third Gender=masculine Number=plural Case=accusative");
        InsertMsd(
            "Pp3mpa--y",
            "zaimek vrsta=osebni oseba=tretja spol=moški število=množina sklon=tožilnik naslonskost=kliticna",
            "Pronoun Type=personal Person=third Gender=masculine Number=plural Case=accusative Clitic=yes");
        InsertMsd(
            "Pp3mpa--b",
            "zaimek vrsta=osebni oseba=tretja spol=moški število=množina sklon=tožilnik naslonskost=navezna",
            "Pronoun Type=personal Person=third Gender=masculine Number=plural Case=accusative Clitic=bound");
        InsertMsd(
            "Pp3mpl",
            "zaimek vrsta=osebni oseba=tretja spol=moški število=množina sklon=mestnik",
            "Pronoun Type=personal Person=third Gender=masculine Number=plural Case=locative");
        InsertMsd(
            "Pp3mpi",
            "zaimek vrsta=osebni oseba=tretja spol=moški število=množina sklon=orodnik",
            "Pronoun Type=personal Person=third Gender=masculine Number=plural Case=instrumental");
        InsertMsd(
            "Pp3fsn",
            "zaimek vrsta=osebni oseba=tretja spol=ženski število=ednina sklon=imenovalnik",
            "Pronoun Type=personal Person=third Gender=feminine Number=singular Case=nominative");
        InsertMsd(
            "Pp3fsg",
            "zaimek vrsta=osebni oseba=tretja spol=ženski število=ednina sklon=rodilnik",
            "Pronoun Type=personal Person=third Gender=feminine Number=singular Case=genitive");
        InsertMsd(
            "Pp3fsg--y",
            "zaimek vrsta=osebni oseba=tretja spol=ženski število=ednina sklon=rodilnik naslonskost=kliticna",
            "Pronoun Type=personal Person=third Gender=feminine Number=singular Case=genitive Clitic=yes");
        InsertMsd(
            "Pp3fsd",
            "zaimek vrsta=osebni oseba=tretja spol=ženski število=ednina sklon=dajalnik",
            "Pronoun Type=personal Person=third Gender=feminine Number=singular Case=dative");
        InsertMsd(
            "Pp3fsd--y",
            "zaimek vrsta=osebni oseba=tretja spol=ženski število=ednina sklon=dajalnik naslonskost=kliticna",
            "Pronoun Type=personal Person=third Gender=feminine Number=singular Case=dative Clitic=yes");
        InsertMsd(
            "Pp3fsa",
            "zaimek vrsta=osebni oseba=tretja spol=ženski število=ednina sklon=tožilnik",
            "Pronoun Type=personal Person=third Gender=feminine Number=singular Case=accusative");
        InsertMsd(
            "Pp3fsa--y",
            "zaimek vrsta=osebni oseba=tretja spol=ženski število=ednina sklon=tožilnik naslonskost=kliticna",
            "Pronoun Type=personal Person=third Gender=feminine Number=singular Case=accusative Clitic=yes");
        InsertMsd(
            "Pp3fsa--b",
            "zaimek vrsta=osebni oseba=tretja spol=ženski število=ednina sklon=tožilnik naslonskost=navezna",
            "Pronoun Type=personal Person=third Gender=feminine Number=singular Case=accusative Clitic=bound");
        InsertMsd(
            "Pp3fsl",
            "zaimek vrsta=osebni oseba=tretja spol=ženski število=ednina sklon=mestnik",
            "Pronoun Type=personal Person=third Gender=feminine Number=singular Case=locative");
        InsertMsd(
            "Pp3fsi",
            "zaimek vrsta=osebni oseba=tretja spol=ženski število=ednina sklon=orodnik",
            "Pronoun Type=personal Person=third Gender=feminine Number=singular Case=instrumental");
        InsertMsd(
            "Pp3fdn",
            "zaimek vrsta=osebni oseba=tretja spol=ženski število=dvojina sklon=imenovalnik",
            "Pronoun Type=personal Person=third Gender=feminine Number=dual Case=nominative");
        InsertMsd(
            "Pp3fdg",
            "zaimek vrsta=osebni oseba=tretja spol=ženski število=dvojina sklon=rodilnik",
            "Pronoun Type=personal Person=third Gender=feminine Number=dual Case=genitive");
        InsertMsd(
            "Pp3fdg--y",
            "zaimek vrsta=osebni oseba=tretja spol=ženski število=dvojina sklon=rodilnik naslonskost=kliticna",
            "Pronoun Type=personal Person=third Gender=feminine Number=dual Case=genitive Clitic=yes");
        InsertMsd(
            "Pp3fdd",
            "zaimek vrsta=osebni oseba=tretja spol=ženski število=dvojina sklon=dajalnik",
            "Pronoun Type=personal Person=third Gender=feminine Number=dual Case=dative");
        InsertMsd(
            "Pp3fdd--y",
            "zaimek vrsta=osebni oseba=tretja spol=ženski število=dvojina sklon=dajalnik naslonskost=kliticna",
            "Pronoun Type=personal Person=third Gender=feminine Number=dual Case=dative Clitic=yes");
        InsertMsd(
            "Pp3fda",
            "zaimek vrsta=osebni oseba=tretja spol=ženski število=dvojina sklon=tožilnik",
            "Pronoun Type=personal Person=third Gender=feminine Number=dual Case=accusative");
        InsertMsd(
            "Pp3fda--y",
            "zaimek vrsta=osebni oseba=tretja spol=ženski število=dvojina sklon=tožilnik naslonskost=kliticna",
            "Pronoun Type=personal Person=third Gender=feminine Number=dual Case=accusative Clitic=yes");
        InsertMsd(
            "Pp3fda--b",
            "zaimek vrsta=osebni oseba=tretja spol=ženski število=dvojina sklon=tožilnik naslonskost=navezna",
            "Pronoun Type=personal Person=third Gender=feminine Number=dual Case=accusative Clitic=bound");
        InsertMsd(
            "Pp3fdl",
            "zaimek vrsta=osebni oseba=tretja spol=ženski število=dvojina sklon=mestnik",
            "Pronoun Type=personal Person=third Gender=feminine Number=dual Case=locative");
        InsertMsd(
            "Pp3fdi",
            "zaimek vrsta=osebni oseba=tretja spol=ženski število=dvojina sklon=orodnik",
            "Pronoun Type=personal Person=third Gender=feminine Number=dual Case=instrumental");
        InsertMsd(
            "Pp3fpn",
            "zaimek vrsta=osebni oseba=tretja spol=ženski število=množina sklon=imenovalnik",
            "Pronoun Type=personal Person=third Gender=feminine Number=plural Case=nominative");
        InsertMsd(
            "Pp3fpg",
            "zaimek vrsta=osebni oseba=tretja spol=ženski število=množina sklon=rodilnik",
            "Pronoun Type=personal Person=third Gender=feminine Number=plural Case=genitive");
        InsertMsd(
            "Pp3fpg--y",
            "zaimek vrsta=osebni oseba=tretja spol=ženski število=množina sklon=rodilnik naslonskost=kliticna",
            "Pronoun Type=personal Person=third Gender=feminine Number=plural Case=genitive Clitic=yes");
        InsertMsd(
            "Pp3fpd",
            "zaimek vrsta=osebni oseba=tretja spol=ženski število=množina sklon=dajalnik",
            "Pronoun Type=personal Person=third Gender=feminine Number=plural Case=dative");
        InsertMsd(
            "Pp3fpd--y",
            "zaimek vrsta=osebni oseba=tretja spol=ženski število=množina sklon=dajalnik naslonskost=kliticna",
            "Pronoun Type=personal Person=third Gender=feminine Number=plural Case=dative Clitic=yes");
        InsertMsd(
            "Pp3fpa",
            "zaimek vrsta=osebni oseba=tretja spol=ženski število=množina sklon=tožilnik",
            "Pronoun Type=personal Person=third Gender=feminine Number=plural Case=accusative");
        InsertMsd(
            "Pp3fpa--y",
            "zaimek vrsta=osebni oseba=tretja spol=ženski število=množina sklon=tožilnik naslonskost=kliticna",
            "Pronoun Type=personal Person=third Gender=feminine Number=plural Case=accusative Clitic=yes");
        InsertMsd(
            "Pp3fpa--b",
            "zaimek vrsta=osebni oseba=tretja spol=ženski število=množina sklon=tožilnik naslonskost=navezna",
            "Pronoun Type=personal Person=third Gender=feminine Number=plural Case=accusative Clitic=bound");
        InsertMsd(
            "Pp3fpl",
            "zaimek vrsta=osebni oseba=tretja spol=ženski število=množina sklon=mestnik",
            "Pronoun Type=personal Person=third Gender=feminine Number=plural Case=locative");
        InsertMsd(
            "Pp3fpi",
            "zaimek vrsta=osebni oseba=tretja spol=ženski število=množina sklon=orodnik",
            "Pronoun Type=personal Person=third Gender=feminine Number=plural Case=instrumental");
        InsertMsd(
            "Pp3nsn",
            "zaimek vrsta=osebni oseba=tretja spol=srednji število=ednina sklon=imenovalnik",
            "Pronoun Type=personal Person=third Gender=neuter Number=singular Case=nominative");
        InsertMsd(
            "Pp3nsg",
            "zaimek vrsta=osebni oseba=tretja spol=srednji število=ednina sklon=rodilnik",
            "Pronoun Type=personal Person=third Gender=neuter Number=singular Case=genitive");
        InsertMsd(
            "Pp3nsg--y",
            "zaimek vrsta=osebni oseba=tretja spol=srednji število=ednina sklon=rodilnik naslonskost=kliticna",
            "Pronoun Type=personal Person=third Gender=neuter Number=singular Case=genitive Clitic=yes");
        InsertMsd(
            "Pp3nsd",
            "zaimek vrsta=osebni oseba=tretja spol=srednji število=ednina sklon=dajalnik",
            "Pronoun Type=personal Person=third Gender=neuter Number=singular Case=dative");
        InsertMsd(
            "Pp3nsd--y",
            "zaimek vrsta=osebni oseba=tretja spol=srednji število=ednina sklon=dajalnik naslonskost=kliticna",
            "Pronoun Type=personal Person=third Gender=neuter Number=singular Case=dative Clitic=yes");
        InsertMsd(
            "Pp3nsa",
            "zaimek vrsta=osebni oseba=tretja spol=srednji število=ednina sklon=tožilnik",
            "Pronoun Type=personal Person=third Gender=neuter Number=singular Case=accusative");
        InsertMsd(
            "Pp3nsa--y",
            "zaimek vrsta=osebni oseba=tretja spol=srednji število=ednina sklon=tožilnik naslonskost=kliticna",
            "Pronoun Type=personal Person=third Gender=neuter Number=singular Case=accusative Clitic=yes");
        InsertMsd(
            "Pp3nsa--b",
            "zaimek vrsta=osebni oseba=tretja spol=srednji število=ednina sklon=tožilnik naslonskost=navezna",
            "Pronoun Type=personal Person=third Gender=neuter Number=singular Case=accusative Clitic=bound");
        InsertMsd(
            "Pp3nsl",
            "zaimek vrsta=osebni oseba=tretja spol=srednji število=ednina sklon=mestnik",
            "Pronoun Type=personal Person=third Gender=neuter Number=singular Case=locative");
        InsertMsd(
            "Pp3nsi",
            "zaimek vrsta=osebni oseba=tretja spol=srednji število=ednina sklon=orodnik",
            "Pronoun Type=personal Person=third Gender=neuter Number=singular Case=instrumental");
        InsertMsd(
            "Pp3ndn",
            "zaimek vrsta=osebni oseba=tretja spol=srednji število=dvojina sklon=imenovalnik",
            "Pronoun Type=personal Person=third Gender=neuter Number=dual Case=nominative");
        InsertMsd(
            "Pp3ndg",
            "zaimek vrsta=osebni oseba=tretja spol=srednji število=dvojina sklon=rodilnik",
            "Pronoun Type=personal Person=third Gender=neuter Number=dual Case=genitive");
        InsertMsd(
            "Pp3ndg--y",
            "zaimek vrsta=osebni oseba=tretja spol=srednji število=dvojina sklon=rodilnik naslonskost=kliticna",
            "Pronoun Type=personal Person=third Gender=neuter Number=dual Case=genitive Clitic=yes");
        InsertMsd(
            "Pp3ndd",
            "zaimek vrsta=osebni oseba=tretja spol=srednji število=dvojina sklon=dajalnik",
            "Pronoun Type=personal Person=third Gender=neuter Number=dual Case=dative");
        InsertMsd(
            "Pp3ndd--y",
            "zaimek vrsta=osebni oseba=tretja spol=srednji število=dvojina sklon=dajalnik naslonskost=kliticna",
            "Pronoun Type=personal Person=third Gender=neuter Number=dual Case=dative Clitic=yes");
        InsertMsd(
            "Pp3nda",
            "zaimek vrsta=osebni oseba=tretja spol=srednji število=dvojina sklon=tožilnik",
            "Pronoun Type=personal Person=third Gender=neuter Number=dual Case=accusative");
        InsertMsd(
            "Pp3nda--y",
            "zaimek vrsta=osebni oseba=tretja spol=srednji število=dvojina sklon=tožilnik naslonskost=kliticna",
            "Pronoun Type=personal Person=third Gender=neuter Number=dual Case=accusative Clitic=yes");
        InsertMsd(
            "Pp3nda--b",
            "zaimek vrsta=osebni oseba=tretja spol=srednji število=dvojina sklon=tožilnik naslonskost=navezna",
            "Pronoun Type=personal Person=third Gender=neuter Number=dual Case=accusative Clitic=bound");
        InsertMsd(
            "Pp3ndl",
            "zaimek vrsta=osebni oseba=tretja spol=srednji število=dvojina sklon=mestnik",
            "Pronoun Type=personal Person=third Gender=neuter Number=dual Case=locative");
        InsertMsd(
            "Pp3ndi",
            "zaimek vrsta=osebni oseba=tretja spol=srednji število=dvojina sklon=orodnik",
            "Pronoun Type=personal Person=third Gender=neuter Number=dual Case=instrumental");
        InsertMsd(
            "Pp3npn",
            "zaimek vrsta=osebni oseba=tretja spol=srednji število=množina sklon=imenovalnik",
            "Pronoun Type=personal Person=third Gender=neuter Number=plural Case=nominative");
        InsertMsd(
            "Pp3npg",
            "zaimek vrsta=osebni oseba=tretja spol=srednji število=množina sklon=rodilnik",
            "Pronoun Type=personal Person=third Gender=neuter Number=plural Case=genitive");
        InsertMsd(
            "Pp3npg--y",
            "zaimek vrsta=osebni oseba=tretja spol=srednji število=množina sklon=rodilnik naslonskost=kliticna",
            "Pronoun Type=personal Person=third Gender=neuter Number=plural Case=genitive Clitic=yes");
        InsertMsd(
            "Pp3npd",
            "zaimek vrsta=osebni oseba=tretja spol=srednji število=množina sklon=dajalnik",
            "Pronoun Type=personal Person=third Gender=neuter Number=plural Case=dative");
        InsertMsd(
            "Pp3npd--y",
            "zaimek vrsta=osebni oseba=tretja spol=srednji število=množina sklon=dajalnik naslonskost=kliticna",
            "Pronoun Type=personal Person=third Gender=neuter Number=plural Case=dative Clitic=yes");
        InsertMsd(
            "Pp3npa",
            "zaimek vrsta=osebni oseba=tretja spol=srednji število=množina sklon=tožilnik",
            "Pronoun Type=personal Person=third Gender=neuter Number=plural Case=accusative");
        InsertMsd(
            "Pp3npa--y",
            "zaimek vrsta=osebni oseba=tretja spol=srednji število=množina sklon=tožilnik naslonskost=kliticna",
            "Pronoun Type=personal Person=third Gender=neuter Number=plural Case=accusative Clitic=yes");
        InsertMsd(
            "Pp3npa--b",
            "zaimek vrsta=osebni oseba=tretja spol=srednji število=množina sklon=tožilnik naslonskost=navezna",
            "Pronoun Type=personal Person=third Gender=neuter Number=plural Case=accusative Clitic=bound");
        InsertMsd(
            "Pp3npl",
            "zaimek vrsta=osebni oseba=tretja spol=srednji število=množina sklon=mestnik",
            "Pronoun Type=personal Person=third Gender=neuter Number=plural Case=locative");
        InsertMsd(
            "Pp3npi",
            "zaimek vrsta=osebni oseba=tretja spol=srednji število=množina sklon=orodnik",
            "Pronoun Type=personal Person=third Gender=neuter Number=plural Case=instrumental");
        InsertMsd(
            "Ps1msns",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=ednina sklon=imenovalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=singular Case=nominative Owner_Number=singular");
        InsertMsd(
            "Ps1msnd",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=ednina sklon=imenovalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=singular Case=nominative Owner_Number=dual");
        InsertMsd(
            "Ps1msnp",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=ednina sklon=imenovalnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=singular Case=nominative Owner_Number=plural");
        InsertMsd(
            "Ps1msgs",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=ednina sklon=rodilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=singular Case=genitive Owner_Number=singular");
        InsertMsd(
            "Ps1msgd",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=ednina sklon=rodilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=singular Case=genitive Owner_Number=dual");
        InsertMsd(
            "Ps1msgp",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=ednina sklon=rodilnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=singular Case=genitive Owner_Number=plural");
        InsertMsd(
            "Ps1msds",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=ednina sklon=dajalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=singular Case=dative Owner_Number=singular");
        InsertMsd(
            "Ps1msdd",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=ednina sklon=dajalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=singular Case=dative Owner_Number=dual");
        InsertMsd(
            "Ps1msdp",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=ednina sklon=dajalnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=singular Case=dative Owner_Number=plural");
        InsertMsd(
            "Ps1msas",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=ednina sklon=tožilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=singular Case=accusative Owner_Number=singular");
        InsertMsd(
            "Ps1msad",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=ednina sklon=tožilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=singular Case=accusative Owner_Number=dual");
        InsertMsd(
            "Ps1msap",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=ednina sklon=tožilnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=singular Case=accusative Owner_Number=plural");
        InsertMsd(
            "Ps1msls",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=ednina sklon=mestnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=singular Case=locative Owner_Number=singular");
        InsertMsd(
            "Ps1msld",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=ednina sklon=mestnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=singular Case=locative Owner_Number=dual");
        InsertMsd(
            "Ps1mslp",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=ednina sklon=mestnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=singular Case=locative Owner_Number=plural");
        InsertMsd(
            "Ps1msis",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=ednina sklon=orodnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=singular Case=instrumental Owner_Number=singular");
        InsertMsd(
            "Ps1msid",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=ednina sklon=orodnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=singular Case=instrumental Owner_Number=dual");
        InsertMsd(
            "Ps1msip",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=ednina sklon=orodnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=singular Case=instrumental Owner_Number=plural");
        InsertMsd(
            "Ps1mdns",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=dvojina sklon=imenovalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=dual Case=nominative Owner_Number=singular");
        InsertMsd(
            "Ps1mdnd",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=dvojina sklon=imenovalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=dual Case=nominative Owner_Number=dual");
        InsertMsd(
            "Ps1mdnp",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=dvojina sklon=imenovalnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=dual Case=nominative Owner_Number=plural");
        InsertMsd(
            "Ps1mdgs",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=dvojina sklon=rodilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=dual Case=genitive Owner_Number=singular");
        InsertMsd(
            "Ps1mdgd",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=dvojina sklon=rodilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=dual Case=genitive Owner_Number=dual");
        InsertMsd(
            "Ps1mdgp",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=dvojina sklon=rodilnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=dual Case=genitive Owner_Number=plural");
        InsertMsd(
            "Ps1mdds",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=dvojina sklon=dajalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=dual Case=dative Owner_Number=singular");
        InsertMsd(
            "Ps1mddd",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=dvojina sklon=dajalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=dual Case=dative Owner_Number=dual");
        InsertMsd(
            "Ps1mddp",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=dvojina sklon=dajalnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=dual Case=dative Owner_Number=plural");
        InsertMsd(
            "Ps1mdas",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=dvojina sklon=tožilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=dual Case=accusative Owner_Number=singular");
        InsertMsd(
            "Ps1mdad",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=dvojina sklon=tožilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=dual Case=accusative Owner_Number=dual");
        InsertMsd(
            "Ps1mdap",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=dvojina sklon=tožilnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=dual Case=accusative Owner_Number=plural");
        InsertMsd(
            "Ps1mdls",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=dvojina sklon=mestnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=dual Case=locative Owner_Number=singular");
        InsertMsd(
            "Ps1mdld",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=dvojina sklon=mestnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=dual Case=locative Owner_Number=dual");
        InsertMsd(
            "Ps1mdlp",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=dvojina sklon=mestnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=dual Case=locative Owner_Number=plural");
        InsertMsd(
            "Ps1mdis",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=dvojina sklon=orodnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=dual Case=instrumental Owner_Number=singular");
        InsertMsd(
            "Ps1mdid",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=dvojina sklon=orodnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=dual Case=instrumental Owner_Number=dual");
        InsertMsd(
            "Ps1mdip",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=dvojina sklon=orodnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=dual Case=instrumental Owner_Number=plural");
        InsertMsd(
            "Ps1mpns",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=množina sklon=imenovalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=plural Case=nominative Owner_Number=singular");
        InsertMsd(
            "Ps1mpnd",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=množina sklon=imenovalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=plural Case=nominative Owner_Number=dual");
        InsertMsd(
            "Ps1mpnp",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=množina sklon=imenovalnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=plural Case=nominative Owner_Number=plural");
        InsertMsd(
            "Ps1mpgs",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=množina sklon=rodilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=plural Case=genitive Owner_Number=singular");
        InsertMsd(
            "Ps1mpgd",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=množina sklon=rodilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=plural Case=genitive Owner_Number=dual");
        InsertMsd(
            "Ps1mpgp",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=množina sklon=rodilnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=plural Case=genitive Owner_Number=plural");
        InsertMsd(
            "Ps1mpds",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=množina sklon=dajalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=plural Case=dative Owner_Number=singular");
        InsertMsd(
            "Ps1mpdd",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=množina sklon=dajalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=plural Case=dative Owner_Number=dual");
        InsertMsd(
            "Ps1mpdp",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=množina sklon=dajalnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=plural Case=dative Owner_Number=plural");
        InsertMsd(
            "Ps1mpas",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=množina sklon=tožilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=plural Case=accusative Owner_Number=singular");
        InsertMsd(
            "Ps1mpad",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=množina sklon=tožilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=plural Case=accusative Owner_Number=dual");
        InsertMsd(
            "Ps1mpap",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=množina sklon=tožilnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=plural Case=accusative Owner_Number=plural");
        InsertMsd(
            "Ps1mpls",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=množina sklon=mestnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=plural Case=locative Owner_Number=singular");
        InsertMsd(
            "Ps1mpld",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=množina sklon=mestnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=plural Case=locative Owner_Number=dual");
        InsertMsd(
            "Ps1mplp",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=množina sklon=mestnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=plural Case=locative Owner_Number=plural");
        InsertMsd(
            "Ps1mpis",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=množina sklon=orodnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=plural Case=instrumental Owner_Number=singular");
        InsertMsd(
            "Ps1mpid",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=množina sklon=orodnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=plural Case=instrumental Owner_Number=dual");
        InsertMsd(
            "Ps1mpip",
            "zaimek vrsta=svojilni oseba=prva spol=moški število=množina sklon=orodnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=masculine Number=plural Case=instrumental Owner_Number=plural");
        InsertMsd(
            "Ps1fsns",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=ednina sklon=imenovalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=singular Case=nominative Owner_Number=singular");
        InsertMsd(
            "Ps1fsnd",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=ednina sklon=imenovalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=singular Case=nominative Owner_Number=dual");
        InsertMsd(
            "Ps1fsnp",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=ednina sklon=imenovalnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=singular Case=nominative Owner_Number=plural");
        InsertMsd(
            "Ps1fsgs",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=ednina sklon=rodilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=singular Case=genitive Owner_Number=singular");
        InsertMsd(
            "Ps1fsgd",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=ednina sklon=rodilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=singular Case=genitive Owner_Number=dual");
        InsertMsd(
            "Ps1fsgp",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=ednina sklon=rodilnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=singular Case=genitive Owner_Number=plural");
        InsertMsd(
            "Ps1fsds",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=ednina sklon=dajalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=singular Case=dative Owner_Number=singular");
        InsertMsd(
            "Ps1fsdd",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=ednina sklon=dajalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=singular Case=dative Owner_Number=dual");
        InsertMsd(
            "Ps1fsdp",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=ednina sklon=dajalnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=singular Case=dative Owner_Number=plural");
        InsertMsd(
            "Ps1fsas",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=ednina sklon=tožilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=singular Case=accusative Owner_Number=singular");
        InsertMsd(
            "Ps1fsad",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=ednina sklon=tožilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=singular Case=accusative Owner_Number=dual");
        InsertMsd(
            "Ps1fsap",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=ednina sklon=tožilnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=singular Case=accusative Owner_Number=plural");
        InsertMsd(
            "Ps1fsls",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=ednina sklon=mestnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=singular Case=locative Owner_Number=singular");
        InsertMsd(
            "Ps1fsld",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=ednina sklon=mestnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=singular Case=locative Owner_Number=dual");
        InsertMsd(
            "Ps1fslp",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=ednina sklon=mestnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=singular Case=locative Owner_Number=plural");
        InsertMsd(
            "Ps1fsis",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=ednina sklon=orodnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=singular Case=instrumental Owner_Number=singular");
        InsertMsd(
            "Ps1fsid",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=ednina sklon=orodnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=singular Case=instrumental Owner_Number=dual");
        InsertMsd(
            "Ps1fsip",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=ednina sklon=orodnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=singular Case=instrumental Owner_Number=plural");
        InsertMsd(
            "Ps1fdns",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=dvojina sklon=imenovalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=dual Case=nominative Owner_Number=singular");
        InsertMsd(
            "Ps1fdnd",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=dvojina sklon=imenovalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=dual Case=nominative Owner_Number=dual");
        InsertMsd(
            "Ps1fdnp",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=dvojina sklon=imenovalnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=dual Case=nominative Owner_Number=plural");
        InsertMsd(
            "Ps1fdgs",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=dvojina sklon=rodilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=dual Case=genitive Owner_Number=singular");
        InsertMsd(
            "Ps1fdgd",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=dvojina sklon=rodilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=dual Case=genitive Owner_Number=dual");
        InsertMsd(
            "Ps1fdgp",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=dvojina sklon=rodilnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=dual Case=genitive Owner_Number=plural");
        InsertMsd(
            "Ps1fdds",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=dvojina sklon=dajalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=dual Case=dative Owner_Number=singular");
        InsertMsd(
            "Ps1fddd",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=dvojina sklon=dajalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=dual Case=dative Owner_Number=dual");
        InsertMsd(
            "Ps1fddp",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=dvojina sklon=dajalnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=dual Case=dative Owner_Number=plural");
        InsertMsd(
            "Ps1fdas",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=dvojina sklon=tožilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=dual Case=accusative Owner_Number=singular");
        InsertMsd(
            "Ps1fdad",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=dvojina sklon=tožilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=dual Case=accusative Owner_Number=dual");
        InsertMsd(
            "Ps1fdap",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=dvojina sklon=tožilnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=dual Case=accusative Owner_Number=plural");
        InsertMsd(
            "Ps1fdls",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=dvojina sklon=mestnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=dual Case=locative Owner_Number=singular");
        InsertMsd(
            "Ps1fdld",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=dvojina sklon=mestnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=dual Case=locative Owner_Number=dual");
        InsertMsd(
            "Ps1fdlp",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=dvojina sklon=mestnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=dual Case=locative Owner_Number=plural");
        InsertMsd(
            "Ps1fdis",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=dvojina sklon=orodnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=dual Case=instrumental Owner_Number=singular");
        InsertMsd(
            "Ps1fdid",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=dvojina sklon=orodnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=dual Case=instrumental Owner_Number=dual");
        InsertMsd(
            "Ps1fdip",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=dvojina sklon=orodnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=dual Case=instrumental Owner_Number=plural");
        InsertMsd(
            "Ps1fpns",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=množina sklon=imenovalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=plural Case=nominative Owner_Number=singular");
        InsertMsd(
            "Ps1fpnd",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=množina sklon=imenovalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=plural Case=nominative Owner_Number=dual");
        InsertMsd(
            "Ps1fpnp",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=množina sklon=imenovalnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=plural Case=nominative Owner_Number=plural");
        InsertMsd(
            "Ps1fpgs",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=množina sklon=rodilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=plural Case=genitive Owner_Number=singular");
        InsertMsd(
            "Ps1fpgd",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=množina sklon=rodilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=plural Case=genitive Owner_Number=dual");
        InsertMsd(
            "Ps1fpgp",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=množina sklon=rodilnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=plural Case=genitive Owner_Number=plural");
        InsertMsd(
            "Ps1fpds",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=množina sklon=dajalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=plural Case=dative Owner_Number=singular");
        InsertMsd(
            "Ps1fpdd",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=množina sklon=dajalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=plural Case=dative Owner_Number=dual");
        InsertMsd(
            "Ps1fpdp",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=množina sklon=dajalnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=plural Case=dative Owner_Number=plural");
        InsertMsd(
            "Ps1fpas",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=množina sklon=tožilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=plural Case=accusative Owner_Number=singular");
        InsertMsd(
            "Ps1fpad",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=množina sklon=tožilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=plural Case=accusative Owner_Number=dual");
        InsertMsd(
            "Ps1fpap",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=množina sklon=tožilnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=plural Case=accusative Owner_Number=plural");
        InsertMsd(
            "Ps1fpls",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=množina sklon=mestnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=plural Case=locative Owner_Number=singular");
        InsertMsd(
            "Ps1fpld",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=množina sklon=mestnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=plural Case=locative Owner_Number=dual");
        InsertMsd(
            "Ps1fplp",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=množina sklon=mestnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=plural Case=locative Owner_Number=plural");
        InsertMsd(
            "Ps1fpis",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=množina sklon=orodnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=plural Case=instrumental Owner_Number=singular");
        InsertMsd(
            "Ps1fpid",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=množina sklon=orodnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=plural Case=instrumental Owner_Number=dual");
        InsertMsd(
            "Ps1fpip",
            "zaimek vrsta=svojilni oseba=prva spol=ženski število=množina sklon=orodnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=feminine Number=plural Case=instrumental Owner_Number=plural");
        InsertMsd(
            "Ps1nsns",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=ednina sklon=imenovalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=singular Case=nominative Owner_Number=singular");
        InsertMsd(
            "Ps1nsnd",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=ednina sklon=imenovalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=singular Case=nominative Owner_Number=dual");
        InsertMsd(
            "Ps1nsnp",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=ednina sklon=imenovalnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=singular Case=nominative Owner_Number=plural");
        InsertMsd(
            "Ps1nsgs",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=ednina sklon=rodilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=singular Case=genitive Owner_Number=singular");
        InsertMsd(
            "Ps1nsgd",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=ednina sklon=rodilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=singular Case=genitive Owner_Number=dual");
        InsertMsd(
            "Ps1nsgp",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=ednina sklon=rodilnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=singular Case=genitive Owner_Number=plural");
        InsertMsd(
            "Ps1nsds",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=ednina sklon=dajalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=singular Case=dative Owner_Number=singular");
        InsertMsd(
            "Ps1nsdd",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=ednina sklon=dajalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=singular Case=dative Owner_Number=dual");
        InsertMsd(
            "Ps1nsdp",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=ednina sklon=dajalnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=singular Case=dative Owner_Number=plural");
        InsertMsd(
            "Ps1nsas",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=ednina sklon=tožilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=singular Case=accusative Owner_Number=singular");
        InsertMsd(
            "Ps1nsad",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=ednina sklon=tožilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=singular Case=accusative Owner_Number=dual");
        InsertMsd(
            "Ps1nsap",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=ednina sklon=tožilnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=singular Case=accusative Owner_Number=plural");
        InsertMsd(
            "Ps1nsls",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=ednina sklon=mestnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=singular Case=locative Owner_Number=singular");
        InsertMsd(
            "Ps1nsld",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=ednina sklon=mestnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=singular Case=locative Owner_Number=dual");
        InsertMsd(
            "Ps1nslp",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=ednina sklon=mestnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=singular Case=locative Owner_Number=plural");
        InsertMsd(
            "Ps1nsis",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=ednina sklon=orodnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=singular Case=instrumental Owner_Number=singular");
        InsertMsd(
            "Ps1nsid",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=ednina sklon=orodnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=singular Case=instrumental Owner_Number=dual");
        InsertMsd(
            "Ps1nsip",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=ednina sklon=orodnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=singular Case=instrumental Owner_Number=plural");
        InsertMsd(
            "Ps1ndns",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=dvojina sklon=imenovalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=dual Case=nominative Owner_Number=singular");
        InsertMsd(
            "Ps1ndnd",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=dvojina sklon=imenovalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=dual Case=nominative Owner_Number=dual");
        InsertMsd(
            "Ps1ndnp",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=dvojina sklon=imenovalnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=dual Case=nominative Owner_Number=plural");
        InsertMsd(
            "Ps1ndgs",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=dvojina sklon=rodilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=dual Case=genitive Owner_Number=singular");
        InsertMsd(
            "Ps1ndgd",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=dvojina sklon=rodilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=dual Case=genitive Owner_Number=dual");
        InsertMsd(
            "Ps1ndgp",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=dvojina sklon=rodilnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=dual Case=genitive Owner_Number=plural");
        InsertMsd(
            "Ps1ndds",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=dvojina sklon=dajalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=dual Case=dative Owner_Number=singular");
        InsertMsd(
            "Ps1nddd",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=dvojina sklon=dajalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=dual Case=dative Owner_Number=dual");
        InsertMsd(
            "Ps1nddp",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=dvojina sklon=dajalnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=dual Case=dative Owner_Number=plural");
        InsertMsd(
            "Ps1ndas",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=dvojina sklon=tožilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=dual Case=accusative Owner_Number=singular");
        InsertMsd(
            "Ps1ndad",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=dvojina sklon=tožilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=dual Case=accusative Owner_Number=dual");
        InsertMsd(
            "Ps1ndap",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=dvojina sklon=tožilnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=dual Case=accusative Owner_Number=plural");
        InsertMsd(
            "Ps1ndls",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=dvojina sklon=mestnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=dual Case=locative Owner_Number=singular");
        InsertMsd(
            "Ps1ndld",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=dvojina sklon=mestnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=dual Case=locative Owner_Number=dual");
        InsertMsd(
            "Ps1ndlp",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=dvojina sklon=mestnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=dual Case=locative Owner_Number=plural");
        InsertMsd(
            "Ps1ndis",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=dvojina sklon=orodnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=dual Case=instrumental Owner_Number=singular");
        InsertMsd(
            "Ps1ndid",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=dvojina sklon=orodnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=dual Case=instrumental Owner_Number=dual");
        InsertMsd(
            "Ps1ndip",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=dvojina sklon=orodnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=dual Case=instrumental Owner_Number=plural");
        InsertMsd(
            "Ps1npns",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=množina sklon=imenovalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=plural Case=nominative Owner_Number=singular");
        InsertMsd(
            "Ps1npnd",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=množina sklon=imenovalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=plural Case=nominative Owner_Number=dual");
        InsertMsd(
            "Ps1npnp",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=množina sklon=imenovalnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=plural Case=nominative Owner_Number=plural");
        InsertMsd(
            "Ps1npgs",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=množina sklon=rodilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=plural Case=genitive Owner_Number=singular");
        InsertMsd(
            "Ps1npgd",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=množina sklon=rodilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=plural Case=genitive Owner_Number=dual");
        InsertMsd(
            "Ps1npgp",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=množina sklon=rodilnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=plural Case=genitive Owner_Number=plural");
        InsertMsd(
            "Ps1npds",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=množina sklon=dajalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=plural Case=dative Owner_Number=singular");
        InsertMsd(
            "Ps1npdd",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=množina sklon=dajalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=plural Case=dative Owner_Number=dual");
        InsertMsd(
            "Ps1npdp",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=množina sklon=dajalnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=plural Case=dative Owner_Number=plural");
        InsertMsd(
            "Ps1npas",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=množina sklon=tožilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=plural Case=accusative Owner_Number=singular");
        InsertMsd(
            "Ps1npad",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=množina sklon=tožilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=plural Case=accusative Owner_Number=dual");
        InsertMsd(
            "Ps1npap",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=množina sklon=tožilnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=plural Case=accusative Owner_Number=plural");
        InsertMsd(
            "Ps1npls",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=množina sklon=mestnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=plural Case=locative Owner_Number=singular");
        InsertMsd(
            "Ps1npld",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=množina sklon=mestnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=plural Case=locative Owner_Number=dual");
        InsertMsd(
            "Ps1nplp",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=množina sklon=mestnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=plural Case=locative Owner_Number=plural");
        InsertMsd(
            "Ps1npis",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=množina sklon=orodnik število_svojine=ednina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=plural Case=instrumental Owner_Number=singular");
        InsertMsd(
            "Ps1npid",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=množina sklon=orodnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=plural Case=instrumental Owner_Number=dual");
        InsertMsd(
            "Ps1npip",
            "zaimek vrsta=svojilni oseba=prva spol=srednji število=množina sklon=orodnik število_svojine=množina",
            "Pronoun Type=possessive Person=first Gender=neuter Number=plural Case=instrumental Owner_Number=plural");
        InsertMsd(
            "Ps2msns",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=ednina sklon=imenovalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=singular Case=nominative Owner_Number=singular");
        InsertMsd(
            "Ps2msnd",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=ednina sklon=imenovalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=singular Case=nominative Owner_Number=dual");
        InsertMsd(
            "Ps2msnp",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=ednina sklon=imenovalnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=singular Case=nominative Owner_Number=plural");
        InsertMsd(
            "Ps2msgs",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=ednina sklon=rodilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=singular Case=genitive Owner_Number=singular");
        InsertMsd(
            "Ps2msgd",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=ednina sklon=rodilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=singular Case=genitive Owner_Number=dual");
        InsertMsd(
            "Ps2msgp",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=ednina sklon=rodilnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=singular Case=genitive Owner_Number=plural");
        InsertMsd(
            "Ps2msds",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=ednina sklon=dajalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=singular Case=dative Owner_Number=singular");
        InsertMsd(
            "Ps2msdd",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=ednina sklon=dajalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=singular Case=dative Owner_Number=dual");
        InsertMsd(
            "Ps2msdp",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=ednina sklon=dajalnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=singular Case=dative Owner_Number=plural");
        InsertMsd(
            "Ps2msas",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=ednina sklon=tožilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=singular Case=accusative Owner_Number=singular");
        InsertMsd(
            "Ps2msad",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=ednina sklon=tožilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=singular Case=accusative Owner_Number=dual");
        InsertMsd(
            "Ps2msap",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=ednina sklon=tožilnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=singular Case=accusative Owner_Number=plural");
        InsertMsd(
            "Ps2msls",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=ednina sklon=mestnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=singular Case=locative Owner_Number=singular");
        InsertMsd(
            "Ps2msld",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=ednina sklon=mestnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=singular Case=locative Owner_Number=dual");
        InsertMsd(
            "Ps2mslp",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=ednina sklon=mestnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=singular Case=locative Owner_Number=plural");
        InsertMsd(
            "Ps2msis",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=ednina sklon=orodnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=singular Case=instrumental Owner_Number=singular");
        InsertMsd(
            "Ps2msid",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=ednina sklon=orodnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=singular Case=instrumental Owner_Number=dual");
        InsertMsd(
            "Ps2msip",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=ednina sklon=orodnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=singular Case=instrumental Owner_Number=plural");
        InsertMsd(
            "Ps2mdns",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=dvojina sklon=imenovalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=dual Case=nominative Owner_Number=singular");
        InsertMsd(
            "Ps2mdnd",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=dvojina sklon=imenovalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=dual Case=nominative Owner_Number=dual");
        InsertMsd(
            "Ps2mdnp",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=dvojina sklon=imenovalnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=dual Case=nominative Owner_Number=plural");
        InsertMsd(
            "Ps2mdgs",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=dvojina sklon=rodilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=dual Case=genitive Owner_Number=singular");
        InsertMsd(
            "Ps2mdgd",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=dvojina sklon=rodilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=dual Case=genitive Owner_Number=dual");
        InsertMsd(
            "Ps2mdgp",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=dvojina sklon=rodilnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=dual Case=genitive Owner_Number=plural");
        InsertMsd(
            "Ps2mdds",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=dvojina sklon=dajalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=dual Case=dative Owner_Number=singular");
        InsertMsd(
            "Ps2mddd",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=dvojina sklon=dajalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=dual Case=dative Owner_Number=dual");
        InsertMsd(
            "Ps2mddp",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=dvojina sklon=dajalnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=dual Case=dative Owner_Number=plural");
        InsertMsd(
            "Ps2mdas",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=dvojina sklon=tožilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=dual Case=accusative Owner_Number=singular");
        InsertMsd(
            "Ps2mdad",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=dvojina sklon=tožilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=dual Case=accusative Owner_Number=dual");
        InsertMsd(
            "Ps2mdap",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=dvojina sklon=tožilnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=dual Case=accusative Owner_Number=plural");
        InsertMsd(
            "Ps2mdls",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=dvojina sklon=mestnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=dual Case=locative Owner_Number=singular");
        InsertMsd(
            "Ps2mdld",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=dvojina sklon=mestnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=dual Case=locative Owner_Number=dual");
        InsertMsd(
            "Ps2mdlp",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=dvojina sklon=mestnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=dual Case=locative Owner_Number=plural");
        InsertMsd(
            "Ps2mdis",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=dvojina sklon=orodnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=dual Case=instrumental Owner_Number=singular");
        InsertMsd(
            "Ps2mdid",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=dvojina sklon=orodnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=dual Case=instrumental Owner_Number=dual");
        InsertMsd(
            "Ps2mdip",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=dvojina sklon=orodnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=dual Case=instrumental Owner_Number=plural");
        InsertMsd(
            "Ps2mpns",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=množina sklon=imenovalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=plural Case=nominative Owner_Number=singular");
        InsertMsd(
            "Ps2mpnd",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=množina sklon=imenovalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=plural Case=nominative Owner_Number=dual");
        InsertMsd(
            "Ps2mpnp",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=množina sklon=imenovalnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=plural Case=nominative Owner_Number=plural");
        InsertMsd(
            "Ps2mpgs",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=množina sklon=rodilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=plural Case=genitive Owner_Number=singular");
        InsertMsd(
            "Ps2mpgd",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=množina sklon=rodilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=plural Case=genitive Owner_Number=dual");
        InsertMsd(
            "Ps2mpgp",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=množina sklon=rodilnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=plural Case=genitive Owner_Number=plural");
        InsertMsd(
            "Ps2mpds",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=množina sklon=dajalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=plural Case=dative Owner_Number=singular");
        InsertMsd(
            "Ps2mpdd",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=množina sklon=dajalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=plural Case=dative Owner_Number=dual");
        InsertMsd(
            "Ps2mpdp",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=množina sklon=dajalnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=plural Case=dative Owner_Number=plural");
        InsertMsd(
            "Ps2mpas",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=množina sklon=tožilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=plural Case=accusative Owner_Number=singular");
        InsertMsd(
            "Ps2mpad",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=množina sklon=tožilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=plural Case=accusative Owner_Number=dual");
        InsertMsd(
            "Ps2mpap",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=množina sklon=tožilnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=plural Case=accusative Owner_Number=plural");
        InsertMsd(
            "Ps2mpls",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=množina sklon=mestnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=plural Case=locative Owner_Number=singular");
        InsertMsd(
            "Ps2mpld",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=množina sklon=mestnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=plural Case=locative Owner_Number=dual");
        InsertMsd(
            "Ps2mplp",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=množina sklon=mestnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=plural Case=locative Owner_Number=plural");
        InsertMsd(
            "Ps2mpis",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=množina sklon=orodnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=plural Case=instrumental Owner_Number=singular");
        InsertMsd(
            "Ps2mpid",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=množina sklon=orodnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=plural Case=instrumental Owner_Number=dual");
        InsertMsd(
            "Ps2mpip",
            "zaimek vrsta=svojilni oseba=druga spol=moški število=množina sklon=orodnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=masculine Number=plural Case=instrumental Owner_Number=plural");
        InsertMsd(
            "Ps2fsns",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=ednina sklon=imenovalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=singular Case=nominative Owner_Number=singular");
        InsertMsd(
            "Ps2fsnd",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=ednina sklon=imenovalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=singular Case=nominative Owner_Number=dual");
        InsertMsd(
            "Ps2fsnp",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=ednina sklon=imenovalnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=singular Case=nominative Owner_Number=plural");
        InsertMsd(
            "Ps2fsgs",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=ednina sklon=rodilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=singular Case=genitive Owner_Number=singular");
        InsertMsd(
            "Ps2fsgd",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=ednina sklon=rodilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=singular Case=genitive Owner_Number=dual");
        InsertMsd(
            "Ps2fsgp",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=ednina sklon=rodilnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=singular Case=genitive Owner_Number=plural");
        InsertMsd(
            "Ps2fsds",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=ednina sklon=dajalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=singular Case=dative Owner_Number=singular");
        InsertMsd(
            "Ps2fsdd",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=ednina sklon=dajalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=singular Case=dative Owner_Number=dual");
        InsertMsd(
            "Ps2fsdp",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=ednina sklon=dajalnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=singular Case=dative Owner_Number=plural");
        InsertMsd(
            "Ps2fsas",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=ednina sklon=tožilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=singular Case=accusative Owner_Number=singular");
        InsertMsd(
            "Ps2fsad",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=ednina sklon=tožilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=singular Case=accusative Owner_Number=dual");
        InsertMsd(
            "Ps2fsap",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=ednina sklon=tožilnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=singular Case=accusative Owner_Number=plural");
        InsertMsd(
            "Ps2fsls",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=ednina sklon=mestnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=singular Case=locative Owner_Number=singular");
        InsertMsd(
            "Ps2fsld",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=ednina sklon=mestnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=singular Case=locative Owner_Number=dual");
        InsertMsd(
            "Ps2fslp",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=ednina sklon=mestnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=singular Case=locative Owner_Number=plural");
        InsertMsd(
            "Ps2fsis",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=ednina sklon=orodnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=singular Case=instrumental Owner_Number=singular");
        InsertMsd(
            "Ps2fsid",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=ednina sklon=orodnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=singular Case=instrumental Owner_Number=dual");
        InsertMsd(
            "Ps2fsip",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=ednina sklon=orodnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=singular Case=instrumental Owner_Number=plural");
        InsertMsd(
            "Ps2fdns",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=dvojina sklon=imenovalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=dual Case=nominative Owner_Number=singular");
        InsertMsd(
            "Ps2fdnd",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=dvojina sklon=imenovalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=dual Case=nominative Owner_Number=dual");
        InsertMsd(
            "Ps2fdnp",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=dvojina sklon=imenovalnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=dual Case=nominative Owner_Number=plural");
        InsertMsd(
            "Ps2fdgs",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=dvojina sklon=rodilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=dual Case=genitive Owner_Number=singular");
        InsertMsd(
            "Ps2fdgd",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=dvojina sklon=rodilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=dual Case=genitive Owner_Number=dual");
        InsertMsd(
            "Ps2fdgp",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=dvojina sklon=rodilnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=dual Case=genitive Owner_Number=plural");
        InsertMsd(
            "Ps2fdds",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=dvojina sklon=dajalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=dual Case=dative Owner_Number=singular");
        InsertMsd(
            "Ps2fddd",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=dvojina sklon=dajalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=dual Case=dative Owner_Number=dual");
        InsertMsd(
            "Ps2fddp",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=dvojina sklon=dajalnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=dual Case=dative Owner_Number=plural");
        InsertMsd(
            "Ps2fdas",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=dvojina sklon=tožilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=dual Case=accusative Owner_Number=singular");
        InsertMsd(
            "Ps2fdad",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=dvojina sklon=tožilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=dual Case=accusative Owner_Number=dual");
        InsertMsd(
            "Ps2fdap",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=dvojina sklon=tožilnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=dual Case=accusative Owner_Number=plural");
        InsertMsd(
            "Ps2fdls",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=dvojina sklon=mestnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=dual Case=locative Owner_Number=singular");
        InsertMsd(
            "Ps2fdld",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=dvojina sklon=mestnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=dual Case=locative Owner_Number=dual");
        InsertMsd(
            "Ps2fdlp",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=dvojina sklon=mestnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=dual Case=locative Owner_Number=plural");
        InsertMsd(
            "Ps2fdis",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=dvojina sklon=orodnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=dual Case=instrumental Owner_Number=singular");
        InsertMsd(
            "Ps2fdid",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=dvojina sklon=orodnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=dual Case=instrumental Owner_Number=dual");
        InsertMsd(
            "Ps2fdip",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=dvojina sklon=orodnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=dual Case=instrumental Owner_Number=plural");
        InsertMsd(
            "Ps2fpns",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=množina sklon=imenovalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=plural Case=nominative Owner_Number=singular");
        InsertMsd(
            "Ps2fpnd",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=množina sklon=imenovalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=plural Case=nominative Owner_Number=dual");
        InsertMsd(
            "Ps2fpnp",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=množina sklon=imenovalnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=plural Case=nominative Owner_Number=plural");
        InsertMsd(
            "Ps2fpgs",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=množina sklon=rodilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=plural Case=genitive Owner_Number=singular");
        InsertMsd(
            "Ps2fpgd",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=množina sklon=rodilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=plural Case=genitive Owner_Number=dual");
        InsertMsd(
            "Ps2fpgp",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=množina sklon=rodilnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=plural Case=genitive Owner_Number=plural");
        InsertMsd(
            "Ps2fpds",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=množina sklon=dajalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=plural Case=dative Owner_Number=singular");
        InsertMsd(
            "Ps2fpdd",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=množina sklon=dajalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=plural Case=dative Owner_Number=dual");
        InsertMsd(
            "Ps2fpdp",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=množina sklon=dajalnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=plural Case=dative Owner_Number=plural");
        InsertMsd(
            "Ps2fpas",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=množina sklon=tožilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=plural Case=accusative Owner_Number=singular");
        InsertMsd(
            "Ps2fpad",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=množina sklon=tožilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=plural Case=accusative Owner_Number=dual");
        InsertMsd(
            "Ps2fpap",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=množina sklon=tožilnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=plural Case=accusative Owner_Number=plural");
        InsertMsd(
            "Ps2fpls",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=množina sklon=mestnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=plural Case=locative Owner_Number=singular");
        InsertMsd(
            "Ps2fpld",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=množina sklon=mestnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=plural Case=locative Owner_Number=dual");
        InsertMsd(
            "Ps2fplp",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=množina sklon=mestnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=plural Case=locative Owner_Number=plural");
        InsertMsd(
            "Ps2fpis",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=množina sklon=orodnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=plural Case=instrumental Owner_Number=singular");
        InsertMsd(
            "Ps2fpid",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=množina sklon=orodnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=plural Case=instrumental Owner_Number=dual");
        InsertMsd(
            "Ps2fpip",
            "zaimek vrsta=svojilni oseba=druga spol=ženski število=množina sklon=orodnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=feminine Number=plural Case=instrumental Owner_Number=plural");
        InsertMsd(
            "Ps2nsns",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=ednina sklon=imenovalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=singular Case=nominative Owner_Number=singular");
        InsertMsd(
            "Ps2nsnd",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=ednina sklon=imenovalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=singular Case=nominative Owner_Number=dual");
        InsertMsd(
            "Ps2nsnp",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=ednina sklon=imenovalnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=singular Case=nominative Owner_Number=plural");
        InsertMsd(
            "Ps2nsgs",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=ednina sklon=rodilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=singular Case=genitive Owner_Number=singular");
        InsertMsd(
            "Ps2nsgd",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=ednina sklon=rodilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=singular Case=genitive Owner_Number=dual");
        InsertMsd(
            "Ps2nsgp",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=ednina sklon=rodilnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=singular Case=genitive Owner_Number=plural");
        InsertMsd(
            "Ps2nsds",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=ednina sklon=dajalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=singular Case=dative Owner_Number=singular");
        InsertMsd(
            "Ps2nsdd",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=ednina sklon=dajalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=singular Case=dative Owner_Number=dual");
        InsertMsd(
            "Ps2nsdp",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=ednina sklon=dajalnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=singular Case=dative Owner_Number=plural");
        InsertMsd(
            "Ps2nsas",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=ednina sklon=tožilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=singular Case=accusative Owner_Number=singular");
        InsertMsd(
            "Ps2nsad",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=ednina sklon=tožilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=singular Case=accusative Owner_Number=dual");
        InsertMsd(
            "Ps2nsap",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=ednina sklon=tožilnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=singular Case=accusative Owner_Number=plural");
        InsertMsd(
            "Ps2nsls",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=ednina sklon=mestnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=singular Case=locative Owner_Number=singular");
        InsertMsd(
            "Ps2nsld",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=ednina sklon=mestnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=singular Case=locative Owner_Number=dual");
        InsertMsd(
            "Ps2nslp",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=ednina sklon=mestnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=singular Case=locative Owner_Number=plural");
        InsertMsd(
            "Ps2nsis",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=ednina sklon=orodnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=singular Case=instrumental Owner_Number=singular");
        InsertMsd(
            "Ps2nsid",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=ednina sklon=orodnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=singular Case=instrumental Owner_Number=dual");
        InsertMsd(
            "Ps2nsip",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=ednina sklon=orodnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=singular Case=instrumental Owner_Number=plural");
        InsertMsd(
            "Ps2ndns",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=dvojina sklon=imenovalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=dual Case=nominative Owner_Number=singular");
        InsertMsd(
            "Ps2ndnd",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=dvojina sklon=imenovalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=dual Case=nominative Owner_Number=dual");
        InsertMsd(
            "Ps2ndnp",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=dvojina sklon=imenovalnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=dual Case=nominative Owner_Number=plural");
        InsertMsd(
            "Ps2ndgs",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=dvojina sklon=rodilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=dual Case=genitive Owner_Number=singular");
        InsertMsd(
            "Ps2ndgd",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=dvojina sklon=rodilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=dual Case=genitive Owner_Number=dual");
        InsertMsd(
            "Ps2ndgp",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=dvojina sklon=rodilnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=dual Case=genitive Owner_Number=plural");
        InsertMsd(
            "Ps2ndds",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=dvojina sklon=dajalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=dual Case=dative Owner_Number=singular");
        InsertMsd(
            "Ps2nddd",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=dvojina sklon=dajalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=dual Case=dative Owner_Number=dual");
        InsertMsd(
            "Ps2nddp",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=dvojina sklon=dajalnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=dual Case=dative Owner_Number=plural");
        InsertMsd(
            "Ps2ndas",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=dvojina sklon=tožilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=dual Case=accusative Owner_Number=singular");
        InsertMsd(
            "Ps2ndad",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=dvojina sklon=tožilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=dual Case=accusative Owner_Number=dual");
        InsertMsd(
            "Ps2ndap",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=dvojina sklon=tožilnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=dual Case=accusative Owner_Number=plural");
        InsertMsd(
            "Ps2ndls",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=dvojina sklon=mestnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=dual Case=locative Owner_Number=singular");
        InsertMsd(
            "Ps2ndld",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=dvojina sklon=mestnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=dual Case=locative Owner_Number=dual");
        InsertMsd(
            "Ps2ndlp",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=dvojina sklon=mestnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=dual Case=locative Owner_Number=plural");
        InsertMsd(
            "Ps2ndis",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=dvojina sklon=orodnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=dual Case=instrumental Owner_Number=singular");
        InsertMsd(
            "Ps2ndid",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=dvojina sklon=orodnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=dual Case=instrumental Owner_Number=dual");
        InsertMsd(
            "Ps2ndip",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=dvojina sklon=orodnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=dual Case=instrumental Owner_Number=plural");
        InsertMsd(
            "Ps2npns",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=množina sklon=imenovalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=plural Case=nominative Owner_Number=singular");
        InsertMsd(
            "Ps2npnd",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=množina sklon=imenovalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=plural Case=nominative Owner_Number=dual");
        InsertMsd(
            "Ps2npnp",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=množina sklon=imenovalnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=plural Case=nominative Owner_Number=plural");
        InsertMsd(
            "Ps2npgs",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=množina sklon=rodilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=plural Case=genitive Owner_Number=singular");
        InsertMsd(
            "Ps2npgd",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=množina sklon=rodilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=plural Case=genitive Owner_Number=dual");
        InsertMsd(
            "Ps2npgp",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=množina sklon=rodilnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=plural Case=genitive Owner_Number=plural");
        InsertMsd(
            "Ps2npds",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=množina sklon=dajalnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=plural Case=dative Owner_Number=singular");
        InsertMsd(
            "Ps2npdd",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=množina sklon=dajalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=plural Case=dative Owner_Number=dual");
        InsertMsd(
            "Ps2npdp",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=množina sklon=dajalnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=plural Case=dative Owner_Number=plural");
        InsertMsd(
            "Ps2npas",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=množina sklon=tožilnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=plural Case=accusative Owner_Number=singular");
        InsertMsd(
            "Ps2npad",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=množina sklon=tožilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=plural Case=accusative Owner_Number=dual");
        InsertMsd(
            "Ps2npap",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=množina sklon=tožilnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=plural Case=accusative Owner_Number=plural");
        InsertMsd(
            "Ps2npls",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=množina sklon=mestnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=plural Case=locative Owner_Number=singular");
        InsertMsd(
            "Ps2npld",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=množina sklon=mestnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=plural Case=locative Owner_Number=dual");
        InsertMsd(
            "Ps2nplp",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=množina sklon=mestnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=plural Case=locative Owner_Number=plural");
        InsertMsd(
            "Ps2npis",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=množina sklon=orodnik število_svojine=ednina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=plural Case=instrumental Owner_Number=singular");
        InsertMsd(
            "Ps2npid",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=množina sklon=orodnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=plural Case=instrumental Owner_Number=dual");
        InsertMsd(
            "Ps2npip",
            "zaimek vrsta=svojilni oseba=druga spol=srednji število=množina sklon=orodnik število_svojine=množina",
            "Pronoun Type=possessive Person=second Gender=neuter Number=plural Case=instrumental Owner_Number=plural");
        InsertMsd(
            "Ps3msnsm",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=ednina sklon=imenovalnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=masculine Number=singular Case=nominative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3msnsf",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=ednina sklon=imenovalnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=masculine Number=singular Case=nominative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3msnsn",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=ednina sklon=imenovalnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=masculine Number=singular Case=nominative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3msnd",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=ednina sklon=imenovalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=singular Case=nominative Owner_Number=dual");
        InsertMsd(
            "Ps3msnp",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=ednina sklon=imenovalnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=singular Case=nominative Owner_Number=plural");
        InsertMsd(
            "Ps3msgsm",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=ednina sklon=rodilnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=masculine Number=singular Case=genitive Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3msgsf",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=ednina sklon=rodilnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=masculine Number=singular Case=genitive Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3msgsn",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=ednina sklon=rodilnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=masculine Number=singular Case=genitive Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3msgd",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=ednina sklon=rodilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=singular Case=genitive Owner_Number=dual");
        InsertMsd(
            "Ps3msgp",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=ednina sklon=rodilnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=singular Case=genitive Owner_Number=plural");
        InsertMsd(
            "Ps3msdsm",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=ednina sklon=dajalnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=masculine Number=singular Case=dative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3msdsf",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=ednina sklon=dajalnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=masculine Number=singular Case=dative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3msdsn",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=ednina sklon=dajalnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=masculine Number=singular Case=dative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3msdd",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=ednina sklon=dajalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=singular Case=dative Owner_Number=dual");
        InsertMsd(
            "Ps3msdp",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=ednina sklon=dajalnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=singular Case=dative Owner_Number=plural");
        InsertMsd(
            "Ps3msasm",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=ednina sklon=tožilnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=masculine Number=singular Case=accusative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3msasf",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=ednina sklon=tožilnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=masculine Number=singular Case=accusative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3msasn",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=ednina sklon=tožilnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=masculine Number=singular Case=accusative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3msad",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=ednina sklon=tožilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=singular Case=accusative Owner_Number=dual");
        InsertMsd(
            "Ps3msap",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=ednina sklon=tožilnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=singular Case=accusative Owner_Number=plural");
        InsertMsd(
            "Ps3mslsm",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=ednina sklon=mestnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=masculine Number=singular Case=locative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3mslsf",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=ednina sklon=mestnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=masculine Number=singular Case=locative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3mslsn",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=ednina sklon=mestnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=masculine Number=singular Case=locative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3msld",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=ednina sklon=mestnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=singular Case=locative Owner_Number=dual");
        InsertMsd(
            "Ps3mslp",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=ednina sklon=mestnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=singular Case=locative Owner_Number=plural");
        InsertMsd(
            "Ps3msism",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=ednina sklon=orodnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=masculine Number=singular Case=instrumental Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3msisf",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=ednina sklon=orodnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=masculine Number=singular Case=instrumental Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3msisn",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=ednina sklon=orodnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=masculine Number=singular Case=instrumental Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3msid",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=ednina sklon=orodnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=singular Case=instrumental Owner_Number=dual");
        InsertMsd(
            "Ps3msip",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=ednina sklon=orodnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=singular Case=instrumental Owner_Number=plural");
        InsertMsd(
            "Ps3mdnsm",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=dvojina sklon=imenovalnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=masculine Number=dual Case=nominative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3mdnsf",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=dvojina sklon=imenovalnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=masculine Number=dual Case=nominative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3mdnsn",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=dvojina sklon=imenovalnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=masculine Number=dual Case=nominative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3mdnd",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=dvojina sklon=imenovalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=dual Case=nominative Owner_Number=dual");
        InsertMsd(
            "Ps3mdnp",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=dvojina sklon=imenovalnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=dual Case=nominative Owner_Number=plural");
        InsertMsd(
            "Ps3mdgsm",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=dvojina sklon=rodilnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=masculine Number=dual Case=genitive Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3mdgsf",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=dvojina sklon=rodilnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=masculine Number=dual Case=genitive Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3mdgsn",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=dvojina sklon=rodilnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=masculine Number=dual Case=genitive Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3mdgd",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=dvojina sklon=rodilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=dual Case=genitive Owner_Number=dual");
        InsertMsd(
            "Ps3mdgp",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=dvojina sklon=rodilnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=dual Case=genitive Owner_Number=plural");
        InsertMsd(
            "Ps3mddsm",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=dvojina sklon=dajalnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=masculine Number=dual Case=dative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3mddsf",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=dvojina sklon=dajalnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=masculine Number=dual Case=dative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3mddsn",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=dvojina sklon=dajalnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=masculine Number=dual Case=dative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3mddd",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=dvojina sklon=dajalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=dual Case=dative Owner_Number=dual");
        InsertMsd(
            "Ps3mddp",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=dvojina sklon=dajalnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=dual Case=dative Owner_Number=plural");
        InsertMsd(
            "Ps3mdasm",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=dvojina sklon=tožilnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=masculine Number=dual Case=accusative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3mdasf",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=dvojina sklon=tožilnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=masculine Number=dual Case=accusative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3mdasn",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=dvojina sklon=tožilnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=masculine Number=dual Case=accusative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3mdad",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=dvojina sklon=tožilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=dual Case=accusative Owner_Number=dual");
        InsertMsd(
            "Ps3mdap",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=dvojina sklon=tožilnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=dual Case=accusative Owner_Number=plural");
        InsertMsd(
            "Ps3mdlsm",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=dvojina sklon=mestnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=masculine Number=dual Case=locative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3mdlsf",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=dvojina sklon=mestnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=masculine Number=dual Case=locative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3mdlsn",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=dvojina sklon=mestnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=masculine Number=dual Case=locative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3mdld",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=dvojina sklon=mestnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=dual Case=locative Owner_Number=dual");
        InsertMsd(
            "Ps3mdlp",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=dvojina sklon=mestnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=dual Case=locative Owner_Number=plural");
        InsertMsd(
            "Ps3mdism",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=dvojina sklon=orodnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=masculine Number=dual Case=instrumental Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3mdisf",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=dvojina sklon=orodnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=masculine Number=dual Case=instrumental Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3mdisn",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=dvojina sklon=orodnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=masculine Number=dual Case=instrumental Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3mdid",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=dvojina sklon=orodnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=dual Case=instrumental Owner_Number=dual");
        InsertMsd(
            "Ps3mdip",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=dvojina sklon=orodnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=dual Case=instrumental Owner_Number=plural");
        InsertMsd(
            "Ps3mpnsm",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=množina sklon=imenovalnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=masculine Number=plural Case=nominative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3mpnsf",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=množina sklon=imenovalnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=masculine Number=plural Case=nominative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3mpnsn",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=množina sklon=imenovalnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=masculine Number=plural Case=nominative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3mpnd",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=množina sklon=imenovalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=plural Case=nominative Owner_Number=dual");
        InsertMsd(
            "Ps3mpnp",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=množina sklon=imenovalnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=plural Case=nominative Owner_Number=plural");
        InsertMsd(
            "Ps3mpgsm",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=množina sklon=rodilnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=masculine Number=plural Case=genitive Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3mpgsf",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=množina sklon=rodilnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=masculine Number=plural Case=genitive Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3mpgsn",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=množina sklon=rodilnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=masculine Number=plural Case=genitive Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3mpgd",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=množina sklon=rodilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=plural Case=genitive Owner_Number=dual");
        InsertMsd(
            "Ps3mpgp",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=množina sklon=rodilnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=plural Case=genitive Owner_Number=plural");
        InsertMsd(
            "Ps3mpdsm",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=množina sklon=dajalnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=masculine Number=plural Case=dative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3mpdsf",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=množina sklon=dajalnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=masculine Number=plural Case=dative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3mpdsn",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=množina sklon=dajalnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=masculine Number=plural Case=dative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3mpdd",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=množina sklon=dajalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=plural Case=dative Owner_Number=dual");
        InsertMsd(
            "Ps3mpdp",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=množina sklon=dajalnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=plural Case=dative Owner_Number=plural");
        InsertMsd(
            "Ps3mpasm",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=množina sklon=tožilnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=masculine Number=plural Case=accusative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3mpasf",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=množina sklon=tožilnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=masculine Number=plural Case=accusative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3mpasn",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=množina sklon=tožilnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=masculine Number=plural Case=accusative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3mpad",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=množina sklon=tožilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=plural Case=accusative Owner_Number=dual");
        InsertMsd(
            "Ps3mpap",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=množina sklon=tožilnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=plural Case=accusative Owner_Number=plural");
        InsertMsd(
            "Ps3mplsm",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=množina sklon=mestnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=masculine Number=plural Case=locative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3mplsf",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=množina sklon=mestnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=masculine Number=plural Case=locative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3mplsn",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=množina sklon=mestnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=masculine Number=plural Case=locative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3mpld",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=množina sklon=mestnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=plural Case=locative Owner_Number=dual");
        InsertMsd(
            "Ps3mplp",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=množina sklon=mestnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=plural Case=locative Owner_Number=plural");
        InsertMsd(
            "Ps3mpism",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=množina sklon=orodnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=masculine Number=plural Case=instrumental Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3mpisf",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=množina sklon=orodnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=masculine Number=plural Case=instrumental Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3mpisn",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=množina sklon=orodnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=masculine Number=plural Case=instrumental Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3mpid",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=množina sklon=orodnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=plural Case=instrumental Owner_Number=dual");
        InsertMsd(
            "Ps3mpip",
            "zaimek vrsta=svojilni oseba=tretja spol=moški število=množina sklon=orodnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=masculine Number=plural Case=instrumental Owner_Number=plural");
        InsertMsd(
            "Ps3fsnsm",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=ednina sklon=imenovalnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=feminine Number=singular Case=nominative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3fsnsf",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=ednina sklon=imenovalnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=feminine Number=singular Case=nominative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3fsnsn",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=ednina sklon=imenovalnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=feminine Number=singular Case=nominative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3fsnd",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=ednina sklon=imenovalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=singular Case=nominative Owner_Number=dual");
        InsertMsd(
            "Ps3fsnp",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=ednina sklon=imenovalnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=singular Case=nominative Owner_Number=plural");
        InsertMsd(
            "Ps3fsgsm",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=ednina sklon=rodilnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=feminine Number=singular Case=genitive Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3fsgsf",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=ednina sklon=rodilnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=feminine Number=singular Case=genitive Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3fsgsn",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=ednina sklon=rodilnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=feminine Number=singular Case=genitive Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3fsgd",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=ednina sklon=rodilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=singular Case=genitive Owner_Number=dual");
        InsertMsd(
            "Ps3fsgp",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=ednina sklon=rodilnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=singular Case=genitive Owner_Number=plural");
        InsertMsd(
            "Ps3fsdsm",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=ednina sklon=dajalnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=feminine Number=singular Case=dative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3fsdsf",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=ednina sklon=dajalnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=feminine Number=singular Case=dative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3fsdsn",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=ednina sklon=dajalnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=feminine Number=singular Case=dative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3fsdd",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=ednina sklon=dajalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=singular Case=dative Owner_Number=dual");
        InsertMsd(
            "Ps3fsdp",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=ednina sklon=dajalnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=singular Case=dative Owner_Number=plural");
        InsertMsd(
            "Ps3fsasm",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=ednina sklon=tožilnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=feminine Number=singular Case=accusative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3fsasf",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=ednina sklon=tožilnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=feminine Number=singular Case=accusative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3fsasn",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=ednina sklon=tožilnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=feminine Number=singular Case=accusative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3fsad",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=ednina sklon=tožilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=singular Case=accusative Owner_Number=dual");
        InsertMsd(
            "Ps3fsap",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=ednina sklon=tožilnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=singular Case=accusative Owner_Number=plural");
        InsertMsd(
            "Ps3fslsm",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=ednina sklon=mestnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=feminine Number=singular Case=locative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3fslsf",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=ednina sklon=mestnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=feminine Number=singular Case=locative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3fslsn",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=ednina sklon=mestnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=feminine Number=singular Case=locative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3fsld",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=ednina sklon=mestnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=singular Case=locative Owner_Number=dual");
        InsertMsd(
            "Ps3fslp",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=ednina sklon=mestnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=singular Case=locative Owner_Number=plural");
        InsertMsd(
            "Ps3fsism",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=ednina sklon=orodnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=feminine Number=singular Case=instrumental Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3fsisf",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=ednina sklon=orodnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=feminine Number=singular Case=instrumental Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3fsisn",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=ednina sklon=orodnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=feminine Number=singular Case=instrumental Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3fsid",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=ednina sklon=orodnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=singular Case=instrumental Owner_Number=dual");
        InsertMsd(
            "Ps3fsip",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=ednina sklon=orodnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=singular Case=instrumental Owner_Number=plural");
        InsertMsd(
            "Ps3fdnsm",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=dvojina sklon=imenovalnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=feminine Number=dual Case=nominative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3fdnsf",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=dvojina sklon=imenovalnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=feminine Number=dual Case=nominative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3fdnsn",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=dvojina sklon=imenovalnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=feminine Number=dual Case=nominative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3fdnd",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=dvojina sklon=imenovalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=dual Case=nominative Owner_Number=dual");
        InsertMsd(
            "Ps3fdnp",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=dvojina sklon=imenovalnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=dual Case=nominative Owner_Number=plural");
        InsertMsd(
            "Ps3fdgsm",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=dvojina sklon=rodilnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=feminine Number=dual Case=genitive Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3fdgsf",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=dvojina sklon=rodilnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=feminine Number=dual Case=genitive Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3fdgsn",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=dvojina sklon=rodilnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=feminine Number=dual Case=genitive Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3fdgd",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=dvojina sklon=rodilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=dual Case=genitive Owner_Number=dual");
        InsertMsd(
            "Ps3fdgp",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=dvojina sklon=rodilnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=dual Case=genitive Owner_Number=plural");
        InsertMsd(
            "Ps3fddsm",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=dvojina sklon=dajalnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=feminine Number=dual Case=dative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3fddsf",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=dvojina sklon=dajalnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=feminine Number=dual Case=dative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3fddsn",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=dvojina sklon=dajalnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=feminine Number=dual Case=dative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3fddd",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=dvojina sklon=dajalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=dual Case=dative Owner_Number=dual");
        InsertMsd(
            "Ps3fddp",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=dvojina sklon=dajalnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=dual Case=dative Owner_Number=plural");
        InsertMsd(
            "Ps3fdasm",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=dvojina sklon=tožilnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=feminine Number=dual Case=accusative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3fdasf",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=dvojina sklon=tožilnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=feminine Number=dual Case=accusative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3fdasn",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=dvojina sklon=tožilnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=feminine Number=dual Case=accusative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3fdad",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=dvojina sklon=tožilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=dual Case=accusative Owner_Number=dual");
        InsertMsd(
            "Ps3fdap",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=dvojina sklon=tožilnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=dual Case=accusative Owner_Number=plural");
        InsertMsd(
            "Ps3fdlsm",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=dvojina sklon=mestnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=feminine Number=dual Case=locative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3fdlsf",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=dvojina sklon=mestnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=feminine Number=dual Case=locative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3fdlsn",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=dvojina sklon=mestnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=feminine Number=dual Case=locative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3fdld",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=dvojina sklon=mestnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=dual Case=locative Owner_Number=dual");
        InsertMsd(
            "Ps3fdlp",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=dvojina sklon=mestnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=dual Case=locative Owner_Number=plural");
        InsertMsd(
            "Ps3fdism",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=dvojina sklon=orodnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=feminine Number=dual Case=instrumental Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3fdisf",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=dvojina sklon=orodnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=feminine Number=dual Case=instrumental Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3fdisn",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=dvojina sklon=orodnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=feminine Number=dual Case=instrumental Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3fdid",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=dvojina sklon=orodnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=dual Case=instrumental Owner_Number=dual");
        InsertMsd(
            "Ps3fdip",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=dvojina sklon=orodnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=dual Case=instrumental Owner_Number=plural");
        InsertMsd(
            "Ps3fpnsm",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=množina sklon=imenovalnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=feminine Number=plural Case=nominative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3fpnsf",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=množina sklon=imenovalnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=feminine Number=plural Case=nominative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3fpnsn",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=množina sklon=imenovalnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=feminine Number=plural Case=nominative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3fpnd",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=množina sklon=imenovalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=plural Case=nominative Owner_Number=dual");
        InsertMsd(
            "Ps3fpnp",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=množina sklon=imenovalnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=plural Case=nominative Owner_Number=plural");
        InsertMsd(
            "Ps3fpgsm",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=množina sklon=rodilnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=feminine Number=plural Case=genitive Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3fpgsf",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=množina sklon=rodilnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=feminine Number=plural Case=genitive Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3fpgsn",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=množina sklon=rodilnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=feminine Number=plural Case=genitive Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3fpgd",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=množina sklon=rodilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=plural Case=genitive Owner_Number=dual");
        InsertMsd(
            "Ps3fpgp",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=množina sklon=rodilnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=plural Case=genitive Owner_Number=plural");
        InsertMsd(
            "Ps3fpdsm",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=množina sklon=dajalnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=feminine Number=plural Case=dative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3fpdsf",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=množina sklon=dajalnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=feminine Number=plural Case=dative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3fpdsn",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=množina sklon=dajalnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=feminine Number=plural Case=dative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3fpdd",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=množina sklon=dajalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=plural Case=dative Owner_Number=dual");
        InsertMsd(
            "Ps3fpdp",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=množina sklon=dajalnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=plural Case=dative Owner_Number=plural");
        InsertMsd(
            "Ps3fpasm",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=množina sklon=tožilnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=feminine Number=plural Case=accusative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3fpasf",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=množina sklon=tožilnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=feminine Number=plural Case=accusative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3fpasn",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=množina sklon=tožilnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=feminine Number=plural Case=accusative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3fpad",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=množina sklon=tožilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=plural Case=accusative Owner_Number=dual");
        InsertMsd(
            "Ps3fpap",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=množina sklon=tožilnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=plural Case=accusative Owner_Number=plural");
        InsertMsd(
            "Ps3fplsm",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=množina sklon=mestnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=feminine Number=plural Case=locative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3fplsf",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=množina sklon=mestnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=feminine Number=plural Case=locative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3fplsn",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=množina sklon=mestnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=feminine Number=plural Case=locative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3fpld",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=množina sklon=mestnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=plural Case=locative Owner_Number=dual");
        InsertMsd(
            "Ps3fplp",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=množina sklon=mestnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=plural Case=locative Owner_Number=plural");
        InsertMsd(
            "Ps3fpism",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=množina sklon=orodnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=feminine Number=plural Case=instrumental Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3fpisf",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=množina sklon=orodnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=feminine Number=plural Case=instrumental Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3fpisn",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=množina sklon=orodnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=feminine Number=plural Case=instrumental Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3fpid",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=množina sklon=orodnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=plural Case=instrumental Owner_Number=dual");
        InsertMsd(
            "Ps3fpip",
            "zaimek vrsta=svojilni oseba=tretja spol=ženski število=množina sklon=orodnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=feminine Number=plural Case=instrumental Owner_Number=plural");
        InsertMsd(
            "Ps3nsnsm",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=ednina sklon=imenovalnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=neuter Number=singular Case=nominative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3nsnsf",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=ednina sklon=imenovalnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=neuter Number=singular Case=nominative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3nsnsn",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=ednina sklon=imenovalnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=neuter Number=singular Case=nominative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3nsnd",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=ednina sklon=imenovalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=singular Case=nominative Owner_Number=dual");
        InsertMsd(
            "Ps3nsnp",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=ednina sklon=imenovalnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=singular Case=nominative Owner_Number=plural");
        InsertMsd(
            "Ps3nsgsm",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=ednina sklon=rodilnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=neuter Number=singular Case=genitive Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3nsgsf",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=ednina sklon=rodilnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=neuter Number=singular Case=genitive Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3nsgsn",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=ednina sklon=rodilnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=neuter Number=singular Case=genitive Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3nsgd",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=ednina sklon=rodilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=singular Case=genitive Owner_Number=dual");
        InsertMsd(
            "Ps3nsgp",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=ednina sklon=rodilnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=singular Case=genitive Owner_Number=plural");
        InsertMsd(
            "Ps3nsdsm",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=ednina sklon=dajalnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=neuter Number=singular Case=dative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3nsdsf",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=ednina sklon=dajalnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=neuter Number=singular Case=dative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3nsdsn",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=ednina sklon=dajalnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=neuter Number=singular Case=dative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3nsdd",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=ednina sklon=dajalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=singular Case=dative Owner_Number=dual");
        InsertMsd(
            "Ps3nsdp",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=ednina sklon=dajalnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=singular Case=dative Owner_Number=plural");
        InsertMsd(
            "Ps3nsasm",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=ednina sklon=tožilnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=neuter Number=singular Case=accusative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3nsasf",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=ednina sklon=tožilnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=neuter Number=singular Case=accusative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3nsasn",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=ednina sklon=tožilnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=neuter Number=singular Case=accusative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3nsad",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=ednina sklon=tožilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=singular Case=accusative Owner_Number=dual");
        InsertMsd(
            "Ps3nsap",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=ednina sklon=tožilnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=singular Case=accusative Owner_Number=plural");
        InsertMsd(
            "Ps3nslsm",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=ednina sklon=mestnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=neuter Number=singular Case=locative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3nslsf",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=ednina sklon=mestnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=neuter Number=singular Case=locative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3nslsn",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=ednina sklon=mestnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=neuter Number=singular Case=locative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3nsld",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=ednina sklon=mestnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=singular Case=locative Owner_Number=dual");
        InsertMsd(
            "Ps3nslp",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=ednina sklon=mestnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=singular Case=locative Owner_Number=plural");
        InsertMsd(
            "Ps3nsism",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=ednina sklon=orodnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=neuter Number=singular Case=instrumental Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3nsisf",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=ednina sklon=orodnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=neuter Number=singular Case=instrumental Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3nsisn",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=ednina sklon=orodnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=neuter Number=singular Case=instrumental Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3nsid",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=ednina sklon=orodnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=singular Case=instrumental Owner_Number=dual");
        InsertMsd(
            "Ps3nsip",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=ednina sklon=orodnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=singular Case=instrumental Owner_Number=plural");
        InsertMsd(
            "Ps3ndnsm",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=dvojina sklon=imenovalnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=neuter Number=dual Case=nominative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3ndnsf",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=dvojina sklon=imenovalnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=neuter Number=dual Case=nominative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3ndnsn",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=dvojina sklon=imenovalnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=neuter Number=dual Case=nominative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3ndnd",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=dvojina sklon=imenovalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=dual Case=nominative Owner_Number=dual");
        InsertMsd(
            "Ps3ndnp",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=dvojina sklon=imenovalnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=dual Case=nominative Owner_Number=plural");
        InsertMsd(
            "Ps3ndgsm",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=dvojina sklon=rodilnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=neuter Number=dual Case=genitive Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3ndgsf",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=dvojina sklon=rodilnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=neuter Number=dual Case=genitive Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3ndgsn",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=dvojina sklon=rodilnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=neuter Number=dual Case=genitive Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3ndgd",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=dvojina sklon=rodilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=dual Case=genitive Owner_Number=dual");
        InsertMsd(
            "Ps3ndgp",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=dvojina sklon=rodilnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=dual Case=genitive Owner_Number=plural");
        InsertMsd(
            "Ps3nddsm",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=dvojina sklon=dajalnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=neuter Number=dual Case=dative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3nddsf",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=dvojina sklon=dajalnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=neuter Number=dual Case=dative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3nddsn",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=dvojina sklon=dajalnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=neuter Number=dual Case=dative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3nddd",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=dvojina sklon=dajalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=dual Case=dative Owner_Number=dual");
        InsertMsd(
            "Ps3nddp",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=dvojina sklon=dajalnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=dual Case=dative Owner_Number=plural");
        InsertMsd(
            "Ps3ndasm",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=dvojina sklon=tožilnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=neuter Number=dual Case=accusative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3ndasf",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=dvojina sklon=tožilnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=neuter Number=dual Case=accusative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3ndasn",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=dvojina sklon=tožilnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=neuter Number=dual Case=accusative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3ndad",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=dvojina sklon=tožilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=dual Case=accusative Owner_Number=dual");
        InsertMsd(
            "Ps3ndap",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=dvojina sklon=tožilnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=dual Case=accusative Owner_Number=plural");
        InsertMsd(
            "Ps3ndlsm",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=dvojina sklon=mestnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=neuter Number=dual Case=locative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3ndlsf",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=dvojina sklon=mestnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=neuter Number=dual Case=locative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3ndlsn",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=dvojina sklon=mestnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=neuter Number=dual Case=locative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3ndld",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=dvojina sklon=mestnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=dual Case=locative Owner_Number=dual");
        InsertMsd(
            "Ps3ndlp",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=dvojina sklon=mestnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=dual Case=locative Owner_Number=plural");
        InsertMsd(
            "Ps3ndism",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=dvojina sklon=orodnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=neuter Number=dual Case=instrumental Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3ndisf",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=dvojina sklon=orodnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=neuter Number=dual Case=instrumental Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3ndisn",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=dvojina sklon=orodnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=neuter Number=dual Case=instrumental Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3ndid",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=dvojina sklon=orodnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=dual Case=instrumental Owner_Number=dual");
        InsertMsd(
            "Ps3ndip",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=dvojina sklon=orodnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=dual Case=instrumental Owner_Number=plural");
        InsertMsd(
            "Ps3npnsm",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=množina sklon=imenovalnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=neuter Number=plural Case=nominative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3npnsf",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=množina sklon=imenovalnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=neuter Number=plural Case=nominative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3npnsn",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=množina sklon=imenovalnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=neuter Number=plural Case=nominative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3npnd",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=množina sklon=imenovalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=plural Case=nominative Owner_Number=dual");
        InsertMsd(
            "Ps3npnp",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=množina sklon=imenovalnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=plural Case=nominative Owner_Number=plural");
        InsertMsd(
            "Ps3npgsm",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=množina sklon=rodilnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=neuter Number=plural Case=genitive Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3npgsf",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=množina sklon=rodilnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=neuter Number=plural Case=genitive Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3npgsn",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=množina sklon=rodilnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=neuter Number=plural Case=genitive Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3npgd",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=množina sklon=rodilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=plural Case=genitive Owner_Number=dual");
        InsertMsd(
            "Ps3npgp",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=množina sklon=rodilnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=plural Case=genitive Owner_Number=plural");
        InsertMsd(
            "Ps3npdsm",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=množina sklon=dajalnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=neuter Number=plural Case=dative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3npdsf",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=množina sklon=dajalnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=neuter Number=plural Case=dative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3npdsn",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=množina sklon=dajalnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=neuter Number=plural Case=dative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3npdd",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=množina sklon=dajalnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=plural Case=dative Owner_Number=dual");
        InsertMsd(
            "Ps3npdp",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=množina sklon=dajalnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=plural Case=dative Owner_Number=plural");
        InsertMsd(
            "Ps3npasm",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=množina sklon=tožilnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=neuter Number=plural Case=accusative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3npasf",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=množina sklon=tožilnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=neuter Number=plural Case=accusative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3npasn",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=množina sklon=tožilnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=neuter Number=plural Case=accusative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3npad",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=množina sklon=tožilnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=plural Case=accusative Owner_Number=dual");
        InsertMsd(
            "Ps3npap",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=množina sklon=tožilnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=plural Case=accusative Owner_Number=plural");
        InsertMsd(
            "Ps3nplsm",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=množina sklon=mestnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=neuter Number=plural Case=locative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3nplsf",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=množina sklon=mestnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=neuter Number=plural Case=locative Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3nplsn",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=množina sklon=mestnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=neuter Number=plural Case=locative Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3npld",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=množina sklon=mestnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=plural Case=locative Owner_Number=dual");
        InsertMsd(
            "Ps3nplp",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=množina sklon=mestnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=plural Case=locative Owner_Number=plural");
        InsertMsd(
            "Ps3npism",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=množina sklon=orodnik število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=possessive Person=third Gender=neuter Number=plural Case=instrumental Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Ps3npisf",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=množina sklon=orodnik število_svojine=ednina spol_svojine=ženski",
            "Pronoun Type=possessive Person=third Gender=neuter Number=plural Case=instrumental Owner_Number=singular Owner_Gender=feminine");
        InsertMsd(
            "Ps3npisn",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=množina sklon=orodnik število_svojine=ednina spol_svojine=srednji",
            "Pronoun Type=possessive Person=third Gender=neuter Number=plural Case=instrumental Owner_Number=singular Owner_Gender=neuter");
        InsertMsd(
            "Ps3npid",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=množina sklon=orodnik število_svojine=dvojina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=plural Case=instrumental Owner_Number=dual");
        InsertMsd(
            "Ps3npip",
            "zaimek vrsta=svojilni oseba=tretja spol=srednji število=množina sklon=orodnik število_svojine=množina",
            "Pronoun Type=possessive Person=third Gender=neuter Number=plural Case=instrumental Owner_Number=plural");
        InsertMsd(
            "Pd-msn",
            "zaimek vrsta=kazalni spol=moški število=ednina sklon=imenovalnik",
            "Pronoun Type=demonstrative Gender=masculine Number=singular Case=nominative");
        InsertMsd(
            "Pd-msg",
            "zaimek vrsta=kazalni spol=moški število=ednina sklon=rodilnik",
            "Pronoun Type=demonstrative Gender=masculine Number=singular Case=genitive");
        InsertMsd(
            "Pd-msd",
            "zaimek vrsta=kazalni spol=moški število=ednina sklon=dajalnik",
            "Pronoun Type=demonstrative Gender=masculine Number=singular Case=dative");
        InsertMsd(
            "Pd-msa",
            "zaimek vrsta=kazalni spol=moški število=ednina sklon=tožilnik",
            "Pronoun Type=demonstrative Gender=masculine Number=singular Case=accusative");
        InsertMsd(
            "Pd-msl",
            "zaimek vrsta=kazalni spol=moški število=ednina sklon=mestnik",
            "Pronoun Type=demonstrative Gender=masculine Number=singular Case=locative");
        InsertMsd(
            "Pd-msi",
            "zaimek vrsta=kazalni spol=moški število=ednina sklon=orodnik",
            "Pronoun Type=demonstrative Gender=masculine Number=singular Case=instrumental");
        InsertMsd(
            "Pd-mdn",
            "zaimek vrsta=kazalni spol=moški število=dvojina sklon=imenovalnik",
            "Pronoun Type=demonstrative Gender=masculine Number=dual Case=nominative");
        InsertMsd(
            "Pd-mdg",
            "zaimek vrsta=kazalni spol=moški število=dvojina sklon=rodilnik",
            "Pronoun Type=demonstrative Gender=masculine Number=dual Case=genitive");
        InsertMsd(
            "Pd-mdd",
            "zaimek vrsta=kazalni spol=moški število=dvojina sklon=dajalnik",
            "Pronoun Type=demonstrative Gender=masculine Number=dual Case=dative");
        InsertMsd(
            "Pd-mda",
            "zaimek vrsta=kazalni spol=moški število=dvojina sklon=tožilnik",
            "Pronoun Type=demonstrative Gender=masculine Number=dual Case=accusative");
        InsertMsd(
            "Pd-mdl",
            "zaimek vrsta=kazalni spol=moški število=dvojina sklon=mestnik",
            "Pronoun Type=demonstrative Gender=masculine Number=dual Case=locative");
        InsertMsd(
            "Pd-mdi",
            "zaimek vrsta=kazalni spol=moški število=dvojina sklon=orodnik",
            "Pronoun Type=demonstrative Gender=masculine Number=dual Case=instrumental");
        InsertMsd(
            "Pd-mpn",
            "zaimek vrsta=kazalni spol=moški število=množina sklon=imenovalnik",
            "Pronoun Type=demonstrative Gender=masculine Number=plural Case=nominative");
        InsertMsd(
            "Pd-mpg",
            "zaimek vrsta=kazalni spol=moški število=množina sklon=rodilnik",
            "Pronoun Type=demonstrative Gender=masculine Number=plural Case=genitive");
        InsertMsd(
            "Pd-mpd",
            "zaimek vrsta=kazalni spol=moški število=množina sklon=dajalnik",
            "Pronoun Type=demonstrative Gender=masculine Number=plural Case=dative");
        InsertMsd(
            "Pd-mpa",
            "zaimek vrsta=kazalni spol=moški število=množina sklon=tožilnik",
            "Pronoun Type=demonstrative Gender=masculine Number=plural Case=accusative");
        InsertMsd(
            "Pd-mpl",
            "zaimek vrsta=kazalni spol=moški število=množina sklon=mestnik",
            "Pronoun Type=demonstrative Gender=masculine Number=plural Case=locative");
        InsertMsd(
            "Pd-mpi",
            "zaimek vrsta=kazalni spol=moški število=množina sklon=orodnik",
            "Pronoun Type=demonstrative Gender=masculine Number=plural Case=instrumental");
        InsertMsd(
            "Pd-fsn",
            "zaimek vrsta=kazalni spol=ženski število=ednina sklon=imenovalnik",
            "Pronoun Type=demonstrative Gender=feminine Number=singular Case=nominative");
        InsertMsd(
            "Pd-fsg",
            "zaimek vrsta=kazalni spol=ženski število=ednina sklon=rodilnik",
            "Pronoun Type=demonstrative Gender=feminine Number=singular Case=genitive");
        InsertMsd(
            "Pd-fsd",
            "zaimek vrsta=kazalni spol=ženski število=ednina sklon=dajalnik",
            "Pronoun Type=demonstrative Gender=feminine Number=singular Case=dative");
        InsertMsd(
            "Pd-fsa",
            "zaimek vrsta=kazalni spol=ženski število=ednina sklon=tožilnik",
            "Pronoun Type=demonstrative Gender=feminine Number=singular Case=accusative");
        InsertMsd(
            "Pd-fsl",
            "zaimek vrsta=kazalni spol=ženski število=ednina sklon=mestnik",
            "Pronoun Type=demonstrative Gender=feminine Number=singular Case=locative");
        InsertMsd(
            "Pd-fsi",
            "zaimek vrsta=kazalni spol=ženski število=ednina sklon=orodnik",
            "Pronoun Type=demonstrative Gender=feminine Number=singular Case=instrumental");
        InsertMsd(
            "Pd-fdn",
            "zaimek vrsta=kazalni spol=ženski število=dvojina sklon=imenovalnik",
            "Pronoun Type=demonstrative Gender=feminine Number=dual Case=nominative");
        InsertMsd(
            "Pd-fdg",
            "zaimek vrsta=kazalni spol=ženski število=dvojina sklon=rodilnik",
            "Pronoun Type=demonstrative Gender=feminine Number=dual Case=genitive");
        InsertMsd(
            "Pd-fdd",
            "zaimek vrsta=kazalni spol=ženski število=dvojina sklon=dajalnik",
            "Pronoun Type=demonstrative Gender=feminine Number=dual Case=dative");
        InsertMsd(
            "Pd-fda",
            "zaimek vrsta=kazalni spol=ženski število=dvojina sklon=tožilnik",
            "Pronoun Type=demonstrative Gender=feminine Number=dual Case=accusative");
        InsertMsd(
            "Pd-fdl",
            "zaimek vrsta=kazalni spol=ženski število=dvojina sklon=mestnik",
            "Pronoun Type=demonstrative Gender=feminine Number=dual Case=locative");
        InsertMsd(
            "Pd-fdi",
            "zaimek vrsta=kazalni spol=ženski število=dvojina sklon=orodnik",
            "Pronoun Type=demonstrative Gender=feminine Number=dual Case=instrumental");
        InsertMsd(
            "Pd-fpn",
            "zaimek vrsta=kazalni spol=ženski število=množina sklon=imenovalnik",
            "Pronoun Type=demonstrative Gender=feminine Number=plural Case=nominative");
        InsertMsd(
            "Pd-fpg",
            "zaimek vrsta=kazalni spol=ženski število=množina sklon=rodilnik",
            "Pronoun Type=demonstrative Gender=feminine Number=plural Case=genitive");
        InsertMsd(
            "Pd-fpd",
            "zaimek vrsta=kazalni spol=ženski število=množina sklon=dajalnik",
            "Pronoun Type=demonstrative Gender=feminine Number=plural Case=dative");
        InsertMsd(
            "Pd-fpa",
            "zaimek vrsta=kazalni spol=ženski število=množina sklon=tožilnik",
            "Pronoun Type=demonstrative Gender=feminine Number=plural Case=accusative");
        InsertMsd(
            "Pd-fpl",
            "zaimek vrsta=kazalni spol=ženski število=množina sklon=mestnik",
            "Pronoun Type=demonstrative Gender=feminine Number=plural Case=locative");
        InsertMsd(
            "Pd-fpi",
            "zaimek vrsta=kazalni spol=ženski število=množina sklon=orodnik",
            "Pronoun Type=demonstrative Gender=feminine Number=plural Case=instrumental");
        InsertMsd(
            "Pd-nsn",
            "zaimek vrsta=kazalni spol=srednji število=ednina sklon=imenovalnik",
            "Pronoun Type=demonstrative Gender=neuter Number=singular Case=nominative");
        InsertMsd(
            "Pd-nsg",
            "zaimek vrsta=kazalni spol=srednji število=ednina sklon=rodilnik",
            "Pronoun Type=demonstrative Gender=neuter Number=singular Case=genitive");
        InsertMsd(
            "Pd-nsd",
            "zaimek vrsta=kazalni spol=srednji število=ednina sklon=dajalnik",
            "Pronoun Type=demonstrative Gender=neuter Number=singular Case=dative");
        InsertMsd(
            "Pd-nsa",
            "zaimek vrsta=kazalni spol=srednji število=ednina sklon=tožilnik",
            "Pronoun Type=demonstrative Gender=neuter Number=singular Case=accusative");
        InsertMsd(
            "Pd-nsl",
            "zaimek vrsta=kazalni spol=srednji število=ednina sklon=mestnik",
            "Pronoun Type=demonstrative Gender=neuter Number=singular Case=locative");
        InsertMsd(
            "Pd-nsi",
            "zaimek vrsta=kazalni spol=srednji število=ednina sklon=orodnik",
            "Pronoun Type=demonstrative Gender=neuter Number=singular Case=instrumental");
        InsertMsd(
            "Pd-ndn",
            "zaimek vrsta=kazalni spol=srednji število=dvojina sklon=imenovalnik",
            "Pronoun Type=demonstrative Gender=neuter Number=dual Case=nominative");
        InsertMsd(
            "Pd-ndg",
            "zaimek vrsta=kazalni spol=srednji število=dvojina sklon=rodilnik",
            "Pronoun Type=demonstrative Gender=neuter Number=dual Case=genitive");
        InsertMsd(
            "Pd-ndd",
            "zaimek vrsta=kazalni spol=srednji število=dvojina sklon=dajalnik",
            "Pronoun Type=demonstrative Gender=neuter Number=dual Case=dative");
        InsertMsd(
            "Pd-nda",
            "zaimek vrsta=kazalni spol=srednji število=dvojina sklon=tožilnik",
            "Pronoun Type=demonstrative Gender=neuter Number=dual Case=accusative");
        InsertMsd(
            "Pd-ndl",
            "zaimek vrsta=kazalni spol=srednji število=dvojina sklon=mestnik",
            "Pronoun Type=demonstrative Gender=neuter Number=dual Case=locative");
        InsertMsd(
            "Pd-ndi",
            "zaimek vrsta=kazalni spol=srednji število=dvojina sklon=orodnik",
            "Pronoun Type=demonstrative Gender=neuter Number=dual Case=instrumental");
        InsertMsd(
            "Pd-npn",
            "zaimek vrsta=kazalni spol=srednji število=množina sklon=imenovalnik",
            "Pronoun Type=demonstrative Gender=neuter Number=plural Case=nominative");
        InsertMsd(
            "Pd-npg",
            "zaimek vrsta=kazalni spol=srednji število=množina sklon=rodilnik",
            "Pronoun Type=demonstrative Gender=neuter Number=plural Case=genitive");
        InsertMsd(
            "Pd-npd",
            "zaimek vrsta=kazalni spol=srednji število=množina sklon=dajalnik",
            "Pronoun Type=demonstrative Gender=neuter Number=plural Case=dative");
        InsertMsd(
            "Pd-npa",
            "zaimek vrsta=kazalni spol=srednji število=množina sklon=tožilnik",
            "Pronoun Type=demonstrative Gender=neuter Number=plural Case=accusative");
        InsertMsd(
            "Pd-npl",
            "zaimek vrsta=kazalni spol=srednji število=množina sklon=mestnik",
            "Pronoun Type=demonstrative Gender=neuter Number=plural Case=locative");
        InsertMsd(
            "Pd-npi",
            "zaimek vrsta=kazalni spol=srednji število=množina sklon=orodnik",
            "Pronoun Type=demonstrative Gender=neuter Number=plural Case=instrumental");
        InsertMsd("Pr", "zaimek vrsta=oziralni", "Pronoun Type=relative");
        InsertMsd(
            "Pr----sm",
            "zaimek vrsta=oziralni število_svojine=ednina spol_svojine=moški",
            "Pronoun Type=relative Owner_Number=singular Owner_Gender=masculine");
        InsertMsd(
            "Pr-msn",
            "zaimek vrsta=oziralni spol=moški število=ednina sklon=imenovalnik",
            "Pronoun Type=relative Gender=masculine Number=singular Case=nominative");
        InsertMsd(
            "Pr-msg",
            "zaimek vrsta=oziralni spol=moški število=ednina sklon=rodilnik",
            "Pronoun Type=relative Gender=masculine Number=singular Case=genitive");
        InsertMsd(
            "Pr-msd",
            "zaimek vrsta=oziralni spol=moški število=ednina sklon=dajalnik",
            "Pronoun Type=relative Gender=masculine Number=singular Case=dative");
        InsertMsd(
            "Pr-msa",
            "zaimek vrsta=oziralni spol=moški število=ednina sklon=tožilnik",
            "Pronoun Type=relative Gender=masculine Number=singular Case=accusative");
        InsertMsd(
            "Pr-msl",
            "zaimek vrsta=oziralni spol=moški število=ednina sklon=mestnik",
            "Pronoun Type=relative Gender=masculine Number=singular Case=locative");
        InsertMsd(
            "Pr-msi",
            "zaimek vrsta=oziralni spol=moški število=ednina sklon=orodnik",
            "Pronoun Type=relative Gender=masculine Number=singular Case=instrumental");
        InsertMsd(
            "Pr-mdn",
            "zaimek vrsta=oziralni spol=moški število=dvojina sklon=imenovalnik",
            "Pronoun Type=relative Gender=masculine Number=dual Case=nominative");
        InsertMsd(
            "Pr-mdg",
            "zaimek vrsta=oziralni spol=moški število=dvojina sklon=rodilnik",
            "Pronoun Type=relative Gender=masculine Number=dual Case=genitive");
        InsertMsd(
            "Pr-mdd",
            "zaimek vrsta=oziralni spol=moški število=dvojina sklon=dajalnik",
            "Pronoun Type=relative Gender=masculine Number=dual Case=dative");
        InsertMsd(
            "Pr-mda",
            "zaimek vrsta=oziralni spol=moški število=dvojina sklon=tožilnik",
            "Pronoun Type=relative Gender=masculine Number=dual Case=accusative");
        InsertMsd(
            "Pr-mdl",
            "zaimek vrsta=oziralni spol=moški število=dvojina sklon=mestnik",
            "Pronoun Type=relative Gender=masculine Number=dual Case=locative");
        InsertMsd(
            "Pr-mdi",
            "zaimek vrsta=oziralni spol=moški število=dvojina sklon=orodnik",
            "Pronoun Type=relative Gender=masculine Number=dual Case=instrumental");
        InsertMsd(
            "Pr-mpn",
            "zaimek vrsta=oziralni spol=moški število=množina sklon=imenovalnik",
            "Pronoun Type=relative Gender=masculine Number=plural Case=nominative");
        InsertMsd(
            "Pr-mpg",
            "zaimek vrsta=oziralni spol=moški število=množina sklon=rodilnik",
            "Pronoun Type=relative Gender=masculine Number=plural Case=genitive");
        InsertMsd(
            "Pr-mpd",
            "zaimek vrsta=oziralni spol=moški število=množina sklon=dajalnik",
            "Pronoun Type=relative Gender=masculine Number=plural Case=dative");
        InsertMsd(
            "Pr-mpa",
            "zaimek vrsta=oziralni spol=moški število=množina sklon=tožilnik",
            "Pronoun Type=relative Gender=masculine Number=plural Case=accusative");
        InsertMsd(
            "Pr-mpl",
            "zaimek vrsta=oziralni spol=moški število=množina sklon=mestnik",
            "Pronoun Type=relative Gender=masculine Number=plural Case=locative");
        InsertMsd(
            "Pr-mpi",
            "zaimek vrsta=oziralni spol=moški število=množina sklon=orodnik",
            "Pronoun Type=relative Gender=masculine Number=plural Case=instrumental");
        InsertMsd(
            "Pr-fsn",
            "zaimek vrsta=oziralni spol=ženski število=ednina sklon=imenovalnik",
            "Pronoun Type=relative Gender=feminine Number=singular Case=nominative");
        InsertMsd(
            "Pr-fsg",
            "zaimek vrsta=oziralni spol=ženski število=ednina sklon=rodilnik",
            "Pronoun Type=relative Gender=feminine Number=singular Case=genitive");
        InsertMsd(
            "Pr-fsd",
            "zaimek vrsta=oziralni spol=ženski število=ednina sklon=dajalnik",
            "Pronoun Type=relative Gender=feminine Number=singular Case=dative");
        InsertMsd(
            "Pr-fsa",
            "zaimek vrsta=oziralni spol=ženski število=ednina sklon=tožilnik",
            "Pronoun Type=relative Gender=feminine Number=singular Case=accusative");
        InsertMsd(
            "Pr-fsl",
            "zaimek vrsta=oziralni spol=ženski število=ednina sklon=mestnik",
            "Pronoun Type=relative Gender=feminine Number=singular Case=locative");
        InsertMsd(
            "Pr-fsi",
            "zaimek vrsta=oziralni spol=ženski število=ednina sklon=orodnik",
            "Pronoun Type=relative Gender=feminine Number=singular Case=instrumental");
        InsertMsd(
            "Pr-fdn",
            "zaimek vrsta=oziralni spol=ženski število=dvojina sklon=imenovalnik",
            "Pronoun Type=relative Gender=feminine Number=dual Case=nominative");
        InsertMsd(
            "Pr-fdg",
            "zaimek vrsta=oziralni spol=ženski število=dvojina sklon=rodilnik",
            "Pronoun Type=relative Gender=feminine Number=dual Case=genitive");
        InsertMsd(
            "Pr-fdd",
            "zaimek vrsta=oziralni spol=ženski število=dvojina sklon=dajalnik",
            "Pronoun Type=relative Gender=feminine Number=dual Case=dative");
        InsertMsd(
            "Pr-fda",
            "zaimek vrsta=oziralni spol=ženski število=dvojina sklon=tožilnik",
            "Pronoun Type=relative Gender=feminine Number=dual Case=accusative");
        InsertMsd(
            "Pr-fdl",
            "zaimek vrsta=oziralni spol=ženski število=dvojina sklon=mestnik",
            "Pronoun Type=relative Gender=feminine Number=dual Case=locative");
        InsertMsd(
            "Pr-fdi",
            "zaimek vrsta=oziralni spol=ženski število=dvojina sklon=orodnik",
            "Pronoun Type=relative Gender=feminine Number=dual Case=instrumental");
        InsertMsd(
            "Pr-fpn",
            "zaimek vrsta=oziralni spol=ženski število=množina sklon=imenovalnik",
            "Pronoun Type=relative Gender=feminine Number=plural Case=nominative");
        InsertMsd(
            "Pr-fpg",
            "zaimek vrsta=oziralni spol=ženski število=množina sklon=rodilnik",
            "Pronoun Type=relative Gender=feminine Number=plural Case=genitive");
        InsertMsd(
            "Pr-fpd",
            "zaimek vrsta=oziralni spol=ženski število=množina sklon=dajalnik",
            "Pronoun Type=relative Gender=feminine Number=plural Case=dative");
        InsertMsd(
            "Pr-fpa",
            "zaimek vrsta=oziralni spol=ženski število=množina sklon=tožilnik",
            "Pronoun Type=relative Gender=feminine Number=plural Case=accusative");
        InsertMsd(
            "Pr-fpl",
            "zaimek vrsta=oziralni spol=ženski število=množina sklon=mestnik",
            "Pronoun Type=relative Gender=feminine Number=plural Case=locative");
        InsertMsd(
            "Pr-fpi",
            "zaimek vrsta=oziralni spol=ženski število=množina sklon=orodnik",
            "Pronoun Type=relative Gender=feminine Number=plural Case=instrumental");
        InsertMsd(
            "Pr-nsn",
            "zaimek vrsta=oziralni spol=srednji število=ednina sklon=imenovalnik",
            "Pronoun Type=relative Gender=neuter Number=singular Case=nominative");
        InsertMsd(
            "Pr-nsg",
            "zaimek vrsta=oziralni spol=srednji število=ednina sklon=rodilnik",
            "Pronoun Type=relative Gender=neuter Number=singular Case=genitive");
        InsertMsd(
            "Pr-nsd",
            "zaimek vrsta=oziralni spol=srednji število=ednina sklon=dajalnik",
            "Pronoun Type=relative Gender=neuter Number=singular Case=dative");
        InsertMsd(
            "Pr-nsa",
            "zaimek vrsta=oziralni spol=srednji število=ednina sklon=tožilnik",
            "Pronoun Type=relative Gender=neuter Number=singular Case=accusative");
        InsertMsd(
            "Pr-nsl",
            "zaimek vrsta=oziralni spol=srednji število=ednina sklon=mestnik",
            "Pronoun Type=relative Gender=neuter Number=singular Case=locative");
        InsertMsd(
            "Pr-nsi",
            "zaimek vrsta=oziralni spol=srednji število=ednina sklon=orodnik",
            "Pronoun Type=relative Gender=neuter Number=singular Case=instrumental");
        InsertMsd(
            "Pr-ndn",
            "zaimek vrsta=oziralni spol=srednji število=dvojina sklon=imenovalnik",
            "Pronoun Type=relative Gender=neuter Number=dual Case=nominative");
        InsertMsd(
            "Pr-ndg",
            "zaimek vrsta=oziralni spol=srednji število=dvojina sklon=rodilnik",
            "Pronoun Type=relative Gender=neuter Number=dual Case=genitive");
        InsertMsd("Pr-ndd", "zaimek vrsta=oziralni spol=srednji število=dvojina sklon=dajalnik", "Pronoun Type=relative Gender=neuter Number=dual Case=dative");
        InsertMsd(
            "Pr-nda",
            "zaimek vrsta=oziralni spol=srednji število=dvojina sklon=tožilnik",
            "Pronoun Type=relative Gender=neuter Number=dual Case=accusative");
        InsertMsd(
            "Pr-ndl",
            "zaimek vrsta=oziralni spol=srednji število=dvojina sklon=mestnik",
            "Pronoun Type=relative Gender=neuter Number=dual Case=locative");
        InsertMsd(
            "Pr-ndi",
            "zaimek vrsta=oziralni spol=srednji število=dvojina sklon=orodnik",
            "Pronoun Type=relative Gender=neuter Number=dual Case=instrumental");
        InsertMsd(
            "Pr-npn",
            "zaimek vrsta=oziralni spol=srednji število=množina sklon=imenovalnik",
            "Pronoun Type=relative Gender=neuter Number=plural Case=nominative");
        InsertMsd(
            "Pr-npg",
            "zaimek vrsta=oziralni spol=srednji število=množina sklon=rodilnik",
            "Pronoun Type=relative Gender=neuter Number=plural Case=genitive");
        InsertMsd(
            "Pr-npd",
            "zaimek vrsta=oziralni spol=srednji število=množina sklon=dajalnik",
            "Pronoun Type=relative Gender=neuter Number=plural Case=dative");
        InsertMsd(
            "Pr-npa",
            "zaimek vrsta=oziralni spol=srednji število=množina sklon=tožilnik",
            "Pronoun Type=relative Gender=neuter Number=plural Case=accusative");
        InsertMsd(
            "Pr-npl",
            "zaimek vrsta=oziralni spol=srednji število=množina sklon=mestnik",
            "Pronoun Type=relative Gender=neuter Number=plural Case=locative");
        InsertMsd(
            "Pr-npi",
            "zaimek vrsta=oziralni spol=srednji število=množina sklon=orodnik",
            "Pronoun Type=relative Gender=neuter Number=plural Case=instrumental");
        InsertMsd("Px------y", "zaimek vrsta=povratni naslonskost=kliticna", "Pronoun Type=reflexive Clitic=yes");
        InsertMsd("Px---g", "zaimek vrsta=povratni sklon=rodilnik", "Pronoun Type=reflexive Case=genitive");
        InsertMsd("Px---d", "zaimek vrsta=povratni sklon=dajalnik", "Pronoun Type=reflexive Case=dative");
        InsertMsd("Px---d--y", "zaimek vrsta=povratni sklon=dajalnik naslonskost=kliticna", "Pronoun Type=reflexive Case=dative Clitic=yes");
        InsertMsd("Px---a", "zaimek vrsta=povratni sklon=tožilnik", "Pronoun Type=reflexive Case=accusative");
        InsertMsd("Px---a--b", "zaimek vrsta=povratni sklon=tožilnik naslonskost=navezna", "Pronoun Type=reflexive Case=accusative Clitic=bound");
        InsertMsd("Px---l", "zaimek vrsta=povratni sklon=mestnik", "Pronoun Type=reflexive Case=locative");
        InsertMsd("Px---i", "zaimek vrsta=povratni sklon=orodnik", "Pronoun Type=reflexive Case=instrumental");
        InsertMsd(
            "Px-msn",
            "zaimek vrsta=povratni spol=moški število=ednina sklon=imenovalnik",
            "Pronoun Type=reflexive Gender=masculine Number=singular Case=nominative");
        InsertMsd(
            "Px-msg",
            "zaimek vrsta=povratni spol=moški število=ednina sklon=rodilnik",
            "Pronoun Type=reflexive Gender=masculine Number=singular Case=genitive");
        InsertMsd(
            "Px-msd",
            "zaimek vrsta=povratni spol=moški število=ednina sklon=dajalnik",
            "Pronoun Type=reflexive Gender=masculine Number=singular Case=dative");
        InsertMsd(
            "Px-msa",
            "zaimek vrsta=povratni spol=moški število=ednina sklon=tožilnik",
            "Pronoun Type=reflexive Gender=masculine Number=singular Case=accusative");
        InsertMsd(
            "Px-msl",
            "zaimek vrsta=povratni spol=moški število=ednina sklon=mestnik",
            "Pronoun Type=reflexive Gender=masculine Number=singular Case=locative");
        InsertMsd(
            "Px-msi",
            "zaimek vrsta=povratni spol=moški število=ednina sklon=orodnik",
            "Pronoun Type=reflexive Gender=masculine Number=singular Case=instrumental");
        InsertMsd(
            "Px-mdn",
            "zaimek vrsta=povratni spol=moški število=dvojina sklon=imenovalnik",
            "Pronoun Type=reflexive Gender=masculine Number=dual Case=nominative");
        InsertMsd(
            "Px-mdg",
            "zaimek vrsta=povratni spol=moški število=dvojina sklon=rodilnik",
            "Pronoun Type=reflexive Gender=masculine Number=dual Case=genitive");
        InsertMsd(
            "Px-mdd",
            "zaimek vrsta=povratni spol=moški število=dvojina sklon=dajalnik",
            "Pronoun Type=reflexive Gender=masculine Number=dual Case=dative");
        InsertMsd(
            "Px-mda",
            "zaimek vrsta=povratni spol=moški število=dvojina sklon=tožilnik",
            "Pronoun Type=reflexive Gender=masculine Number=dual Case=accusative");
        InsertMsd(
            "Px-mdl",
            "zaimek vrsta=povratni spol=moški število=dvojina sklon=mestnik",
            "Pronoun Type=reflexive Gender=masculine Number=dual Case=locative");
        InsertMsd(
            "Px-mdi",
            "zaimek vrsta=povratni spol=moški število=dvojina sklon=orodnik",
            "Pronoun Type=reflexive Gender=masculine Number=dual Case=instrumental");
        InsertMsd(
            "Px-mpn",
            "zaimek vrsta=povratni spol=moški število=množina sklon=imenovalnik",
            "Pronoun Type=reflexive Gender=masculine Number=plural Case=nominative");
        InsertMsd(
            "Px-mpg",
            "zaimek vrsta=povratni spol=moški število=množina sklon=rodilnik",
            "Pronoun Type=reflexive Gender=masculine Number=plural Case=genitive");
        InsertMsd(
            "Px-mpd",
            "zaimek vrsta=povratni spol=moški število=množina sklon=dajalnik",
            "Pronoun Type=reflexive Gender=masculine Number=plural Case=dative");
        InsertMsd(
            "Px-mpa",
            "zaimek vrsta=povratni spol=moški število=množina sklon=tožilnik",
            "Pronoun Type=reflexive Gender=masculine Number=plural Case=accusative");
        InsertMsd(
            "Px-mpl",
            "zaimek vrsta=povratni spol=moški število=množina sklon=mestnik",
            "Pronoun Type=reflexive Gender=masculine Number=plural Case=locative");
        InsertMsd(
            "Px-mpi",
            "zaimek vrsta=povratni spol=moški število=množina sklon=orodnik",
            "Pronoun Type=reflexive Gender=masculine Number=plural Case=instrumental");
        InsertMsd(
            "Px-fsn",
            "zaimek vrsta=povratni spol=ženski število=ednina sklon=imenovalnik",
            "Pronoun Type=reflexive Gender=feminine Number=singular Case=nominative");
        InsertMsd(
            "Px-fsg",
            "zaimek vrsta=povratni spol=ženski število=ednina sklon=rodilnik",
            "Pronoun Type=reflexive Gender=feminine Number=singular Case=genitive");
        InsertMsd(
            "Px-fsd",
            "zaimek vrsta=povratni spol=ženski število=ednina sklon=dajalnik",
            "Pronoun Type=reflexive Gender=feminine Number=singular Case=dative");
        InsertMsd(
            "Px-fsa",
            "zaimek vrsta=povratni spol=ženski število=ednina sklon=tožilnik",
            "Pronoun Type=reflexive Gender=feminine Number=singular Case=accusative");
        InsertMsd(
            "Px-fsl",
            "zaimek vrsta=povratni spol=ženski število=ednina sklon=mestnik",
            "Pronoun Type=reflexive Gender=feminine Number=singular Case=locative");
        InsertMsd(
            "Px-fsi",
            "zaimek vrsta=povratni spol=ženski število=ednina sklon=orodnik",
            "Pronoun Type=reflexive Gender=feminine Number=singular Case=instrumental");
        InsertMsd(
            "Px-fdn",
            "zaimek vrsta=povratni spol=ženski število=dvojina sklon=imenovalnik",
            "Pronoun Type=reflexive Gender=feminine Number=dual Case=nominative");
        InsertMsd(
            "Px-fdg",
            "zaimek vrsta=povratni spol=ženski število=dvojina sklon=rodilnik",
            "Pronoun Type=reflexive Gender=feminine Number=dual Case=genitive");
        InsertMsd(
            "Px-fdd",
            "zaimek vrsta=povratni spol=ženski število=dvojina sklon=dajalnik",
            "Pronoun Type=reflexive Gender=feminine Number=dual Case=dative");
        InsertMsd(
            "Px-fda",
            "zaimek vrsta=povratni spol=ženski število=dvojina sklon=tožilnik",
            "Pronoun Type=reflexive Gender=feminine Number=dual Case=accusative");
        InsertMsd(
            "Px-fdl",
            "zaimek vrsta=povratni spol=ženski število=dvojina sklon=mestnik",
            "Pronoun Type=reflexive Gender=feminine Number=dual Case=locative");
        InsertMsd(
            "Px-fdi",
            "zaimek vrsta=povratni spol=ženski število=dvojina sklon=orodnik",
            "Pronoun Type=reflexive Gender=feminine Number=dual Case=instrumental");
        InsertMsd(
            "Px-fpn",
            "zaimek vrsta=povratni spol=ženski število=množina sklon=imenovalnik",
            "Pronoun Type=reflexive Gender=feminine Number=plural Case=nominative");
        InsertMsd(
            "Px-fpg",
            "zaimek vrsta=povratni spol=ženski število=množina sklon=rodilnik",
            "Pronoun Type=reflexive Gender=feminine Number=plural Case=genitive");
        InsertMsd(
            "Px-fpd",
            "zaimek vrsta=povratni spol=ženski število=množina sklon=dajalnik",
            "Pronoun Type=reflexive Gender=feminine Number=plural Case=dative");
        InsertMsd(
            "Px-fpa",
            "zaimek vrsta=povratni spol=ženski število=množina sklon=tožilnik",
            "Pronoun Type=reflexive Gender=feminine Number=plural Case=accusative");
        InsertMsd(
            "Px-fpl",
            "zaimek vrsta=povratni spol=ženski število=množina sklon=mestnik",
            "Pronoun Type=reflexive Gender=feminine Number=plural Case=locative");
        InsertMsd(
            "Px-fpi",
            "zaimek vrsta=povratni spol=ženski število=množina sklon=orodnik",
            "Pronoun Type=reflexive Gender=feminine Number=plural Case=instrumental");
        InsertMsd(
            "Px-nsn",
            "zaimek vrsta=povratni spol=srednji število=ednina sklon=imenovalnik",
            "Pronoun Type=reflexive Gender=neuter Number=singular Case=nominative");
        InsertMsd(
            "Px-nsg",
            "zaimek vrsta=povratni spol=srednji število=ednina sklon=rodilnik",
            "Pronoun Type=reflexive Gender=neuter Number=singular Case=genitive");
        InsertMsd(
            "Px-nsd",
            "zaimek vrsta=povratni spol=srednji število=ednina sklon=dajalnik",
            "Pronoun Type=reflexive Gender=neuter Number=singular Case=dative");
        InsertMsd(
            "Px-nsa",
            "zaimek vrsta=povratni spol=srednji število=ednina sklon=tožilnik",
            "Pronoun Type=reflexive Gender=neuter Number=singular Case=accusative");
        InsertMsd(
            "Px-nsl",
            "zaimek vrsta=povratni spol=srednji število=ednina sklon=mestnik",
            "Pronoun Type=reflexive Gender=neuter Number=singular Case=locative");
        InsertMsd(
            "Px-nsi",
            "zaimek vrsta=povratni spol=srednji število=ednina sklon=orodnik",
            "Pronoun Type=reflexive Gender=neuter Number=singular Case=instrumental");
        InsertMsd(
            "Px-ndn",
            "zaimek vrsta=povratni spol=srednji število=dvojina sklon=imenovalnik",
            "Pronoun Type=reflexive Gender=neuter Number=dual Case=nominative");
        InsertMsd(
            "Px-ndg",
            "zaimek vrsta=povratni spol=srednji število=dvojina sklon=rodilnik",
            "Pronoun Type=reflexive Gender=neuter Number=dual Case=genitive");
        InsertMsd(
            "Px-ndd",
            "zaimek vrsta=povratni spol=srednji število=dvojina sklon=dajalnik",
            "Pronoun Type=reflexive Gender=neuter Number=dual Case=dative");
        InsertMsd(
            "Px-nda",
            "zaimek vrsta=povratni spol=srednji število=dvojina sklon=tožilnik",
            "Pronoun Type=reflexive Gender=neuter Number=dual Case=accusative");
        InsertMsd(
            "Px-ndl",
            "zaimek vrsta=povratni spol=srednji število=dvojina sklon=mestnik",
            "Pronoun Type=reflexive Gender=neuter Number=dual Case=locative");
        InsertMsd(
            "Px-ndi",
            "zaimek vrsta=povratni spol=srednji število=dvojina sklon=orodnik",
            "Pronoun Type=reflexive Gender=neuter Number=dual Case=instrumental");
        InsertMsd(
            "Px-npn",
            "zaimek vrsta=povratni spol=srednji število=množina sklon=imenovalnik",
            "Pronoun Type=reflexive Gender=neuter Number=plural Case=nominative");
        InsertMsd(
            "Px-npg",
            "zaimek vrsta=povratni spol=srednji število=množina sklon=rodilnik",
            "Pronoun Type=reflexive Gender=neuter Number=plural Case=genitive");
        InsertMsd(
            "Px-npd",
            "zaimek vrsta=povratni spol=srednji število=množina sklon=dajalnik",
            "Pronoun Type=reflexive Gender=neuter Number=plural Case=dative");
        InsertMsd(
            "Px-npa",
            "zaimek vrsta=povratni spol=srednji število=množina sklon=tožilnik",
            "Pronoun Type=reflexive Gender=neuter Number=plural Case=accusative");
        InsertMsd(
            "Px-npl",
            "zaimek vrsta=povratni spol=srednji število=množina sklon=mestnik",
            "Pronoun Type=reflexive Gender=neuter Number=plural Case=locative");
        InsertMsd(
            "Px-npi",
            "zaimek vrsta=povratni spol=srednji število=množina sklon=orodnik",
            "Pronoun Type=reflexive Gender=neuter Number=plural Case=instrumental");
        InsertMsd(
            "Pg-msn",
            "zaimek vrsta=celostni spol=moški število=ednina sklon=imenovalnik",
            "Pronoun Type=general Gender=masculine Number=singular Case=nominative");
        InsertMsd(
            "Pg-msg",
            "zaimek vrsta=celostni spol=moški število=ednina sklon=rodilnik",
            "Pronoun Type=general Gender=masculine Number=singular Case=genitive");
        InsertMsd(
            "Pg-msd",
            "zaimek vrsta=celostni spol=moški število=ednina sklon=dajalnik",
            "Pronoun Type=general Gender=masculine Number=singular Case=dative");
        InsertMsd(
            "Pg-msa",
            "zaimek vrsta=celostni spol=moški število=ednina sklon=tožilnik",
            "Pronoun Type=general Gender=masculine Number=singular Case=accusative");
        InsertMsd(
            "Pg-msl",
            "zaimek vrsta=celostni spol=moški število=ednina sklon=mestnik",
            "Pronoun Type=general Gender=masculine Number=singular Case=locative");
        InsertMsd(
            "Pg-msi",
            "zaimek vrsta=celostni spol=moški število=ednina sklon=orodnik",
            "Pronoun Type=general Gender=masculine Number=singular Case=instrumental");
        InsertMsd(
            "Pg-mdn",
            "zaimek vrsta=celostni spol=moški število=dvojina sklon=imenovalnik",
            "Pronoun Type=general Gender=masculine Number=dual Case=nominative");
        InsertMsd(
            "Pg-mdg",
            "zaimek vrsta=celostni spol=moški število=dvojina sklon=rodilnik",
            "Pronoun Type=general Gender=masculine Number=dual Case=genitive");
        InsertMsd("Pg-mdd", "zaimek vrsta=celostni spol=moški število=dvojina sklon=dajalnik", "Pronoun Type=general Gender=masculine Number=dual Case=dative");
        InsertMsd(
            "Pg-mda",
            "zaimek vrsta=celostni spol=moški število=dvojina sklon=tožilnik",
            "Pronoun Type=general Gender=masculine Number=dual Case=accusative");
        InsertMsd(
            "Pg-mdl",
            "zaimek vrsta=celostni spol=moški število=dvojina sklon=mestnik",
            "Pronoun Type=general Gender=masculine Number=dual Case=locative");
        InsertMsd(
            "Pg-mdi",
            "zaimek vrsta=celostni spol=moški število=dvojina sklon=orodnik",
            "Pronoun Type=general Gender=masculine Number=dual Case=instrumental");
        InsertMsd(
            "Pg-mpn",
            "zaimek vrsta=celostni spol=moški število=množina sklon=imenovalnik",
            "Pronoun Type=general Gender=masculine Number=plural Case=nominative");
        InsertMsd(
            "Pg-mpg",
            "zaimek vrsta=celostni spol=moški število=množina sklon=rodilnik",
            "Pronoun Type=general Gender=masculine Number=plural Case=genitive");
        InsertMsd(
            "Pg-mpd",
            "zaimek vrsta=celostni spol=moški število=množina sklon=dajalnik",
            "Pronoun Type=general Gender=masculine Number=plural Case=dative");
        InsertMsd(
            "Pg-mpa",
            "zaimek vrsta=celostni spol=moški število=množina sklon=tožilnik",
            "Pronoun Type=general Gender=masculine Number=plural Case=accusative");
        InsertMsd(
            "Pg-mpl",
            "zaimek vrsta=celostni spol=moški število=množina sklon=mestnik",
            "Pronoun Type=general Gender=masculine Number=plural Case=locative");
        InsertMsd(
            "Pg-mpi",
            "zaimek vrsta=celostni spol=moški število=množina sklon=orodnik",
            "Pronoun Type=general Gender=masculine Number=plural Case=instrumental");
        InsertMsd(
            "Pg-fsn",
            "zaimek vrsta=celostni spol=ženski število=ednina sklon=imenovalnik",
            "Pronoun Type=general Gender=feminine Number=singular Case=nominative");
        InsertMsd(
            "Pg-fsg",
            "zaimek vrsta=celostni spol=ženski število=ednina sklon=rodilnik",
            "Pronoun Type=general Gender=feminine Number=singular Case=genitive");
        InsertMsd(
            "Pg-fsd",
            "zaimek vrsta=celostni spol=ženski število=ednina sklon=dajalnik",
            "Pronoun Type=general Gender=feminine Number=singular Case=dative");
        InsertMsd(
            "Pg-fsa",
            "zaimek vrsta=celostni spol=ženski število=ednina sklon=tožilnik",
            "Pronoun Type=general Gender=feminine Number=singular Case=accusative");
        InsertMsd(
            "Pg-fsl",
            "zaimek vrsta=celostni spol=ženski število=ednina sklon=mestnik",
            "Pronoun Type=general Gender=feminine Number=singular Case=locative");
        InsertMsd(
            "Pg-fsi",
            "zaimek vrsta=celostni spol=ženski število=ednina sklon=orodnik",
            "Pronoun Type=general Gender=feminine Number=singular Case=instrumental");
        InsertMsd(
            "Pg-fdn",
            "zaimek vrsta=celostni spol=ženski število=dvojina sklon=imenovalnik",
            "Pronoun Type=general Gender=feminine Number=dual Case=nominative");
        InsertMsd(
            "Pg-fdg",
            "zaimek vrsta=celostni spol=ženski število=dvojina sklon=rodilnik",
            "Pronoun Type=general Gender=feminine Number=dual Case=genitive");
        InsertMsd("Pg-fdd", "zaimek vrsta=celostni spol=ženski število=dvojina sklon=dajalnik", "Pronoun Type=general Gender=feminine Number=dual Case=dative");
        InsertMsd(
            "Pg-fda",
            "zaimek vrsta=celostni spol=ženski število=dvojina sklon=tožilnik",
            "Pronoun Type=general Gender=feminine Number=dual Case=accusative");
        InsertMsd(
            "Pg-fdl",
            "zaimek vrsta=celostni spol=ženski število=dvojina sklon=mestnik",
            "Pronoun Type=general Gender=feminine Number=dual Case=locative");
        InsertMsd(
            "Pg-fdi",
            "zaimek vrsta=celostni spol=ženski število=dvojina sklon=orodnik",
            "Pronoun Type=general Gender=feminine Number=dual Case=instrumental");
        InsertMsd(
            "Pg-fpn",
            "zaimek vrsta=celostni spol=ženski število=množina sklon=imenovalnik",
            "Pronoun Type=general Gender=feminine Number=plural Case=nominative");
        InsertMsd(
            "Pg-fpg",
            "zaimek vrsta=celostni spol=ženski število=množina sklon=rodilnik",
            "Pronoun Type=general Gender=feminine Number=plural Case=genitive");
        InsertMsd(
            "Pg-fpd",
            "zaimek vrsta=celostni spol=ženski število=množina sklon=dajalnik",
            "Pronoun Type=general Gender=feminine Number=plural Case=dative");
        InsertMsd(
            "Pg-fpa",
            "zaimek vrsta=celostni spol=ženski število=množina sklon=tožilnik",
            "Pronoun Type=general Gender=feminine Number=plural Case=accusative");
        InsertMsd(
            "Pg-fpl",
            "zaimek vrsta=celostni spol=ženski število=množina sklon=mestnik",
            "Pronoun Type=general Gender=feminine Number=plural Case=locative");
        InsertMsd(
            "Pg-fpi",
            "zaimek vrsta=celostni spol=ženski število=množina sklon=orodnik",
            "Pronoun Type=general Gender=feminine Number=plural Case=instrumental");
        InsertMsd(
            "Pg-nsn",
            "zaimek vrsta=celostni spol=srednji število=ednina sklon=imenovalnik",
            "Pronoun Type=general Gender=neuter Number=singular Case=nominative");
        InsertMsd(
            "Pg-nsg",
            "zaimek vrsta=celostni spol=srednji število=ednina sklon=rodilnik",
            "Pronoun Type=general Gender=neuter Number=singular Case=genitive");
        InsertMsd(
            "Pg-nsd",
            "zaimek vrsta=celostni spol=srednji število=ednina sklon=dajalnik",
            "Pronoun Type=general Gender=neuter Number=singular Case=dative");
        InsertMsd(
            "Pg-nsa",
            "zaimek vrsta=celostni spol=srednji število=ednina sklon=tožilnik",
            "Pronoun Type=general Gender=neuter Number=singular Case=accusative");
        InsertMsd(
            "Pg-nsl",
            "zaimek vrsta=celostni spol=srednji število=ednina sklon=mestnik",
            "Pronoun Type=general Gender=neuter Number=singular Case=locative");
        InsertMsd(
            "Pg-nsi",
            "zaimek vrsta=celostni spol=srednji število=ednina sklon=orodnik",
            "Pronoun Type=general Gender=neuter Number=singular Case=instrumental");
        InsertMsd(
            "Pg-ndn",
            "zaimek vrsta=celostni spol=srednji število=dvojina sklon=imenovalnik",
            "Pronoun Type=general Gender=neuter Number=dual Case=nominative");
        InsertMsd(
            "Pg-ndg",
            "zaimek vrsta=celostni spol=srednji število=dvojina sklon=rodilnik",
            "Pronoun Type=general Gender=neuter Number=dual Case=genitive");
        InsertMsd("Pg-ndd", "zaimek vrsta=celostni spol=srednji število=dvojina sklon=dajalnik", "Pronoun Type=general Gender=neuter Number=dual Case=dative");
        InsertMsd(
            "Pg-nda",
            "zaimek vrsta=celostni spol=srednji število=dvojina sklon=tožilnik",
            "Pronoun Type=general Gender=neuter Number=dual Case=accusative");
        InsertMsd("Pg-ndl", "zaimek vrsta=celostni spol=srednji število=dvojina sklon=mestnik", "Pronoun Type=general Gender=neuter Number=dual Case=locative");
        InsertMsd(
            "Pg-ndi",
            "zaimek vrsta=celostni spol=srednji število=dvojina sklon=orodnik",
            "Pronoun Type=general Gender=neuter Number=dual Case=instrumental");
        InsertMsd(
            "Pg-npn",
            "zaimek vrsta=celostni spol=srednji število=množina sklon=imenovalnik",
            "Pronoun Type=general Gender=neuter Number=plural Case=nominative");
        InsertMsd(
            "Pg-npg",
            "zaimek vrsta=celostni spol=srednji število=množina sklon=rodilnik",
            "Pronoun Type=general Gender=neuter Number=plural Case=genitive");
        InsertMsd(
            "Pg-npd",
            "zaimek vrsta=celostni spol=srednji število=množina sklon=dajalnik",
            "Pronoun Type=general Gender=neuter Number=plural Case=dative");
        InsertMsd(
            "Pg-npa",
            "zaimek vrsta=celostni spol=srednji število=množina sklon=tožilnik",
            "Pronoun Type=general Gender=neuter Number=plural Case=accusative");
        InsertMsd(
            "Pg-npl",
            "zaimek vrsta=celostni spol=srednji število=množina sklon=mestnik",
            "Pronoun Type=general Gender=neuter Number=plural Case=locative");
        InsertMsd(
            "Pg-npi",
            "zaimek vrsta=celostni spol=srednji število=množina sklon=orodnik",
            "Pronoun Type=general Gender=neuter Number=plural Case=instrumental");
        InsertMsd(
            "Pq-msn",
            "zaimek vrsta=vprašalni spol=moški število=ednina sklon=imenovalnik",
            "Pronoun Type=interrogative Gender=masculine Number=singular Case=nominative");
        InsertMsd(
            "Pq-msg",
            "zaimek vrsta=vprašalni spol=moški število=ednina sklon=rodilnik",
            "Pronoun Type=interrogative Gender=masculine Number=singular Case=genitive");
        InsertMsd(
            "Pq-msd",
            "zaimek vrsta=vprašalni spol=moški število=ednina sklon=dajalnik",
            "Pronoun Type=interrogative Gender=masculine Number=singular Case=dative");
        InsertMsd(
            "Pq-msa",
            "zaimek vrsta=vprašalni spol=moški število=ednina sklon=tožilnik",
            "Pronoun Type=interrogative Gender=masculine Number=singular Case=accusative");
        InsertMsd(
            "Pq-msl",
            "zaimek vrsta=vprašalni spol=moški število=ednina sklon=mestnik",
            "Pronoun Type=interrogative Gender=masculine Number=singular Case=locative");
        InsertMsd(
            "Pq-msi",
            "zaimek vrsta=vprašalni spol=moški število=ednina sklon=orodnik",
            "Pronoun Type=interrogative Gender=masculine Number=singular Case=instrumental");
        InsertMsd(
            "Pq-mdn",
            "zaimek vrsta=vprašalni spol=moški število=dvojina sklon=imenovalnik",
            "Pronoun Type=interrogative Gender=masculine Number=dual Case=nominative");
        InsertMsd(
            "Pq-mdg",
            "zaimek vrsta=vprašalni spol=moški število=dvojina sklon=rodilnik",
            "Pronoun Type=interrogative Gender=masculine Number=dual Case=genitive");
        InsertMsd(
            "Pq-mdd",
            "zaimek vrsta=vprašalni spol=moški število=dvojina sklon=dajalnik",
            "Pronoun Type=interrogative Gender=masculine Number=dual Case=dative");
        InsertMsd(
            "Pq-mda",
            "zaimek vrsta=vprašalni spol=moški število=dvojina sklon=tožilnik",
            "Pronoun Type=interrogative Gender=masculine Number=dual Case=accusative");
        InsertMsd(
            "Pq-mdl",
            "zaimek vrsta=vprašalni spol=moški število=dvojina sklon=mestnik",
            "Pronoun Type=interrogative Gender=masculine Number=dual Case=locative");
        InsertMsd(
            "Pq-mdi",
            "zaimek vrsta=vprašalni spol=moški število=dvojina sklon=orodnik",
            "Pronoun Type=interrogative Gender=masculine Number=dual Case=instrumental");
        InsertMsd(
            "Pq-mpn",
            "zaimek vrsta=vprašalni spol=moški število=množina sklon=imenovalnik",
            "Pronoun Type=interrogative Gender=masculine Number=plural Case=nominative");
        InsertMsd(
            "Pq-mpg",
            "zaimek vrsta=vprašalni spol=moški število=množina sklon=rodilnik",
            "Pronoun Type=interrogative Gender=masculine Number=plural Case=genitive");
        InsertMsd(
            "Pq-mpd",
            "zaimek vrsta=vprašalni spol=moški število=množina sklon=dajalnik",
            "Pronoun Type=interrogative Gender=masculine Number=plural Case=dative");
        InsertMsd(
            "Pq-mpa",
            "zaimek vrsta=vprašalni spol=moški število=množina sklon=tožilnik",
            "Pronoun Type=interrogative Gender=masculine Number=plural Case=accusative");
        InsertMsd(
            "Pq-mpl",
            "zaimek vrsta=vprašalni spol=moški število=množina sklon=mestnik",
            "Pronoun Type=interrogative Gender=masculine Number=plural Case=locative");
        InsertMsd(
            "Pq-mpi",
            "zaimek vrsta=vprašalni spol=moški število=množina sklon=orodnik",
            "Pronoun Type=interrogative Gender=masculine Number=plural Case=instrumental");
        InsertMsd(
            "Pq-fsn",
            "zaimek vrsta=vprašalni spol=ženski število=ednina sklon=imenovalnik",
            "Pronoun Type=interrogative Gender=feminine Number=singular Case=nominative");
        InsertMsd(
            "Pq-fsg",
            "zaimek vrsta=vprašalni spol=ženski število=ednina sklon=rodilnik",
            "Pronoun Type=interrogative Gender=feminine Number=singular Case=genitive");
        InsertMsd(
            "Pq-fsd",
            "zaimek vrsta=vprašalni spol=ženski število=ednina sklon=dajalnik",
            "Pronoun Type=interrogative Gender=feminine Number=singular Case=dative");
        InsertMsd(
            "Pq-fsa",
            "zaimek vrsta=vprašalni spol=ženski število=ednina sklon=tožilnik",
            "Pronoun Type=interrogative Gender=feminine Number=singular Case=accusative");
        InsertMsd(
            "Pq-fsl",
            "zaimek vrsta=vprašalni spol=ženski število=ednina sklon=mestnik",
            "Pronoun Type=interrogative Gender=feminine Number=singular Case=locative");
        InsertMsd(
            "Pq-fsi",
            "zaimek vrsta=vprašalni spol=ženski število=ednina sklon=orodnik",
            "Pronoun Type=interrogative Gender=feminine Number=singular Case=instrumental");
        InsertMsd(
            "Pq-fdn",
            "zaimek vrsta=vprašalni spol=ženski število=dvojina sklon=imenovalnik",
            "Pronoun Type=interrogative Gender=feminine Number=dual Case=nominative");
        InsertMsd(
            "Pq-fdg",
            "zaimek vrsta=vprašalni spol=ženski število=dvojina sklon=rodilnik",
            "Pronoun Type=interrogative Gender=feminine Number=dual Case=genitive");
        InsertMsd(
            "Pq-fdd",
            "zaimek vrsta=vprašalni spol=ženski število=dvojina sklon=dajalnik",
            "Pronoun Type=interrogative Gender=feminine Number=dual Case=dative");
        InsertMsd(
            "Pq-fda",
            "zaimek vrsta=vprašalni spol=ženski število=dvojina sklon=tožilnik",
            "Pronoun Type=interrogative Gender=feminine Number=dual Case=accusative");
        InsertMsd(
            "Pq-fdl",
            "zaimek vrsta=vprašalni spol=ženski število=dvojina sklon=mestnik",
            "Pronoun Type=interrogative Gender=feminine Number=dual Case=locative");
        InsertMsd(
            "Pq-fdi",
            "zaimek vrsta=vprašalni spol=ženski število=dvojina sklon=orodnik",
            "Pronoun Type=interrogative Gender=feminine Number=dual Case=instrumental");
        InsertMsd(
            "Pq-fpn",
            "zaimek vrsta=vprašalni spol=ženski število=množina sklon=imenovalnik",
            "Pronoun Type=interrogative Gender=feminine Number=plural Case=nominative");
        InsertMsd(
            "Pq-fpg",
            "zaimek vrsta=vprašalni spol=ženski število=množina sklon=rodilnik",
            "Pronoun Type=interrogative Gender=feminine Number=plural Case=genitive");
        InsertMsd(
            "Pq-fpd",
            "zaimek vrsta=vprašalni spol=ženski število=množina sklon=dajalnik",
            "Pronoun Type=interrogative Gender=feminine Number=plural Case=dative");
        InsertMsd(
            "Pq-fpa",
            "zaimek vrsta=vprašalni spol=ženski število=množina sklon=tožilnik",
            "Pronoun Type=interrogative Gender=feminine Number=plural Case=accusative");
        InsertMsd(
            "Pq-fpl",
            "zaimek vrsta=vprašalni spol=ženski število=množina sklon=mestnik",
            "Pronoun Type=interrogative Gender=feminine Number=plural Case=locative");
        InsertMsd(
            "Pq-fpi",
            "zaimek vrsta=vprašalni spol=ženski število=množina sklon=orodnik",
            "Pronoun Type=interrogative Gender=feminine Number=plural Case=instrumental");
        InsertMsd(
            "Pq-nsn",
            "zaimek vrsta=vprašalni spol=srednji število=ednina sklon=imenovalnik",
            "Pronoun Type=interrogative Gender=neuter Number=singular Case=nominative");
        InsertMsd(
            "Pq-nsg",
            "zaimek vrsta=vprašalni spol=srednji število=ednina sklon=rodilnik",
            "Pronoun Type=interrogative Gender=neuter Number=singular Case=genitive");
        InsertMsd(
            "Pq-nsd",
            "zaimek vrsta=vprašalni spol=srednji število=ednina sklon=dajalnik",
            "Pronoun Type=interrogative Gender=neuter Number=singular Case=dative");
        InsertMsd(
            "Pq-nsa",
            "zaimek vrsta=vprašalni spol=srednji število=ednina sklon=tožilnik",
            "Pronoun Type=interrogative Gender=neuter Number=singular Case=accusative");
        InsertMsd(
            "Pq-nsl",
            "zaimek vrsta=vprašalni spol=srednji število=ednina sklon=mestnik",
            "Pronoun Type=interrogative Gender=neuter Number=singular Case=locative");
        InsertMsd(
            "Pq-nsi",
            "zaimek vrsta=vprašalni spol=srednji število=ednina sklon=orodnik",
            "Pronoun Type=interrogative Gender=neuter Number=singular Case=instrumental");
        InsertMsd(
            "Pq-ndn",
            "zaimek vrsta=vprašalni spol=srednji število=dvojina sklon=imenovalnik",
            "Pronoun Type=interrogative Gender=neuter Number=dual Case=nominative");
        InsertMsd(
            "Pq-ndg",
            "zaimek vrsta=vprašalni spol=srednji število=dvojina sklon=rodilnik",
            "Pronoun Type=interrogative Gender=neuter Number=dual Case=genitive");
        InsertMsd(
            "Pq-ndd",
            "zaimek vrsta=vprašalni spol=srednji število=dvojina sklon=dajalnik",
            "Pronoun Type=interrogative Gender=neuter Number=dual Case=dative");
        InsertMsd(
            "Pq-nda",
            "zaimek vrsta=vprašalni spol=srednji število=dvojina sklon=tožilnik",
            "Pronoun Type=interrogative Gender=neuter Number=dual Case=accusative");
        InsertMsd(
            "Pq-ndl",
            "zaimek vrsta=vprašalni spol=srednji število=dvojina sklon=mestnik",
            "Pronoun Type=interrogative Gender=neuter Number=dual Case=locative");
        InsertMsd(
            "Pq-ndi",
            "zaimek vrsta=vprašalni spol=srednji število=dvojina sklon=orodnik",
            "Pronoun Type=interrogative Gender=neuter Number=dual Case=instrumental");
        InsertMsd(
            "Pq-npn",
            "zaimek vrsta=vprašalni spol=srednji število=množina sklon=imenovalnik",
            "Pronoun Type=interrogative Gender=neuter Number=plural Case=nominative");
        InsertMsd(
            "Pq-npg",
            "zaimek vrsta=vprašalni spol=srednji število=množina sklon=rodilnik",
            "Pronoun Type=interrogative Gender=neuter Number=plural Case=genitive");
        InsertMsd(
            "Pq-npd",
            "zaimek vrsta=vprašalni spol=srednji število=množina sklon=dajalnik",
            "Pronoun Type=interrogative Gender=neuter Number=plural Case=dative");
        InsertMsd(
            "Pq-npa",
            "zaimek vrsta=vprašalni spol=srednji število=množina sklon=tožilnik",
            "Pronoun Type=interrogative Gender=neuter Number=plural Case=accusative");
        InsertMsd(
            "Pq-npl",
            "zaimek vrsta=vprašalni spol=srednji število=množina sklon=mestnik",
            "Pronoun Type=interrogative Gender=neuter Number=plural Case=locative");
        InsertMsd(
            "Pq-npi",
            "zaimek vrsta=vprašalni spol=srednji število=množina sklon=orodnik",
            "Pronoun Type=interrogative Gender=neuter Number=plural Case=instrumental");
        InsertMsd(
            "Pi-msn",
            "zaimek vrsta=nedolocni spol=moški število=ednina sklon=imenovalnik",
            "Pronoun Type=indefinite Gender=masculine Number=singular Case=nominative");
        InsertMsd(
            "Pi-msg",
            "zaimek vrsta=nedolocni spol=moški število=ednina sklon=rodilnik",
            "Pronoun Type=indefinite Gender=masculine Number=singular Case=genitive");
        InsertMsd(
            "Pi-msd",
            "zaimek vrsta=nedolocni spol=moški število=ednina sklon=dajalnik",
            "Pronoun Type=indefinite Gender=masculine Number=singular Case=dative");
        InsertMsd(
            "Pi-msa",
            "zaimek vrsta=nedolocni spol=moški število=ednina sklon=tožilnik",
            "Pronoun Type=indefinite Gender=masculine Number=singular Case=accusative");
        InsertMsd(
            "Pi-msl",
            "zaimek vrsta=nedolocni spol=moški število=ednina sklon=mestnik",
            "Pronoun Type=indefinite Gender=masculine Number=singular Case=locative");
        InsertMsd(
            "Pi-msi",
            "zaimek vrsta=nedolocni spol=moški število=ednina sklon=orodnik",
            "Pronoun Type=indefinite Gender=masculine Number=singular Case=instrumental");
        InsertMsd(
            "Pi-mdn",
            "zaimek vrsta=nedolocni spol=moški število=dvojina sklon=imenovalnik",
            "Pronoun Type=indefinite Gender=masculine Number=dual Case=nominative");
        InsertMsd(
            "Pi-mdg",
            "zaimek vrsta=nedolocni spol=moški število=dvojina sklon=rodilnik",
            "Pronoun Type=indefinite Gender=masculine Number=dual Case=genitive");
        InsertMsd(
            "Pi-mdd",
            "zaimek vrsta=nedolocni spol=moški število=dvojina sklon=dajalnik",
            "Pronoun Type=indefinite Gender=masculine Number=dual Case=dative");
        InsertMsd(
            "Pi-mda",
            "zaimek vrsta=nedolocni spol=moški število=dvojina sklon=tožilnik",
            "Pronoun Type=indefinite Gender=masculine Number=dual Case=accusative");
        InsertMsd(
            "Pi-mdl",
            "zaimek vrsta=nedolocni spol=moški število=dvojina sklon=mestnik",
            "Pronoun Type=indefinite Gender=masculine Number=dual Case=locative");
        InsertMsd(
            "Pi-mdi",
            "zaimek vrsta=nedolocni spol=moški število=dvojina sklon=orodnik",
            "Pronoun Type=indefinite Gender=masculine Number=dual Case=instrumental");
        InsertMsd(
            "Pi-mpn",
            "zaimek vrsta=nedolocni spol=moški število=množina sklon=imenovalnik",
            "Pronoun Type=indefinite Gender=masculine Number=plural Case=nominative");
        InsertMsd(
            "Pi-mpg",
            "zaimek vrsta=nedolocni spol=moški število=množina sklon=rodilnik",
            "Pronoun Type=indefinite Gender=masculine Number=plural Case=genitive");
        InsertMsd(
            "Pi-mpd",
            "zaimek vrsta=nedolocni spol=moški število=množina sklon=dajalnik",
            "Pronoun Type=indefinite Gender=masculine Number=plural Case=dative");
        InsertMsd(
            "Pi-mpa",
            "zaimek vrsta=nedolocni spol=moški število=množina sklon=tožilnik",
            "Pronoun Type=indefinite Gender=masculine Number=plural Case=accusative");
        InsertMsd(
            "Pi-mpl",
            "zaimek vrsta=nedolocni spol=moški število=množina sklon=mestnik",
            "Pronoun Type=indefinite Gender=masculine Number=plural Case=locative");
        InsertMsd(
            "Pi-mpi",
            "zaimek vrsta=nedolocni spol=moški število=množina sklon=orodnik",
            "Pronoun Type=indefinite Gender=masculine Number=plural Case=instrumental");
        InsertMsd(
            "Pi-fsn",
            "zaimek vrsta=nedolocni spol=ženski število=ednina sklon=imenovalnik",
            "Pronoun Type=indefinite Gender=feminine Number=singular Case=nominative");
        InsertMsd(
            "Pi-fsg",
            "zaimek vrsta=nedolocni spol=ženski število=ednina sklon=rodilnik",
            "Pronoun Type=indefinite Gender=feminine Number=singular Case=genitive");
        InsertMsd(
            "Pi-fsd",
            "zaimek vrsta=nedolocni spol=ženski število=ednina sklon=dajalnik",
            "Pronoun Type=indefinite Gender=feminine Number=singular Case=dative");
        InsertMsd(
            "Pi-fsa",
            "zaimek vrsta=nedolocni spol=ženski število=ednina sklon=tožilnik",
            "Pronoun Type=indefinite Gender=feminine Number=singular Case=accusative");
        InsertMsd(
            "Pi-fsl",
            "zaimek vrsta=nedolocni spol=ženski število=ednina sklon=mestnik",
            "Pronoun Type=indefinite Gender=feminine Number=singular Case=locative");
        InsertMsd(
            "Pi-fsi",
            "zaimek vrsta=nedolocni spol=ženski število=ednina sklon=orodnik",
            "Pronoun Type=indefinite Gender=feminine Number=singular Case=instrumental");
        InsertMsd(
            "Pi-fdn",
            "zaimek vrsta=nedolocni spol=ženski število=dvojina sklon=imenovalnik",
            "Pronoun Type=indefinite Gender=feminine Number=dual Case=nominative");
        InsertMsd(
            "Pi-fdg",
            "zaimek vrsta=nedolocni spol=ženski število=dvojina sklon=rodilnik",
            "Pronoun Type=indefinite Gender=feminine Number=dual Case=genitive");
        InsertMsd(
            "Pi-fdd",
            "zaimek vrsta=nedolocni spol=ženski število=dvojina sklon=dajalnik",
            "Pronoun Type=indefinite Gender=feminine Number=dual Case=dative");
        InsertMsd(
            "Pi-fda",
            "zaimek vrsta=nedolocni spol=ženski število=dvojina sklon=tožilnik",
            "Pronoun Type=indefinite Gender=feminine Number=dual Case=accusative");
        InsertMsd(
            "Pi-fdl",
            "zaimek vrsta=nedolocni spol=ženski število=dvojina sklon=mestnik",
            "Pronoun Type=indefinite Gender=feminine Number=dual Case=locative");
        InsertMsd(
            "Pi-fdi",
            "zaimek vrsta=nedolocni spol=ženski število=dvojina sklon=orodnik",
            "Pronoun Type=indefinite Gender=feminine Number=dual Case=instrumental");
        InsertMsd(
            "Pi-fpn",
            "zaimek vrsta=nedolocni spol=ženski število=množina sklon=imenovalnik",
            "Pronoun Type=indefinite Gender=feminine Number=plural Case=nominative");
        InsertMsd(
            "Pi-fpg",
            "zaimek vrsta=nedolocni spol=ženski število=množina sklon=rodilnik",
            "Pronoun Type=indefinite Gender=feminine Number=plural Case=genitive");
        InsertMsd(
            "Pi-fpd",
            "zaimek vrsta=nedolocni spol=ženski število=množina sklon=dajalnik",
            "Pronoun Type=indefinite Gender=feminine Number=plural Case=dative");
        InsertMsd(
            "Pi-fpa",
            "zaimek vrsta=nedolocni spol=ženski število=množina sklon=tožilnik",
            "Pronoun Type=indefinite Gender=feminine Number=plural Case=accusative");
        InsertMsd(
            "Pi-fpl",
            "zaimek vrsta=nedolocni spol=ženski število=množina sklon=mestnik",
            "Pronoun Type=indefinite Gender=feminine Number=plural Case=locative");
        InsertMsd(
            "Pi-fpi",
            "zaimek vrsta=nedolocni spol=ženski število=množina sklon=orodnik",
            "Pronoun Type=indefinite Gender=feminine Number=plural Case=instrumental");
        InsertMsd(
            "Pi-nsn",
            "zaimek vrsta=nedolocni spol=srednji število=ednina sklon=imenovalnik",
            "Pronoun Type=indefinite Gender=neuter Number=singular Case=nominative");
        InsertMsd(
            "Pi-nsg",
            "zaimek vrsta=nedolocni spol=srednji število=ednina sklon=rodilnik",
            "Pronoun Type=indefinite Gender=neuter Number=singular Case=genitive");
        InsertMsd(
            "Pi-nsd",
            "zaimek vrsta=nedolocni spol=srednji število=ednina sklon=dajalnik",
            "Pronoun Type=indefinite Gender=neuter Number=singular Case=dative");
        InsertMsd(
            "Pi-nsa",
            "zaimek vrsta=nedolocni spol=srednji število=ednina sklon=tožilnik",
            "Pronoun Type=indefinite Gender=neuter Number=singular Case=accusative");
        InsertMsd(
            "Pi-nsl",
            "zaimek vrsta=nedolocni spol=srednji število=ednina sklon=mestnik",
            "Pronoun Type=indefinite Gender=neuter Number=singular Case=locative");
        InsertMsd(
            "Pi-nsi",
            "zaimek vrsta=nedolocni spol=srednji število=ednina sklon=orodnik",
            "Pronoun Type=indefinite Gender=neuter Number=singular Case=instrumental");
        InsertMsd(
            "Pi-ndn",
            "zaimek vrsta=nedolocni spol=srednji število=dvojina sklon=imenovalnik",
            "Pronoun Type=indefinite Gender=neuter Number=dual Case=nominative");
        InsertMsd(
            "Pi-ndg",
            "zaimek vrsta=nedolocni spol=srednji število=dvojina sklon=rodilnik",
            "Pronoun Type=indefinite Gender=neuter Number=dual Case=genitive");
        InsertMsd(
            "Pi-ndd",
            "zaimek vrsta=nedolocni spol=srednji število=dvojina sklon=dajalnik",
            "Pronoun Type=indefinite Gender=neuter Number=dual Case=dative");
        InsertMsd(
            "Pi-nda",
            "zaimek vrsta=nedolocni spol=srednji število=dvojina sklon=tožilnik",
            "Pronoun Type=indefinite Gender=neuter Number=dual Case=accusative");
        InsertMsd(
            "Pi-ndl",
            "zaimek vrsta=nedolocni spol=srednji število=dvojina sklon=mestnik",
            "Pronoun Type=indefinite Gender=neuter Number=dual Case=locative");
        InsertMsd(
            "Pi-ndi",
            "zaimek vrsta=nedolocni spol=srednji število=dvojina sklon=orodnik",
            "Pronoun Type=indefinite Gender=neuter Number=dual Case=instrumental");
        InsertMsd(
            "Pi-npn",
            "zaimek vrsta=nedolocni spol=srednji število=množina sklon=imenovalnik",
            "Pronoun Type=indefinite Gender=neuter Number=plural Case=nominative");
        InsertMsd(
            "Pi-npg",
            "zaimek vrsta=nedolocni spol=srednji število=množina sklon=rodilnik",
            "Pronoun Type=indefinite Gender=neuter Number=plural Case=genitive");
        InsertMsd(
            "Pi-npd",
            "zaimek vrsta=nedolocni spol=srednji število=množina sklon=dajalnik",
            "Pronoun Type=indefinite Gender=neuter Number=plural Case=dative");
        InsertMsd(
            "Pi-npa",
            "zaimek vrsta=nedolocni spol=srednji število=množina sklon=tožilnik",
            "Pronoun Type=indefinite Gender=neuter Number=plural Case=accusative");
        InsertMsd(
            "Pi-npl",
            "zaimek vrsta=nedolocni spol=srednji število=množina sklon=mestnik",
            "Pronoun Type=indefinite Gender=neuter Number=plural Case=locative");
        InsertMsd(
            "Pi-npi",
            "zaimek vrsta=nedolocni spol=srednji število=množina sklon=orodnik",
            "Pronoun Type=indefinite Gender=neuter Number=plural Case=instrumental");
        InsertMsd(
            "Pz-msn",
            "zaimek vrsta=nikalni spol=moški število=ednina sklon=imenovalnik",
            "Pronoun Type=negative Gender=masculine Number=singular Case=nominative");
        InsertMsd(
            "Pz-msg",
            "zaimek vrsta=nikalni spol=moški število=ednina sklon=rodilnik",
            "Pronoun Type=negative Gender=masculine Number=singular Case=genitive");
        InsertMsd(
            "Pz-msd",
            "zaimek vrsta=nikalni spol=moški število=ednina sklon=dajalnik",
            "Pronoun Type=negative Gender=masculine Number=singular Case=dative");
        InsertMsd(
            "Pz-msa",
            "zaimek vrsta=nikalni spol=moški število=ednina sklon=tožilnik",
            "Pronoun Type=negative Gender=masculine Number=singular Case=accusative");
        InsertMsd(
            "Pz-msl",
            "zaimek vrsta=nikalni spol=moški število=ednina sklon=mestnik",
            "Pronoun Type=negative Gender=masculine Number=singular Case=locative");
        InsertMsd(
            "Pz-msi",
            "zaimek vrsta=nikalni spol=moški število=ednina sklon=orodnik",
            "Pronoun Type=negative Gender=masculine Number=singular Case=instrumental");
        InsertMsd(
            "Pz-mdn",
            "zaimek vrsta=nikalni spol=moški število=dvojina sklon=imenovalnik",
            "Pronoun Type=negative Gender=masculine Number=dual Case=nominative");
        InsertMsd(
            "Pz-mdg",
            "zaimek vrsta=nikalni spol=moški število=dvojina sklon=rodilnik",
            "Pronoun Type=negative Gender=masculine Number=dual Case=genitive");
        InsertMsd("Pz-mdd", "zaimek vrsta=nikalni spol=moški število=dvojina sklon=dajalnik", "Pronoun Type=negative Gender=masculine Number=dual Case=dative");
        InsertMsd(
            "Pz-mda",
            "zaimek vrsta=nikalni spol=moški število=dvojina sklon=tožilnik",
            "Pronoun Type=negative Gender=masculine Number=dual Case=accusative");
        InsertMsd(
            "Pz-mdl",
            "zaimek vrsta=nikalni spol=moški število=dvojina sklon=mestnik",
            "Pronoun Type=negative Gender=masculine Number=dual Case=locative");
        InsertMsd(
            "Pz-mdi",
            "zaimek vrsta=nikalni spol=moški število=dvojina sklon=orodnik",
            "Pronoun Type=negative Gender=masculine Number=dual Case=instrumental");
        InsertMsd(
            "Pz-mpn",
            "zaimek vrsta=nikalni spol=moški število=množina sklon=imenovalnik",
            "Pronoun Type=negative Gender=masculine Number=plural Case=nominative");
        InsertMsd(
            "Pz-mpg",
            "zaimek vrsta=nikalni spol=moški število=množina sklon=rodilnik",
            "Pronoun Type=negative Gender=masculine Number=plural Case=genitive");
        InsertMsd(
            "Pz-mpd",
            "zaimek vrsta=nikalni spol=moški število=množina sklon=dajalnik",
            "Pronoun Type=negative Gender=masculine Number=plural Case=dative");
        InsertMsd(
            "Pz-mpa",
            "zaimek vrsta=nikalni spol=moški število=množina sklon=tožilnik",
            "Pronoun Type=negative Gender=masculine Number=plural Case=accusative");
        InsertMsd(
            "Pz-mpl",
            "zaimek vrsta=nikalni spol=moški število=množina sklon=mestnik",
            "Pronoun Type=negative Gender=masculine Number=plural Case=locative");
        InsertMsd(
            "Pz-mpi",
            "zaimek vrsta=nikalni spol=moški število=množina sklon=orodnik",
            "Pronoun Type=negative Gender=masculine Number=plural Case=instrumental");
        InsertMsd(
            "Pz-fsn",
            "zaimek vrsta=nikalni spol=ženski število=ednina sklon=imenovalnik",
            "Pronoun Type=negative Gender=feminine Number=singular Case=nominative");
        InsertMsd(
            "Pz-fsg",
            "zaimek vrsta=nikalni spol=ženski število=ednina sklon=rodilnik",
            "Pronoun Type=negative Gender=feminine Number=singular Case=genitive");
        InsertMsd(
            "Pz-fsd",
            "zaimek vrsta=nikalni spol=ženski število=ednina sklon=dajalnik",
            "Pronoun Type=negative Gender=feminine Number=singular Case=dative");
        InsertMsd(
            "Pz-fsa",
            "zaimek vrsta=nikalni spol=ženski število=ednina sklon=tožilnik",
            "Pronoun Type=negative Gender=feminine Number=singular Case=accusative");
        InsertMsd(
            "Pz-fsl",
            "zaimek vrsta=nikalni spol=ženski število=ednina sklon=mestnik",
            "Pronoun Type=negative Gender=feminine Number=singular Case=locative");
        InsertMsd(
            "Pz-fsi",
            "zaimek vrsta=nikalni spol=ženski število=ednina sklon=orodnik",
            "Pronoun Type=negative Gender=feminine Number=singular Case=instrumental");
        InsertMsd(
            "Pz-fdn",
            "zaimek vrsta=nikalni spol=ženski število=dvojina sklon=imenovalnik",
            "Pronoun Type=negative Gender=feminine Number=dual Case=nominative");
        InsertMsd(
            "Pz-fdg",
            "zaimek vrsta=nikalni spol=ženski število=dvojina sklon=rodilnik",
            "Pronoun Type=negative Gender=feminine Number=dual Case=genitive");
        InsertMsd("Pz-fdd", "zaimek vrsta=nikalni spol=ženski število=dvojina sklon=dajalnik", "Pronoun Type=negative Gender=feminine Number=dual Case=dative");
        InsertMsd(
            "Pz-fda",
            "zaimek vrsta=nikalni spol=ženski število=dvojina sklon=tožilnik",
            "Pronoun Type=negative Gender=feminine Number=dual Case=accusative");
        InsertMsd(
            "Pz-fdl",
            "zaimek vrsta=nikalni spol=ženski število=dvojina sklon=mestnik",
            "Pronoun Type=negative Gender=feminine Number=dual Case=locative");
        InsertMsd(
            "Pz-fdi",
            "zaimek vrsta=nikalni spol=ženski število=dvojina sklon=orodnik",
            "Pronoun Type=negative Gender=feminine Number=dual Case=instrumental");
        InsertMsd(
            "Pz-fpn",
            "zaimek vrsta=nikalni spol=ženski število=množina sklon=imenovalnik",
            "Pronoun Type=negative Gender=feminine Number=plural Case=nominative");
        InsertMsd(
            "Pz-fpg",
            "zaimek vrsta=nikalni spol=ženski število=množina sklon=rodilnik",
            "Pronoun Type=negative Gender=feminine Number=plural Case=genitive");
        InsertMsd(
            "Pz-fpd",
            "zaimek vrsta=nikalni spol=ženski število=množina sklon=dajalnik",
            "Pronoun Type=negative Gender=feminine Number=plural Case=dative");
        InsertMsd(
            "Pz-fpa",
            "zaimek vrsta=nikalni spol=ženski število=množina sklon=tožilnik",
            "Pronoun Type=negative Gender=feminine Number=plural Case=accusative");
        InsertMsd(
            "Pz-fpl",
            "zaimek vrsta=nikalni spol=ženski število=množina sklon=mestnik",
            "Pronoun Type=negative Gender=feminine Number=plural Case=locative");
        InsertMsd(
            "Pz-fpi",
            "zaimek vrsta=nikalni spol=ženski število=množina sklon=orodnik",
            "Pronoun Type=negative Gender=feminine Number=plural Case=instrumental");
        InsertMsd(
            "Pz-nsn",
            "zaimek vrsta=nikalni spol=srednji število=ednina sklon=imenovalnik",
            "Pronoun Type=negative Gender=neuter Number=singular Case=nominative");
        InsertMsd(
            "Pz-nsg",
            "zaimek vrsta=nikalni spol=srednji število=ednina sklon=rodilnik",
            "Pronoun Type=negative Gender=neuter Number=singular Case=genitive");
        InsertMsd(
            "Pz-nsd",
            "zaimek vrsta=nikalni spol=srednji število=ednina sklon=dajalnik",
            "Pronoun Type=negative Gender=neuter Number=singular Case=dative");
        InsertMsd(
            "Pz-nsa",
            "zaimek vrsta=nikalni spol=srednji število=ednina sklon=tožilnik",
            "Pronoun Type=negative Gender=neuter Number=singular Case=accusative");
        InsertMsd(
            "Pz-nsl",
            "zaimek vrsta=nikalni spol=srednji število=ednina sklon=mestnik",
            "Pronoun Type=negative Gender=neuter Number=singular Case=locative");
        InsertMsd(
            "Pz-nsi",
            "zaimek vrsta=nikalni spol=srednji število=ednina sklon=orodnik",
            "Pronoun Type=negative Gender=neuter Number=singular Case=instrumental");
        InsertMsd(
            "Pz-ndn",
            "zaimek vrsta=nikalni spol=srednji število=dvojina sklon=imenovalnik",
            "Pronoun Type=negative Gender=neuter Number=dual Case=nominative");
        InsertMsd(
            "Pz-ndg",
            "zaimek vrsta=nikalni spol=srednji število=dvojina sklon=rodilnik",
            "Pronoun Type=negative Gender=neuter Number=dual Case=genitive");
        InsertMsd("Pz-ndd", "zaimek vrsta=nikalni spol=srednji število=dvojina sklon=dajalnik", "Pronoun Type=negative Gender=neuter Number=dual Case=dative");
        InsertMsd(
            "Pz-nda",
            "zaimek vrsta=nikalni spol=srednji število=dvojina sklon=tožilnik",
            "Pronoun Type=negative Gender=neuter Number=dual Case=accusative");
        InsertMsd("Pz-ndl", "zaimek vrsta=nikalni spol=srednji število=dvojina sklon=mestnik", "Pronoun Type=negative Gender=neuter Number=dual Case=locative");
        InsertMsd(
            "Pz-ndi",
            "zaimek vrsta=nikalni spol=srednji število=dvojina sklon=orodnik",
            "Pronoun Type=negative Gender=neuter Number=dual Case=instrumental");
        InsertMsd(
            "Pz-npn",
            "zaimek vrsta=nikalni spol=srednji število=množina sklon=imenovalnik",
            "Pronoun Type=negative Gender=neuter Number=plural Case=nominative");
        InsertMsd(
            "Pz-npg",
            "zaimek vrsta=nikalni spol=srednji število=množina sklon=rodilnik",
            "Pronoun Type=negative Gender=neuter Number=plural Case=genitive");
        InsertMsd(
            "Pz-npd",
            "zaimek vrsta=nikalni spol=srednji število=množina sklon=dajalnik",
            "Pronoun Type=negative Gender=neuter Number=plural Case=dative");
        InsertMsd(
            "Pz-npa",
            "zaimek vrsta=nikalni spol=srednji število=množina sklon=tožilnik",
            "Pronoun Type=negative Gender=neuter Number=plural Case=accusative");
        InsertMsd(
            "Pz-npl",
            "zaimek vrsta=nikalni spol=srednji število=množina sklon=mestnik",
            "Pronoun Type=negative Gender=neuter Number=plural Case=locative");
        InsertMsd(
            "Pz-npi",
            "zaimek vrsta=nikalni spol=srednji število=množina sklon=orodnik",
            "Pronoun Type=negative Gender=neuter Number=plural Case=instrumental");
        InsertMsd("Mdc", "števnik zapis=arabski vrsta=glavni", "Numeral Form=digit Type=cardinal");
        InsertMsd("Mdo", "števnik zapis=arabski vrsta=vrstilni", "Numeral Form=digit Type=ordinal");
        InsertMsd("Mrc", "števnik zapis=rimski vrsta=glavni", "Numeral Form=roman Type=cardinal");
        InsertMsd("Mro", "števnik zapis=rimski vrsta=vrstilni", "Numeral Form=roman Type=ordinal");
        InsertMsd(
            "Mlc-pn",
            "števnik zapis=besedni vrsta=glavni število=množina sklon=imenovalnik",
            "Numeral Form=letter Type=cardinal Number=plural Case=nominative");
        InsertMsd(
            "Mlc-pg",
            "števnik zapis=besedni vrsta=glavni število=množina sklon=rodilnik",
            "Numeral Form=letter Type=cardinal Number=plural Case=genitive");
        InsertMsd("Mlc-pd", "števnik zapis=besedni vrsta=glavni število=množina sklon=dajalnik", "Numeral Form=letter Type=cardinal Number=plural Case=dative");
        InsertMsd(
            "Mlc-pa",
            "števnik zapis=besedni vrsta=glavni število=množina sklon=tožilnik",
            "Numeral Form=letter Type=cardinal Number=plural Case=accusative");
        InsertMsd(
            "Mlc-pl",
            "števnik zapis=besedni vrsta=glavni število=množina sklon=mestnik",
            "Numeral Form=letter Type=cardinal Number=plural Case=locative");
        InsertMsd(
            "Mlc-pi",
            "števnik zapis=besedni vrsta=glavni število=množina sklon=orodnik",
            "Numeral Form=letter Type=cardinal Number=plural Case=instrumental");
        InsertMsd(
            "Mlcmdn",
            "števnik zapis=besedni vrsta=glavni spol=moški število=dvojina sklon=imenovalnik",
            "Numeral Form=letter Type=cardinal Gender=masculine Number=dual Case=nominative");
        InsertMsd(
            "Mlcmdg",
            "števnik zapis=besedni vrsta=glavni spol=moški število=dvojina sklon=rodilnik",
            "Numeral Form=letter Type=cardinal Gender=masculine Number=dual Case=genitive");
        InsertMsd(
            "Mlcmdd",
            "števnik zapis=besedni vrsta=glavni spol=moški število=dvojina sklon=dajalnik",
            "Numeral Form=letter Type=cardinal Gender=masculine Number=dual Case=dative");
        InsertMsd(
            "Mlcmda",
            "števnik zapis=besedni vrsta=glavni spol=moški število=dvojina sklon=tožilnik",
            "Numeral Form=letter Type=cardinal Gender=masculine Number=dual Case=accusative");
        InsertMsd(
            "Mlcmdl",
            "števnik zapis=besedni vrsta=glavni spol=moški število=dvojina sklon=mestnik",
            "Numeral Form=letter Type=cardinal Gender=masculine Number=dual Case=locative");
        InsertMsd(
            "Mlcmdi",
            "števnik zapis=besedni vrsta=glavni spol=moški število=dvojina sklon=orodnik",
            "Numeral Form=letter Type=cardinal Gender=masculine Number=dual Case=instrumental");
        InsertMsd(
            "Mlcmpn",
            "števnik zapis=besedni vrsta=glavni spol=moški število=množina sklon=imenovalnik",
            "Numeral Form=letter Type=cardinal Gender=masculine Number=plural Case=nominative");
        InsertMsd(
            "Mlcmpg",
            "števnik zapis=besedni vrsta=glavni spol=moški število=množina sklon=rodilnik",
            "Numeral Form=letter Type=cardinal Gender=masculine Number=plural Case=genitive");
        InsertMsd(
            "Mlcmpd",
            "števnik zapis=besedni vrsta=glavni spol=moški število=množina sklon=dajalnik",
            "Numeral Form=letter Type=cardinal Gender=masculine Number=plural Case=dative");
        InsertMsd(
            "Mlcmpa",
            "števnik zapis=besedni vrsta=glavni spol=moški število=množina sklon=tožilnik",
            "Numeral Form=letter Type=cardinal Gender=masculine Number=plural Case=accusative");
        InsertMsd(
            "Mlcmpl",
            "števnik zapis=besedni vrsta=glavni spol=moški število=množina sklon=mestnik",
            "Numeral Form=letter Type=cardinal Gender=masculine Number=plural Case=locative");
        InsertMsd(
            "Mlcmpi",
            "števnik zapis=besedni vrsta=glavni spol=moški število=množina sklon=orodnik",
            "Numeral Form=letter Type=cardinal Gender=masculine Number=plural Case=instrumental");
        InsertMsd(
            "Mlcfdn",
            "števnik zapis=besedni vrsta=glavni spol=ženski število=dvojina sklon=imenovalnik",
            "Numeral Form=letter Type=cardinal Gender=feminine Number=dual Case=nominative");
        InsertMsd(
            "Mlcfdg",
            "števnik zapis=besedni vrsta=glavni spol=ženski število=dvojina sklon=rodilnik",
            "Numeral Form=letter Type=cardinal Gender=feminine Number=dual Case=genitive");
        InsertMsd(
            "Mlcfdd",
            "števnik zapis=besedni vrsta=glavni spol=ženski število=dvojina sklon=dajalnik",
            "Numeral Form=letter Type=cardinal Gender=feminine Number=dual Case=dative");
        InsertMsd(
            "Mlcfda",
            "števnik zapis=besedni vrsta=glavni spol=ženski število=dvojina sklon=tožilnik",
            "Numeral Form=letter Type=cardinal Gender=feminine Number=dual Case=accusative");
        InsertMsd(
            "Mlcfdl",
            "števnik zapis=besedni vrsta=glavni spol=ženski število=dvojina sklon=mestnik",
            "Numeral Form=letter Type=cardinal Gender=feminine Number=dual Case=locative");
        InsertMsd(
            "Mlcfdi",
            "števnik zapis=besedni vrsta=glavni spol=ženski število=dvojina sklon=orodnik",
            "Numeral Form=letter Type=cardinal Gender=feminine Number=dual Case=instrumental");
        InsertMsd(
            "Mlcfpn",
            "števnik zapis=besedni vrsta=glavni spol=ženski število=množina sklon=imenovalnik",
            "Numeral Form=letter Type=cardinal Gender=feminine Number=plural Case=nominative");
        InsertMsd(
            "Mlcfpg",
            "števnik zapis=besedni vrsta=glavni spol=ženski število=množina sklon=rodilnik",
            "Numeral Form=letter Type=cardinal Gender=feminine Number=plural Case=genitive");
        InsertMsd(
            "Mlcfpd",
            "števnik zapis=besedni vrsta=glavni spol=ženski število=množina sklon=dajalnik",
            "Numeral Form=letter Type=cardinal Gender=feminine Number=plural Case=dative");
        InsertMsd(
            "Mlcfpa",
            "števnik zapis=besedni vrsta=glavni spol=ženski število=množina sklon=tožilnik",
            "Numeral Form=letter Type=cardinal Gender=feminine Number=plural Case=accusative");
        InsertMsd(
            "Mlcfpl",
            "števnik zapis=besedni vrsta=glavni spol=ženski število=množina sklon=mestnik",
            "Numeral Form=letter Type=cardinal Gender=feminine Number=plural Case=locative");
        InsertMsd(
            "Mlcfpi",
            "števnik zapis=besedni vrsta=glavni spol=ženski število=množina sklon=orodnik",
            "Numeral Form=letter Type=cardinal Gender=feminine Number=plural Case=instrumental");
        InsertMsd(
            "Mlcndn",
            "števnik zapis=besedni vrsta=glavni spol=srednji število=dvojina sklon=imenovalnik",
            "Numeral Form=letter Type=cardinal Gender=neuter Number=dual Case=nominative");
        InsertMsd(
            "Mlcndg",
            "števnik zapis=besedni vrsta=glavni spol=srednji število=dvojina sklon=rodilnik",
            "Numeral Form=letter Type=cardinal Gender=neuter Number=dual Case=genitive");
        InsertMsd(
            "Mlcndd",
            "števnik zapis=besedni vrsta=glavni spol=srednji število=dvojina sklon=dajalnik",
            "Numeral Form=letter Type=cardinal Gender=neuter Number=dual Case=dative");
        InsertMsd(
            "Mlcnda",
            "števnik zapis=besedni vrsta=glavni spol=srednji število=dvojina sklon=tožilnik",
            "Numeral Form=letter Type=cardinal Gender=neuter Number=dual Case=accusative");
        InsertMsd(
            "Mlcndl",
            "števnik zapis=besedni vrsta=glavni spol=srednji število=dvojina sklon=mestnik",
            "Numeral Form=letter Type=cardinal Gender=neuter Number=dual Case=locative");
        InsertMsd(
            "Mlcndi",
            "števnik zapis=besedni vrsta=glavni spol=srednji število=dvojina sklon=orodnik",
            "Numeral Form=letter Type=cardinal Gender=neuter Number=dual Case=instrumental");
        InsertMsd(
            "Mlcnpn",
            "števnik zapis=besedni vrsta=glavni spol=srednji število=množina sklon=imenovalnik",
            "Numeral Form=letter Type=cardinal Gender=neuter Number=plural Case=nominative");
        InsertMsd(
            "Mlcnpg",
            "števnik zapis=besedni vrsta=glavni spol=srednji število=množina sklon=rodilnik",
            "Numeral Form=letter Type=cardinal Gender=neuter Number=plural Case=genitive");
        InsertMsd(
            "Mlcnpd",
            "števnik zapis=besedni vrsta=glavni spol=srednji število=množina sklon=dajalnik",
            "Numeral Form=letter Type=cardinal Gender=neuter Number=plural Case=dative");
        InsertMsd(
            "Mlcnpa",
            "števnik zapis=besedni vrsta=glavni spol=srednji število=množina sklon=tožilnik",
            "Numeral Form=letter Type=cardinal Gender=neuter Number=plural Case=accusative");
        InsertMsd(
            "Mlcnpl",
            "števnik zapis=besedni vrsta=glavni spol=srednji število=množina sklon=mestnik",
            "Numeral Form=letter Type=cardinal Gender=neuter Number=plural Case=locative");
        InsertMsd(
            "Mlcnpi",
            "števnik zapis=besedni vrsta=glavni spol=srednji število=množina sklon=orodnik",
            "Numeral Form=letter Type=cardinal Gender=neuter Number=plural Case=instrumental");
        InsertMsd(
            "Mlomsn",
            "števnik zapis=besedni vrsta=vrstilni spol=moški število=ednina sklon=imenovalnik",
            "Numeral Form=letter Type=ordinal Gender=masculine Number=singular Case=nominative");
        InsertMsd(
            "Mlomsg",
            "števnik zapis=besedni vrsta=vrstilni spol=moški število=ednina sklon=rodilnik",
            "Numeral Form=letter Type=ordinal Gender=masculine Number=singular Case=genitive");
        InsertMsd(
            "Mlomsd",
            "števnik zapis=besedni vrsta=vrstilni spol=moški število=ednina sklon=dajalnik",
            "Numeral Form=letter Type=ordinal Gender=masculine Number=singular Case=dative");
        InsertMsd(
            "Mlomsa",
            "števnik zapis=besedni vrsta=vrstilni spol=moški število=ednina sklon=tožilnik",
            "Numeral Form=letter Type=ordinal Gender=masculine Number=singular Case=accusative");
        InsertMsd(
            "Mlomsl",
            "števnik zapis=besedni vrsta=vrstilni spol=moški število=ednina sklon=mestnik",
            "Numeral Form=letter Type=ordinal Gender=masculine Number=singular Case=locative");
        InsertMsd(
            "Mlomsi",
            "števnik zapis=besedni vrsta=vrstilni spol=moški število=ednina sklon=orodnik",
            "Numeral Form=letter Type=ordinal Gender=masculine Number=singular Case=instrumental");
        InsertMsd(
            "Mlomdn",
            "števnik zapis=besedni vrsta=vrstilni spol=moški število=dvojina sklon=imenovalnik",
            "Numeral Form=letter Type=ordinal Gender=masculine Number=dual Case=nominative");
        InsertMsd(
            "Mlomdg",
            "števnik zapis=besedni vrsta=vrstilni spol=moški število=dvojina sklon=rodilnik",
            "Numeral Form=letter Type=ordinal Gender=masculine Number=dual Case=genitive");
        InsertMsd(
            "Mlomdd",
            "števnik zapis=besedni vrsta=vrstilni spol=moški število=dvojina sklon=dajalnik",
            "Numeral Form=letter Type=ordinal Gender=masculine Number=dual Case=dative");
        InsertMsd(
            "Mlomda",
            "števnik zapis=besedni vrsta=vrstilni spol=moški število=dvojina sklon=tožilnik",
            "Numeral Form=letter Type=ordinal Gender=masculine Number=dual Case=accusative");
        InsertMsd(
            "Mlomdl",
            "števnik zapis=besedni vrsta=vrstilni spol=moški število=dvojina sklon=mestnik",
            "Numeral Form=letter Type=ordinal Gender=masculine Number=dual Case=locative");
        InsertMsd(
            "Mlomdi",
            "števnik zapis=besedni vrsta=vrstilni spol=moški število=dvojina sklon=orodnik",
            "Numeral Form=letter Type=ordinal Gender=masculine Number=dual Case=instrumental");
        InsertMsd(
            "Mlompn",
            "števnik zapis=besedni vrsta=vrstilni spol=moški število=množina sklon=imenovalnik",
            "Numeral Form=letter Type=ordinal Gender=masculine Number=plural Case=nominative");
        InsertMsd(
            "Mlompg",
            "števnik zapis=besedni vrsta=vrstilni spol=moški število=množina sklon=rodilnik",
            "Numeral Form=letter Type=ordinal Gender=masculine Number=plural Case=genitive");
        InsertMsd(
            "Mlompd",
            "števnik zapis=besedni vrsta=vrstilni spol=moški število=množina sklon=dajalnik",
            "Numeral Form=letter Type=ordinal Gender=masculine Number=plural Case=dative");
        InsertMsd(
            "Mlompa",
            "števnik zapis=besedni vrsta=vrstilni spol=moški število=množina sklon=tožilnik",
            "Numeral Form=letter Type=ordinal Gender=masculine Number=plural Case=accusative");
        InsertMsd(
            "Mlompl",
            "števnik zapis=besedni vrsta=vrstilni spol=moški število=množina sklon=mestnik",
            "Numeral Form=letter Type=ordinal Gender=masculine Number=plural Case=locative");
        InsertMsd(
            "Mlompi",
            "števnik zapis=besedni vrsta=vrstilni spol=moški število=množina sklon=orodnik",
            "Numeral Form=letter Type=ordinal Gender=masculine Number=plural Case=instrumental");
        InsertMsd(
            "Mlofsn",
            "števnik zapis=besedni vrsta=vrstilni spol=ženski število=ednina sklon=imenovalnik",
            "Numeral Form=letter Type=ordinal Gender=feminine Number=singular Case=nominative");
        InsertMsd(
            "Mlofsg",
            "števnik zapis=besedni vrsta=vrstilni spol=ženski število=ednina sklon=rodilnik",
            "Numeral Form=letter Type=ordinal Gender=feminine Number=singular Case=genitive");
        InsertMsd(
            "Mlofsd",
            "števnik zapis=besedni vrsta=vrstilni spol=ženski število=ednina sklon=dajalnik",
            "Numeral Form=letter Type=ordinal Gender=feminine Number=singular Case=dative");
        InsertMsd(
            "Mlofsa",
            "števnik zapis=besedni vrsta=vrstilni spol=ženski število=ednina sklon=tožilnik",
            "Numeral Form=letter Type=ordinal Gender=feminine Number=singular Case=accusative");
        InsertMsd(
            "Mlofsl",
            "števnik zapis=besedni vrsta=vrstilni spol=ženski število=ednina sklon=mestnik",
            "Numeral Form=letter Type=ordinal Gender=feminine Number=singular Case=locative");
        InsertMsd(
            "Mlofsi",
            "števnik zapis=besedni vrsta=vrstilni spol=ženski število=ednina sklon=orodnik",
            "Numeral Form=letter Type=ordinal Gender=feminine Number=singular Case=instrumental");
        InsertMsd(
            "Mlofdn",
            "števnik zapis=besedni vrsta=vrstilni spol=ženski število=dvojina sklon=imenovalnik",
            "Numeral Form=letter Type=ordinal Gender=feminine Number=dual Case=nominative");
        InsertMsd(
            "Mlofdg",
            "števnik zapis=besedni vrsta=vrstilni spol=ženski število=dvojina sklon=rodilnik",
            "Numeral Form=letter Type=ordinal Gender=feminine Number=dual Case=genitive");
        InsertMsd(
            "Mlofdd",
            "števnik zapis=besedni vrsta=vrstilni spol=ženski število=dvojina sklon=dajalnik",
            "Numeral Form=letter Type=ordinal Gender=feminine Number=dual Case=dative");
        InsertMsd(
            "Mlofda",
            "števnik zapis=besedni vrsta=vrstilni spol=ženski število=dvojina sklon=tožilnik",
            "Numeral Form=letter Type=ordinal Gender=feminine Number=dual Case=accusative");
        InsertMsd(
            "Mlofdl",
            "števnik zapis=besedni vrsta=vrstilni spol=ženski število=dvojina sklon=mestnik",
            "Numeral Form=letter Type=ordinal Gender=feminine Number=dual Case=locative");
        InsertMsd(
            "Mlofdi",
            "števnik zapis=besedni vrsta=vrstilni spol=ženski število=dvojina sklon=orodnik",
            "Numeral Form=letter Type=ordinal Gender=feminine Number=dual Case=instrumental");
        InsertMsd(
            "Mlofpn",
            "števnik zapis=besedni vrsta=vrstilni spol=ženski število=množina sklon=imenovalnik",
            "Numeral Form=letter Type=ordinal Gender=feminine Number=plural Case=nominative");
        InsertMsd(
            "Mlofpg",
            "števnik zapis=besedni vrsta=vrstilni spol=ženski število=množina sklon=rodilnik",
            "Numeral Form=letter Type=ordinal Gender=feminine Number=plural Case=genitive");
        InsertMsd(
            "Mlofpd",
            "števnik zapis=besedni vrsta=vrstilni spol=ženski število=množina sklon=dajalnik",
            "Numeral Form=letter Type=ordinal Gender=feminine Number=plural Case=dative");
        InsertMsd(
            "Mlofpa",
            "števnik zapis=besedni vrsta=vrstilni spol=ženski število=množina sklon=tožilnik",
            "Numeral Form=letter Type=ordinal Gender=feminine Number=plural Case=accusative");
        InsertMsd(
            "Mlofpl",
            "števnik zapis=besedni vrsta=vrstilni spol=ženski število=množina sklon=mestnik",
            "Numeral Form=letter Type=ordinal Gender=feminine Number=plural Case=locative");
        InsertMsd(
            "Mlofpi",
            "števnik zapis=besedni vrsta=vrstilni spol=ženski število=množina sklon=orodnik",
            "Numeral Form=letter Type=ordinal Gender=feminine Number=plural Case=instrumental");
        InsertMsd(
            "Mlonsn",
            "števnik zapis=besedni vrsta=vrstilni spol=srednji število=ednina sklon=imenovalnik",
            "Numeral Form=letter Type=ordinal Gender=neuter Number=singular Case=nominative");
        InsertMsd(
            "Mlonsg",
            "števnik zapis=besedni vrsta=vrstilni spol=srednji število=ednina sklon=rodilnik",
            "Numeral Form=letter Type=ordinal Gender=neuter Number=singular Case=genitive");
        InsertMsd(
            "Mlonsd",
            "števnik zapis=besedni vrsta=vrstilni spol=srednji število=ednina sklon=dajalnik",
            "Numeral Form=letter Type=ordinal Gender=neuter Number=singular Case=dative");
        InsertMsd(
            "Mlonsa",
            "števnik zapis=besedni vrsta=vrstilni spol=srednji število=ednina sklon=tožilnik",
            "Numeral Form=letter Type=ordinal Gender=neuter Number=singular Case=accusative");
        InsertMsd(
            "Mlonsl",
            "števnik zapis=besedni vrsta=vrstilni spol=srednji število=ednina sklon=mestnik",
            "Numeral Form=letter Type=ordinal Gender=neuter Number=singular Case=locative");
        InsertMsd(
            "Mlonsi",
            "števnik zapis=besedni vrsta=vrstilni spol=srednji število=ednina sklon=orodnik",
            "Numeral Form=letter Type=ordinal Gender=neuter Number=singular Case=instrumental");
        InsertMsd(
            "Mlondn",
            "števnik zapis=besedni vrsta=vrstilni spol=srednji število=dvojina sklon=imenovalnik",
            "Numeral Form=letter Type=ordinal Gender=neuter Number=dual Case=nominative");
        InsertMsd(
            "Mlondg",
            "števnik zapis=besedni vrsta=vrstilni spol=srednji število=dvojina sklon=rodilnik",
            "Numeral Form=letter Type=ordinal Gender=neuter Number=dual Case=genitive");
        InsertMsd(
            "Mlondd",
            "števnik zapis=besedni vrsta=vrstilni spol=srednji število=dvojina sklon=dajalnik",
            "Numeral Form=letter Type=ordinal Gender=neuter Number=dual Case=dative");
        InsertMsd(
            "Mlonda",
            "števnik zapis=besedni vrsta=vrstilni spol=srednji število=dvojina sklon=tožilnik",
            "Numeral Form=letter Type=ordinal Gender=neuter Number=dual Case=accusative");
        InsertMsd(
            "Mlondl",
            "števnik zapis=besedni vrsta=vrstilni spol=srednji število=dvojina sklon=mestnik",
            "Numeral Form=letter Type=ordinal Gender=neuter Number=dual Case=locative");
        InsertMsd(
            "Mlondi",
            "števnik zapis=besedni vrsta=vrstilni spol=srednji število=dvojina sklon=orodnik",
            "Numeral Form=letter Type=ordinal Gender=neuter Number=dual Case=instrumental");
        InsertMsd(
            "Mlonpn",
            "števnik zapis=besedni vrsta=vrstilni spol=srednji število=množina sklon=imenovalnik",
            "Numeral Form=letter Type=ordinal Gender=neuter Number=plural Case=nominative");
        InsertMsd(
            "Mlonpg",
            "števnik zapis=besedni vrsta=vrstilni spol=srednji število=množina sklon=rodilnik",
            "Numeral Form=letter Type=ordinal Gender=neuter Number=plural Case=genitive");
        InsertMsd(
            "Mlonpd",
            "števnik zapis=besedni vrsta=vrstilni spol=srednji število=množina sklon=dajalnik",
            "Numeral Form=letter Type=ordinal Gender=neuter Number=plural Case=dative");
        InsertMsd(
            "Mlonpa",
            "števnik zapis=besedni vrsta=vrstilni spol=srednji število=množina sklon=tožilnik",
            "Numeral Form=letter Type=ordinal Gender=neuter Number=plural Case=accusative");
        InsertMsd(
            "Mlonpl",
            "števnik zapis=besedni vrsta=vrstilni spol=srednji število=množina sklon=mestnik",
            "Numeral Form=letter Type=ordinal Gender=neuter Number=plural Case=locative");
        InsertMsd(
            "Mlonpi",
            "števnik zapis=besedni vrsta=vrstilni spol=srednji število=množina sklon=orodnik",
            "Numeral Form=letter Type=ordinal Gender=neuter Number=plural Case=instrumental");
        InsertMsd(
            "Mlpmsn",
            "števnik zapis=besedni vrsta=zaimkovni spol=moški število=ednina sklon=imenovalnik",
            "Numeral Form=letter Type=pronominal Gender=masculine Number=singular Case=nominative");
        InsertMsd(
            "Mlpmsnn",
            "števnik zapis=besedni vrsta=zaimkovni spol=moški število=ednina sklon=imenovalnik dolocnost=ne",
            "Numeral Form=letter Type=pronominal Gender=masculine Number=singular Case=nominative Definiteness=no");
        InsertMsd(
            "Mlpmsny",
            "števnik zapis=besedni vrsta=zaimkovni spol=moški število=ednina sklon=imenovalnik dolocnost=da",
            "Numeral Form=letter Type=pronominal Gender=masculine Number=singular Case=nominative Definiteness=yes");
        InsertMsd(
            "Mlpmsg",
            "števnik zapis=besedni vrsta=zaimkovni spol=moški število=ednina sklon=rodilnik",
            "Numeral Form=letter Type=pronominal Gender=masculine Number=singular Case=genitive");
        InsertMsd(
            "Mlpmsd",
            "števnik zapis=besedni vrsta=zaimkovni spol=moški število=ednina sklon=dajalnik",
            "Numeral Form=letter Type=pronominal Gender=masculine Number=singular Case=dative");
        InsertMsd(
            "Mlpmsa",
            "števnik zapis=besedni vrsta=zaimkovni spol=moški število=ednina sklon=tožilnik",
            "Numeral Form=letter Type=pronominal Gender=masculine Number=singular Case=accusative");
        InsertMsd(
            "Mlpmsan",
            "števnik zapis=besedni vrsta=zaimkovni spol=moški število=ednina sklon=tožilnik dolocnost=ne",
            "Numeral Form=letter Type=pronominal Gender=masculine Number=singular Case=accusative Definiteness=no");
        InsertMsd(
            "Mlpmsay",
            "števnik zapis=besedni vrsta=zaimkovni spol=moški število=ednina sklon=tožilnik dolocnost=da",
            "Numeral Form=letter Type=pronominal Gender=masculine Number=singular Case=accusative Definiteness=yes");
        InsertMsd(
            "Mlpmsl",
            "števnik zapis=besedni vrsta=zaimkovni spol=moški število=ednina sklon=mestnik",
            "Numeral Form=letter Type=pronominal Gender=masculine Number=singular Case=locative");
        InsertMsd(
            "Mlpmsi",
            "števnik zapis=besedni vrsta=zaimkovni spol=moški število=ednina sklon=orodnik",
            "Numeral Form=letter Type=pronominal Gender=masculine Number=singular Case=instrumental");
        InsertMsd(
            "Mlpmdn",
            "števnik zapis=besedni vrsta=zaimkovni spol=moški število=dvojina sklon=imenovalnik",
            "Numeral Form=letter Type=pronominal Gender=masculine Number=dual Case=nominative");
        InsertMsd(
            "Mlpmdg",
            "števnik zapis=besedni vrsta=zaimkovni spol=moški število=dvojina sklon=rodilnik",
            "Numeral Form=letter Type=pronominal Gender=masculine Number=dual Case=genitive");
        InsertMsd(
            "Mlpmdd",
            "števnik zapis=besedni vrsta=zaimkovni spol=moški število=dvojina sklon=dajalnik",
            "Numeral Form=letter Type=pronominal Gender=masculine Number=dual Case=dative");
        InsertMsd(
            "Mlpmda",
            "števnik zapis=besedni vrsta=zaimkovni spol=moški število=dvojina sklon=tožilnik",
            "Numeral Form=letter Type=pronominal Gender=masculine Number=dual Case=accusative");
        InsertMsd(
            "Mlpmdl",
            "števnik zapis=besedni vrsta=zaimkovni spol=moški število=dvojina sklon=mestnik",
            "Numeral Form=letter Type=pronominal Gender=masculine Number=dual Case=locative");
        InsertMsd(
            "Mlpmdi",
            "števnik zapis=besedni vrsta=zaimkovni spol=moški število=dvojina sklon=orodnik",
            "Numeral Form=letter Type=pronominal Gender=masculine Number=dual Case=instrumental");
        InsertMsd(
            "Mlpmpn",
            "števnik zapis=besedni vrsta=zaimkovni spol=moški število=množina sklon=imenovalnik",
            "Numeral Form=letter Type=pronominal Gender=masculine Number=plural Case=nominative");
        InsertMsd(
            "Mlpmpg",
            "števnik zapis=besedni vrsta=zaimkovni spol=moški število=množina sklon=rodilnik",
            "Numeral Form=letter Type=pronominal Gender=masculine Number=plural Case=genitive");
        InsertMsd(
            "Mlpmpd",
            "števnik zapis=besedni vrsta=zaimkovni spol=moški število=množina sklon=dajalnik",
            "Numeral Form=letter Type=pronominal Gender=masculine Number=plural Case=dative");
        InsertMsd(
            "Mlpmpa",
            "števnik zapis=besedni vrsta=zaimkovni spol=moški število=množina sklon=tožilnik",
            "Numeral Form=letter Type=pronominal Gender=masculine Number=plural Case=accusative");
        InsertMsd(
            "Mlpmpl",
            "števnik zapis=besedni vrsta=zaimkovni spol=moški število=množina sklon=mestnik",
            "Numeral Form=letter Type=pronominal Gender=masculine Number=plural Case=locative");
        InsertMsd(
            "Mlpmpi",
            "števnik zapis=besedni vrsta=zaimkovni spol=moški število=množina sklon=orodnik",
            "Numeral Form=letter Type=pronominal Gender=masculine Number=plural Case=instrumental");
        InsertMsd(
            "Mlpfsn",
            "števnik zapis=besedni vrsta=zaimkovni spol=ženski število=ednina sklon=imenovalnik",
            "Numeral Form=letter Type=pronominal Gender=feminine Number=singular Case=nominative");
        InsertMsd(
            "Mlpfsg",
            "števnik zapis=besedni vrsta=zaimkovni spol=ženski število=ednina sklon=rodilnik",
            "Numeral Form=letter Type=pronominal Gender=feminine Number=singular Case=genitive");
        InsertMsd(
            "Mlpfsd",
            "števnik zapis=besedni vrsta=zaimkovni spol=ženski število=ednina sklon=dajalnik",
            "Numeral Form=letter Type=pronominal Gender=feminine Number=singular Case=dative");
        InsertMsd(
            "Mlpfsa",
            "števnik zapis=besedni vrsta=zaimkovni spol=ženski število=ednina sklon=tožilnik",
            "Numeral Form=letter Type=pronominal Gender=feminine Number=singular Case=accusative");
        InsertMsd(
            "Mlpfsl",
            "števnik zapis=besedni vrsta=zaimkovni spol=ženski število=ednina sklon=mestnik",
            "Numeral Form=letter Type=pronominal Gender=feminine Number=singular Case=locative");
        InsertMsd(
            "Mlpfsi",
            "števnik zapis=besedni vrsta=zaimkovni spol=ženski število=ednina sklon=orodnik",
            "Numeral Form=letter Type=pronominal Gender=feminine Number=singular Case=instrumental");
        InsertMsd(
            "Mlpfdn",
            "števnik zapis=besedni vrsta=zaimkovni spol=ženski število=dvojina sklon=imenovalnik",
            "Numeral Form=letter Type=pronominal Gender=feminine Number=dual Case=nominative");
        InsertMsd(
            "Mlpfdg",
            "števnik zapis=besedni vrsta=zaimkovni spol=ženski število=dvojina sklon=rodilnik",
            "Numeral Form=letter Type=pronominal Gender=feminine Number=dual Case=genitive");
        InsertMsd(
            "Mlpfdd",
            "števnik zapis=besedni vrsta=zaimkovni spol=ženski število=dvojina sklon=dajalnik",
            "Numeral Form=letter Type=pronominal Gender=feminine Number=dual Case=dative");
        InsertMsd(
            "Mlpfda",
            "števnik zapis=besedni vrsta=zaimkovni spol=ženski število=dvojina sklon=tožilnik",
            "Numeral Form=letter Type=pronominal Gender=feminine Number=dual Case=accusative");
        InsertMsd(
            "Mlpfdl",
            "števnik zapis=besedni vrsta=zaimkovni spol=ženski število=dvojina sklon=mestnik",
            "Numeral Form=letter Type=pronominal Gender=feminine Number=dual Case=locative");
        InsertMsd(
            "Mlpfdi",
            "števnik zapis=besedni vrsta=zaimkovni spol=ženski število=dvojina sklon=orodnik",
            "Numeral Form=letter Type=pronominal Gender=feminine Number=dual Case=instrumental");
        InsertMsd(
            "Mlpfpn",
            "števnik zapis=besedni vrsta=zaimkovni spol=ženski število=množina sklon=imenovalnik",
            "Numeral Form=letter Type=pronominal Gender=feminine Number=plural Case=nominative");
        InsertMsd(
            "Mlpfpg",
            "števnik zapis=besedni vrsta=zaimkovni spol=ženski število=množina sklon=rodilnik",
            "Numeral Form=letter Type=pronominal Gender=feminine Number=plural Case=genitive");
        InsertMsd(
            "Mlpfpd",
            "števnik zapis=besedni vrsta=zaimkovni spol=ženski število=množina sklon=dajalnik",
            "Numeral Form=letter Type=pronominal Gender=feminine Number=plural Case=dative");
        InsertMsd(
            "Mlpfpa",
            "števnik zapis=besedni vrsta=zaimkovni spol=ženski število=množina sklon=tožilnik",
            "Numeral Form=letter Type=pronominal Gender=feminine Number=plural Case=accusative");
        InsertMsd(
            "Mlpfpl",
            "števnik zapis=besedni vrsta=zaimkovni spol=ženski število=množina sklon=mestnik",
            "Numeral Form=letter Type=pronominal Gender=feminine Number=plural Case=locative");
        InsertMsd(
            "Mlpfpi",
            "števnik zapis=besedni vrsta=zaimkovni spol=ženski število=množina sklon=orodnik",
            "Numeral Form=letter Type=pronominal Gender=feminine Number=plural Case=instrumental");
        InsertMsd(
            "Mlpnsn",
            "števnik zapis=besedni vrsta=zaimkovni spol=srednji število=ednina sklon=imenovalnik",
            "Numeral Form=letter Type=pronominal Gender=neuter Number=singular Case=nominative");
        InsertMsd(
            "Mlpnsg",
            "števnik zapis=besedni vrsta=zaimkovni spol=srednji število=ednina sklon=rodilnik",
            "Numeral Form=letter Type=pronominal Gender=neuter Number=singular Case=genitive");
        InsertMsd(
            "Mlpnsd",
            "števnik zapis=besedni vrsta=zaimkovni spol=srednji število=ednina sklon=dajalnik",
            "Numeral Form=letter Type=pronominal Gender=neuter Number=singular Case=dative");
        InsertMsd(
            "Mlpnsa",
            "števnik zapis=besedni vrsta=zaimkovni spol=srednji število=ednina sklon=tožilnik",
            "Numeral Form=letter Type=pronominal Gender=neuter Number=singular Case=accusative");
        InsertMsd(
            "Mlpnsl",
            "števnik zapis=besedni vrsta=zaimkovni spol=srednji število=ednina sklon=mestnik",
            "Numeral Form=letter Type=pronominal Gender=neuter Number=singular Case=locative");
        InsertMsd(
            "Mlpnsi",
            "števnik zapis=besedni vrsta=zaimkovni spol=srednji število=ednina sklon=orodnik",
            "Numeral Form=letter Type=pronominal Gender=neuter Number=singular Case=instrumental");
        InsertMsd(
            "Mlpndn",
            "števnik zapis=besedni vrsta=zaimkovni spol=srednji število=dvojina sklon=imenovalnik",
            "Numeral Form=letter Type=pronominal Gender=neuter Number=dual Case=nominative");
        InsertMsd(
            "Mlpndg",
            "števnik zapis=besedni vrsta=zaimkovni spol=srednji število=dvojina sklon=rodilnik",
            "Numeral Form=letter Type=pronominal Gender=neuter Number=dual Case=genitive");
        InsertMsd(
            "Mlpndd",
            "števnik zapis=besedni vrsta=zaimkovni spol=srednji število=dvojina sklon=dajalnik",
            "Numeral Form=letter Type=pronominal Gender=neuter Number=dual Case=dative");
        InsertMsd(
            "Mlpnda",
            "števnik zapis=besedni vrsta=zaimkovni spol=srednji število=dvojina sklon=tožilnik",
            "Numeral Form=letter Type=pronominal Gender=neuter Number=dual Case=accusative");
        InsertMsd(
            "Mlpndl",
            "števnik zapis=besedni vrsta=zaimkovni spol=srednji število=dvojina sklon=mestnik",
            "Numeral Form=letter Type=pronominal Gender=neuter Number=dual Case=locative");
        InsertMsd(
            "Mlpndi",
            "števnik zapis=besedni vrsta=zaimkovni spol=srednji število=dvojina sklon=orodnik",
            "Numeral Form=letter Type=pronominal Gender=neuter Number=dual Case=instrumental");
        InsertMsd(
            "Mlpnpn",
            "števnik zapis=besedni vrsta=zaimkovni spol=srednji število=množina sklon=imenovalnik",
            "Numeral Form=letter Type=pronominal Gender=neuter Number=plural Case=nominative");
        InsertMsd(
            "Mlpnpg",
            "števnik zapis=besedni vrsta=zaimkovni spol=srednji število=množina sklon=rodilnik",
            "Numeral Form=letter Type=pronominal Gender=neuter Number=plural Case=genitive");
        InsertMsd(
            "Mlpnpd",
            "števnik zapis=besedni vrsta=zaimkovni spol=srednji število=množina sklon=dajalnik",
            "Numeral Form=letter Type=pronominal Gender=neuter Number=plural Case=dative");
        InsertMsd(
            "Mlpnpa",
            "števnik zapis=besedni vrsta=zaimkovni spol=srednji število=množina sklon=tožilnik",
            "Numeral Form=letter Type=pronominal Gender=neuter Number=plural Case=accusative");
        InsertMsd(
            "Mlpnpl",
            "števnik zapis=besedni vrsta=zaimkovni spol=srednji število=množina sklon=mestnik",
            "Numeral Form=letter Type=pronominal Gender=neuter Number=plural Case=locative");
        InsertMsd(
            "Mlpnpi",
            "števnik zapis=besedni vrsta=zaimkovni spol=srednji število=množina sklon=orodnik",
            "Numeral Form=letter Type=pronominal Gender=neuter Number=plural Case=instrumental");
        InsertMsd(
            "Mlsmsnn",
            "števnik zapis=besedni vrsta=drugi spol=moški število=ednina sklon=imenovalnik dolocnost=ne",
            "Numeral Form=letter Type=special Gender=masculine Number=singular Case=nominative Definiteness=no");
        InsertMsd(
            "Mlsmsny",
            "števnik zapis=besedni vrsta=drugi spol=moški število=ednina sklon=imenovalnik dolocnost=da",
            "Numeral Form=letter Type=special Gender=masculine Number=singular Case=nominative Definiteness=yes");
        InsertMsd(
            "Mlsmsg",
            "števnik zapis=besedni vrsta=drugi spol=moški število=ednina sklon=rodilnik",
            "Numeral Form=letter Type=special Gender=masculine Number=singular Case=genitive");
        InsertMsd(
            "Mlsmsd",
            "števnik zapis=besedni vrsta=drugi spol=moški število=ednina sklon=dajalnik",
            "Numeral Form=letter Type=special Gender=masculine Number=singular Case=dative");
        InsertMsd(
            "Mlsmsa",
            "števnik zapis=besedni vrsta=drugi spol=moški število=ednina sklon=tožilnik",
            "Numeral Form=letter Type=special Gender=masculine Number=singular Case=accusative");
        InsertMsd(
            "Mlsmsan",
            "števnik zapis=besedni vrsta=drugi spol=moški število=ednina sklon=tožilnik dolocnost=ne",
            "Numeral Form=letter Type=special Gender=masculine Number=singular Case=accusative Definiteness=no");
        InsertMsd(
            "Mlsmsay",
            "števnik zapis=besedni vrsta=drugi spol=moški število=ednina sklon=tožilnik dolocnost=da",
            "Numeral Form=letter Type=special Gender=masculine Number=singular Case=accusative Definiteness=yes");
        InsertMsd(
            "Mlsmsl",
            "števnik zapis=besedni vrsta=drugi spol=moški število=ednina sklon=mestnik",
            "Numeral Form=letter Type=special Gender=masculine Number=singular Case=locative");
        InsertMsd(
            "Mlsmsi",
            "števnik zapis=besedni vrsta=drugi spol=moški število=ednina sklon=orodnik",
            "Numeral Form=letter Type=special Gender=masculine Number=singular Case=instrumental");
        InsertMsd(
            "Mlsmdn",
            "števnik zapis=besedni vrsta=drugi spol=moški število=dvojina sklon=imenovalnik",
            "Numeral Form=letter Type=special Gender=masculine Number=dual Case=nominative");
        InsertMsd(
            "Mlsmdg",
            "števnik zapis=besedni vrsta=drugi spol=moški število=dvojina sklon=rodilnik",
            "Numeral Form=letter Type=special Gender=masculine Number=dual Case=genitive");
        InsertMsd(
            "Mlsmdd",
            "števnik zapis=besedni vrsta=drugi spol=moški število=dvojina sklon=dajalnik",
            "Numeral Form=letter Type=special Gender=masculine Number=dual Case=dative");
        InsertMsd(
            "Mlsmda",
            "števnik zapis=besedni vrsta=drugi spol=moški število=dvojina sklon=tožilnik",
            "Numeral Form=letter Type=special Gender=masculine Number=dual Case=accusative");
        InsertMsd(
            "Mlsmdl",
            "števnik zapis=besedni vrsta=drugi spol=moški število=dvojina sklon=mestnik",
            "Numeral Form=letter Type=special Gender=masculine Number=dual Case=locative");
        InsertMsd(
            "Mlsmdi",
            "števnik zapis=besedni vrsta=drugi spol=moški število=dvojina sklon=orodnik",
            "Numeral Form=letter Type=special Gender=masculine Number=dual Case=instrumental");
        InsertMsd(
            "Mlsmpn",
            "števnik zapis=besedni vrsta=drugi spol=moški število=množina sklon=imenovalnik",
            "Numeral Form=letter Type=special Gender=masculine Number=plural Case=nominative");
        InsertMsd(
            "Mlsmpg",
            "števnik zapis=besedni vrsta=drugi spol=moški število=množina sklon=rodilnik",
            "Numeral Form=letter Type=special Gender=masculine Number=plural Case=genitive");
        InsertMsd(
            "Mlsmpd",
            "števnik zapis=besedni vrsta=drugi spol=moški število=množina sklon=dajalnik",
            "Numeral Form=letter Type=special Gender=masculine Number=plural Case=dative");
        InsertMsd(
            "Mlsmpa",
            "števnik zapis=besedni vrsta=drugi spol=moški število=množina sklon=tožilnik",
            "Numeral Form=letter Type=special Gender=masculine Number=plural Case=accusative");
        InsertMsd(
            "Mlsmpl",
            "števnik zapis=besedni vrsta=drugi spol=moški število=množina sklon=mestnik",
            "Numeral Form=letter Type=special Gender=masculine Number=plural Case=locative");
        InsertMsd(
            "Mlsmpi",
            "števnik zapis=besedni vrsta=drugi spol=moški število=množina sklon=orodnik",
            "Numeral Form=letter Type=special Gender=masculine Number=plural Case=instrumental");
        InsertMsd(
            "Mlsfsn",
            "števnik zapis=besedni vrsta=drugi spol=ženski število=ednina sklon=imenovalnik",
            "Numeral Form=letter Type=special Gender=feminine Number=singular Case=nominative");
        InsertMsd(
            "Mlsfsg",
            "števnik zapis=besedni vrsta=drugi spol=ženski število=ednina sklon=rodilnik",
            "Numeral Form=letter Type=special Gender=feminine Number=singular Case=genitive");
        InsertMsd(
            "Mlsfsd",
            "števnik zapis=besedni vrsta=drugi spol=ženski število=ednina sklon=dajalnik",
            "Numeral Form=letter Type=special Gender=feminine Number=singular Case=dative");
        InsertMsd(
            "Mlsfsa",
            "števnik zapis=besedni vrsta=drugi spol=ženski število=ednina sklon=tožilnik",
            "Numeral Form=letter Type=special Gender=feminine Number=singular Case=accusative");
        InsertMsd(
            "Mlsfsl",
            "števnik zapis=besedni vrsta=drugi spol=ženski število=ednina sklon=mestnik",
            "Numeral Form=letter Type=special Gender=feminine Number=singular Case=locative");
        InsertMsd(
            "Mlsfsi",
            "števnik zapis=besedni vrsta=drugi spol=ženski število=ednina sklon=orodnik",
            "Numeral Form=letter Type=special Gender=feminine Number=singular Case=instrumental");
        InsertMsd(
            "Mlsfdn",
            "števnik zapis=besedni vrsta=drugi spol=ženski število=dvojina sklon=imenovalnik",
            "Numeral Form=letter Type=special Gender=feminine Number=dual Case=nominative");
        InsertMsd(
            "Mlsfdg",
            "števnik zapis=besedni vrsta=drugi spol=ženski število=dvojina sklon=rodilnik",
            "Numeral Form=letter Type=special Gender=feminine Number=dual Case=genitive");
        InsertMsd(
            "Mlsfdd",
            "števnik zapis=besedni vrsta=drugi spol=ženski število=dvojina sklon=dajalnik",
            "Numeral Form=letter Type=special Gender=feminine Number=dual Case=dative");
        InsertMsd(
            "Mlsfda",
            "števnik zapis=besedni vrsta=drugi spol=ženski število=dvojina sklon=tožilnik",
            "Numeral Form=letter Type=special Gender=feminine Number=dual Case=accusative");
        InsertMsd(
            "Mlsfdl",
            "števnik zapis=besedni vrsta=drugi spol=ženski število=dvojina sklon=mestnik",
            "Numeral Form=letter Type=special Gender=feminine Number=dual Case=locative");
        InsertMsd(
            "Mlsfdi",
            "števnik zapis=besedni vrsta=drugi spol=ženski število=dvojina sklon=orodnik",
            "Numeral Form=letter Type=special Gender=feminine Number=dual Case=instrumental");
        InsertMsd(
            "Mlsfpn",
            "števnik zapis=besedni vrsta=drugi spol=ženski število=množina sklon=imenovalnik",
            "Numeral Form=letter Type=special Gender=feminine Number=plural Case=nominative");
        InsertMsd(
            "Mlsfpg",
            "števnik zapis=besedni vrsta=drugi spol=ženski število=množina sklon=rodilnik",
            "Numeral Form=letter Type=special Gender=feminine Number=plural Case=genitive");
        InsertMsd(
            "Mlsfpd",
            "števnik zapis=besedni vrsta=drugi spol=ženski število=množina sklon=dajalnik",
            "Numeral Form=letter Type=special Gender=feminine Number=plural Case=dative");
        InsertMsd(
            "Mlsfpa",
            "števnik zapis=besedni vrsta=drugi spol=ženski število=množina sklon=tožilnik",
            "Numeral Form=letter Type=special Gender=feminine Number=plural Case=accusative");
        InsertMsd(
            "Mlsfpl",
            "števnik zapis=besedni vrsta=drugi spol=ženski število=množina sklon=mestnik",
            "Numeral Form=letter Type=special Gender=feminine Number=plural Case=locative");
        InsertMsd(
            "Mlsfpi",
            "števnik zapis=besedni vrsta=drugi spol=ženski število=množina sklon=orodnik",
            "Numeral Form=letter Type=special Gender=feminine Number=plural Case=instrumental");
        InsertMsd(
            "Mlsnsn",
            "števnik zapis=besedni vrsta=drugi spol=srednji število=ednina sklon=imenovalnik",
            "Numeral Form=letter Type=special Gender=neuter Number=singular Case=nominative");
        InsertMsd(
            "Mlsnsg",
            "števnik zapis=besedni vrsta=drugi spol=srednji število=ednina sklon=rodilnik",
            "Numeral Form=letter Type=special Gender=neuter Number=singular Case=genitive");
        InsertMsd(
            "Mlsnsd",
            "števnik zapis=besedni vrsta=drugi spol=srednji število=ednina sklon=dajalnik",
            "Numeral Form=letter Type=special Gender=neuter Number=singular Case=dative");
        InsertMsd(
            "Mlsnsa",
            "števnik zapis=besedni vrsta=drugi spol=srednji število=ednina sklon=tožilnik",
            "Numeral Form=letter Type=special Gender=neuter Number=singular Case=accusative");
        InsertMsd(
            "Mlsnsl",
            "števnik zapis=besedni vrsta=drugi spol=srednji število=ednina sklon=mestnik",
            "Numeral Form=letter Type=special Gender=neuter Number=singular Case=locative");
        InsertMsd(
            "Mlsnsi",
            "števnik zapis=besedni vrsta=drugi spol=srednji število=ednina sklon=orodnik",
            "Numeral Form=letter Type=special Gender=neuter Number=singular Case=instrumental");
        InsertMsd(
            "Mlsndn",
            "števnik zapis=besedni vrsta=drugi spol=srednji število=dvojina sklon=imenovalnik",
            "Numeral Form=letter Type=special Gender=neuter Number=dual Case=nominative");
        InsertMsd(
            "Mlsndg",
            "števnik zapis=besedni vrsta=drugi spol=srednji število=dvojina sklon=rodilnik",
            "Numeral Form=letter Type=special Gender=neuter Number=dual Case=genitive");
        InsertMsd(
            "Mlsndd",
            "števnik zapis=besedni vrsta=drugi spol=srednji število=dvojina sklon=dajalnik",
            "Numeral Form=letter Type=special Gender=neuter Number=dual Case=dative");
        InsertMsd(
            "Mlsnda",
            "števnik zapis=besedni vrsta=drugi spol=srednji število=dvojina sklon=tožilnik",
            "Numeral Form=letter Type=special Gender=neuter Number=dual Case=accusative");
        InsertMsd(
            "Mlsndl",
            "števnik zapis=besedni vrsta=drugi spol=srednji število=dvojina sklon=mestnik",
            "Numeral Form=letter Type=special Gender=neuter Number=dual Case=locative");
        InsertMsd(
            "Mlsndi",
            "števnik zapis=besedni vrsta=drugi spol=srednji število=dvojina sklon=orodnik",
            "Numeral Form=letter Type=special Gender=neuter Number=dual Case=instrumental");
        InsertMsd(
            "Mlsnpn",
            "števnik zapis=besedni vrsta=drugi spol=srednji število=množina sklon=imenovalnik",
            "Numeral Form=letter Type=special Gender=neuter Number=plural Case=nominative");
        InsertMsd(
            "Mlsnpg",
            "števnik zapis=besedni vrsta=drugi spol=srednji število=množina sklon=rodilnik",
            "Numeral Form=letter Type=special Gender=neuter Number=plural Case=genitive");
        InsertMsd(
            "Mlsnpd",
            "števnik zapis=besedni vrsta=drugi spol=srednji število=množina sklon=dajalnik",
            "Numeral Form=letter Type=special Gender=neuter Number=plural Case=dative");
        InsertMsd(
            "Mlsnpa",
            "števnik zapis=besedni vrsta=drugi spol=srednji število=množina sklon=tožilnik",
            "Numeral Form=letter Type=special Gender=neuter Number=plural Case=accusative");
        InsertMsd(
            "Mlsnpl",
            "števnik zapis=besedni vrsta=drugi spol=srednji število=množina sklon=mestnik",
            "Numeral Form=letter Type=special Gender=neuter Number=plural Case=locative");
        InsertMsd(
            "Mlsnpi",
            "števnik zapis=besedni vrsta=drugi spol=srednji število=množina sklon=orodnik",
            "Numeral Form=letter Type=special Gender=neuter Number=plural Case=instrumental");
        InsertMsd("Sn", "predlog sklon=imenovalnik", "Adposition Case=nominative");
        InsertMsd("Sg", "predlog sklon=rodilnik", "Adposition Case=genitive");
        InsertMsd("Sd", "predlog sklon=dajalnik", "Adposition Case=dative");
        InsertMsd("Sa", "predlog sklon=tožilnik", "Adposition Case=accusative");
        InsertMsd("Sl", "predlog sklon=mestnik", "Adposition Case=locative");
        InsertMsd("Si", "predlog sklon=orodnik", "Adposition Case=instrumental");
        InsertMsd("Cc", "veznik vrsta=priredni", "Conjunction Type=coordinating");
        InsertMsd("Cs", "veznik vrsta=podredni", "Conjunction Type=subordinating");
        InsertMsd("Q", "clenek", "Particle");
        InsertMsd("I", "medmet", "Interjection");
        InsertMsd("Y", "okrajšava", "Abbreviation");
        InsertMsd("X", "neuvršceno", "Residual");
        InsertMsd("Xf", "neuvršceno vrsta=tujejezicno", "Residual Type=foreign");
        InsertMsd("Xt", "neuvršceno vrsta=tipkarska", "Residual Type=typo");
        InsertMsd("Xw", "neuvršceno vrsta=splet", "Residual Type=web");
        InsertMsd("Xe", "neuvršceno vrsta=emo", "Residual Type=emo");
        InsertMsd("Xh", "neuvršceno vrsta=kljucnik", "Residual Type=hashtag");
        InsertMsd("Xa", "neuvršceno vrsta=afna", "Residual Type=at");
        InsertMsd("Xp", "neuvršceno vrsta=program", "Residual Type=program");
        InsertMsd("Z", "locilo", "Punctuation");
    }

    private void InsertMsd(string code, string description, string englishDescription)
    {
        var currentDate = DateTime.UtcNow;
        var data = new Dictionary<string, object>();
        data.Add(nameof(Msd.Id), Guid.NewGuid());
        data.Add(nameof(Msd.CreatedDate), currentDate);
        data.Add(nameof(Msd.ModifiedDate), currentDate);
        data.Add(nameof(Msd.Code), code);
        data.Add(nameof(Msd.Description), description);
        data.Add(nameof(Msd.EnglishDescription), englishDescription);
        Insert.IntoTable(nameof(Msd)).Row(data);
    }
}