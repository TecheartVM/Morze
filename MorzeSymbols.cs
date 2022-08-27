using System.Collections.Generic;

namespace Morze
{
    static class MorzeSymbols
    {
        public static Dictionary<char, string> dictionary = new Dictionary<char, string>();

        static MorzeSymbols()
        {
            dictionary.Add('a', "•-");
            dictionary.Add('b', "-•••");
            dictionary.Add('c', "-•-•");
            dictionary.Add('d', "-••");
            dictionary.Add('e', "•");
            dictionary.Add('f', "••-•");
            dictionary.Add('g', "--•");
            dictionary.Add('h', "••••");
            dictionary.Add('i', "••");
            dictionary.Add('j', "•---");
            dictionary.Add('k', "-•-");
            dictionary.Add('l', "•-••");
            dictionary.Add('m', "--");
            dictionary.Add('n', "-•");
            dictionary.Add('o', "---");
            dictionary.Add('p', "•--•");
            dictionary.Add('q', "--•-");
            dictionary.Add('r', "•-•");
            dictionary.Add('s', "•••");
            dictionary.Add('t', "-");
            dictionary.Add('u', "••-");
            dictionary.Add('v', "•••-");
            dictionary.Add('w', "•--");
            dictionary.Add('x', "-••-");
            dictionary.Add('y', "-•--");
            dictionary.Add('z', "--••");
        }
    }
}
