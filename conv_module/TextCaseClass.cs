﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConvertModule
{
    /// <summary>
    /// Именительный падеж
    /// </summary>
    public class NominativeCaseClass : TextCaseClass
    {
        /// <summary>
        /// Метод-переводчик в именительный падеж из именительного
        /// </summary>
        /// <param name="text">Текст, который необходимо перевести</param>
        /// <returns>Результат перевода</returns>
        public override string Translate(string text)
        {
            return text;
        }
    }

    /// <summary>
    /// Родительный падеж
    /// </summary>
    public class GenitiveCaseClass : TextCaseClass
    {
        private Dictionary<string, string> words = new Dictionary<string, string>() {
        {"ноль","нуля"},
        {"один","одного"},
        {"одна","одной"},
        {"одно","одного"},
        {"два","двух"},
        {"две","двух"},
        {"три","трёх"},
        {"четыре","четырёх"},
        {"пять","пяти"},
        {"шесть","шести"},
        {"семь","семи"},
        {"восемь","восьми"},
        {"девять","девяти"},
        {"десять","десяти"},
        {"одинадцать","одинадцати"},
        {"двенадцать","двенадцати"},
        {"тринадцать","тринадцати"},
        {"четырнадцать","четырнадцати"},
        {"пятнадцать","пятнадцати"},
        {"шестнадцать","шестнадцати"},
        {"семнадцать","семнадцати"},
        {"восемнадцать","восемнадцати"},
        {"девятнадцать","девятнадцати"},
        {"двадцать","двадцати"},
        {"тридцать","тридцати"},
        {"сорок","сорока"},
        {"пятьдесят","пятидесяти"},
        {"шестьдесят","шестидесяти"},
        {"семьдесят","семидесяти"},
        {"восемьдесят","восьмидесяти"},
        {"девяносто","девяноста"},
        {"сто","ста"},
        {"двести","двухсот"},
        {"триста","трёхсот"},
        {"четыреста","четырёхсот"},
        {"пятьсот","пятисот"},
        {"шестьсот","шестисот"},
        {"семьсот","семисот"},
        {"восемьсот","восьмисот"},
        {"девятьсот","девятисот"},
        {"тысяча","тысячи"},
        {"тысячи","тысяч"},
        {"миллион","миллиона"},
        {"миллиона","миллионов"},
        {"миллиард","миллиарда"},
        {"миллиарда","миллиардов"},
        {"триллион","триллиона"},
        {"триллиона","триллионов"},
        {"рубль","рубля"},
        {"рубля","рублей"},
        {"копейка","копейки"},
        {"копейки","копеек"},
        {"доллар","доллара"},
        {"доллара","долларов"},
        {"цент","цента"},
        {"цента","центов"},
        {"третий", "третьего"},
        {"третья", "третью"},
        {"январь", "января"},
        {"февраль", "февраля"},
        {"март", "марта"},
        {"апрель", "апреля"},
        {"май", "мая"},
        {"июнь", "июня"},
        {"июль", "июля"},
        {"август", "августа"},
        {"сентябрь", "сентября"},
        {"октябрь", "октября"},
        {"ноябрь", "ноября"},
        {"декабрь", "декабря"},
        {"год", "года"},
        {"секунда", "секунды"},
        {"секунды", "секунд"},
        {"секунд", "секунд"},
        {"минута", "минуты"},
        {"минуты", "минут"},
        {"минут", "минут"},
        {"час", "часа"},
        {"часа", "часов"},
        {"часов", "часов"}
        };

        /// <summary>
        /// Метод-переводчик в родительный падеж из именительного
        /// </summary>
        /// <param name="text">Текст, который необходимо перевести</param>
        /// <returns>Результат перевода</returns>
        public override string Translate(string text)
        {
            if (words.ContainsKey(text))
                return words[text];
            else
            if (Regex.IsMatch(text, @"(ой|ый)$"))
                return Regex.Replace(text, @"(ой|ый)$", "ого");
            else
            if (Regex.IsMatch(text, @"(ая)$"))
                return Regex.Replace(text, @"(ая)$", "ой");
            else
                if (Regex.IsMatch(text, @"(ое)$"))
                    return Regex.Replace(text, @"(ое)$", "ого");
            else
               return text;
        }
    }

    /// <summary>
    /// Дательный падеж
    /// </summary>
    public class DativeCaseClass : TextCaseClass
    {
        private Dictionary<string, string> words = new Dictionary<string, string>() {
        {"ноль","нулю"},
        {"один","одному"},
        {"одна","одной"},
        {"одно","одному"},
        {"два","двум"},
        {"две","двум"},
        {"три","трём"},
        {"четыре","четырём"},
        {"пять","пяти"},
        {"шесть","шести"},
        {"семь","семи"},
        {"восемь","восьми"},
        {"девять","девяти"},
        {"десять","десяти"},
        {"одинадцать","одинадцати"},
        {"двенадцать","двенадцати"},
        {"тринадцать","тринадцати"},
        {"четырнадцать","четырнадцати"},
        {"пятнадцать","пятнадцати"},
        {"шестнадцать","шестнадцати"},
        {"семнадцать","семнадцати"},
        {"восемнадцать","восемнадцати"},
        {"девятнадцать","девятнадцати"},
        {"двадцать","двадцати"},
        {"тридцать","тридцати"},
        {"сорок","сорока"},
        {"пятьдесят","пятидесяти"},
        {"шестьдесят","шестидесяти"},
        {"семьдесят","семидесяти"},
        {"восемьдесят","восьмидесяти"},
        {"девяносто","девяноста"},
        {"сто","ста"},
        {"двести","двумстам"},
        {"триста","трёмстам"},
        {"четыреста","четырёмстам"},
        {"пятьсот","пятистам"},
        {"шестьсот","шестистам"},
        {"семьсот","семистам"},
        {"восемьсот","восьмистам"},
        {"девятьсот","девятистам"},
        {"тысяча","тысяче"},
        {"тысячи","тысячам"},
        {"тысяч","тысячам"},
        {"миллион","миллиону"},
        {"миллиона","миллионам"},
        {"миллионов","миллионам"},
        {"миллиард","миллиарду"},
        {"миллиарда","миллиардам"},
        {"миллиардов","миллиардам"},
        {"триллион","триллионам"},
        {"триллиона","триллионам"},
        {"триллионов","триллионам"},
        {"рубль","рублю"},
        {"рубля","рублям"},
        {"рублей","рублям"},
        {"копейка","копейке"},
        {"копейки","копейкам"},
        {"копеек","копейкам"},
        {"доллар","доллару"},
        {"доллара","долларам"},
        {"долларов","долларам"},
        {"цент","центу"},
        {"цента","центам"},
        {"центов","центам"},
        {"третий", "третьему"},
        {"третья", "третьей"},
        {"третье", "третьему"},
        {"январь", "январю"},
        {"февраль", "февралю"},
        {"март", "марту"},
        {"апрель", "апрелю"},
        {"май", "маю"},
        {"июнь", "июню"},
        {"июль", "июлю"},
        {"август", "августу"},
        {"сентябрь", "сентябрю"},
        {"октябрь", "октябрю"},
        {"ноябрь", "ноябрю"},
        {"декабрь", "декабрю"},
        {"год", "году"},
        {"секунда", "секунде"},
        {"секунды", "секундам"},
        {"секунд", "секундам"},
        {"минута", "минуте"},
        {"минуты", "минутам"},
        {"минут", "минутам"},
        {"час", "часу"},
        {"часа", "часам"},
        {"часов", "часам"},
        {"целых","целым"},
        {"десятых","десятым"}
        };

        /// <summary>
        /// Метод-переводчик в дательный падеж из именительного
        /// </summary>
        /// <param name="text">Текст, который необходимо перевести</param>
        /// <returns>Результат перевода</returns>
        public override string Translate(string text)
        {
            if (words.ContainsKey(text))
                return words[text];
            else
                if (Regex.IsMatch(text, @"(ой|ый)$"))
                    return Regex.Replace(text, @"(ой|ый)$", "ому");
                else
                    if (Regex.IsMatch(text, @"(ая)$"))
                        return Regex.Replace(text, @"(ая)$", "ой");
                    else
                        if (Regex.IsMatch(text, @"(ое)$"))
                            return Regex.Replace(text, @"(ое)$", "ому");
                        else
                            return text;
        }
    }

    /// <summary>
    /// Винительный падеж
    /// </summary>
    public class AccusativeCaseClass : TextCaseClass
    {
        private Dictionary<string, string> words = new Dictionary<string, string>() {
        {"одна","одну"},
        {"тысяча","тысячу"},
        {"копейка","копейку"},
        {"третий", "третьего"},
        {"третья", "третью"},
        {"третье", "третьего"},
        {"секунда", "секунду"},
        {"минута", "минуту"}
        };

        /// <summary>
        /// Метод-переводчик в винительный падеж из именительного
        /// </summary>
        /// <param name="text">Текст, который необходимо перевести</param>
        /// <returns>Результат перевода</returns>
        public override string Translate(string text)
        {
            if (words.ContainsKey(text))
                return words[text];
            else
                if (Regex.IsMatch(text, @"(ой|ый)$"))
                    return Regex.Replace(text, @"(ой|ый)$", "ого");
                else
                    if (Regex.IsMatch(text, @"(ая)$"))
                        return Regex.Replace(text, @"(ая)$", "ую");
                    else
                        if (Regex.IsMatch(text, @"(ое)$"))
                            return Regex.Replace(text, @"(ое)$", "ого");
                        else
                            return text;
        }
    }

    /// <summary>
    /// Творительный падеж
    /// </summary>
    public class InstrumentalCaseClass : TextCaseClass
    {
        private Dictionary<string, string> words = new Dictionary<string, string>() {
        {"ноль","нулем"},
        {"один","одним"},
        {"одна","одной"},
        {"одно","одним"},
        {"два","двумя"},
        {"две","двумя"},
        {"три","тремя"},
        {"четыре","четыремя"},
        {"пять","пятью"},
        {"шесть","шестью"},
        {"семь","семью"},
        {"восемь","восьмью"},
        {"девять","девятью"},
        {"десять","десятью"},
        {"одинадцать","одинадцатью"},
        {"двенадцать","двенадцатью"},
        {"тринадцать","тринадцатью"},
        {"четырнадцать","четырнадцатью"},
        {"пятнадцать","пятнадцатью"},
        {"шестнадцать","шестнадцатью"},
        {"семнадцать","семнадцатью"},
        {"восемнадцать","восемнадцатью"},
        {"девятнадцать","девятнадцатью"},
        {"двадцать","двадцатью"},
        {"тридцать","тридцатью"},
        {"сорок","сорока"},
        {"пятьдесят","пятидесятью"},
        {"шестьдесят","шестидесятью"},
        {"семьдесят","семидесятью"},
        {"восемьдесят","восьмидесятью"},
        {"девяносто","девяносто"},
        {"сто","ста"},
        {"двести","двумястами"},
        {"триста","тремястами"},
        {"четыреста","четыремястами"},
        {"пятьсот","пятьюстами"},
        {"шестьсот","шестьюстами"},
        {"семьсот","семистами"},
        {"восемьсот","восемьюстами"},
        {"девятьсот","девятьюстами"},
        {"тысяча","тысячей"},
        {"тысячи","тысячами"},
        {"тысяч","тысячами"},
        {"миллион","миллионом"},
        {"миллиона","миллионами"},
        {"миллионов","миллионами"},
        {"миллиард","миллиардом"},
        {"миллиарда","миллиардами"},
        {"миллиардов","миллиардами"},
        {"триллион","триллионом"},
        {"триллиона","триллионами"},
        {"триллионов","триллионами"},
        {"рубль","рублем"},
        {"рубля","рублями"},
        {"рублей","рублями"},
        {"копейка","копейкой"},
        {"копейки","копейками"},
        {"копеек","копейками"}, 
        {"доллар","долларом"},
        {"доллара","долларами"},
        {"долларов","долларами"},
        {"цент","центом"},
        {"цента","центами"},
        {"центов","центами"},
        {"третий", "третьим"},
        {"третья", "третьей"},
        {"третье", "третьим"},
        {"январь", "январем"},
        {"февраль", "февралем"},
        {"март", "мартом"},
        {"апрель", "апрелем"},
        {"май", "маем"},
        {"июнь", "июнем"},
        {"июль", "июлем"},
        {"август", "августом"},
        {"сентябрь", "сентябрем"},
        {"октябрь", "октябрем"},
        {"ноябрь", "ноябрем"},
        {"декабрь", "декабрем"},
        {"год", "годом"},
        {"секунда", "секундой"},
        {"секунды", "секундами"},
        {"секунд", "секундами"},
        {"минута", "минутой"},
        {"минуты", "минутами"},
        {"минут", "минутами"},
        {"час", "часом"},
        {"часа", "часами"},
        {"часов", "часами"},
        {"целых","целыми"},
        {"десятых","десятыми"}
        };

        /// <summary>
        /// Метод-переводчик в творительный падеж из именительного
        /// </summary>
        /// <param name="text">Текст, который необходимо перевести</param>
        /// <returns>Результат перевода</returns>
        public override string Translate(string text)
        {
            if (words.ContainsKey(text))
                return words[text];
            else
                if (Regex.IsMatch(text, @"(ой|ый)$"))
                    return Regex.Replace(text, @"(ой|ый)$", "ым");
                else
                    if (Regex.IsMatch(text, @"(ая)$"))
                        return Regex.Replace(text, @"(ая)$", "ой");
                    else
                        if (Regex.IsMatch(text, @"(ое)$"))
                            return Regex.Replace(text, @"(ое)$", "ым");
                        else
                            return text;
        }
    }

    /// <summary>
    /// Предложный падеж
    /// </summary>
    public class PrepositionalCaseClass : TextCaseClass
    {
        private Dictionary<string, string> words = new Dictionary<string, string>() {
        {"ноль","нуле"},
        {"один","одном"},
        {"одна","одной"},
        {"одно","одном"},
        {"два","двух"},
        {"две","двух"},
        {"три","трёх"},
        {"четыре","четырёх"},
        {"пять","пяти"},
        {"шесть","шести"},
        {"семь","семи"},
        {"восемь","восьми"},
        {"девять","девяти"},
        {"десять","десяти"},
        {"одинадцать","одинадцати"},
        {"двенадцать","двенадцати"},
        {"тринадцать","тринадцати"},
        {"четырнадцать","четырнадцати"},
        {"пятнадцать","пятнадцати"},
        {"шестнадцать","шестнадцати"},
        {"семнадцать","семнадцати"},
        {"восемнадцать","восемнадцати"},
        {"девятнадцать","девятнадцати"},
        {"двадцать","двадцати"},
        {"тридцать","тридцати"},
        {"сорок","сорока"},
        {"пятьдесят","пятидесяти"},
        {"шестьдесят","шестидесяти"},
        {"семьдесят","семидесяти"},
        {"восемьдесят","восьмидесяти"},
        {"девяносто","девяноста"},
        {"сто","ста"},
        {"двести","двухстах"},
        {"триста","трёхстах"},
        {"четыреста","четырёхстах"},
        {"пятьсот","пятистах"},
        {"шестьсот","шестистах"},
        {"семьсот","семистах"},
        {"восемьсот","восьмистах"},
        {"девятьсот","девятистах"},
        {"тысяча","тысяче"},
        {"тысячи","тысячах"},
        {"тысяч","тысячах"},
        {"миллион","миллионе"},
        {"миллиона","миллионах"},
        {"миллионов","миллионах"},
        {"миллиард","миллиарде"},
        {"миллиарда","миллиардах"},
        {"миллиардов","миллиардах"},
        {"триллион","триллионе"},
        {"триллиона","триллионах"},
        {"триллионов","триллионах"},
        {"рубль","рубле"},
        {"рубля","рублях"},
        {"рублей","рублях"},
        {"копейка","копейке"},
        {"копейки","копейках"},
        {"копеек","копейках"}, 
        {"доллар","долларе"},
        {"доллара","долларах"},
        {"долларов","долларах"},
        {"цент","центе"},
        {"цента","центах"},
        {"центов","центах"},
        {"третий", "третьем"},
        {"третья", "третьей"},
        {"третье", "третьем"},
        {"январь", "январе"},
        {"февраль", "феврале"},
        {"март", "марте"},
        {"апрель", "апреле"},
        {"май", "мае"},
        {"июнь", "июне"},
        {"июль", "июле"},
        {"август", "августе"},
        {"сентябрь", "сентябре"},
        {"октябрь", "октябре"},
        {"ноябрь", "ноябре"},
        {"декабрь", "декабре"},
        {"год", "годе"},
        {"секунда", "секунде"},
        {"секунды", "секундах"},
        {"секунд", "секундах"},
        {"минута", "минуте"},
        {"минуты", "минутах"},
        {"минут", "минутах"},
        {"час", "часе"},
        {"часа", "часах"},
        {"часов", "часах"}
        };

        /// <summary>
        /// Метод-переводчик в предложный падеж из именительного
        /// </summary>
        /// <param name="text">Текст, который необходимо перевести</param>
        /// <returns>Результат перевода</returns>
        public override string Translate(string text)
        {
            if (words.ContainsKey(text))
                return words[text];
            else
                if (Regex.IsMatch(text, @"(ой|ый)$"))
                    return Regex.Replace(text, @"(ой|ый)$", "ом");
                else
                    if (Regex.IsMatch(text, @"(ая)$"))
                        return Regex.Replace(text, @"(ая)$", "ой");
                    else
                        if (Regex.IsMatch(text, @"(ое)$"))
                            return Regex.Replace(text, @"(ое)$", "ом");
                        else
                            return text;
        }
    }

    /// <summary>
    /// Класс падежа
    /// </summary>
    public abstract class TextCaseClass
    {
        /// <summary>
        /// Абстрактный метод-переводчик в необходимый падеж из именительного
        /// </summary>
        /// <param name="text">Текст, который необходимо перевести</param>
        /// <returns>Результат перевода</returns>
        public abstract string Translate(string text);
    }
}
