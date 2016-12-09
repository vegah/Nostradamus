﻿using NostradamusEngine.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NostradamusEngine.Set;

namespace NostradamusEngine.Pieces
{
    public abstract class Piece
    {
        // Ugly
        public readonly  List<Move> Moves;

        protected Piece(Color color, Square square, ChessEngine game)
        {
            Color = color;
            Square = square;
            Game = game;
            Moves = new List<Move>();
        }

        public void Move(Move m)
        {
            Moves.Add(m);
        }

        public void UndoMove(Move m)
        {
            Moves.Remove(m);
        }

        public ChessEngine Game
        {
            get;
            private set;
        }

        public abstract String FullName
        {
            get;
        }

        public abstract String ShortName
        {
            get;
        }

        public abstract IEnumerable<Square> FindCoveredSquares();

        public abstract IEnumerable<Move> CalculateAllMoves(int ply);

        public virtual Move IsLegalMove(Move move, int ply)
        {
            foreach (Move m in CalculateAllMoves(ply))
            {
                if (move == m)
                    return m;
            }
            return null;
        }

        public Square Square
        {
            get;
            set;
        }

        public Color Color { get; private set; }

    }

}
