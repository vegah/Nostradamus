﻿using NostradamusEngine.Board;
using NostradamusEngine.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NostradamusEngine.Pieces
{
    public class Queen : DirectionalMovingPiece
    {

        public Queen(Boolean isWhite, Square square, ChessEngine game)
            : base(isWhite, square, game)
        {

        }


        public override String FullName
        {
            get
            {
                return "Queen";
            }
        }

        public override String ShortName
        {
            get
            {
                return "Q";
            }
        }

        public override IEnumerable<Rules.Move> CalculateAllMoves()
        {
            List<Rules.Move> allMoves = new List<Move>();

            // Raycast +1 +1
            allMoves.AddRange(CalculateMoveInDirection(1, 0));
            // Raycast +1 -1
            allMoves.AddRange(CalculateMoveInDirection(0, 1));
            // Raycast -1 -1
            allMoves.AddRange(CalculateMoveInDirection(-1, 0));
            // Raycast -1 +1
            allMoves.AddRange(CalculateMoveInDirection(0, -1));
            // Raycast +1 +1
            allMoves.AddRange(CalculateMoveInDirection(1, 1));
            // Raycast +1 -1
            allMoves.AddRange(CalculateMoveInDirection(1, -1));
            // Raycast -1 -1
            allMoves.AddRange(CalculateMoveInDirection(-1, -1));
            // Raycast -1 +1
            allMoves.AddRange(CalculateMoveInDirection(-1, 1));
            return allMoves;
        }

    }
}
