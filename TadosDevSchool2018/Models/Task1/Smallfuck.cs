using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TadosDevSchool2018.Models.Task1
{
    public class Smallfuck
    {
        public static string Interpreter(string code, string tape)
        {
            //  Думаете сам делал? Неа, жизнь слишком коротка, чтобы програмировать уже запрограммированное
            //  Код взят отсюда https://repl.it/@weylinwagnon/smallfuck и переведён на C#

            var _tape = new bool[tape.Length];
            for (var i = 0; i < tape.Length; i++)
            {
                _tape[i] = int.Parse(tape[i].ToString()) > 0;
            }

            var t = 0;
            var c = 0;
            var op = 0;
            var cl = 0;

            while ((t >= 0 && t < tape.Length) && (c >= 0 && c < code.Length))
            {
                var val = _tape[t];
                var cmd = code[c];

                if (cmd == '>')
                {
                    t++;
                    c++;
                }
                else if (cmd == '<')
                {
                    t--;
                    c++;
                }
                else if (cmd == '*')
                {
                    _tape[t] = !val;
                    c++;
                }
                else if (cmd == '[')
                {
                    c++;
                    if (!val)
                    {
                        c++;
                        while (c < code.Length)
                        {
                            cmd = code[c];
                            if (cmd == ']' && op == 0)
                            {
                                c++;
                                break;
                            }
                            else if (cmd == '[')
                            {
                                op++;
                            }
                            else if (cmd == ']')
                            {
                                op--;
                            }
                            c++;
                        }
                    }
                }
                else if (cmd == ']')
                {
                    if (val)
                    {
                        c--;
                        while (c > 0)
                        {
                            cmd = code[c];
                            if (cmd == '[' && cl == 0)
                            {
                                break;
                            }
                            else if (cmd == ']')
                            {
                                cl++;
                            }
                            else if (cmd == '[')
                            {
                                cl--;
                            }
                            c--;
                        }
                    }
                    else
                    {
                        c++;
                    }
                }
                else
                {
                    c++;
                }
            }

            var output = "";
            for (var i = 0; i < _tape.Length; i++)
            {
                output += _tape[i] ? '1' : '0';
            }
            return output;
        }
    }
}
