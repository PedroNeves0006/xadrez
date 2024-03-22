using System;
using tabuleiro;
using xadrez;

namespace tabuleiro
{
  class TabuleiroException : Exception
    {
        public TabuleiroException(string msg) : base(msg)
        {
        }
    }
}
