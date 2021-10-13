// Written by bhavani

using System;
using System.Collections.Generic;

    // visitor interface for all the concrete interfaces
    interface IVisitor
    {
        void Visit(Element element);
    }

    // concrete coin visitor
    class PlayVisitor : IVisitor
    {
        public void Visit(Element element)
        {
        ScoreMemento memento = new ScoreMemento();
        ScoreBoard.shared.AddPoints(memento.getCurrentScore() + element.GetPoints());
        }
    }


   // any class that can be visited will subclass this abstract class
    abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    public int GetPoints()
    {
        
        return 2;
    }
    }

    // element sub type to implement Accept for visitor
    class CoinElement : Element
    {
    private int points = 2;

    public int Points { get => points; set => points = value; }


        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
 