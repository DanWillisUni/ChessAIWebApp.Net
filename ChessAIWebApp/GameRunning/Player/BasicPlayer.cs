using ConsoleChess.Model.BoardHelpers;
using ConsoleChess.Pieces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChess.GameRunning.Player
{
    public class BasicPlayer
    {
        public List<Move> getAllMoves(Board b,bool isWhite)
        {
            List<Move> all = new List<Move>();
            List<IPieces> playersPieces = b.getPieces(isWhite);
            foreach(IPieces pieces in playersPieces)
            {
                List<Move> pieceMoves = pieces.getAllMoves(b);
                foreach (Move move in pieceMoves)
                {
                    all.Add(move);
                }
            }
            return all;
        }
    }
}
