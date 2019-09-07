using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranscriptionOrokin
{
    class dataMotsRecus
    {
        internal static string renvoieIntermedaire = ""; // variable du mot transcrit

        public static string MotTranscrip(string motRecu)
        {
			
            switch(motRecu)
            {
				case "a t e n o "					: return renvoieIntermedaire = "a tenno ";
				case "i s "							: return renvoieIntermedaire = "is ";
				case "th u m "						: return renvoieIntermedaire = "them ";
				case "s oo aw r n "					: return renvoieIntermedaire = "sworn ";
				case "aw f "						: return renvoieIntermedaire = "of ";
				case "p r aw t e kh t aw r "		: return renvoieIntermedaire = "protector  ";
				case "s ee s t e m "				: return renvoieIntermedaire = "system ";
				case "ow r "						: return renvoieIntermedaire = "or ";
				case "ee oo h "						: return renvoieIntermedaire = "you ";
				case "th u h "						: return renvoieIntermedaire = "the ";
				case "aw r "						: return renvoieIntermedaire = "are ";
				case "h o p "						: return renvoieIntermedaire = "h o p e ";
				case "f ee oo ch oo r "				: return renvoieIntermedaire = "futur ";
				case "t e n o "						: return renvoieIntermedaire = "tenno ";
				case " too "						: return renvoieIntermedaire = "too ";
				case "m ae n t ae n "				: return renvoieIntermedaire = "maintain ";
				case "b a l a n k "					: return renvoieIntermedaire = "blank ";
				case "b aw th "						: return renvoieIntermedaire = "both ";
				case "t o "							: return renvoieIntermedaire = "to ";
				case "sh a d ow "					: return renvoieIntermedaire = "shadow ";
				case "l i g h t "					: return renvoieIntermedaire = "light ";
				case "a "							: return renvoieIntermedaire = "a ";
				case "oo e l kh u m "				: return renvoieIntermedaire = "welcome ";
				case "dh u h , h o p "				: return renvoieIntermedaire = "the: hope ";
				case "v o i d "						: return renvoieIntermedaire = "void ";
				case "l i n k "						: return renvoieIntermedaire = "link  ";
				case "s e v e r e d "				: return renvoieIntermedaire = "severed ";
				case "r e s aw n"					: return renvoieIntermedaire = "reason ";
				case "zh aw r e i g n "				: return renvoieIntermedaire = "foreing ";
				case "k a r aye r "					: return renvoieIntermedaire = "carrier ";
				case ". "							: return renvoieIntermedaire = ". ";
				case "d e t e k t e d "				: return renvoieIntermedaire = "detected ";
				case "a n d "						: return renvoieIntermedaire = "and ";
				case "u n k n ow n "				: return renvoieIntermedaire = "unknow ";
				case "s u s p e k sh u m "			: return renvoieIntermedaire = "suspection ";
				case "t r a k i g "					: return renvoieIntermedaire = "tracking ";
				case "i n "							: return renvoieIntermedaire = "in ";
				case "s i g n a l "					: return renvoieIntermedaire = "signal ";
				case "r e i n i t e i ng "			: return renvoieIntermedaire = "reinitiating ";
				case "d i p o l r "					: return renvoieIntermedaire = "dipolar ";
				case "k aw n e k sh u m "			: return renvoieIntermedaire = "connection ";
				case "aw n "						: return renvoieIntermedaire = "on ";
				case "n aw v e l "					: return renvoieIntermedaire = "novel ";
				case "b i o "						: return renvoieIntermedaire = "bio ";
				case "s t an d b aye"				: return renvoieIntermedaire = "standby ";
                case "f aw r "						: return renvoieIntermedaire = "for ";
                case "ch e k "						: return renvoieIntermedaire = "check ";
                case "s ee n k "					: return renvoieIntermedaire = "sync ";
                case "m aw sh u m "					: return renvoieIntermedaire = "motion ";
                case "k aw m p e n s a sh u m "		: return renvoieIntermedaire = "compensation ";
                case "k aw m p l e t e "			: return renvoieIntermedaire = "complete ";
                case "s e l e n i k "				: return renvoieIntermedaire = "selenic ";
                case "l e n s i n g "				: return renvoieIntermedaire = "l aw k e d ";
                case "s aw m a t i k "				: return renvoieIntermedaire = "somatic ";
                case "k aw n t r o l "				: return renvoieIntermedaire = "control ";
                case "e s t a b l i sh e d "		: return renvoieIntermedaire = "established ";
                case "m a r g oo l i s"     		: return renvoieIntermedaire = "margulis ";
                case "i m p l a n t a sh u m" 		: return renvoieIntermedaire = "implantation ";
                case "i n t a k t "         		: return renvoieIntermedaire = "intact ";
                case "e v m "               		: return renvoieIntermedaire = "EVM ";
                case "s t a t u s "         		: return renvoieIntermedaire = "status ";
                case "n aw m i n a l"       		: return renvoieIntermedaire = "nominal ";
                case "oo o r "              		: return renvoieIntermedaire = "war ";
                case "p l a t f aw r m"     		: return renvoieIntermedaire = "platform ";
                case "aw ae t i n g"        		: return renvoieIntermedaire = "awaiting ";
                case "i n i t e l i z i g"  		: return renvoieIntermedaire = "initializing ";
                case "s ee n a p t i k"     		: return renvoieIntermedaire = "synaptic ";
                case "aw v e r l ae"        		: return renvoieIntermedaire = "overlay ";
                case "g oo d"               		: return renvoieIntermedaire = "good ";
                case "n i g h t "           		: return renvoieIntermedaire = "night";
                case "a n j i l "           		: return renvoieIntermedaire = "angel ";
                case "s oo ee t "           		: return renvoieIntermedaire = "sweet"; 
            }//fin switch
			
			
            return renvoieIntermedaire = motRecu;

        }
    }
}
